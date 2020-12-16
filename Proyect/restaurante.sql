
USE restaurante


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

SELECT * FROM tbl_usuario


-----------------------------------------------------------------------------------------------


CREATE TABLE `tbl_mesa` (
  `numero` VARCHAR(20) DEFAULT NULL,
  `descripcion` VARCHAR(100) DEFAULT NULL,
  `estado` VARCHAR(1) DEFAULT NULL COMMENT 'O=Ocupado, L=Libre',
  `cargo` VARCHAR(20) DEFAULT NULL,
  `activo` VARCHAR(1) DEFAULT NULL COMMENT '1=Activo, 0=inactivo',
  PRIMARY KEY (`numero`)
) ENGINE=INNODB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4;

SELECT * FROM tbl_mesa

