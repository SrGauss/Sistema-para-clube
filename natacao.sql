-- phpMyAdmin SQL Dump
-- version 4.5.4.1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: 20-Set-2024 às 13:40
-- Versão do servidor: 5.7.11
-- PHP Version: 7.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `natacao`
--
CREATE DATABASE IF NOT EXISTS `natacao` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `natacao`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `contato`
--

DROP TABLE IF EXISTS `contato`;
CREATE TABLE IF NOT EXISTS `contato` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `endereco` varchar(50) NOT NULL,
  `telefone` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `siteOficial` varchar(50) NOT NULL,
  `redesSociais` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `dadosgerais`
--

DROP TABLE IF EXISTS `dadosgerais`;
CREATE TABLE IF NOT EXISTS `dadosgerais` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nomeCompleto` varchar(50) NOT NULL,
  `nomeAbreviado` varchar(50) NOT NULL,
  `dataFundacao` varchar(50) NOT NULL,
  `coresOficiais` varchar(50) NOT NULL,
  `patrocinadores` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `dadosgerais`
--

INSERT INTO `dadosgerais` (`id`, `nomeCompleto`, `nomeAbreviado`, `dataFundacao`, `coresOficiais`, `patrocinadores`) VALUES
(1, 'Minas Tênis Clube', 'MTC', '15/11/1935', 'Azul Royal e Branco', 'Prudential do Brasil / Melitta / Itambé / KTO');

-- --------------------------------------------------------

--
-- Estrutura da tabela `financeiro`
--

DROP TABLE IF EXISTS `financeiro`;
CREATE TABLE IF NOT EXISTS `financeiro` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `receita` varchar(50) NOT NULL,
  `despesas` varchar(50) NOT NULL,
  `patrimonioLiquido` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `historico`
--

DROP TABLE IF EXISTS `historico`;
CREATE TABLE IF NOT EXISTS `historico` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `titulosConquistados` varchar(50) NOT NULL,
  `participacoes` varchar(50) NOT NULL,
  `maioresVencedores` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `historico`
--

INSERT INTO `historico` (`id`, `titulosConquistados`, `participacoes`, `maioresVencedores`) VALUES
(1, 'Troféu Maria Lenk: 9     Troféu José Finkel: 11', ' Olimpíadas de Paris 24  Troféu José Finkel 2024', 'Cesar Cielo, Thiago Pereira  Marcus Mattioli');

-- --------------------------------------------------------

--
-- Estrutura da tabela `login`
--

DROP TABLE IF EXISTS `login`;
CREATE TABLE IF NOT EXISTS `login` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `usuario` varchar(50) NOT NULL,
  `senha` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `login`
--

INSERT INTO `login` (`id`, `usuario`, `senha`) VALUES
(1, 'Gustavo', 'Senha123'),
(2, 'admin', 'admin');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
