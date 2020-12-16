
USE restaurante

-----------------------------------------------------------------------------------------------


CREATE TABLE `tbl_usuario` (
  `id_usuario` BIGINT(20) UNSIGNED NOT NULL AUTO_INCREMENT,
  `usuario` VARCHAR(20) DEFAULT NULL,
  `contrasenna` VARCHAR(20) DEFAULT NULL,
  `nombre` VARCHAR(30) DEFAULT NULL,
  `cargo` VARCHAR(20) DEFAULT NULL,
  `activo` VARCHAR(1) DEFAULT NULL COMMENT '1=Activo, 0=inactivo',
  `fecha_adicion` DATETIME DEFAULT NULL,
  `fecha_modificacion` DATETIME DEFAULT NULL,
  PRIMARY KEY (`id_usuario`)
) ENGINE=INNODB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4;

-----------------------------------------------------------------------------------------------

SELECT * FROM tbl_usuario

-----------------------------------------------------------------------------------------------

INSERT  INTO `tbl_usuario`(`id_usuario`,`usuario`,`contrasenna`,`nombre`,`cargo`,`activo`,`fecha_adicion`,`fecha_modificacion`) VALUES 
(1,'Marilyn','1','Marilyn','Mesero','0','2020-10-15 22:23:20',NULL),
(2,'Hiram','2','Hiram','mesero','1','2020-10-15 22:31:13',NULL),
(3,'Teñikaler','3','Teñikaler','mesero','1','2020-10-15 22:31:13',NULL),

-----------------------------------------------------------------------------------------------

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insert_tbl_usuario`(IN p_usuario VARCHAR(20),
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

------------------------------------------------------------------------------------------------

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_select_tbl_usuario_todos`()
BEGIN
		SELECT `id_usuario`, `usuario`, `contrasenna`, `nombre`, `cargo`, `activo`, `fecha_adicion`, `fecha_modificacion`
		FROM `tbl_usuario`;
	END $$
DELIMITER ;

------------------------------------------------------------------------------------------------

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_select_tbl_usuario_uno`(IN p_id_usuario VARCHAR(20))
BEGIN
		SELECT `id_usuario`, `usuario`, `contrasenna`, `nombre`, `cargo`, `activo`, `fecha_adicion`, `fecha_modificacion`
		FROM `tbl_usuario`
		WHERE id_usuario = p_id_usuario;
	END $$
DELIMITER ;

------------------------------------------------------------------------------------------------

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_update_tbl_usuario`(IN p_id_usuario VARCHAR(20),
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
DELIMITER;

-----------------------------------------------------------------------------------------------

DELIMITER $$
CREATE PROCEDURE `sp_delete_tbl_usuario`(IN p_id_usuario VARCHAR(20))
BEGIN
 
    SET SQL_SAFE_UPDATES = 0;
    SET @SQL = CONCAT('DELETE FROM ', tbl_usuario );
 
    PREPARE stmt FROM @SQL;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
 
    SET @SQL = CONCAT('ALTER TABLE ', tbl_usuario , ' AUTO_INCREMENT = 1');
 
    PREPARE stmt FROM @SQL;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
 
    SET SQL_SAFE_UPDATES = 1;
 
END
DELIMITER;
-----------------------------------------------------------------------------------------------


CREATE TABLE `tbl_mesa` (
  `numero` VARCHAR(20) DEFAULT NULL,
  `descripcion` VARCHAR(100) DEFAULT NULL,
  `estado` VARCHAR(1) DEFAULT NULL COMMENT 'O=Ocupado, L=Libre',
  `cargo` VARCHAR(20) DEFAULT NULL,
  `activo` VARCHAR(1) DEFAULT NULL COMMENT '1=Activo, 0=inactivo',
  PRIMARY KEY (`numero`)
) ENGINE=INNODB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4;

-----------------------------------------------------------------------------------------------

SELECT * FROM tbl_mesa

-----------------------------------------------------------------------------------------------

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insert_tbl_mesa`(IN p_numero VARCHAR(20),
						    IN p_descripcion VARCHAR(100),
						    IN p_estado VARCHAR(1),
						    IN p_cargo VARCHAR(20),
						    IN p_activo VARCHAR(1))
BEGIN
		INSERT INTO tbl_mesa (numero, descripcion, estado, cargo, activo)
		VALUES (p_numero, p_descripcion, p_estado, p_cargo, p_activo, NOW());
		
		SELECT @@identity AS numero;
		
	END $$
DELIMITER ;

-----------------------------------------------------------------------------------------------

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_select_tbl_mesa_todos`()
BEGIN
		SELECT `numero`, `descripcion`, `estado`,`cargo`, `activo`
		FROM `tbl_mesa`;
	END $$
DELIMITER ;

------------------------------------------------------------------------------------------------

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_select_tbl_mesa_uno`(IN p_numero VARCHAR(20))
BEGIN
		SELECT `numero`, `descripcion`, `estado`, `cargo`, `activo`
		FROM `tbl_mesa`
		WHERE numero = p_numero;
	END $$
DELIMITER ;

------------------------------------------------------------------------------------------------

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_update_tbl_mesa`(IN p_numero VARCHAR(20),
						    IN p_descripcion VARCHAR(20),
						    IN p_estado VARCHAR(20),
						    IN p_cargo VARCHAR(20),
						    IN p_activo VARCHAR(1))
BEGIN
		UPDATE tbl_mesa
		   SET numero     = p_usuario,
		       descripcion = p_contrasenna,
		       estado      = p_nombre,
		       cargo       = p_cargo,
		       activo      = p_activo,
		 WHERE numero = p_numero; 
		 
		 SELECT '1' AS actualizado; 
	END $$
DELIMITER;

-----------------------------------------------------------------------------------------------

DELIMITER $$
CREATE PROCEDURE `sp_delete_tbl_mesa`(IN p_numero VARCHAR(20))
BEGIN
 
    SET SQL_SAFE_UPDATES = 0;
    SET @SQL = CONCAT('DELETE FROM ', tbl_mesa );
 
    PREPARE stmt FROM @SQL;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
 
    SET @SQL = CONCAT('ALTER TABLE ', tbl_mesa , ' AUTO_INCREMENT = 1');
 
    PREPARE stmt FROM @SQL;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
 
    SET SQL_SAFE_UPDATES = 1;
 
END
DELIMITER;

-----------------------------------------------------------------------------------------------