
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



GO
CREATE TABLE [dbo].[Vehicles] (
    [LotID]     INT          IDENTITY (1000, 1) NOT NULL,
    [VIN]       VARCHAR (17) NOT NULL,
    [Year]      INT          NOT NULL,
    [Make]      NCHAR (30)   NOT NULL,
    [Model]     NCHAR (30)   NOT NULL,
    [SalePrice] MONEY        NULL,
    [Color]     NCHAR (20)   NOT NULL,
    [Miles]     INT          NULL,
	[PicId]		NCHAR (20)   NULL
);
GO
Insert into Vehicles(VIN,Year,Make,Model,SalePrice,Color,Miles)

VALUES('1FTSW21P86EA44631','2006','Ford','F 250 Powerstroke','17999','Red','178765')
	,('3GTU2MEC8HG143064','2017','GMC','Sierra 1500 SLE','34999','White','22447')
	,('1FTFW1ET3BFC96648','2011','Ford','F 150 Platinum','21499','Black','112566')
	,('3GYFNBE3XCS613244','2012','Cadillac','SRX','22850','Red','89906')
	,('2G1FK1EJ6A9192021','2010','Chevrolet','Camaro SS','13500','Custom','142000')
	,('WBA7F2C52GG419157','2016','BMW','7 Series','42888','White','62643')
	,('3FA6P0T96GR291622','2016','Ford','Fusion SE AWD','15999','Blue','45777')
	,('1GT424E83FF575863','2015','GMC','Sierra DURAMAX 3500','51999','White','40130')
	,('2HNYD28609H533769','2009','Acura','MDX','11990','Black','151529')

