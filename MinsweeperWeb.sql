USE [master]
GO
/****** Object:  Database [MinesweeperWeb]    Script Date: 2/10/2021 3:41:17 PM ******/
CREATE DATABASE [MinesweeperWeb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MinesweeperWeb', FILENAME = N'C:\Users\anaod\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\MinesweeperWeb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MinesweeperWeb_log', FILENAME = N'C:\Users\anaod\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\MinesweeperWeb.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [MinesweeperWeb] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MinesweeperWeb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MinesweeperWeb] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [MinesweeperWeb] SET ANSI_NULLS ON 
GO
ALTER DATABASE [MinesweeperWeb] SET ANSI_PADDING ON 
GO
ALTER DATABASE [MinesweeperWeb] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [MinesweeperWeb] SET ARITHABORT ON 
GO
ALTER DATABASE [MinesweeperWeb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MinesweeperWeb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MinesweeperWeb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MinesweeperWeb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MinesweeperWeb] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [MinesweeperWeb] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [MinesweeperWeb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MinesweeperWeb] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [MinesweeperWeb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MinesweeperWeb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MinesweeperWeb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MinesweeperWeb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MinesweeperWeb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MinesweeperWeb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MinesweeperWeb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MinesweeperWeb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MinesweeperWeb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MinesweeperWeb] SET RECOVERY FULL 
GO
ALTER DATABASE [MinesweeperWeb] SET  MULTI_USER 
GO
ALTER DATABASE [MinesweeperWeb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MinesweeperWeb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MinesweeperWeb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MinesweeperWeb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MinesweeperWeb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MinesweeperWeb] SET QUERY_STORE = OFF
GO
USE [MinesweeperWeb]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [MinesweeperWeb]
GO
/****** Object:  Table [dbo].[tbl_User]    Script Date: 2/10/2021 3:41:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_User](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Gender] [nvarchar](50) NOT NULL,
	[Age] [nvarchar](50) NOT NULL,
	[EmailAddress] [nvarchar](50) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[State] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[usp_GrabUserByID]    Script Date: 2/10/2021 3:41:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GrabUserByID]
	@UserID int = 0
AS
BEGIN
	SELECT * 
	FROM tbl_User
	WHERE UserID = @UserID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_InsertUser]    Script Date: 2/10/2021 3:41:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_InsertUser]
	@FirstName nvarchar(50) = '',
	@LastName nvarchar(50) = '',
	@Gender nvarchar(50) = '',
	@Age nvarchar(50) = '',
	@Email nvarchar(50) = '',
	@Username nvarchar(50) = '',
	@Password nvarchar(50) = '',
	@State nvarchar(50) = '' 
AS
BEGIN
INSERT INTO tbl_User (FirstName, LastName, Gender, Age,
	EmailAddress, Username, Password, State) VALUES(@FirstName, @LastName, @Gender, @Age, @Email, @Username, @Password, @State)
END
GO
/****** Object:  StoredProcedure [dbo].[usp_LoginUser]    Script Date: 2/10/2021 3:41:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_LoginUser]
	@Username nvarchar(50) = '',
	@Password nvarchar(50) = ''
AS
BEGIN
	SELECT * 
	FROM tbl_User
	WHERE Username = @Username
	AND Password = @Password
END
GO
USE [master]
GO
ALTER DATABASE [MinesweeperWeb] SET  READ_WRITE 
GO
