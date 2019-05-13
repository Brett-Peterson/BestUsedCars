 /*This creates a database called BestUsedCarsVehicles and populates with 9 test cars in a Tables called PurchasedVehicles
 //It also creates Tables for CurrentVehicles and SoldVehicles
 //They need to link to the Forms frmPurchaseVehile and frmSellVehicle and List of Current Vehicles
 */
use master
IF DB_ID('BestUsedCarsVehicles') IS NOT NULL
		DROP DATABASE BestUsedCarsVehicles
GO
CREATE DATABASE BestUsedCarsVehicles
GO

USE [BestUsedCarsVehicles]
GO

/****** Object: Table [dbo].[Table] Script Date: 4/19/2019 4:41:10 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PurchasedVehicles] (
    [LotID]			INT          IDENTITY (1000, 1) NOT NULL,
    [VIN]			NCHAR (17) Primary Key,
    [Year]			INT          NOT NULL,
    [Make]			NCHAR (30)   NOT NULL,
    [Model]			NCHAR (30)   NOT NULL,
    [Color]			NCHAR (20)   NOT NULL,
    [Miles]			INT          Not NULL,
    [Cost]			MONEY        Not NULL,
	[SellerName]    NCHAR(30)    NOT NULL
);
GO



Create Table[dbo].[CurrentVehicles](
    [VIN]			 NCHAR (17) Primary Key,
	[PicId]			 NCHAR (20)   NULL,
	[RepairCosts]	 Money		  NULL,
	[PrepCosts]		 Money		  NULL,
	[OtherCosts]	 Money		  Null,
	[TotalCost]		 Money		  NOT NULL,

	);
GO
Create Table [dbo].[SoldVehicles](

    [VIN]			 NCHAR (17) Primary Key,
	[Customer Name]  Nchar(30)	  NOT NULL,
    [Address1]	     NCHAR(30)    NULL,
	[Address2]		 NCHAR(30)	  Null,
	[City]			 NCHAR(30)	  Null,
	[State]			 NCHAR(2)	  Null,
	[ZipCode]		 NCHAR(10)	  Null,
    [SalePrice]      MONEY        NOT NULL,
	[SalesDate]		 Date		  Not Null,
	[SalesAgent]	 NCHAR(30)	  NOT NULL,



);
GO
Insert into PurchasedVehicles(VIN,Year,Make,Model,Color,Miles,Cost,SellerName)

Values('1FTSW21P86EA44631','2006','Ford','F 250 Powerstroke','Red','12532','11900','Daffy Duck')
	,('3GTU2MEC8HG143064','2017','GMC','Sierra 1500 SLE','White','22447','11450','Manheim')
	,('1FTFW1ET3BFC96648','2011','Ford','F 150 Platinum','Black','112566','15900','Manheim')
	,('3GYFNBE3XCS613244','2012','Cadillac','SRX','Red','16995','12750','SW Auctions')
	,('2G1FK1EJ6A9192021','2010','Chevrolet','Camaro SS','Custom','103367','97650','Manheim')
	,('WBA7F2C52GG419157','2016','BMW','7 Series','White','62643','37425','Fred Flintstone')
	,('3FA6P0T96GR291622','2016','Ford','Fusion SE AWD','Blue','45777','13500','Manheim')
	,('1GT424E83FF575863','2015','GMC','Sierra DURAMAX 3500','White','40130','41900','Bill Baily')
	,('2HNYD28609H533769','2009','Acura','MDX','Black','151529','10250','Manheim')

GO
