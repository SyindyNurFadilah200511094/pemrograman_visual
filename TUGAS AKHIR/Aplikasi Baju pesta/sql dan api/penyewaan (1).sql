-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Хост: 10.0.2.30
-- Время создания: Июл 21 2023 г., 12:16
-- Версия сервера: 5.7.37-40
-- Версия PHP: 7.2.34

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `f0837623_akademik`
--

-- --------------------------------------------------------

--
-- Структура таблицы `penyewaan`
--

CREATE TABLE `penyewaan` (
  `id` int(10) NOT NULL,
  `nps` varchar(50) NOT NULL,
  `nama` varchar(20) NOT NULL,
  `jns_kostum` varchar(20) NOT NULL,
  `tgl_sewa` varchar(50) NOT NULL,
  `ukuran` varchar(40) NOT NULL,
  `harga` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `penyewaan`
--

INSERT INTO `penyewaan` (`id`, `nps`, `nama`, `jns_kostum`, `tgl_sewa`, `ukuran`, `harga`) VALUES
(6, '', '', '', '', '', '');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `penyewaan`
--
ALTER TABLE `penyewaan`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nps` (`nps`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `penyewaan`
--
ALTER TABLE `penyewaan`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
