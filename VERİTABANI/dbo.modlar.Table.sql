USE [ProjeDB]
GO
/****** Object:  Table [dbo].[modlar]    Script Date: 1.11.2022 00:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[modlar](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Mod] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.modlar] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[modlar] ON 

INSERT [dbo].[modlar] ([id], [Mod]) VALUES (1, N'LCL')
INSERT [dbo].[modlar] ([id], [Mod]) VALUES (2, N'FCL')
INSERT [dbo].[modlar] ([id], [Mod]) VALUES (3, N'AIR')
SET IDENTITY_INSERT [dbo].[modlar] OFF
GO
