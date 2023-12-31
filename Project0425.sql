USE [master]
GO
/****** Object:  Database [Project]    Script Date: 2023/4/25 下午 04:03:21 ******/
CREATE DATABASE [Project]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Project', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Project.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Project_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Project_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Project] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Project].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Project] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Project] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Project] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Project] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Project] SET ARITHABORT OFF 
GO
ALTER DATABASE [Project] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Project] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Project] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Project] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Project] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Project] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Project] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Project] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Project] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Project] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Project] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Project] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Project] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Project] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Project] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Project] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Project] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Project] SET RECOVERY FULL 
GO
ALTER DATABASE [Project] SET  MULTI_USER 
GO
ALTER DATABASE [Project] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Project] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Project] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Project] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Project] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Project] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Project', N'ON'
GO
ALTER DATABASE [Project] SET QUERY_STORE = OFF
GO
USE [Project]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 2023/4/25 下午 04:03:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[帳號] [nvarchar](50) NULL,
	[密碼] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cart]    Script Date: 2023/4/25 下午 04:03:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cart](
	[訂單編號] [int] IDENTITY(1,1) NOT NULL,
	[購物人] [nvarchar](50) NULL,
	[商品] [nvarchar](50) NOT NULL,
	[數量] [int] NOT NULL,
	[總價] [int] NOT NULL,
 CONSTRAINT [PK_Cart] PRIMARY KEY CLUSTERED 
(
	[訂單編號] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Members]    Script Date: 2023/4/25 下午 04:03:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Members](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[姓名] [nvarchar](50) NULL,
	[電話] [nvarchar](50) NULL,
	[地址] [nvarchar](100) NULL,
	[email] [nvarchar](50) NULL,
	[生日] [date] NULL,
	[婚姻狀態] [bit] NULL,
	[會員點數] [int] NULL,
 CONSTRAINT [PK_persons] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order_o]    Script Date: 2023/4/25 下午 04:03:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order_o](
	[訂單編號] [int] NULL,
	[購物人] [nvarchar](50) NULL,
	[商品] [nvarchar](50) NULL,
	[數量] [int] NULL,
	[總價] [int] NULL,
	[電話] [nvarchar](50) NULL,
	[地址] [nvarchar](100) NULL,
	[email] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 2023/4/25 下午 04:03:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[pname] [nvarchar](100) NULL,
	[price] [int] NULL,
	[pinform] [nvarchar](500) NULL,
	[pimage] [nvarchar](100) NULL,
 CONSTRAINT [PK_products] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([帳號], [密碼]) VALUES (N'boss987', N'boss987')
GO
SET IDENTITY_INSERT [dbo].[Cart] ON 

INSERT [dbo].[Cart] ([訂單編號], [購物人], [商品], [數量], [總價]) VALUES (29, N'鄭偉漢', N'嫩煎鷄腿堡', 5, 350)
INSERT [dbo].[Cart] ([訂單編號], [購物人], [商品], [數量], [總價]) VALUES (30, N'幹', N'雙層牛肉吉事堡', 5, 350)
SET IDENTITY_INSERT [dbo].[Cart] OFF
GO
SET IDENTITY_INSERT [dbo].[Members] ON 

INSERT [dbo].[Members] ([id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [會員點數]) VALUES (1, N'蕭弘志', N'0937-123-456', N'台北市中正區忠孝東路一段100號', N'changsan@gmail.com', CAST(N'1986-06-17' AS Date), 1, 21)
INSERT [dbo].[Members] ([id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [會員點數]) VALUES (2, N'李德名', N'0988-987-654', N'新北市新店區北宜路二段50巷10弄3號', N'lisih@icloud.com', CAST(N'1991-02-28' AS Date), 0, 13)
INSERT [dbo].[Members] ([id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [會員點數]) VALUES (3, N'王敏號', N'0912-345-678', N'台中市北屯區熱河路三段200號', N'wangwu@yahoo.com.tw', CAST(N'1995-12-10' AS Date), 0, 32)
INSERT [dbo].[Members] ([id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [會員點數]) VALUES (4, N'鄭偉漢', N'0922-555-888', N'台南市安南區安中路二段100號', N'zhaoliu@hotmail.com', CAST(N'2003-12-25' AS Date), 0, 47)
INSERT [dbo].[Members] ([id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [會員點數]) VALUES (5, N'楊心怡', N'0977-692-467', N'桃園市中壢區中大路300號', N'chenqi@outlook.com', CAST(N'2001-07-05' AS Date), 1, 76)
INSERT [dbo].[Members] ([id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [會員點數]) VALUES (6, N'林健祥', N'0901-234-567', N'高雄市三民區民族一路200號', N'wuba@yahoo.com.tw', CAST(N'1998-03-15' AS Date), 1, 108)
INSERT [dbo].[Members] ([id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [會員點數]) VALUES (7, N'黃弘勝', N'0955-321-654', N'新竹市東區建功一路18號', N'linjiu@gmail.com', CAST(N'1990-11-23' AS Date), 0, 89)
INSERT [dbo].[Members] ([id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [會員點數]) VALUES (8, N'許依林', N'0910-272-347', N'台北市信義區忠孝東路五段200號', N'hsuxi@yahoo.com.tw', CAST(N'2006-06-08' AS Date), 0, 78)
INSERT [dbo].[Members] ([id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [會員點數]) VALUES (9, N'趙紫琪', N'0986-026-549', N'台北市大安區敦化南路二段200號', N'chenst@gmail.com', CAST(N'2002-09-14' AS Date), 1, 26)
INSERT [dbo].[Members] ([id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [會員點數]) VALUES (10, N'張雅涵', N'0921-987-654', N'新北市三峽區中正路200號', N'wangcm@outlook.com', CAST(N'1995-04-23' AS Date), 1, 154)
SET IDENTITY_INSERT [dbo].[Members] OFF
GO
INSERT [dbo].[Order_o] ([訂單編號], [購物人], [商品], [數量], [總價], [電話], [地址], [email]) VALUES (29, N'鄭偉漢', N'嫩煎鷄腿堡', 5, 350, N'0922-555-888', N'台南市安南區安中路二段100號', N'zhaoliu@hotmail.com')
INSERT [dbo].[Order_o] ([訂單編號], [購物人], [商品], [數量], [總價], [電話], [地址], [email]) VALUES (30, N'幹', N'雙層牛肉吉事堡', 5, 350, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[products] ON 

INSERT [dbo].[products] ([id], [pname], [price], [pinform], [pimage]) VALUES (1, N'雙層牛肉吉事堡', 70, N'好吃', N'1.png')
INSERT [dbo].[products] ([id], [pname], [price], [pinform], [pimage]) VALUES (2, N'蕈菇安格斯牛肉堡', 100, N'好吃', N'2.png')
INSERT [dbo].[products] ([id], [pname], [price], [pinform], [pimage]) VALUES (3, N'無敵大麥克', 120, N'好吃', N'3.png')
INSERT [dbo].[products] ([id], [pname], [price], [pinform], [pimage]) VALUES (4, N'嫩煎鷄腿堡', 70, N'好吃', N'4.png')
INSERT [dbo].[products] ([id], [pname], [price], [pinform], [pimage]) VALUES (5, N'六塊麥克雞塊', 60, N'難吃', N'5.png')
INSERT [dbo].[products] ([id], [pname], [price], [pinform], [pimage]) VALUES (6, N'薯條', 40, N'好吃', N'6.png')
INSERT [dbo].[products] ([id], [pname], [price], [pinform], [pimage]) VALUES (7, N'義式烤鷄沙拉', 40, N'好吃', N'7.png')
INSERT [dbo].[products] ([id], [pname], [price], [pinform], [pimage]) VALUES (8, N'金黃地瓜條', 40, N'好吃', N'8.png')
INSERT [dbo].[products] ([id], [pname], [price], [pinform], [pimage]) VALUES (9, N'薯餅', 30, N'好吃', N'9.png')
INSERT [dbo].[products] ([id], [pname], [price], [pinform], [pimage]) VALUES (10, N'勁辣香鷄翅', 60, N'好吃', N'10.png')
SET IDENTITY_INSERT [dbo].[products] OFF
GO
USE [master]
GO
ALTER DATABASE [Project] SET  READ_WRITE 
GO
