﻿/*
Deployment script for BestUsedCarsVehicles

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "BestUsedCarsVehicles"
:setvar DefaultFilePrefix "BestUsedCarsVehicles"
:setvar DefaultDataPath "C:\Users\USER\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"
:setvar DefaultLogPath "C:\Users\USER\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Update complete.';


GO
Insert into BestUsedCarsVehicles
	('1FTSW21P86EA44631','2006','Ford','F 250 Powerstroke','17999','Red','178765')
	,('3GTU2MEC8HG143064','2017','GMC','Sierra 1500 SLE','34999','White','22447')
	,('1FTFW1ET3BFC96648','2011','Ford','F 150 Platinum','21499','Black','112566')
	,('3GYFNBE3XCS613244','2012','Cadillac','SRX','22850','Red','89906')
	,('2G1FK1EJ6A9192021','2010','Chevrolet','Camaro SS','13500','Custom','142000')
	,('WBA7F2C52GG419157','2016','BMW','7 Series','42888','White','62643')
	,('3FA6P0T96GR291622','2016','Ford','Fusion SE AWD','15999','Blue','45777')
	,('1GT424E83FF575863','2015','GMC','Sierra DURAMAX 3500','51999','White','40130')
	,('2HNYD28609H533769','2009','Acura','MDX','11990','Black','151529')
	GO