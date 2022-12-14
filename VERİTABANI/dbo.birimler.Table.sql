USE [ProjeDB]
GO
/****** Object:  Table [dbo].[birimler]    Script Date: 1.11.2022 00:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[birimler](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Birim] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.birimler] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[birimler] ON 

INSERT [dbo].[birimler] ([id], [Birim]) VALUES (1, N'CM')
INSERT [dbo].[birimler] ([id], [Birim]) VALUES (2, N'IN')
SET IDENTITY_INSERT [dbo].[birimler] OFF
GO
