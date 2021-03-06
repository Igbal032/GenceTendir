USE [master]
GO
/****** Object:  Database [GanjaBreadCompany]    Script Date: 10/4/2019 11:09:03 PM ******/
CREATE DATABASE [GanjaBreadCompany]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GanjaBreadCompany', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\GanjaBreadCompany.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GanjaBreadCompany_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\GanjaBreadCompany_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [GanjaBreadCompany] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GanjaBreadCompany].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GanjaBreadCompany] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GanjaBreadCompany] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GanjaBreadCompany] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GanjaBreadCompany] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GanjaBreadCompany] SET ARITHABORT OFF 
GO
ALTER DATABASE [GanjaBreadCompany] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GanjaBreadCompany] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GanjaBreadCompany] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GanjaBreadCompany] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GanjaBreadCompany] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GanjaBreadCompany] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GanjaBreadCompany] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GanjaBreadCompany] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GanjaBreadCompany] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GanjaBreadCompany] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GanjaBreadCompany] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GanjaBreadCompany] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GanjaBreadCompany] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GanjaBreadCompany] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GanjaBreadCompany] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GanjaBreadCompany] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GanjaBreadCompany] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GanjaBreadCompany] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GanjaBreadCompany] SET  MULTI_USER 
GO
ALTER DATABASE [GanjaBreadCompany] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GanjaBreadCompany] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GanjaBreadCompany] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GanjaBreadCompany] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GanjaBreadCompany] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GanjaBreadCompany] SET QUERY_STORE = OFF
GO
USE [GanjaBreadCompany]
GO
/****** Object:  Table [dbo].[CountForDays]    Script Date: 10/4/2019 11:09:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CountForDays](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SubsidiaryId] [int] NOT NULL,
	[MonthId] [int] NOT NULL,
	[Year] [int] NULL,
	[MarketName] [nvarchar](50) NULL,
	[Day1] [int] NULL,
	[Day2] [int] NULL,
	[Day3] [int] NULL,
	[Day4] [int] NULL,
	[Day5] [int] NULL,
	[Day6] [int] NULL,
	[Day7] [int] NULL,
	[Day8] [int] NULL,
	[Day9] [int] NULL,
	[Day10] [int] NULL,
	[Day11] [int] NULL,
	[Day12] [int] NULL,
	[Day13] [int] NULL,
	[Day14] [int] NULL,
	[Day15] [int] NULL,
	[Day16] [int] NULL,
	[Day17] [int] NULL,
	[Day18] [int] NULL,
	[Day19] [int] NULL,
	[Day20] [int] NULL,
	[Day21] [int] NULL,
	[Day22] [int] NULL,
	[Day23] [int] NULL,
	[Day24] [int] NULL,
	[Day25] [int] NULL,
	[Day26] [int] NULL,
	[Day27] [int] NULL,
	[Day28] [int] NULL,
	[Day29] [int] NULL,
	[Day30] [int] NULL,
	[Day31] [int] NULL,
	[PriceOfOne] [float] NULL,
	[TotalCount] [int] NULL,
	[TotalPrice] [money] NULL,
	[CreatedDate] [datetime] NULL,
	[DeletedDate] [datetime] NULL,
	[SumInOneMonth] [money] NULL,
 CONSTRAINT [PK_Days] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MarketList]    Script Date: 10/4/2019 11:09:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MarketList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MarketName] [nvarchar](50) NOT NULL,
	[UserId] [int] NOT NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedDate] [datetime] NULL,
	[DeletedDate] [datetime] NULL,
 CONSTRAINT [PK_MarketList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Months]    Script Date: 10/4/2019 11:09:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Months](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MonthName] [nvarchar](50) NOT NULL,
	[MonthNumber] [int] NOT NULL,
 CONSTRAINT [PK_Months] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subsidiary]    Script Date: 10/4/2019 11:09:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subsidiary](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Subsidiary] [nvarchar](50) NOT NULL,
	[MarketId] [int] NOT NULL,
	[CreatedDate] [datetime] NULL,
	[DeletedDate] [datetime] NULL,
 CONSTRAINT [PK_Subsidiary] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 10/4/2019 11:09:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[UserSurname] [nvarchar](50) NOT NULL,
	[UserEmail] [varchar](50) NOT NULL,
	[UserPassword] [nvarchar](50) NOT NULL,
	[CreatedDate] [datetime] NULL,
	[Modifieddate] [datetime] NULL,
	[DeletedDate] [datetime] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CountForDays]  WITH CHECK ADD  CONSTRAINT [FK_CountForDays_Months] FOREIGN KEY([MonthId])
REFERENCES [dbo].[Months] ([Id])
GO
ALTER TABLE [dbo].[CountForDays] CHECK CONSTRAINT [FK_CountForDays_Months]
GO
ALTER TABLE [dbo].[CountForDays]  WITH CHECK ADD  CONSTRAINT [FK_CountForDays_Subsidiary] FOREIGN KEY([SubsidiaryId])
REFERENCES [dbo].[Subsidiary] ([Id])
GO
ALTER TABLE [dbo].[CountForDays] CHECK CONSTRAINT [FK_CountForDays_Subsidiary]
GO
ALTER TABLE [dbo].[MarketList]  WITH CHECK ADD  CONSTRAINT [FK_MarketList_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[MarketList] CHECK CONSTRAINT [FK_MarketList_Users]
GO
ALTER TABLE [dbo].[Subsidiary]  WITH CHECK ADD  CONSTRAINT [FK_Subsidiary_MarketList] FOREIGN KEY([MarketId])
REFERENCES [dbo].[MarketList] ([Id])
GO
ALTER TABLE [dbo].[Subsidiary] CHECK CONSTRAINT [FK_Subsidiary_MarketList]
GO
USE [master]
GO
ALTER DATABASE [GanjaBreadCompany] SET  READ_WRITE 
GO
