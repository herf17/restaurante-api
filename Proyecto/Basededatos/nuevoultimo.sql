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


-- Volcando estructura de base de datos para restaurante
CREATE DATABASE IF NOT EXISTS `restaurante` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `restaurante`;

-- Volcando estructura para procedimiento restaurante.pa_crear_orden
DELIMITER //
CREATE PROCEDURE `pa_crear_orden`(
			IN tota VARCHAR(20),
			IN idusuario VARCHAR(20),
			IN numeromesa VARCHAR(20),
			IN idcliente VARCHAR(20)
)
BEGIN
	INSERT INTO tbl_orden_encabezado(fecha_hora,total,id_usuario,numero_mesa,id_cliente)
	VALUES(NOW(),tota,idusuario,numeromesa,idcliente);
	
	SELECT @@identity AS id_orden;  
	   
END//
DELIMITER ;

-- Volcando estructura para procedimiento restaurante.pa_insert_orden_detalle
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

-- Volcando estructura para procedimiento restaurante.pa_select_catg_prod
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
DELIMITER //
CREATE PROCEDURE `pa_select_tbl_mesa`()
BEGIN
	SELECT numero, descripcion, estado FROM tbl_mesa WHERE activo = 1;    
END//
DELIMITER ;

-- Volcando estructura para procedimiento restaurante.sp_agregar_usuario
DELIMITER //
CREATE PROCEDURE `sp_agregar_usuario`(IN `p_usuario` VARCHAR(100), IN `p_contrasena` VARCHAR(100), IN `p_nombre` VARCHAR(100), IN `p_cargo` VARCHAR(100), IN `p_activo` VARCHAR(100))
    NO SQL
INSERT INTO tbl_usuario(tbl_usuario.usuario, tbl_usuario.contrasenna, tbl_usuario.nombre, tbl_usuario.cargo, tbl_usuario.activo) 
VALUES(p_usuario,p_contrasenna,p_nombre,p_cargo,p_activo, NOW())//
DELIMITER ;

-- Volcando estructura para procedimiento restaurante.sp_eliminar_categoria
DELIMITER //
CREATE PROCEDURE `sp_eliminar_categoria`(IN `p_id_categoria` INT(3))
    NO SQL
DELETE FROM tbl_categoria WHERE tbl_categoria.id_categoria=p_id_categoria//
DELIMITER ;

-- Volcando estructura para procedimiento restaurante.sp_insertar_categoria
DELIMITER //
CREATE PROCEDURE `sp_insertar_categoria`(IN `p_nombre` VARCHAR(100), IN `p_imagen` VARCHAR(800), IN `p_activo` VARCHAR(100))
    NO SQL
INSERT INTO `tbl_categoria` ( `nombre`, `imagen`, `activo`) 
VALUES(`p_nombre`,`p_imagen`,`p_activo`)//
DELIMITER ;

-- Volcando estructura para tabla restaurante.tbl_categoria
CREATE TABLE IF NOT EXISTS `tbl_categoria` (
  `id_categoria` bigint(20) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(20) NOT NULL,
  `imagen` varchar(20) NOT NULL,
  `activo` varchar(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id_categoria`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla restaurante.tbl_cliente
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
CREATE TABLE IF NOT EXISTS `tbl_mesa` (
  `numero` bigint(20) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(20) NOT NULL COMMENT 'descripcion puede ser la cantidad de puestos que tiene',
  `estado` varchar(1) NOT NULL DEFAULT 'L' COMMENT 'L: para libre, O: para ocupado',
  `activo` varchar(1) NOT NULL DEFAULT '1' COMMENT '1= activo, 0 inactivo',
  PRIMARY KEY (`numero`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1 COMMENT='Tabla mesas del restaurante';

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla restaurante.tbl_orden_detalle
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
CREATE TABLE IF NOT EXISTS `tbl_orden_encabezado` (
  `id_orden` bigint(20) NOT NULL AUTO_INCREMENT,
  `fecha_hora` datetime NOT NULL,
  `total` varchar(50) NOT NULL,
  `id_usuario` int(3) NOT NULL,
  `numero_mesa` varchar(3) NOT NULL,
  `id_cliente` bigint(11) NOT NULL DEFAULT 0,
  `estado` varchar(50) NOT NULL DEFAULT 'P',
  PRIMARY KEY (`id_orden`),
  KEY `id_cliente` (`id_cliente`,`id_usuario`),
  KEY `FK_tbl_orden_encabezado_tbl_usuario` (`id_usuario`),
  CONSTRAINT `FK_tbl_orden_encabezado_tbl_cliente` FOREIGN KEY (`id_cliente`) REFERENCES `tbl_cliente` (`id_cliente`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_tbl_orden_encabezado_tbl_usuario` FOREIGN KEY (`id_usuario`) REFERENCES `tbl_usuario` (`id_usuario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla restaurante.tbl_producto
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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
