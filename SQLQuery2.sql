Create database Face;
USE [Face]
GO
/****** Object:  Table [dbo].[contacto]    Script Date: 20/11/2019 12:40:46 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[contacto](
	[IdCon] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Celular] [varchar](50) NULL,
	[Email] [varchar](60) NULL,
	[Direccion] [varchar](80) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Eventos]    Script Date: 20/11/2019 12:40:46 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Eventos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Evento] [nvarchar](500) NULL,
	[Fecha] [datetime] NULL,
 CONSTRAINT [PK_Eventos] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grupo]    Script Date: 20/11/2019 12:40:46 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Grupo](
	[IdGru] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](30) NULL,
	[Asignatura] [varchar](50) NULL,
	[Cuatrimestre] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdGru] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[contacto] ON 
GO
INSERT [dbo].[contacto] ([IdCon], [Nombre], [Celular], [Email], [Direccion]) VALUES (2, N'Nicol', N'123456', N'Romea@gmail.com', N'Direccion')
GO
INSERT [dbo].[contacto] ([IdCon], [Nombre], [Celular], [Email], [Direccion]) VALUES (3, N'Niurlix', N'123456', N'sagrariodiazdecleto@gmail.com', N'Direccion')
GO
INSERT [dbo].[contacto] ([IdCon], [Nombre], [Celular], [Email], [Direccion]) VALUES (4, N'ambar', N'1234567', N'cleto662"', N'Direccion')
GO
SET IDENTITY_INSERT [dbo].[contacto] OFF
GO
SET IDENTITY_INSERT [dbo].[Eventos] ON 
GO
INSERT [dbo].[Eventos] ([ID], [Evento], [Fecha]) VALUES (1, N'Compras', CAST(N'2019-05-02T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Eventos] OFF
GO
SET IDENTITY_INSERT [dbo].[Grupo] ON 
GO
INSERT [dbo].[Grupo] ([IdGru], [Nombre], [Asignatura], [Cuatrimestre]) VALUES (1, N'Niurlix', N'Programacion 3, DCU, Mineria', N'7')
GO
INSERT [dbo].[Grupo] ([IdGru], [Nombre], [Asignatura], [Cuatrimestre]) VALUES (2, N'Bladimir Cleto Diaz', N'Programacion 3, DCU, Mineria, Fisica', N'7')
GO
SET IDENTITY_INSERT [dbo].[Grupo] OFF
GO
