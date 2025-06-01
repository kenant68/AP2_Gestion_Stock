-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : dim. 01 juin 2025 à 14:08
-- Version du serveur : 8.3.0
-- Version de PHP : 8.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `bd_stock_tekbas`
--

-- --------------------------------------------------------

--
-- Structure de la table `articles`
--

DROP TABLE IF EXISTS `articles`;
CREATE TABLE IF NOT EXISTS `articles` (
  `ReferenceArticle` char(20) NOT NULL,
  `Libelle` varchar(120) NOT NULL,
  `IdFabricant` char(10) NOT NULL,
  `CodeCategorie` char(5) NOT NULL,
  `CodeUnite` char(3) NOT NULL,
  PRIMARY KEY (`ReferenceArticle`),
  KEY `IdFabricant` (`IdFabricant`),
  KEY `CodeCategorie` (`CodeCategorie`),
  KEY `CodeUnite` (`CodeUnite`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `articles`
--

INSERT INTO `articles` (`ReferenceArticle`, `Libelle`, `IdFabricant`, `CodeCategorie`, `CodeUnite`) VALUES
('IPH15GO128', 'Iphone 15 Pro Or 128Go', 'APPLE001', 'SMT', 'UNT'),
('IPH15GO256', 'Iphone 15 Pro Or 256Go', 'APPLE001', 'SMT', 'UNT'),
('IPH15GO512', 'Iphone 15 Pro Or 512Go', 'APPLE001', 'SMT', 'UNT'),
('IPH15NO128', 'Iphone 15 Pro Noir 128Go', 'APPLE001', 'SMT', 'UNT'),
('IPH15NO256', 'Iphone 15 Pro Noir 256Go', 'APPLE001', 'SMT', 'UNT'),
('IPH15NO512', 'Iphone 15 Pro Noir 512Go', 'APPLE001', 'SMT', 'UNT'),
('IPH15BL128', 'Iphone 15 Pro Blanc 128Go', 'APPLE001', 'SMT', 'UNT'),
('IPH15BL256', 'Iphone 15 Pro Blanc 256Go', 'APPLE001', 'SMT', 'UNT'),
('IPH15BL512', 'Iphone 15 Pro Blanc 512Go', 'APPLE001', 'SMT', 'UNT'),
('IPH15AC128', 'Iphone 15 Pro Acier 128Go', 'APPLE001', 'SMT', 'UNT'),
('IPH15AC256', 'Iphone 15 Pro Acier 256Go', 'APPLE001', 'SMT', 'UNT'),
('IPH15AC512', 'Iphone 15 Pro Acier 512Go', 'APPLE001', 'SMT', 'UNT'),
('QE65Q80AATXXC', 'Samsung Q80A', 'SAM001', 'TV', 'UNT'),
('XIAOMIRDMIN14GO128', 'Xiaomi Redmi Note 14 128Go', 'XIAOMI001', 'SMT', 'UNT'),
('IPH15GO1000', 'Iphone 15 Pro Or 1000Go', 'APPLE001', 'SMT', 'UNT'),
('TV4K', 'Télévision 4K Xiaomi ', 'XIAOMI001', 'TV', 'UNT'),
('NETSOL5L', 'Nettoyant sols et multisurfaces Citron', 'MRPROPRE01', 'NET', 'LIT'),
('PS5P1TO', 'Playstation 5 Pro 1To', 'PS001', 'CONSL', 'UNT');

-- --------------------------------------------------------

--
-- Structure de la table `categories`
--

DROP TABLE IF EXISTS `categories`;
CREATE TABLE IF NOT EXISTS `categories` (
  `CodeCategorie` char(5) NOT NULL,
  `Libelle` varchar(50) NOT NULL,
  PRIMARY KEY (`CodeCategorie`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `categories`
--

INSERT INTO `categories` (`CodeCategorie`, `Libelle`) VALUES
('SMT', 'Smartphone'),
('LEG', 'Légumes'),
('NET', 'Produits d\'entretien'),
('TV', 'Télévision'),
('PCPOR', 'PC Portable '),
('CONSL', 'Console');

-- --------------------------------------------------------

--
-- Structure de la table `depots`
--

DROP TABLE IF EXISTS `depots`;
CREATE TABLE IF NOT EXISTS `depots` (
  `NumeroDepot` int NOT NULL,
  `Nom` varchar(50) NOT NULL,
  `Ville` varchar(50) NOT NULL,
  `Pays` varchar(50) NOT NULL,
  `Latitude` double DEFAULT NULL,
  `Longitude` double DEFAULT NULL,
  PRIMARY KEY (`NumeroDepot`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `depots`
--

INSERT INTO `depots` (`NumeroDepot`, `Nom`, `Ville`, `Pays`, `Latitude`, `Longitude`) VALUES
(101, 'Dépôt Paris Nord', 'Paris', 'France', 48.899, 2.37),
(102, 'Dépôt Lyon Est', 'Lyon', 'France', 45.75, 4.85),
(818, 'Dépôt Marseille Sud', 'Marseille', 'France', 43.296, 5.369),
(68, 'Dépôt Aksaray', 'Aksaray', 'Turquie', 38.3726, 34.0254),
(67, 'Dépôt Strasbourg', 'Strasbourg', 'France', 48.899, 4.85),
(93, 'Dépôt de Saint Denis', 'Paris', 'France', 48.88, 2.27);

-- --------------------------------------------------------

--
-- Structure de la table `fabricants`
--

DROP TABLE IF EXISTS `fabricants`;
CREATE TABLE IF NOT EXISTS `fabricants` (
  `IdFabricant` char(10) NOT NULL,
  `NomEntreprise` varchar(50) NOT NULL,
  `Marque` varchar(50) NOT NULL,
  PRIMARY KEY (`IdFabricant`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `fabricants`
--

INSERT INTO `fabricants` (`IdFabricant`, `NomEntreprise`, `Marque`) VALUES
('APPLE001', 'Apple ', 'Apple'),
('UNILEV01', 'Unilever', 'Dove'),
('UNILEV02', 'Unilever', 'Rexona'),
('TKBS68', 'Tekbas Inc', 'Tekbas'),
('SAM001', 'Samsung ', 'Samsung'),
('XIAOMI001', 'Xiaomi ', 'Xiaomi'),
('MRPROPRE01', 'Mr Propre', 'Mr Propre'),
('PS001', 'Sony', 'Playstation');

-- --------------------------------------------------------

--
-- Structure de la table `mouvementsstock`
--

DROP TABLE IF EXISTS `mouvementsstock`;
CREATE TABLE IF NOT EXISTS `mouvementsstock` (
  `ReferenceArticle` char(20) NOT NULL,
  `NumeroDepot` int NOT NULL,
  `DateHeureMouvement` datetime NOT NULL,
  `Type` char(3) DEFAULT NULL,
  `Quantite` double NOT NULL,
  PRIMARY KEY (`ReferenceArticle`,`NumeroDepot`,`DateHeureMouvement`),
  KEY `NumeroDepot` (`NumeroDepot`)
) ;

--
-- Déchargement des données de la table `mouvementsstock`
--

INSERT INTO `mouvementsstock` (`ReferenceArticle`, `NumeroDepot`, `DateHeureMouvement`, `Type`, `Quantite`) VALUES
('IPH15GO128', 818, '2024-12-22 16:32:23', 'INV', 7),
('IPH15GO256', 818, '2024-12-23 09:10:27', 'MVT', -4),
('X079077', 818, '2024-12-27 10:45:53', 'MVT', 5),
('QE65Q80AATXXC', 101, '2024-12-29 15:07:37', 'MVT', 4);

-- --------------------------------------------------------

--
-- Structure de la table `unites`
--

DROP TABLE IF EXISTS `unites`;
CREATE TABLE IF NOT EXISTS `unites` (
  `CodeUnite` char(3) NOT NULL,
  `Libelle` varchar(30) NOT NULL,
  PRIMARY KEY (`CodeUnite`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `unites`
--

INSERT INTO `unites` (`CodeUnite`, `Libelle`) VALUES
('UNT', 'Unité'),
('LIT', 'Litre'),
('ML', 'Millilitre'),
('KG', 'Kilogramme'),
('G', 'Gramme'),
('MG', 'Milligramme');

-- --------------------------------------------------------

--
-- Doublure de structure pour la vue `vue_niveaustock`
-- (Voir ci-dessous la vue réelle)
--
DROP VIEW IF EXISTS `vue_niveaustock`;
CREATE TABLE IF NOT EXISTS `vue_niveaustock` (
`ReferenceArticle` char(20)
,`NumeroDepot` int
,`DernierInventaire` datetime
,`NiveauStock` double
);

-- --------------------------------------------------------

--
-- Structure de la vue `vue_niveaustock`
--
DROP TABLE IF EXISTS `vue_niveaustock`;

DROP VIEW IF EXISTS `vue_niveaustock`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vue_niveaustock`  AS SELECT `ms`.`ReferenceArticle` AS `ReferenceArticle`, `ms`.`NumeroDepot` AS `NumeroDepot`, max((case when (`ms`.`Type` = 'INV') then `ms`.`DateHeureMouvement` else NULL end)) AS `DernierInventaire`, (ifnull((select sum((case when (`m`.`Type` = 'MVT') then `m`.`Quantite` else 0 end)) from `mouvementsstock` `m` where ((`m`.`ReferenceArticle` = `ms`.`ReferenceArticle`) and (`m`.`NumeroDepot` = `ms`.`NumeroDepot`) and (`m`.`DateHeureMouvement` > (select max(`mouvementsstock`.`DateHeureMouvement`) from `mouvementsstock` where ((`mouvementsstock`.`Type` = 'INV') and (`mouvementsstock`.`ReferenceArticle` = `ms`.`ReferenceArticle`) and (`mouvementsstock`.`NumeroDepot` = `ms`.`NumeroDepot`)))))),0) + ifnull((select `m2`.`Quantite` from `mouvementsstock` `m2` where ((`m2`.`Type` = 'INV') and (`m2`.`ReferenceArticle` = `ms`.`ReferenceArticle`) and (`m2`.`NumeroDepot` = `ms`.`NumeroDepot`)) order by `m2`.`DateHeureMouvement` desc limit 1),0)) AS `NiveauStock` FROM `mouvementsstock` AS `ms` GROUP BY `ms`.`ReferenceArticle`, `ms`.`NumeroDepot` ;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
