
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

CREATE TABLE `tbl_tipo_de_usuario`(
  `id` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=INNODB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

LOCK TABLES `tbl_tipo_de_usuario` WRITE;
INSERT INTO `tbl_tipo_de_usuario` VALUES (1,'Administrador'),(2,'Usuario');
UNLOCK TABLES;

INSERT INTO `tbl_usuario` (`id_usuario`, `usuario`, `contrasena`, `nombre`, `cargo`, `activo`) VALUES
(1, 'marilyn', '123' , 'Marilyn', 'programador', 'si'),
(2, 'cristal', '1234' , 'Cristal', 'programador', 'si');

ALTER TABLE `tbl_usuario`
  ADD PRIMARY KEY (`id_usuario`);
  
  ALTER TABLE `tbl_usuario`
  MODIFY `id_usuario` INT(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

SELECT * FROM tbl_tipo_de_usuario
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
  CONSTRAINT `fk_usuario_tipo` FOREIGN KEY (`id_tipo`) REFERENCES `tbl_tipo_usuario` (`id`)
) ENGINE=INNODB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `tbl_tipo_de_usuario`(
  `id` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=INNODB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

LOCK TABLES `tbl_tipo_usuario` WRITE;
INSERT INTO `tbl_tipo_usuario` VALUES (1,'Administrador'),(2,'Usuario');
UNLOCK TABLES;

INSERT INTO `tbl_usuario` (`id_usuario`, `usuario`, `contrasena`, `nombre`, `cargo`, `activo`) VALUES
(1, 'marilyn', '123' , 'Marilyn', 'programador', 'si'),
(2, 'cristal', '1234' , 'Cristal', 'programador', 'si');

ALTER TABLE `tbl_usuario`
  ADD PRIMARY KEY (`id_usuario`);
  
  ALTER TABLE `tbl_usuario`
  MODIFY `id_usuario` INT(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

SELECT * FROM tbl_tipo_usuario


DROP TABLE tbl_tipo_de_usuario
