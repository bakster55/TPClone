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
PRINT N'Creating [dbo].[Audience]...';


GO
CREATE TABLE [dbo].[Audience] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[AddAudience]...';


GO
CREATE PROCEDURE [dbo].[AddAudience]
	@name NVARCHAR(50)
AS
	INSERT INTO Audience VALUES(@name)
RETURN 0
GO
PRINT N'Creating [dbo].[DeleteAudience]...';


GO
CREATE PROCEDURE [dbo].[DeleteAudience]
	@id INT
AS
	DELETE FROM Audience WHERE Id = @id
RETURN 0
GO
PRINT N'Creating [dbo].[GetAudience]...';


GO
CREATE PROCEDURE [dbo].[GetAudience]
	@id INT
AS
	SELECT TOP 1 * FROM Audience WHERE Id = @id
RETURN 0
GO
PRINT N'Creating [dbo].[GetAudienceList]...';


GO
CREATE PROCEDURE [dbo].[GetAudienceList]
	@id int = NULL,
	@name NVARCHAR(50) = NULL
AS
	SELECT * FROM Audience
RETURN 0
GO
PRINT N'Creating [dbo].[UpdateAudience]...';


GO
CREATE PROCEDURE [dbo].[UpdateAudience]
    @id INT,
    @name NVARCHAR(50) = NULL
AS
BEGIN
    UPDATE Audience SET Name = ISNULL(@name, Name)
	WHERE id = @id
END
GO
PRINT N'Update complete.';


GO
