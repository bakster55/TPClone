﻿/*
Deployment script for TrainingPortal

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "TrainingPortal"
:setvar DefaultFilePrefix "TrainingPortal"
:setvar DefaultDataPath "C:\Users\anabi\AppData\Local\Microsoft\VisualStudio\SSDT"
:setvar DefaultLogPath "C:\Users\anabi\AppData\Local\Microsoft\VisualStudio\SSDT"

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
PRINT N'Altering [dbo].[GetUserByEmail]...';


GO
ALTER PROCEDURE [dbo].[GetUserByEmail]
	@userEmail NVARCHAR(50),
	@email NVARCHAR(50) OUTPUT,
	@name NVARCHAR(50) OUTPUT,
	@id int OUTPUT
AS
	SELECT @id = [User].Id, @email = [User].Email, @name = [User].Name FROM [User] WHERE [User].Email = @userEmail
RETURN 0
GO
PRINT N'Altering [dbo].[GetUserById]...';


GO
ALTER PROCEDURE [dbo].[GetUserById]
	@userId int,
	@email NVARCHAR(50) OUTPUT,
	@name NVARCHAR(50) OUTPUT,
	@id int OUTPUT
AS
	SELECT @id = [User].Id, @email = [User].Email, @name = [User].Name FROM [User] WHERE [User].Id = @userId
RETURN 0
GO
PRINT N'Altering [dbo].[GetUserByName]...';


GO
ALTER PROCEDURE [dbo].[GetUserByName]
	@userName NVARCHAR(50),
	@email NVARCHAR(50) OUTPUT,
	@name NVARCHAR(50) OUTPUT,
	@id int OUTPUT
AS
	SELECT @id = [User].Id, @email = [User].Email, @name = [User].Name FROM [User] WHERE [User].Name = @userName
RETURN 0
GO
PRINT N'Update complete.';


GO
