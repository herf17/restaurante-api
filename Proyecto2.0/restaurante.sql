-- phpMyAdmin SQL Dump
-- version 4.6.6deb5
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost:3306
-- Tiempo de generación: 23-10-2020 a las 01:26:13
-- Versión del servidor: 5.7.31-0ubuntu0.18.04.1
-- Versión de PHP: 7.2.24-0ubuntu0.18.04.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `restaurante`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_agregar_usuario` (IN `p_usuario` VARCHAR(100), IN `p_contrasena` VARCHAR(100), IN `p_cargo` VARCHAR(100), IN `p_activo` VARCHAR(100), IN `p_nombre` VARCHAR(100))  NO SQL
INSERT INTO tbl_usuario(tbl_usuario.usuario, tbl_usuario.contrasena, tbl_usuario.nombre, tbl_usuario.cargo, tbl_usuario.activo) 
VALUES(p_usuario,p_contrasena,p_nombre,p_cargo,p_activo)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_eliminar_categoria` (IN `p_id_categoria` INT(3))  NO SQL
DELETE FROM tbl_categoria WHERE tbl_categoria.id_categoria=p_id_categoria$$

CREATE DEFINER=`id14779432_root`@`%` PROCEDURE `sp_insertar_categoria` (IN `p_nombre` VARCHAR(100), IN `p_imagen` VARCHAR(800), IN `p_activo` VARCHAR(100))  NO SQL
INSERT INTO `tbl_categoria` ( `nombre`, `imagen`, `activo`) 
VALUES(`p_nombre`,`p_imagen`,`p_activo`)$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_categoria`
--

CREATE TABLE `tbl_categoria` (
  `id_categoria` int(3) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `imagen` varchar(800) NOT NULL,
  `activo` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_cliente`
--

CREATE TABLE `tbl_cliente` (
  `id_cliente` int(3) NOT NULL,
  `nombre` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `apellido` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `ultima_compra` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `puntos` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_mesa`
--

CREATE TABLE `tbl_mesa` (
  `numero` int(3) NOT NULL,
  `descripcion` varchar(400) NOT NULL,
  `estado` varchar(100) NOT NULL,
  `activo` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_orden_detalle`
--

CREATE TABLE `tbl_orden_detalle` (
  `id_orden` int(3) NOT NULL,
  `id_producto` int(3) NOT NULL,
  `cantidad` int(100) NOT NULL,
  `precio` varchar(3) COLLATE utf8_unicode_ci NOT NULL,
  `total` varchar(3) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_orden_encabezado`
--

CREATE TABLE `tbl_orden_encabezado` (
  `id_orden` int(3) NOT NULL,
  `fecha_hora` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `total` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `id_usuario` varchar(3) COLLATE utf8_unicode_ci NOT NULL,
  `numero_mesa` varchar(3) COLLATE utf8_unicode_ci NOT NULL,
  `id_cliente` varchar(3) COLLATE utf8_unicode_ci NOT NULL,
  `estado` varchar(50) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_producto`
--

CREATE TABLE `tbl_producto` (
  `id_producto` int(3) NOT NULL,
  `descripcion` varchar(400) COLLATE utf8_unicode_ci NOT NULL,
  `precio` varchar(3) COLLATE utf8_unicode_ci NOT NULL,
  `cantidad` varchar(400) COLLATE utf8_unicode_ci NOT NULL,
  `id_categoria` varchar(3) COLLATE utf8_unicode_ci NOT NULL,
  `activo` varchar(100) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_usuario`
--

CREATE TABLE `tbl_usuario` (
  `id_usuario` int(3) NOT NULL,
  `usuario` varchar(100) NOT NULL,
  `contrasena` varchar(100) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `cargo` varchar(100) NOT NULL,
  `activo` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tbl_usuario`
--

INSERT INTO `tbl_usuario` (`id_usuario`, `usuario`, `contrasena`, `nombre`, `cargo`, `activo`) VALUES
(1, 'marilyn', 'marilyn', 'mesa1', 'programador', 'si'),
(2, 'cristal', 'cristal', 'prueba2', 'programador', 'si');


--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `tbl_categoria`
--
ALTER TABLE `tbl_categoria`
  ADD PRIMARY KEY (`id_categoria`);

--
-- Indices de la tabla `tbl_cliente`
--
ALTER TABLE `tbl_cliente`
  ADD PRIMARY KEY (`id_cliente`);

--
-- Indices de la tabla `tbl_mesa`
--
ALTER TABLE `tbl_mesa`
  ADD PRIMARY KEY (`numero`);

--
-- Indices de la tabla `tbl_orden_detalle`
--
ALTER TABLE `tbl_orden_detalle`
  ADD PRIMARY KEY (`id_orden`);

--
-- Indices de la tabla `tbl_orden_encabezado`
--
ALTER TABLE `tbl_orden_encabezado`
  ADD PRIMARY KEY (`id_orden`);

--
-- Indices de la tabla `tbl_producto`
--
ALTER TABLE `tbl_producto`
  ADD PRIMARY KEY (`id_producto`);

--
-- Indices de la tabla `tbl_usuario`
--
ALTER TABLE `tbl_usuario`
  ADD PRIMARY KEY (`id_usuario`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `tbl_categoria`
--
ALTER TABLE `tbl_categoria`
  MODIFY `id_categoria` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `tbl_cliente`
--
ALTER TABLE `tbl_cliente`
  MODIFY `id_cliente` int(3) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `tbl_orden_detalle`
--
ALTER TABLE `tbl_orden_detalle`
  MODIFY `id_orden` int(3) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `tbl_orden_encabezado`
--
ALTER TABLE `tbl_orden_encabezado`
  MODIFY `id_orden` int(3) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `tbl_producto`
--
ALTER TABLE `tbl_producto`
  MODIFY `id_producto` int(3) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `tbl_usuario`
--
ALTER TABLE `tbl_usuario`
  MODIFY `id_usuario` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
