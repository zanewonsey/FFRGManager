USE [master]
GO
/****** Object:  Database [FFRGBPOMGR]    Script Date: 12/15/2020 9:13:36 PM ******/
CREATE DATABASE [FFRGBPOMGR]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FFRGBPOMGR', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\FFRGBPOMGR.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FFRGBPOMGR_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\FFRGBPOMGR_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [FFRGBPOMGR] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FFRGBPOMGR].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FFRGBPOMGR] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FFRGBPOMGR] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FFRGBPOMGR] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FFRGBPOMGR] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FFRGBPOMGR] SET ARITHABORT OFF 
GO
ALTER DATABASE [FFRGBPOMGR] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FFRGBPOMGR] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FFRGBPOMGR] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FFRGBPOMGR] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FFRGBPOMGR] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FFRGBPOMGR] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FFRGBPOMGR] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FFRGBPOMGR] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FFRGBPOMGR] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FFRGBPOMGR] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FFRGBPOMGR] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FFRGBPOMGR] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FFRGBPOMGR] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FFRGBPOMGR] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FFRGBPOMGR] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FFRGBPOMGR] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FFRGBPOMGR] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FFRGBPOMGR] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FFRGBPOMGR] SET  MULTI_USER 
GO
ALTER DATABASE [FFRGBPOMGR] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FFRGBPOMGR] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FFRGBPOMGR] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FFRGBPOMGR] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FFRGBPOMGR] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FFRGBPOMGR] SET QUERY_STORE = OFF
GO
USE [FFRGBPOMGR]
GO
/****** Object:  User [zanewonsey]    Script Date: 12/15/2020 9:13:36 PM ******/
CREATE USER [zanewonsey] FOR LOGIN [zanewonsey] WITH DEFAULT_SCHEMA=[db_owner]
GO
/****** Object:  User [csharptesting]    Script Date: 12/15/2020 9:13:36 PM ******/
CREATE USER [csharptesting] FOR LOGIN [csharptesting] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [zanewonsey]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [zanewonsey]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [zanewonsey]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [zanewonsey]
GO
ALTER ROLE [db_datareader] ADD MEMBER [zanewonsey]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [zanewonsey]
GO
/****** Object:  Table [dbo].[Addresses]    Script Date: 12/15/2020 9:13:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Addresses](
	[Address_ID] [int] IDENTITY(1,1) NOT NULL,
	[Street] [varchar](40) NOT NULL,
	[City] [varchar](20) NOT NULL,
	[State] [varchar](15) NOT NULL,
	[ZipCode] [varchar](10) NOT NULL,
	[MapCoordinates_ID] [int] NOT NULL,
	[Year_Built] [varchar](4) NULL,
PRIMARY KEY CLUSTERED 
(
	[Address_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MapCoordinates]    Script Date: 12/15/2020 9:13:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MapCoordinates](
	[MapCoordinates_ID] [int] IDENTITY(1,1) NOT NULL,
	[Latitude] [float] NOT NULL,
	[Longitude] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MapCoordinates_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 12/15/2020 9:13:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Order_ID] [int] IDENTITY(1,1) NOT NULL,
	[Address_ID] [int] NOT NULL,
	[SourceCompany_ID] [int] NOT NULL,
	[PicStatus] [int] NOT NULL,
	[Due_Date] [datetime] NOT NULL,
	[DataSource] [varchar](20) NULL,
	[Room_Count] [varchar](8) NULL,
	[GLA] [varchar](20) NULL,
	[Foundation] [varchar](10) NULL,
	[Style] [varchar](20) NULL,
	[Lot_Size] [varchar](20) NULL,
	[Garage] [varchar](10) NULL,
	[Area_Values] [varchar](15) NULL,
	[Listings] [varchar](2) NULL,
	[Sales] [varchar](2) NULL,
	[Rent] [varchar](4) NULL,
	[Land] [varchar](10) NULL,
	[Out_Range] [varchar](10) NULL,
	[Back_Range] [varchar](10) NULL,
	[L] [varchar](10) NULL,
	[S] [varchar](10) NULL,
	[Q] [varchar](10) NULL,
	[Notes] [varchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[Order_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RouteTable]    Script Date: 12/15/2020 9:13:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RouteTable](
	[RouteTable_ID] [int] IDENTITY(1,1) NOT NULL,
	[Assinee_Name] [varchar](20) NOT NULL,
	[Date_To_Be_Ran] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RouteTable_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SourceCompany]    Script Date: 12/15/2020 9:13:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SourceCompany](
	[SourceCompany_ID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[SourceCompany_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StopTable]    Script Date: 12/15/2020 9:13:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StopTable](
	[StopTable_ID] [int] IDENTITY(1,1) NOT NULL,
	[Order_ID] [int] NOT NULL,
	[RouteTable_ID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[StopTable_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[template]    Script Date: 12/15/2020 9:13:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[template](
	[template_ID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[template_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Addresses]  WITH CHECK ADD FOREIGN KEY([MapCoordinates_ID])
REFERENCES [dbo].[MapCoordinates] ([MapCoordinates_ID])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([Address_ID])
REFERENCES [dbo].[Addresses] ([Address_ID])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([SourceCompany_ID])
REFERENCES [dbo].[SourceCompany] ([SourceCompany_ID])
GO
ALTER TABLE [dbo].[StopTable]  WITH CHECK ADD FOREIGN KEY([Order_ID])
REFERENCES [dbo].[Orders] ([Order_ID])
GO
ALTER TABLE [dbo].[StopTable]  WITH CHECK ADD FOREIGN KEY([RouteTable_ID])
REFERENCES [dbo].[RouteTable] ([RouteTable_ID])
GO
USE [master]
GO
ALTER DATABASE [FFRGBPOMGR] SET  READ_WRITE 
GO
USE [FFRGBPOMGR]
GO
INSERT INTO [dbo].[MapCoordinates] (Latitude, Longitude) VALUES(0, 0);
GO
INSERT INTO [dbo].[SourceCompany] (CompanyName)
VALUES
	('Single Source'),
	('Clear Capital'),
	('eMortgage');
GO