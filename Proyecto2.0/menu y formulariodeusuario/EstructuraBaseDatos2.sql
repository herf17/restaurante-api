/*
SQLyog Community v13.1.6 (64 bit)
MySQL - 10.4.11-MariaDB : Database - restaurante
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`restaurante` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

USE `restaurante`;

/*Table structure for table `tbl_usuario` */

DROP TABLE IF EXISTS `tbl_usuario`;

CREATE TABLE `tbl_usuario` (
  `id_usuario` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `usuario` varchar(20) DEFAULT NULL,
  `contrasenna` varchar(20) DEFAULT NULL,
  `nombre` varchar(30) DEFAULT NULL,
  `cargo` varchar(20) DEFAULT NULL,
  `activo` varchar(1) DEFAULT NULL COMMENT '1=Activo, 0=inactivo',
  `fecha_adicion` datetime DEFAULT NULL,
  `fecha_modificacion` datetime DEFAULT NULL,
  PRIMARY KEY (`id_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4;

/*Data for the table `tbl_usuario` */

insert  into `tbl_usuario`(`id_usuario`,`usuario`,`contrasenna`,`nombre`,`cargo`,`activo`,`fecha_adicion`,`fecha_modificacion`) values 
(1,'pperez','466789','Pedro Perez E.','Gerente','1','2020-09-30 20:01:37','2020-09-30 20:11:58'),
(2,'pperez','12345667','Pedro Perez','Gerente','1','2020-09-30 20:03:37',NULL),
(3,'pperez','12345667','Pedro Perez','Gerente','1','2020-09-30 20:03:43',NULL),
(4,'pperez','12345667','Pedro Perez','Gerente','1','2020-09-30 20:04:38',NULL),
(5,'pperez','12345667','Pedro Perez','Gerente','1','2020-09-30 20:05:59',NULL),
(6,'mperez','123213123123','Maria Perez','Mesera','1','2020-09-30 20:45:52',NULL),
(7,'234234','234','234','23434','1','2020-09-30 20:48:33',NULL),
(8,'asdas','808','998','098098','1','2020-09-30 20:52:04',NULL);

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

/* Procedure structure for procedure `sp_update_tbl_usuario` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_update_tbl_usuario` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_update_tbl_usuario`(in p_id_usuario varchar(20),
						    IN p_usuario VARCHAR(20),
						    IN p_contrasenna VARCHAR(20),
						    IN p_nombre VARCHAR(30),
						    IN p_cargo VARCHAR(20),
						    IN p_activo VARCHAR(1))
BEGIN
		update tbl_usuario 
		   set usuario     = p_usuario,
		       contrasenna = p_contrasenna,
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
