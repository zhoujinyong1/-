USE [db_ZJY1]
GO
/****** Object:  Table [dbo].[tb_class]    Script Date: 2020/9/22 11:03:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_class](
	[id] [int] IDENTITY(0,1) NOT NULL,
	[name] [varchar](30) NOT NULL,
	[life] [int] NULL,
	[attack] [int] NULL,
	[defense] [int] NULL,
	[experience] [int] NULL,
	[gold] [int] NULL,
	[keyyellow] [int] NULL,
	[keyblue] [int] NULL,
	[keyred] [int] NULL,
	[keyqing] [int] NULL,
	[number] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_game]    Script Date: 2020/9/22 11:03:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_game](
	[id] [int] IDENTITY(0,1) NOT NULL,
	[uid] [int] NOT NULL,
	[number] [int] NOT NULL,
	[lv] [int] NOT NULL,
	[life] [int] NOT NULL,
	[attack] [int] NOT NULL,
	[defense] [int] NOT NULL,
	[experience] [int] NOT NULL,
	[gold] [int] NOT NULL,
	[keyyellow] [int] NOT NULL,
	[keyblue] [int] NOT NULL,
	[keyred] [int] NOT NULL,
	[keyqing] [int] NOT NULL,
	[x] [int] NOT NULL,
	[y] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_map]    Script Date: 2020/9/22 11:03:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_map](
	[id] [int] IDENTITY(0,1) NOT NULL,
	[classx] [int] NOT NULL,
	[classy] [int] NOT NULL,
	[classid] [int] NOT NULL,
	[number] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_user]    Script Date: 2020/9/22 11:03:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_user](
	[id] [int] IDENTITY(0,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[phone] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tb_class] ON 

INSERT [dbo].[tb_class] ([id], [name], [life], [attack], [defense], [experience], [gold], [keyyellow], [keyblue], [keyred], [keyqing], [number]) VALUES (0, N'slime     ', 5, 5, 0, 1, 1, 0, 0, 0, 0, 1)
INSERT [dbo].[tb_class] ([id], [name], [life], [attack], [defense], [experience], [gold], [keyyellow], [keyblue], [keyred], [keyqing], [number]) VALUES (1, N'kulou    ', 10, 7, 0, 5, 3, 0, 0, 0, 0, 1)
INSERT [dbo].[tb_class] ([id], [name], [life], [attack], [defense], [experience], [gold], [keyyellow], [keyblue], [keyred], [keyqing], [number]) VALUES (2, N'jdkulou      ', 15, 9, 5, 10, 5, 0, 0, 0, 0, 1)
INSERT [dbo].[tb_class] ([id], [name], [life], [attack], [defense], [experience], [gold], [keyyellow], [keyblue], [keyred], [keyqing], [number]) VALUES (3, N'sorcerer      ', 15, 9, 5, 10, 5, 0, 0, 0, 0, 1)
INSERT [dbo].[tb_class] ([id], [name], [life], [attack], [defense], [experience], [gold], [keyyellow], [keyblue], [keyred], [keyqing], [number]) VALUES (4, N'blood  ', 30, 0, 0, 0, 0, 0, 0, 0, 0, 1)
INSERT [dbo].[tb_class] ([id], [name], [life], [attack], [defense], [experience], [gold], [keyyellow], [keyblue], [keyred], [keyqing], [number]) VALUES (5, N'shield     ', 0, 0, 10, 0, 0, 0, 0, 0, 0, 1)
INSERT [dbo].[tb_class] ([id], [name], [life], [attack], [defense], [experience], [gold], [keyyellow], [keyblue], [keyred], [keyqing], [number]) VALUES (6, N'sword  ', 0, 10, 0, 0, 0, 0, 0, 0, 0, 1)
INSERT [dbo].[tb_class] ([id], [name], [life], [attack], [defense], [experience], [gold], [keyyellow], [keyblue], [keyred], [keyqing], [number]) VALUES (7, N'keyyellow	', 0, 0, 0, 0, 0, 1, 0, 0, 0, 1)
INSERT [dbo].[tb_class] ([id], [name], [life], [attack], [defense], [experience], [gold], [keyyellow], [keyblue], [keyred], [keyqing], [number]) VALUES (8, N'keyblue		', 0, 0, 0, 0, 0, 0, 1, 0, 0, 1)
INSERT [dbo].[tb_class] ([id], [name], [life], [attack], [defense], [experience], [gold], [keyyellow], [keyblue], [keyred], [keyqing], [number]) VALUES (9, N'keyred		', 0, 0, 0, 0, 0, 0, 0, 1, 0, 1)
INSERT [dbo].[tb_class] ([id], [name], [life], [attack], [defense], [experience], [gold], [keyyellow], [keyblue], [keyred], [keyqing], [number]) VALUES (10, N'keyqing		', 0, 0, 0, 0, 0, 0, 0, 0, 1, 1)
INSERT [dbo].[tb_class] ([id], [name], [life], [attack], [defense], [experience], [gold], [keyyellow], [keyblue], [keyred], [keyqing], [number]) VALUES (11, N'dooryellow', 0, 0, 0, 0, 0, -1, 0, 0, 0, 1)
INSERT [dbo].[tb_class] ([id], [name], [life], [attack], [defense], [experience], [gold], [keyyellow], [keyblue], [keyred], [keyqing], [number]) VALUES (12, N'doorblue', 0, 0, 0, 0, 0, 0, -1, 0, 0, 1)
INSERT [dbo].[tb_class] ([id], [name], [life], [attack], [defense], [experience], [gold], [keyyellow], [keyblue], [keyred], [keyqing], [number]) VALUES (13, N'doorred', 0, 0, 0, 0, 0, 0, 0, -1, 0, 1)
INSERT [dbo].[tb_class] ([id], [name], [life], [attack], [defense], [experience], [gold], [keyyellow], [keyblue], [keyred], [keyqing], [number]) VALUES (14, N'doorqing', 0, 0, 0, 0, 0, 0, 0, 0, -1, 1)
INSERT [dbo].[tb_class] ([id], [name], [life], [attack], [defense], [experience], [gold], [keyyellow], [keyblue], [keyred], [keyqing], [number]) VALUES (15, N'floor', 0, 0, 0, 0, 0, 0, 0, 0, 0, 1)
INSERT [dbo].[tb_class] ([id], [name], [life], [attack], [defense], [experience], [gold], [keyyellow], [keyblue], [keyred], [keyqing], [number]) VALUES (16, N'uplouti', 0, 0, 0, 0, 0, 0, 0, 0, 0, 1)
INSERT [dbo].[tb_class] ([id], [name], [life], [attack], [defense], [experience], [gold], [keyyellow], [keyblue], [keyred], [keyqing], [number]) VALUES (17, N'downlouti', 0, 0, 0, 0, 0, 0, 0, 0, 0, 1)
INSERT [dbo].[tb_class] ([id], [name], [life], [attack], [defense], [experience], [gold], [keyyellow], [keyblue], [keyred], [keyqing], [number]) VALUES (18, N'wall', 0, 0, 0, 0, 0, 0, 0, 0, 0, 1)
INSERT [dbo].[tb_class] ([id], [name], [life], [attack], [defense], [experience], [gold], [keyyellow], [keyblue], [keyred], [keyqing], [number]) VALUES (19, N'yanjiang', 0, 0, 0, 0, 0, 0, 0, 0, 0, 1)
INSERT [dbo].[tb_class] ([id], [name], [life], [attack], [defense], [experience], [gold], [keyyellow], [keyblue], [keyred], [keyqing], [number]) VALUES (20, N'xingguang', 0, 0, 0, 0, 0, 0, 0, 0, 0, 1)
SET IDENTITY_INSERT [dbo].[tb_class] OFF
SET IDENTITY_INSERT [dbo].[tb_game] ON 

INSERT [dbo].[tb_game] ([id], [uid], [number], [lv], [life], [attack], [defense], [experience], [gold], [keyyellow], [keyblue], [keyred], [keyqing], [x], [y]) VALUES (5, 1006, 1, 1, 100, 5, 5, 0, 0, 0, 0, 0, 0, 1, 1)
INSERT [dbo].[tb_game] ([id], [uid], [number], [lv], [life], [attack], [defense], [experience], [gold], [keyyellow], [keyblue], [keyred], [keyqing], [x], [y]) VALUES (6, 1007, 1, 1, 100, 5, 5, 0, 0, 0, 0, 0, 0, 1, 1)
SET IDENTITY_INSERT [dbo].[tb_game] OFF
SET IDENTITY_INSERT [dbo].[tb_map] ON 

INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (0, 8, 3, 0, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (1, 11, 6, 0, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (2, 6, 3, 1, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (3, 11, 3, 1, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (4, 3, 4, 2, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (5, 7, 6, 2, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (6, 2, 1, 3, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (7, 11, 10, 3, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (8, 3, 1, 4, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (9, 8, 1, 4, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (10, 6, 6, 4, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (11, 10, 7, 4, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (12, 6, 7, 5, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (13, 4, 2, 6, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (14, 3, 2, 7, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (15, 4, 1, 7, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (16, 11, 5, 7, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (17, 11, 9, 8, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (18, 9, 2, 11, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (19, 9, 9, 11, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (20, 7, 7, 12, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (21, 9, 7, 12, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (22, 5, 2, 13, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (23, 11, 8, 13, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (25, 6, 1, 5, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (26, 11, 4, 5, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (28, 10, 4, 4, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (32, 1, 1, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (33, 1, 2, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (34, 1, 3, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (35, 1, 4, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (36, 1, 5, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (37, 1, 6, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (38, 1, 7, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (39, 1, 9, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (40, 1, 10, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (80, 8, 11, 16, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (81, 6, 11, 17, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (295, 1, 8, 16, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (41, 1, 11, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (42, 2, 4, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (43, 2, 5, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (44, 2, 7, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (45, 2, 9, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (46, 3, 7, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (47, 3, 9, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (48, 3, 10, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (49, 3, 11, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (50, 4, 4, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (51, 4, 5, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (52, 4, 6, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (53, 4, 7, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (54, 4, 8, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (55, 4, 9, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (56, 4, 11, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (57, 5, 4, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (58, 5, 9, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (59, 5, 11, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (60, 6, 2, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (61, 6, 4, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (62, 6, 9, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (63, 7, 4, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (64, 8, 2, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (65, 8, 4, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (66, 8, 5, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (67, 8, 6, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (68, 8, 7, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (69, 8, 8, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (70, 8, 9, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (71, 8, 10, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (72, 10, 2, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (73, 10, 5, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (74, 10, 9, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (75, 10, 11, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (76, 11, 1, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (77, 11, 2, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (78, 11, 7, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (79, 11, 11, 15, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (296, 1, 8, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (297, 2, 2, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (298, 2, 3, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (299, 2, 6, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (300, 2, 8, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (301, 2, 10, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (302, 2, 11, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (303, 3, 3, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (304, 3, 5, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (305, 3, 6, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (306, 3, 8, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (307, 4, 3, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (308, 4, 10, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (309, 5, 1, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (310, 5, 3, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (311, 5, 5, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (312, 5, 6, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (313, 5, 7, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (314, 5, 8, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (315, 5, 10, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (316, 6, 5, 18, 1)
GO
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (317, 6, 8, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (318, 6, 10, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (319, 7, 1, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (320, 7, 2, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (321, 7, 3, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (322, 7, 5, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (323, 7, 8, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (324, 7, 9, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (325, 7, 10, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (326, 7, 11, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (327, 9, 1, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (328, 9, 3, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (329, 9, 4, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (330, 9, 5, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (331, 9, 6, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (332, 9, 8, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (333, 9, 10, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (334, 9, 11, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (335, 10, 1, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (336, 10, 3, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (337, 10, 6, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (338, 10, 8, 18, 1)
INSERT [dbo].[tb_map] ([id], [classx], [classy], [classid], [number]) VALUES (339, 10, 10, 18, 1)
SET IDENTITY_INSERT [dbo].[tb_map] OFF
SET IDENTITY_INSERT [dbo].[tb_user] ON 

INSERT [dbo].[tb_user] ([id], [name], [password], [phone]) VALUES (1006, N'1', N'1', N'1')
INSERT [dbo].[tb_user] ([id], [name], [password], [phone]) VALUES (1007, N'2', N'2', N'2')
SET IDENTITY_INSERT [dbo].[tb_user] OFF
ALTER TABLE [dbo].[tb_game] ADD  CONSTRAINT [DF_tb_game_number]  DEFAULT ((1)) FOR [number]
GO
ALTER TABLE [dbo].[tb_game] ADD  CONSTRAINT [DF_tb_game_lv]  DEFAULT ((1)) FOR [lv]
GO
ALTER TABLE [dbo].[tb_game] ADD  CONSTRAINT [DF_tb_game_life]  DEFAULT ((100)) FOR [life]
GO
ALTER TABLE [dbo].[tb_game] ADD  CONSTRAINT [DF_tb_game_attack]  DEFAULT ((5)) FOR [attack]
GO
ALTER TABLE [dbo].[tb_game] ADD  CONSTRAINT [DF_tb_game_defense]  DEFAULT ((5)) FOR [defense]
GO
ALTER TABLE [dbo].[tb_game] ADD  CONSTRAINT [DF_tb_game_experience]  DEFAULT ((0)) FOR [experience]
GO
ALTER TABLE [dbo].[tb_game] ADD  CONSTRAINT [DF_tb_game_gold]  DEFAULT ((0)) FOR [gold]
GO
ALTER TABLE [dbo].[tb_game] ADD  CONSTRAINT [DF_tb_game_keyyellow]  DEFAULT ((0)) FOR [keyyellow]
GO
ALTER TABLE [dbo].[tb_game] ADD  CONSTRAINT [DF_tb_game_keyblue]  DEFAULT ((0)) FOR [keyblue]
GO
ALTER TABLE [dbo].[tb_game] ADD  CONSTRAINT [DF_tb_game_keyred]  DEFAULT ((0)) FOR [keyred]
GO
ALTER TABLE [dbo].[tb_game] ADD  CONSTRAINT [DF_tb_game_keyqing]  DEFAULT ((0)) FOR [keyqing]
GO
ALTER TABLE [dbo].[tb_game] ADD  CONSTRAINT [DF_tb_game_x]  DEFAULT ((0)) FOR [x]
GO
ALTER TABLE [dbo].[tb_game] ADD  CONSTRAINT [DF_tb_game_y]  DEFAULT ((0)) FOR [y]
GO
