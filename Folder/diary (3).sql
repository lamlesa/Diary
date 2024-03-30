-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Mar 30, 2024 at 07:53 PM
-- Server version: 5.7.24
-- PHP Version: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `diary`
--

-- --------------------------------------------------------

--
-- Table structure for table `subjects`
--

CREATE TABLE `subjects` (
  `ID` int(11) UNSIGNED NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Professor` varchar(50) NOT NULL,
  `WeekDay` varchar(11) NOT NULL,
  `Time` time NOT NULL,
  `Status` varchar(4) NOT NULL,
  `Aud` varchar(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `subjects`
--

INSERT INTO `subjects` (`ID`, `Name`, `Professor`, `WeekDay`, `Time`, `Status`, `Aud`) VALUES
(6, 'Матанализ', 'Сидоров А. М.', '0', '08:30:00', '', '0'),
(7, 'Матанализ', 'Сидоров А. М.', 'Понедельник', '08:30:00', 'Main', '0'),
(8, 'Матанализ', 'Сидоров А.М.', 'Вторник', '10:10:00', '', '0'),
(10, 'Программирование', 'Фадеева Е.В.', 'Среда', '12:10:00', 'Main', '0'),
(11, 'Программирование', 'Фадеева Е.В.', 'Вторник', '08:30:00', '', '0'),
(12, 'Программирование', 'Фадеева Е.В.', 'Среда', '08:30:00', 'None', '1105'),
(13, 'Программирование', 'Фадеева Е.В.', 'Среда', '08:30:00', 'None', '1105'),
(14, 'Матанализ', 'Сидоров А. М.', 'Среда', '10:10:00', 'None', '108'),
(15, 'Матанализ', 'Сидоров А. М.', 'Среда', '10:10:00', 'None', '108'),
(22, 'Русский', 'Файзуллина Э.Ф.', 'Пятница', '12:10:00', 'None', '1113'),
(18, 'Английский', 'Закирова Г.Ш.', 'Понедельник', '10:10:00', 'None', '403'),
(20, 'Английский', 'Закирова Г.Ш.', 'Понедельник', '10:10:00', 'None', '403'),
(23, 'Правоведение', 'Окриашвили Т.Г.', 'Среда', '12:10:00', 'None', '1012'),
(24, 'Русский', 'Файзуллина Э.Ф.', 'Пятница', '12:10:00', 'None', '1113'),
(25, 'Правоведение', 'Окриашвили Т.Г.', 'Среда', '12:10:00', 'None', '1012');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `ID` int(11) UNSIGNED NOT NULL,
  `Login` varchar(100) NOT NULL,
  `Password` varchar(33) NOT NULL,
  `Role` varchar(7) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Surname` varchar(50) NOT NULL,
  `Group` varchar(9) NOT NULL,
  `Math_Info` text NOT NULL,
  `Prog_Info` text NOT NULL,
  `Phys_Info` text NOT NULL,
  `Eng_Info` text NOT NULL,
  `Alg_Info` text NOT NULL,
  `His_Info` text NOT NULL,
  `Rus_Info` text NOT NULL,
  `Law_Info` text NOT NULL,
  `UPic` varchar(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`ID`, `Login`, `Password`, `Role`, `Name`, `Surname`, `Group`, `Math_Info`, `Prog_Info`, `Phys_Info`, `Eng_Info`, `Alg_Info`, `His_Info`, `Rus_Info`, `Law_Info`, `UPic`) VALUES
(20, 'rh', '123', 'Student', 'игорь', 'крутой', '09-322', '', '', '', '', '', '', '', '', ''),
(7, 'clock', '1234', 'Student', 'Иван', 'Иванов', '09-321', 'Хороший предмет. Нейтральный.нравится мненравится мнекруто круто', 'Крутой предмет. Положительный.', 'Злой предмет. Отрицательный.', '', '', 'Ужас. тихий. и беспощадный.', ' хороший крутой я бы сказала', '', 'C:\\Users\\ламлеса\\Pictures\\Saved Pictures\\обои.jpg'),
(8, 'tree', '234', 'Student', 'крутыш', 'крутышев', '09-321', '', '', '', '', '', '', '', '', ''),
(6, 'Cool', '123', 'Admin', 'Шариф', 'Сырков', '09-322', '', '', '', '', '', '', '', '', ''),
(10, 'kiri4800', '1234', 'Admin', 'Кирич', 'Прыгунов', '09-321', '', '', '', '', '', '', '', '', ''),
(22, 'yesmir', '123', 'Admin', 'Дамир', 'Усманов', '09-322', '', '', '', '', '', '', '', '', ''),
(17, 'green', '123', 'Admin', 'Сергей', 'f', '09-321', '', '', '', '', '', '', '', '', 'C:\\Users\\ламлеса\\Pictures\\Saved Pictures\\собакен.jpg'),
(19, 'lamlesa', '123', 'Admin', 'Леся', 'Морозова', '09-322', '', '', '', '', '', '', '', '', ''),
(21, 'julsor', '123', 'Student', 'Юлия', 'Сороквашина', '09-322', '', '', '', '', '', '', '', '', ''),
(23, 'f', '34', 'Student', 'h', 'h', '09-322', '', '', '', '', '', '', '', '', ''),
(25, 'sab', '123', 'Student', 'Сабина', 'Низамова', '09-322', '', '', '', '', '', '', '', '', '');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `subjects`
--
ALTER TABLE `subjects`
  ADD UNIQUE KEY `ID` (`ID`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD UNIQUE KEY `ID` (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `subjects`
--
ALTER TABLE `subjects`
  MODIFY `ID` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `ID` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
