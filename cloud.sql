
CREATE DATABASE [Cloud]

USE [Cloud]

CREATE TABLE [dbo].[otp](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[otp] [varchar](100) NULL,
	[name] [varchar](100) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Registration]    Script Date: 16-10-2016 17:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registration](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Emailid] [varchar](50) NULL,
	[Contactno] [varchar](100) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Share]    Script Date: 16-10-2016 17:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Share](
	[Shareid] [int] IDENTITY(1,1) NOT NULL,
	[Friendid] [varchar](50) NULL,
	[Filename] [varchar](max) NULL,
	[Servername] [varchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [Cloud] SET  READ_WRITE 
GO
CREATE TABLE [dbo].[time_op](
	[stime] [varchar](50) NULL,
	[etime] [varchar](50) NULL,
	[tdiff] [varchar](50) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

