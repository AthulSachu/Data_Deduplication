-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.1.48-community


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema deduplication1
--

CREATE DATABASE IF NOT EXISTS deduplication1;
USE deduplication1;

--
-- Definition of table `file_details`
--

DROP TABLE IF EXISTS `file_details`;
CREATE TABLE `file_details` (
  `file_details_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `file_name` varchar(45) DEFAULT NULL,
  `file_size` varchar(45) DEFAULT NULL,
  `file_type` varchar(45) DEFAULT NULL,
  `username` varchar(45) DEFAULT NULL,
  `dupliaction` varchar(45) DEFAULT NULL,
  `keyGen` varchar(45) DEFAULT NULL,
  `tousername` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`file_details_id`)
) ENGINE=InnoDB AUTO_INCREMENT=78 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `file_details`
--

/*!40000 ALTER TABLE `file_details` DISABLE KEYS */;
INSERT INTO `file_details` (`file_details_id`,`file_name`,`file_size`,`file_type`,`username`,`dupliaction`,`keyGen`,`tousername`) VALUES 
 (74,'445JE04215-YGP900_1_lar.jpg','112.27','.jpg','ajith','0','9993','swathi12'),
 (75,'393JE04215-YGP900_1_lar.jpg','112.27','.jpg','swathi99','1','9993','swathi12'),
 (76,'605ER.png','44.90','.png','swathi99','1','9993','anish'),
 (77,'054ER.png','44.90','.png','swathi','1','9993','anish');
/*!40000 ALTER TABLE `file_details` ENABLE KEYS */;


--
-- Definition of table `file_link`
--

DROP TABLE IF EXISTS `file_link`;
CREATE TABLE `file_link` (
  `file_link_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `file_id` varchar(45) DEFAULT NULL,
  `keyGen` varchar(45) DEFAULT NULL,
  `username` varchar(45) DEFAULT NULL,
  `filelink` varchar(45) DEFAULT NULL,
  `type` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`file_link_id`)
) ENGINE=InnoDB AUTO_INCREMENT=72 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `file_link`
--

/*!40000 ALTER TABLE `file_link` DISABLE KEYS */;
INSERT INTO `file_link` (`file_link_id`,`file_id`,`keyGen`,`username`,`filelink`,`type`) VALUES 
 (68,'74','9993','ajith','445JE04215-YGP900_1_lar.jpg','.jpg'),
 (69,'75','9993','swathi99','445JE04215-YGP900_1_lar.jpg','.jpg'),
 (70,'76','9993','swathi99','445JE04215-YGP900_1_lar.jpg','.png'),
 (71,'77','9993','swathi','445JE04215-YGP900_1_lar.jpg','.png');
/*!40000 ALTER TABLE `file_link` ENABLE KEYS */;


--
-- Definition of table `registeration`
--

DROP TABLE IF EXISTS `registeration`;
CREATE TABLE `registeration` (
  `UserId` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Password` varchar(45) DEFAULT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `Email` varchar(45) DEFAULT NULL,
  `Mobile` varchar(45) DEFAULT NULL,
  `Dob` varchar(45) DEFAULT NULL,
  `Gender` varchar(45) DEFAULT NULL,
  `Age` varchar(45) DEFAULT NULL,
  `Address` varchar(100) DEFAULT NULL,
  `Photo` varchar(45) DEFAULT NULL,
  `Username` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`UserId`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=151 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `registeration`
--

/*!40000 ALTER TABLE `registeration` DISABLE KEYS */;
INSERT INTO `registeration` (`UserId`,`Password`,`Name`,`Email`,`Mobile`,`Dob`,`Gender`,`Age`,`Address`,`Photo`,`Username`) VALUES 
 (141,'2001','Dhanyashree S','dhanyashreebalya@gmail.com','+919901912979','09/03/2001','Female','22','MATHASHREE NILAYA GOVINDAKATTE BALLYA','WHPS281013_0_z.jpg','Dhanya'),
 (143,'1111','swati','swatiyv@gmail.com','9856321478','01/09/2000','Female','23','mangalore','WHPS281013_0_z.jpg','swati y v'),
 (144,'6666','anupam  v','anuop@gmail.com','9888782588','01/06/2000','Male','24','udupi','JE04215-YGP900_1_lar.jpg','anup'),
 (145,'1111','ajith v','ajith114@gmail.com','9849987456','04/06/2003','Male','24','karkala','JE04215-YGP900_1_lar.jpg','ajith'),
 (146,'1111','swathi12','swathi@gmail.com','9878987898','01/06/2000','Female','22','mangalore','DSC_0150.JPG','swathi'),
 (147,'4444','swathi','swathi44@gmail.com','9878989696','01/06/2008','Female','15','udupi','1687243449802.jpg','swathi11'),
 (148,'3333','swathi','swathi444@gmail.com','9878989696','01/06/2006','Female','19','udupi','1687243449851.jpg','swathi99'),
 (149,'1111','anish','anish44@gmail.com','9876689696','01/06/2006','Male','19','udupi','1687243449841.jpg','anish'),
 (150,'1111','radha11','agss44@gmail.com','9876689696','01/06/2006','Female','19','udupi','1687243449813.jpg','radha');
/*!40000 ALTER TABLE `registeration` ENABLE KEYS */;


--
-- Definition of table `text_linking`
--

DROP TABLE IF EXISTS `text_linking`;
CREATE TABLE `text_linking` (
  `linkingid` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `textdataid` int(10) unsigned DEFAULT NULL,
  `fromusername` varchar(45) DEFAULT NULL,
  `tousername` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`linkingid`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `text_linking`
--

/*!40000 ALTER TABLE `text_linking` DISABLE KEYS */;
/*!40000 ALTER TABLE `text_linking` ENABLE KEYS */;


--
-- Definition of table `textdata`
--

DROP TABLE IF EXISTS `textdata`;
CREATE TABLE `textdata` (
  `textdataid` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `fromusername` varchar(45) DEFAULT NULL,
  `tousername` varchar(45) DEFAULT NULL,
  `textcontent` varchar(8000) DEFAULT NULL,
  PRIMARY KEY (`textdataid`)
) ENGINE=InnoDB AUTO_INCREMENT=91 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `textdata`
--

/*!40000 ALTER TABLE `textdata` DISABLE KEYS */;
/*!40000 ALTER TABLE `textdata` ENABLE KEYS */;


--
-- Definition of table `user_creation`
--

DROP TABLE IF EXISTS `user_creation`;
CREATE TABLE `user_creation` (
  `UserCreationId` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Username` varchar(45) DEFAULT NULL,
  `Password` varchar(45) DEFAULT NULL,
  `User_type` varchar(45) DEFAULT NULL,
  `Email` varchar(45) DEFAULT NULL,
  `DateCreated` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`UserCreationId`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user_creation`
--

/*!40000 ALTER TABLE `user_creation` DISABLE KEYS */;
INSERT INTO `user_creation` (`UserCreationId`,`Username`,`Password`,`User_type`,`Email`,`DateCreated`) VALUES 
 (12,'Dhanya','2001','Admin','dhanyashreebalya@gmail.com','2023-06-14'),
 (14,'swati y v','1111','User','swatiyv@gmail.com','2023-06-14'),
 (15,'anup','6666','User','anuop@gmail.com','2023-06-14'),
 (16,'ajith','1111','User','ajith114@gmail.com','2023-06-14'),
 (17,'swathi','1111','User','swathi@gmail.com','2023-06-20'),
 (18,'swathi11','4444','User','swathi44@gmail.com','2023-06-20'),
 (19,'swathi99','3333','User','swathi444@gmail.com','2023-06-20'),
 (20,'anish','1111','User','anish44@gmail.com','2023-06-20'),
 (21,'radha','1111','User','agss44@gmail.com','2023-06-20');
/*!40000 ALTER TABLE `user_creation` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
