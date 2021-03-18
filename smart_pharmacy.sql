-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 28 ديسمبر 2020 الساعة 15:18
-- إصدار الخادم: 10.4.6-MariaDB
-- PHP Version: 7.1.32

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `smart pharmacy`
--

-- --------------------------------------------------------

--
-- بنية الجدول `admin`
--

CREATE TABLE `admin` (
  `id` int(11) NOT NULL,
  `name` varchar(22) NOT NULL,
  `email` varchar(200) NOT NULL,
  `password` varchar(200) NOT NULL,
  `img` varchar(300) NOT NULL,
  `priv_id` int(22) NOT NULL,
  `address` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- إرجاع أو استيراد بيانات الجدول `admin`
--

INSERT INTO `admin` (`id`, `name`, `email`, `password`, `img`, `priv_id`, `address`) VALUES
(4, 'ali', 'ali.com', '202cb962ac59075b964b07152d234b70', '5fc7c72ec1ba8.jpg', 1, 'egypt'),
(5, 'omar', 'omar.com', '202cb962ac59075b964b07152d234b70', '5fc7c778dc408.jpg', 2, 'dahp'),
(6, 'mai', 'mai.com', '202cb962ac59075b964b07152d234b70', '', 1, 'egypt'),
(7, 'yara', 'yara@com', '202cb962ac59075b964b07152d234b70', '', 1, 'egypt'),
(9, 'doaa', 'doa.com', '202cb962ac59075b964b07152d234b70', '', 3, 'egypt'),
(10, 'abmonsef', '22.12@com', '202cb962ac59075b964b07152d234b70', '', 2, 'egypt');

-- --------------------------------------------------------

--
-- بنية الجدول `cart`
--

CREATE TABLE `cart` (
  `id` int(11) NOT NULL,
  `user_id` int(22) NOT NULL,
  `pro_id` int(22) NOT NULL,
  `count` int(22) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- إرجاع أو استيراد بيانات الجدول `cart`
--

INSERT INTO `cart` (`id`, `user_id`, `pro_id`, `count`) VALUES
(1, 0, 21, 1),
(7, 4, 15, 7),
(9, 0, 26, 1),
(10, 4, 26, 1),
(11, 0, 26, 1),
(12, 6, 26, 1),
(16, 0, 35, 1),
(17, 4, 35, 1),
(18, 5, 35, 3),
(24, 10, 31, 2),
(25, 10, 25, 1),
(26, 4, 14, 1);

-- --------------------------------------------------------

--
-- بنية الجدول `catagerous`
--

CREATE TABLE `catagerous` (
  `id` int(11) NOT NULL,
  `name` varchar(22) NOT NULL,
  `img` varchar(300) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- إرجاع أو استيراد بيانات الجدول `catagerous`
--

INSERT INTO `catagerous` (`id`, `name`, `img`) VALUES
(1, 'pressure', ''),
(2, 'heart', ''),
(3, 'headache', ''),
(4, 'beauty', ''),
(5, 'baby care', ''),
(6, 'ear,nose and throat', ''),
(7, 'dermatophytes', ''),
(8, 'liver and disgestive', ''),
(9, 'kidney and urinary sys', ''),
(10, 'high temperature ', ''),
(11, 'eye', '');

-- --------------------------------------------------------

--
-- بنية الجدول `messages`
--

CREATE TABLE `messages` (
  `id` int(22) NOT NULL,
  `name` varchar(200) NOT NULL,
  `message` text NOT NULL,
  `email` int(200) NOT NULL,
  `img` varchar(300) NOT NULL,
  `phone` bigint(200) NOT NULL,
  `view` int(100) NOT NULL,
  `priv_id` int(22) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- إرجاع أو استيراد بيانات الجدول `messages`
--

INSERT INTO `messages` (`id`, `name`, `message`, `email`, `img`, `phone`, `view`, `priv_id`) VALUES
(1, 'ashraf ahmed', 'opipoipojopj', 22, '', 1019819243, 0, 0),
(3, 'sara', 'hi iam sara', 0, '', 215131531, 0, 0),
(4, 'ali', 'i want this medicine', 0, '', 315131513, 0, 0),
(5, 'hassan', 'i want this', 22, '', 2135131, 0, 0),
(6, 'ashraf ahmed', 'i want aspirne', 22, '', 1019819243, 0, 0),
(7, 'olaa', 'i want ansolne ', 22, '', 3511351, 0, 0),
(8, 'olaa', 'ughkg;kgefb;E;FG;', 22, '', 213511351, 0, 0),
(9, 'olaa', 'i want ansolne', 22, '', 3513131, 0, 0),
(10, 'olaa', 'i want ansolne', 22, '', 1019819243, 0, 0);

-- --------------------------------------------------------

--
-- بنية الجدول `orders`
--

CREATE TABLE `orders` (
  `id` int(22) NOT NULL,
  `name` varchar(22) NOT NULL,
  `status` int(22) NOT NULL,
  `username` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- بنية الجدول `orders-details`
--

CREATE TABLE `orders-details` (
  `id` int(22) NOT NULL,
  `name` varchar(22) NOT NULL,
  `ordersid` int(22) NOT NULL,
  `price` int(22) NOT NULL,
  `quantity` int(22) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- بنية الجدول `priv`
--

CREATE TABLE `priv` (
  `id` int(11) NOT NULL,
  `name` text NOT NULL,
  `priv_id` int(22) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- إرجاع أو استيراد بيانات الجدول `priv`
--

INSERT INTO `priv` (`id`, `name`, `priv_id`) VALUES
(1, 'admin', 0),
(2, 'user', 0),
(3, 'doctor', 0);

-- --------------------------------------------------------

--
-- بنية الجدول `products`
--

CREATE TABLE `products` (
  `id` int(11) NOT NULL,
  `name` varchar(22) NOT NULL,
  `img` varchar(300) NOT NULL,
  `ex_date` date NOT NULL,
  `price` int(200) NOT NULL,
  `stock` int(22) NOT NULL,
  `cat_id` int(22) NOT NULL,
  `description` longtext NOT NULL,
  `offer` int(22) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- إرجاع أو استيراد بيانات الجدول `products`
--

INSERT INTO `products` (`id`, `name`, `img`, `ex_date`, `price`, `stock`, `cat_id`, `description`, `offer`) VALUES
(13, 'actand', '5fc0bcb2763bd.jpg', '2020-11-18', 73, 0, 2, '', 0),
(14, 'aspirine', '5fc0c2d084c77.jpg', '2020-11-21', 40, 0, 3, '', 0),
(15, 'coderx', '5fc0c317eb47d.jpg', '2020-11-13', 66, 0, 1, '', 0),
(16, 'digitex', '5fc0c38f8991b.jpg', '2020-11-14', 55, 6, 1, '', 0),
(17, 'lanoxin', '5fc0c40e5cd33.jpg', '2020-11-24', 76, 0, 2, '', 0),
(18, 'dolomal', '5fc41f3d2771b.jpg', '2020-11-18', 63, 0, 3, '', 0),
(19, 'inderal tablets', '5fc420b1a6a4d.jpg', '2020-11-10', 55, 0, 2, '', 0),
(21, 'ouidad', '5fc531bee294e.jpg', '2020-11-19', 56, 14, 4, '', 51),
(22, 'argan', '5fc532f8ab1f5.jpg', '2020-11-19', 57, 13, 4, '', 51),
(23, 'living proof', '5fc533205d63a.jpg', '2020-11-18', 60, 9, 4, '', 55),
(24, 'kerastes', '5fc4261fa3cbe.jpg', '2020-11-27', 58, 0, 4, '', 0),
(25, 'baby pants', '5fc4271962798.jpg', '2020-11-12', 45, 4, 5, '', 0),
(26, 'tylenol cold', '5fc4281be16ce.jpg', '2020-11-18', 38, 0, 5, '', 0),
(27, 'vitamines', '5fc42884a3893.jpg', '2020-11-18', 30, 0, 5, '', 0),
(30, 'oramax', '5fcec257229b4.jpg', '2020-12-15', 30, 0, 6, '', 0),
(31, 'frost', '5fcec394cac38.jpg', '0000-00-00', 40, 0, 10, '', 0),
(32, 'strepcil', '5fcec47208e0b.jpg', '2020-12-17', 65, 0, 6, '', 0),
(33, 'scaro', '5fcec4da7a923.jpg', '2020-12-17', 98, 0, 7, '', 0),
(34, 'ursochol', '5fcec57b96652.jpg', '2020-12-13', 28, 0, 9, '', 0);

-- --------------------------------------------------------

--
-- بنية الجدول `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `name` varchar(22) NOT NULL,
  `email` varchar(200) NOT NULL,
  `password` varchar(200) NOT NULL,
  `img` varchar(300) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- إرجاع أو استيراد بيانات الجدول `users`
--

INSERT INTO `users` (`id`, `name`, `email`, `password`, `img`) VALUES
(1, 'ali', 'ali.com', '123', ''),
(2, 'sara', 'sara.com', '123', '');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `cart`
--
ALTER TABLE `cart`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `catagerous`
--
ALTER TABLE `catagerous`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `messages`
--
ALTER TABLE `messages`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `orders-details`
--
ALTER TABLE `orders-details`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `priv`
--
ALTER TABLE `priv`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `cart`
--
ALTER TABLE `cart`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT for table `catagerous`
--
ALTER TABLE `catagerous`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `messages`
--
ALTER TABLE `messages`
  MODIFY `id` int(22) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `id` int(22) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `orders-details`
--
ALTER TABLE `orders-details`
  MODIFY `id` int(22) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `priv`
--
ALTER TABLE `priv`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=36;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
