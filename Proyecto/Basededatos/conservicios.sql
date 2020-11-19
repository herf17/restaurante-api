-- --------------------------------------------------------
-- Host:                         
-- Versión del servidor:         10.4.14-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win64
-- HeidiSQL Versión:             11.1.0.6116
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

-- Volcando estructura para procedimiento restaurante.pa_agregar_puntos
DROP PROCEDURE IF EXISTS `pa_agregar_puntos`;
DELIMITER //
CREATE PROCEDURE `pa_agregar_puntos`(
	IN `idorden` VARCHAR(20)
)
BEGIN
DECLARE puntosTotales INT;
SET puntosTotales = CEILING((SELECT cl.puntos FROM tbl_cliente cl INNER JOIN tbl_orden_encabezado oe ON oe.id_cliente =cl.id_cliente WHERE oe.id_orden=idorden)+(SELECT total FROM tbl_orden_encabezado WHERE id_orden = idorden));
	UPDATE tbl_cliente
	SET
		puntos = puntosTotales,
		ultima_compra = NOW()
	WHERE id_cliente = (SELECT tbc.id_cliente FROM tbl_orden_encabezado ore INNER JOIN tbl_cliente tbc ON ore.id_cliente = tbc.id_cliente  WHERE ore.id_orden = idorden);
END//
DELIMITER ;

-- Volcando estructura para procedimiento restaurante.pa_anular_orden
DROP PROCEDURE IF EXISTS `pa_anular_orden`;
DELIMITER //
CREATE PROCEDURE `pa_anular_orden`(
	IN `idorden` VARCHAR(20)
)
BEGIN
	UPDATE tbl_orden_encabezado
	SET
		estado = "A"
	WHERE id_orden = idorden;
	
	UPDATE tbl_mesa
	SET
		estado = "L"
		WHERE numero = (SELECT m.numero FROM tbl_mesa m INNER JOIN tbl_orden_encabezado o ON m.numero = o.numero_mesa WHERE o.id_orden = idorden);
END//
DELIMITER ;

-- Volcando estructura para procedimiento restaurante.pa_cambio_estado_orden
DROP PROCEDURE IF EXISTS `pa_cambio_estado_orden`;
DELIMITER //
CREATE PROCEDURE `pa_cambio_estado_orden`(
			IN codmesa VARCHAR(20)
			
)
BEGIN
	UPDATE tbl_orden_encabezado
	SET 
		estado = "E"
	WHERE 
		numero_mesa = codmesa AND estado = "P";
END//
DELIMITER ;

-- Volcando estructura para procedimiento restaurante.pa_comprobar_puntos
DROP PROCEDURE IF EXISTS `pa_comprobar_puntos`;
DELIMITER //
CREATE PROCEDURE `pa_comprobar_puntos`(
	IN `cod` VARCHAR(20)
)
BEGIN
	SELECT nombre, apellido, puntos, ultima_compra FROM tbl_cliente WHERE id_cliente = cod;
END//
DELIMITER ;

-- Volcando estructura para procedimiento restaurante.pa_crear_orden
DROP PROCEDURE IF EXISTS `pa_crear_orden`;
DELIMITER //
CREATE PROCEDURE `pa_crear_orden`(
	IN `tota` VARCHAR(20),
	IN `idusuario` VARCHAR(20),
	IN `numeromesa` VARCHAR(20),
	IN `idcliente` VARCHAR(20)
)
BEGIN
	INSERT INTO tbl_orden_encabezado(fecha_hora,total,id_usuario,numero_mesa,id_cliente)
	VALUES(NOW(),tota,idusuario,numeromesa,idcliente);
	UPDATE tbl_mesa
	SET
		estado = "O"
	WHERE numero = numeromesa;
	
	SELECT @@identity AS id_orden;  
	   
END//
DELIMITER ;

-- Volcando estructura para procedimiento restaurante.pa_end_orden
DROP PROCEDURE IF EXISTS `pa_end_orden`;
DELIMITER //
CREATE PROCEDURE `pa_end_orden`(
	IN `idorden` VARCHAR(20)
)
BEGIN
	UPDATE tbl_orden_encabezado
	SET 
		estado = "C"
	WHERE id_orden = idorden;
	
	UPDATE tbl_mesa 
	SET
		estado = "L"
	WHERE numero = (SELECT me.numero FROM tbl_mesa me INNER JOIN tbl_orden_encabezado oe  ON me.numero = oe.numero_mesa  WHERE oe.id_orden = idorden);
	SELECT idorden AS id_orden; 
END//
DELIMITER ;

-- Volcando estructura para procedimiento restaurante.pa_insert_orden_detalle
DROP PROCEDURE IF EXISTS `pa_insert_orden_detalle`;
DELIMITER //
CREATE PROCEDURE `pa_insert_orden_detalle`(
			IN idorden VARCHAR(20),
			IN idproducto VARCHAR(20),
			IN cantidad VARCHAR(20),
			IN precio VARCHAR(20),
			IN total VARCHAR(20)
)
BEGIN
	INSERT INTO tbl_orden_detalle
	VALUES(idorden,idproducto,cantidad,precio,total);  
END//
DELIMITER ;

-- Volcando estructura para procedimiento restaurante.pa_productos_enorden
DROP PROCEDURE IF EXISTS `pa_productos_enorden`;
DELIMITER //
CREATE PROCEDURE `pa_productos_enorden`(
			IN codmesa VARCHAR(20)
			
)
BEGIN
	SELECT prod.descripcion, ordet.cantidad
	FROM 
		tbl_producto prod
	INNER JOIN tbl_orden_detalle ordet
		ON ordet.id_producto = prod.id_producto
	INNER JOIN tbl_orden_encabezado ordenca
		ON ordenca.id_orden = ordet.id_orden
	WHERE
		ordenca.numero_mesa = codmesa AND ordenca.estado ="P";
END//
DELIMITER ;

-- Volcando estructura para procedimiento restaurante.pa_select_catg_prod
DROP PROCEDURE IF EXISTS `pa_select_catg_prod`;
DELIMITER //
CREATE PROCEDURE `pa_select_catg_prod`(
			IN id_categ VARCHAR(20)
)
BEGIN
	SELECT 
		id_producto, 
		descripcion, 
		precio,
    activo
	FROM
		tbl_producto
	WHERE id_categoria =id_categ AND activo = "1";    
END//
DELIMITER ;

-- Volcando estructura para procedimiento restaurante.pa_select_orden_catg
DROP PROCEDURE IF EXISTS `pa_select_orden_catg`;
DELIMITER //
CREATE PROCEDURE `pa_select_orden_catg`()
BEGIN
	SELECT 
		id_categoria, 
		nombre, 
		imagen
	FROM
		tbl_categoria
	WHERE activo = "1";    
END//
DELIMITER ;

-- Volcando estructura para procedimiento restaurante.pa_select_tbl_mesa
DROP PROCEDURE IF EXISTS `pa_select_tbl_mesa`;
DELIMITER //
CREATE PROCEDURE `pa_select_tbl_mesa`()
BEGIN
	SELECT numero, descripcion, estado FROM tbl_mesa WHERE activo = 1;    
END//
DELIMITER ;

-- Volcando estructura para procedimiento restaurante.sp_agregar_usuario
DROP PROCEDURE IF EXISTS `sp_agregar_usuario`;
DELIMITER //
CREATE PROCEDURE `sp_agregar_usuario`(IN `p_usuario` VARCHAR(100), IN `p_contrasena` VARCHAR(100), IN `p_nombre` VARCHAR(100), IN `p_cargo` VARCHAR(100), IN `p_activo` VARCHAR(100))
    NO SQL
INSERT INTO tbl_usuario(tbl_usuario.usuario, tbl_usuario.contrasenna, tbl_usuario.nombre, tbl_usuario.cargo, tbl_usuario.activo) 
VALUES(p_usuario,p_contrasenna,p_nombre,p_cargo,p_activo, NOW())//
DELIMITER ;

-- Volcando estructura para procedimiento restaurante.sp_eliminar_categoria
DROP PROCEDURE IF EXISTS `sp_eliminar_categoria`;
DELIMITER //
CREATE PROCEDURE `sp_eliminar_categoria`(IN `p_id_categoria` INT(3))
    NO SQL
DELETE FROM tbl_categoria WHERE tbl_categoria.id_categoria=p_id_categoria//
DELIMITER ;

-- Volcando estructura para procedimiento restaurante.sp_insertar_categoria
DROP PROCEDURE IF EXISTS `sp_insertar_categoria`;
DELIMITER //
CREATE PROCEDURE `sp_insertar_categoria`(IN `p_nombre` VARCHAR(100), IN `p_imagen` VARCHAR(800), IN `p_activo` VARCHAR(100))
    NO SQL
INSERT INTO `tbl_categoria` ( `nombre`, `imagen`, `activo`) 
VALUES(`p_nombre`,`p_imagen`,`p_activo`)//
DELIMITER ;

-- Volcando estructura para tabla restaurante.tbl_categoria
DROP TABLE IF EXISTS `tbl_categoria`;
CREATE TABLE IF NOT EXISTS `tbl_categoria` (
  `id_categoria` bigint(20) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(20) NOT NULL,
  `imagen` varchar(20) NOT NULL,
  `activo` varchar(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id_categoria`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla restaurante.tbl_cliente
DROP TABLE IF EXISTS `tbl_cliente`;
CREATE TABLE IF NOT EXISTS `tbl_cliente` (
  `id_cliente` bigint(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `apellido` varchar(100) NOT NULL,
  `ultima_compra` varchar(100) NOT NULL,
  `puntos` int(3) NOT NULL,
  PRIMARY KEY (`id_cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla restaurante.tbl_mesa
DROP TABLE IF EXISTS `tbl_mesa`;
CREATE TABLE IF NOT EXISTS `tbl_mesa` (
  `numero` bigint(20) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(20) NOT NULL COMMENT 'descripcion puede ser la cantidad de puestos que tiene',
  `estado` varchar(1) NOT NULL DEFAULT 'L' COMMENT 'L: para libre, O: para ocupado',
  `activo` varchar(1) NOT NULL DEFAULT '1' COMMENT '1= activo, 0 inactivo',
  PRIMARY KEY (`numero`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1 COMMENT='Tabla mesas del restaurante';

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla restaurante.tbl_orden_detalle
DROP TABLE IF EXISTS `tbl_orden_detalle`;
CREATE TABLE IF NOT EXISTS `tbl_orden_detalle` (
  `id_orden` bigint(20) NOT NULL,
  `id_producto` bigint(20) NOT NULL,
  `cantidad` int(100) NOT NULL,
  `precio` varchar(20) NOT NULL,
  `total` float NOT NULL DEFAULT 0,
  PRIMARY KEY (`id_orden`,`id_producto`),
  KEY `FK_tbl_orden_detalle_tbl_productos` (`id_producto`),
  CONSTRAINT `FK_tbl_orden_detalle_tbl_orden_encabezado` FOREIGN KEY (`id_orden`) REFERENCES `tbl_orden_encabezado` (`id_orden`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_tbl_orden_detalle_tbl_producto` FOREIGN KEY (`id_producto`) REFERENCES `tbl_producto` (`id_producto`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla restaurante.tbl_orden_encabezado
DROP TABLE IF EXISTS `tbl_orden_encabezado`;
CREATE TABLE IF NOT EXISTS `tbl_orden_encabezado` (
  `id_orden` bigint(20) NOT NULL AUTO_INCREMENT,
  `fecha_hora` datetime NOT NULL,
  `total` varchar(50) NOT NULL,
  `id_usuario` int(3) NOT NULL,
  `numero_mesa` bigint(20) NOT NULL,
  `id_cliente` bigint(11) NOT NULL DEFAULT 0,
  `estado` varchar(50) NOT NULL DEFAULT 'P',
  PRIMARY KEY (`id_orden`),
  KEY `id_cliente` (`id_cliente`,`id_usuario`),
  KEY `FK_tbl_orden_encabezado_tbl_usuario` (`id_usuario`),
  KEY `FK_tbl_orden_encabezado_tbl_mesa` (`numero_mesa`),
  CONSTRAINT `FK_tbl_orden_encabezado_tbl_cliente` FOREIGN KEY (`id_cliente`) REFERENCES `tbl_cliente` (`id_cliente`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_tbl_orden_encabezado_tbl_mesa` FOREIGN KEY (`numero_mesa`) REFERENCES `tbl_mesa` (`numero`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_tbl_orden_encabezado_tbl_usuario` FOREIGN KEY (`id_usuario`) REFERENCES `tbl_usuario` (`id_usuario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla restaurante.tbl_producto
DROP TABLE IF EXISTS `tbl_producto`;
CREATE TABLE IF NOT EXISTS `tbl_producto` (
  `id_producto` bigint(20) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(20) NOT NULL,
  `precio` varchar(20) NOT NULL,
  `id_categoria` bigint(20) NOT NULL,
  `activo` varchar(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id_producto`),
  KEY `FK_tbl_producto_tbl_categoria` (`id_categoria`),
  CONSTRAINT `FK_tbl_producto_tbl_categoria` FOREIGN KEY (`id_categoria`) REFERENCES `tbl_categoria` (`id_categoria`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla restaurante.tbl_usuario
DROP TABLE IF EXISTS `tbl_usuario`;
CREATE TABLE IF NOT EXISTS `tbl_usuario` (
  `id_usuario` int(3) NOT NULL AUTO_INCREMENT,
  `usuario` varchar(100) NOT NULL,
  `contrasena` varchar(100) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `cargo` varchar(100) NOT NULL,
  `activo` varchar(1) NOT NULL COMMENT '1=Activo, 0=inactivo',
  `fecha_adicion` datetime NOT NULL,
  `fecha_modificacion` datetime NOT NULL,
  PRIMARY KEY (`id_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
