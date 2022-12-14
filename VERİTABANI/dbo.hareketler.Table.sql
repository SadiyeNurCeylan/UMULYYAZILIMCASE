USE [ProjeDB]
GO
/****** Object:  Table [dbo].[hareketler]    Script Date: 1.11.2022 00:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hareketler](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Hareket] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.hareketler] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[hareketler] ON 

INSERT [dbo].[hareketler] ([id], [Hareket]) VALUES (1, N'Kapıdan Kapıya')
INSERT [dbo].[hareketler] ([id], [Hareket]) VALUES (2, N'Limandan Kapıya')
INSERT [dbo].[hareketler] ([id], [Hareket]) VALUES (3, N'Kapıdan Limana')
INSERT [dbo].[hareketler] ([id], [Hareket]) VALUES (4, N'Limandan Limana')
SET IDENTITY_INSERT [dbo].[hareketler] OFF
GO
