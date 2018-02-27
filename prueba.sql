-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 27-02-2018 a las 05:27:58
-- Versión del servidor: 10.1.19-MariaDB
-- Versión de PHP: 5.6.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `prueba`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empaque`
--

CREATE TABLE `empaque` (
  `No_serie` varchar(11) NOT NULL,
  `mac_address` varchar(12) NOT NULL,
  `fecha` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `empaque`
--

INSERT INTO `empaque` (`No_serie`, `mac_address`, `fecha`) VALUES
('BZR3203M023', '748EF8D0F160', '2018-02-06 02:40:29'),
('BZR3203M022', 'CC4E2474BBC0', '2018-02-06 02:37:39'),
('BZR3203M023', 'CE4E245D5560', '2018-02-06 02:41:51');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `informacion`
--

CREATE TABLE `informacion` (
  `No_serie` varchar(11) NOT NULL,
  `modelo` varchar(17) NOT NULL,
  `pais_origen` varchar(2) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `ciudad` varchar(6) NOT NULL DEFAULT 'juarez',
  `fecha` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `informacion`
--

INSERT INTO `informacion` (`No_serie`, `modelo`, `pais_origen`, `cantidad`, `ciudad`, `fecha`) VALUES
('BZR3203M022', 'ICX6450-24P', 'MX', 3, '', '0000-00-00 00:00:00'),
('BZR3203M023', 'ICX6450-24P', 'MX', -2, '', '0000-00-00 00:00:00'),
('BZR3203M042', 'ICX6430-48', 'EU', 4, '', '0000-00-00 00:00:00'),
('DUQ2560M00X', '7250-24P-2XG10', 'US', 8, 'juarez', '0000-00-00 00:00:00'),
('DUQ2560M00Y', '7250-48P-2XG10', 'CN', 5, '', '0000-00-00 00:00:00'),
('DUQ2560M00Z', '7250-24P-2XG10', 'US', 2, 'juarez', '0000-00-00 00:00:00'),
('DUQ2660M00Z', '7250-24P', 'US', 6, 'juarez', '0000-00-00 00:00:00'),
('DUQ3205M00H', '7250-48', 'MX', 3, 'juarez', '2018-02-08 03:07:33'),
('DUQ4203M00H', '7250-48P', 'CN', 3, 'juarez', '2018-02-08 03:06:07');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `empaque`
--
ALTER TABLE `empaque`
  ADD UNIQUE KEY `mac_address` (`mac_address`),
  ADD KEY `No_serie` (`No_serie`);

--
-- Indices de la tabla `informacion`
--
ALTER TABLE `informacion`
  ADD PRIMARY KEY (`No_serie`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `empaque`
--
ALTER TABLE `empaque`
  ADD CONSTRAINT `empaque_ibfk_1` FOREIGN KEY (`No_serie`) REFERENCES `informacion` (`No_serie`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
