-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 29-07-2019 a las 03:50:49
-- Versión del servidor: 10.1.37-MariaDB
-- Versión de PHP: 7.3.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `cine`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `asientos`
--

CREATE TABLE `asientos` (
  `idAsiento` varchar(5) COLLATE utf8mb4_bin NOT NULL,
  `idSala` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `asientos`
--

INSERT INTO `asientos` (`idAsiento`, `idSala`) VALUES
('A-1', 1),
('A-1', 2),
('A-1', 3),
('A-1', 4),
('A-1', 5),
('A-10', 1),
('A-10', 2),
('A-10', 3),
('A-10', 4),
('A-10', 5),
('A-2', 1),
('A-2', 2),
('A-2', 3),
('A-2', 4),
('A-2', 5),
('A-3', 1),
('A-3', 2),
('A-3', 3),
('A-3', 4),
('A-3', 5),
('A-4', 1),
('A-4', 2),
('A-4', 3),
('A-4', 4),
('A-4', 5),
('A-5', 1),
('A-5', 2),
('A-5', 3),
('A-5', 4),
('A-5', 5),
('A-6', 1),
('A-6', 2),
('A-6', 3),
('A-6', 4),
('A-6', 5),
('A-7', 1),
('A-7', 2),
('A-7', 3),
('A-7', 4),
('A-7', 5),
('A-8', 1),
('A-8', 2),
('A-8', 3),
('A-8', 4),
('A-8', 5),
('A-9', 1),
('A-9', 2),
('A-9', 3),
('A-9', 4),
('A-9', 5);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bitacora`
--

CREATE TABLE `bitacora` (
  `noReg` int(11) NOT NULL,
  `Usuario` varchar(45) COLLATE utf8mb4_bin DEFAULT NULL,
  `Accion` varchar(20) COLLATE utf8mb4_bin NOT NULL,
  `Afectado` varchar(45) COLLATE utf8mb4_bin NOT NULL,
  `Operacion` text COLLATE utf8mb4_bin NOT NULL,
  `ipAddress` varchar(45) COLLATE utf8mb4_bin DEFAULT NULL,
  `Fecha` date DEFAULT NULL,
  `Hora` time DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `boletos`
--

CREATE TABLE `boletos` (
  `idBoleto` int(11) NOT NULL,
  `idFuncion` int(11) DEFAULT NULL,
  `idAsiento` varchar(5) COLLATE utf8mb4_bin DEFAULT NULL,
  `Fecha` date DEFAULT NULL,
  `Cine` varchar(45) COLLATE utf8mb4_bin DEFAULT NULL,
  `tipoBoleto` varchar(45) COLLATE utf8mb4_bin DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cines`
--

CREATE TABLE `cines` (
  `idCine` int(11) NOT NULL,
  `idCiudad` int(11) DEFAULT NULL,
  `nombreCine` varchar(45) COLLATE utf8mb4_bin DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `cines`
--

INSERT INTO `cines` (`idCine`, `idCiudad`, `nombreCine`) VALUES
(1, 1, 'Portales'),
(2, 1, 'Miraflores'),
(3, 1, 'Naranjo'),
(4, 2, 'Plaza Americas'),
(5, 3, 'Interplaza');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ciudades`
--

CREATE TABLE `ciudades` (
  `idCiudad` int(11) NOT NULL,
  `nombreCiudad` varchar(255) COLLATE utf8mb4_bin DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `ciudades`
--

INSERT INTO `ciudades` (`idCiudad`, `nombreCiudad`) VALUES
(1, 'Guatemala'),
(2, 'Quetzaltenango'),
(3, 'Xela');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clasificacion`
--

CREATE TABLE `clasificacion` (
  `idClasificacion` int(11) NOT NULL,
  `clasificacion` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `detalle` text COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `clasificacion`
--

INSERT INTO `clasificacion` (`idClasificacion`, `clasificacion`, `detalle`) VALUES
(1, 'A', 'para todo el publico'),
(2, 'B', 'para adolescentes de 12 años en adelante'),
(3, 'B15', 'no recomendable para menores de 15 años de edad'),
(4, 'C', 'para adultos de 18 años en adelante'),
(5, 'D', 'peliculas para adultos, con sexo explícito, lenguaje procaz o alto grado de violencia'),
(6, 'R', 'Restricted, reserva el visionado de una película exhibida en salas cinematográficas a los mayores de 17 años, o a los menores de esa edad que acudan acompañados de un adulto.');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detallefactura`
--

CREATE TABLE `detallefactura` (
  `numeroLinea` int(11) NOT NULL,
  `numeroFactura` int(11) NOT NULL,
  `idBoleto` int(11) DEFAULT NULL,
  `idFuncion` int(11) NOT NULL,
  `Costo` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detallereservacion`
--

CREATE TABLE `detallereservacion` (
  `numeroLinea` int(11) NOT NULL,
  `idReservasion` int(11) NOT NULL,
  `idFuncion` int(11) NOT NULL,
  `idAsiento` varchar(5) COLLATE utf8mb4_bin DEFAULT NULL,
  `tipoBoleto` varchar(45) COLLATE utf8mb4_bin DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `encabezadosfactura`
--

CREATE TABLE `encabezadosfactura` (
  `numeroFactura` int(11) NOT NULL,
  `fechaFactura` date DEFAULT NULL,
  `Cine` varchar(45) COLLATE utf8mb4_bin NOT NULL,
  `Funcion` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `funciones`
--

CREATE TABLE `funciones` (
  `idFuncion` int(11) NOT NULL,
  `idPelicula` int(11) DEFAULT NULL,
  `idSala` int(11) DEFAULT NULL,
  `cine` varchar(45) COLLATE utf8mb4_bin NOT NULL,
  `horaFuncion` time DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `funciones`
--

INSERT INTO `funciones` (`idFuncion`, `idPelicula`, `idSala`, `cine`, `horaFuncion`) VALUES
(6, 2, 5, 'Portales', '16:05:00'),
(7, 2, 1, 'Naranjo', '11:00:00'),
(9, 3, 4, 'Portales', '16:50:00'),
(10, 2, 3, 'Interplaza', '16:00:00'),
(11, 2, 4, 'Plaza Americas', '13:00:00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `multimedia`
--

CREATE TABLE `multimedia` (
  `NoRegistro` int(10) NOT NULL,
  `Afiche` varchar(255) COLLATE utf8mb4_bin NOT NULL,
  `Trailer` varchar(255) COLLATE utf8mb4_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `multimedia`
--

INSERT INTO `multimedia` (`NoRegistro`, `Afiche`, `Trailer`) VALUES
(1, 'Multimedia/Reyleon.png', 'https://www.youtube.com/watch?v=BfSAvH2fGkE&pbjreload=10'),
(2, 'Multimedia/Spiderman.jpg', 'https://www.youtube.com/watch?v=s1OxOBPWBeU'),
(3, 'Multimedia/HotelMumbai.jpg', 'https://www.youtube.com/watch?v=td03ewyR9LI');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `peliculas`
--

CREATE TABLE `peliculas` (
  `idPelicula` int(11) NOT NULL,
  `Titulo` varchar(255) COLLATE utf8mb4_bin DEFAULT NULL,
  `Multimedia` int(5) NOT NULL,
  `Formato` varchar(45) COLLATE utf8mb4_bin DEFAULT NULL,
  `Clasificación` varchar(45) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `Sinopsis` text COLLATE utf8mb4_bin NOT NULL,
  `Duracion` varchar(45) COLLATE utf8mb4_bin DEFAULT NULL,
  `semanaEstrenoInicio` date DEFAULT NULL,
  `semanaEstrenoFin` date DEFAULT NULL,
  `Usuario` varchar(45) COLLATE utf8mb4_bin DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `peliculas`
--

INSERT INTO `peliculas` (`idPelicula`, `Titulo`, `Multimedia`, `Formato`, `Clasificación`, `Sinopsis`, `Duracion`, `semanaEstrenoInicio`, `semanaEstrenoFin`, `Usuario`) VALUES
(2, 'Spider-Man: Lejos de casa', 1, '3D', 'B', 'Peter Parker regresa en Spider-Man: Lejos de casa el siguiente capítulo en la serie de Spider-Man: Homecoming. Nuestro amistoso vecino superhéroe decide unirse a sus mejores amigos Ned, MJ, y el resto del grupo a unas vacaciones europeas. Aunque, el plan de Peter sea dejar sus heroicidades atrás durante unas pocas semanas, pronto desecha esas ideas para ayudar a regañadientes a Nick Furia a desentrañar el misterio de los ataques de varias criaturas elementales, que están creando el caos en el mundo', '1 hora 30 minutos', '2019-07-07', '2019-07-14', 'rchocm'),
(3, 'Hotel Mumbai', 1, '3D', 'B15', 'Una apasionante historia sobre humanidad y heroísmo, HOTEL MUMBAI cuenta vividamente el cerco de 2008 al Taj Hotel por un grupo de terroristas en Mumbai, India. Entre el personal del hotel se encuentra el renombrado chef Hemant Oberoi (Anupam Kher) y un camarero (Dev Patel) quienes eligen arriesgar sus vidas para proteger a los huéspedes, Mientras la situación avanza, una pareja desesperada (Armie Hammer y Nazanin Boniadi) se ve obligada hacer sacrificios impensables para proteger a su hijo recién nacido.', '1 hora 30 minutos', '2019-07-14', '2019-07-21', 'gus657'),
(4, 'Prueba', 1, NULL, 'A', '', NULL, NULL, NULL, 'gus657');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfiles`
--

CREATE TABLE `perfiles` (
  `idPerfil` int(11) NOT NULL,
  `Tipo` varchar(45) COLLATE utf8mb4_bin DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `perfiles`
--

INSERT INTO `perfiles` (`idPerfil`, `Tipo`) VALUES
(1, 'administrador');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reservaciones`
--

CREATE TABLE `reservaciones` (
  `idReservasion` int(11) NOT NULL,
  `idFuncion` int(11) DEFAULT NULL,
  `Fecha` date DEFAULT NULL,
  `Cine` varchar(45) COLLATE utf8mb4_bin DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `salas`
--

CREATE TABLE `salas` (
  `idSala` int(11) NOT NULL,
  `idCine` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `salas`
--

INSERT INTO `salas` (`idSala`, `idCine`) VALUES
(1, 1),
(2, 4),
(3, 5),
(4, 3),
(5, 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `timer`
--

CREATE TABLE `timer` (
  `noRegistro` int(11) NOT NULL,
  `Tiempo` time NOT NULL,
  `Fecha` date NOT NULL,
  `Usuario` varchar(45) COLLATE utf8mb4_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `timer`
--

INSERT INTO `timer` (`noRegistro`, `Tiempo`, `Fecha`, `Usuario`) VALUES
(1, '01:00:00', '2019-07-27', 'gus657');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tiposboleto`
--

CREATE TABLE `tiposboleto` (
  `idBoleto` int(11) NOT NULL,
  `Tipo` varchar(100) COLLATE utf8mb4_bin NOT NULL,
  `Precio` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `tiposboleto`
--

INSERT INTO `tiposboleto` (`idBoleto`, `Tipo`, `Precio`) VALUES
(1, '3ra Edad', 35),
(2, 'Adulto', 40),
(3, 'Niño', 30);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `Usuario` varchar(45) COLLATE utf8mb4_bin NOT NULL,
  `idPerfil` int(11) DEFAULT NULL,
  `password` text COLLATE utf8mb4_bin NOT NULL,
  `DPI` varchar(13) COLLATE utf8mb4_bin NOT NULL,
  `Nombres` varchar(100) COLLATE utf8mb4_bin NOT NULL,
  `Apellidos` varchar(100) COLLATE utf8mb4_bin NOT NULL,
  `Telefono` varchar(20) COLLATE utf8mb4_bin NOT NULL,
  `Correo` varchar(50) COLLATE utf8mb4_bin NOT NULL,
  `Sexo` varchar(10) COLLATE utf8mb4_bin NOT NULL,
  `fechaNac` date NOT NULL,
  `fechaInicio` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`Usuario`, `idPerfil`, `password`, `DPI`, `Nombres`, `Apellidos`, `Telefono`, `Correo`, `Sexo`, `fechaNac`, `fechaInicio`) VALUES
('Risko', 1, 'dd3d7a65733c4e476c310d7cfd7a2460', '894652', 'Risko', 'Risko', '84651325354', 'risko@Risko.com', 'masculino', '2019-07-01', '2019-07-31'),
('edgar', 1, 'cf55ada960dedf6154b0d6905b2748ff', '12365478', 'Edgar', 'Casasola', '22665544', 'edgar@risko.com', 'Masculino', '2018-07-31', '2019-06-27'),
('gus657', 1, 'b4288d9c0ec0a1841b3b3728321e7088', '35621547', 'Gustavo', 'Perez', '455221', 'gus', 'Masculino', '2019-07-28', '2019-07-28'),
('rchocm', 1, 'e9a529231e0c7e68bb358b0db3453c75', '4896513', 'Randy', 'Choc', '44558899', 'randy@risko.com', 'Masculino', '2017-12-16', '2019-07-25');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `asientos`
--
ALTER TABLE `asientos`
  ADD PRIMARY KEY (`idAsiento`,`idSala`),
  ADD KEY `idSala` (`idSala`);

--
-- Indices de la tabla `bitacora`
--
ALTER TABLE `bitacora`
  ADD PRIMARY KEY (`noReg`),
  ADD KEY `Usuario` (`Usuario`);

--
-- Indices de la tabla `boletos`
--
ALTER TABLE `boletos`
  ADD PRIMARY KEY (`idBoleto`),
  ADD KEY `Cine` (`Cine`),
  ADD KEY `idAsiento` (`idAsiento`),
  ADD KEY `idFuncion` (`idFuncion`),
  ADD KEY `tipoBoleto` (`tipoBoleto`);

--
-- Indices de la tabla `cines`
--
ALTER TABLE `cines`
  ADD PRIMARY KEY (`idCine`),
  ADD KEY `nombreCine` (`nombreCine`),
  ADD KEY `idCiudad` (`idCiudad`);

--
-- Indices de la tabla `ciudades`
--
ALTER TABLE `ciudades`
  ADD PRIMARY KEY (`idCiudad`);

--
-- Indices de la tabla `clasificacion`
--
ALTER TABLE `clasificacion`
  ADD PRIMARY KEY (`idClasificacion`),
  ADD KEY `clasificacion` (`clasificacion`);

--
-- Indices de la tabla `detallefactura`
--
ALTER TABLE `detallefactura`
  ADD PRIMARY KEY (`numeroLinea`,`numeroFactura`),
  ADD KEY `idBoleto` (`idBoleto`),
  ADD KEY `numeroFactura` (`numeroFactura`),
  ADD KEY `Costo` (`Costo`),
  ADD KEY `idFuncion` (`idFuncion`);

--
-- Indices de la tabla `detallereservacion`
--
ALTER TABLE `detallereservacion`
  ADD PRIMARY KEY (`numeroLinea`,`idReservasion`),
  ADD KEY `idFuncion` (`idFuncion`),
  ADD KEY `idAsiento` (`idAsiento`),
  ADD KEY `tipoBoleto` (`tipoBoleto`),
  ADD KEY `idReservasion` (`idReservasion`);

--
-- Indices de la tabla `encabezadosfactura`
--
ALTER TABLE `encabezadosfactura`
  ADD PRIMARY KEY (`numeroFactura`),
  ADD KEY `Cine` (`Cine`),
  ADD KEY `Funcion` (`Funcion`);

--
-- Indices de la tabla `funciones`
--
ALTER TABLE `funciones`
  ADD PRIMARY KEY (`idFuncion`),
  ADD KEY `idPelicula` (`idPelicula`),
  ADD KEY `idSala` (`idSala`),
  ADD KEY `cine` (`cine`);

--
-- Indices de la tabla `multimedia`
--
ALTER TABLE `multimedia`
  ADD PRIMARY KEY (`NoRegistro`);

--
-- Indices de la tabla `peliculas`
--
ALTER TABLE `peliculas`
  ADD PRIMARY KEY (`idPelicula`),
  ADD KEY `Clasificación` (`Clasificación`),
  ADD KEY `Usuario` (`Usuario`),
  ADD KEY `Titulo` (`Titulo`(191)),
  ADD KEY `Multimedia` (`Multimedia`);

--
-- Indices de la tabla `perfiles`
--
ALTER TABLE `perfiles`
  ADD PRIMARY KEY (`idPerfil`);

--
-- Indices de la tabla `reservaciones`
--
ALTER TABLE `reservaciones`
  ADD PRIMARY KEY (`idReservasion`),
  ADD KEY `Cine` (`Cine`),
  ADD KEY `idFuncion` (`idFuncion`);

--
-- Indices de la tabla `salas`
--
ALTER TABLE `salas`
  ADD PRIMARY KEY (`idSala`,`idCine`),
  ADD KEY `idCine` (`idCine`);

--
-- Indices de la tabla `timer`
--
ALTER TABLE `timer`
  ADD PRIMARY KEY (`noRegistro`),
  ADD KEY `Usuario` (`Usuario`);

--
-- Indices de la tabla `tiposboleto`
--
ALTER TABLE `tiposboleto`
  ADD PRIMARY KEY (`idBoleto`),
  ADD KEY `Precio` (`Precio`),
  ADD KEY `Tipo` (`Tipo`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`Usuario`),
  ADD KEY `idPerfil` (`idPerfil`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `bitacora`
--
ALTER TABLE `bitacora`
  MODIFY `noReg` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `boletos`
--
ALTER TABLE `boletos`
  MODIFY `idBoleto` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `cines`
--
ALTER TABLE `cines`
  MODIFY `idCine` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `ciudades`
--
ALTER TABLE `ciudades`
  MODIFY `idCiudad` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `clasificacion`
--
ALTER TABLE `clasificacion`
  MODIFY `idClasificacion` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `detallereservacion`
--
ALTER TABLE `detallereservacion`
  MODIFY `numeroLinea` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `encabezadosfactura`
--
ALTER TABLE `encabezadosfactura`
  MODIFY `numeroFactura` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `funciones`
--
ALTER TABLE `funciones`
  MODIFY `idFuncion` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de la tabla `multimedia`
--
ALTER TABLE `multimedia`
  MODIFY `NoRegistro` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `peliculas`
--
ALTER TABLE `peliculas`
  MODIFY `idPelicula` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `perfiles`
--
ALTER TABLE `perfiles`
  MODIFY `idPerfil` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `salas`
--
ALTER TABLE `salas`
  MODIFY `idSala` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `timer`
--
ALTER TABLE `timer`
  MODIFY `noRegistro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `asientos`
--
ALTER TABLE `asientos`
  ADD CONSTRAINT `asientos_ibfk_1` FOREIGN KEY (`idSala`) REFERENCES `salas` (`idSala`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `bitacora`
--
ALTER TABLE `bitacora`
  ADD CONSTRAINT `bitacora_ibfk_2` FOREIGN KEY (`Usuario`) REFERENCES `usuarios` (`Usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `boletos`
--
ALTER TABLE `boletos`
  ADD CONSTRAINT `boletos_ibfk_1` FOREIGN KEY (`idAsiento`) REFERENCES `asientos` (`idAsiento`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `boletos_ibfk_2` FOREIGN KEY (`idFuncion`) REFERENCES `funciones` (`idFuncion`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `boletos_ibfk_3` FOREIGN KEY (`tipoBoleto`) REFERENCES `tiposboleto` (`Tipo`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `boletos_ibfk_4` FOREIGN KEY (`Cine`) REFERENCES `cines` (`nombreCine`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `cines`
--
ALTER TABLE `cines`
  ADD CONSTRAINT `cines_ibfk_1` FOREIGN KEY (`idCiudad`) REFERENCES `ciudades` (`idCiudad`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `detallefactura`
--
ALTER TABLE `detallefactura`
  ADD CONSTRAINT `detallefactura_ibfk_1` FOREIGN KEY (`numeroFactura`) REFERENCES `encabezadosfactura` (`numeroFactura`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `detallefactura_ibfk_2` FOREIGN KEY (`idBoleto`) REFERENCES `boletos` (`idBoleto`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `detallefactura_ibfk_3` FOREIGN KEY (`Costo`) REFERENCES `tiposboleto` (`Precio`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `detallefactura_ibfk_4` FOREIGN KEY (`idFuncion`) REFERENCES `funciones` (`idFuncion`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `detallereservacion`
--
ALTER TABLE `detallereservacion`
  ADD CONSTRAINT `detallereservacion_ibfk_1` FOREIGN KEY (`idFuncion`) REFERENCES `funciones` (`idFuncion`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `detallereservacion_ibfk_2` FOREIGN KEY (`idAsiento`) REFERENCES `asientos` (`idAsiento`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `detallereservacion_ibfk_3` FOREIGN KEY (`tipoBoleto`) REFERENCES `tiposboleto` (`Tipo`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `detallereservacion_ibfk_6` FOREIGN KEY (`idReservasion`) REFERENCES `reservaciones` (`idReservasion`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `encabezadosfactura`
--
ALTER TABLE `encabezadosfactura`
  ADD CONSTRAINT `encabezadosfactura_ibfk_1` FOREIGN KEY (`Cine`) REFERENCES `cines` (`nombreCine`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `encabezadosfactura_ibfk_2` FOREIGN KEY (`Funcion`) REFERENCES `funciones` (`idFuncion`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `funciones`
--
ALTER TABLE `funciones`
  ADD CONSTRAINT `funciones_ibfk_1` FOREIGN KEY (`idPelicula`) REFERENCES `peliculas` (`idPelicula`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `funciones_ibfk_2` FOREIGN KEY (`idSala`) REFERENCES `salas` (`idSala`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `funciones_ibfk_3` FOREIGN KEY (`cine`) REFERENCES `cines` (`nombreCine`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `peliculas`
--
ALTER TABLE `peliculas`
  ADD CONSTRAINT `peliculas_ibfk_1` FOREIGN KEY (`Clasificación`) REFERENCES `clasificacion` (`clasificacion`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `peliculas_ibfk_2` FOREIGN KEY (`Usuario`) REFERENCES `usuarios` (`Usuario`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `peliculas_ibfk_3` FOREIGN KEY (`Multimedia`) REFERENCES `multimedia` (`NoRegistro`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `reservaciones`
--
ALTER TABLE `reservaciones`
  ADD CONSTRAINT `reservaciones_ibfk_1` FOREIGN KEY (`Cine`) REFERENCES `cines` (`nombreCine`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `reservaciones_ibfk_2` FOREIGN KEY (`idFuncion`) REFERENCES `funciones` (`idFuncion`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `salas`
--
ALTER TABLE `salas`
  ADD CONSTRAINT `salas_ibfk_1` FOREIGN KEY (`idCine`) REFERENCES `cines` (`idCine`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `timer`
--
ALTER TABLE `timer`
  ADD CONSTRAINT `timer_ibfk_1` FOREIGN KEY (`Usuario`) REFERENCES `usuarios` (`Usuario`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD CONSTRAINT `usuarios_ibfk_1` FOREIGN KEY (`idPerfil`) REFERENCES `perfiles` (`idPerfil`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
