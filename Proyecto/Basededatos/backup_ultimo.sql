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
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbl_cliente` */

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
  `total` varchar(3) NOT NULL,
  PRIMARY KEY (`id_orden`),
  KEY `FK_tbl_orden_detalle_tbl_productos` (`id_producto`),
  CONSTRAINT `FK_tbl_orden_detalle_tbl_producto` FOREIGN KEY (`id_producto`) REFERENCES `tbl_producto` (`id_producto`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbl_orden_detalle` */

/*Table structure for table `tbl_orden_encabezado` */

DROP TABLE IF EXISTS `tbl_orden_encabezado`;

CREATE TABLE `tbl_orden_encabezado` (
  `id_orden` bigint(20) NOT NULL AUTO_INCREMENT,
  `fecha_hora` varchar(10) NOT NULL,
  `total` varchar(50) NOT NULL,
  `id_usuario` int(3) NOT NULL,
  `numero_mesa` varchar(3) NOT NULL,
  `id_cliente` bigint(11) NOT NULL,
  `estado` varchar(50) NOT NULL,
  PRIMARY KEY (`id_orden`),
  KEY `id_cliente` (`id_cliente`,`id_usuario`),
  KEY `FK_tbl_orden_encabezado_tbl_usuario` (`id_usuario`),
  CONSTRAINT `FK_tbl_orden_encabezado_tbl_cliente` FOREIGN KEY (`id_cliente`) REFERENCES `tbl_cliente` (`id_cliente`) ON DELETE CASCADE ON UPDATE CASCADE,
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
  `activo` varchar(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id_producto`),
  KEY `FK_tbl_producto_tbl_categoria` (`id_categoria`),
  CONSTRAINT `FK_tbl_producto_tbl_categoria` FOREIGN KEY (`id_categoria`) REFERENCES `tbl_categoria` (`id_categoria`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_producto` */

insert  into `tbl_producto`(`id_producto`,`descripcion`,`precio`,`id_categoria`,`activo`) values 
(1,'Sancocho','3.99',1,'1'),
(2,'Caldo de pollo','3.99',1,'1'),
(3,'Sopa de carne','3.99',1,'1'),
(4,'Gaseosa','1.00',2,'1'),
(5,'BBQ Grill','0.80',3,'1'),
(6,'Chuleta','4.50',3,'1'),
(7,'Pollo Asado','4.00',3,'1'),
(8,'Costillas','8.00',3,'0');

/*Table structure for table `tbl_usuario` */

DROP TABLE IF EXISTS `tbl_usuario`;

CREATE TABLE `tbl_usuario` (
  `id_usuario` int(3) NOT NULL AUTO_INCREMENT,
  `usuario` varchar(100) NOT NULL,
  `contrasena` varchar(100) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `cargo` varchar(100) NOT NULL,
  `activo` varchar(1) NOT NULL COMMENT '1=Activo, 0=inactivo',
  `fecha_adicion` datetime NOT NULL,
  `fecha_modificacion` datetime NOT NULL,
  PRIMARY KEY (`id_usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbl_usuario` */

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

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_agregar_usuario`(IN `p_usuario` VARCHAR(100), IN `p_contrasena` VARCHAR(100), IN `p_nombre` VARCHAR(100), IN `p_cargo` VARCHAR(100), IN `p_activo` VARCHAR(100))
    NO SQL
INSERT INTO tbl_usuario(tbl_usuario.usuario, tbl_usuario.contrasenna, tbl_usuario.nombre, tbl_usuario.cargo, tbl_usuario.activo) 
VALUES(p_usuario,p_contrasenna,p_nombre,p_cargo,p_activo, NOW()) */$$
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

/*!50003 CREATE DEFINER=`id14779432_root`@`%` PROCEDURE `sp_insertar_categoria`(IN `p_nombre` VARCHAR(100), IN `p_imagen` VARCHAR(800), IN `p_activo` VARCHAR(100))
    NO SQL
INSERT INTO `tbl_categoria` ( `nombre`, `imagen`, `activo`) 
VALUES(`p_nombre`,`p_imagen`,`p_activo`) */$$
DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
