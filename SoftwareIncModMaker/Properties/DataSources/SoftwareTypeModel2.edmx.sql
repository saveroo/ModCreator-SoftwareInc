
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/11/2017 12:15:52
-- Generated from EDMX file: C:\Users\Savero\documents\visual studio 2017\Projects\SoftwareIncModMaker\SoftwareIncModMaker\Properties\DataSources\SoftwareTypeModel2.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ModCreator];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_SoftwareTypeModelFeatureModel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FeatureModels] DROP CONSTRAINT [FK_SoftwareTypeModelFeatureModel];
GO
IF OBJECT_ID(N'[dbo].[FK_SoftwareTypeModelCategoryModel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CategoryModels] DROP CONSTRAINT [FK_SoftwareTypeModelCategoryModel];
GO
IF OBJECT_ID(N'[dbo].[FK_FeatureModelFeatureAttributes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FeatureAttributes] DROP CONSTRAINT [FK_FeatureModelFeatureAttributes];
GO
IF OBJECT_ID(N'[dbo].[FK_FeatureModelFeatureDependency]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FeatureDependencies] DROP CONSTRAINT [FK_FeatureModelFeatureDependency];
GO
IF OBJECT_ID(N'[dbo].[FK_FeatureModelFeatureSoftwareCategory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FeatureSoftwareCategories] DROP CONSTRAINT [FK_FeatureModelFeatureSoftwareCategory];
GO
IF OBJECT_ID(N'[dbo].[FK_SoftwareTypeMAttributeSoftwareTypeModel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SoftwareTypeModels] DROP CONSTRAINT [FK_SoftwareTypeMAttributeSoftwareTypeModel];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FeatureModels]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FeatureModels];
GO
IF OBJECT_ID(N'[dbo].[CategoryModels]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CategoryModels];
GO
IF OBJECT_ID(N'[dbo].[SoftwareTypeModels]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SoftwareTypeModels];
GO
IF OBJECT_ID(N'[dbo].[FeatureAttributes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FeatureAttributes];
GO
IF OBJECT_ID(N'[dbo].[FeatureSoftwareCategories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FeatureSoftwareCategories];
GO
IF OBJECT_ID(N'[dbo].[FeatureDependencies]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FeatureDependencies];
GO
IF OBJECT_ID(N'[dbo].[SoftwareTypeMAttributes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SoftwareTypeMAttributes];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'FeatureModels'
CREATE TABLE [dbo].[FeatureModels] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SubFeatureName] nvarchar(max)  NOT NULL,
    [SubFeatureDescription] nvarchar(max)  NOT NULL,
    [SubFeatureSoftwareCategory] nvarchar(max)  NULL,
    [SubFeatureUnlock] decimal(18,0)  NULL,
    [SubFeatureUsability] decimal(18,0)  NULL,
    [SubFeatureInnovation] decimal(18,0)  NULL,
    [SubFeatureDevTime] decimal(18,0)  NULL,
    [SubFeatureCodeArt] decimal(18,0)  NULL,
    [SubFeatureDepedency] nvarchar(max)  NULL,
    [SubFeatureStability] decimal(18,0)  NULL,
    [SubFeatureServer] decimal(18,0)  NOT NULL,
    [FKSoftwareTypeModel_Id] int  NOT NULL,
    [FKFeatureAttributes_Id] int  NULL,
    [FKFeatureDependencies_Id] int  NULL,
    [FKFeatureSoftwareCategory_Id] int  NULL,
    [SoftwareTypeModel_Id] int  NOT NULL
);
GO

-- Creating table 'CategoryModels'
CREATE TABLE [dbo].[CategoryModels] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [STCategoryName] nvarchar(max)  NOT NULL,
    [STCategoryDescription] nvarchar(max)  NULL,
    [STPopularity] decimal(18,0)  NULL,
    [STUnlock] decimal(18,0)  NULL,
    [STTimeScale] decimal(18,0)  NULL,
    [STRetention] decimal(18,0)  NULL,
    [STIterative] decimal(18,0)  NULL,
    [STNameGenerator] nvarchar(max)  NULL,
    [SoftwareTypeModel_Id] int  NULL
);
GO

-- Creating table 'SoftwareTypeModels'
CREATE TABLE [dbo].[SoftwareTypeModels] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RootName] nvarchar(max)  NOT NULL,
    [RootDescription] nvarchar(max)  NOT NULL,
    [RootCategory] nvarchar(max)  NULL,
    [RootUnlock] decimal(18,0)  NULL,
    [RootOSLimit] nvarchar(max)  NULL,
    [RootOSSpecific] bit  NULL,
    [RootPopularity] decimal(18,0)  NULL,
    [RootRandom] decimal(18,0)  NULL,
    [RootRetention] decimal(18,0)  NULL,
    [RootOneClient] bit  NULL,
    [RootInHouse] bit  NULL,
    [RootIterative] decimal(18,0)  NULL,
    [RootNameGenerator] nvarchar(max)  NULL,
    [SoftwareTypeMAttribute_Id] int  NULL
);
GO

-- Creating table 'FeatureAttributes'
CREATE TABLE [dbo].[FeatureAttributes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AttributeFrom] nvarchar(max)  NULL,
    [AttributeForced] bit  NULL,
    [AttributeResearch] bit  NULL,
    [AttributeVital] bit  NULL,
    [FKFeatureModel_Id] int  NOT NULL,
    [FKFeatureName] nvarchar(max)  NOT NULL,
    [FeatureModel_Id] int  NOT NULL
);
GO

-- Creating table 'FeatureSoftwareCategories'
CREATE TABLE [dbo].[FeatureSoftwareCategories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FCName] nvarchar(max)  NOT NULL,
    [FCDescription] nvarchar(max)  NULL,
    [FCPopularity] decimal(18,0)  NULL,
    [FCTimeScale] decimal(18,0)  NULL,
    [FCRetention] decimal(18,0)  NULL,
    [FCIterative] decimal(18,0)  NULL,
    [FCNameGenerator] nvarchar(max)  NULL,
    [FCUnlock] decimal(18,0)  NULL,
    [FeatureModel_Id] int  NOT NULL
);
GO

-- Creating table 'FeatureDependencies'
CREATE TABLE [dbo].[FeatureDependencies] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DependencySoftware] nvarchar(max)  NULL,
    [DependencyFeature] nvarchar(max)  NULL,
    [FeatureModel_Id] int  NOT NULL
);
GO

-- Creating table 'SoftwareTypeMAttributes'
CREATE TABLE [dbo].[SoftwareTypeMAttributes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Override] bit  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'FeatureModels'
ALTER TABLE [dbo].[FeatureModels]
ADD CONSTRAINT [PK_FeatureModels]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CategoryModels'
ALTER TABLE [dbo].[CategoryModels]
ADD CONSTRAINT [PK_CategoryModels]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SoftwareTypeModels'
ALTER TABLE [dbo].[SoftwareTypeModels]
ADD CONSTRAINT [PK_SoftwareTypeModels]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FeatureAttributes'
ALTER TABLE [dbo].[FeatureAttributes]
ADD CONSTRAINT [PK_FeatureAttributes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FeatureSoftwareCategories'
ALTER TABLE [dbo].[FeatureSoftwareCategories]
ADD CONSTRAINT [PK_FeatureSoftwareCategories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FeatureDependencies'
ALTER TABLE [dbo].[FeatureDependencies]
ADD CONSTRAINT [PK_FeatureDependencies]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SoftwareTypeMAttributes'
ALTER TABLE [dbo].[SoftwareTypeMAttributes]
ADD CONSTRAINT [PK_SoftwareTypeMAttributes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [SoftwareTypeModel_Id] in table 'FeatureModels'
ALTER TABLE [dbo].[FeatureModels]
ADD CONSTRAINT [FK_SoftwareTypeModelFeatureModel]
    FOREIGN KEY ([SoftwareTypeModel_Id])
    REFERENCES [dbo].[SoftwareTypeModels]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SoftwareTypeModelFeatureModel'
CREATE INDEX [IX_FK_SoftwareTypeModelFeatureModel]
ON [dbo].[FeatureModels]
    ([SoftwareTypeModel_Id]);
GO

-- Creating foreign key on [SoftwareTypeModel_Id] in table 'CategoryModels'
ALTER TABLE [dbo].[CategoryModels]
ADD CONSTRAINT [FK_SoftwareTypeModelCategoryModel]
    FOREIGN KEY ([SoftwareTypeModel_Id])
    REFERENCES [dbo].[SoftwareTypeModels]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SoftwareTypeModelCategoryModel'
CREATE INDEX [IX_FK_SoftwareTypeModelCategoryModel]
ON [dbo].[CategoryModels]
    ([SoftwareTypeModel_Id]);
GO

-- Creating foreign key on [FeatureModel_Id] in table 'FeatureAttributes'
ALTER TABLE [dbo].[FeatureAttributes]
ADD CONSTRAINT [FK_FeatureModelFeatureAttributes]
    FOREIGN KEY ([FeatureModel_Id])
    REFERENCES [dbo].[FeatureModels]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FeatureModelFeatureAttributes'
CREATE INDEX [IX_FK_FeatureModelFeatureAttributes]
ON [dbo].[FeatureAttributes]
    ([FeatureModel_Id]);
GO

-- Creating foreign key on [FeatureModel_Id] in table 'FeatureDependencies'
ALTER TABLE [dbo].[FeatureDependencies]
ADD CONSTRAINT [FK_FeatureModelFeatureDependency]
    FOREIGN KEY ([FeatureModel_Id])
    REFERENCES [dbo].[FeatureModels]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FeatureModelFeatureDependency'
CREATE INDEX [IX_FK_FeatureModelFeatureDependency]
ON [dbo].[FeatureDependencies]
    ([FeatureModel_Id]);
GO

-- Creating foreign key on [FeatureModel_Id] in table 'FeatureSoftwareCategories'
ALTER TABLE [dbo].[FeatureSoftwareCategories]
ADD CONSTRAINT [FK_FeatureModelFeatureSoftwareCategory]
    FOREIGN KEY ([FeatureModel_Id])
    REFERENCES [dbo].[FeatureModels]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FeatureModelFeatureSoftwareCategory'
CREATE INDEX [IX_FK_FeatureModelFeatureSoftwareCategory]
ON [dbo].[FeatureSoftwareCategories]
    ([FeatureModel_Id]);
GO

-- Creating foreign key on [SoftwareTypeMAttribute_Id] in table 'SoftwareTypeModels'
ALTER TABLE [dbo].[SoftwareTypeModels]
ADD CONSTRAINT [FK_SoftwareTypeMAttributeSoftwareTypeModel]
    FOREIGN KEY ([SoftwareTypeMAttribute_Id])
    REFERENCES [dbo].[SoftwareTypeMAttributes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SoftwareTypeMAttributeSoftwareTypeModel'
CREATE INDEX [IX_FK_SoftwareTypeMAttributeSoftwareTypeModel]
ON [dbo].[SoftwareTypeModels]
    ([SoftwareTypeMAttribute_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------