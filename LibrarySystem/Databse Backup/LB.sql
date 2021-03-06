USE [master]
GO
/****** Object:  Database [LibrarySystem]    Script Date: 2/14/2021 4:13:31 PM ******/
CREATE DATABASE [LibrarySystem] ON  PRIMARY 
( NAME = N'Library_Management', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVERR\MSSQL\DATA\Library_Management.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Library_Management_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVERR\MSSQL\DATA\Library_Management_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [LibrarySystem] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LibrarySystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LibrarySystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LibrarySystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LibrarySystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LibrarySystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LibrarySystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [LibrarySystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LibrarySystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LibrarySystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LibrarySystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LibrarySystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LibrarySystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LibrarySystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LibrarySystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LibrarySystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LibrarySystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LibrarySystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LibrarySystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LibrarySystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LibrarySystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LibrarySystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LibrarySystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LibrarySystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LibrarySystem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LibrarySystem] SET  MULTI_USER 
GO
ALTER DATABASE [LibrarySystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LibrarySystem] SET DB_CHAINING OFF 
GO
USE [LibrarySystem]
GO
/****** Object:  User [VERBAT\V10083]    Script Date: 2/14/2021 4:13:31 PM ******/
CREATE USER [VERBAT\V10083] FOR LOGIN [VERBAT\V10083] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [NT SERVICE\MSSQL$MSSQLSERVERR]    Script Date: 2/14/2021 4:13:31 PM ******/
CREATE USER [NT SERVICE\MSSQL$MSSQLSERVERR] FOR LOGIN [NT SERVICE\MSSQL$MSSQLSERVERR]
GO
/****** Object:  User [NT AUTHORITY\SYSTEM]    Script Date: 2/14/2021 4:13:31 PM ******/
CREATE USER [NT AUTHORITY\SYSTEM] FOR LOGIN [NT AUTHORITY\SYSTEM] WITH DEFAULT_SCHEMA=[dbo]
GO
sys.sp_addrolemember @rolename = N'db_owner', @membername = N'VERBAT\V10083'
GO
sys.sp_addrolemember @rolename = N'db_owner', @membername = N'NT SERVICE\MSSQL$MSSQLSERVERR'
GO
/****** Object:  Table [dbo].[AdminMst]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminMst](
	[AID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[EntryDate] [datetime] NULL,
 CONSTRAINT [PK_AdminMst] PRIMARY KEY CLUSTERED 
(
	[AID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookMst]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookMst](
	[BookID] [int] IDENTITY(1,1) NOT NULL,
	[BookName] [nvarchar](50) NULL,
	[Author] [nvarchar](50) NULL,
	[Detail] [nvarchar](50) NULL,
	[Price] [float] NULL,
	[Publication] [nvarchar](50) NULL,
	[Branch] [nvarchar](50) NULL,
	[Quantities] [int] NULL,
	[AvailableQnt] [int] NULL,
	[RentQnt] [int] NULL,
	[Image] [nvarchar](1000) NULL,
	[EntryDate] [datetime] NULL,
 CONSTRAINT [PK_BookMst] PRIMARY KEY CLUSTERED 
(
	[BookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BranchMst]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BranchMst](
	[BranchID] [int] IDENTITY(1,1) NOT NULL,
	[BranchName] [nvarchar](50) NULL,
 CONSTRAINT [PK_BranchMst] PRIMARY KEY CLUSTERED 
(
	[BranchID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PenaltyMst]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PenaltyMst](
	[PID] [int] NOT NULL,
	[SID] [int] NULL,
	[BookName] [nvarchar](50) NULL,
	[Price] [float] NULL,
	[Panalty] [float] NULL,
	[Detail] [nvarchar](500) NULL,
	[EntryDate] [datetime] NULL,
 CONSTRAINT [PK_PenaltyMst] PRIMARY KEY CLUSTERED 
(
	[PID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PublicationMst]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PublicationMst](
	[PID] [int] IDENTITY(1,1) NOT NULL,
	[Publication] [nvarchar](100) NULL,
	[EntryDate] [datetime] NULL,
 CONSTRAINT [PK_PublicationMst] PRIMARY KEY CLUSTERED 
(
	[PID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentMst]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentMst](
	[RID] [int] IDENTITY(1,1) NOT NULL,
	[BookName] [nvarchar](50) NULL,
	[SID] [int] NULL,
	[Days] [int] NULL,
	[IssueDate] [datetime] NULL,
	[ReturnDate] [datetime] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_RentMst] PRIMARY KEY CLUSTERED 
(
	[RID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentMst]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentMst](
	[SID] [int] IDENTITY(1,1) NOT NULL,
	[StudentName] [nvarchar](50) NULL,
	[BranchName] [nvarchar](50) NULL,
	[Mobile] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[Pincode] [nvarchar](50) NULL,
	[DOB] [datetime] NULL,
	[Gender] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Image] [nvarchar](500) NULL,
	[EntryDate] [datetime] NULL,
 CONSTRAINT [PK_StudentMst] PRIMARY KEY CLUSTERED 
(
	[SID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AdminMst] ON 

INSERT [dbo].[AdminMst] ([AID], [Name], [UserName], [Password], [EntryDate]) VALUES (1, N'Admin', N'Admin', N'Admin', CAST(N'2021-02-11T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[AdminMst] OFF
SET IDENTITY_INSERT [dbo].[BookMst] ON 

INSERT [dbo].[BookMst] ([BookID], [BookName], [Author], [Detail], [Price], [Publication], [Branch], [Quantities], [AvailableQnt], [RentQnt], [Image], [EntryDate]) VALUES (1, N'Microsoft Office', N'Mr.Hawlord', N'MS office and Outlook ', 100, N'Mohideen', N'CSE', 2, 2, 0, N'~/Book/asnet.jpg', CAST(N'2021-02-12T20:14:31.717' AS DateTime))
SET IDENTITY_INSERT [dbo].[BookMst] OFF
SET IDENTITY_INSERT [dbo].[BranchMst] ON 

INSERT [dbo].[BranchMst] ([BranchID], [BranchName]) VALUES (3, N'CSE')
SET IDENTITY_INSERT [dbo].[BranchMst] OFF
SET IDENTITY_INSERT [dbo].[PublicationMst] ON 

INSERT [dbo].[PublicationMst] ([PID], [Publication], [EntryDate]) VALUES (2, N'Mohideen', CAST(N'2021-02-12T15:49:15.517' AS DateTime))
SET IDENTITY_INSERT [dbo].[PublicationMst] OFF
SET IDENTITY_INSERT [dbo].[RentMst] ON 

INSERT [dbo].[RentMst] ([RID], [BookName], [SID], [Days], [IssueDate], [ReturnDate], [Status]) VALUES (1, N'Microsoft Office', 1, 5, CAST(N'2021-02-13T01:39:13.910' AS DateTime), CAST(N'2021-02-13T23:58:25.280' AS DateTime), 1)
INSERT [dbo].[RentMst] ([RID], [BookName], [SID], [Days], [IssueDate], [ReturnDate], [Status]) VALUES (2, N'Microsoft Office', 1, 2, CAST(N'2021-02-14T00:08:53.223' AS DateTime), CAST(N'2021-02-14T00:09:13.087' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[RentMst] OFF
SET IDENTITY_INSERT [dbo].[StudentMst] ON 

INSERT [dbo].[StudentMst] ([SID], [StudentName], [BranchName], [Mobile], [Address], [City], [Pincode], [DOB], [Gender], [Email], [Password], [Image], [EntryDate]) VALUES (1, N'Student', N'CSE', N'4578455', N'Nagercoil', N'Nagercoil', N'629251', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Male', N'4', N'1', N'~/img/std.png', CAST(N'2021-02-12T23:11:41.060' AS DateTime))
SET IDENTITY_INSERT [dbo].[StudentMst] OFF
/****** Object:  StoredProcedure [dbo].[ADMIN_changepassword]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ADMIN_changepassword]
	
	@aid as int,
	@PASS AS NVARCHAR(256)
	
AS
BEGIN
	
	SET NOCOUNT ON;

  
	update AdminMst set password=@pass where aid=@aid
	
	END
GO
/****** Object:  StoredProcedure [dbo].[ADMIN_DELETE]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ADMIN_DELETE]
	
	@AID AS INT
	
AS
BEGIN
	
	SET NOCOUNT ON;

  
	DELETE FROM AdminMst WHERE AID=@AID
	
	END
GO
/****** Object:  StoredProcedure [dbo].[ADMIN_INSERT]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ADMIN_INSERT]
	
	@NAME AS NVARCHAR(256),
	@UNAME AS NVARCHAR(256),
	@PASS AS NVARCHAR(256)
	
AS
BEGIN
	
	SET NOCOUNT ON;

  
	INSERT INTO AdminMst(Name,UserName,Password,EntryDate) VALUES (@NAME,@UNAME,@PASS,GETDATE())
	
	END
GO
/****** Object:  StoredProcedure [dbo].[ADMIN_SELECT]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ADMIN_SELECT]
	
	
AS
BEGIN
	
	SET NOCOUNT ON;

  
	SELECT * FROM AdminMst
	
	END
GO
/****** Object:  StoredProcedure [dbo].[ADMIN_SELECT_FOR_LOGIN]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[ADMIN_SELECT_FOR_LOGIN]
	@uname as nvarchar(256),
	@pass as nvarchar(256)
	
AS
BEGIN
	
	SET NOCOUNT ON;

  
	SELECT * FROM AdminMst where UserName=@uname and Password=@pass
	
	END
GO
/****** Object:  StoredProcedure [dbo].[BOOK_DELETE]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BOOK_DELETE]
	@BOOKID AS INT
AS
BEGIN
	
	SET NOCOUNT ON;
		DELETE FROM BookMst WHERE BOOKID=@BOOKID

   
	 
END
GO
/****** Object:  StoredProcedure [dbo].[BOOK_INSERT]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BOOK_INSERT]
  	@BNAME AS NVARCHAR(256),
	@AUTHOR AS NVARCHAR(256),
	@DETAIL AS NVARCHAR(256),
	@PRICE AS FLOAT ,
	@PUBLICATION AS NVARCHAR(256),
	@BRANCH AS NVARCHAR(256), 
	@QUANTITIES AS INT ,
    @AVAILABLEQNT AS INT ,
    @RENTQNT AS INT,
    @img as nvarchar(1000)
AS
BEGIN


	SET NOCOUNT ON;
	INSERT INTO BookMst VALUES (@BNAME,@AUTHOR ,@DETAIL , @PRICE, @PUBLICATION , @BRANCH , @QUANTITIES , @AVAILABLEQNT,@RENTQNT,@img,GETDATE() )

    
END
GO
/****** Object:  StoredProcedure [dbo].[BOOK_ISSUE_TO_STUDENT]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BOOK_ISSUE_TO_STUDENT]
	@BID  AS INT
AS
BEGIN
	
	SET NOCOUNT ON;

	UPDATE BookMst SET AvailableQnt=AvailableQnt-1, RentQnt=RentQnt+1 WHERE BookID=@BID
END
GO
/****** Object:  StoredProcedure [dbo].[BOOK_SELECT]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BOOK_SELECT]
	
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT * FROM BookMst
END
GO
/****** Object:  StoredProcedure [dbo].[BOOK_SELECT_By_BID]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[BOOK_SELECT_By_BID]
	
	@bid as int
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT * FROM BookMst where BookID=@bid
END
GO
/****** Object:  StoredProcedure [dbo].[BOOK_SELECT_By_BNAME]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[BOOK_SELECT_By_BNAME]
	
@BNAME AS NVARCHAR(200)
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT * FROM BookMst where BookName=@BNAME
END
GO
/****** Object:  StoredProcedure [dbo].[BOOK_SELECT_By_BRANCH]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BOOK_SELECT_By_BRANCH]
	
@BRANCH AS NVARCHAR(200)
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT * FROM BookMst where Branch=@BRANCH
END
GO
/****** Object:  StoredProcedure [dbo].[BOOK_SELECT_By_PUBLICATION]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BOOK_SELECT_By_PUBLICATION]
	
@PUB AS NVARCHAR(200)
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT * FROM BookMst where Publication=@PUB
END
GO
/****** Object:  StoredProcedure [dbo].[BOOK_UPDATE]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[BOOK_UPDATE]
@bid as int,
  	@BNAME AS NVARCHAR(256),
	@AUTHOR AS NVARCHAR(256),
	@DETAIL AS NVARCHAR(256),
	@PRICE AS FLOAT ,
	@PUBLICATION AS NVARCHAR(256),
	@BRANCH AS NVARCHAR(256), 	
    @img as nvarchar(1000)
AS
BEGIN


 update BookMst set BookName=@BNAME,Author=@AUTHOR,Detail=@DETAIL, Price=@PRICE, Publication =@PUBLICATION , Branch=@BRANCH, Image=@img where BookID=@bid

    
END
GO
/****** Object:  StoredProcedure [dbo].[BRANCH_DELETE]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BRANCH_DELETE]
	@BRANCHID AS INT
AS
BEGIN
	
	SET NOCOUNT ON;
		DELETE FROM BranchMst WHERE BRANCHID=@BRANCHID

   
	 
END
GO
/****** Object:  StoredProcedure [dbo].[BRANCH_INSERT]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BRANCH_INSERT]
	
	@BRANCHNAME AS NVARCHAR(256)
	
AS
BEGIN
	
	SET NOCOUNT ON;

  
	INSERT INTO BranchMst(BranchName) VALUES (@BRANCHNAME)
	
	END
GO
/****** Object:  StoredProcedure [dbo].[BRANCH_SELECT]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BRANCH_SELECT]
	
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT * FROM BranchMst
END
GO
/****** Object:  StoredProcedure [dbo].[BRANCH_SELECT_BY_BID]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BRANCH_SELECT_BY_BID]
@BID AS INT	
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT * FROM BranchMst WHERE BranchID=@BID
END
GO
/****** Object:  StoredProcedure [dbo].[BRANCH_SELECT_BY_BNAME]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BRANCH_SELECT_BY_BNAME]
@BNAME AS NVARCHAR(256)
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT * FROM BranchMst WHERE BranchName=@BNAME
END
GO
/****** Object:  StoredProcedure [dbo].[BRANCH_UPDATE]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BRANCH_UPDATE]
	@BID AS INT,
	@BRANCHNAME AS NVARCHAR(256)
	
	
AS
BEGIN
UPDATE BranchMst SET BranchName= @BRANCHNAME WHERE BranchID=@BID
	
	END
GO
/****** Object:  StoredProcedure [dbo].[PENALTY_DELETE]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PENALTY_DELETE]
	@PID AS INT
AS
BEGIN
	
	SET NOCOUNT ON;
		DELETE FROM PenaltyMst WHERE PID=@PID

   
	 
END
GO
/****** Object:  StoredProcedure [dbo].[PENALTY_INSERT]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PENALTY_INSERT]
	
	
	@SID AS INT,
	@bname as nvarchar(256),
	@price as float,
	@panalty as float,
	@detail as nvarchar(500)
 
AS
BEGIN
	
	SET NOCOUNT ON;

  
	INSERT INTO PenaltyMst (SID,BookName,Price,Panalty,Detail,EntryDate)VALUES (@SID,@bname,@price,@panalty,@detail,GETDATE())
	
	END
GO
/****** Object:  StoredProcedure [dbo].[PENALTY_PAY_NOW]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[PENALTY_PAY_NOW]
@panalty as float,
@detail as nvarchar(500),
@pid as int
AS
BEGIN
	
	SET NOCOUNT ON;

update PenaltyMst set Panalty=@panalty,Detail=@detail, EntryDate=GETDATE() where  PID=@pid
	--SELECT * FROM PenaltyMst WHERE SID=@SID and Panalty=0
END
GO
/****** Object:  StoredProcedure [dbo].[PENALTY_SELECT]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PENALTY_SELECT]
	
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT * FROM PenaltyMst
END
GO
/****** Object:  StoredProcedure [dbo].[PENALTY_SELECT_BY_BNAME]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PENALTY_SELECT_BY_BNAME]
@BNAME AS NVARCHAR(256)	
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT * FROM PenaltyMst WHERE BookName=@BNAME
END
GO
/****** Object:  StoredProcedure [dbo].[PENALTY_SELECT_BY_PID]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PENALTY_SELECT_BY_PID]
@PID AS INT	
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT * FROM PenaltyMst WHERE PID=@PID
END
GO
/****** Object:  StoredProcedure [dbo].[PENALTY_SELECT_BY_SID]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PENALTY_SELECT_BY_SID]
@SID AS INT	
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT * FROM PenaltyMst WHERE SID=@SID  
END
GO
/****** Object:  StoredProcedure [dbo].[PENALTY_SELECT_BY_SID_and_Panalty_0]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[PENALTY_SELECT_BY_SID_and_Panalty_0]
@SID AS INT	
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT * FROM PenaltyMst WHERE SID=@SID and Panalty=0
END
GO
/****** Object:  StoredProcedure [dbo].[PENALTY_SELECT_BY_SID_book]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[PENALTY_SELECT_BY_SID_book]
@SID AS INT,
@book as nvarchar(500)
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT * FROM PenaltyMst WHERE SID=@SID and BookName=@book
END
GO
/****** Object:  StoredProcedure [dbo].[PENALTY_SELECT_FOR_PAY]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[PENALTY_SELECT_FOR_PAY]
	
AS
BEGIN
	
	SET NOCOUNT ON;

	select * from StudentMst where SID in( SELECT SID FROM PenaltyMst where Panalty=0)
END
GO
/****** Object:  StoredProcedure [dbo].[PUBLICATION_DELETE]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PUBLICATION_DELETE]
@PID AS INT
AS
BEGIN
	
	SET NOCOUNT ON;

DELETE FROM PublicationMst WHERE PID=@PID
	
END
GO
/****** Object:  StoredProcedure [dbo].[PUBLICATION_INSERT]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PUBLICATION_INSERT]
	@PNAME AS NVARCHAR(256)
AS
BEGIN
	
	SET NOCOUNT ON;

	INSERT INTO PublicationMst(Publication,EntryDate) VALUES(@PNAME,GETDATE())
	
END
GO
/****** Object:  StoredProcedure [dbo].[PUBLICATION_SELECT]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PUBLICATION_SELECT]
	
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT * FROM PublicationMst
END
GO
/****** Object:  StoredProcedure [dbo].[PUBLICATION_SELECT_BY_PID]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PUBLICATION_SELECT_BY_PID]
	@PID AS INT
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT * FROM PublicationMst WHERE PID=@PID
END
GO
/****** Object:  StoredProcedure [dbo].[PUBLICATION_SELECT_BY_PNAME]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PUBLICATION_SELECT_BY_PNAME]
	@PNAME AS NVARCHAR(256)
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT * FROM PublicationMst WHERE Publication=@PNAME
END
GO
/****** Object:  StoredProcedure [dbo].[PUBLICATION_UPDATE]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PUBLICATION_UPDATE]
@PID AS INT,
	@PNAME AS NVARCHAR(256)
AS
BEGIN
	
	SET NOCOUNT ON;

	UPDATE PublicationMst SET PUBLICATION= @PNAME WHERE PID=@PID
	
END
GO
/****** Object:  StoredProcedure [dbo].[RENT_DELETE]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RENT_DELETE]
	@RID AS INT
AS
BEGIN
	
	SET NOCOUNT ON;
		DELETE FROM RentMst WHERE RID=@RID

   
	 
END
GO
/****** Object:  StoredProcedure [dbo].[RENT_INSERT]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RENT_INSERT]
	
	@BNAME AS NVARCHAR(256),
	@SID AS INT,
	@DAYS AS INT
	
AS
BEGIN
	
	SET NOCOUNT ON;

  
	INSERT INTO RentMst(BookName,SID,Days,IssueDate,ReturnDate,Status) VALUES (@BNAME,@SID,@DAYS,GETDATE(),NULL,0)
	
	END
GO
/****** Object:  StoredProcedure [dbo].[RENT_SELECT]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RENT_SELECT]
	
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT * FROM RentMst
END
GO
/****** Object:  StoredProcedure [dbo].[RENT_SELECT_BOOK_RENT]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[RENT_SELECT_BOOK_RENT]
	@sid  as  int,
	@STATUS AS INT
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT  * FROM RentMst   where SID=@sid and  Status=@STATUS  
END
GO
/****** Object:  StoredProcedure [dbo].[RENT_SELECT_BOOKNAME]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[RENT_SELECT_BOOKNAME]
	@BNAME AS NVARCHAR(256)
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT * FROM RentMst where BookName=@BNAME
END
GO
/****** Object:  StoredProcedure [dbo].[RENT_SELECT_BY_STATUS]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[RENT_SELECT_BY_STATUS]
	@STATUS AS INT
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT * FROM RentMst where Status=@STATUS
END
GO
/****** Object:  StoredProcedure [dbo].[RENT_SELECT_BY_STATUS_AND_SID]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[RENT_SELECT_BY_STATUS_AND_SID]
	@SID AS INT,
	@STATUS AS INT
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT * FROM RentMst where SID=@SID AND  Status=@STATUS
END
GO
/****** Object:  StoredProcedure [dbo].[RENT_SELECT_RETURN]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RENT_SELECT_RETURN]
	@RID AS INT,
	@STATUS AS INT,
	@bid as  int
AS
BEGIN
	
	SET NOCOUNT ON;

	 UPDATE RentMst SET Status=@STATUS, ReturnDate=GETDATE() WHERE RID=@RID
	 update BookMst set AvailableQnt=AvailableQnt+1,RentQnt=RentQnt-1 where BookID=@bid
END
GO
/****** Object:  StoredProcedure [dbo].[RENT_SELECT_RID]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[RENT_SELECT_RID]
	@rid as int
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT * FROM RentMst where RID=@rid
END
GO
/****** Object:  StoredProcedure [dbo].[RENT_SELECT_SID]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[RENT_SELECT_SID]
	@SID AS INT
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT * FROM RentMst where SID=@SID
END
GO
/****** Object:  StoredProcedure [dbo].[RENT_SELECT_SID_and_BNAME]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[RENT_SELECT_SID_and_BNAME]
	@BNAME AS NVARCHAR(256),
	@sid as int
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT * FROM RentMst where BookName=@BNAME and SID=@sid
END
GO
/****** Object:  StoredProcedure [dbo].[RENT_SELECT_SID_and_BNAME_and_STATUS]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[RENT_SELECT_SID_and_BNAME_and_STATUS]
	@BNAME AS NVARCHAR(256),
	@sid as int,
	@status as int
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT * FROM RentMst where BookName=@BNAME and SID=@sid and Status=@status
END
GO
/****** Object:  StoredProcedure [dbo].[RENT_SELECT_SID_STATUS]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[RENT_SELECT_SID_STATUS]
	@sid as int,
	@status as int
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT * FROM RentMst where SID=@sid and Status=@status
END
GO
/****** Object:  StoredProcedure [dbo].[STUDENT_change_password]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[STUDENT_change_password]
	@sid as int,
	@pass as nvarchar(256)
AS
BEGIN
	
	SET NOCOUNT ON;

update StudentMst set password=@pass where SID=@sid
END
GO
/****** Object:  StoredProcedure [dbo].[STUDENT_DELETE]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[STUDENT_DELETE]
	@SID AS INT
AS
BEGIN
	
	SET NOCOUNT ON;
		DELETE FROM StudentMst WHERE SID=@SID

   
	 
END
GO
/****** Object:  StoredProcedure [dbo].[STUDENT_INSERT]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[STUDENT_INSERT]
	@STUDENTNAME AS NVARCHAR(256),
	@BRANCHNAME AS NVARCHAR(256),
	@MOBILE AS NVARCHAR (256),
	@ADD AS NVARCHAR(256),
	@CITY AS NVARCHAR(256),
	@PINCODE AS NVARCHAR(256),
	@DOB AS DATETIME,
	@GENDER AS NVARCHAR(256),
	@EMAIL AS  NVARCHAR (256),
	@pass as nvarchar(256),
	@img as nvarchar(500)
AS
BEGIN
	
	SET NOCOUNT ON;


	INSERT INTO StudentMst(StudentName,BranchName,Mobile,Address,City,Pincode,DOB,Gender,Email,Password,Image,EntryDate) VALUES (@STUDENTNAME, @BRANCHNAME ,@MOBILE , @ADD , @CITY , @PINCODE , @DOB, @GENDER , @EMAIL,@pass,@img,GETDATE()) 
END
GO
/****** Object:  StoredProcedure [dbo].[STUDENT_SELECT]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[STUDENT_SELECT]
	
AS
BEGIN
	
	SET NOCOUNT ON;


	SELECT * FROM StudentMst
END
GO
/****** Object:  StoredProcedure [dbo].[STUDENT_SELECT_BY_branch]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[STUDENT_SELECT_BY_branch]
@branch AS  NVARCHAR(256)
AS
BEGIN
	
	SET NOCOUNT ON;


	SELECT * FROM StudentMst WHERE BranchName=@branch
END
GO
/****** Object:  StoredProcedure [dbo].[STUDENT_SELECT_BY_EMAIL]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[STUDENT_SELECT_BY_EMAIL]
@EMAIL AS  NVARCHAR(256)
AS
BEGIN
	
	SET NOCOUNT ON;


	SELECT * FROM StudentMst WHERE Email=@EMAIL
END
GO
/****** Object:  StoredProcedure [dbo].[STUDENT_SELECT_BY_SID]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[STUDENT_SELECT_BY_SID]
@SID AS INT	
AS
BEGIN
	
	SET NOCOUNT ON;


	SELECT * FROM StudentMst WHERE SID=@SID
END
GO
/****** Object:  StoredProcedure [dbo].[STUDENT_SELECT_LOGIN]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[STUDENT_SELECT_LOGIN]
@EMAIL AS  NVARCHAR(256),
@pass as nvarchar(256)
AS
BEGIN
	
	SET NOCOUNT ON;


	SELECT * FROM StudentMst WHERE Email=@EMAIL and Password=@pass
END
GO
/****** Object:  StoredProcedure [dbo].[STUDENT_SELECT_RENT_BOOK]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[STUDENT_SELECT_RENT_BOOK]
	
	@STATUS AS INT
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT distinct s.sid as SID,s.StudentName as StudentName FROM RentMst as r, StudentMst as s where Status=@STATUS and s.SID=r.SID
END
GO
/****** Object:  StoredProcedure [dbo].[STUDENT_SELECT_SEARCH]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[STUDENT_SELECT_SEARCH]
	@name as nvarchar(256)
AS
BEGIN
	
	SET NOCOUNT ON;


	SELECT * FROM StudentMst where StudentName like @name
END
GO
/****** Object:  StoredProcedure [dbo].[STUDENT_UPDATE]    Script Date: 2/14/2021 4:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[STUDENT_UPDATE]
	@SID AS INT,
	@STUDENTNAME AS NVARCHAR(256),
	@EMail AS NVARCHAR(256),
	@MOBILE AS NVARCHAR (256),
	@ADD AS NVARCHAR(256),
	@CITY AS NVARCHAR(256),
	@PINCODE AS NVARCHAR(256)

    
AS
BEGIN
	
UPDATE StudentMst SET StudentName=@STUDENTNAME, Email=@EMail, Mobile=@MOBILE, Address=@ADD, City=@CITY, Pincode=@PINCODE  WHERE SID=@SID

END
GO
USE [master]
GO
ALTER DATABASE [LibrarySystem] SET  READ_WRITE 
GO
