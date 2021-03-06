USE [summer17]
GO
/****** Object:  Table [dbo].[CreditCard]    Script Date: 05/29/2017 08:54:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CreditCard](
	[CardNr] [int] NOT NULL,
	[Bank] [varchar](50) NULL,
	[CVC] [int] NULL,
	[CardHolder] [varchar](50) NULL,
	[ExpirationDate] [date] NULL,
	[BillingAddress] [varchar](50) NULL,
	[IssuingCompany] [varchar](50) NULL,
 CONSTRAINT [PK_CreditCard] PRIMARY KEY CLUSTERED 
(
	[CardNr] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Book]    Script Date: 05/29/2017 08:54:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Book](
	[ISBN] [int] NOT NULL,
	[Title] [varchar](50) NULL,
	[CoverImage] [varchar](50) NULL,
	[Description] [text] NULL,
	[Price] [numeric](18, 0) NULL,
	[PublishingInfo] [varchar](50) NULL,
	[NrOfSales] [int] NULL,
	[Genre] [varchar](50) NULL,
	[Rating] [int] NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Author]    Script Date: 05/29/2017 08:54:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Author](
	[AuthorID] [int] NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[ProfileImage] [varchar](50) NULL,
	[Biography] [text] NULL,
 CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED 
(
	[AuthorID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Writes]    Script Date: 05/29/2017 08:54:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Writes](
	[AuthorID] [int] NULL,
	[ISBN] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 05/29/2017 08:54:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [int] NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Address] [varchar](100) NULL,
	[DOB] [date] NULL,
	[Sex] [varchar](50) NULL,
	[ProfileImage] [varchar](100) NULL,
	[ShippingAddress] [varchar](50) NULL,
	[Nickname] [varchar](50) NULL,
	[Unsername] [varchar](20) NULL,
	[Password] [varchar](20) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Purchases]    Script Date: 05/29/2017 08:54:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purchases](
	[UserID] [int] NULL,
	[ISBN] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OwnsA]    Script Date: 05/29/2017 08:54:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OwnsA](
	[UserID] [int] NULL,
	[CardNr] [int] NULL
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_OwnsA] ON [dbo].[OwnsA] 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Purchases_Book]    Script Date: 05/29/2017 08:54:54 ******/
ALTER TABLE [dbo].[Purchases]  WITH CHECK ADD  CONSTRAINT [FK_Purchases_Book] FOREIGN KEY([ISBN])
REFERENCES [dbo].[Book] ([ISBN])
GO
ALTER TABLE [dbo].[Purchases] CHECK CONSTRAINT [FK_Purchases_Book]
GO
/****** Object:  ForeignKey [FK_Purchases_User]    Script Date: 05/29/2017 08:54:54 ******/
ALTER TABLE [dbo].[Purchases]  WITH CHECK ADD  CONSTRAINT [FK_Purchases_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[Purchases] CHECK CONSTRAINT [FK_Purchases_User]
GO
/****** Object:  ForeignKey [FK_OwnsA_CreditCard]    Script Date: 05/29/2017 08:54:54 ******/
ALTER TABLE [dbo].[OwnsA]  WITH CHECK ADD  CONSTRAINT [FK_OwnsA_CreditCard] FOREIGN KEY([CardNr])
REFERENCES [dbo].[CreditCard] ([CardNr])
GO
ALTER TABLE [dbo].[OwnsA] CHECK CONSTRAINT [FK_OwnsA_CreditCard]
GO
/****** Object:  ForeignKey [FK_OwnsA_User]    Script Date: 05/29/2017 08:54:54 ******/
ALTER TABLE [dbo].[OwnsA]  WITH CHECK ADD  CONSTRAINT [FK_OwnsA_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[OwnsA] CHECK CONSTRAINT [FK_OwnsA_User]
GO
