-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: mysql-sistemamediosav.alwaysdata.net
-- Generation Time: Nov 13, 2021 at 07:42 AM
-- Server version: 10.5.11-MariaDB
-- PHP Version: 7.4.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sistemamediosav_db`
--
CREATE DATABASE IF NOT EXISTS `sistemamediosav_db` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `sistemamediosav_db`;

-- --------------------------------------------------------

--
-- Table structure for table `APARTADORECURSO`
--

CREATE TABLE IF NOT EXISTS `APARTADORECURSO` (
  `IdApartadoRec` int(11) NOT NULL AUTO_INCREMENT,
  `Fecha` date NOT NULL,
  `Docente` varchar(100) NOT NULL,
  `Alumno` varchar(100) NOT NULL,
  `Nc` varchar(100) NOT NULL,
  `Edificio` varchar(25) NOT NULL,
  `Aula` varchar(10) NOT NULL,
  PRIMARY KEY (`IdApartadoRec`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `APARTADOS-LUGAR`
--

CREATE TABLE IF NOT EXISTS `APARTADOS-LUGAR` (
  `IdApartado` int(5) NOT NULL AUTO_INCREMENT,
  `IdLugar` int(5) NOT NULL,
  `Docente` varchar(100) NOT NULL,
  `Alumno` varchar(100) NOT NULL,
  `Nc` varchar(100) NOT NULL,
  `Concepto` varchar(225) NOT NULL,
  `Fecha` date NOT NULL,
  `HoraInicial` time NOT NULL,
  `HoraFinal` time NOT NULL,
  `Estado` varchar(25) NOT NULL,
  PRIMARY KEY (`IdApartado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `ATENCIONFALLAS`
--

CREATE TABLE IF NOT EXISTS `ATENCIONFALLAS` (
  `IdAtencion` int(11) NOT NULL AUTO_INCREMENT,
  `IdReporte` int(11) NOT NULL,
  `TipoReporte` varchar(100) NOT NULL,
  `FechaSeguimiento` date NOT NULL,
  `QuienAtiende` varchar(225) NOT NULL,
  `Estado` varchar(225) NOT NULL,
  PRIMARY KEY (`IdAtencion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `BAJAS`
--

CREATE TABLE IF NOT EXISTS `BAJAS` (
  `IdBaja` int(11) NOT NULL AUTO_INCREMENT,
  `IdRecurso` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `Concepto` varchar(225) NOT NULL,
  `Autoriza` varchar(225) NOT NULL,
  PRIMARY KEY (`IdBaja`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `bitacora`
--

CREATE TABLE IF NOT EXISTS `bitacora` (
  `id` int(6) NOT NULL AUTO_INCREMENT,
  `formulario` varchar(25) NOT NULL,
  `descripcion` varchar(50) NOT NULL,
  `error` varchar(25) NOT NULL,
  `fecha` varchar(25) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `CATEGORIA`
--

CREATE TABLE IF NOT EXISTS `CATEGORIA` (
  `idCategoria` int(11) NOT NULL AUTO_INCREMENT,
  `Concepto` varchar(100) NOT NULL,
  PRIMARY KEY (`idCategoria`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `CAÑONES`
--

CREATE TABLE IF NOT EXISTS `CAÑONES` (
  `IdRecurso` int(11) NOT NULL,
  `INVCAPECE` varchar(100) NOT NULL,
  `FechaAdq` date NOT NULL,
  `FechaUltMantto` date NOT NULL,
  `Modelo` varchar(100) NOT NULL,
  `Marca` varchar(100) NOT NULL,
  `NoSerie` varchar(100) NOT NULL,
  `HorasLampara` int(9) NOT NULL,
  `Observaciones` varchar(100) NOT NULL,
  `Estado` varchar(100) NOT NULL,
  PRIMARY KEY (`IdRecurso`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `COMPUTADORAS`
--

CREATE TABLE IF NOT EXISTS `COMPUTADORAS` (
  `IdRecurso` int(11) NOT NULL,
  `INVCAPECE` varchar(100) NOT NULL,
  `FechaAdq` date NOT NULL,
  `FechaUltMantto` date NOT NULL,
  `Modelo` varchar(100) NOT NULL,
  `Marca` varchar(100) NOT NULL,
  `NoSerie` varchar(100) NOT NULL,
  `Procesador` varchar(100) NOT NULL,
  `Memoria` varchar(100) NOT NULL,
  `HDD` varchar(100) NOT NULL,
  `Estado` varchar(100) NOT NULL,
  PRIMARY KEY (`IdRecurso`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `DETALLE-SUP-RECURSO`
--

CREATE TABLE IF NOT EXISTS `DETALLE-SUP-RECURSO` (
  `IdSupervision` int(11) NOT NULL,
  `IdRecursoAsignado` int(11) NOT NULL,
  `ObservaRecurso` varchar(225) NOT NULL,
  `HorasTrabajadas` int(11) DEFAULT NULL,
  `ImagenRecurso` varchar(225) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `DETALLEAPARTADORECURSO`
--

CREATE TABLE IF NOT EXISTS `DETALLEAPARTADORECURSO` (
  `IdApartadoRec` int(11) NOT NULL AUTO_INCREMENT,
  `IdRecurso` int(11) NOT NULL,
  `CantidadPrest` int(11) NOT NULL,
  `CantidadDev` int(11) DEFAULT NULL,
  `FechaDev` date DEFAULT NULL,
  PRIMARY KEY (`IdApartadoRec`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `DETALLEATENCIONFALLAS`
--

CREATE TABLE IF NOT EXISTS `DETALLEATENCIONFALLAS` (
  `IdAtencion` int(11) NOT NULL,
  `IdRecurso` int(11) NOT NULL,
  `TipoAtencion` varchar(225) NOT NULL,
  `Observaciones` varchar(225) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `LUGAR`
--

CREATE TABLE IF NOT EXISTS `LUGAR` (
  `idLugar` int(11) NOT NULL AUTO_INCREMENT,
  `Concepto` varchar(100) NOT NULL,
  PRIMARY KEY (`idLugar`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `PANTALLAS`
--

CREATE TABLE IF NOT EXISTS `PANTALLAS` (
  `IdRecurso` int(11) NOT NULL,
  `Tipo` varchar(100) NOT NULL,
  `INVCAPECE` varchar(100) NOT NULL,
  `Marca` varchar(100) NOT NULL,
  `Modelo` varchar(100) NOT NULL,
  `Dimension` varchar(100) NOT NULL,
  `Estado` varchar(50) NOT NULL,
  PRIMARY KEY (`IdRecurso`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `PREVENTIVO`
--

CREATE TABLE IF NOT EXISTS `PREVENTIVO` (
  `IdPreventivo` int(11) NOT NULL AUTO_INCREMENT,
  `Tipo` varchar(225) NOT NULL,
  `FechaInicio` date NOT NULL,
  `FechaFin` date NOT NULL,
  `IdRecurso` int(11) NOT NULL,
  `Concepto` varchar(225) NOT NULL,
  `QuienAtiende` varchar(225) NOT NULL,
  `Observacion` varchar(225) NOT NULL,
  `Estado` varchar(225) NOT NULL,
  PRIMARY KEY (`IdPreventivo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `RECURSOS`
--

CREATE TABLE IF NOT EXISTS `RECURSOS` (
  `idRecursos` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(100) NOT NULL,
  `idCategoria` int(11) NOT NULL,
  PRIMARY KEY (`idRecursos`,`idCategoria`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `RECURSOSASIGNADOS`
--

CREATE TABLE IF NOT EXISTS `RECURSOSASIGNADOS` (
  `IdRecursoAsignado` int(11) NOT NULL AUTO_INCREMENT,
  `IdRecurso` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `Edificio` varchar(100) NOT NULL,
  `Aula` varchar(100) NOT NULL,
  `Responsable` varchar(100) NOT NULL,
  `Estado` varchar(100) NOT NULL,
  PRIMARY KEY (`IdRecursoAsignado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `REPORTEDOCENTES`
--

CREATE TABLE IF NOT EXISTS `REPORTEDOCENTES` (
  `IdReporte` int(11) NOT NULL AUTO_INCREMENT,
  `Docente` varchar(225) NOT NULL,
  `Fecha` date NOT NULL,
  `Edificio` varchar(225) NOT NULL,
  `Aula` varchar(225) NOT NULL,
  `HoraIC` time NOT NULL,
  `HoraFC` time NOT NULL,
  `ObservacionesGrales` varchar(225) NOT NULL,
  `Estado` varchar(225) NOT NULL,
  PRIMARY KEY (`IdReporte`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `REPORTESRECURSOSINDIVIDUALES`
--

CREATE TABLE IF NOT EXISTS `REPORTESRECURSOSINDIVIDUALES` (
  `IdReporteRecursos` int(11) NOT NULL AUTO_INCREMENT,
  `IdRecurso` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `Concepto` varchar(225) NOT NULL,
  `Estado` varchar(225) NOT NULL,
  PRIMARY KEY (`IdReporteRecursos`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `SUPERVISION`
--

CREATE TABLE IF NOT EXISTS `SUPERVISION` (
  `IdSupervision` int(11) NOT NULL AUTO_INCREMENT,
  `Fecha` date NOT NULL,
  `Responsable` varchar(100) NOT NULL,
  `Edificio` varchar(20) NOT NULL,
  `Aula` varchar(10) NOT NULL,
  `ObservaCajaConex` varchar(225) DEFAULT NULL,
  `ImagenCajaConex` varchar(225) DEFAULT NULL,
  `ObservaConectorElect` varchar(225) DEFAULT NULL,
  `ImagenConectorElect` varchar(225) DEFAULT NULL,
  `ObservaPintarrón` varchar(225) DEFAULT NULL,
  `ImagenPintarrón` varchar(225) DEFAULT NULL,
  `ObservaElectricidad` varchar(225) DEFAULT NULL,
  `ImagenElect` varchar(225) DEFAULT NULL,
  `ObservaLámparas` varchar(225) DEFAULT NULL,
  `ImagenLamparas` varchar(225) DEFAULT NULL,
  `ObservaVentanas` varchar(225) DEFAULT NULL,
  `ImagenVentanas` varchar(225) DEFAULT NULL,
  PRIMARY KEY (`IdSupervision`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
