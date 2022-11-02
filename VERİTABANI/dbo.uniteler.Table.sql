USE [ProjeDB]
GO
/****** Object:  Table [dbo].[uniteler]    Script Date: 1.11.2022 00:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[uniteler](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Unite] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.uniteler] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[uniteler] ON 

INSERT [dbo].[uniteler] ([id], [Unite]) VALUES (1, N'KG')
INSERT [dbo].[uniteler] ([id], [Unite]) VALUES (2, N'LB')
SET IDENTITY_INSERT [dbo].[uniteler] OFF
GO
