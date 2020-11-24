
/*--------------------------------------------------------------------*/
/*--------------------------------------------------------------------*/
/* Requerimientos de Tabla usuario*/

CREATE TABLE `tbl_usuario` (
  `id_usuario` INT(3) NOT NULL,
  `usuario` VARCHAR(100) NOT NULL,
  `contrasena` VARCHAR(100) NOT NULL,
  `nombre` VARCHAR(100) NOT NULL,
  `cargo` VARCHAR(100) NOT NULL,
  `activo` VARCHAR(100) NOT NULL,
  `id_tipo` INT NOT NULL,
  PRIMARY KEY (`id_usuario`),
  KEY `fk_usuario_tipo_idx` (`id_tipo`),
  CONSTRAINT `fk_usuario_tipo` FOREIGN KEY (`id_tipo`) REFERENCES `tbl_tipo_de_usuario` (`id`)
) ENGINE=INNODB DEFAULT CHARSET=utf8mb4;

ALTER TABLE `tbl_usuario`
  ADD PRIMARY KEY (`id_usuario`);
  
ALTER TABLE `tbl_usuario`
  MODIFY `id_usuario` INT(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
  
/* Insersión de tabla usuario*/

INSERT INTO `tbl_usuario` (`id_usuario`, `usuario`, `contrasena`, `nombre`, `cargo`, `activo`) VALUES
(1, 'marilyn', '123' , 'Marilyn', 'programador', 'si'),
(2, 'cristal', '1234' , 'Cristal', 'programador', 'si');

/* procedimiento para la tabla usuario*/

DELIMITER $$

CREATE DEFINER=`root`@`localhost` 
PROCEDURE `sp_insert_tbl_usuario`
(IN p_usuario VARCHAR(20),
IN p_contrasenna VARCHAR(20),
IN p_nombre VARCHAR(30),
IN p_cargo VARCHAR(20),
IN p_activo VARCHAR(1))
BEGIN
INSERT INTO tbl_usuario (usuario, contrasenna, nombre, cargo, activo, fecha_adicion)
VALUES (p_usuario, p_contrasenna, p_nombre, p_cargo, p_activo, NOW());
		
SELECT @@identity AS id_usuario;
		
END $$
DELIMITER ;

/* Procedimiento para la tabla usuario seleccionar todos` */

DROP PROCEDURE IF EXISTS  `sp_select_tbl_usuario_todos` */;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` 
PROCEDURE `sp_select_tbl_usuario_todos`()
BEGIN
SELECT `id_usuario`, `usuario`, `contrasenna`, `nombre`, `cargo`, `activo`, `fecha_adicion`, `fecha_modificacion`
FROM `tbl_usuario`;
	END $$
DELIMITER ;

/* Procedimiento de la tabla usuario seleccionar uno` */

DELIMITER $$

CREATE DEFINER=`root`@`localhost` 
PROCEDURE `sp_select_tbl_usuario_uno`(IN p_id_usuario VARCHAR(20))
BEGIN
SELECT `id_usuario`, `usuario`, `contrasenna`, `nombre`, `cargo`, `activo`, `fecha_adicion`, `fecha_modificacion`
FROM `tbl_usuario`
WHERE id_usuario = p_id_usuario;
	END $$
DELIMITER ;


DELIMITER $$

/* Procedimiento de la tabla usuario actualizar` */

DELIMITER $$
CREATE DEFINER=`root`@`localhost` 
PROCEDURE `sp_update_tbl_usuario`
(IN p_id_usuario VARCHAR(20),
IN p_usuario VARCHAR(20),
IN p_contrasenna VARCHAR(20),
IN p_nombre VARCHAR(30),
IN p_cargo VARCHAR(20),
IN p_activo VARCHAR(1))
BEGIN
UPDATE tbl_usuario 
SET usuario     = p_usuario,
		       contrasenna = p_contrasenna,
		       nombre      = p_nombre,
		       cargo       = p_cargo,
		       activo      = p_activo ,
		       fecha_modificacion = NOW()
WHERE id_usuario = p_id_usuario; 
		 
SELECT '1' AS actualizado; 
	END $$
DELIMITER ;

/*--------------------------------------------------------------------*/
/*--------------------------------------------------------------------*/
/* Requerimientos de Tabla tipo de usuario*/

CREATE TABLE `tbl_tipo_usuario`(
  `id` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=INNODB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

/* Insersión de tabla tipo de usuario*/

LOCK TABLES `tbl_tipo_usuario` WRITE;
INSERT INTO `tbl_tipo_usuario` VALUES (1,'Administrador'),(2,'Usuario');
UNLOCK TABLES;

/*--------------------------------------------------------------------*/
/*--------------------------------------------------------------------*/

SELECT * FROM tbl_tipo_usuario

/*--------------------------------------------------------------------*/



