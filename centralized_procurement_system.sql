-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 01, 2023 at 07:06 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `centralized_procurement_system`
--

-- --------------------------------------------------------

--
-- Table structure for table `bpa`
--

CREATE TABLE `bpa` (
  `ContractNumber` varchar(11) NOT NULL,
  `StartDate` date NOT NULL,
  `EndDate` date NOT NULL,
  `EffectiveDay` int(11) NOT NULL,
  `SupplierID` varchar(50) NOT NULL,
  `ItemID` int(11) NOT NULL,
  `Price` int(11) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `UOM` varchar(50) NOT NULL,
  `Discounts` int(2) NOT NULL,
  `TermsAndCondition` varchar(3000) NOT NULL,
  `Status` enum('Valid','Invalid') NOT NULL,
  `Signatures` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `bpa`
--

INSERT INTO `bpa` (`ContractNumber`, `StartDate`, `EndDate`, `EffectiveDay`, `SupplierID`, `ItemID`, `Price`, `Quantity`, `UOM`, `Discounts`, `TermsAndCondition`, `Status`, `Signatures`) VALUES
('bpa0001', '2023-06-02', '2023-12-22', 203, 'S001', 1002, 3000, 464, 'kg', 8, '1: Payment Terms: Net 30 days from the date of invoice. Late payments will incur a 2% monthly interest charge.\r\n\r\n2: Product Warranty: All products are covered under a 1-year warranty from the date of delivery.\r\nDelivery Timeframe: The supplier agrees to us', 'Valid', 'Lee Chou'),
('bpa0002', '2023-06-01', '2023-07-31', 60, 'S004', 1006, 1001, 300, 'kg', 10, '1: Payment Terms: Net 30 days from the date of invoice. Late payments will incur a 2% monthly interest charge.\r\n\r\n2: Product Warranty: All products are covered under a 1-year warranty from the date of delivery.\r\nDelivery Timeframe: The supplier agrees to ', 'Valid', 'May Wong'),
('bpa0004', '2023-06-01', '2023-06-07', 6, 'S001', 1003, 500, 20, 'box', 10, 'aa', 'Invalid', 'Jason'),
('bpa0005', '2023-06-30', '2023-07-30', 30, 'S003', 1004, 200, 873, 'box', 10, 'Test', 'Valid', 'Hin');

-- --------------------------------------------------------

--
-- Table structure for table `contract_order`
--

CREATE TABLE `contract_order` (
  `contractOrderID` varchar(50) NOT NULL,
  `agreementID` varchar(11) NOT NULL,
  `orderType` varchar(50) NOT NULL,
  `supplierID` varchar(20) NOT NULL,
  `supplierName` varchar(100) NOT NULL,
  `shipToAddress` varchar(255) NOT NULL,
  `createDate` date NOT NULL,
  `pickUpDate` date NOT NULL,
  `status` enum('In Progress','Completed','Cancelled') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `contract_order`
--

INSERT INTO `contract_order` (`contractOrderID`, `agreementID`, `orderType`, `supplierID`, `supplierName`, `shipToAddress`, `createDate`, `pickUpDate`, `status`) VALUES
('c00001', 'cpa0001', 'CPA', 'S002', 'Supplier Company A', 'Yummy Warehouse, 1234 Yummy Street, Yummy City', '2023-06-30', '2023-06-30', 'In Progress');

-- --------------------------------------------------------

--
-- Table structure for table `cpa`
--

CREATE TABLE `cpa` (
  `ContractNumber` varchar(11) NOT NULL,
  `StartDate` date NOT NULL,
  `EndDate` date NOT NULL,
  `EffectiveDay` int(11) NOT NULL,
  `SupplierID` varchar(11) NOT NULL,
  `TermsAndCondition` varchar(3000) NOT NULL,
  `Status` enum('Valid','Invalid') NOT NULL,
  `Signatures` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `cpa`
--

INSERT INTO `cpa` (`ContractNumber`, `StartDate`, `EndDate`, `EffectiveDay`, `SupplierID`, `TermsAndCondition`, `Status`, `Signatures`) VALUES
('cpa0001', '2023-06-08', '2023-06-23', 15, 'S002', 'test22', 'Valid', 'John Chan'),
('cpa0003', '2023-06-29', '2023-07-28', 28, 'S006', 'Test', 'Valid', 'hins'),
('cpa0004', '2023-06-29', '2023-07-20', 20, 'S003', 'Test2', 'Valid', 'Hins');

-- --------------------------------------------------------

--
-- Table structure for table `delivery_note`
--

CREATE TABLE `delivery_note` (
  `deliveryNoteID` varchar(10) NOT NULL,
  `despatchID` int(8) NOT NULL,
  `restaurantID` int(3) NOT NULL,
  `restaurantName` varchar(50) NOT NULL,
  `restaurantContact` int(30) NOT NULL,
  `shipAddress` varchar(100) NOT NULL,
  `deliveryDate` date NOT NULL,
  `createDate` date NOT NULL,
  `status` enum('In Progress','Completed','Cancelled','Delivered') NOT NULL,
  `requestID` int(9) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `delivery_note`
--

INSERT INTO `delivery_note` (`deliveryNoteID`, `despatchID`, `restaurantID`, `restaurantName`, `restaurantContact`, `shipAddress`, `deliveryDate`, `createDate`, `status`, `requestID`) VALUES
('d00001', 0, 1, 'Burger Joys', 26823832, '27-29 First Street, Sai Ying Pun, Western District LG/F, Tai Yik House,, Hong Kong China', '2023-07-01', '2023-07-01', 'Completed', 118);

-- --------------------------------------------------------

--
-- Table structure for table `delivery_note_item`
--

CREATE TABLE `delivery_note_item` (
  `delivery_note_itemID` int(8) NOT NULL,
  `deliveryID` varchar(10) NOT NULL,
  `itemID` int(10) NOT NULL,
  `itemName` varchar(50) NOT NULL,
  `qty` int(10) NOT NULL,
  `unit` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `delivery_note_item`
--

INSERT INTO `delivery_note_item` (`delivery_note_itemID`, `deliveryID`, `itemID`, `itemName`, `qty`, `unit`) VALUES
(8, 'd00001', 4500, 'Sugar', 2, 'kilogram'),
(9, 'd00001', 4501, 'Brown Sugar', 3, 'pieces');

-- --------------------------------------------------------

--
-- Table structure for table `department`
--

CREATE TABLE `department` (
  `deptID` int(3) NOT NULL,
  `deptName` varchar(50) NOT NULL,
  `phone` int(8) NOT NULL,
  `address` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `department`
--

INSERT INTO `department` (`deptID`, `deptName`, `phone`, `address`) VALUES
(1, 'Restaurant', 23578416, 'Wong Lok Road, Big building.'),
(2, 'Category', 25478569, 'Tai O, Happy building'),
(3, 'Purchasement', 22547854, 'Tai Kwok road'),
(4, 'Inventory', 54784152, 'Yummy Warehouse, 1234 Yummy Street, Yummy City'),
(5, 'Accounting', 21547856, 'Tai Kwok road, Happy Building'),
(6, 'IT', 25451258, '123 N, Silicon Valley, CA');

-- --------------------------------------------------------

--
-- Table structure for table `despatch_instruction`
--

CREATE TABLE `despatch_instruction` (
  `despatchID` int(8) NOT NULL,
  `purchaseManagerID` int(5) NOT NULL,
  `restaurantID` int(3) NOT NULL,
  `requestID` int(9) NOT NULL,
  `status` enum('In Progress','Completed','Cancelled') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `despatch_instruction`
--

INSERT INTO `despatch_instruction` (`despatchID`, `purchaseManagerID`, `restaurantID`, `requestID`, `status`) VALUES
(0, 12345, 1, 118, 'Completed'),
(1, 12345, 1, 124, 'In Progress'),
(2, 12345, 1, 123, 'In Progress'),
(3, 12345, 1, 123, 'In Progress'),
(4, 12345, 1, 120, 'In Progress'),
(5, 12345, 1, 125, 'In Progress'),
(6, 12345, 1, 119, 'In Progress'),
(7, 12345, 1, 125, 'In Progress'),
(8, 12345, 1, 126, 'In Progress');

-- --------------------------------------------------------

--
-- Table structure for table `despatch_instruction_item_mapping`
--

CREATE TABLE `despatch_instruction_item_mapping` (
  `despatchitemMappingID` int(8) NOT NULL,
  `despatchID` int(8) NOT NULL,
  `itemID` int(11) NOT NULL,
  `requestQty` int(10) NOT NULL,
  `unit` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `despatch_instruction_item_mapping`
--

INSERT INTO `despatch_instruction_item_mapping` (`despatchitemMappingID`, `despatchID`, `itemID`, `requestQty`, `unit`) VALUES
(17, 0, 4500, 2, 'kilogram'),
(18, 0, 4501, 3, 'pieces'),
(19, 1, 4501, 22, 'kilograms'),
(20, 2, 4502, 2, 'kilograms'),
(21, 3, 4502, 2, 'kilograms'),
(22, 4, 4501, 3, 'kilograms'),
(23, 4, 4500, 2, 'kilogram'),
(24, 5, 4506, 222, 'kilograms'),
(25, 6, 4503, 3, 'dozen'),
(26, 7, 4503, 50, 'dozen'),
(27, 7, 4506, 222, 'kilograms'),
(28, 8, 4510, 66, 'ppp');

-- --------------------------------------------------------

--
-- Table structure for table `item`
--

CREATE TABLE `item` (
  `itemID` int(11) NOT NULL,
  `supplierID` varchar(50) NOT NULL,
  `typeID` int(2) NOT NULL,
  `categoryID` int(4) NOT NULL,
  `itemName` varchar(255) NOT NULL,
  `brand` varchar(50) NOT NULL,
  `remark` varchar(255) DEFAULT NULL,
  `stockItemQty` int(11) NOT NULL,
  `unit` varchar(20) NOT NULL,
  `stockStatus` enum('Low','Normal','Out of Stock') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `item`
--

INSERT INTO `item` (`itemID`, `supplierID`, `typeID`, `categoryID`, `itemName`, `brand`, `remark`, `stockItemQty`, `unit`, `stockStatus`) VALUES
(1002, 'S002', 102, 1212, 'Sugar', 'Brand A', 'id = 102', 346, 'kilograms', 'Low'),
(1003, 'S007', 101, 1234, 'Chicken Egg', 'Brand B', NULL, 50, 'dozen', 'Low'),
(1004, 'S002', 102, 1212, 'Brown Sugar', 'Brand C', 'Hi', 272, 'kilograms', 'Low'),
(1005, 'S003', 103, 1234, 'Beef', 'Brand D', NULL, 300, 'kilograms', 'Low'),
(1006, 'S004', 104, 1234, 'Salmon', 'Brand E', '', 60, 'kilograms', 'Low'),
(1007, 'S005', 105, 1238, 'Carrots', 'Brand F', '', 80, 'kilograms', 'Low'),
(1008, 'S006', 201, 1241, 'Water Glass', 'Brand G', '', 2000, 'pieces', 'Normal'),
(1009, 'S007', 202, 1242, 'Dinner Plate', 'Brand H', NULL, 150, 'pieces', 'Low'),
(1010, 'S008', 203, 1240, 'Wine Glass', 'Brand I', '', 100, 'pieces', 'Low'),
(1011, 'S009', 204, 1243, 'Cutlery Set', 'Brand J', NULL, 50, 'sets', 'Low'),
(1012, 'S010', 205, 1244, 'Tablecloth', 'Brand K', NULL, 20, 'pieces', 'Low'),
(1014, 'S005', 104, 1234, 'Fresh Fillet', 'Brand U', '', 5000, 'pieces', 'Normal'),
(1015, 'S001', 105, 1238, 'Mango', 'Brand F', '', 22, 'box', 'Low'),
(1019, 'S002', 101, 1212, 'Japan Sun Egg', 'Brand K', '', 0, 'dozen', 'Out of Stock'),
(1021, 'S003', 105, 1235, 'Potato', 'Brand J', '', 100, 'box', 'Normal');

-- --------------------------------------------------------

--
-- Table structure for table `item_category`
--

CREATE TABLE `item_category` (
  `categoryID` int(4) NOT NULL,
  `categoryName` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `item_category`
--

INSERT INTO `item_category` (`categoryID`, `categoryName`) VALUES
(1212, 'Sweeteners'),
(1234, 'Meat and Poultry'),
(1235, 'Seafood'),
(1236, 'Dairy Products'),
(1237, 'Baked Goods'),
(1238, 'Fruits and Vegetables'),
(1239, 'Beverages'),
(1240, 'Kitchen Utensils'),
(1241, 'Cleaning Supplies'),
(1242, 'Tableware'),
(1243, 'Furniture'),
(1244, 'Decorations');

-- --------------------------------------------------------

--
-- Table structure for table `item_type`
--

CREATE TABLE `item_type` (
  `itemTypeID` int(4) NOT NULL,
  `typeName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `item_type`
--

INSERT INTO `item_type` (`itemTypeID`, `typeName`) VALUES
(101, 'Chicken Egg'),
(102, 'Brown Sugar'),
(103, 'Beef Steak'),
(104, 'Salmon Fillet'),
(105, 'Vegetable Stir-Fry'),
(106, 'Pasta Carbonara'),
(107, 'Sushi Roll'),
(201, 'Water Glass'),
(202, 'Dinner Plate'),
(203, 'Wine Glass'),
(204, 'Cutlery Set'),
(205, 'Tablecloth');

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `orderID` varchar(50) NOT NULL,
  `order_type` enum('bpa','ppa') NOT NULL,
  `requestID` int(9) NOT NULL,
  `order_agreement_id` varchar(11) NOT NULL,
  `item_aID` int(11) NOT NULL,
  `item_vID` int(11) NOT NULL,
  `order_qty` int(11) NOT NULL,
  `unit` varchar(50) NOT NULL,
  `pickUpDate` date NOT NULL,
  `createDate` date NOT NULL,
  `remark` varchar(255) NOT NULL,
  `status` enum('In Progress','Completed','Cancelled') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`orderID`, `order_type`, `requestID`, `order_agreement_id`, `item_aID`, `item_vID`, `order_qty`, `unit`, `pickUpDate`, `createDate`, `remark`, `status`) VALUES
('o00001', 'bpa', 120, 'bpa0001', 1002, 4500, 2, 'kilogram', '2023-06-09', '2023-06-29', '', 'Cancelled'),
('o00002', 'bpa', 120, 'bpa0005', 1004, 4501, 3, 'pieces', '2023-06-09', '2023-06-29', 'test123', 'In Progress'),
('o00003', 'ppa', 127, 'ppa0003', 1004, 4501, 3, 'kilograms', '2023-06-22', '2023-06-29', 'a', 'In Progress');

-- --------------------------------------------------------

--
-- Table structure for table `order_cpa_item_mapping`
--

CREATE TABLE `order_cpa_item_mapping` (
  `orderCPAItemID` int(8) NOT NULL,
  `itemAID` int(11) NOT NULL,
  `itemName` varchar(100) NOT NULL,
  `ordersID` varchar(50) NOT NULL,
  `totalQty` int(10) NOT NULL,
  `unit` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `order_cpa_item_mapping`
--

INSERT INTO `order_cpa_item_mapping` (`orderCPAItemID`, `itemAID`, `itemName`, `ordersID`, `totalQty`, `unit`) VALUES
(15, 1002, 'Sugar', 'c00001', 4, 'kilogram'),
(16, 1004, 'Brown Sugar', 'c00001', 200, 'kilograms');

-- --------------------------------------------------------

--
-- Table structure for table `position`
--

CREATE TABLE `position` (
  `positionID` int(3) NOT NULL,
  `positionName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `position`
--

INSERT INTO `position` (`positionID`, `positionName`) VALUES
(1, 'Admin'),
(100, 'Purchase manager'),
(104, 'Warehouse manager'),
(110, 'Account manager'),
(111, 'Category manager'),
(123, 'Restaurant manager');

-- --------------------------------------------------------

--
-- Table structure for table `ppa`
--

CREATE TABLE `ppa` (
  `ContractNumber` varchar(11) NOT NULL,
  `TentativeSchedules` varchar(50) NOT NULL,
  `StartDate` date NOT NULL,
  `EndDate` date NOT NULL,
  `EffectiveDay` int(11) NOT NULL,
  `SupplierID` varchar(20) NOT NULL,
  `TermsAndCondition` varchar(3000) NOT NULL,
  `ItemID` int(11) NOT NULL,
  `Price` int(11) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `UOM` varchar(50) NOT NULL,
  `Status` enum('Valid','Invalid') NOT NULL,
  `Signatures` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `ppa`
--

INSERT INTO `ppa` (`ContractNumber`, `TentativeSchedules`, `StartDate`, `EndDate`, `EffectiveDay`, `SupplierID`, `TermsAndCondition`, `ItemID`, `Price`, `Quantity`, `UOM`, `Status`, `Signatures`) VALUES
('ppa0001', '1 week', '2023-06-01', '2023-11-01', 519, 'S001', 'Test2', 1009, 200, 400, 'pack', 'Valid', 'Peter Wong'),
('ppa0002', '4 month', '2023-07-02', '2023-05-04', 208, 'S001', 'test2', 1011, 200, 40, 'set', 'Invalid', 'Peter Wong'),
('ppa0003', '3 Week', '2023-06-29', '2024-05-23', 328, 'S003', 'test', 1004, 20, 1997, 'kilogram', 'Valid', 'Hin');

-- --------------------------------------------------------

--
-- Table structure for table `request_change_item_log`
--

CREATE TABLE `request_change_item_log` (
  `requestItemLogID` int(9) NOT NULL,
  `requestLogID` int(11) NOT NULL,
  `logItemVID` int(11) NOT NULL,
  `logItemName` varchar(255) NOT NULL,
  `logItemType` varchar(50) NOT NULL,
  `logItemCategory` varchar(255) NOT NULL,
  `logBrand` varchar(50) NOT NULL,
  `logItemQty` int(11) NOT NULL,
  `logItemUnit` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `request_change_item_log`
--

INSERT INTO `request_change_item_log` (`requestItemLogID`, `requestLogID`, `logItemVID`, `logItemName`, `logItemType`, `logItemCategory`, `logBrand`, `logItemQty`, `logItemUnit`) VALUES
(123, 150, 4500, 'Sugar', 'Brown Sugar', 'Sweeteners', 'Sweeteners', 2, 'kilogram'),
(124, 151, 4500, 'Sugar', 'Brown Sugar', 'Sweeteners', 'Sweeteners', 2, 'kilogram'),
(125, 152, 4500, 'Sugar', 'Brown Sugar', 'Sweeteners', 'Sweeteners', 2, 'kilogram'),
(127, 156, 4500, 'Sugar', 'Brown Sugar', 'Sweeteners', 'Brand A', 2, 'kilogram'),
(128, 156, 4501, 'Brown Sugar', 'Tablecloth', 'Decorations', 'Brand K', 2, 'pieces'),
(129, 158, 4501, 'Dinner Plate', 'Brown Sugar', 'Sweeteners', 'Sweeteners', 200, 'kilograms');

-- --------------------------------------------------------

--
-- Table structure for table `request_change_log`
--

CREATE TABLE `request_change_log` (
  `requestLogID` int(11) NOT NULL,
  `requestID` int(9) NOT NULL,
  `modifyType` enum('Update','Cancel Item','Cancel Request') NOT NULL,
  `logPickUpDate` date NOT NULL,
  `requestDateTime` datetime NOT NULL,
  `modifyReason` varchar(255) NOT NULL,
  `requestRemark` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `request_change_log`
--

INSERT INTO `request_change_log` (`requestLogID`, `requestID`, `modifyType`, `logPickUpDate`, `requestDateTime`, `modifyReason`, `requestRemark`) VALUES
(149, 116, 'Cancel Request', '2023-05-28', '2023-05-29 01:28:49', 'aa', 'bb'),
(150, 120, 'Update', '2023-06-09', '2023-06-01 12:03:56', '', ''),
(151, 120, 'Update', '2023-06-09', '2023-06-02 01:12:26', '', ''),
(152, 118, 'Update', '2023-05-29', '2023-06-02 01:13:15', '', ''),
(156, 122, 'Cancel Item', '2023-06-02', '2023-06-02 01:34:07', 'b', ''),
(157, 122, 'Cancel Request', '2023-06-02', '2023-06-02 01:34:15', 'b', ''),
(158, 128, 'Update', '2023-06-30', '2023-06-30 17:36:45', 'test 1', '');

-- --------------------------------------------------------

--
-- Table structure for table `request_item`
--

CREATE TABLE `request_item` (
  `requestItemRecordID` int(11) NOT NULL,
  `requestItemVID` int(11) NOT NULL,
  `requestID` int(9) NOT NULL,
  `requestItemName` varchar(255) NOT NULL,
  `requestItemTypeName` varchar(50) NOT NULL,
  `requestItemCategory` varchar(255) NOT NULL,
  `requestBrand` varchar(50) NOT NULL,
  `requestQty` int(11) NOT NULL,
  `unit` varchar(20) NOT NULL,
  `itemStatus` enum('Pending','In Progress','Completed','Cancelled','Update','Cancel Request','Rejected','Delivered') NOT NULL DEFAULT 'Pending'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `request_item`
--

INSERT INTO `request_item` (`requestItemRecordID`, `requestItemVID`, `requestID`, `requestItemName`, `requestItemTypeName`, `requestItemCategory`, `requestBrand`, `requestQty`, `unit`, `itemStatus`) VALUES
(194, 4500, 118, 'Sugar', 'Brown Sugar', 'Sweeteners', 'Brand A', 2, 'kilogram', 'Completed'),
(195, 4501, 118, 'Brown Sugar', 'Brown Sugar', 'Sweeteners', 'Brand C', 3, 'kilogram', 'Completed'),
(196, 4503, 119, 'Salmon', 'Chicken Egg', 'Meat and Poultry', 'Brand B', 3, 'dozen', 'In Progress'),
(197, 4500, 120, 'Sugar', 'Brown Sugar', 'Sweeteners', 'Brand A', 2, 'kilogram', 'In Progress'),
(201, 4500, 122, 'Sugar', 'Brown Sugar', 'Sweeteners', 'Brand A', 2, 'kilogram', 'Cancel Request'),
(203, 4502, 122, 'Beef', 'Beef Steak', 'Meat and Poultry', 'Brand D', 3, 'kilograms', 'Cancel Request'),
(204, 4502, 123, 'Beef', 'Beef Steak', 'Meat and Poultry', 'Brand D', 2, 'kilograms', 'In Progress'),
(205, 4500, 124, 'Sugar', 'Brown Sugar', 'Sweeteners', 'Brand A', 9999, 'kilogram', 'In Progress'),
(207, 4503, 125, 'Salmon', 'Chicken Egg', 'Meat and Poultry', 'Brand B', 50, 'dozen', 'Rejected'),
(208, 4504, 125, 'Carrots', 'Vegetable Stir-Fry', 'Fruits and Vegetables', 'Brand F', 100, 'kilograms', 'Rejected'),
(210, 4508, 126, 'Cutlery Set', 'Cutlery Set', 'Furniture', 'Brand J', 22, 'sets', 'In Progress'),
(211, 4509, 126, 'Tablecloth', 'Tablecloth', 'Decorations', 'Brand K', 22, 'pieces', 'In Progress'),
(212, 4510, 126, 'Chicken Egg', 'Beef Steak', 'Meat and Poultry', 'bbb', 66, 'ppp', 'In Progress'),
(213, 4500, 127, 'Sugar', 'Brown Sugar', 'Sweeteners', 'Brand A', 4, 'kilogram', 'In Progress'),
(214, 4501, 127, 'Brown Sugar', 'Brown Sugar', 'Sweeteners', 'Brand C', 3, 'kilogram', 'In Progress'),
(215, 4501, 128, 'Dinner Plate', 'Brown Sugar', 'Sweeteners', 'Brand C', 200, 'kilograms', 'Update'),
(216, 4507, 128, 'Wine Glass', 'Wine Glass', 'Kitchen Utensils', 'Brand I', 300, 'pieces', 'Pending'),
(217, 4507, 129, 'Wine Glass', 'Wine Glass', 'Kitchen Utensils', 'Brand I', 55, 'pieces', 'Pending'),
(218, 4508, 129, 'Cutlery Set', 'Cutlery Set', 'Furniture', 'Brand J', 70, 'sets', 'Pending'),
(219, 4505, 130, 'Water Glass', 'Water Glass', 'Cleaning Supplies', 'Brand G', 2, 'pieces', 'Pending'),
(220, 4506, 130, 'Dinner Plate', 'Brown Sugar', 'Sweeteners', 'Brand C', 3, 'kilograms', 'Pending'),
(221, 4507, 130, 'Wine Glass', 'Wine Glass', 'Kitchen Utensils', 'Brand I', 4, 'pieces', 'Pending');

-- --------------------------------------------------------

--
-- Table structure for table `request_record`
--

CREATE TABLE `request_record` (
  `requestID` int(9) NOT NULL,
  `userID` int(5) NOT NULL,
  `requestDateTime` datetime NOT NULL DEFAULT current_timestamp(),
  `pickUpDate` date NOT NULL,
  `remark` varchar(255) NOT NULL,
  `status` enum('Pending','Review','Approved','Rejected','Order Placed','Delivered','Completed','Cancelled','Cancel Request') NOT NULL DEFAULT 'Pending'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `request_record`
--

INSERT INTO `request_record` (`requestID`, `userID`, `requestDateTime`, `pickUpDate`, `remark`, `status`) VALUES
(116, 20579, '2023-05-28 00:59:14', '2023-05-28', 'bb', 'Cancelled'),
(118, 20579, '2023-05-29 01:29:07', '2023-05-29', '', 'Completed'),
(119, 20579, '2023-05-30 19:28:30', '2023-05-30', '', 'Order Placed'),
(120, 20579, '2023-06-01 12:03:34', '2023-06-09', '', 'Order Placed'),
(122, 20579, '2023-06-02 01:33:37', '2023-06-02', '', 'Cancel Request'),
(123, 20579, '2023-06-10 03:02:35', '2023-06-10', 'test1', 'Order Placed'),
(124, 20579, '2023-06-27 14:07:14', '2023-06-27', '', 'Order Placed'),
(125, 20579, '2023-06-28 05:07:45', '2023-06-28', 'Test Reject 2', 'Rejected'),
(126, 20579, '2023-06-29 10:46:54', '2023-08-24', '', 'Order Placed'),
(127, 20579, '2023-06-29 20:39:25', '2023-06-22', '', 'Order Placed'),
(128, 20579, '2023-06-30 02:53:35', '2023-06-30', '', 'Pending'),
(129, 20579, '2023-06-30 17:31:38', '2023-08-25', '', 'Pending'),
(130, 20579, '2023-07-01 12:44:24', '2023-07-21', '', 'Pending');

-- --------------------------------------------------------

--
-- Table structure for table `restaurant`
--

CREATE TABLE `restaurant` (
  `RestaurantID` int(3) NOT NULL,
  `restaurantTypeID` int(2) NOT NULL,
  `restaurantName` varchar(50) NOT NULL,
  `address` varchar(255) NOT NULL,
  `phone` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `restaurant`
--

INSERT INTO `restaurant` (`RestaurantID`, `restaurantTypeID`, `restaurantName`, `address`, `phone`) VALUES
(1, 1, 'Burger Joys', '27-29 First Street, Sai Ying Pun, Western District LG/F, Tai Yik House,, Hong Kong China', 26823832),
(2, 2, 'The Aubrey', '5 Connaught Road Central 25F, Mandarin Oriental Hotel, Central, Hong Kong China', 28254001);

-- --------------------------------------------------------

--
-- Table structure for table `restaurant_staff_mapping`
--

CREATE TABLE `restaurant_staff_mapping` (
  `restaurantID` int(3) NOT NULL,
  `userID` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `restaurant_staff_mapping`
--

INSERT INTO `restaurant_staff_mapping` (`restaurantID`, `userID`) VALUES
(1, 20579),
(2, 54322);

-- --------------------------------------------------------

--
-- Table structure for table `restaurant_stock`
--

CREATE TABLE `restaurant_stock` (
  `restaurantID` int(11) NOT NULL,
  `itemID` int(11) NOT NULL,
  `stockStatus` enum('Low','Normal','Out of Stock') NOT NULL,
  `stockQty` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `restaurant_stock`
--

INSERT INTO `restaurant_stock` (`restaurantID`, `itemID`, `stockStatus`, `stockQty`) VALUES
(1, 4502, 'Normal', 500),
(1, 4511, 'Normal', 80),
(2, 4501, 'Low', 20),
(2, 4504, 'Out of Stock', 0);

-- --------------------------------------------------------

--
-- Table structure for table `restaurant_type`
--

CREATE TABLE `restaurant_type` (
  `restaurantTypeID` int(2) NOT NULL,
  `restaurantTypeName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `restaurant_type`
--

INSERT INTO `restaurant_type` (`restaurantTypeID`, `restaurantTypeName`) VALUES
(1, 'Western'),
(2, 'Japanese'),
(3, 'Conveyor Belt Sushi'),
(4, 'Fast Food');

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `userID` int(5) NOT NULL,
  `positionID` int(3) NOT NULL,
  `departmentID` int(3) NOT NULL,
  `restaurantID` int(8) NOT NULL,
  `password` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `firstName` varchar(20) NOT NULL,
  `lastName` varchar(20) NOT NULL,
  `gender` char(1) NOT NULL,
  `contactNumber` int(8) DEFAULT NULL,
  `status` enum('Locked','Normal') NOT NULL,
  `remark` varchar(255) DEFAULT NULL,
  `managerID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`userID`, `positionID`, `departmentID`, `restaurantID`, `password`, `email`, `firstName`, `lastName`, `gender`, `contactNumber`, `status`, `remark`, `managerID`) VALUES
(1, 1, 6, 0, 'dd417f5cc4c69b618932775d886b73acfb675d9f', 'yummyAdmin@yummy.com', 'John', 'Chan', 'M', 65784125, 'Normal', '', NULL),
(1004, 104, 4, 0, 'dd417f5cc4c69b618932775d886b73acfb675d9f', 'yummywarehouse12345@yummy.com', 'May', 'Chan', 'F', 57458745, 'Normal', NULL, NULL),
(10101, 110, 5, 0, 'dd417f5cc4c69b618932775d886b73acfb675d9f', 'yummyAccount@yummy.com', 'Ben', 'Chao', 'M', 51247854, 'Normal', NULL, NULL),
(12345, 100, 3, 0, 'dd417f5cc4c69b618932775d886b73acfb675d9f', 'yummypurchase12345@yummy.com', 'Peter', 'Chan', 'F', 65784125, 'Normal', '', NULL),
(20579, 123, 1, 1, 'dd417f5cc4c69b618932775d886b73acfb675d9f', 'jason199754@gmail.com', 'Kwok Hin', 'Kong', 'M', 57841258, 'Normal', NULL, NULL),
(54321, 111, 2, 0, 'dd417f5cc4c69b618932775d886b73acfb675d9f', 'ilovevtc@vtcmail.com', 'Ka Tai', 'ku', 'M', 57841268, 'Normal', NULL, NULL),
(54322, 123, 1, 0, 'dd417f5cc4c69b618932775d886b73acfb675d9f', 'testRes@yummy.com', 'a', 'a', 'F', 12547854, 'Normal', NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `supplierID` varchar(20) NOT NULL,
  `companyName` varchar(100) NOT NULL,
  `contactName` varchar(50) NOT NULL,
  `contactNumber` int(8) NOT NULL,
  `address` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`supplierID`, `companyName`, `contactName`, `contactNumber`, `address`) VALUES
('S001', 'Supplier Company B', 'Jane Smith', 98765432, '456 Elm Avenue'),
('S002', 'Supplier Company A', 'John Doe', 25479158, '123 Main Street'),
('S003', 'Supplier Company C', 'Mike Johnson', 54871546, '789 Oak Road'),
('S004', 'Supplier Company D', 'Sarah Davis', 25478513, '321 Pine Lane'),
('S005', 'Supplier Company E', 'Robert Wilson', 98578541, '654 Maple Drive'),
('S006', 'Supplier Company F', 'Emily Anderson', 65478541, '987 Cedar Court'),
('S007', 'Supplier Company Z', 'Michael War Brown', 98765432, '852 Birch Street 123'),
('S008', 'Supplier Company H', 'Jessica Taylor', 56325874, '369 Walnut Avenue'),
('S009', 'Supplier Company I', 'Christopher Clark', 95478963, '753 Spruce Road'),
('S010', 'Supplier Company J', 'Jennifer Martinez', 51254785, '159 Oakwood Drive');

-- --------------------------------------------------------

--
-- Table structure for table `vidmapping`
--

CREATE TABLE `vidmapping` (
  `vID` int(11) NOT NULL,
  `vName` varchar(255) NOT NULL,
  `aID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `vidmapping`
--

INSERT INTO `vidmapping` (`vID`, `vName`, `aID`) VALUES
(4500, 'Sugar', 1002),
(4501, 'Brown Sugar', 1004),
(4502, 'Beef', 1005),
(4503, 'Salmon', 1003),
(4504, 'Carrots', 1007),
(4505, 'Water Glass', 1008),
(4506, 'Dinner Plate', 1004),
(4507, 'Wine Glass', 1010),
(4508, 'Cutlery Set', 1011),
(4509, 'Tablecloth', 1012),
(4510, 'Chicken Egg', 1014),
(4511, 'mango', 1015);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bpa`
--
ALTER TABLE `bpa`
  ADD PRIMARY KEY (`ContractNumber`),
  ADD KEY `bpa_supplierID_fk` (`SupplierID`),
  ADD KEY `bpa_itemID` (`ItemID`);

--
-- Indexes for table `contract_order`
--
ALTER TABLE `contract_order`
  ADD PRIMARY KEY (`contractOrderID`);

--
-- Indexes for table `cpa`
--
ALTER TABLE `cpa`
  ADD KEY `cpa_supplier_fk` (`SupplierID`);

--
-- Indexes for table `delivery_note`
--
ALTER TABLE `delivery_note`
  ADD PRIMARY KEY (`deliveryNoteID`),
  ADD KEY `deliveryResID_fk` (`restaurantID`),
  ADD KEY `deliveryNote_requestID_fk` (`requestID`),
  ADD KEY `deliveryNote_despatchID_fk` (`despatchID`);

--
-- Indexes for table `delivery_note_item`
--
ALTER TABLE `delivery_note_item`
  ADD PRIMARY KEY (`delivery_note_itemID`),
  ADD KEY `deliveryID_dID_fk` (`deliveryID`),
  ADD KEY `delivery_item_fk` (`itemID`);

--
-- Indexes for table `department`
--
ALTER TABLE `department`
  ADD PRIMARY KEY (`deptID`);

--
-- Indexes for table `despatch_instruction`
--
ALTER TABLE `despatch_instruction`
  ADD PRIMARY KEY (`despatchID`),
  ADD KEY `despatch_userID` (`purchaseManagerID`),
  ADD KEY `despatch_restaurantID` (`restaurantID`),
  ADD KEY `despatch_requestID` (`requestID`);

--
-- Indexes for table `despatch_instruction_item_mapping`
--
ALTER TABLE `despatch_instruction_item_mapping`
  ADD PRIMARY KEY (`despatchitemMappingID`),
  ADD KEY `despatchID_itemID_fk` (`itemID`),
  ADD KEY `despatchID_fk` (`despatchID`);

--
-- Indexes for table `item`
--
ALTER TABLE `item`
  ADD PRIMARY KEY (`itemID`),
  ADD KEY `item_ItemType_fk` (`typeID`),
  ADD KEY `item_categoryID_fk` (`categoryID`),
  ADD KEY `itemSupplier_supplierID_fk` (`supplierID`);

--
-- Indexes for table `item_category`
--
ALTER TABLE `item_category`
  ADD PRIMARY KEY (`categoryID`);

--
-- Indexes for table `item_type`
--
ALTER TABLE `item_type`
  ADD PRIMARY KEY (`itemTypeID`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`orderID`),
  ADD KEY `aID_itemID_fk` (`item_aID`),
  ADD KEY `o_requestID_fk` (`requestID`),
  ADD KEY `o_itemVID_fk` (`item_vID`);

--
-- Indexes for table `order_cpa_item_mapping`
--
ALTER TABLE `order_cpa_item_mapping`
  ADD PRIMARY KEY (`orderCPAItemID`),
  ADD KEY `oItemID_itemID_fk` (`itemAID`),
  ADD KEY `oID_contractOID` (`ordersID`);

--
-- Indexes for table `position`
--
ALTER TABLE `position`
  ADD PRIMARY KEY (`positionID`);

--
-- Indexes for table `ppa`
--
ALTER TABLE `ppa`
  ADD PRIMARY KEY (`ContractNumber`),
  ADD KEY `ppa_supplier_fk` (`SupplierID`),
  ADD KEY `ppa_item_fk` (`ItemID`);

--
-- Indexes for table `request_change_item_log`
--
ALTER TABLE `request_change_item_log`
  ADD PRIMARY KEY (`requestItemLogID`),
  ADD KEY `itemLog_changeLogID_fk` (`requestLogID`);

--
-- Indexes for table `request_change_log`
--
ALTER TABLE `request_change_log`
  ADD PRIMARY KEY (`requestLogID`),
  ADD KEY `logRequestID_reuqestID_fk` (`requestID`);

--
-- Indexes for table `request_item`
--
ALTER TABLE `request_item`
  ADD PRIMARY KEY (`requestItemRecordID`),
  ADD KEY `rItem_rID_fk` (`requestID`),
  ADD KEY `requestItemVID_vMappingID_fk` (`requestItemVID`);

--
-- Indexes for table `request_record`
--
ALTER TABLE `request_record`
  ADD PRIMARY KEY (`requestID`),
  ADD KEY `requestUID_staffUID_fk` (`userID`);

--
-- Indexes for table `restaurant`
--
ALTER TABLE `restaurant`
  ADD PRIMARY KEY (`RestaurantID`),
  ADD KEY `restaurant_type_fk` (`restaurantTypeID`);

--
-- Indexes for table `restaurant_staff_mapping`
--
ALTER TABLE `restaurant_staff_mapping`
  ADD PRIMARY KEY (`restaurantID`,`userID`),
  ADD KEY `stMapping_fk` (`userID`,`restaurantID`) USING BTREE;

--
-- Indexes for table `restaurant_stock`
--
ALTER TABLE `restaurant_stock`
  ADD PRIMARY KEY (`restaurantID`,`itemID`),
  ADD KEY `ri_item_fk` (`itemID`);

--
-- Indexes for table `restaurant_type`
--
ALTER TABLE `restaurant_type`
  ADD PRIMARY KEY (`restaurantTypeID`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`userID`),
  ADD KEY `staff_position_fk` (`positionID`),
  ADD KEY `staff_dept_fk` (`departmentID`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`supplierID`);

--
-- Indexes for table `vidmapping`
--
ALTER TABLE `vidmapping`
  ADD PRIMARY KEY (`vID`),
  ADD KEY `itemID_aID_fk` (`aID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `delivery_note_item`
--
ALTER TABLE `delivery_note_item`
  MODIFY `delivery_note_itemID` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `department`
--
ALTER TABLE `department`
  MODIFY `deptID` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `despatch_instruction_item_mapping`
--
ALTER TABLE `despatch_instruction_item_mapping`
  MODIFY `despatchitemMappingID` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT for table `item`
--
ALTER TABLE `item`
  MODIFY `itemID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1022;

--
-- AUTO_INCREMENT for table `item_category`
--
ALTER TABLE `item_category`
  MODIFY `categoryID` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1245;

--
-- AUTO_INCREMENT for table `item_type`
--
ALTER TABLE `item_type`
  MODIFY `itemTypeID` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=206;

--
-- AUTO_INCREMENT for table `order_cpa_item_mapping`
--
ALTER TABLE `order_cpa_item_mapping`
  MODIFY `orderCPAItemID` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `position`
--
ALTER TABLE `position`
  MODIFY `positionID` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1005;

--
-- AUTO_INCREMENT for table `request_change_item_log`
--
ALTER TABLE `request_change_item_log`
  MODIFY `requestItemLogID` int(9) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=130;

--
-- AUTO_INCREMENT for table `request_change_log`
--
ALTER TABLE `request_change_log`
  MODIFY `requestLogID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=159;

--
-- AUTO_INCREMENT for table `request_item`
--
ALTER TABLE `request_item`
  MODIFY `requestItemRecordID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=222;

--
-- AUTO_INCREMENT for table `request_record`
--
ALTER TABLE `request_record`
  MODIFY `requestID` int(9) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=131;

--
-- AUTO_INCREMENT for table `restaurant`
--
ALTER TABLE `restaurant`
  MODIFY `RestaurantID` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `restaurant_type`
--
ALTER TABLE `restaurant_type`
  MODIFY `restaurantTypeID` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `staff`
--
ALTER TABLE `staff`
  MODIFY `userID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=54323;

--
-- AUTO_INCREMENT for table `vidmapping`
--
ALTER TABLE `vidmapping`
  MODIFY `vID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10002;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `bpa`
--
ALTER TABLE `bpa`
  ADD CONSTRAINT `bpa_itemID` FOREIGN KEY (`ItemID`) REFERENCES `item` (`itemID`),
  ADD CONSTRAINT `bpa_supplierID_fk` FOREIGN KEY (`SupplierID`) REFERENCES `supplier` (`supplierID`);

--
-- Constraints for table `cpa`
--
ALTER TABLE `cpa`
  ADD CONSTRAINT `cpa_supplier_fk` FOREIGN KEY (`SupplierID`) REFERENCES `supplier` (`supplierID`);

--
-- Constraints for table `delivery_note`
--
ALTER TABLE `delivery_note`
  ADD CONSTRAINT `deliveryNote_despatchID_fk` FOREIGN KEY (`despatchID`) REFERENCES `despatch_instruction` (`despatchID`),
  ADD CONSTRAINT `deliveryResID_fk` FOREIGN KEY (`restaurantID`) REFERENCES `restaurant` (`RestaurantID`);

--
-- Constraints for table `delivery_note_item`
--
ALTER TABLE `delivery_note_item`
  ADD CONSTRAINT `deliveryID_dID_fk` FOREIGN KEY (`deliveryID`) REFERENCES `delivery_note` (`deliveryNoteID`),
  ADD CONSTRAINT `delivery_item_fk` FOREIGN KEY (`itemID`) REFERENCES `vidmapping` (`vID`);

--
-- Constraints for table `despatch_instruction`
--
ALTER TABLE `despatch_instruction`
  ADD CONSTRAINT `despatch_requestID` FOREIGN KEY (`requestID`) REFERENCES `request_record` (`requestID`),
  ADD CONSTRAINT `despatch_restaurantID` FOREIGN KEY (`restaurantID`) REFERENCES `restaurant` (`RestaurantID`),
  ADD CONSTRAINT `despatch_userID` FOREIGN KEY (`purchaseManagerID`) REFERENCES `staff` (`userID`);

--
-- Constraints for table `despatch_instruction_item_mapping`
--
ALTER TABLE `despatch_instruction_item_mapping`
  ADD CONSTRAINT `despatchID_fk` FOREIGN KEY (`despatchID`) REFERENCES `despatch_instruction` (`despatchID`),
  ADD CONSTRAINT `despatchID_itemID_fk` FOREIGN KEY (`itemID`) REFERENCES `vidmapping` (`vID`);

--
-- Constraints for table `item`
--
ALTER TABLE `item`
  ADD CONSTRAINT `itemSupplier_supplierID_fk` FOREIGN KEY (`supplierID`) REFERENCES `supplier` (`supplierID`),
  ADD CONSTRAINT `item_ItemType_fk` FOREIGN KEY (`typeID`) REFERENCES `item_type` (`itemTypeID`),
  ADD CONSTRAINT `item_categoryID_fk` FOREIGN KEY (`categoryID`) REFERENCES `item_category` (`categoryID`);

--
-- Constraints for table `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `aID_itemID_fk` FOREIGN KEY (`item_aID`) REFERENCES `item` (`itemID`),
  ADD CONSTRAINT `o_itemVID_fk` FOREIGN KEY (`item_vID`) REFERENCES `vidmapping` (`vID`),
  ADD CONSTRAINT `o_requestID_fk` FOREIGN KEY (`requestID`) REFERENCES `request_record` (`requestID`);

--
-- Constraints for table `order_cpa_item_mapping`
--
ALTER TABLE `order_cpa_item_mapping`
  ADD CONSTRAINT `oID_contractOID` FOREIGN KEY (`ordersID`) REFERENCES `contract_order` (`contractOrderID`),
  ADD CONSTRAINT `oItemID_itemID_fk` FOREIGN KEY (`itemAID`) REFERENCES `item` (`itemID`);

--
-- Constraints for table `ppa`
--
ALTER TABLE `ppa`
  ADD CONSTRAINT `ppa_item_fk` FOREIGN KEY (`ItemID`) REFERENCES `item` (`itemID`),
  ADD CONSTRAINT `ppa_supplier_fk` FOREIGN KEY (`SupplierID`) REFERENCES `supplier` (`supplierID`);

--
-- Constraints for table `request_change_item_log`
--
ALTER TABLE `request_change_item_log`
  ADD CONSTRAINT `itemLog_changeLogID_fk` FOREIGN KEY (`requestLogID`) REFERENCES `request_change_log` (`requestLogID`);

--
-- Constraints for table `request_change_log`
--
ALTER TABLE `request_change_log`
  ADD CONSTRAINT `logRequestID_reuqestID_fk` FOREIGN KEY (`requestID`) REFERENCES `request_record` (`requestID`);

--
-- Constraints for table `request_item`
--
ALTER TABLE `request_item`
  ADD CONSTRAINT `rItem_rID_fk` FOREIGN KEY (`requestID`) REFERENCES `request_record` (`requestID`);

--
-- Constraints for table `restaurant`
--
ALTER TABLE `restaurant`
  ADD CONSTRAINT `restaurant_type_fk` FOREIGN KEY (`restaurantTypeID`) REFERENCES `restaurant_type` (`restaurantTypeID`);

--
-- Constraints for table `restaurant_staff_mapping`
--
ALTER TABLE `restaurant_staff_mapping`
  ADD CONSTRAINT `rsMapping_fk` FOREIGN KEY (`restaurantID`) REFERENCES `restaurant` (`RestaurantID`),
  ADD CONSTRAINT `stMapping_fk` FOREIGN KEY (`userID`) REFERENCES `staff` (`userID`);

--
-- Constraints for table `restaurant_stock`
--
ALTER TABLE `restaurant_stock`
  ADD CONSTRAINT `ri_item_fk` FOREIGN KEY (`itemID`) REFERENCES `vidmapping` (`vID`),
  ADD CONSTRAINT `ri_restaurant_fk` FOREIGN KEY (`restaurantID`) REFERENCES `restaurant` (`RestaurantID`);

--
-- Constraints for table `staff`
--
ALTER TABLE `staff`
  ADD CONSTRAINT `staff_dept_fk` FOREIGN KEY (`departmentID`) REFERENCES `department` (`deptID`),
  ADD CONSTRAINT `staff_position_fk` FOREIGN KEY (`positionID`) REFERENCES `position` (`positionID`);

--
-- Constraints for table `vidmapping`
--
ALTER TABLE `vidmapping`
  ADD CONSTRAINT `vAID_itemID_fk` FOREIGN KEY (`aID`) REFERENCES `item` (`itemID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
