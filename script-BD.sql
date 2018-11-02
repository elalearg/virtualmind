USE [master]
GO

/****** Object:  Database [Encuesta]    Script Date: 28/10/2018 09:04:10 p.m. ******/
CREATE DATABASE [Encuesta]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Encuesta', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Encuesta.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Encuesta_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Encuesta_log.ldf' , SIZE = 5696KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [Encuesta] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Encuesta].[dbo].[sp_fulltext_database] @action = 'disable'
end
GO

ALTER DATABASE [Encuesta] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Encuesta] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Encuesta] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Encuesta] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Encuesta] SET ARITHABORT OFF 
GO

ALTER DATABASE [Encuesta] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Encuesta] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Encuesta] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Encuesta] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Encuesta] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Encuesta] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Encuesta] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Encuesta] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Encuesta] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Encuesta] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Encuesta] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Encuesta] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Encuesta] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Encuesta] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Encuesta] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Encuesta] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Encuesta] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Encuesta] SET RECOVERY FULL 
GO

ALTER DATABASE [Encuesta] SET  MULTI_USER 
GO

ALTER DATABASE [Encuesta] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Encuesta] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Encuesta] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Encuesta] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [Encuesta] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Encuesta] SET  READ_WRITE 
GO

USE [Encuesta]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 28/10/2018 09:03:40 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[idUser] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](100) NOT NULL,
	[Password] [varchar](100) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Apellido] [varchar](100) NOT NULL,
	[Email] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [Encuesta]
GO

INSERT INTO [dbo].[Users]
           ([Usuario],[Password],[Nombre],[Apellido],[Email])
     VALUES
           ('test1','Pass1','Test','Apellido','mail@mail.com')
GO

INSERT INTO [dbo].[Users]
           ([Usuario],[Password],[Nombre],[Apellido],[Email])
     VALUES
           ('test2','Pass2','Test','Apellido','mail@mail.com')
GO
INSERT INTO [dbo].[Users]
           ([Usuario],[Password],[Nombre],[Apellido],[Email])
     VALUES
           ('test3','Pass3','Test','Apellido','mail@mail.com')
GO


