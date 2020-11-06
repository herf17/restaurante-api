CREATE DATABASE IF NOT EXISTS restaurante;

/*Tablas de pruebas*/
/*Tabla mesas*/
CREATE TABLE `tbl_mesa` (
	`numero` BIGINT(20) NOT NULL AUTO_INCREMENT,
	`descripcion` VARCHAR(20) NOT NULL COMMENT 'descripcion puede ser la cantidad de puestos que tiene',
	`estado` VARCHAR(1) NOT NULL DEFAULT 'L' COMMENT 'L: para libre, O: para ocupado',
	`activo` VARCHAR(1) NOT NULL DEFAULT '1' COMMENT '1= activo, 0 inactivo',
	PRIMARY KEY (`numero`)
)
COMMENT='Tabla mesas del restaurante'
;

/*Tabla categorias*/
CREATE TABLE `tbl_categoria` (
	`id_categoria` BIGINT(20) NOT NULL AUTO_INCREMENT,
	`nombre` VARCHAR(20) NOT NULL,
	`imagen` VARCHAR(20) NOT NULL,
	`activo` VARCHAR(1) NOT NULL DEFAULT '1',
	PRIMARY KEY (`id_categoria`)
);

/*Tabla productos*/
CREATE TABLE `tbl_producto` (
	`id_producto` BIGINT(20) NOT NULL AUTO_INCREMENT,
	`descripcion` VARCHAR(20) NOT NULL,
	`precio` VARCHAR(20) NOT NULL,
	`id_categoria` BIGINT(20) NOT NULL,
	`activo` VARCHAR(1) NOT NULL DEFAULT '1',
	PRIMARY KEY (`id_producto`),
	INDEX `FK_tbl_producto_tbl_categoria` (`id_categoria`),
	CONSTRAINT `FK_tbl_producto_tbl_categoria` FOREIGN KEY (`id_categoria`) REFERENCES `restaurante`.`tbl_categoria` (`id_categoria`) ON UPDATE CASCADE ON DELETE CASCADE
);




/*Valores de prueba*/
INSERT INTO tbl_mesa(descripcion,estado,activo) VALUES("4",DEFAULT,DEFAULT);
INSERT INTO tbl_mesa(descripcion,estado,activo) VALUES("6",DEFAULT,DEFAULT);
INSERT INTO tbl_mesa(descripcion,estado,activo) VALUES("2","O",DEFAULT);         
INSERT INTO tbl_mesa(descripcion,estado,activo) VALUES("8","O",DEFAULT);
INSERT INTO tbl_mesa(descripcion,estado,activo) VALUES("5",DEFAULT,DEFAULT);
INSERT INTO tbl_mesa(descripcion,estado,activo) VALUES("6",DEFAULT,0);
SELECT * FROM tbl_mesa;


INSERT INTO tbl_categoria(nombre,imagen,activo) VALUES("Sopas y cremas","imagen/sopa.png",DEFAULT);
INSERT INTO tbl_categoria(nombre,imagen,activo) VALUES("Bebidas","imagen/bebida.png",DEFAULT);   
INSERT INTO tbl_categoria(nombre,imagen,activo) VALUES("Parrillas","imagen/parrilla.png",DEFAULT);
INSERT INTO tbl_categoria(nombre,imagen,activo) VALUES("Platos fuertes","imagen/platosfue","0");
INSERT INTO tbl_categoria(nombre,imagen,activo) VALUES("Espaguettis","imagen/spaguetti.png","0");
SELECT * FROM tbl_categoria;

INSERT INTO tbl_producto(descripcion,precio,id_categoria,activo) VALUES("Sancocho","3.99",1,DEFAULT);
INSERT INTO tbl_producto(descripcion,precio,id_categoria,activo) VALUES("Caldo de pollo","3.99",1,DEFAULT);
INSERT INTO tbl_producto(descripcion,precio,id_categoria,activo) VALUES("Sopa de carne","3.99",1,DEFAULT);
INSERT INTO tbl_producto(descripcion,precio,id_categoria,activo) VALUES("Gaseosa","1.00",2,DEFAULT);
INSERT INTO tbl_producto(descripcion,precio,id_categoria,activo) VALUES("BBQ Grill","0.80",3,DEFAULT);
INSERT INTO tbl_producto(descripcion,precio,id_categoria,activo) VALUES("Chuleta","4.50",3,DEFAULT);
INSERT INTO tbl_producto(descripcion,precio,id_categoria,activo) VALUES("Pollo Asado","4.00",3,DEFAULT);
INSERT INTO tbl_producto(descripcion,precio,id_categoria,activo) VALUES("Costillas","8.00",3,"0");
SELECT * FROM tbl_producto;

/*Procedimientos*/
/*select busca mesa*/
DELIMITER $$

CREATE PROCEDURE pa_select_tbl_mesa()
BEGIN
	SELECT numero, descripcion, estado FROM tbl_mesa WHERE activo = 1;    
END$$
DELIMITER ;
/*Fin creacion procedimiento*/
CALL pa_select_tbl_mesa();

/*select busca categoria en pantalla agregar orden*/
DELIMITER $$

CREATE PROCEDURE pa_select_orden_catg()
BEGIN
	SELECT 
		id_categoria, 
		nombre, 
		imagen
	FROM
		tbl_categoria
	WHERE activo = "1";    
END$$
DELIMITER ;
/*Fin creacion procedimiento*/
CALL pa_select_orden_catg();
/*------------------------------------------------------------------------*/
/*Select busca producto filtrado por categoria*/
DELIMITER $$

CREATE PROCEDURE pa_select_catg_prod(
			IN id_categ VARCHAR(20)
)
BEGIN
	SELECT 
		id_producto, 
		descripcion, 
		preciorestaurante
	FROM
		tbl_producto
	WHERE id_categoria =id_categ AND activo = "1";    
END$$
DELIMITER ;
/*Fin creacion procedimiento*/
CALL pa_select_catg_prod("3");
