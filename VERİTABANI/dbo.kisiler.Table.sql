USE [ProjeDB]
GO
/****** Object:  Table [dbo].[kisiler]    Script Date: 1.11.2022 00:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kisiler](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nvarchar](max) NULL,
	[soyad] [nvarchar](max) NULL,
	[email] [nvarchar](max) NULL,
	[modid] [int] NOT NULL,
	[hareketid] [int] NOT NULL,
	[teslimatid] [int] NOT NULL,
	[paketid] [int] NOT NULL,
	[birimid] [int] NOT NULL,
	[uniteid] [int] NOT NULL,
	[paraid] [int] NOT NULL,
	[sehirid] [int] NOT NULL,
 CONSTRAINT [PK_dbo.kisiler] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[kisiler] ON 

INSERT [dbo].[kisiler] ([id], [ad], [soyad], [email], [modid], [hareketid], [teslimatid], [paketid], [birimid], [uniteid], [paraid], [sehirid]) VALUES (4, N'Sadiye Nur', N'Ceylan', N'sadiye@gmail.com', 2, 2, 2, 2, 2, 2, 2, 3)
INSERT [dbo].[kisiler] ([id], [ad], [soyad], [email], [modid], [hareketid], [teslimatid], [paketid], [birimid], [uniteid], [paraid], [sehirid]) VALUES (5, N'mehmet', N'ceylan', N'mehmet@gmail.com', 3, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[kisiler] ([id], [ad], [soyad], [email], [modid], [hareketid], [teslimatid], [paketid], [birimid], [uniteid], [paraid], [sehirid]) VALUES (6, N'yusuf', N'çiftci', N'yusuf@gmail.com', 2, 3, 2, 1, 1, 1, 1, 8)
SET IDENTITY_INSERT [dbo].[kisiler] OFF
GO
ALTER TABLE [dbo].[kisiler]  WITH CHECK ADD  CONSTRAINT [FK_dbo.kisis_dbo.birims_birimid] FOREIGN KEY([birimid])
REFERENCES [dbo].[birimler] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[kisiler] CHECK CONSTRAINT [FK_dbo.kisis_dbo.birims_birimid]
GO
ALTER TABLE [dbo].[kisiler]  WITH CHECK ADD  CONSTRAINT [FK_dbo.kisis_dbo.harekets_hareketid] FOREIGN KEY([hareketid])
REFERENCES [dbo].[hareketler] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[kisiler] CHECK CONSTRAINT [FK_dbo.kisis_dbo.harekets_hareketid]
GO
ALTER TABLE [dbo].[kisiler]  WITH CHECK ADD  CONSTRAINT [FK_dbo.kisis_dbo.mods_modid] FOREIGN KEY([modid])
REFERENCES [dbo].[modlar] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[kisiler] CHECK CONSTRAINT [FK_dbo.kisis_dbo.mods_modid]
GO
ALTER TABLE [dbo].[kisiler]  WITH CHECK ADD  CONSTRAINT [FK_dbo.kisis_dbo.pakets_paketid] FOREIGN KEY([paketid])
REFERENCES [dbo].[paketler] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[kisiler] CHECK CONSTRAINT [FK_dbo.kisis_dbo.pakets_paketid]
GO
ALTER TABLE [dbo].[kisiler]  WITH CHECK ADD  CONSTRAINT [FK_dbo.kisis_dbo.paras_paraid] FOREIGN KEY([paraid])
REFERENCES [dbo].[paralar] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[kisiler] CHECK CONSTRAINT [FK_dbo.kisis_dbo.paras_paraid]
GO
ALTER TABLE [dbo].[kisiler]  WITH CHECK ADD  CONSTRAINT [FK_dbo.kisis_dbo.sehirs_sehirid] FOREIGN KEY([sehirid])
REFERENCES [dbo].[sehirler] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[kisiler] CHECK CONSTRAINT [FK_dbo.kisis_dbo.sehirs_sehirid]
GO
ALTER TABLE [dbo].[kisiler]  WITH CHECK ADD  CONSTRAINT [FK_dbo.kisis_dbo.teslimats_teslimatid] FOREIGN KEY([teslimatid])
REFERENCES [dbo].[teslimatlar] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[kisiler] CHECK CONSTRAINT [FK_dbo.kisis_dbo.teslimats_teslimatid]
GO
ALTER TABLE [dbo].[kisiler]  WITH CHECK ADD  CONSTRAINT [FK_dbo.kisis_dbo.unites_uniteid] FOREIGN KEY([uniteid])
REFERENCES [dbo].[uniteler] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[kisiler] CHECK CONSTRAINT [FK_dbo.kisis_dbo.unites_uniteid]
GO
