-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 10-08-2019 a las 06:58:17
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
  `idFuncion` int(11) NOT NULL,
  `estado` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `asientos`
--

INSERT INTO `asientos` (`idAsiento`, `idFuncion`, `estado`) VALUES
('A-1', 1, 1),
('A-1', 2, 1),
('A-1', 3, 0),
('A-1', 4, 0),
('A-1', 5, 0),
('A-1', 6, 0),
('A-1', 7, 0),
('A-1', 8, 0),
('A-1', 9, 0),
('A-10', 1, 1),
('A-10', 2, 0),
('A-10', 3, 0),
('A-10', 4, 0),
('A-10', 5, 0),
('A-10', 6, 0),
('A-10', 7, 0),
('A-10', 8, 0),
('A-10', 9, 0),
('A-2', 1, 1),
('A-2', 2, 0),
('A-2', 3, 0),
('A-2', 4, 0),
('A-2', 5, 0),
('A-2', 6, 0),
('A-2', 7, 0),
('A-2', 8, 0),
('A-2', 9, 0),
('A-3', 1, 0),
('A-3', 2, 0),
('A-3', 3, 0),
('A-3', 4, 0),
('A-3', 5, 0),
('A-3', 6, 0),
('A-3', 7, 0),
('A-3', 8, 0),
('A-3', 9, 0),
('A-4', 1, 0),
('A-4', 2, 0),
('A-4', 3, 0),
('A-4', 4, 0),
('A-4', 5, 0),
('A-4', 6, 0),
('A-4', 7, 0),
('A-4', 8, 0),
('A-4', 9, 0),
('A-5', 1, 0),
('A-5', 2, 0),
('A-5', 3, 0),
('A-5', 4, 0),
('A-5', 5, 0),
('A-5', 6, 0),
('A-5', 7, 0),
('A-5', 8, 0),
('A-5', 9, 0),
('A-6', 1, 0),
('A-6', 2, 0),
('A-6', 3, 0),
('A-6', 4, 0),
('A-6', 5, 0),
('A-6', 6, 0),
('A-6', 7, 0),
('A-6', 8, 0),
('A-6', 9, 0),
('A-7', 1, 0),
('A-7', 2, 0),
('A-7', 3, 0),
('A-7', 4, 0),
('A-7', 5, 0),
('A-7', 6, 0),
('A-7', 7, 0),
('A-7', 8, 0),
('A-7', 9, 0),
('A-8', 1, 0),
('A-8', 2, 0),
('A-8', 3, 0),
('A-8', 4, 0),
('A-8', 5, 0),
('A-8', 6, 0),
('A-8', 7, 0),
('A-8', 8, 0),
('A-8', 9, 0),
('A-9', 1, 0),
('A-9', 2, 0),
('A-9', 3, 0),
('A-9', 4, 0),
('A-9', 5, 0),
('A-9', 6, 0),
('A-9', 7, 0),
('A-9', 8, 0),
('A-9', 9, 0),
('B-1', 1, 0),
('B-1', 2, 0),
('B-1', 3, 0),
('B-1', 4, 0),
('B-1', 5, 0),
('B-1', 6, 0),
('B-1', 7, 0),
('B-1', 8, 0),
('B-1', 9, 0),
('B-10', 1, 0),
('B-10', 2, 0),
('B-10', 3, 0),
('B-10', 4, 0),
('B-10', 5, 0),
('B-10', 6, 0),
('B-10', 7, 0),
('B-10', 8, 0),
('B-10', 9, 0),
('B-2', 1, 0),
('B-2', 2, 0),
('B-2', 3, 0),
('B-2', 4, 0),
('B-2', 5, 0),
('B-2', 6, 0),
('B-2', 7, 0),
('B-2', 8, 0),
('B-2', 9, 0),
('B-3', 1, 0),
('B-3', 2, 0),
('B-3', 3, 0),
('B-3', 4, 0),
('B-3', 5, 0),
('B-3', 6, 0),
('B-3', 7, 0),
('B-3', 8, 0),
('B-3', 9, 0),
('B-4', 1, 0),
('B-4', 2, 0),
('B-4', 3, 0),
('B-4', 4, 0),
('B-4', 5, 0),
('B-4', 6, 0),
('B-4', 7, 0),
('B-4', 8, 0),
('B-4', 9, 0),
('B-5', 1, 0),
('B-5', 2, 0),
('B-5', 3, 0),
('B-5', 4, 0),
('B-5', 5, 0),
('B-5', 6, 0),
('B-5', 7, 0),
('B-5', 8, 0),
('B-5', 9, 0),
('B-6', 1, 0),
('B-6', 2, 0),
('B-6', 3, 0),
('B-6', 4, 0),
('B-6', 5, 0),
('B-6', 6, 0),
('B-6', 7, 0),
('B-6', 8, 0),
('B-6', 9, 0),
('B-7', 1, 0),
('B-7', 2, 0),
('B-7', 3, 0),
('B-7', 4, 0),
('B-7', 5, 0),
('B-7', 6, 0),
('B-7', 7, 0),
('B-7', 8, 0),
('B-7', 9, 0),
('B-8', 1, 0),
('B-8', 2, 0),
('B-8', 3, 0),
('B-8', 4, 0),
('B-8', 5, 0),
('B-8', 6, 0),
('B-8', 7, 0),
('B-8', 8, 0),
('B-8', 9, 0),
('B-9', 1, 0),
('B-9', 2, 0),
('B-9', 3, 0),
('B-9', 4, 0),
('B-9', 5, 0),
('B-9', 6, 0),
('B-9', 7, 0),
('B-9', 8, 0),
('B-9', 9, 0),
('C-1', 1, 0),
('C-1', 2, 0),
('C-1', 3, 0),
('C-1', 4, 0),
('C-1', 5, 0),
('C-1', 6, 0),
('C-1', 7, 0),
('C-1', 8, 0),
('C-1', 9, 0),
('C-10', 1, 0),
('C-10', 2, 0),
('C-10', 3, 0),
('C-10', 4, 0),
('C-10', 5, 0),
('C-10', 6, 0),
('C-10', 7, 0),
('C-10', 8, 0),
('C-10', 9, 0),
('C-2', 1, 0),
('C-2', 2, 0),
('C-2', 3, 0),
('C-2', 4, 0),
('C-2', 5, 0),
('C-2', 6, 0),
('C-2', 7, 0),
('C-2', 8, 0),
('C-2', 9, 0),
('C-3', 1, 0),
('C-3', 2, 0),
('C-3', 3, 0),
('C-3', 4, 0),
('C-3', 5, 0),
('C-3', 6, 0),
('C-3', 7, 0),
('C-3', 8, 0),
('C-3', 9, 0),
('C-4', 1, 0),
('C-4', 2, 0),
('C-4', 3, 0),
('C-4', 4, 0),
('C-4', 5, 0),
('C-4', 6, 0),
('C-4', 7, 0),
('C-4', 8, 0),
('C-4', 9, 0),
('C-5', 1, 1),
('C-5', 2, 0),
('C-5', 3, 0),
('C-5', 4, 0),
('C-5', 5, 0),
('C-5', 6, 0),
('C-5', 7, 0),
('C-5', 8, 0),
('C-5', 9, 0),
('C-6', 1, 1),
('C-6', 2, 0),
('C-6', 3, 0),
('C-6', 4, 0),
('C-6', 5, 0),
('C-6', 6, 0),
('C-6', 7, 0),
('C-6', 8, 0),
('C-6', 9, 0),
('C-7', 1, 0),
('C-7', 2, 0),
('C-7', 3, 0),
('C-7', 4, 0),
('C-7', 5, 0),
('C-7', 6, 0),
('C-7', 7, 0),
('C-7', 8, 0),
('C-7', 9, 0),
('C-8', 1, 0),
('C-8', 2, 0),
('C-8', 3, 0),
('C-8', 4, 0),
('C-8', 5, 0),
('C-8', 6, 0),
('C-8', 7, 0),
('C-8', 8, 0),
('C-8', 9, 0),
('C-9', 1, 0),
('C-9', 2, 0),
('C-9', 3, 0),
('C-9', 4, 0),
('C-9', 5, 0),
('C-9', 6, 0),
('C-9', 7, 0),
('C-9', 8, 0),
('C-9', 9, 0),
('D-1', 1, 0),
('D-1', 2, 0),
('D-1', 3, 0),
('D-1', 4, 0),
('D-1', 5, 0),
('D-1', 6, 0),
('D-1', 7, 0),
('D-1', 8, 0),
('D-1', 9, 0),
('D-10', 1, 0),
('D-10', 2, 0),
('D-10', 3, 0),
('D-10', 4, 0),
('D-10', 5, 0),
('D-10', 6, 0),
('D-10', 7, 0),
('D-10', 8, 0),
('D-10', 9, 0),
('D-2', 1, 0),
('D-2', 2, 0),
('D-2', 3, 0),
('D-2', 4, 0),
('D-2', 5, 0),
('D-2', 6, 0),
('D-2', 7, 0),
('D-2', 8, 0),
('D-2', 9, 0),
('D-3', 1, 0),
('D-3', 2, 0),
('D-3', 3, 0),
('D-3', 4, 0),
('D-3', 5, 0),
('D-3', 6, 0),
('D-3', 7, 0),
('D-3', 8, 0),
('D-3', 9, 0),
('D-4', 1, 0),
('D-4', 2, 0),
('D-4', 3, 0),
('D-4', 4, 0),
('D-4', 5, 0),
('D-4', 6, 0),
('D-4', 7, 0),
('D-4', 8, 0),
('D-4', 9, 0),
('D-5', 1, 0),
('D-5', 2, 0),
('D-5', 3, 0),
('D-5', 4, 0),
('D-5', 5, 0),
('D-5', 6, 0),
('D-5', 7, 0),
('D-5', 8, 0),
('D-5', 9, 0),
('D-6', 1, 0),
('D-6', 2, 0),
('D-6', 3, 0),
('D-6', 4, 0),
('D-6', 5, 0),
('D-6', 6, 0),
('D-6', 7, 0),
('D-6', 8, 0),
('D-6', 9, 0),
('D-7', 1, 0),
('D-7', 2, 0),
('D-7', 3, 0),
('D-7', 4, 0),
('D-7', 5, 0),
('D-7', 6, 0),
('D-7', 7, 0),
('D-7', 8, 0),
('D-7', 9, 0),
('D-8', 1, 0),
('D-8', 2, 0),
('D-8', 3, 0),
('D-8', 4, 0),
('D-8', 5, 0),
('D-8', 6, 0),
('D-8', 7, 0),
('D-8', 8, 0),
('D-8', 9, 0),
('D-9', 1, 0),
('D-9', 2, 0),
('D-9', 3, 0),
('D-9', 4, 0),
('D-9', 5, 0),
('D-9', 6, 0),
('D-9', 7, 0),
('D-9', 8, 0),
('D-9', 9, 0),
('E-1', 1, 0),
('E-1', 2, 0),
('E-1', 3, 0),
('E-1', 4, 0),
('E-1', 5, 0),
('E-1', 6, 0),
('E-1', 7, 0),
('E-1', 8, 0),
('E-1', 9, 0),
('E-10', 1, 0),
('E-10', 2, 0),
('E-10', 3, 0),
('E-10', 4, 0),
('E-10', 5, 0),
('E-10', 6, 0),
('E-10', 7, 0),
('E-10', 8, 0),
('E-10', 9, 0),
('E-2', 1, 0),
('E-2', 2, 0),
('E-2', 3, 0),
('E-2', 4, 0),
('E-2', 5, 0),
('E-2', 6, 0),
('E-2', 7, 0),
('E-2', 8, 0),
('E-2', 9, 0),
('E-3', 1, 0),
('E-3', 2, 0),
('E-3', 3, 0),
('E-3', 4, 0),
('E-3', 5, 0),
('E-3', 6, 0),
('E-3', 7, 0),
('E-3', 8, 0),
('E-3', 9, 0),
('E-4', 1, 0),
('E-4', 2, 0),
('E-4', 3, 0),
('E-4', 4, 0),
('E-4', 5, 0),
('E-4', 6, 0),
('E-4', 7, 0),
('E-4', 8, 0),
('E-4', 9, 0),
('E-5', 1, 0),
('E-5', 2, 0),
('E-5', 3, 0),
('E-5', 4, 0),
('E-5', 5, 0),
('E-5', 6, 0),
('E-5', 7, 0),
('E-5', 8, 0),
('E-5', 9, 0),
('E-6', 1, 0),
('E-6', 2, 0),
('E-6', 3, 0),
('E-6', 4, 0),
('E-6', 5, 0),
('E-6', 6, 0),
('E-6', 7, 0),
('E-6', 8, 0),
('E-6', 9, 0),
('E-7', 1, 0),
('E-7', 2, 0),
('E-7', 3, 0),
('E-7', 4, 0),
('E-7', 5, 0),
('E-7', 6, 0),
('E-7', 7, 0),
('E-7', 8, 0),
('E-7', 9, 0),
('E-8', 1, 0),
('E-8', 2, 0),
('E-8', 3, 0),
('E-8', 4, 0),
('E-8', 5, 0),
('E-8', 6, 0),
('E-8', 7, 0),
('E-8', 8, 0),
('E-8', 9, 0),
('E-9', 1, 0),
('E-9', 2, 0),
('E-9', 3, 0),
('E-9', 4, 0),
('E-9', 5, 0),
('E-9', 6, 0),
('E-9', 7, 0),
('E-9', 8, 0),
('E-9', 9, 0),
('F-1', 1, 0),
('F-1', 2, 0),
('F-1', 3, 0),
('F-1', 4, 0),
('F-1', 5, 0),
('F-1', 6, 0),
('F-1', 7, 0),
('F-1', 8, 0),
('F-1', 9, 0),
('F-10', 1, 0),
('F-10', 2, 0),
('F-10', 3, 0),
('F-10', 4, 0),
('F-10', 5, 0),
('F-10', 6, 0),
('F-10', 7, 0),
('F-10', 8, 0),
('F-10', 9, 0),
('F-2', 1, 0),
('F-2', 2, 0),
('F-2', 3, 0),
('F-2', 4, 0),
('F-2', 5, 0),
('F-2', 6, 0),
('F-2', 7, 0),
('F-2', 8, 0),
('F-2', 9, 0),
('F-3', 1, 0),
('F-3', 2, 0),
('F-3', 3, 0),
('F-3', 4, 0),
('F-3', 5, 0),
('F-3', 6, 0),
('F-3', 7, 0),
('F-3', 8, 0),
('F-3', 9, 0),
('F-4', 1, 0),
('F-4', 2, 0),
('F-4', 3, 0),
('F-4', 4, 0),
('F-4', 5, 0),
('F-4', 6, 0),
('F-4', 7, 0),
('F-4', 8, 0),
('F-4', 9, 0),
('F-5', 1, 0),
('F-5', 2, 0),
('F-5', 3, 0),
('F-5', 4, 0),
('F-5', 5, 0),
('F-5', 6, 0),
('F-5', 7, 0),
('F-5', 8, 0),
('F-5', 9, 0),
('F-6', 1, 0),
('F-6', 2, 0),
('F-6', 3, 0),
('F-6', 4, 0),
('F-6', 5, 0),
('F-6', 6, 0),
('F-6', 7, 0),
('F-6', 8, 0),
('F-6', 9, 0),
('F-7', 1, 0),
('F-7', 2, 0),
('F-7', 3, 0),
('F-7', 4, 0),
('F-7', 5, 0),
('F-7', 6, 0),
('F-7', 7, 0),
('F-7', 8, 0),
('F-7', 9, 0),
('F-8', 1, 0),
('F-8', 2, 0),
('F-8', 3, 0),
('F-8', 4, 0),
('F-8', 5, 0),
('F-8', 6, 0),
('F-8', 7, 0),
('F-8', 8, 0),
('F-8', 9, 0),
('F-9', 1, 0),
('F-9', 2, 0),
('F-9', 3, 0),
('F-9', 4, 0),
('F-9', 5, 0),
('F-9', 6, 0),
('F-9', 7, 0),
('F-9', 8, 0),
('F-9', 9, 0),
('G-1', 1, 0),
('G-1', 2, 0),
('G-1', 3, 0),
('G-1', 4, 0),
('G-1', 5, 0),
('G-1', 6, 0),
('G-1', 7, 0),
('G-1', 8, 0),
('G-1', 9, 0),
('G-10', 1, 0),
('G-10', 2, 0),
('G-10', 3, 0),
('G-10', 4, 0),
('G-10', 5, 0),
('G-10', 6, 0),
('G-10', 7, 0),
('G-10', 8, 0),
('G-10', 9, 0),
('G-2', 1, 0),
('G-2', 2, 0),
('G-2', 3, 0),
('G-2', 4, 0),
('G-2', 5, 0),
('G-2', 6, 0),
('G-2', 7, 0),
('G-2', 8, 0),
('G-2', 9, 0),
('G-3', 1, 0),
('G-3', 2, 0),
('G-3', 3, 0),
('G-3', 4, 0),
('G-3', 5, 0),
('G-3', 6, 0),
('G-3', 7, 0),
('G-3', 8, 0),
('G-3', 9, 0),
('G-4', 1, 0),
('G-4', 2, 0),
('G-4', 3, 0),
('G-4', 4, 0),
('G-4', 5, 0),
('G-4', 6, 0),
('G-4', 7, 0),
('G-4', 8, 0),
('G-4', 9, 0),
('G-5', 1, 0),
('G-5', 2, 0),
('G-5', 3, 0),
('G-5', 4, 0),
('G-5', 5, 0),
('G-5', 6, 0),
('G-5', 7, 0),
('G-5', 8, 0),
('G-5', 9, 0),
('G-6', 1, 0),
('G-6', 2, 0),
('G-6', 3, 0),
('G-6', 4, 0),
('G-6', 5, 0),
('G-6', 6, 0),
('G-6', 7, 0),
('G-6', 8, 0),
('G-6', 9, 0),
('G-7', 1, 0),
('G-7', 2, 0),
('G-7', 3, 0),
('G-7', 4, 0),
('G-7', 5, 0),
('G-7', 6, 0),
('G-7', 7, 0),
('G-7', 8, 0),
('G-7', 9, 0),
('G-8', 1, 0),
('G-8', 2, 0),
('G-8', 3, 0),
('G-8', 4, 0),
('G-8', 5, 0),
('G-8', 6, 0),
('G-8', 7, 0),
('G-8', 8, 0),
('G-8', 9, 0),
('G-9', 1, 0),
('G-9', 2, 0),
('G-9', 3, 0),
('G-9', 4, 0),
('G-9', 5, 0),
('G-9', 6, 0),
('G-9', 7, 0),
('G-9', 8, 0),
('G-9', 9, 0),
('H-1', 1, 0),
('H-1', 2, 0),
('H-1', 3, 0),
('H-1', 4, 0),
('H-1', 5, 0),
('H-1', 6, 0),
('H-1', 7, 0),
('H-1', 8, 0),
('H-1', 9, 0),
('H-10', 1, 0),
('H-10', 2, 0),
('H-10', 3, 0),
('H-10', 4, 0),
('H-10', 5, 0),
('H-10', 6, 0),
('H-10', 7, 0),
('H-10', 8, 0),
('H-10', 9, 0),
('H-2', 1, 0),
('H-2', 2, 0),
('H-2', 3, 0),
('H-2', 4, 0),
('H-2', 5, 0),
('H-2', 6, 0),
('H-2', 7, 0),
('H-2', 8, 0),
('H-2', 9, 0),
('H-3', 1, 0),
('H-3', 2, 0),
('H-3', 3, 0),
('H-3', 4, 0),
('H-3', 5, 0),
('H-3', 6, 0),
('H-3', 7, 0),
('H-3', 8, 0),
('H-3', 9, 0),
('H-4', 1, 0),
('H-4', 2, 0),
('H-4', 3, 0),
('H-4', 4, 0),
('H-4', 5, 0),
('H-4', 6, 0),
('H-4', 7, 0),
('H-4', 8, 0),
('H-4', 9, 0),
('H-5', 1, 0),
('H-5', 2, 0),
('H-5', 3, 0),
('H-5', 4, 0),
('H-5', 5, 0),
('H-5', 6, 0),
('H-5', 7, 0),
('H-5', 8, 0),
('H-5', 9, 0),
('H-6', 1, 1),
('H-6', 2, 0),
('H-6', 3, 0),
('H-6', 4, 0),
('H-6', 5, 0),
('H-6', 6, 0),
('H-6', 7, 0),
('H-6', 8, 0),
('H-6', 9, 0),
('H-7', 1, 0),
('H-7', 2, 0),
('H-7', 3, 0),
('H-7', 4, 0),
('H-7', 5, 0),
('H-7', 6, 0),
('H-7', 7, 0),
('H-7', 8, 0),
('H-7', 9, 0),
('H-8', 1, 0),
('H-8', 2, 0),
('H-8', 3, 0),
('H-8', 4, 0),
('H-8', 5, 0),
('H-8', 6, 0),
('H-8', 7, 0),
('H-8', 8, 0),
('H-8', 9, 0),
('H-9', 1, 0),
('H-9', 2, 0),
('H-9', 3, 0),
('H-9', 4, 0),
('H-9', 5, 0),
('H-9', 6, 0),
('H-9', 7, 0),
('H-9', 8, 0),
('H-9', 9, 0),
('I-1', 1, 0),
('I-1', 2, 0),
('I-1', 3, 0),
('I-1', 4, 0),
('I-1', 5, 0),
('I-1', 6, 0),
('I-1', 7, 0),
('I-1', 8, 0),
('I-1', 9, 0),
('I-10', 1, 0),
('I-10', 2, 0),
('I-10', 3, 0),
('I-10', 4, 0),
('I-10', 5, 0),
('I-10', 6, 0),
('I-10', 7, 0),
('I-10', 8, 0),
('I-10', 9, 0),
('I-2', 1, 0),
('I-2', 2, 0),
('I-2', 3, 0),
('I-2', 4, 0),
('I-2', 5, 0),
('I-2', 6, 0),
('I-2', 7, 0),
('I-2', 8, 0),
('I-2', 9, 0),
('I-3', 1, 0),
('I-3', 2, 0),
('I-3', 3, 0),
('I-3', 4, 0),
('I-3', 5, 0),
('I-3', 6, 0),
('I-3', 7, 0),
('I-3', 8, 0),
('I-3', 9, 0),
('I-4', 1, 0),
('I-4', 2, 0),
('I-4', 3, 0),
('I-4', 4, 0),
('I-4', 5, 0),
('I-4', 6, 0),
('I-4', 7, 0),
('I-4', 8, 0),
('I-4', 9, 0),
('I-5', 1, 0),
('I-5', 2, 0),
('I-5', 3, 0),
('I-5', 4, 0),
('I-5', 5, 0),
('I-5', 6, 0),
('I-5', 7, 0),
('I-5', 8, 0),
('I-5', 9, 0),
('I-6', 1, 0),
('I-6', 2, 0),
('I-6', 3, 0),
('I-6', 4, 0),
('I-6', 5, 0),
('I-6', 6, 0),
('I-6', 7, 0),
('I-6', 8, 0),
('I-6', 9, 0),
('I-7', 1, 0),
('I-7', 2, 0),
('I-7', 3, 0),
('I-7', 4, 0),
('I-7', 5, 0),
('I-7', 6, 0),
('I-7', 7, 0),
('I-7', 8, 0),
('I-7', 9, 0),
('I-8', 1, 0),
('I-8', 2, 0),
('I-8', 3, 0),
('I-8', 4, 0),
('I-8', 5, 0),
('I-8', 6, 0),
('I-8', 7, 0),
('I-8', 8, 0),
('I-8', 9, 0),
('I-9', 1, 0),
('I-9', 2, 0),
('I-9', 3, 0),
('I-9', 4, 0),
('I-9', 5, 0),
('I-9', 6, 0),
('I-9', 7, 0),
('I-9', 8, 0),
('I-9', 9, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bitacora`
--

CREATE TABLE `bitacora` (
  `noReg` int(11) NOT NULL,
  `Usuario` varchar(45) COLLATE utf8mb4_bin DEFAULT NULL,
  `Accion` varchar(20) COLLATE utf8mb4_bin NOT NULL,
  `Afectado` varchar(45) COLLATE utf8mb4_bin NOT NULL,
  `ipAddress` text COLLATE utf8mb4_bin,
  `fechaHora` text COLLATE utf8mb4_bin
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `bitacora`
--

INSERT INTO `bitacora` (`noReg`, `Usuario`, `Accion`, `Afectado`, `ipAddress`, `fechaHora`) VALUES
(1, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 18:28:44'),
(2, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 18:31:12'),
(3, 'Risko', 'INSERT', 'MULTIMEDIA ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 18:31:25'),
(4, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 18:33:24'),
(5, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 18:34:18'),
(6, 'Risko', 'UPDATE', ' MULTIMEDIA', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 18:34:23'),
(7, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 18:35:50'),
(8, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 18:36:30'),
(9, 'Risko', 'INSERT', ' MULTIMEDIA', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 18:36:40'),
(10, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 18:36:51'),
(11, 'Risko', 'DELETE', ' MULTIMEDIA', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 18:36:57'),
(12, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 18:39:55'),
(13, 'Risko', 'INSERT', ' MULTIMEDIA', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 18:40:07'),
(14, 'Risko', 'DELETE', ' MULTIMEDIA', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 18:40:12'),
(15, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 21:04:46'),
(16, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 21:07:45'),
(17, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 21:14:09'),
(18, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 21:15:23'),
(19, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 21:15:46'),
(20, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 21:16:00'),
(21, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 21:16:32'),
(22, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 21:17:11'),
(23, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 21:27:46'),
(24, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 21:28:31'),
(25, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 21:29:13'),
(26, 'Risko', 'UPDATE', ' MULTIMEDIA', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 21:29:22'),
(27, 'Risko', 'UPDATE', ' MULTIMEDIA', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 21:29:32'),
(28, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 21:33:18'),
(29, 'Risko', 'INSERT', ' Cines', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 21:33:30'),
(30, 'Risko', 'DELETE', ' CINES', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 21:33:36'),
(31, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 21:43:30'),
(32, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 21:45:44'),
(33, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 21:46:22'),
(34, 'Risko', 'UPDATE', ' CIUDADES', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 21:46:38'),
(35, 'Risko', 'INSERT', ' CIUDADES', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 21:46:56'),
(36, 'Risko', 'DELETE', ' CIUDADES', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 21:47:01'),
(37, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 21:48:24'),
(38, 'Risko', 'INSERT', ' CIUDADES', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 21:48:31'),
(39, 'Risko', 'UPDATE', ' CIUDADES', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 21:48:47'),
(40, 'Risko', 'DELETE', ' CIUDADES', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 21:48:54'),
(41, 'Risko', 'UPDATE', ' CIUDADES', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 21:49:05'),
(42, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 21:57:29'),
(43, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 21:58:10'),
(44, 'Risko', 'INSERT', ' FUNCIONES', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 21:58:48'),
(45, 'Risko', 'UPDATE', ' FUNCIONES', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 21:59:10'),
(46, 'Risko', 'DELETE', ' FUNCIONES', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 21:59:15'),
(47, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 22:03:46'),
(48, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 22:04:49'),
(49, 'Risko', 'DELETE', ' USUARIOS', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 22:05:05'),
(50, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 22:08:21'),
(51, 'Risko', 'DELETE', ' PELICULAS', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 22:08:54'),
(52, 'Risko', 'DELETE', ' PELICULAS', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 22:09:02'),
(53, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 23:33:43'),
(54, 'Risko', 'INSERT', ' FUNCIONES', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 23:34:15'),
(55, 'Risko', 'INSERT', ' PELICULAS', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 23:35:52'),
(56, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 23:37:08'),
(57, 'Risko', 'INSERT', ' FUNCIONES', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '1/08/2019 23:37:26'),
(58, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.50.120', '2/08/2019 08:29:57'),
(59, 'Risko', 'UPDATE', ' FUNCIONES', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.50.120', '2/08/2019 08:30:05'),
(60, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.50.120', '2/08/2019 08:43:02'),
(61, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.50.120', '2/08/2019 08:43:22'),
(62, 'Risko', 'UPDATE', ' USUARIOS', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.50.120', '2/08/2019 08:44:16'),
(63, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::b841:8529:6db6:d7a6%9   |   fe80::b523:a454:a8ba:7157%15   |   2803:7000:2000:4f1:142e:1117:f87f:f7bc   |   2803:7000:2000:4f1:b523:a454:a8ba:7157   |   192.168.56.1   |   192.168.0.14', '3/08/2019 11:30:42'),
(64, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::b841:8529:6db6:d7a6%9   |   fe80::b523:a454:a8ba:7157%15   |   2803:7000:2000:4f1:142e:1117:f87f:f7bc   |   2803:7000:2000:4f1:b523:a454:a8ba:7157   |   192.168.56.1   |   192.168.0.14', '3/08/2019 11:31:29'),
(65, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::b841:8529:6db6:d7a6%9   |   fe80::b523:a454:a8ba:7157%15   |   2803:7000:2000:4f1:142e:1117:f87f:f7bc   |   2803:7000:2000:4f1:b523:a454:a8ba:7157   |   192.168.56.1   |   192.168.0.14', '3/08/2019 11:32:51'),
(66, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::b841:8529:6db6:d7a6%9   |   fe80::b523:a454:a8ba:7157%15   |   2803:7000:2000:4f1:142e:1117:f87f:f7bc   |   2803:7000:2000:4f1:b523:a454:a8ba:7157   |   192.168.56.1   |   192.168.0.14', '3/08/2019 11:33:27'),
(67, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::b841:8529:6db6:d7a6%9   |   fe80::b523:a454:a8ba:7157%15   |   2803:7000:2000:4f1:142e:1117:f87f:f7bc   |   2803:7000:2000:4f1:b523:a454:a8ba:7157   |   192.168.56.1   |   192.168.0.14', '3/08/2019 12:38:15'),
(68, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '5/08/2019 00:00:27'),
(69, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '5/08/2019 00:01:10'),
(70, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '5/08/2019 00:01:40'),
(71, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '5/08/2019 00:03:30'),
(72, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '5/08/2019 00:04:46'),
(73, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '5/08/2019 00:05:31'),
(74, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '5/08/2019 00:09:25'),
(75, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '5/08/2019 00:11:37'),
(76, 'Gus', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '5/08/2019 00:35:29'),
(77, 'Gus', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '5/08/2019 00:36:04'),
(78, 'Gus', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '5/08/2019 00:36:23'),
(79, 'Gus', 'SELECT', ' BITACORA', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '5/08/2019 00:37:10'),
(80, 'Gus', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '5/08/2019 00:37:10'),
(81, 'Gus', 'SELECT', ' BITACORA', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '5/08/2019 00:37:27'),
(82, 'Gus', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '5/08/2019 00:37:27'),
(83, 'edgar', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '5/08/2019 00:53:00'),
(84, 'Risko', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '5/08/2019 00:54:07'),
(85, 'Gus', 'SELECT', ' BITACORA', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '5/08/2019 00:55:02'),
(86, 'Gus', 'LOG IN', 'LOGIN ', '   |   fe80::bcee:cf39:bf89:475%14   |   fe80::bd74:d5b6:1520:c945%9   |   192.168.56.1   |   192.168.1.5', '5/08/2019 00:55:02');

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

--
-- Volcado de datos para la tabla `boletos`
--

INSERT INTO `boletos` (`idBoleto`, `idFuncion`, `idAsiento`, `Fecha`, `Cine`, `tipoBoleto`) VALUES
(10, 1, 'A-8', '2019-08-09', 'Portales', '3ra Edad'),
(11, 1, 'B-8', '2019-08-09', 'Portales', 'Adulto'),
(12, 1, 'C-8', '2019-08-09', 'Portales', 'Niño'),
(13, 1, 'D-8', '2019-08-09', 'Portales', 'Adulto');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cines`
--

CREATE TABLE `cines` (
  `idCine` int(11) NOT NULL,
  `idCiudad` int(11) DEFAULT NULL,
  `nombreCine` varchar(45) COLLATE utf8mb4_bin DEFAULT NULL,
  `estadoCine` int(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `cines`
--

INSERT INTO `cines` (`idCine`, `idCiudad`, `nombreCine`, `estadoCine`) VALUES
(1, 1, 'Portales', 7),
(2, 1, 'Miraflores', 7),
(3, 1, 'Naranjo', 7),
(4, 2, 'Plaza Americas', 0),
(5, 3, 'Interplaza', 0);

--
-- Disparadores `cines`
--
DELIMITER $$
CREATE TRIGGER `estdo sala` AFTER UPDATE ON `cines` FOR EACH ROW BEGIN
UPDATE salas set estadoSala = new.estadoCine WHERE salas.idCine=new.idCine;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ciudades`
--

CREATE TABLE `ciudades` (
  `idCiudad` int(11) NOT NULL,
  `nombreCiudad` varchar(255) COLLATE utf8mb4_bin DEFAULT NULL,
  `estadoCiudad` int(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `ciudades`
--

INSERT INTO `ciudades` (`idCiudad`, `nombreCiudad`, `estadoCiudad`) VALUES
(1, 'Guatemala', 7),
(2, 'Quetzaltenango', 0),
(3, 'Xela', 0);

--
-- Disparadores `ciudades`
--
DELIMITER $$
CREATE TRIGGER `ESTADO CINE` AFTER UPDATE ON `ciudades` FOR EACH ROW BEGIN
UPDATE cines set estadoCine = new.estadoCiudad WHERE cines.idCiudad=new.idCiudad;
END
$$
DELIMITER ;

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
  `Costo` int(3) NOT NULL,
  `estadoDetalleFactura` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `detallefactura`
--

INSERT INTO `detallefactura` (`numeroLinea`, `numeroFactura`, `idBoleto`, `Costo`, `estadoDetalleFactura`) VALUES
(1, 15, 10, 35, 0),
(2, 15, 11, 40, 0),
(3, 15, 12, 30, 0),
(4, 15, 13, 40, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detallereservacion`
--

CREATE TABLE `detallereservacion` (
  `numeroLinea` int(11) NOT NULL,
  `idReservacion` int(11) NOT NULL,
  `idFuncion` int(11) NOT NULL,
  `idAsiento` varchar(5) COLLATE utf8mb4_bin DEFAULT NULL,
  `estadoDetalleReservacion` int(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `detallereservacion`
--

INSERT INTO `detallereservacion` (`numeroLinea`, `idReservacion`, `idFuncion`, `idAsiento`, `estadoDetalleReservacion`) VALUES
(1, 1, 6, 'A-1', 0),
(2, 1, 6, 'A-2', 0),
(8, 9, 1, 'A-7', 0),
(9, 9, 1, 'B-7', 0),
(10, 9, 1, 'C-7', 0),
(11, 10, 1, 'A-7', 0),
(12, 10, 1, 'B-7', 0),
(13, 11, 1, 'A-9', 0),
(14, 12, 1, 'B-8', 0),
(15, 12, 1, 'B-9', 0),
(16, 13, 1, 'A-8', 0),
(17, 13, 1, 'B-8', 0),
(18, 14, 1, 'A-8', 0),
(19, 14, 1, 'B-8', 0),
(20, 15, 1, 'A-8', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `encabezadosfactura`
--

CREATE TABLE `encabezadosfactura` (
  `numeroFactura` int(11) NOT NULL,
  `fechaFactura` date DEFAULT NULL,
  `Cine` varchar(45) COLLATE utf8mb4_bin NOT NULL,
  `Funcion` int(11) NOT NULL,
  `estadoFactura` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `encabezadosfactura`
--

INSERT INTO `encabezadosfactura` (`numeroFactura`, `fechaFactura`, `Cine`, `Funcion`, `estadoFactura`) VALUES
(15, '2019-08-09', 'Portales', 1, 0);

--
-- Disparadores `encabezadosfactura`
--
DELIMITER $$
CREATE TRIGGER `estado detalle` AFTER UPDATE ON `encabezadosfactura` FOR EACH ROW BEGIN
UPDATE detallefactura
set estadoDetalleFactura = new.estadoFactura
WHERE detallefactura.numeroFactura = new.numeroFactura;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `funciones`
--

CREATE TABLE `funciones` (
  `idFuncion` int(11) NOT NULL,
  `idPelicula` int(11) DEFAULT NULL,
  `idSala` int(11) DEFAULT NULL,
  `cine` varchar(45) COLLATE utf8mb4_bin NOT NULL,
  `horaFuncion` time DEFAULT NULL,
  `estadoFuncion` int(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `funciones`
--

INSERT INTO `funciones` (`idFuncion`, `idPelicula`, `idSala`, `cine`, `horaFuncion`, `estadoFuncion`) VALUES
(1, 2, 5, 'Portales', '16:05:00', 7),
(2, 2, 4, 'Naranjo', '11:00:00', 7),
(3, 2, 3, 'Interplaza', '16:00:00', 0),
(4, 6, 5, 'Portales', '16:05:00', 7),
(5, 5, 3, 'Interplaza', '10:25:00', 0),
(6, 5, 1, 'Portales', '12:50:00', 7),
(7, 8, 6, 'Portales', '01:00:00', 7),
(8, 6, 2, 'Interplaza', '00:00:02', 0),
(9, 2, 4, 'Plaza Americas', '10:20:00', 7);

--
-- Disparadores `funciones`
--
DELIMITER $$
CREATE TRIGGER `asientos funcion` AFTER INSERT ON `funciones` FOR EACH ROW BEGIN
INSERT INTO `asientos` VALUES
('A-1', new.idFuncion, 0),
('A-2', new.idFuncion, 0),
('A-3', new.idFuncion, 0),
('A-4', new.idFuncion, 0),
('A-5', new.idFuncion, 0),
('A-6', new.idFuncion, 0),
('A-7', new.idFuncion, 0),
('A-8', new.idFuncion, 0),
('A-9', new.idFuncion, 0),
('A-10', new.idFuncion, 0),
('B-1', new.idFuncion, 0),
('B-2', new.idFuncion, 0),
('B-3', new.idFuncion, 0),
('B-4', new.idFuncion, 0),
('B-5', new.idFuncion, 0),
('B-6', new.idFuncion, 0),
('B-7', new.idFuncion, 0),
('B-8', new.idFuncion, 0),
('B-9', new.idFuncion, 0),
('B-10', new.idFuncion, 0),
('C-1', new.idFuncion, 0),
('C-2', new.idFuncion, 0),
('C-3', new.idFuncion, 0),
('C-4', new.idFuncion, 0),
('C-5', new.idFuncion, 0),
('C-6', new.idFuncion, 0),
('C-7', new.idFuncion, 0),
('C-8', new.idFuncion, 0),
('C-9', new.idFuncion, 0),
('C-10', new.idFuncion, 0),
('D-1', new.idFuncion, 0),
('D-2', new.idFuncion, 0),
('D-3', new.idFuncion, 0),
('D-4', new.idFuncion, 0),
('D-5', new.idFuncion, 0),
('D-6', new.idFuncion, 0),
('D-7', new.idFuncion, 0),
('D-8', new.idFuncion, 0),
('D-9', new.idFuncion, 0),
('D-10', new.idFuncion, 0),
('E-1', new.idFuncion, 0),
('E-2', new.idFuncion, 0),
('E-3', new.idFuncion, 0),
('E-4', new.idFuncion, 0),
('E-5', new.idFuncion, 0),
('E-6', new.idFuncion, 0),
('E-7', new.idFuncion, 0),
('E-8', new.idFuncion, 0),
('E-9', new.idFuncion, 0),
('E-10', new.idFuncion, 0),
('F-1', new.idFuncion, 0),
('F-2', new.idFuncion, 0),
('F-3', new.idFuncion, 0),
('F-4', new.idFuncion, 0),
('F-5', new.idFuncion, 0),
('F-6', new.idFuncion, 0),
('F-7', new.idFuncion, 0),
('F-8', new.idFuncion, 0),
('F-9', new.idFuncion, 0),
('F-10', new.idFuncion, 0),
('G-1', new.idFuncion, 0),
('G-2', new.idFuncion, 0),
('G-3', new.idFuncion, 0),
('G-4', new.idFuncion, 0),
('G-5', new.idFuncion, 0),
('G-6', new.idFuncion, 0),
('G-7', new.idFuncion, 0),
('G-8', new.idFuncion, 0),
('G-9', new.idFuncion, 0),
('G-10', new.idFuncion, 0),
('H-1', new.idFuncion, 0),
('H-2', new.idFuncion, 0),
('H-3', new.idFuncion, 0),
('H-4', new.idFuncion, 0),
('H-5', new.idFuncion, 0),
('H-6', new.idFuncion, 0),
('H-7', new.idFuncion, 0),
('H-8', new.idFuncion, 0),
('H-9', new.idFuncion, 0),
('H-10', new.idFuncion, 0),
('I-1', new.idFuncion, 0),
('I-2', new.idFuncion, 0),
('I-3', new.idFuncion, 0),
('I-4', new.idFuncion, 0),
('I-5', new.idFuncion, 0),
('I-6', new.idFuncion, 0),
('I-7', new.idFuncion, 0),
('I-8', new.idFuncion, 0),
('I-9', new.idFuncion, 0),
('I-10', new.idFuncion, 0);



END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `multimedia`
--

CREATE TABLE `multimedia` (
  `NoRegistro` int(10) NOT NULL,
  `Afiche` varchar(255) COLLATE utf8mb4_bin NOT NULL,
  `Trailer` varchar(255) COLLATE utf8mb4_bin NOT NULL,
  `estadoMultimedia` int(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `multimedia`
--

INSERT INTO `multimedia` (`NoRegistro`, `Afiche`, `Trailer`, `estadoMultimedia`) VALUES
(1, 'https://img.europapress.es/fotoweb/fotonoticia_20190531140023_640.jpg', 'https://www.youtube.com/watch?v=8foZzQf1L9o&t=3s', 0),
(2, 'https://img-cdn.hipertextual.com/files/2019/06/hipertextual-4-trajes-spider-man-lejos-casa-nuevo-trailer-2019196176.jpg?strip=all&lossy=1&quality=57&resize=740%2C490&ssl=1', 'https://www.youtube.com/watch?v=s1OxOBPWBeU', 0),
(3, 'https://visitkearney.org/wp-content/uploads/hotel-mumbai.jpg', 'https://www.youtube.com/watch?v=td03ewyR9LI', 0),
(5, 'http://www.endorfina.mx/wp-content/uploads/2019/06/4-360x290.jpg', 'https://www.youtube.com/watch?v=WPEgVaz9j2g', 0);

--
-- Disparadores `multimedia`
--
DELIMITER $$
CREATE TRIGGER `estado multimedia` AFTER UPDATE ON `multimedia` FOR EACH ROW BEGIN
UPDATE peliculas set estadoPelicula= new.estadoMultimedia WHERE multimedia=new.NoRegistro;
END
$$
DELIMITER ;

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
  `Idioma` varchar(45) COLLATE utf8mb4_bin DEFAULT NULL,
  `semanaEstrenoInicio` date DEFAULT NULL,
  `semanaEstrenoFin` date DEFAULT NULL,
  `estadoPelicula` int(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `peliculas`
--

INSERT INTO `peliculas` (`idPelicula`, `Titulo`, `Multimedia`, `Formato`, `Clasificación`, `Sinopsis`, `Idioma`, `semanaEstrenoInicio`, `semanaEstrenoFin`, `estadoPelicula`) VALUES
(2, 'Spider-Man: Lejos de casa', 2, '3D', 'B', 'Peter Parker regresa en Spider-Man: Lejos de casa el siguiente capítulo en la serie de Spider-Man: Homecoming. Nuestro amistoso vecino superhéroe decide unirse a sus mejores amigos Ned, MJ, y el resto del grupo a unas vacaciones europeas. Aunque, el plan de Peter sea dejar sus heroicidades atrás durante unas pocas semanas, pronto desecha esas ideas para ayudar a regañadientes a Nick Furia a desentrañar el misterio de los ataques de varias criaturas elementales, que están creando el caos en el mundo', 'Español', '2019-07-07', '2019-07-14', 0),
(5, 'El rey león', 1, '2D', 'A', 'EL REY LEÓN de Disney, dirigida por Jon Favreau, nos lleva a la sabana africana donde un futuro rey ha nacido. Simba idolatra a su padre, el rey Mufasa, y está entusiasmado con su destino real. Pero no todos en el reino celebran la llegada del nuevo cachorro. Scar, el hermano de Mufasa y antiguo heredero al trono, tiene sus propios planes. La batalla de La Roca del Rey se ve teñida de traición, tragedia y drama, y acaba forzando a Simba al exilio. Con la ayuda de una curiosa pareja de amigos nuevos, Simba tendrá que arreglárselas para crecer y recuperar lo que legítimamente le corresponde. El estelar reparto incluye a: Donald Glover como Simba, Beyoncé Knowles-Carter en el papel de Nala, James Earl Jones como Mufasa, Chiwetel Ejiofor como Scar, Seth Rogen como Pumba y Billy Eichner en el papel de Timón.', 'Subtitulada', '2019-07-10', '2019-07-19', 0),
(6, 'Desastre en París', 5, '2D', 'B', 'El día que una extraña niebla letal sumerge París, los supervivientes encuentran refugio en los pisos superiores de los edificios y en los tejados de la capital. Sin información, sin electricidad, sin agua ni comida, una pequeña familia trata de sobrevivir a este desastre. Pero pasan las horas y una cosa está clara: la ayuda no llegará y será necesario para poder salir, probar suerte en la niebla.', 'Español', '2019-07-01', '2019-07-17', 0),
(8, 'Hotel Mumbai', 3, '2D', 'B15', 'Una apasionante historia sobre humanidad y heroísmo, HOTEL MUMBAI cuenta vividamente el cerco de 2008 al Taj Hotel por un grupo de terroristas en Mumbai, India. Entre el personal del hotel se encuentra el renombrado chef Hemant Oberoi (Anupam Kher) y un camarero (Dev Patel) quienes eligen arriesgar sus vidas para proteger a los huéspedes, Mientras la situación avanza, una pareja desesperada (Armie Hammer y Nazanin Boniadi) se ve obligada hacer sacrificios impensables para proteger a su hijo recién nacido.', 'Español', '2019-08-07', '2019-08-31', 0);

--
-- Disparadores `peliculas`
--
DELIMITER $$
CREATE TRIGGER `estado funciones peli` AFTER UPDATE ON `peliculas` FOR EACH ROW BEGIN
UPDATE funciones set estadoFuncion = new.estadoPelicula WHERE funciones.idPelicula=new.idPelicula;
END
$$
DELIMITER ;

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
(1, 'Usuario'),
(2, 'Gerente'),
(3, 'Administrador');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reservaciones`
--

CREATE TABLE `reservaciones` (
  `idReservacion` int(11) NOT NULL,
  `idFuncion` int(11) DEFAULT NULL,
  `Fecha` date DEFAULT NULL,
  `Cine` varchar(45) COLLATE utf8mb4_bin DEFAULT NULL,
  `estadoReservacion` int(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `reservaciones`
--

INSERT INTO `reservaciones` (`idReservacion`, `idFuncion`, `Fecha`, `Cine`, `estadoReservacion`) VALUES
(1, 1, '2019-08-06', 'Portales', 0),
(2, 4, '2019-08-13', 'Portales', 0),
(3, 1, '2019-08-05', 'Portales', 0),
(9, 1, '0000-00-00', 'Portales', 0),
(10, 1, '2019-08-09', 'Portales', 0),
(11, 1, '2019-08-09', 'Portales', 0),
(12, 1, '2019-08-09', 'Portales', 0),
(13, 1, '0000-00-00', 'Portales', 0),
(14, 1, '0000-00-00', 'Portales', 0),
(15, 1, '2019-08-09', 'Portales', 0);

--
-- Disparadores `reservaciones`
--
DELIMITER $$
CREATE TRIGGER `estado detalle reservacion` AFTER UPDATE ON `reservaciones` FOR EACH ROW BEGIN
UPDATE detallereservacion
set estadoDetalleReservacion = new.estadoReservacion
WHERE detallereservacion.idReservacion = new.idReservacion;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `salas`
--

CREATE TABLE `salas` (
  `idSala` int(11) NOT NULL,
  `idCine` int(11) NOT NULL,
  `estadoSala` int(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `salas`
--

INSERT INTO `salas` (`idSala`, `idCine`, `estadoSala`) VALUES
(1, 1, 7),
(2, 4, 0),
(3, 5, 0),
(4, 3, 7),
(5, 2, 7),
(6, 1, 7);

--
-- Disparadores `salas`
--
DELIMITER $$
CREATE TRIGGER `estado funciones` AFTER UPDATE ON `salas` FOR EACH ROW BEGIN
UPDATE funciones set estadoFuncion = new.estadoSala WHERE funciones.idSala=new.idSala;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `timer`
--

CREATE TABLE `timer` (
  `noRegistro` int(11) NOT NULL,
  `Tiempo` int(10) NOT NULL,
  `Fecha` date NOT NULL,
  `Usuario` varchar(45) COLLATE utf8mb4_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `timer`
--

INSERT INTO `timer` (`noRegistro`, `Tiempo`, `Fecha`, `Usuario`) VALUES
(1, 120, '2019-08-03', 'Risko');

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
  `fechaInicio` date NOT NULL,
  `estadoUsuario` int(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`Usuario`, `idPerfil`, `password`, `DPI`, `Nombres`, `Apellidos`, `Telefono`, `Correo`, `Sexo`, `fechaNac`, `fechaInicio`, `estadoUsuario`) VALUES
('Gus', 3, 'b4288d9c0ec0a1841b3b3728321e7088', '3525036592121', 'Gustavo', 'Perez', '455221155', 'gus657@gmail.com', 'Masculino', '1998-08-08', '2019-07-07', 0),
('Risko', 2, 'dd3d7a65733c4e476c310d7cfd7a2460', '894652', 'Risko', 'Risko', '84651325354', 'risko@Risko.com', 'masculino', '2019-07-01', '2019-07-31', 0),
('edgar', 1, 'cf55ada960dedf6154b0d6905b2748ff', '444541541', 'Edgar', 'Casasola', '22665544', 'edgar@risko.com', 'Masculino', '2018-07-31', '2019-06-27', 0),
('rchocm', 1, 'e9a529231e0c7e68bb358b0db3453c75', '4896513', 'Randy', 'Choc', '44558899', 'randy@risko.com', 'Masculino', '2017-12-16', '2019-07-25', 0);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `asientos`
--
ALTER TABLE `asientos`
  ADD PRIMARY KEY (`idAsiento`,`idFuncion`),
  ADD KEY `idSala` (`idFuncion`);

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
  ADD KEY `idCiudad` (`idCiudad`),
  ADD KEY `estadoCine` (`estadoCine`);

--
-- Indices de la tabla `ciudades`
--
ALTER TABLE `ciudades`
  ADD PRIMARY KEY (`idCiudad`),
  ADD KEY `estadoCiudad` (`estadoCiudad`);

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
  ADD KEY `Costo` (`Costo`);

--
-- Indices de la tabla `detallereservacion`
--
ALTER TABLE `detallereservacion`
  ADD PRIMARY KEY (`numeroLinea`,`idReservacion`),
  ADD KEY `idFuncion` (`idFuncion`),
  ADD KEY `idAsiento` (`idAsiento`),
  ADD KEY `idReservasion` (`idReservacion`);

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
  ADD PRIMARY KEY (`idReservacion`),
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
  MODIFY `noReg` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=87;

--
-- AUTO_INCREMENT de la tabla `boletos`
--
ALTER TABLE `boletos`
  MODIFY `idBoleto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

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
-- AUTO_INCREMENT de la tabla `detallefactura`
--
ALTER TABLE `detallefactura`
  MODIFY `numeroLinea` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `detallereservacion`
--
ALTER TABLE `detallereservacion`
  MODIFY `numeroLinea` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT de la tabla `encabezadosfactura`
--
ALTER TABLE `encabezadosfactura`
  MODIFY `numeroFactura` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT de la tabla `funciones`
--
ALTER TABLE `funciones`
  MODIFY `idFuncion` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de la tabla `multimedia`
--
ALTER TABLE `multimedia`
  MODIFY `NoRegistro` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `peliculas`
--
ALTER TABLE `peliculas`
  MODIFY `idPelicula` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de la tabla `perfiles`
--
ALTER TABLE `perfiles`
  MODIFY `idPerfil` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `reservaciones`
--
ALTER TABLE `reservaciones`
  MODIFY `idReservacion` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT de la tabla `salas`
--
ALTER TABLE `salas`
  MODIFY `idSala` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

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
  ADD CONSTRAINT `asientos_ibfk_1` FOREIGN KEY (`idFuncion`) REFERENCES `funciones` (`idFuncion`) ON DELETE CASCADE ON UPDATE CASCADE;

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
  ADD CONSTRAINT `detallefactura_ibfk_3` FOREIGN KEY (`Costo`) REFERENCES `tiposboleto` (`Precio`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `detallereservacion`
--
ALTER TABLE `detallereservacion`
  ADD CONSTRAINT `detallereservacion_ibfk_1` FOREIGN KEY (`idFuncion`) REFERENCES `funciones` (`idFuncion`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `detallereservacion_ibfk_2` FOREIGN KEY (`idAsiento`) REFERENCES `asientos` (`idAsiento`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `detallereservacion_ibfk_4` FOREIGN KEY (`idReservacion`) REFERENCES `reservaciones` (`idReservacion`) ON DELETE CASCADE ON UPDATE CASCADE;

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
