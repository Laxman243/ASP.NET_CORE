
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/19/2018 17:06:24
-- Generated from EDMX file: F:\ADO.NET_Programs\ConsoleApp1\ModelFirstApproach\Models\CompanyDb.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Laxman];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CompanyDetails'
CREATE TABLE [dbo].[CompanyDetails] (
    [CID] int IDENTITY(1,1) NOT NULL,
    [CName] nvarchar(max)  NOT NULL,
    [CAddress] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CID] in table 'CompanyDetails'
ALTER TABLE [dbo].[CompanyDetails]
ADD CONSTRAINT [PK_CompanyDetails]
    PRIMARY KEY CLUSTERED ([CID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------