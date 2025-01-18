-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: setlist
-- ------------------------------------------------------
-- Server version	8.0.32

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
-- Table structure for table `albumes`
--

DROP TABLE IF EXISTS `albumes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `albumes` (
  `idAlbum` int NOT NULL AUTO_INCREMENT,
  `NombreAlbum` varchar(45) NOT NULL,
  `AñoAlbum` int NOT NULL,
  `Artista` int NOT NULL,
  PRIMARY KEY (`idAlbum`),
  UNIQUE KEY `NombreAlbum_UNIQUE` (`NombreAlbum`),
  KEY `FK_AL_AR_idx` (`Artista`),
  CONSTRAINT `FK_AL_AR` FOREIGN KEY (`Artista`) REFERENCES `artistas` (`IdArtista`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `albumes`
--

LOCK TABLES `albumes` WRITE;
/*!40000 ALTER TABLE `albumes` DISABLE KEYS */;
INSERT INTO `albumes` VALUES (1,'Sopa Fría',2004,6),(2,'Zapatillas',2003,7),(3,'Lagrimas Desordenadas',2012,9),(4,'Infinity',2015,10),(5,'Con una Botella',2015,12),(6,'Dicen Que Estamos Locos',2010,15),(7,'El merengue',2023,4),(8,'Destino o Casualidad',2012,9),(9,'Sin Noticias de Holanda',2003,9),(10,'X100PRE',2003,1),(11,'Un alumno Mas',2015,9),(12,'Un Verano Sin Ti',2022,1),(13,'El Ultimo Tour Del Mundo',2016,1),(14,'Des/Amor',2016,8),(15,'HOMERUN',2013,2);
/*!40000 ALTER TABLE `albumes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `artistas`
--

DROP TABLE IF EXISTS `artistas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `artistas` (
  `IdArtista` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) NOT NULL,
  `País` char(3) NOT NULL,
  PRIMARY KEY (`IdArtista`),
  UNIQUE KEY `Nombre_UNIQUE` (`Nombre`),
  KEY `FK_AR_PA_idx` (`País`),
  CONSTRAINT `FK_AR_PA` FOREIGN KEY (`País`) REFERENCES `paises` (`idPais`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `artistas`
--

LOCK TABLES `artistas` WRITE;
/*!40000 ALTER TABLE `artistas` DISABLE KEYS */;
INSERT INTO `artistas` VALUES (1,'Bad Bunny','PRT'),(2,'Paulo Londra','ARG'),(3,'Ozuna','PRT'),(4,'Marshmello','ING'),(5,'Manuel Turizo','ESP'),(6,'M-Clan','ESP'),(7,'El Canto Del Loco','ESP'),(8,'Reik','PRT'),(9,'Melendi','ESP'),(10,'Jaymes young','ING'),(11,'Mora','BRA'),(12,'Morat','ESP'),(13,'Morad','ESP'),(14,'Ying','CHI'),(15,'Los Panchos','ECU');
/*!40000 ALTER TABLE `artistas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `canciones`
--

DROP TABLE IF EXISTS `canciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `canciones` (
  `idCancion` int NOT NULL AUTO_INCREMENT,
  `NombreCancion` varchar(45) NOT NULL,
  `Duración` int NOT NULL,
  `Album` int NOT NULL,
  `OrdenCanción` int NOT NULL,
  PRIMARY KEY (`idCancion`),
  UNIQUE KEY `NombreCancion_UNIQUE` (`NombreCancion`),
  KEY `FK_CA_AL_idx` (`Album`),
  CONSTRAINT `FK_CA_AL` FOREIGN KEY (`Album`) REFERENCES `albumes` (`idAlbum`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `canciones`
--

LOCK TABLES `canciones` WRITE;
/*!40000 ALTER TABLE `canciones` DISABLE KEYS */;
INSERT INTO `canciones` VALUES (1,'Tu Jardin con Enanitos',320,3,1),(2,'La Promesa',359,3,2),(3,'Desde Que Estamos Juntos',333,3,3),(4,'LAMAMADELAMAMA',123,1,1),(5,'Aprendiz De Caballero',293,3,4),(6,'El Merengue',324,7,1),(7,'Tocado y Hundido',456,8,1),(8,'La religion de los idiotas',345,8,2),(9,'Ojitos Lindos',234,12,1),(10,'Me Porto Bonito',342,12,2),(11,'Moscow Mule',321,12,3),(12,'Titi Me Pregunto',332,12,4),(13,'Un ratito',342,12,5),(14,'Canciones',347,2,1),(15,'Volvera',317,2,2);
/*!40000 ALTER TABLE `canciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `conciertos`
--

DROP TABLE IF EXISTS `conciertos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `conciertos` (
  `idConcierto` int NOT NULL AUTO_INCREMENT,
  `Artista` int NOT NULL,
  `Sitio` int NOT NULL,
  `FechaConcierto` date NOT NULL,
  PRIMARY KEY (`idConcierto`),
  KEY `FK_CO_AR_idx` (`Artista`),
  KEY `FK_CO_SI_idx` (`Sitio`),
  CONSTRAINT `FK_CO_AR` FOREIGN KEY (`Artista`) REFERENCES `artistas` (`IdArtista`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `FK_CO_SI` FOREIGN KEY (`Sitio`) REFERENCES `sitio` (`idSitio`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `conciertos`
--

LOCK TABLES `conciertos` WRITE;
/*!40000 ALTER TABLE `conciertos` DISABLE KEYS */;
INSERT INTO `conciertos` VALUES (1,9,1,'2001-01-01'),(2,9,3,'2001-03-26'),(3,9,2,'2003-03-23'),(4,2,2,'2003-04-22'),(5,6,3,'2023-05-05'),(6,9,4,'2023-05-13'),(7,12,7,'2023-08-19'),(8,1,5,'2023-08-22'),(9,2,12,'2023-08-22'),(10,9,14,'2023-08-22'),(11,3,6,'2023-08-22'),(12,7,11,'2023-08-22'),(13,14,13,'2023-10-12'),(14,5,4,'2023-10-12'),(15,1,15,'2023-10-28');
/*!40000 ALTER TABLE `conciertos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `paises`
--

DROP TABLE IF EXISTS `paises`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `paises` (
  `idPais` char(3) NOT NULL,
  `NombrePais` varchar(45) NOT NULL,
  PRIMARY KEY (`idPais`),
  UNIQUE KEY `NombrePais_UNIQUE` (`NombrePais`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paises`
--

LOCK TABLES `paises` WRITE;
/*!40000 ALTER TABLE `paises` DISABLE KEYS */;
INSERT INTO `paises` VALUES ('ALE','ALEMANIA'),('ARG','ARGENTINA'),('BEL','BELGICA'),('BRA','BRASIL'),('CHI','CHINA'),('CHL','CHLE'),('COL','COLOMBIA'),('ECU','ECUADOR'),('ESP','ESPAÑA'),('FRA','FRANCIA'),('ING','INGLATERRA'),('ITA','ITALIA'),('JAP','JAPON'),('POL','POLONIA'),('PRT','PUERTO RICO');
/*!40000 ALTER TABLE `paises` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `setlists`
--

DROP TABLE IF EXISTS `setlists`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `setlists` (
  `Concierto` int NOT NULL,
  `Canción` int NOT NULL,
  `OrdenSetlist` int NOT NULL,
  PRIMARY KEY (`Concierto`,`Canción`),
  KEY `FK_SE_CO_idx` (`Concierto`),
  KEY `FK_SE_CA_idx` (`Canción`),
  CONSTRAINT `FK_SE_CA` FOREIGN KEY (`Canción`) REFERENCES `canciones` (`idCancion`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `FK_SE_CO` FOREIGN KEY (`Concierto`) REFERENCES `conciertos` (`idConcierto`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `setlists`
--

LOCK TABLES `setlists` WRITE;
/*!40000 ALTER TABLE `setlists` DISABLE KEYS */;
INSERT INTO `setlists` VALUES (1,1,1),(1,3,2),(1,8,3),(2,3,1),(3,1,1),(3,3,2),(5,4,1),(8,11,1),(10,3,1),(10,5,2),(10,7,3),(10,8,4),(15,9,1),(15,11,2),(15,12,3),(15,13,4);
/*!40000 ALTER TABLE `setlists` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sitio`
--

DROP TABLE IF EXISTS `sitio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sitio` (
  `idSitio` int NOT NULL AUTO_INCREMENT,
  `NombreSitio` varchar(45) NOT NULL,
  `País` char(3) NOT NULL,
  `Tipo` enum('sala','pabellón','estadio','festival') NOT NULL,
  PRIMARY KEY (`idSitio`),
  UNIQUE KEY `NombreSitio_UNIQUE` (`NombreSitio`),
  KEY `FK_SI_PA_idx` (`País`),
  CONSTRAINT `FK_SI_PA` FOREIGN KEY (`País`) REFERENCES `paises` (`idPais`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sitio`
--

LOCK TABLES `sitio` WRITE;
/*!40000 ALTER TABLE `sitio` DISABLE KEYS */;
INSERT INTO `sitio` VALUES (1,'Quijote Arena','ESP','pabellón'),(2,'Colo Beach Festival','COL','festival'),(3,'La gala Exotic','ESP','sala'),(4,'Colo Colo','ARG','estadio'),(5,'Isla Tortuga','BRA','sala'),(6,'La casa de Paco','ESP','sala'),(7,'Etihad Stadium','ING','estadio'),(8,'Sanchez Pijuan','ESP','estadio'),(9,'El pabel','COL','pabellón'),(10,'La Mansion','POL','sala'),(11,'Los Pillados','CHI','festival'),(12,'Man beach','ING','festival'),(13,'Barbariee','CHL','estadio'),(14,'Chao','JAP','pabellón'),(15,'Caccio','ITA','festival');
/*!40000 ALTER TABLE `sitio` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-05-02 12:32:11
