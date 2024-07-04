CREATE DATABASE  IF NOT EXISTS `event_management_system` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `event_management_system`;
-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: event_management_system
-- ------------------------------------------------------
-- Server version	8.0.35

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `addon`
--

DROP TABLE IF EXISTS `addon`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `addon` (
  `addOnID` char(6) NOT NULL,
  `description` varchar(45) DEFAULT NULL,
  `addOnPrice` int DEFAULT NULL,
  PRIMARY KEY (`addOnID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `addon`
--

LOCK TABLES `addon` WRITE;
/*!40000 ALTER TABLE `addon` DISABLE KEYS */;
INSERT INTO `addon` VALUES ('100Mag','Additional 60 magnets',1000),('1hrExt','Time Extension of 1 hour',1000),('30 Mag','Additional 30 magnets',550),('50 Mag','Additional 50 magnets',750),('RawPht','Copy of all Raw Photos',500),('RawVid','Copy of all Raw Videos',2000);
/*!40000 ALTER TABLE `addon` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `availability`
--

DROP TABLE IF EXISTS `availability`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `availability` (
  `employeeID` char(5) NOT NULL,
  `availableDate` date DEFAULT NULL,
  PRIMARY KEY (`employeeID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `availability`
--

LOCK TABLES `availability` WRITE;
/*!40000 ALTER TABLE `availability` DISABLE KEYS */;
/*!40000 ALTER TABLE `availability` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `biller`
--

DROP TABLE IF EXISTS `biller`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `biller` (
  `billerID` varchar(6) NOT NULL,
  `billerName` varchar(20) DEFAULT NULL,
  `billType` varchar(20) DEFAULT NULL,
  `dueDate` date DEFAULT NULL,
  `monthlyBudget` int DEFAULT NULL,
  `billStatus` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`billerID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `biller`
--

LOCK TABLES `biller` WRITE;
/*!40000 ALTER TABLE `biller` DISABLE KEYS */;
INSERT INTO `biller` VALUES ('ELCTRC','Meralco','Electricity Utility','2024-07-16',6000,'Unpaid'),('MNTNC','Jun Zapanta','Equip Maintenance','2024-07-30',2000,'Unpaid'),('REPAIR','G.Aircon Services','Aircon Cleaning','2024-07-30',1500,'Unpaid'),('STUDIO','Alica Barcz','Studio Place Rent','2024-07-15',20000,'Unpaid'),('WATER','Manila Waters','Water Utility','2024-07-10',1500,'Unpaid');
/*!40000 ALTER TABLE `biller` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employee` (
  `employeeID` char(5) NOT NULL,
  `employeeName` varchar(50) DEFAULT NULL,
  `employeeEmail` varchar(60) DEFAULT NULL,
  `employeeNum` char(11) DEFAULT NULL,
  `employeeAddress` varchar(100) DEFAULT NULL,
  `employeeFBName` varchar(50) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  `role` varchar(8) DEFAULT NULL,
  PRIMARY KEY (`employeeID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee`
--

LOCK TABLES `employee` WRITE;
/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
INSERT INTO `employee` VALUES ('DAD05','Daniel Deniega','dadsightph@gmail.com','09123456789','Robinson Homes, Dalig, Antipolo City','Dan Deniega','papz0905','Admin'),('DAN77','Dan Aglugub','D.Aglugub@gmai.com','09765432109','Maries, Mambugan, Lower Antipolo','Dan','dandan77','Employee'),('INT16','Princess Deniega','inchetDen@gmail.com','09567890123','Robinson Homes, Dalig, Antipolo CIty','Princess Deniega','inchet11','Admin'),('JAS08','Josh Agaps','JoshAgs@gmail.com','09084921376','dela Paz, Antipolo City','Josh Agaps','JA345','Employee'),('JJL01','John Lumayno','JJLumayno@gmail.com','09237233843','Carigma, Antipolo City','John John','JohnLuma','Employee'),('JRF28','John Rafael Agapay','J.R_agapay@gmail.com','09987654321','Robinson Homes, Dalig, Antipolo City','Rafael Agapay','RafMitch88','Employee'),('JUN08','Jun Deniega','JD___@gmail.com','09237233843','Robinson Homes, Dalig, Antipolo','Jun Deniega','123Jun','Employee'),('KAT09','Katherine Jane Jacildone Alindogan','KathKathAlindogan@gmail.com','09342673463','Tubigan, Antipolo City','Katherine Jane Jacildone Alindogan','Kath456','Admin'),('KMH27','Kim Hiro','kihiro@gmail.com','09876543210','Bagong Nayon, Antipolo CIty','Hiro Kim','kk0972','Employee'),('KNG10','King Silvestre Gutierre','KingGutierrez@gmail.com','09345678901','Bagumbayan, Antipolo City','King Silvestre Gutierrez','sushi00','Employee'),('KRL12','Karl Punzalan','KrlPunzalan@gmail.com','09765432109','Sta. Maria Subd, Dalig, Antipolo City','Karl Punzalan','KKyle<3','Employee'),('KYL29','Kyle Marie Villegas','MarieVillegas@gmail.com','09876543210','Robinson Homes, Dalig, Antipolo City','Kyle Marie Villegas','kmv123','Employee'),('LMZ05','Louise Monica Zapanta','monicasdump@gmail.com','09192912749','Sto. Nino, San Jose, Antipolo City','Monica Zapanta','monmon15!','Admin'),('TMK00','Tadzmermark Delos Santos','MarkedbyTadz@gmail.com','09456789012','Milagros Subd, Dalig, Antipolo City','Tadzmermark Delos Santos','tadzmark','Employee'),('ZDR06','Zander Lawrence De Guzman','ZanderLDG@gmail.com','09432109876','Milagros Subd, Dalig, Antipolo','Zander Lawrence De Guzman','zaaa001','Employee');
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `equipment`
--

DROP TABLE IF EXISTS `equipment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `equipment` (
  `equipID` char(5) NOT NULL,
  `equipName` varchar(20) DEFAULT NULL,
  `equipType` varchar(10) DEFAULT NULL,
  `equipCondition` varchar(12) DEFAULT NULL,
  `equipStatus` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`equipID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipment`
--

LOCK TABLES `equipment` WRITE;
/*!40000 ALTER TABLE `equipment` DISABLE KEYS */;
INSERT INTO `equipment` VALUES ('BGST1','BG in Blue Bag','BG stand','For Repair','In-Studio'),('BGST2','BG in Black Bag','BG stand','Good-to-Go','In-Studio'),('BOX01','Black HG Box','Box','Good-to-Go','In-Studio'),('BOX02','Black HG Box','Box','Good-to-Go','In-Studio'),('BOX03','Clar HG Box','Box','Good-to-Go','In-Studio'),('CAM01','Sony a7 iii','Camera','Good-to-Go','In-Studio'),('CAM02','D7000','Camera','Good-to-Go','In-Studio'),('CAM03','D5300','Camera','Good-to-Go','In-Studio'),('CAM04','D3200','Camera','Good-to-Go','In-Studio'),('GIMBL','Moza Air 3','Gimbal','Good-to-Go','In-Studio'),('LPTP1','Dell','Laptop','Good-to-Go','In-Studio'),('LPTP2','Asus GTX','Laptop','For Repair','In-Studio'),('LPTP3','Asus Vivibook 14','Laptop','Good-to-Go','In-Studio'),('MICPH','Takstar SGC-598','Microphone','Good-to-Go','In-Studio'),('MNTR1','Dell SE2422H 24\"','Monitor','Good-to-Go','In-Studio'),('MNTR2','DELL 22\" P2219H','Monitor','Good-to-Go','In-Studio'),('MNTR3','DELL P2414HB','Monitor','Good-to-Go','In-Studio'),('PRNT1','Epson L210','Printer','Good-to-Go','In-Studio'),('PRNT2','Epson L210 copy1','Printer','For Repair','In-Studio'),('PRNT3','Epson L810','Printer','Good-to-Go','In-Studio'),('SPD01','Godox TT685S','Speedlight','Good-to-Go','In-Studio'),('SPD02','Nikon SB-700','Speedlight','Good-to-Go','In-Studio'),('SPD03','Godox V860IIS','Speedlight','Good-to-Go','In-Studio'),('SPD04','Godox TT600S','Speedlight','Good-to-Go','In-Studio'),('TRI01','MACTREM','Tripod','Good-to-Go','In-Studio'),('TRI02','Joilcan Blue','Tripod','Good-to-Go','In-Studio'),('TRI03','ST-668','Tripod','Good-to-Go','In-Studio');
/*!40000 ALTER TABLE `equipment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `event`
--

DROP TABLE IF EXISTS `event`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `event` (
  `eventID` varchar(8) NOT NULL,
  `paymentID` varchar(6) NOT NULL,
  `eventName` varchar(50) NOT NULL,
  `eventType` varchar(20) NOT NULL,
  `clientName` varchar(50) NOT NULL,
  `clientNum` varchar(11) DEFAULT NULL,
  `eventDate` date NOT NULL,
  `eventTime` time NOT NULL,
  `eventVenue` varchar(50) NOT NULL,
  `packageType` char(5) NOT NULL,
  `addOn` char(6) DEFAULT NULL,
  `staff1` varchar(50) DEFAULT NULL,
  `staff2` varchar(50) DEFAULT NULL,
  `staff3` varchar(50) DEFAULT NULL,
  `staff4` varchar(50) DEFAULT NULL,
  `equipNeeded` varchar(200) NOT NULL,
  `additionalReq` varchar(100) DEFAULT NULL,
  `paymentStatus` varchar(10) NOT NULL,
  PRIMARY KEY (`eventID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `event`
--

LOCK TABLES `event` WRITE;
/*!40000 ALTER TABLE `event` DISABLE KEYS */;
INSERT INTO `event` VALUES ('JD062724','JD0724','Jane & Dean Wedding','Wedding','Jane Ushero','09192912749','2024-07-04','20:10:00','Jardin','PMMag','100Mag','Dan Aglugub','John Lumayno','','','Cam, Box, Printer, Monitor, BG stand, Tripod','','PRTL'),('KW300624','WK0624','KeiJEan','Wedding','Keilah J.','09192912749','2024-07-01','20:20:00','L&M','PBStr','1hrExt','Louise Monica Zapanta','Princess Deniega','','','Cam, Speedlight, Lighting, Printer, Monitor, Tripod, Box, BG stand','hmmmmmmmmmm','FULL'),('XK290624','KX0624','Xia','Kiddie Birthday','Monica','09192912749','2024-06-29','11:30:00','Jardin','PHCov','None','Dan Aglugub','','','None','Camera, Speedlight','','FULL');
/*!40000 ALTER TABLE `event` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `financereport`
--

DROP TABLE IF EXISTS `financereport`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `financereport` (
  `financeRepID` char(4) NOT NULL,
  `month` date DEFAULT NULL,
  `totalPayouts` int DEFAULT NULL,
  `totalEventPayments` int DEFAULT NULL,
  `totalBill` int DEFAULT NULL,
  `totalMonthlyIncome` int DEFAULT NULL,
  PRIMARY KEY (`financeRepID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `financereport`
--

LOCK TABLES `financereport` WRITE;
/*!40000 ALTER TABLE `financereport` DISABLE KEYS */;
INSERT INTO `financereport` VALUES ('0624','2024-06-30',1500,8000,31000,-24500),('0724','2024-07-30',2000,4500,31000,-28500);
/*!40000 ALTER TABLE `financereport` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `invoice`
--

DROP TABLE IF EXISTS `invoice`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `invoice` (
  `paymentID` char(6) NOT NULL,
  `eventID` char(8) DEFAULT NULL,
  `paymentStatus` varchar(10) DEFAULT NULL,
  `paymentType` varchar(15) DEFAULT NULL,
  `totalAmount` int DEFAULT NULL,
  `paymentBal` int DEFAULT NULL,
  `downpayment` int DEFAULT NULL,
  PRIMARY KEY (`paymentID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `invoice`
--

LOCK TABLES `invoice` WRITE;
/*!40000 ALTER TABLE `invoice` DISABLE KEYS */;
INSERT INTO `invoice` VALUES ('JD0724','JD062724','PRTL','Gcash',4500,0,2000),('KX0624','XK290624','FULL','Gcash',4500,0,2000),('WK0624','KW300624','FULL','Cash',3500,0,1500);
/*!40000 ALTER TABLE `invoice` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `package`
--

DROP TABLE IF EXISTS `package`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `package` (
  `packageType` char(5) NOT NULL,
  `packageName` varchar(50) DEFAULT NULL,
  `packagePrice` int DEFAULT NULL,
  `packageInclusion` varchar(200) DEFAULT NULL,
  `employeeRate` int DEFAULT NULL,
  PRIMARY KEY (`packageType`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `package`
--

LOCK TABLES `package` WRITE;
/*!40000 ALTER TABLE `package` DISABLE KEYS */;
INSERT INTO `package` VALUES ('ABday','Adult Birthday Package',2500,'3hr. 3-outfit Pre-Birthday shoot, 1min. Edited Video, 3hr. Birthday Coverage, 1 PA, 1 Photographer, 1 Videographer, 1 Editor',1500),('Anniv','Anniversary Package',40000,'3hr. 3-outfit Pre-Anniversary shoot, 1 min. and 30 sec. Edited Video, 3hr. Events Coverage, 1 PA, 1 Photographer, 1 Videographer, 1 Editor  ',2000),('DebGD','Debut Gold Package',50000,'3hr. 3-outfit Pre-Debut shoot, 1min. Edited Video, 30 sec. Invitation Video, 3hr. Birthday Coverage, 1 PA, 1 Photographer, 1 Videographer, 1 Editor  ',2500),('DebSL','Debut Silver Package',30000,'3hr. 2-outfit Pre-Debut shoot, 1min. Edited Video, 3hr. Birthday Coverage, 1 PA, 1 Photographer, 1 Videographer, 1 Editor  ',1500),('KBday','Kiddie Birthday Package',20000,'3hr. Studio Pre-Birthday shoot, 1min. Edited Video, 3hr. Birthday Coverage, 1 PA, 1 Photographer, 1 Videographer, 1 Editor  ',1200),('Other',NULL,0,NULL,0),('PBMag','Photobooth Magnet',4000,'2hrs. Unli-print and unli-shoot with magnet, 30 mins. break',500),('PBPlr','Photobooth Polaroid',3500,'2hrs. Unli-print and unli-shoot framed polaroid photos, 30 mins. break ',500),('PBStn','Photobooth Standee',3500,'2hrs. Unli-print and unli-shoot framed Landscape photos, 30 mins. break',500),('PBStr','Photobooth Strip',3500,'2hrs. Unli-print and unli-shoot framed strip photos, 30 mins. break',500),('PHCov','Event Photo Coverage',3500,'3hrs. Event Photo Coverage, 1 Photographer',1500),('PMMag','Photoman Magnet',6500,'3hrs. Unli-print and unli-shoot with magnet ',1500),('PMPlr','Photoman Polaroid',5500,'3hrs. Unli-print and unli-shoot framed photos',1500),('Reunn','Reunion Package',25000,'3hrs. Event Photo Coverage, 1 coordinator, 1 photographer, 1 videographer',1500),('SS_BG','Studio Shoot Big Group Package',5000,'3.5hrs. Professional Studio Shoot, 1 PA, 1 Photographer',1500),('SS_FM','Studio Shoot Family/Barkada Package',4000,'3hrs. Professional Studio Shoot, 1 PA, 1 Photographer',2000),('SS_SL','Studio Shoot Solo Package',2500,'3hrs. Professional Studio Shoot, 1 Photographer',800),('VDCov','Event Video Coverage',8000,'3hrs. Event Video Coverage, 1 Videographer',1500),('WedGD','Wedding Gold Package',65000,'3hr. 2-outfit Pre-Nup shoot, 1min. Edited Video, 20sec. Invitation Video, 3hr. Wedding Coverage, 2 PA, 1 Photographer, 1 Videographer, 1 Editor',4000),('WedPL','Wedding Platinum Package',80000,'4hr. 5-outfit Pre-Nup shoot, 1min. SDE Video, 30sec. Invitation Video, 3hr. Wedding Coverage, 2 PA, 2 Photographer, 2 Videographer, 1 Editor',4500),('WedSL','Wedding Silver Package',40000,'2hr. 2-outfit Pre-Nup shoot, 1min. Edited Video, 3hr. Wedding Coverage, 1 PA, 1 Photographer, 1 Videographer, 1 Editor',2000);
/*!40000 ALTER TABLE `package` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payout`
--

DROP TABLE IF EXISTS `payout`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `payout` (
  `employeeID` char(5) NOT NULL,
  `eventID` char(8) NOT NULL,
  `packageType` char(5) NOT NULL,
  `payoutMonth` date DEFAULT NULL,
  `payoutAmount` int DEFAULT NULL,
  `payoutStatus` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`employeeID`,`eventID`,`packageType`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payout`
--

LOCK TABLES `payout` WRITE;
/*!40000 ALTER TABLE `payout` DISABLE KEYS */;
INSERT INTO `payout` VALUES ('DAN77','JD062724','PMMag','2024-07-04',500,'Pending'),('DAN77','XK290624','PHCov','2024-06-29',1500,'Pending'),('INT16','KW300624','PBStr','2024-07-01',500,'Pending'),('JJL01','JD062724','PMMag','2024-07-04',500,'Pending'),('LMZ05','KW300624','PBStr','2024-07-01',500,'Pending');
/*!40000 ALTER TABLE `payout` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `posteventreport`
--

DROP TABLE IF EXISTS `posteventreport`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `posteventreport` (
  `reportID` char(8) NOT NULL,
  `eventID` char(8) DEFAULT NULL,
  `equipmentCon` varchar(100) DEFAULT NULL,
  `photoPaperC` int DEFAULT NULL,
  `outputQuality` varchar(10) DEFAULT NULL,
  `Comments` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`reportID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `posteventreport`
--

LOCK TABLES `posteventreport` WRITE;
/*!40000 ALTER TABLE `posteventreport` DISABLE KEYS */;
/*!40000 ALTER TABLE `posteventreport` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-07-04 22:30:06
