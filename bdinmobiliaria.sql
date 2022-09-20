-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 20-09-2022 a las 22:26:58
-- Versión del servidor: 10.4.24-MariaDB
-- Versión de PHP: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bdinmobiliaria`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `contrato`
--

CREATE TABLE `contrato` (
  `id` int(11) NOT NULL,
  `fecha_desde` date NOT NULL,
  `fecha_hasta` date NOT NULL,
  `monto_alquiler` int(50) NOT NULL,
  `id_inmueble` int(11) NOT NULL,
  `id_inquilino` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `contrato`
--

INSERT INTO `contrato` (`id`, `fecha_desde`, `fecha_hasta`, `monto_alquiler`, `id_inmueble`, `id_inquilino`) VALUES
(1, '2022-09-21', '2022-09-29', 1000, 0, 1),
(2, '2022-09-20', '2022-09-30', 1000, 2, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `inmueble`
--

CREATE TABLE `inmueble` (
  `id` int(11) NOT NULL,
  `direccion` varchar(50) NOT NULL,
  `ambientes` int(50) NOT NULL,
  `superficie` decimal(10,0) NOT NULL,
  `latitud` decimal(10,0) NOT NULL,
  `Longitud` decimal(10,0) NOT NULL,
  `Precio` decimal(10,0) NOT NULL,
  `uso` int(11) NOT NULL,
  `oferta_activa` tinyint(1) NOT NULL,
  `id_propietario` int(11) NOT NULL,
  `id_tipo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `inmueble`
--

INSERT INTO `inmueble` (`id`, `direccion`, `ambientes`, `superficie`, `latitud`, `Longitud`, `Precio`, `uso`, `oferta_activa`, `id_propietario`, `id_tipo`) VALUES
(1, '1570 Pampa', 2, '105', '1510', '120', '12000', 2, 1, 1, 0),
(2, '1570 Pampa', 23, '3242', '324', '324', '423', 1, 1, 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `inquilino`
--

CREATE TABLE `inquilino` (
  `id` int(11) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Apellido` varchar(50) NOT NULL,
  `Dni` int(25) NOT NULL,
  `Telefono` int(25) NOT NULL,
  `Email` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `inquilino`
--

INSERT INTO `inquilino` (`id`, `Nombre`, `Apellido`, `Dni`, `Telefono`, `Email`) VALUES
(1, 'Mauro', 'Gil', 37345367, 26640000, 'mau@gmail.com');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `propietario`
--

CREATE TABLE `propietario` (
  `id` int(11) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Apellido` varchar(50) NOT NULL,
  `Dni` int(25) NOT NULL,
  `Telefono` int(25) NOT NULL,
  `Email` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `propietario`
--

INSERT INTO `propietario` (`id`, `Nombre`, `Apellido`, `Dni`, `Telefono`, `Email`) VALUES
(1, 'Lorenzo', 'Muñoz', 39796666, 2147483647, 'lasd@gmail.com');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_inmueble`
--

CREATE TABLE `tipo_inmueble` (
  `id` int(11) NOT NULL,
  `descripcion` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tipo_inmueble`
--

INSERT INTO `tipo_inmueble` (`id`, `descripcion`) VALUES
(1, 'sfsdf');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `contrato`
--
ALTER TABLE `contrato`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `inmueble`
--
ALTER TABLE `inmueble`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `inquilino`
--
ALTER TABLE `inquilino`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `propietario`
--
ALTER TABLE `propietario`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `tipo_inmueble`
--
ALTER TABLE `tipo_inmueble`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `contrato`
--
ALTER TABLE `contrato`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `inmueble`
--
ALTER TABLE `inmueble`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `inquilino`
--
ALTER TABLE `inquilino`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `propietario`
--
ALTER TABLE `propietario`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `tipo_inmueble`
--
ALTER TABLE `tipo_inmueble`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
