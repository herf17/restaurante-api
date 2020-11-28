/*
SQLyog Community v13.1.7 (64 bit)
MySQL - 5.7.24 : Database - restaurante
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`restaurante` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `restaurante`;

/*Table structure for table `tbl_categoria` */

DROP TABLE IF EXISTS `tbl_categoria`;

CREATE TABLE `tbl_categoria` (
  `id_categoria` bigint(20) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(20) NOT NULL,
  `imagen` varchar(20) NOT NULL,
  `activo` varchar(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id_categoria`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_categoria` */

insert  into `tbl_categoria`(`id_categoria`,`nombre`,`imagen`,`activo`) values 
(1,'Sopas y cremas','imagen/sopa.png','1'),
(2,'Bebidas','imagen/bebida.png','1'),
(3,'Parrillas','imagen/parrilla.png','1'),
(4,'Platos fuertes','imagen/platosfue','0'),
(5,'Espaguettis','imagen/spaguetti.png','0');

/*Table structure for table `tbl_cliente` */

DROP TABLE IF EXISTS `tbl_cliente`;

CREATE TABLE `tbl_cliente` (
  `id_cliente` bigint(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `apellido` varchar(100) NOT NULL,
  `ultima_compra` varchar(100) NOT NULL,
  `puntos` int(3) NOT NULL,
  PRIMARY KEY (`id_cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_cliente` */

insert  into `tbl_cliente`(`id_cliente`,`nombre`,`apellido`,`ultima_compra`,`puntos`) values 
(4,'ubaldo','Smith','111',100);

/*Table structure for table `tbl_mesa` */

DROP TABLE IF EXISTS `tbl_mesa`;

CREATE TABLE `tbl_mesa` (
  `numero` bigint(20) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(20) NOT NULL COMMENT 'descripcion puede ser la cantidad de puestos que tiene',
  `estado` varchar(1) NOT NULL DEFAULT 'L' COMMENT 'L: para libre, O: para ocupado',
  `activo` varchar(1) NOT NULL DEFAULT '1' COMMENT '1= activo, 0 inactivo',
  PRIMARY KEY (`numero`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1 COMMENT='Tabla mesas del restaurante';

/*Data for the table `tbl_mesa` */

insert  into `tbl_mesa`(`numero`,`descripcion`,`estado`,`activo`) values 
(1,'4','L','1'),
(2,'6','L','1'),
(3,'2','O','1'),
(4,'8','O','1'),
(5,'5','L','1'),
(6,'6','L','0');

/*Table structure for table `tbl_orden_detalle` */

DROP TABLE IF EXISTS `tbl_orden_detalle`;

CREATE TABLE `tbl_orden_detalle` (
  `id_orden` bigint(20) NOT NULL,
  `id_producto` bigint(20) NOT NULL,
  `cantidad` int(100) NOT NULL,
  `precio` varchar(20) NOT NULL,
  `total` float NOT NULL DEFAULT '0',
  PRIMARY KEY (`id_orden`,`id_producto`),
  KEY `FK_tbl_orden_detalle_tbl_productos` (`id_producto`),
  CONSTRAINT `FK_tbl_orden_detalle_tbl_orden_encabezado` FOREIGN KEY (`id_orden`) REFERENCES `tbl_orden_encabezado` (`id_orden`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_tbl_orden_detalle_tbl_producto` FOREIGN KEY (`id_producto`) REFERENCES `tbl_producto` (`id_producto`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbl_orden_detalle` */

/*Table structure for table `tbl_orden_encabezado` */

DROP TABLE IF EXISTS `tbl_orden_encabezado`;

CREATE TABLE `tbl_orden_encabezado` (
  `id_orden` bigint(20) NOT NULL AUTO_INCREMENT,
  `fecha_hora` datetime NOT NULL,
  `total` varchar(50) NOT NULL,
  `id_usuario` int(3) NOT NULL,
  `numero_mesa` bigint(20) NOT NULL,
  `id_cliente` bigint(11) NOT NULL DEFAULT '0',
  `estado` varchar(50) NOT NULL DEFAULT 'P',
  PRIMARY KEY (`id_orden`),
  KEY `id_cliente` (`id_cliente`,`id_usuario`),
  KEY `FK_tbl_orden_encabezado_tbl_usuario` (`id_usuario`),
  KEY `FK_tbl_orden_encabezado_tbl_mesa` (`numero_mesa`),
  CONSTRAINT `FK_tbl_orden_encabezado_tbl_cliente` FOREIGN KEY (`id_cliente`) REFERENCES `tbl_cliente` (`id_cliente`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_tbl_orden_encabezado_tbl_mesa` FOREIGN KEY (`numero_mesa`) REFERENCES `tbl_mesa` (`numero`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_tbl_orden_encabezado_tbl_usuario` FOREIGN KEY (`id_usuario`) REFERENCES `tbl_usuario` (`id_usuario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbl_orden_encabezado` */

/*Table structure for table `tbl_producto` */

DROP TABLE IF EXISTS `tbl_producto`;

CREATE TABLE `tbl_producto` (
  `id_producto` bigint(20) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(20) NOT NULL,
  `precio` varchar(20) NOT NULL,
  `id_categoria` bigint(20) NOT NULL,
  `cantidad` int(100) NOT NULL,
  `activo` varchar(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id_producto`),
  KEY `FK_tbl_producto_tbl_categoria` (`id_categoria`),
  CONSTRAINT `FK_tbl_producto_tbl_categoria` FOREIGN KEY (`id_categoria`) REFERENCES `tbl_categoria` (`id_categoria`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_producto` */

insert  into `tbl_producto`(`id_producto`,`descripcion`,`precio`,`id_categoria`,`cantidad`,`activo`) values 
(1,'Carne de Sopa','5.00',1,5,'1');

/* Procedure structure for procedure `pa_agregar_puntos` */

/*!50003 DROP PROCEDURE IF EXISTS  `pa_agregar_puntos` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `pa_agregar_puntos`(
	IN `idorden` VARCHAR(20)
)
BEGIN
DECLARE puntosTotales INT;
SET puntosTotales = CEILING((SELECT cl.puntos FROM tbl_cliente cl INNER JOIN tbl_orden_encabezado oe ON oe.id_cliente =cl.id_cliente WHERE oe.id_orden=idorden)+(SELECT total FROM tbl_orden_encabezado WHERE id_orden = idorden));
	UPDATE tbl_cliente
	SET
		puntos = puntosTotales,
		ultima_compra = NOW()
	WHERE id_cliente = (SELECT id_cliente FROM tbl_orden_encabezado WHERE id_orden = idorden);
END */$$
DELIMITER ;

/* Procedure structure for procedure `pa_anular_orden` */

/*!50003 DROP PROCEDURE IF EXISTS  `pa_anular_orden` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `pa_anular_orden`(
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
		WHERE numero = (SELECT numero_mesa FROM tbl_orden_encabezado WHERE id_orden = idorden);
END */$$
DELIMITER ;

/* Procedure structure for procedure `pa_cambio_estado_orden` */

/*!50003 DROP PROCEDURE IF EXISTS  `pa_cambio_estado_orden` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `pa_cambio_estado_orden`(
			IN codmesa VARCHAR(20)
			
)
BEGIN
	UPDATE tbl_orden_encabezado
	SET 
		estado = "E"
	WHERE 
		numero_mesa = codmesa AND estado = "P";
END */$$
DELIMITER ;

/* Procedure structure for procedure `pa_comprobar_puntos` */

/*!50003 DROP PROCEDURE IF EXISTS  `pa_comprobar_puntos` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `pa_comprobar_puntos`(
	IN `cod` VARCHAR(20)
)
BEGIN
	SELECT nombre, apellido, puntos, ultima_compra FROM tbl_cliente WHERE id_cliente = cod;
END */$$
DELIMITER ;

/* Procedure structure for procedure `pa_crear_orden` */

/*!50003 DROP PROCEDURE IF EXISTS  `pa_crear_orden` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `pa_crear_orden`(
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
	   
END */$$
DELIMITER ;

/* Procedure structure for procedure `pa_end_orden` */

/*!50003 DROP PROCEDURE IF EXISTS  `pa_end_orden` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `pa_end_orden`(
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
	WHERE numero = (SELECT numero_mesa FROM tbl_orden_encabezado WHERE id_orden = idorden);
	SELECT idorden AS id_orden; 
END */$$
DELIMITER ;

/* Procedure structure for procedure `pa_insert_orden_detalle` */

/*!50003 DROP PROCEDURE IF EXISTS  `pa_insert_orden_detalle` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `pa_insert_orden_detalle`(
			IN idorden VARCHAR(20),
			IN idproducto VARCHAR(20),
			IN cantidad VARCHAR(20),
			IN precio VARCHAR(20),
			IN total VARCHAR(20)
)
BEGIN
	INSERT INTO tbl_orden_detalle
	VALUES(idorden,idproducto,cantidad,precio,total);  
END */$$
DELIMITER ;

/* Procedure structure for procedure `pa_productos_enorden` */

/*!50003 DROP PROCEDURE IF EXISTS  `pa_productos_enorden` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `pa_productos_enorden`(
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
END */$$
DELIMITER ;

/* Procedure structure for procedure `pa_select_catg_prod` */

/*!50003 DROP PROCEDURE IF EXISTS  `pa_select_catg_prod` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `pa_select_catg_prod`(
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
END */$$
DELIMITER ;

/* Procedure structure for procedure `pa_select_orden_catg` */

/*!50003 DROP PROCEDURE IF EXISTS  `pa_select_orden_catg` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `pa_select_orden_catg`()
BEGIN
	SELECT 
		id_categoria, 
		nombre, 
		imagen
	FROM
		tbl_categoria
	WHERE activo = "1";    
END */$$
DELIMITER ;

/* Procedure structure for procedure `pa_select_tbl_mesa` */

/*!50003 DROP PROCEDURE IF EXISTS  `pa_select_tbl_mesa` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `pa_select_tbl_mesa`()
BEGIN
	SELECT numero, descripcion, estado FROM tbl_mesa WHERE activo = 1;    
END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_agregar_usuario` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_agregar_usuario` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_agregar_usuario`(IN `p_usuario` VARCHAR(100), 
								 IN `p_contrasena` VARCHAR(100), 
								 IN `p_nombre` VARCHAR(100), 
								 IN `p_cargo` VARCHAR(100), 
								 IN `p_activo` VARCHAR(100))
    NO SQL
INSERT INTO tbl_usuario(tbl_usuario.usuario, tbl_usuario.contrasena, tbl_usuario.nombre, tbl_usuario.cargo, tbl_usuario.activo) 
VALUES(p_usuario,p_contrasena,p_nombre,p_cargo,p_activo, NOW()) */$$
DELIMITER ;

/* Procedure structure for procedure `sp_eliminar_categoria` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_eliminar_categoria` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_eliminar_categoria`(IN `p_id_categoria` INT(3))
    NO SQL
DELETE FROM tbl_categoria WHERE tbl_categoria.id_categoria=p_id_categoria */$$
DELIMITER ;

/* Procedure structure for procedure `sp_insertar_categoria` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_insertar_categoria` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insertar_categoria`(IN `p_nombre` VARCHAR(100), IN `p_imagen` VARCHAR(800), IN `p_activo` VARCHAR(100))
    NO SQL
INSERT INTO `tbl_categoria` ( `nombre`, `imagen`, `activo`) 
VALUES(`p_nombre`,`p_imagen`,`p_activo`) */$$
DELIMITER ;

/* Procedure structure for procedure `sp_insert_tbl_usuario` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_insert_tbl_usuario` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insert_tbl_usuario`(in p_usuario varchar(20),
						    IN p_contrasenna varchar(20),
						    in p_nombre varchar(30),
						    in p_cargo varchar(20),
						    in p_activo varchar(1))
BEGIN
		insert into tbl_usuario (usuario, contrasenna, nombre, cargo, activo, fecha_adicion)
		values (p_usuario, p_contrasenna, p_nombre, p_cargo, p_activo, now());
		
		select @@identity as id_usuario;
		
	END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_select_reporte_de_mesa` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_select_reporte_de_mesa` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_select_reporte_de_mesa`()
BEGIN
		SELECT numero, descripcion, estado, activo FROM tbl_mesa WHERE activo = 1;  
	END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_select_reporte_de_ordenes` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_select_reporte_de_ordenes` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_select_reporte_de_ordenes`()
BEGIN
		SELECT orden.id_orden,
		orden.fecha_hora,
		orden.total,
		usuario.nombre,
		mesa.numero,
		clie.nombre,
		orden.estado,
	
		clie.apellido
		
		
		FROM tbl_orden_encabezado orden
		JOIN tbl_mesa mesa
		JOIN tbl_cliente clie
		JOIN tbl_usuario usuario
				
		ON mesa.numero = orden.numero_mesa;
		# ON clie.id_cliente = orden.id_cliente
		# ON usuario.id_usuario = orden.id_usuario
	END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_select_reporte_de_producto` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_select_reporte_de_producto` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_select_reporte_de_producto`()
BEGIN
	  SELECT prod.id_producto,
		prod.descripcion,
		prod.precio,
		prod.id_categoria,
		prod.activo,
		prod.cantidad,
		
		cate.id_categoria,
		cate.nombre
		
		FROM tbl_producto prod
		JOIN tbl_categoria cate
				
		ON cate.id_categoria = prod.id_producto; 
	END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_select_reporte_de_ventas` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_select_reporte_de_ventas` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_select_reporte_de_ventas`()
BEGIN
		SELECT id_orden, cantidad, total FROM tbl_orden_detalle; 
	END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_select_tbl_usuario_todos` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_select_tbl_usuario_todos` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_select_tbl_usuario_todos`()
BEGIN
		select `id_usuario`, `usuario`, `contrasenna`, `nombre`, `cargo`, `activo`, `fecha_adicion`, `fecha_modificacion`
		from `tbl_usuario`;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_select_tbl_usuario_uno` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_select_tbl_usuario_uno` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_select_tbl_usuario_uno`(IN p_id_usuario varchar(20))
BEGIN
		select `id_usuario`, `usuario`, `contrasenna`, `nombre`, `cargo`, `activo`, `fecha_adicion`, `fecha_modificacion`
		from `tbl_usuario`
		where id_usuario = p_id_usuario;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_tbl_categoria_insert` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_tbl_categoria_insert` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_tbl_categoria_insert`(IN p_nombre VARCHAR(20), 
						      IN p_imagen VARCHAR(20), 
						      IN p_activo VARCHAR(1))
BEGIN
		INSERT INTO `tbl_categoria` ( `nombre`, `imagen`, `activo`) 
		VALUES(p_nombre, p_imagen, p_activo );
		SELECT @@identity AS id_categoria;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_tbl_categoria_select` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_tbl_categoria_select` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_tbl_categoria_select`()
BEGIN
		SELECT `id_categoria`, `nombre`, `imagen`, `activo` FROM `tbl_categoria`;    
	END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_tbl_categoria_select_uno` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_tbl_categoria_select_uno` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_tbl_categoria_select_uno`(IN p_id_categoria VARCHAR(20))
BEGIN
		SELECT `id_categoria`, `nombre`, `imagen`, activo
		FROM `tbl_categoria`
		WHERE `id_categoria` = p_id_categoria;

	END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_tbl_categoria_update` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_tbl_categoria_update` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_tbl_categoria_update`(IN p_id_categoria VARCHAR(20),
					 IN p_nombre VARCHAR(20),
					 IN p_imagen VARCHAR(20),
					 IN p_activo VARCHAR(1))
BEGIN
		
		UPDATE `tbl_categoria`
		   SET nombre      = p_nombre,
		       imagen       = p_imagen,
		       activo      = p_activo
		 WHERE id_categoria = p_id_categoria; 
		 
		 SELECT '1' AS actualizado; 
	END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_tbl_cliente_insert` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_tbl_cliente_insert` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_tbl_cliente_insert`(IN p_nombre VARCHAR(100), 
					            IN p_apellido VARCHAR(100), 
						    IN p_ultima_compra VARCHAR(100),
						    IN p_puntos VARCHAR(3))
BEGIN
		INSERT INTO `tbl_cliente` ( `nombre`, `apellido`, `ultima_compra`, `puntos`) 
		VALUES( p_nombre, p_apellido, p_ultima_compra,  p_puntos );
		
		select @@identity as id_cliente;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_tbl_cliente_select` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_tbl_cliente_select` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_tbl_cliente_select`()
BEGIN
		SELECT `id_cliente`, `nombre`, `apellido`, `ultima_compra`, `puntos`  FROM `tbl_cliente`;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_tbl_cliente_select_uno` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_tbl_cliente_select_uno` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_tbl_cliente_select_uno`(IN p_id_cliente VARCHAR(11))
BEGIN
		SELECT `id_cliente`, `nombre`, `apellido`,`ultima_compra`, `puntos`
		FROM `tbl_cliente`
		WHERE `id_cliente` = p_id_cliente;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_tbl_cliente_update` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_tbl_cliente_update` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_tbl_cliente_update`(IN p_id_cliente VARCHAR(11),
					 IN p_nombre VARCHAR(100),
					 IN p_apellido VARCHAR(100),
					 IN p_ultima_compra VARCHAR(100),
					 IN p_puntos VARCHAR(3))
BEGIN
		UPDATE `tbl_cliente`
		   SET nombre        = p_nombre,
		       apellido      = p_apellido,
		       ultima_compra = p_ultima_compra,
		       puntos        = p_puntos
		 WHERE id_cliente  = p_id_cliente; 
		 
		 SELECT '1' AS actualizado;  
	END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_tbl_productos_insert` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_tbl_productos_insert` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_tbl_productos_insert`(IN p_descripcion VARCHAR(20), 
					              IN p_precio VARCHAR(20), 
						      IN p_id_categoria VARCHAR(20),
						      IN p_cantidad VARCHAR(100),
						      IN p_activo VARCHAR(1))
BEGIN
		INSERT INTO `tbl_producto` ( `descripcion`, `precio`, `id_categoria`, `cantidad`, `activo`) 
		VALUES( p_descripcion, p_precio, p_id_categoria, p_cantidad, p_activo );
		select @@identity as id_producto;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_tbl_productos_select` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_tbl_productos_select` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_tbl_productos_select`()
BEGIN
		SELECT id_producto,
		descripcion,
		precio,
		id_categoria,
		cantidad,
		activo
		
		FROM tbl_producto;
		
	END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_tbl_productos_select_uno` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_tbl_productos_select_uno` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_tbl_productos_select_uno`(IN p_id_producto VARCHAR(20))
BEGIN
		SELECT id_producto, descripcion, precio, id_categoria, cantidad, activo
		FROM tbl_producto
		WHERE id_producto = p_id_producto;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_tbl_productos_update` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_tbl_productos_update` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_tbl_productos_update`(IN p_id_producto VARCHAR(20),
					 IN p_descripcion VARCHAR(20),
					 IN p_precio VARCHAR(20),
					 IN p_id_categoria VARCHAR(20),
					 IN p_cantidad VARCHAR(20),
					 IN p_activo VARCHAR(1))
BEGIN
		UPDATE `tbl_producto`
		   SET descripcion  = p_descripcion,
		       precio       = p_precio,
		       id_categoria = p_id_categoria,
		       cantidad     = p_cantidad,
		       activo       = p_activo
		 WHERE id_producto  = p_id_producto; 
		 
		 SELECT '1' AS actualizado; 
	END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_update_tbl_usuario` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_update_tbl_usuario` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_update_tbl_usuario`(in p_id_usuario varchar(20),
						    IN p_usuario VARCHAR(20),
						    IN p_contrasena VARCHAR(20),
						    IN p_nombre VARCHAR(30),
						    IN p_cargo VARCHAR(20),
						    IN p_activo VARCHAR(1))
BEGIN
		update tbl_usuario 
		   set usuario     = p_usuario,
		       contrasena = p_contrasena,
		       nombre      = p_nombre,
		       cargo       = p_cargo,
		       activo      = p_activo ,
		       fecha_modificacion = now()
		 where id_usuario = p_id_usuario; 
		 
		 select '1' as actualizado; 
	END */$$
DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
