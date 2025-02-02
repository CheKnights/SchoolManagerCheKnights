USE [master]
GO

/****** Object:  Database [SchoolManager]    Script Date: 09/10/2020 10:35:53 ******/
CREATE DATABASE [SchoolManager]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SchoolManager', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\SchoolManager.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SchoolManager_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\SchoolManager_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [SchoolManager] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SchoolManager].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [SchoolManager] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [SchoolManager] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [SchoolManager] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [SchoolManager] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [SchoolManager] SET ARITHABORT OFF 
GO

ALTER DATABASE [SchoolManager] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [SchoolManager] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [SchoolManager] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [SchoolManager] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [SchoolManager] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [SchoolManager] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [SchoolManager] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [SchoolManager] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [SchoolManager] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [SchoolManager] SET  ENABLE_BROKER 
GO

ALTER DATABASE [SchoolManager] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [SchoolManager] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [SchoolManager] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [SchoolManager] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [SchoolManager] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [SchoolManager] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [SchoolManager] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [SchoolManager] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [SchoolManager] SET  MULTI_USER 
GO

ALTER DATABASE [SchoolManager] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [SchoolManager] SET DB_CHAINING OFF 
GO

ALTER DATABASE [SchoolManager] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [SchoolManager] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [SchoolManager] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [SchoolManager] SET  READ_WRITE 
GO
