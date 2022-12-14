USE [ProjeDB]
GO
/****** Object:  Table [dbo].[paralar]    Script Date: 1.11.2022 00:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[paralar](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Para] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.paralar] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[paralar] ON 

INSERT [dbo].[paralar] ([id], [Para]) VALUES (1, N'USD - ABD Doları')
INSERT [dbo].[paralar] ([id], [Para]) VALUES (2, N'CNY - Çin Yuanı')
INSERT [dbo].[paralar] ([id], [Para]) VALUES (3, N'TL - Türk Lirası')
SET IDENTITY_INSERT [dbo].[paralar] OFF
GO
