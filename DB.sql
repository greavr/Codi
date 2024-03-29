USE [Codi]
GO
/****** Object:  Table [dbo].[tbl_Page]    Script Date: 01/23/2011 21:32:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Page]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_Page]
GO
/****** Object:  Table [dbo].[tbl_Chapters]    Script Date: 01/23/2011 21:32:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Chapters]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_Chapters]
GO
/****** Object:  Table [dbo].[tbl_Books]    Script Date: 01/23/2011 21:32:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Books]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_Books]
GO
/****** Object:  Table [dbo].[tbl_Attachment]    Script Date: 01/23/2011 21:32:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Attachment]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_Attachment]
GO
/****** Object:  Table [dbo].[tbl_Notes]    Script Date: 01/23/2011 21:32:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Notes]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_Notes]
GO
/****** Object:  Table [dbo].[tbl_Requirements]    Script Date: 01/23/2011 21:32:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Requirements]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_Requirements]
GO
/****** Object:  Table [dbo].[tbl_Requirements]    Script Date: 01/23/2011 21:32:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Requirements]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_Requirements](
	[RID] [int] IDENTITY(1,1) NOT NULL,
	[Requirement] [varchar](250) NULL,
	[PID] [int] NULL,
 CONSTRAINT [PK_tbl_Requirements] PRIMARY KEY CLUSTERED 
(
	[RID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Notes]    Script Date: 01/23/2011 21:32:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Notes]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_Notes](
	[NID] [int] IDENTITY(1,1) NOT NULL,
	[Note] [varchar](1000) NULL,
	[Created] [datetime] NULL,
 CONSTRAINT [PK_tbl_Notes] PRIMARY KEY CLUSTERED 
(
	[NID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Attachment]    Script Date: 01/23/2011 21:32:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Attachment]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_Attachment](
	[AID] [int] IDENTITY(1,1) NOT NULL,
	[Attachment] [binary](8000) NULL,
	[PID] [int] NULL,
 CONSTRAINT [PK_tbl_Attachment] PRIMARY KEY CLUSTERED 
(
	[AID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Books]    Script Date: 01/23/2011 21:32:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Books]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_Books](
	[BID] [int] IDENTITY(1,1) NOT NULL,
	[Book Name] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_Books] PRIMARY KEY CLUSTERED 
(
	[BID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Chapters]    Script Date: 01/23/2011 21:32:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Chapters]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_Chapters](
	[CID] [int] IDENTITY(1,1) NOT NULL,
	[Chapter Name] [varchar](50) NULL,
	[BID] [int] NULL,
 CONSTRAINT [PK_tbl_Chapters] PRIMARY KEY CLUSTERED 
(
	[CID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Page]    Script Date: 01/23/2011 21:32:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Page]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_Page](
	[PID] [int] IDENTITY(1,1) NOT NULL,
	[Page Title] [varchar](100) NULL,
	[Code] [varchar](4000) NULL,
	[Status] [varchar](50) NULL,
	[Created] [datetime] NULL,
	[Last Modified] [datetime] NULL,
	[CID] [int] NULL,
 CONSTRAINT [PK_tbl_Page] PRIMARY KEY CLUSTERED 
(
	[PID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
