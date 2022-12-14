USE [ProjeDB]
GO
/****** Object:  Table [dbo].[paketler]    Script Date: 1.11.2022 00:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[paketler](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Paket] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.paketler] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[paketler] ON 

INSERT [dbo].[paketler] ([id], [Paket]) VALUES (1, N'Paletler')
INSERT [dbo].[paketler] ([id], [Paket]) VALUES (2, N'Kutular')
INSERT [dbo].[paketler] ([id], [Paket]) VALUES (3, N'Kartonlar')
SET IDENTITY_INSERT [dbo].[paketler] OFF
GO
