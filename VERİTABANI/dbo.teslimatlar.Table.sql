USE [ProjeDB]
GO
/****** Object:  Table [dbo].[teslimatlar]    Script Date: 1.11.2022 00:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[teslimatlar](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Teslimat] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.teslimatlar] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[teslimatlar] ON 

INSERT [dbo].[teslimatlar] ([id], [Teslimat]) VALUES (1, N' Görevi Ödenmiş Olarak Teslim Edildi')
INSERT [dbo].[teslimatlar] ([id], [Teslimat]) VALUES (2, N'Yerinde Teslim Edildi')
SET IDENTITY_INSERT [dbo].[teslimatlar] OFF
GO
