USE [MuseuDaUFPA]
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Users_IsActive]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Users] DROP CONSTRAINT [DF_Users_IsActive]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Users_IsAdmin]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Users] DROP CONSTRAINT [DF_Users_IsAdmin]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Users_SignupDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Users] DROP CONSTRAINT [DF_Users_SignupDate]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Painting_IsMarked]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Painting] DROP CONSTRAINT [DF_Painting_IsMarked]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Painting_IsSignatureAvailable]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Painting] DROP CONSTRAINT [DF_Painting_IsSignatureAvailable]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Painting_IsRestored]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Painting] DROP CONSTRAINT [DF_Painting_IsRestored]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Painting_IsPhotoAvailable]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Painting] DROP CONSTRAINT [DF_Painting_IsPhotoAvailable]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Painting_IsAssigned]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Painting] DROP CONSTRAINT [DF_Painting_IsAssigned]
END

GO
/****** Object:  Table [dbo].[Users]    Script Date: 9/17/2019 12:32:47 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Users]') AND type in (N'U'))
DROP TABLE [dbo].[Users]
GO
/****** Object:  Table [dbo].[PaintingCategory]    Script Date: 9/17/2019 12:32:47 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PaintingCategory]') AND type in (N'U'))
DROP TABLE [dbo].[PaintingCategory]
GO
/****** Object:  Table [dbo].[Painting]    Script Date: 9/17/2019 12:32:47 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Painting]') AND type in (N'U'))
DROP TABLE [dbo].[Painting]
GO
/****** Object:  Table [dbo].[AuthorPaintingCategory]    Script Date: 9/17/2019 12:32:47 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AuthorPaintingCategory]') AND type in (N'U'))
DROP TABLE [dbo].[AuthorPaintingCategory]
GO
/****** Object:  Table [dbo].[AuthorPainting]    Script Date: 9/17/2019 12:32:47 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AuthorPainting]') AND type in (N'U'))
DROP TABLE [dbo].[AuthorPainting]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 9/17/2019 12:32:47 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Author]') AND type in (N'U'))
DROP TABLE [dbo].[Author]
GO
USE [master]
GO
/****** Object:  Database [MuseuDaUFPA]    Script Date: 9/17/2019 12:32:47 AM ******/
IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'MuseuDaUFPA')
DROP DATABASE [MuseuDaUFPA]
GO
/****** Object:  Database [MuseuDaUFPA]    Script Date: 9/17/2019 12:32:47 AM ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'MuseuDaUFPA')
BEGIN
CREATE DATABASE [MuseuDaUFPA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MuseuDaUFPA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\MuseuDaUFPA.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MuseuDaUFPA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\MuseuDaUFPA_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
END

GO
ALTER DATABASE [MuseuDaUFPA] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MuseuDaUFPA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MuseuDaUFPA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MuseuDaUFPA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MuseuDaUFPA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MuseuDaUFPA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MuseuDaUFPA] SET ARITHABORT OFF 
GO
ALTER DATABASE [MuseuDaUFPA] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MuseuDaUFPA] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [MuseuDaUFPA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MuseuDaUFPA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MuseuDaUFPA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MuseuDaUFPA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MuseuDaUFPA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MuseuDaUFPA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MuseuDaUFPA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MuseuDaUFPA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MuseuDaUFPA] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MuseuDaUFPA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MuseuDaUFPA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MuseuDaUFPA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MuseuDaUFPA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MuseuDaUFPA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MuseuDaUFPA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MuseuDaUFPA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MuseuDaUFPA] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MuseuDaUFPA] SET  MULTI_USER 
GO
ALTER DATABASE [MuseuDaUFPA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MuseuDaUFPA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MuseuDaUFPA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MuseuDaUFPA] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [MuseuDaUFPA]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 9/17/2019 12:32:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Author]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Author](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[DOB] [nvarchar](50) NOT NULL,
	[PlaceOfBirth] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](200) NOT NULL,
	[Biography] [nvarchar](max) NOT NULL,
	[SignImage] [image] NULL,
	[ProfileImage] [image] NULL,
 CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[AuthorPainting]    Script Date: 9/17/2019 12:32:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AuthorPainting]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[AuthorPainting](
	[PaintingID] [int] NOT NULL,
	[AuthorID] [int] NOT NULL
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[AuthorPaintingCategory]    Script Date: 9/17/2019 12:32:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AuthorPaintingCategory]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[AuthorPaintingCategory](
	[PaintingCategoryID] [int] NOT NULL,
	[AuthorID] [int] NOT NULL
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Painting]    Script Date: 9/17/2019 12:32:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Painting]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Painting](
	[PaintingID] [int] NOT NULL,
	[RegistrationNumber] [nvarchar](50) NOT NULL,
	[InventoryNumber] [nvarchar](50) NOT NULL,
	[Collection] [nvarchar](1000) NULL,
	[IsAssignedToAuthor] [bit] NOT NULL,
	[AuthorPaintingID] [int] NOT NULL,
	[Title] [nvarchar](100) NULL,
	[WorkCondition] [nvarchar](50) NULL,
	[WorkConditionDescription] [nvarchar](max) NULL,
	[IsPhotoAvailable] [bit] NOT NULL,
	[FrontPhotoPath] [nvarchar](500) NULL,
	[BackPhotoPath] [nvarchar](500) NULL,
	[IsRestored] [bit] NOT NULL,
	[BeforeRestorationImagePath] [nvarchar](500) NULL,
	[AfterRestorationImagePath] [nvarchar](500) NULL,
	[LastRestorationDate] [datetime] NULL,
	[IsInTheStore] [bit] NULL,
	[DrawerNumber] [nvarchar](50) NULL,
	[CurrentLocation] [nvarchar](500) NULL,
	[LocalLocation] [nvarchar](500) NULL,
	[TagTitle] [nvarchar](50) NULL,
	[Tag] [nvarchar](50) NULL,
	[TagDescription] [nvarchar](500) NULL,
	[Object] [nvarchar](1000) NULL,
	[Copy] [nvarchar](500) NULL,
	[Technique] [nvarchar](50) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[CultureGroup] [nvarchar](50) NULL,
	[DatePosition] [nvarchar](50) NULL,
	[Style] [nvarchar](50) NULL,
	[Movement] [nvarchar](50) NULL,
	[Period] [nvarchar](50) NULL,
	[IsSignatureAvailable] [bit] NOT NULL,
	[SignaturePosition] [nvarchar](50) NULL,
	[SignaturePath] [nvarchar](max) NULL,
	[SinatureDescription] [nvarchar](500) NULL,
	[IsMarked] [bit] NOT NULL,
	[MarkedPosition] [nvarchar](50) NULL,
	[MarkedPath] [nvarchar](500) NULL,
	[ProcessNumber] [nvarchar](50) NULL,
	[WayOfAcquisition] [nvarchar](50) NULL,
	[DateOfAcquisition] [datetime] NULL,
	[PurchasePrice] [nvarchar](50) NULL,
	[InsuranceValue] [nvarchar](50) NULL,
	[Publisher] [nvarchar](100) NULL,
	[Edition] [nvarchar](50) NULL,
	[EditionNumber] [nvarchar](50) NULL,
	[TypeOfAge] [nvarchar](50) NULL,
	[Category] [nvarchar](50) NULL,
	[ProviderName] [nvarchar](50) NULL,
	[FrameHeight] [nvarchar](50) NULL,
	[FrameWidth] [nvarchar](50) NULL,
	[FrameDepth] [nvarchar](50) NULL,
	[FrameWeight] [nvarchar](50) NULL,
	[FrameShape] [nvarchar](50) NULL,
	[PrintedAreaHeight] [nvarchar](50) NULL,
	[PrintedAreaWidth] [nvarchar](50) NULL,
	[PrintedAreaDepth] [nvarchar](50) NULL,
	[PrintedAreaWeight] [nvarchar](50) NULL,
	[PrintedAreaShape] [nvarchar](50) NULL,
	[FormalDescription] [nvarchar](max) NULL,
	[ContentDescription] [nvarchar](max) NULL,
	[KeywordsDescription] [nvarchar](max) NULL,
	[ExOwner] [nvarchar](50) NULL,
	[Exhibition] [nvarchar](max) NULL,
	[Reference] [nvarchar](500) NULL,
	[Notes] [nvarchar](500) NULL,
	[PaintingViewCount] [int] NULL,
 CONSTRAINT [PK_Painting] PRIMARY KEY CLUSTERED 
(
	[PaintingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[PaintingCategory]    Script Date: 9/17/2019 12:32:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PaintingCategory]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PaintingCategory](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PaintingCategory] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Users]    Script Date: 9/17/2019 12:32:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Users]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[SignupDate] [datetime] NOT NULL,
	[IsAdmin] [bit] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Painting_IsAssigned]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Painting] ADD  CONSTRAINT [DF_Painting_IsAssigned]  DEFAULT ((0)) FOR [IsAssignedToAuthor]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Painting_IsPhotoAvailable]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Painting] ADD  CONSTRAINT [DF_Painting_IsPhotoAvailable]  DEFAULT ((0)) FOR [IsPhotoAvailable]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Painting_IsRestored]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Painting] ADD  CONSTRAINT [DF_Painting_IsRestored]  DEFAULT ((0)) FOR [IsRestored]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Painting_IsSignatureAvailable]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Painting] ADD  CONSTRAINT [DF_Painting_IsSignatureAvailable]  DEFAULT ((0)) FOR [IsSignatureAvailable]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Painting_IsMarked]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Painting] ADD  CONSTRAINT [DF_Painting_IsMarked]  DEFAULT ((0)) FOR [IsMarked]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Users_SignupDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_SignupDate]  DEFAULT (getdate()) FOR [SignupDate]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Users_IsAdmin]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_IsAdmin]  DEFAULT ((0)) FOR [IsAdmin]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Users_IsActive]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_IsActive]  DEFAULT ((1)) FOR [IsActive]
END

GO
USE [master]
GO
ALTER DATABASE [MuseuDaUFPA] SET  READ_WRITE 
GO
