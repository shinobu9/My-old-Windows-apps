USE [Data2]
GO
/****** Object:  Table [dbo].[BACKUP]    Script Date: 06/09/2018 18:31:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BACKUP](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[st_ln] [varchar](255) NULL,
	[st_fn] [varchar](255) NULL,
	[st_sn] [varchar](255) NULL,
	[st_school] [varchar](255) NULL,
	[st_class] [varchar](255) NULL,
	[st_tel] [varchar](255) NULL,
	[st_em] [varchar](255) NULL,
	[st_date] [date] NULL,
	[ad_name] [varchar](255) NULL,
	[ad_tel] [varchar](255) NULL,
	[ad_address] [varchar](255) NULL,
	[CD_date] [date] NULL,
 CONSTRAINT [PK_BACKUP] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ADN]    Script Date: 06/09/2018 18:31:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ADN](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Indx] [varchar](255) NULL,
	[Name] [varchar](255) NULL,
	[Tel] [varchar](255) NULL,
	[Address] [varchar](255) NULL,
 CONSTRAINT [PK_ADN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[STN]    Script Date: 06/09/2018 18:31:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[STN](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LName] [varchar](255) NULL,
	[FName] [varchar](255) NULL,
	[SName] [varchar](255) NULL,
	[School] [varchar](255) NULL,
	[Class] [varchar](255) NULL,
	[Tel] [varchar](255) NULL,
	[EMail] [varchar](255) NULL,
	[Date] [date] NULL,
 CONSTRAINT [PK_STN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[Update2]    Script Date: 06/09/2018 18:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Update2] @LN varchar(255),@FN varchar(255),
@SN varchar(255),@SC varchar(255),@C varchar(255),@T varchar(255),
@E varchar(255),@D date,@ID int
AS
BEGIN
update [STN] set [FName] = @FN, [LName] = @LN,[Sname] = @SN,[School]=@SC,[Class]=@C, [Tel] = @T,[EMail]=@E,[Date]=@D where [ID] = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[Upd3]    Script Date: 06/09/2018 18:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Upd3] @ID int, @N varchar(255), @T varchar(255), @A varchar(255)
AS
BEGIN
update [ADN] set [Name] = @N, [Tel] = @T,[Address] = @A where [ID] = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[insin]    Script Date: 06/09/2018 18:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insin] @LN varchar(255),@FN varchar(255),
@SN varchar(255),@SC varchar(255),@C varchar(255),@T varchar(255),
@E varchar(255),@D varchar(255),
@yn varchar(255), @yt varchar(255), @ya varchar(255)
AS
BEGIN
INSERT INTO [BACKUP] ([st_ln],[st_fn],[st_sn],[st_school],[st_class],[st_tel],[st_em],[st_date],[ad_name],[ad_tel],[ad_address],[CD_date])
VALUES (@LN,@FN,@SN,@SC,@C,@T,@E,@D,@yn,@yt,@ya,GETDATE());
END
GO
/****** Object:  StoredProcedure [dbo].[Insert2]    Script Date: 06/09/2018 18:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Insert2] @LN varchar(255),@FN varchar(255),
@SN varchar(255),@SC varchar(255),@C varchar(255),@T varchar(255),
@E varchar(255),@D varchar(255)
AS
BEGIN
INSERT INTO [STN] ([LName],[FName],[SName],[School],[Class],[Tel],[EMail],[Date])
VALUES (@LN,@FN,@SN,@SC,@C,@T,@E,@D);
END
GO
/****** Object:  StoredProcedure [dbo].[Ins3]    Script Date: 06/09/2018 18:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Ins3] @I varchar(255),@N varchar(255),@T varchar(255),
@A varchar(255)
AS
BEGIN
INSERT INTO [ADN] ([Indx],[Name],[Tel],[Address])
VALUES (@I,@N,@T,@A)
END
GO
/****** Object:  StoredProcedure [dbo].[Delete2]    Script Date: 06/09/2018 18:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Delete2] @id int
AS
BEGIN
delete from [STN] where [ID]=@id
delete from [ADN] where [Indx]=@id
END
GO
/****** Object:  StoredProcedure [dbo].[Del3]    Script Date: 06/09/2018 18:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Del3] @id int
AS
BEGIN
delete from [ADN] where [ID]=@id
END
GO
/****** Object:  StoredProcedure [dbo].[Count2]    Script Date: 06/09/2018 18:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Count2]
AS
BEGIN
Select COUNT(*) from [STN]
END
GO
/****** Object:  StoredProcedure [dbo].[copyinSTN]    Script Date: 06/09/2018 18:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[copyinSTN] @id int
AS
BEGIN
SELECT * FROM [STN]
WHERE [ID]=@id
END
GO
/****** Object:  StoredProcedure [dbo].[copyinADN]    Script Date: 06/09/2018 18:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[copyinADN] @id int
AS
BEGIN
SELECT * FROM [ADN]
WHERE [Indx]=@id
END
GO
