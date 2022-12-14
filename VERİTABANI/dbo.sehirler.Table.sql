USE [ProjeDB]
GO
/****** Object:  Table [dbo].[sehirler]    Script Date: 1.11.2022 00:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sehirler](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Sehiradi] [nvarchar](max) NULL,
	[Ulke] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.sehirler] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[sehirler] ON 

INSERT [dbo].[sehirler] ([id], [Sehiradi], [Ulke]) VALUES (1, N'New York', N'ABD')
INSERT [dbo].[sehirler] ([id], [Sehiradi], [Ulke]) VALUES (2, N'Los Angeles', N'ABD')
INSERT [dbo].[sehirler] ([id], [Sehiradi], [Ulke]) VALUES (3, N'Miami', N'ABD')
INSERT [dbo].[sehirler] ([id], [Sehiradi], [Ulke]) VALUES (4, N'Minnesota', N'ABD')
INSERT [dbo].[sehirler] ([id], [Sehiradi], [Ulke]) VALUES (5, N'Pekin', N'ÇİN')
INSERT [dbo].[sehirler] ([id], [Sehiradi], [Ulke]) VALUES (6, N'Şanghay', N'ÇİN')
INSERT [dbo].[sehirler] ([id], [Sehiradi], [Ulke]) VALUES (7, N'İstanbul', N'TÜRKİYE')
INSERT [dbo].[sehirler] ([id], [Sehiradi], [Ulke]) VALUES (8, N'İzmir', N'TÜRKİYE')
SET IDENTITY_INSERT [dbo].[sehirler] OFF
GO
