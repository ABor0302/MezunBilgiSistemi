-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 23 May 2024, 14:02:02
-- Sunucu sürümü: 10.4.32-MariaDB
-- PHP Sürümü: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `mezunbilgisistemi`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `mezunbilgileri`
--

CREATE TABLE `mezunbilgileri` (
  `ogrenci_no` int(11) NOT NULL,
  `ad` varchar(50) DEFAULT NULL,
  `soyad` varchar(50) DEFAULT NULL,
  `mezuniyet_tarihi` date DEFAULT NULL,
  `ceptel` varchar(15) DEFAULT NULL,
  `eposta` varchar(100) DEFAULT NULL,
  `evtel` varchar(15) DEFAULT NULL,
  `evulke` varchar(50) DEFAULT NULL,
  `evsehir` varchar(50) DEFAULT NULL,
  `evadres` varchar(255) DEFAULT NULL,
  `AkademikEgitim` varchar(100) DEFAULT NULL,
  `Baslangic` date DEFAULT NULL,
  `Bitis` date DEFAULT NULL,
  `Ulke` varchar(50) DEFAULT NULL,
  `Sehir` varchar(50) DEFAULT NULL,
  `Universite` varchar(100) DEFAULT NULL,
  `Bolum` varchar(100) DEFAULT NULL,
  `IseGirisTarihi` date DEFAULT NULL,
  `IstenAyrilisTarihi` date DEFAULT NULL,
  `KamuOzel` enum('Kamu','Özel') DEFAULT NULL,
  `Sektor` varchar(50) DEFAULT NULL,
  `Unvan` varchar(50) DEFAULT NULL,
  `Pozisyon` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `mezunbilgileri`
--

INSERT INTO `mezunbilgileri` (`ogrenci_no`, `ad`, `soyad`, `mezuniyet_tarihi`, `ceptel`, `eposta`, `evtel`, `evulke`, `evsehir`, `evadres`, `AkademikEgitim`, `Baslangic`, `Bitis`, `Ulke`, `Sehir`, `Universite`, `Bolum`, `IseGirisTarihi`, `IstenAyrilisTarihi`, `KamuOzel`, `Sektor`, `Unvan`, `Pozisyon`) VALUES
(1, 'Ali', 'Yılmaz', '2005-06-25', '05551234567', 'ali@example.com', '02121234567', 'Türkiye', 'İstanbul', 'Örnek Mahallesi, Örnek Sokak, No: 1', 'Lisans', '1999-06-25', '2005-06-25', 'Türkiye', 'Ankara', 'Hacettepe Üniversitesi', 'Makine Mühendisliği', '2010-04-09', '2021-12-31', 'Özel', 'Mühendislik', 'Makine Mühendisi', 'Proje Yöneticisi'),
(2, 'Emel', 'Kaya', '2005-09-07', '05557654321', 'ayse@example.com', '03121234567', 'Türkiye', 'Ankara', 'Deneme Mahallesi, Deneme Sokak, No: 12', 'Yüksek Lisans', '2016-09-01', '2018-06-30', 'Türkiye', 'İzmir', 'Ege Üniversitesi', 'İşletme', '2020-07-15', '2020-12-31', 'Özel', 'İşletme', 'Yönetici', 'Satış Müdürü'),
(3, 'Mehmet', 'Demir', '2008-10-08', NULL, NULL, NULL, 'Türkiye', 'İzmir', 'Test Mahallesi, Test Sokak, No: 5', 'Lisans', '2004-10-08', '2008-10-08', 'ABD', 'New York', 'New York Üniversitesi', 'Bilgisayar Bilimi', '2015-05-18', '2022-12-31', 'Özel', 'Teknoloji', 'Yazılım Mühendisi', 'Kıdemli Yazılım Geliştirici'),
(4, 'Fatma', 'Şahin', '2008-07-29', '05553337788', 'fatma@example.com', NULL, 'Türkiye', 'Bursa', 'Örnek Mahallesi, Deneme Sokak, No: 20', 'Lisans', '2003-07-29', '2008-07-29', 'Türkiye', 'İstanbul', 'Boğaziçi Üniversitesi', 'Ekonomi', '2018-08-30', '2024-03-31', 'Özel', 'Bankacılık', 'Müşteri İlişkileri Yöneticisi', 'Kıdemli Müşteri İlişkileri Yöneticisi'),
(5, 'Ahmet', 'Yıldız', '2009-04-03', NULL, 'ahmet@example.com', NULL, 'Türkiye', 'Antalya', 'Test Mahallesi, Örnek Sokak, No: 7', 'Lisans', '2006-04-03', '2009-04-03', 'Türkiye', 'İstanbul', 'İstanbul Teknik Üniversitesi', 'Endüstri Mühendisliği', '2014-05-23', '2023-09-30', 'Özel', 'Üretim', 'Üretim Planlama Uzmanı', 'Üretim Planlama Müdürü'),
(6, 'Zeynep', 'Çelik', '2005-05-14', '05554443322', NULL, '03421234567', 'Türkiye', 'Adana', 'Deneme Mahallesi, Test Sokak, No: 15', 'Doktora', '2018-09-01', '2023-06-30', 'ABD', 'Los Angeles', 'California Üniversitesi', 'Fizik', '2024-04-20', NULL, '', NULL, 'Araştırma Görevlisi', 'Doktora Sonrası Araştırmacı'),
(7, 'Mustafa', 'Kurt', '2008-07-01', '05559998877', 'mustafa@example.com', '02125432100', 'Türkiye', 'Trabzon', 'Örnek Mahallesi, Deneme Sokak, No: 3', 'Lisans', '2004-07-01', '2008-07-01', 'Türkiye', 'İstanbul', 'Boğaziçi Üniversitesi', 'Bilgisayar Mühendisliği', '2021-07-30', '2022-12-31', 'Özel', 'Teknoloji', 'Yazılım Geliştirici', 'Yazılım Mühendisi'),
(8, 'Ayhan', 'Aydın', '2007-12-22', '05556667788', 'ayhan@example.com', NULL, 'Türkiye', 'Eskişehir', 'Test Mahallesi, Test Sokak, No: 9', 'Lisans', '2001-12-22', '2007-12-22', 'Türkiye', 'Ankara', 'Orta Doğu Teknik Üniversitesi', 'Elektrik Elektronik Mühendisliği', '2009-06-03', '2024-02-28', 'Kamu', 'Enerji', 'Mühendis', 'Elektrik Mühendisi'),
(9, 'Emine', 'Arslan', '2000-11-15', '05557778899', NULL, NULL, 'Türkiye', 'Konya', 'Deneme Mahallesi, Örnek Sokak, No: 11', 'Yüksek Lisans', '2019-09-01', '2021-06-30', 'Almanya', 'Berlin', 'Teknik Üniversite Berlin', 'Makine Mühendisliği', '2022-05-11', NULL, 'Özel', 'Otomotiv', 'Tasarım Mühendisi', 'Kıdemli Tasarım Mühendisi'),
(10, 'İbrahim', 'Öztürk', '2008-09-27', NULL, NULL, '02222222222', 'Türkiye', 'İzmit', 'Örnek Mahallesi, Deneme Sokak, No: 8', 'Lisans', '2004-09-27', '2008-09-27', 'Türkiye', 'İstanbul', 'İstanbul Teknik Üniversitesi', 'Makine Mühendisliği', '2019-11-14', '2023-08-31', 'Özel', 'Enerji', 'Makine Mühendisi', 'Proje Mühendisi'),
(21, 'Deniz', 'Kurt', '2000-05-30', '5557778899', 'deniz@example.com', '2245552233', 'Türkiye', 'İzmir', 'Örnek Bulvar', 'Yüksek Lisans', '2019-10-15', '2023-09-18', 'Türkiye', 'İzmir', 'Ege Üniversitesi', 'İşletme', '2023-05-27', NULL, 'Özel', NULL, 'Yönetici', 'Satış Müdürü'),
(22, 'Can', 'Yıldırım', '2005-09-02', '5558889900', 'can@example.com', '3125553344', 'Türkiye', 'Ankara', 'Örnek Cadde', 'Doktora', '2018-09-01', '2022-12-05', 'ABD', 'Ankara', 'Ankara Üniversitesi', 'İktisat', '2022-06-27', NULL, 'Kamu', NULL, 'Uzman', 'Ekonomist'),
(23, 'Nazlı', 'Şahin', '2006-06-24', '5559990011', 'nazli@example.com', '2165555566', 'Türkiye', 'İstanbul', 'Örnek Köy', 'Lisans', '2002-06-24', '2006-06-24', 'Türkiye', 'İstanbul', 'Boğaziçi Üniversitesi', 'Tıp', '2016-02-15', NULL, 'Özel', NULL, 'Doktor', 'Cerrah'),
(24, 'Kaan', 'Kaya', '2010-07-28', '5551122334', 'kaan@example.com', '3125556677', 'Türkiye', 'Ankara', 'Örnek Mahalle', 'Yüksek Lisans', '2019-03-01', '2023-07-30', 'Türkiye', 'Ankara', 'ODTÜ', 'Bilgisayar Mühendisliği', '2021-12-16', NULL, 'Kamu', NULL, 'Mühendis', 'Bilgisayar Bilimci'),
(25, 'Ebru', 'Yılmaz', '2007-07-15', '5552233445', 'ebru@example.com', '2125557788', 'Türkiye', 'İstanbul', 'Örnek Sokak', 'Lisans', '2001-07-15', '2007-07-15', 'Türkiye', 'İstanbul', 'Boğaziçi Üniversitesi', 'Kimya', '2021-10-28', NULL, 'Kamu', NULL, 'Kimyager', 'Ar-Ge Uzmanı'),
(26, 'Mert', 'Aydın', '2001-12-08', '5553344556', 'mert@example.com', '2165551122', 'Türkiye', 'İstanbul', 'Örnek Caddesi', 'Yüksek Lisans', '2020-04-01', '2023-05-18', 'Türkiye', 'İstanbul', 'İstanbul Teknik Üniversitesi', 'İnşaat Mühendisliği', '2020-06-05', NULL, 'Özel', NULL, 'Mühendis', 'Yapı Denetçisi'),
(27, 'Elif', 'Demir', '2005-07-11', '5554455667', 'elif@example.com', '2245558899', 'Türkiye', 'Bursa', 'Örnek Bulvar', 'Doktora', '2018-10-01', '2022-11-10', 'İngiltere', 'Bursa', 'Uludağ Üniversitesi', 'Biyoloji', '2022-11-23', NULL, 'Kamu', NULL, 'Araştırmacı', 'Biyoistatistikçi'),
(28, 'Beril', 'Şimşek', '2009-08-28', '5555566778', 'beril@example.com', '2125559900', 'Türkiye', 'Ankara', 'Örnek Mahallesi', 'Lisans', '2005-08-28', '2009-08-28', 'Türkiye', 'Ankara', 'Hacettepe Üniversitesi', 'Edebiyat', '2011-02-14', NULL, 'Özel', NULL, 'Editör', 'Yayıncı'),
(29, 'Tolga', 'Şahin', '2010-04-26', '5556677889', 'tolga@example.com', '2165556677', 'Türkiye', 'İstanbul', 'Örnek Köy', 'Yüksek Lisans', '2018-09-01', '2022-08-14', 'Türkiye', 'İstanbul', 'İstanbul Üniversitesi', 'Fizik', '2022-03-14', NULL, 'Kamu', NULL, 'Araştırmacı', 'Teorik Fizikçi'),
(30, 'Seda', 'Yıldız', '2007-04-10', '5557788990', 'seda@example.com', '2245552233', 'Türkiye', 'İzmir', 'Örnek Sokak', 'Lisans', '2003-04-10', '2007-04-10', 'Türkiye', 'İzmir', 'Dokuz Eylül Üniversitesi', 'Mimarlık', '2010-03-18', NULL, 'Özel', NULL, 'Mimar', 'İç Mimar'),
(32, 'Ece', 'Toprak', '2002-08-09', '5554455667', 'ece@example.com', '2165557788', 'Türkiye', 'İstanbul', 'Örnek Caddesi', 'Yüksek Lisans', '2020-02-01', '2023-07-05', 'Türkiye', 'İstanbul', 'Boğaziçi Üniversitesi', 'Eczacılık', '2024-09-03', NULL, 'Kamu', NULL, 'Eczacı', 'Klinik Eczacı'),
(33, 'Berk', 'Erdoğan', '2008-02-29', '5556677889', 'berk@example.com', '2245558899', 'Türkiye', 'İzmir', 'Örnek Mahalle', 'Lisans', '2004-02-29', '2008-02-29', 'Türkiye', 'İzmir', 'Ege Üniversitesi', 'Endüstri Mühendisliği', '2014-10-10', NULL, 'Özel', NULL, 'Mühendis', 'Üretim Mühendisi'),
(34, 'Zeynep', 'Şimşek', '2005-01-23', '5557788990', 'zeynep@example.com', '3125553344', 'Türkiye', 'Ankara', 'Örnek Bulvar', 'Lisans', '2001-01-23', '2005-01-23', 'Türkiye', 'Ankara', 'Ankara Üniversitesi', 'Tarih', '2008-11-30', NULL, 'Kamu', NULL, 'Araştırmacı', 'Arkeolog'),
(35, 'Aslı', 'Yılmaz', '2001-10-21', '5553344556', 'asli@example.com', '2125556677', 'Türkiye', 'İstanbul', 'Örnek Caddesi', 'Yüksek Lisans', '2018-09-01', '2022-08-30', 'Türkiye', 'İstanbul', 'İstanbul Teknik Üniversitesi', 'Maden Mühendisliği', '2021-05-21', NULL, 'Özel', NULL, 'Mühendis', 'Madencilik Mühendisi'),
(36, 'Emir', 'Koç', '2009-03-15', '5555566778', 'emir@example.com', '2165555566', 'Türkiye', 'İstanbul', 'Örnek Köy', 'Doktora', '2019-09-15', '2023-12-20', 'Türkiye', 'İstanbul', 'Boğaziçi Üniversitesi', 'Fizik', '2023-12-28', NULL, 'Kamu', NULL, 'Araştırmacı', 'Nükleer Fizikçi'),
(37, 'Elif', 'Aydın', '2022-06-14', '5554455667', 'elifaydin@example.com', '2245552233', 'Türkiye', 'İzmir', 'Örnek Bulvar', 'Yüksek Lisans', '2018-10-01', '2022-06-14', 'Türkiye', 'İzmir', 'Dokuz Eylül Üniversitesi', 'Fen Bilimleri', '2020-01-07', NULL, 'Özel', NULL, 'Araştırmacı', 'Veri Analisti'),
(38, 'Kerem', 'Öztürk', '2023-09-25', '5556677889', 'kerem@example.com', '3125556677', 'Türkiye', 'Ankara', 'Örnek Mahalle', 'Doktora', '2019-10-15', '2023-09-25', 'Türkiye', 'Ankara', 'Orta Doğu Teknik Üniversitesi', 'Bilgisayar Bilimleri', '2024-04-14', NULL, 'Kamu', NULL, 'Araştırmacı', 'Yapay Zeka Uzmanı'),
(39, 'Selin', 'Kaya', '2022-11-10', '5557788990', 'selinkaya@example.com', '2165557788', 'Türkiye', 'İstanbul', 'Örnek Caddesi', 'Doktora', '2018-09-01', '2022-11-10', 'Türkiye', 'İstanbul', 'Boğaziçi Üniversitesi', 'Kimya', '2022-05-28', NULL, 'Özel', NULL, 'Kimyager', 'Organik Kimyacı'),
(40, 'Caner', 'Demir', '2007-03-24', '5558899000', 'canerdemir@example.com', '2245552233', 'Türkiye', 'Ankara', 'Örnek Köy', 'Lisans', '2003-03-24', '2007-03-24', 'Türkiye', 'Ankara', 'Ankara Üniversitesi', 'Jeoloji', '2035-03-05', NULL, 'Kamu', NULL, 'Jeolog', 'Petrol Jeologu'),
(2244, 'Ali', 'BORHAN', '2024-05-15', '555', 'BALBA', '555', 'Türkiye', 'Ankara', 'blabla sk.', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `users`
--

INSERT INTO `users` (`id`, `username`, `password`) VALUES
(1, 'kullanici1', 'sifre1'),
(2, 'kullanici2', 'sifre2'),
(3, 'kullanici3', 'sifre3');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `mezunbilgileri`
--
ALTER TABLE `mezunbilgileri`
  ADD PRIMARY KEY (`ogrenci_no`);

--
-- Tablo için indeksler `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
