-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Apr 13, 2020 at 09:17 AM
-- Server version: 10.4.10-MariaDB
-- PHP Version: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `softaware`
--

-- --------------------------------------------------------

--
-- Table structure for table `newsletter`
--

DROP TABLE IF EXISTS `newsletter`;
CREATE TABLE IF NOT EXISTS `newsletter` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `email` varchar(100) COLLATE latin2_bin NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `email` (`email`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=latin2 COLLATE=latin2_bin;

--
-- Dumping data for table `newsletter`
--

INSERT INTO `newsletter` (`id`, `email`) VALUES
(1, 'user1@user1.user'),
(2, 'user2@mail.connection'),
(3, 'asdf@asdf.com'),
(5, 'novi@mail.a'),
(6, 'jos@jedan.korisnik'),
(7, 'anchor@test.t');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `idUser` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(60) COLLATE latin2_bin NOT NULL,
  `password` varchar(300) COLLATE latin2_bin NOT NULL,
  `email` varchar(90) COLLATE latin2_bin NOT NULL,
  PRIMARY KEY (`idUser`),
  UNIQUE KEY `username` (`username`)
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=latin2 COLLATE=latin2_bin;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`idUser`, `username`, `password`, `email`) VALUES
(1, 'user1', '5f4dcc3b5aa765d61d8327deb882cf99', 'mail@mail.mail'),
(2, 'user2', '5f4dcc3b5aa765d61d8327deb882cf99', 'user2@email.com'),
(7, 'mail', '5f4dcc3b5aa765d61d8327deb882cf99', 'email@mail.com'),
(8, 'noviKorisnik', '5f4dcc3b5aa765d61d8327deb882cf99', 'novi@korisnik.com'),
(9, 'passMan', '6eea9b7ef19179a06954edd0f6c05ceb', 'asdf@asdf.com');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
