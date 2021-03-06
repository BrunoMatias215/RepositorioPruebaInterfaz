USE [Che Miranda]
GO
/****** Object:  Table [dbo].[Cadete]    Script Date: 26/11/2020 12:45:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cadete](
	[idcadete] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[apellido] [varchar](20) NOT NULL,
	[telefono] [int] NOT NULL,
	[licencia] [int] NULL,
 CONSTRAINT [PK_Cadete] PRIMARY KEY CLUSTERED 
(
	[idcadete] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Caja]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Caja](
	[idcaja] [int] IDENTITY(1,1) NOT NULL,
	[idusuario] [int] NOT NULL,
	[efectivocaja] [int] NOT NULL,
	[postnetcaja] [int] NOT NULL,
	[fechayhora] [datetime] NOT NULL,
	[efectivoinicial] [int] NOT NULL,
	[estado] [int] NOT NULL,
 CONSTRAINT [PK_Caja] PRIMARY KEY CLUSTERED 
(
	[idcaja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[idcliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NULL,
	[apellido] [varchar](20) NULL,
	[telefono] [varchar](50) NULL,
	[direccion] [varchar](50) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[idcliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallePedido]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallePedido](
	[iddetallepedido] [int] IDENTITY(1,1) NOT NULL,
	[idproducto] [int] NOT NULL,
	[idpedido] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precioventa] [int] NOT NULL,
 CONSTRAINT [PK__DetalleP__47D240BD3F466844] PRIMARY KEY CLUSTERED 
(
	[idpedido] ASC,
	[iddetallepedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoCategoria]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoCategoria](
	[idestadocategoria] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_EstadoCategoria] PRIMARY KEY CLUSTERED 
(
	[idestadocategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FormaPago]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FormaPago](
	[idformadepago] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](20) NOT NULL,
 CONSTRAINT [PK_FormaPago] PRIMARY KEY CLUSTERED 
(
	[idformadepago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedido]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedido](
	[idpedido] [int] IDENTITY(1,1) NOT NULL,
	[idformadepago] [int] NOT NULL,
	[idcliente] [int] NOT NULL,
	[idusuario] [int] NOT NULL,
	[fechayhora] [datetime] NOT NULL,
	[observaciones] [varchar](100) NULL,
	[idcadete] [int] NULL,
	[idestadocategoria] [int] NOT NULL,
	[total] [int] NULL,
 CONSTRAINT [PK_Pedido] PRIMARY KEY CLUSTERED 
(
	[idpedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[idproducto] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[idproductocategoria] [int] NOT NULL,
	[precio] [int] NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[idproducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductoCategoria]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductoCategoria](
	[idproductocategoria] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ProductoCategoria] PRIMARY KEY CLUSTERED 
(
	[idproductocategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[idusuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[apellido] [varchar](20) NOT NULL,
	[CUIL] [int] NOT NULL,
	[contraseña] [varchar](20) NOT NULL,
	[fechadecontratacion] [date] NOT NULL,
	[idcategoriausuario] [int] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[idusuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuarioCategoria]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioCategoria](
	[idcategoriausuario] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](20) NOT NULL,
 CONSTRAINT [PK_UsuarioCategoria] PRIMARY KEY CLUSTERED 
(
	[idcategoriausuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cadete] ON 

INSERT [dbo].[Cadete] ([idcadete], [nombre], [apellido], [telefono], [licencia]) VALUES (1, N'Sin Cadete', N'Sin Cadete', 49435828, 12345)
INSERT [dbo].[Cadete] ([idcadete], [nombre], [apellido], [telefono], [licencia]) VALUES (3, N'Osvaldo', N'Mateo', 49537218, 12345)
INSERT [dbo].[Cadete] ([idcadete], [nombre], [apellido], [telefono], [licencia]) VALUES (4, N'Santiago', N'Garcia', 49186712, 12345)
INSERT [dbo].[Cadete] ([idcadete], [nombre], [apellido], [telefono], [licencia]) VALUES (5, N'Gonzalo', N'Pérez', 49576328, 12345)
SET IDENTITY_INSERT [dbo].[Cadete] OFF
GO
SET IDENTITY_INSERT [dbo].[Caja] ON 

INSERT [dbo].[Caja] ([idcaja], [idusuario], [efectivocaja], [postnetcaja], [fechayhora], [efectivoinicial], [estado]) VALUES (1, 1, 150, 0, CAST(N'2020-11-20T22:36:49.513' AS DateTime), 150, 1)
INSERT [dbo].[Caja] ([idcaja], [idusuario], [efectivocaja], [postnetcaja], [fechayhora], [efectivoinicial], [estado]) VALUES (2, 2, 100, 0, CAST(N'2020-11-22T00:13:05.080' AS DateTime), 100, 1)
SET IDENTITY_INSERT [dbo].[Caja] OFF
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([idcliente], [nombre], [apellido], [telefono], [direccion]) VALUES (1, N'Ricardo', N'Guzmán', N'49256718', N'Av. Rivadavia 2000')
INSERT [dbo].[Cliente] ([idcliente], [nombre], [apellido], [telefono], [direccion]) VALUES (2, N'Pablo', N'Hernández', N'48321890', N'Av. Corrientes 500')
INSERT [dbo].[Cliente] ([idcliente], [nombre], [apellido], [telefono], [direccion]) VALUES (3, N'Javier', N'Pérez', N'49521927', N'Formosa 235')
INSERT [dbo].[Cliente] ([idcliente], [nombre], [apellido], [telefono], [direccion]) VALUES (4, N'Carlos', N'Medina', N'49523743', N'Av. Callao 2730')
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[DetallePedido] ON 

INSERT [dbo].[DetallePedido] ([iddetallepedido], [idproducto], [idpedido], [cantidad], [precioventa]) VALUES (40, 1, 20, 1, 240)
INSERT [dbo].[DetallePedido] ([iddetallepedido], [idproducto], [idpedido], [cantidad], [precioventa]) VALUES (41, 69, 20, 1, 170)
INSERT [dbo].[DetallePedido] ([iddetallepedido], [idproducto], [idpedido], [cantidad], [precioventa]) VALUES (42, 1, 21, 2, 480)
INSERT [dbo].[DetallePedido] ([iddetallepedido], [idproducto], [idpedido], [cantidad], [precioventa]) VALUES (43, 68, 21, 1, 90)
INSERT [dbo].[DetallePedido] ([iddetallepedido], [idproducto], [idpedido], [cantidad], [precioventa]) VALUES (44, 1, 22, 1, 240)
INSERT [dbo].[DetallePedido] ([iddetallepedido], [idproducto], [idpedido], [cantidad], [precioventa]) VALUES (45, 68, 22, 1, 90)
INSERT [dbo].[DetallePedido] ([iddetallepedido], [idproducto], [idpedido], [cantidad], [precioventa]) VALUES (46, 1, 23, 1, 240)
INSERT [dbo].[DetallePedido] ([iddetallepedido], [idproducto], [idpedido], [cantidad], [precioventa]) VALUES (47, 68, 23, 1, 90)
INSERT [dbo].[DetallePedido] ([iddetallepedido], [idproducto], [idpedido], [cantidad], [precioventa]) VALUES (48, 1, 24, 1, 240)
INSERT [dbo].[DetallePedido] ([iddetallepedido], [idproducto], [idpedido], [cantidad], [precioventa]) VALUES (49, 68, 24, 1, 90)
INSERT [dbo].[DetallePedido] ([iddetallepedido], [idproducto], [idpedido], [cantidad], [precioventa]) VALUES (50, 1, 25, 1, 240)
INSERT [dbo].[DetallePedido] ([iddetallepedido], [idproducto], [idpedido], [cantidad], [precioventa]) VALUES (51, 69, 25, 2, 340)
INSERT [dbo].[DetallePedido] ([iddetallepedido], [idproducto], [idpedido], [cantidad], [precioventa]) VALUES (52, 72, 26, 1, 360)
INSERT [dbo].[DetallePedido] ([iddetallepedido], [idproducto], [idpedido], [cantidad], [precioventa]) VALUES (53, 147, 26, 2, 1260)
INSERT [dbo].[DetallePedido] ([iddetallepedido], [idproducto], [idpedido], [cantidad], [precioventa]) VALUES (54, 1, 27, 1, 240)
INSERT [dbo].[DetallePedido] ([iddetallepedido], [idproducto], [idpedido], [cantidad], [precioventa]) VALUES (55, 70, 27, 2, 600)
INSERT [dbo].[DetallePedido] ([iddetallepedido], [idproducto], [idpedido], [cantidad], [precioventa]) VALUES (56, 1, 28, 1, 240)
INSERT [dbo].[DetallePedido] ([iddetallepedido], [idproducto], [idpedido], [cantidad], [precioventa]) VALUES (57, 193, 28, 1, 55)
INSERT [dbo].[DetallePedido] ([iddetallepedido], [idproducto], [idpedido], [cantidad], [precioventa]) VALUES (58, 1, 29, 1, 240)
INSERT [dbo].[DetallePedido] ([iddetallepedido], [idproducto], [idpedido], [cantidad], [precioventa]) VALUES (59, 1, 29, 1, 240)
INSERT [dbo].[DetallePedido] ([iddetallepedido], [idproducto], [idpedido], [cantidad], [precioventa]) VALUES (60, 1, 30, 1, 240)
INSERT [dbo].[DetallePedido] ([iddetallepedido], [idproducto], [idpedido], [cantidad], [precioventa]) VALUES (61, 1, 31, 1, 240)
INSERT [dbo].[DetallePedido] ([iddetallepedido], [idproducto], [idpedido], [cantidad], [precioventa]) VALUES (62, 1, 32, 1, 240)
INSERT [dbo].[DetallePedido] ([iddetallepedido], [idproducto], [idpedido], [cantidad], [precioventa]) VALUES (63, 193, 32, 1, 55)
INSERT [dbo].[DetallePedido] ([iddetallepedido], [idproducto], [idpedido], [cantidad], [precioventa]) VALUES (64, 1, 33, 1, 240)
SET IDENTITY_INSERT [dbo].[DetallePedido] OFF
GO
SET IDENTITY_INSERT [dbo].[EstadoCategoria] ON 

INSERT [dbo].[EstadoCategoria] ([idestadocategoria], [descripcion]) VALUES (1, N'Inicializado')
INSERT [dbo].[EstadoCategoria] ([idestadocategoria], [descripcion]) VALUES (2, N'Delivery')
INSERT [dbo].[EstadoCategoria] ([idestadocategoria], [descripcion]) VALUES (3, N'Cancelado')
INSERT [dbo].[EstadoCategoria] ([idestadocategoria], [descripcion]) VALUES (4, N'Finalizado')
SET IDENTITY_INSERT [dbo].[EstadoCategoria] OFF
GO
SET IDENTITY_INSERT [dbo].[FormaPago] ON 

INSERT [dbo].[FormaPago] ([idformadepago], [descripcion]) VALUES (1, N'Efectivo')
INSERT [dbo].[FormaPago] ([idformadepago], [descripcion]) VALUES (2, N'Tarjeta de Crédito')
INSERT [dbo].[FormaPago] ([idformadepago], [descripcion]) VALUES (3, N'Tarjeta de Débito')
SET IDENTITY_INSERT [dbo].[FormaPago] OFF
GO
SET IDENTITY_INSERT [dbo].[Pedido] ON 

INSERT [dbo].[Pedido] ([idpedido], [idformadepago], [idcliente], [idusuario], [fechayhora], [observaciones], [idcadete], [idestadocategoria], [total]) VALUES (20, 1, 1, 2, CAST(N'2020-11-25T21:00:45.660' AS DateTime), N'', 1, 1, 410)
INSERT [dbo].[Pedido] ([idpedido], [idformadepago], [idcliente], [idusuario], [fechayhora], [observaciones], [idcadete], [idestadocategoria], [total]) VALUES (21, 1, 1, 2, CAST(N'2020-11-25T21:20:24.820' AS DateTime), N'', 1, 1, 570)
INSERT [dbo].[Pedido] ([idpedido], [idformadepago], [idcliente], [idusuario], [fechayhora], [observaciones], [idcadete], [idestadocategoria], [total]) VALUES (22, 1, 1, 2, CAST(N'2020-11-25T21:31:21.963' AS DateTime), N'', 1, 1, 330)
INSERT [dbo].[Pedido] ([idpedido], [idformadepago], [idcliente], [idusuario], [fechayhora], [observaciones], [idcadete], [idestadocategoria], [total]) VALUES (23, 1, 1, 2, CAST(N'2020-11-25T21:35:42.740' AS DateTime), N'', 1, 1, 330)
INSERT [dbo].[Pedido] ([idpedido], [idformadepago], [idcliente], [idusuario], [fechayhora], [observaciones], [idcadete], [idestadocategoria], [total]) VALUES (24, 1, 1, 2, CAST(N'2020-11-25T21:42:16.263' AS DateTime), N'', 1, 1, 330)
INSERT [dbo].[Pedido] ([idpedido], [idformadepago], [idcliente], [idusuario], [fechayhora], [observaciones], [idcadete], [idestadocategoria], [total]) VALUES (25, 1, 1, 2, CAST(N'2020-11-25T21:57:59.493' AS DateTime), N'', 1, 1, 580)
INSERT [dbo].[Pedido] ([idpedido], [idformadepago], [idcliente], [idusuario], [fechayhora], [observaciones], [idcadete], [idestadocategoria], [total]) VALUES (26, 1, 1, 2, CAST(N'2020-11-25T21:59:48.550' AS DateTime), N'', 1, 1, 1620)
INSERT [dbo].[Pedido] ([idpedido], [idformadepago], [idcliente], [idusuario], [fechayhora], [observaciones], [idcadete], [idestadocategoria], [total]) VALUES (27, 1, 1, 2, CAST(N'2020-11-25T22:19:37.617' AS DateTime), N'', 1, 1, 840)
INSERT [dbo].[Pedido] ([idpedido], [idformadepago], [idcliente], [idusuario], [fechayhora], [observaciones], [idcadete], [idestadocategoria], [total]) VALUES (28, 1, 1, 2, CAST(N'2020-11-25T22:22:35.710' AS DateTime), N'', 1, 1, 295)
INSERT [dbo].[Pedido] ([idpedido], [idformadepago], [idcliente], [idusuario], [fechayhora], [observaciones], [idcadete], [idestadocategoria], [total]) VALUES (29, 1, 1, 2, CAST(N'2020-11-25T22:25:48.000' AS DateTime), N'', 1, 1, 240)
INSERT [dbo].[Pedido] ([idpedido], [idformadepago], [idcliente], [idusuario], [fechayhora], [observaciones], [idcadete], [idestadocategoria], [total]) VALUES (30, 1, 1, 2, CAST(N'2020-11-25T22:28:01.343' AS DateTime), N'', 1, 1, 240)
INSERT [dbo].[Pedido] ([idpedido], [idformadepago], [idcliente], [idusuario], [fechayhora], [observaciones], [idcadete], [idestadocategoria], [total]) VALUES (31, 1, 1, 2, CAST(N'2020-11-25T22:28:44.223' AS DateTime), N'', 1, 1, 240)
INSERT [dbo].[Pedido] ([idpedido], [idformadepago], [idcliente], [idusuario], [fechayhora], [observaciones], [idcadete], [idestadocategoria], [total]) VALUES (32, 1, 1, 2, CAST(N'2020-11-25T22:30:41.927' AS DateTime), N'', 1, 1, 295)
INSERT [dbo].[Pedido] ([idpedido], [idformadepago], [idcliente], [idusuario], [fechayhora], [observaciones], [idcadete], [idestadocategoria], [total]) VALUES (33, 1, 1, 2, CAST(N'2020-11-25T22:36:05.130' AS DateTime), N'', 1, 1, 240)
SET IDENTITY_INSERT [dbo].[Pedido] OFF
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (1, N'Ensalada Rusa', 1, 240)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (2, N'Matambre con Ensalada Rusa', 1, 340)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (3, N'Mayonesa de Atún', 1, 350)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (4, N'Mayonesa de Ave', 1, 340)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (5, N'Salpicón de Ave', 1, 320)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (6, N'Salpicón de Atún', 1, 360)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (7, N'Tomate Relleno con Atún', 1, 360)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (8, N'Jamón Cocido con Rusa', 1, 290)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (9, N'Jamón Crudo con Rusa', 1, 360)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (10, N'Milanesa F o P', 4, 295)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (11, N'Milanesa Napolitana F o P', 4, 350)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (12, N'Milanesa a la Fugazzeta F o P', 4, 350)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (15, N'Milanesa a la Suiza F', 4, 350)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (16, N'Milanesa Siciliana F', 4, 370)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (18, N'Suprema F o P', 5, 320)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (19, N'Suprema Napolitana F o P', 5, 370)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (20, N'Suprema a la Fugazzeta F', 5, 370)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (21, N'Suprema a la Suiza F', 5, 370)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (22, N'Suprema a la Siciliana F', 5, 390)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (23, N'Matambrito F', 6, 330)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (24, N'M. a la Pizza F', 6, 380)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (25, N'M. a la Portuguesa pNatural', 6, 380)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (26, N'M. a la Salsa de Verdeo pNoiset', 6, 380)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (27, N'Omellete al Gusto', 2, 290)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (28, N'Omellete Mixto', 2, 340)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (30, N'Omellete al Champignon', 2, 370)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (31, N'Omllete al Roquefort', 2, 370)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (32, N'Porción F o P', 8, 200)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (33, N'Guarnición F o P', 8, 120)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (34, N'Pollo 1/4 al Horno pHorno', 9, 280)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (35, N'P. 1/4 a la Portuguesa P', 9, 350)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (36, N'P. 1/4 al Ajillo pEspañolas', 9, 360)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (37, N'P. 1/4 a la Calabresa pEspañolas', 9, 360)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (38, N'P. 1/4 al Verdeo pNoiset', 9, 360)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (39, N'Filet de Merluza F o P', 11, 330)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (40, N'1/2 Bife de Chorizo F o P', 10, 395)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (41, N'Bife de Chorizo F o P', 10, 480)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (42, N'1/2 Bife de Lomo F o P', 10, 420)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (43, N'Bife de Lomo F o P', 10, 490)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (44, N'Asado de Tira F', 10, 360)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (45, N'Bife de Costilla F o P', 10, 290)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (46, N'Costillas de Cerdo F ', 10, 330)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (47, N'Costillas de Cerdo a la Riojana', 10, 510)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (48, N'1/4 de Pollo Deshuesado F o P', 10, 295)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (49, N'Hamburguesa F o P', 10, 350)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (51, N'Ensalada un Gusto', 12, 140)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (52, N'Ensalada Mixta', 12, 170)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (53, N'Ensalada Completa', 12, 270)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (54, N'Ensalada Waldorf', 13, 310)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (55, N'Ensalada Primavera', 13, 310)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (56, N'Ensalada Parisiens', 13, 370)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (57, N'Ensalada Caferatta', 13, 370)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (58, N'Ensalada Che Miranda', 13, 360)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (59, N'Flan Casero', 25, 100)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (60, N'Budín de Pan Casero', 25, 100)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (61, N'Ensalada de Frutas', 25, 140)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (62, N'Cerezas al Marrasquino', 25, 140)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (63, N'Duraznos en Almibar', 25, 140)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (64, N'Ananá al Almibar', 25, 140)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (65, N'Queso y Dulce', 25, 140)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (66, N'Banana con Crema', 25, 140)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (67, N'Extra Crema o DL', 25, 70)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (68, N'Cerveza Lata 600 cc', 24, 90)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (69, N'Gaseosa 1,5L', 24, 170)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (70, N'Vino Blanco o Tinto 3/4L', 24, 300)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (71, N'Botellón de Cerveza Artezanal 1,9L', 24, 0)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (72, N'P. Muzzarella Grande', 14, 360)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (73, N'P. Pizzaiola Grande', 14, 350)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (74, N'P. Anchoas Grande', 14, 390)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (75, N'P. Mixta Grande', 14, 390)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (76, N'P. Muzzarella Chica', 14, 300)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (77, N'P. Pizzaiola Chica', 14, 300)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (78, N'P. Anchoas Chica', 14, 340)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (79, N'P. Mixta Chica', 14, 340)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (82, N'P. Espinaca Grande', 15, 480)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (83, N'P. Che Miranda Grande', 15, 620)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (86, N'P. Aviñon Grande', 15, 490)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (87, N'P. Alcapone Grande', 15, 550)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (88, N'P. Bologneza Grande', 15, 490)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (89, N'P. Trento Grande', 15, 490)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (90, N'P. Burdeos Grande', 15, 540)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (91, N'P. Calabresa Grande', 15, 480)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (92, N'P. Capri Grande', 15, 520)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (93, N'P. Chamberry Grande', 15, 510)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (94, N'P. Génova Grande', 15, 500)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (95, N'P. Lion Grande', 15, 520)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (96, N'P. Espinaca Chica', 15, 430)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (97, N'P. Che Miranda Chica', 15, 510)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (98, N'P. Aviñon Chica', 15, 440)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (99, N'P. Alcapone Chica', 15, 500)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (100, N'P. Bologneza Chica', 15, 440)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (101, N'P. Trento Chica', 15, 440)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (102, N'P. Burdeos Chica', 15, 460)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (103, N'P. Calabresa Chica', 15, 430)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (105, N'P. Capri Chica', 15, 470)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (106, N'P. Chamberry Chica', 15, 460)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (107, N'P. Génova Chica', 15, 450)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (108, N'P. Lion Chica', 15, 470)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (109, N'P. Linoge Grande', 16, 490)
GO
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (110, N'P. Floresta Grande', 16, 510)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (111, N'P. Marcella Grande', 16, 520)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (112, N'P. Milán Grande', 16, 480)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (114, N'P. Murcia Grande', 16, 520)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (115, N'P. Napolitana Grande', 16, 480)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (116, N'P. Parisina Grande', 16, 490)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (117, N'P. Picadillo de Oro Grande', 16, 510)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (118, N'P. Romana Grande', 16, 510)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (119, N'P. Salerno Grande', 16, 490)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (120, N'P. Tolemans Grande', 16, 510)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (121, N'P. Verona Grande', 16, 470)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (122, N'P. Linoge Chica', 16, 440)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (123, N'P. Floresta Chica', 16, 460)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (124, N'P. Marcella Chica', 16, 470)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (125, N'P. Milán Chica', 16, 430)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (126, N'P. Murcia Chica', 16, 470)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (127, N'P. Napolitana Chica', 16, 430)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (128, N'P. Parisina Chica', 16, 440)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (129, N'P. Picadillo de Oro Chica', 16, 460)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (130, N'P. Romana Chica', 16, 460)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (131, N'P. Salerno Chica', 16, 440)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (132, N'P. Tolemans Chica', 16, 460)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (133, N'P. Verona Chica', 16, 430)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (134, N'Fugazza (Ceb, Aceit. V, Oreg) Grande', 17, 360)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (135, N'Fugazza (Muzza, Aceit. V, Oreg) Grande', 17, 400)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (136, N'Fugazza (Muzza, Roque, Aceit. V) Grande', 17, 430)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (138, N'Fugazza (Morr, Muzza, Roque, Aceit. V) Grande', 17, 450)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (139, N'Fugazza (Ceb, Aceit. V, Oreg) Chica', 17, 300)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (141, N'Fugazza (Muzza, Aceit. V, Oreg) Chica', 17, 350)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (142, N'Fugazza (Muzza, Roque, Aceit. V) Chica', 17, 380)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (143, N'Fugazza (Morr, Muzza, Roque, Aceit. V) Chica', 17, 400)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (144, N'Fugazzeta (Ceb, Oreg, Queso) Grande', 18, 570)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (146, N'Fugazzeta (Jamón) Grande', 18, 600)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (147, N'Fugazzeta (Jamón, Morrón) Grande', 18, 630)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (148, N'Fugazzeta (Calabresa) Grande', 18, 600)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (149, N'Fugazzeta (Roquefort) Grande', 18, 600)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (150, N'Fugazzeta (Roquefort y Morrón) Grande', 18, 630)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (151, N'Fugazzeta (Ceb, Oreg, Queso) Chica', 18, 520)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (152, N'Fugazzeta (Jamón) Chica', 18, 550)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (153, N'Fugazzeta (Jamón, Morrón) Chica', 18, 580)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (154, N'Fugazzeta (Calabresa) Chica', 18, 550)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (155, N'Fugazzeta (Roquefort) Chica', 18, 550)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (156, N'Fugazzeta (Roquefort y Morrón) Chica', 18, 580)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (158, N'Calzón Alcapone Grande', 19, 590)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (159, N'Calzón Roquefort Grande', 19, 550)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (160, N'Calzón Champignon Grande', 19, 550)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (161, N'Calzón Calabres Grande', 19, 550)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (162, N'Calzón Genovés Grande', 19, 550)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (163, N'Calzón Cebolla Grande', 19, 550)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (164, N'Calzón Milán Grande', 19, 530)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (165, N'Calzón Napolitano Grande', 19, 560)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (166, N'Calzón Alcapone Chico', 19, 540)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (167, N'Calzón Roquefort Chico', 19, 500)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (168, N'Calzón Champignon Chico', 19, 500)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (169, N'Calzón Calabres Chico', 19, 500)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (170, N'Calzón Genovés Chico', 19, 500)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (171, N'Calzón Cebolla Chico', 19, 500)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (172, N'Calzón Milán Chico', 19, 480)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (173, N'Calzón Napolitano Chico', 19, 510)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (174, N'Pizza Caprés Grande', 20, 510)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (176, N'Pizza Siciliana Grande', 20, 520)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (177, N'Pizza Viamonteza Grande', 20, 490)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (179, N'Pizza Pizzicato Grande', 20, 520)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (181, N'Pizza Rusticana Grande', 20, 540)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (182, N'Pizza Caprés Chica', 20, 460)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (185, N'Pizza Siciliana Chica', 20, 470)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (186, N'Pizza Viamonteza Chica', 20, 440)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (188, N'Pizza Pizzicato Chica', 20, 470)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (191, N'Pizza Rusticana Chica', 20, 490)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (193, N'Empanada de Carne', 21, 55)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (194, N'Empanada de Carne CC', 21, 55)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (197, N'Empanada de Pollo', 21, 55)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (200, N'Empanada de Humita', 21, 55)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (202, N'Empanada de Jamón y Queso', 21, 55)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (204, N'Empanada de Cebolla y Queso', 21, 55)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (206, N'Empanada de Verdura y Queso', 21, 55)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (208, N'Empanada de Roquefort y Apio', 21, 55)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (209, N'Empanada de Caprece', 21, 55)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (211, N'Docena de Empanadas', 21, 660)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (213, N'Sandwich Hamburguesa', 22, 220)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (215, N'S.Hambur de Lechuga y Tomate', 22, 250)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (217, N'S.Hambur de Lechuga, Tomate, J y Q', 22, 280)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (218, N'Sandwich de Milanesa', 22, 260)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (220, N'S. Milanesa de Lechuga y Tomate', 22, 270)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (223, N'S. Milanesa de Lechuga, Tomate, J y Q', 22, 290)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (225, N'Sandwich de Lomito', 22, 290)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (226, N'S. Lomito con Lechuga y Tomate', 22, 310)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (228, N'S. Lomito con Lechuga, Tomate, J y Q', 22, 350)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (230, N'Fritas Adicional', 22, 60)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (232, N'Canelones de V y P con Salsa', 23, 330)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (233, N'Ñoquis SR o SB', 23, 290)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (234, N'Tallarines SR o SB', 23, 290)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (235, N'Ravioles de Ricota SR o SB', 23, 340)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (236, N'Ravioles de Verdura SR o SB', 23, 340)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (239, N'Sorrentinos de Jamón y Muzzarella SR o SB', 23, 380)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (240, N'Salsa Bognolesa', 23, 100)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (243, N'Salsa Escarparo', 23, 100)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (244, N'Salsa Parissien', 23, 100)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (246, N'Guarnición de Estofado de Pollo', 23, 120)
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (247, N'G. de Estofado de Carne', 23, 120)
GO
INSERT [dbo].[Producto] ([idproducto], [descripcion], [idproductocategoria], [precio]) VALUES (249, N'Porcíon de Estofado de Carne', 23, 190)
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductoCategoria] ON 

INSERT [dbo].[ProductoCategoria] ([idproductocategoria], [descripcion]) VALUES (1, N'Entradas')
INSERT [dbo].[ProductoCategoria] ([idproductocategoria], [descripcion]) VALUES (2, N'Omellete')
INSERT [dbo].[ProductoCategoria] ([idproductocategoria], [descripcion]) VALUES (3, N'Tortillas')
INSERT [dbo].[ProductoCategoria] ([idproductocategoria], [descripcion]) VALUES (4, N'Milanesas')
INSERT [dbo].[ProductoCategoria] ([idproductocategoria], [descripcion]) VALUES (5, N'Supremas')
INSERT [dbo].[ProductoCategoria] ([idproductocategoria], [descripcion]) VALUES (6, N'Matambre')
INSERT [dbo].[ProductoCategoria] ([idproductocategoria], [descripcion]) VALUES (8, N'Guarnición')
INSERT [dbo].[ProductoCategoria] ([idproductocategoria], [descripcion]) VALUES (9, N'Pollos')
INSERT [dbo].[ProductoCategoria] ([idproductocategoria], [descripcion]) VALUES (10, N'Parillas')
INSERT [dbo].[ProductoCategoria] ([idproductocategoria], [descripcion]) VALUES (11, N'Pescados')
INSERT [dbo].[ProductoCategoria] ([idproductocategoria], [descripcion]) VALUES (12, N'Ensaladas')
INSERT [dbo].[ProductoCategoria] ([idproductocategoria], [descripcion]) VALUES (13, N'Ensaladas Esp')
INSERT [dbo].[ProductoCategoria] ([idproductocategoria], [descripcion]) VALUES (14, N'Tradicionales')
INSERT [dbo].[ProductoCategoria] ([idproductocategoria], [descripcion]) VALUES (15, N'Especiales I')
INSERT [dbo].[ProductoCategoria] ([idproductocategoria], [descripcion]) VALUES (16, N'Especiales II')
INSERT [dbo].[ProductoCategoria] ([idproductocategoria], [descripcion]) VALUES (17, N'Especiales en Fugazza')
INSERT [dbo].[ProductoCategoria] ([idproductocategoria], [descripcion]) VALUES (18, N'Especiales en Fugazzeta')
INSERT [dbo].[ProductoCategoria] ([idproductocategoria], [descripcion]) VALUES (19, N'Especialidades en Calzones')
INSERT [dbo].[ProductoCategoria] ([idproductocategoria], [descripcion]) VALUES (20, N'Otras Especialidades')
INSERT [dbo].[ProductoCategoria] ([idproductocategoria], [descripcion]) VALUES (21, N'Empanadas')
INSERT [dbo].[ProductoCategoria] ([idproductocategoria], [descripcion]) VALUES (22, N'Sandwiches')
INSERT [dbo].[ProductoCategoria] ([idproductocategoria], [descripcion]) VALUES (23, N'Pastas')
INSERT [dbo].[ProductoCategoria] ([idproductocategoria], [descripcion]) VALUES (24, N'Bebidas')
INSERT [dbo].[ProductoCategoria] ([idproductocategoria], [descripcion]) VALUES (25, N'Postres')
INSERT [dbo].[ProductoCategoria] ([idproductocategoria], [descripcion]) VALUES (26, N'Menús')
INSERT [dbo].[ProductoCategoria] ([idproductocategoria], [descripcion]) VALUES (27, N'Promos')
SET IDENTITY_INSERT [dbo].[ProductoCategoria] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([idusuario], [nombre], [apellido], [CUIL], [contraseña], [fechadecontratacion], [idcategoriausuario]) VALUES (1, N'Administrador', N'Administrador', 11111, N'1234', CAST(N'2012-12-12' AS Date), 1)
INSERT [dbo].[Usuario] ([idusuario], [nombre], [apellido], [CUIL], [contraseña], [fechadecontratacion], [idcategoriausuario]) VALUES (2, N'Yoel', N'Vázquez', 22222, N'12345', CAST(N'2015-12-12' AS Date), 2)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
SET IDENTITY_INSERT [dbo].[UsuarioCategoria] ON 

INSERT [dbo].[UsuarioCategoria] ([idcategoriausuario], [descripcion]) VALUES (1, N'Dueño')
INSERT [dbo].[UsuarioCategoria] ([idcategoriausuario], [descripcion]) VALUES (2, N'Encargado')
SET IDENTITY_INSERT [dbo].[UsuarioCategoria] OFF
GO
ALTER TABLE [dbo].[Caja]  WITH CHECK ADD  CONSTRAINT [FK_Caja_Usuario] FOREIGN KEY([idusuario])
REFERENCES [dbo].[Usuario] ([idusuario])
GO
ALTER TABLE [dbo].[Caja] CHECK CONSTRAINT [FK_Caja_Usuario]
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_Cadete] FOREIGN KEY([idcadete])
REFERENCES [dbo].[Cadete] ([idcadete])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_Cadete]
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_Cliente] FOREIGN KEY([idcliente])
REFERENCES [dbo].[Cliente] ([idcliente])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_Cliente]
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_EstadoCategoria] FOREIGN KEY([idestadocategoria])
REFERENCES [dbo].[EstadoCategoria] ([idestadocategoria])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_EstadoCategoria]
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_FormaPago] FOREIGN KEY([idformadepago])
REFERENCES [dbo].[FormaPago] ([idformadepago])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_FormaPago]
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_Usuario] FOREIGN KEY([idusuario])
REFERENCES [dbo].[Usuario] ([idusuario])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_Usuario]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_ProductoCategoria] FOREIGN KEY([idproductocategoria])
REFERENCES [dbo].[ProductoCategoria] ([idproductocategoria])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_ProductoCategoria]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_UsuarioCategoria] FOREIGN KEY([idcategoriausuario])
REFERENCES [dbo].[UsuarioCategoria] ([idcategoriausuario])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_UsuarioCategoria]
GO
/****** Object:  StoredProcedure [dbo].[BuscarPedidoPorMesAño]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BuscarPedidoPorMesAño](
                    @mes INT, 
                   
					@año INT
					)
as
BEGIN


select idpedido as 'ID del Pedido', Cliente.nombre as 'Nombre del cliente', Cliente.apellido as'Apellido del cliente', Usuario.nombre as 'Encargado', fechayhora as 'Fecha', observaciones, Cadete.nombre as 'Nombre del Cadete', EstadoCategoria.descripcion as 'Estado del pedido', total from Pedido join FormaPago on Pedido.idformadepago=FormaPago.idformadepago
join Cliente on Pedido.idcliente = Cliente.idcliente
join Usuario on Pedido.idusuario = Usuario.idusuario
join Cadete on Pedido.idcadete = Cadete.idcadete
join EstadoCategoria on Pedido.idestadocategoria = EstadoCategoria.idestadocategoria



where month(fechayhora)= @mes and year(fechayhora)= @año

END
GO
/****** Object:  StoredProcedure [dbo].[SPAsignarCadete]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPAsignarCadete](@idpedido INT, @idcadete INT)
AS
BEGIN
UPDATE Pedido
SET idcadete = @idcadete
WHERE idpedido = @idpedido
END
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarBebidas]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarBebidas]asselect * from Productowhere idproductocategoria  = 24
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarCadetes]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarCadetes]
as
begin

select * from Cadete

end
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarCadetesReales]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SPBuscarCadetesReales]
as
begin

select * from Cadete where idcadete <> 1

end
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarCalzones]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarCalzones]asselect * from Productowhere idproductocategoria  = 19
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarCategoriaProducto]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[SPBuscarCategoriaProducto]
AS
BEGIN

SELECT idproductocategoria as 'ID del Producto', descripcion as 'Nombre del producto' FROM ProductoCategoria

END
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarCategoriasUsuario]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[SPBuscarCategoriasUsuario]

as

begin

select * from UsuarioCategoria

end
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarClientePorNombre]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPBuscarClientePorNombre](
                    @nombre varchar(20)
					)
AS
BEGIN
SELECT * FROM Cliente
WHERE Cliente.nombre like @nombre or Cliente.telefono like @nombre
END
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarClientes]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SPBuscarClientes]
as
begin

select Cliente.idcliente, Cliente.nombre, Cliente.apellido, Cliente.telefono, Cliente.direccion
from Cliente

end
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarDetallePedidoSegunPedido]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPBuscarDetallePedidoSegunPedido](
                    @idpedido INT          
					)
AS
BEGIN

SELECT DetallePedido.iddetallepedido as 'ID Detalle Pedido', DetallePedido.idpedido as 'ID Pedido', Producto.descripcion as 'Producto', DetallePedido.cantidad as 'Cantidad', DetallePedido.precioventa as 'Precio Venta'

FROM DetallePedido

JOIN Producto 
ON Producto.idproducto = DetallePedido.idproducto

WHERE 

DetallePedido.idpedido = @idpedido

END
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarEmpanadas]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarEmpanadas]asselect * from Productowhere idproductocategoria  = 21
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarEnsaladas]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarEnsaladas]asselect * from Productowhere idproductocategoria  = 12
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarEnsaladasEsp]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarEnsaladasEsp]asselect * from Productowhere idproductocategoria  = 13
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarEntradas]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SPBuscarEntradas]asselect * from Productowhere idproductocategoria  = 1
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarEspecialesI]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarEspecialesI]asselect * from Productowhere idproductocategoria  = 15
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarEspecialesII]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarEspecialesII]asselect * from Productowhere idproductocategoria  = 16
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarEstadosCategorias]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SPBuscarEstadosCategorias]

as

begin

select * from EstadoCategoria

end
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarFormasDePago]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarFormasDePago]
as
begin

select * from FormaPago

end
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarFugazzas]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarFugazzas]asselect * from Productowhere idproductocategoria  = 17
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarFugazzetas]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarFugazzetas]asselect * from Productowhere idproductocategoria  = 18
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarGuarnicion]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarGuarnicion]asselect * from Productowhere idproductocategoria  = 8
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarMatambre]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarMatambre]asselect * from Productowhere idproductocategoria  = 6
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarMenus]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarMenus]asselect * from Productowhere idproductocategoria  = 26
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarMilanesas]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarMilanesas]asselect * from Productowhere idproductocategoria  = 4
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarOmelletes]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarOmelletes]asselect * from Productowhere idproductocategoria  = 2
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarOtrasEspecialidades]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarOtrasEspecialidades]asselect * from Productowhere idproductocategoria  = 20
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarParillas]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarParillas]asselect * from Productowhere idproductocategoria  = 10
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarPastas]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarPastas]asselect * from Productowhere idproductocategoria  = 23
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarPedidoPorDia]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[SPBuscarPedidoPorDia]

as

begin


select idpedido as 'ID del Pedido', Cliente.nombre as 'Nombre del cliente', Cliente.apellido as'Apellido del cliente', Usuario.nombre as 'Encargado', fechayhora as 'Fecha', observaciones, Cadete.nombre as 'Nombre del Cadete', EstadoCategoria.descripcion as 'Estado del pedido', total from Pedido join FormaPago on Pedido.idformadepago=FormaPago.idformadepago
join Cliente on Pedido.idcliente = Cliente.idcliente
join Usuario on Pedido.idusuario = Usuario.idusuario
join Cadete on Pedido.idcadete = Cadete.idcadete
join EstadoCategoria on Pedido.idestadocategoria = EstadoCategoria.idestadocategoria 



where day(fechayhora) = day(GETDATE()	)

end
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarPedidosActivos]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPBuscarPedidosActivos]

AS
BEGIN

SELECT Pedido.idpedido as 'ID Pedido', Cliente.nombre AS 'Cliente', FormaPago.descripcion as 'Medio de Pago', Cadete.nombre as 'Cadete', EstadoCategoria.descripcion as 'Estado', Pedido.total as 'Precio', Pedido.fechayhora as 'Fecha de Creación'
FROM Pedido 

JOIN EstadoCategoria 
ON Pedido.idestadocategoria = EstadoCategoria.idestadocategoria 

JOIN Cliente 
ON Cliente.idcliente = Pedido.idcliente

JOIN FormaPago 
ON FormaPago.idformadepago = Pedido.idformadepago

JOIN Cadete
ON Cadete.idcadete = Pedido.idcadete
where Pedido.idestadocategoria= 1 or Pedido.idestadocategoria= 2

END
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarPedidosSegunCliente]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPBuscarPedidosSegunCliente](
                    @idcliente INT          
					)
AS
BEGIN

SELECT Pedido.idpedido as 'ID Pedido', Cliente.nombre AS 'Cliente', FormaPago.descripcion as 'Medio de Pago', Cadete.nombre as 'Cadete', EstadoCategoria.descripcion as 'Estado', Pedido.total as 'Total'
FROM Pedido 
JOIN Cliente 
ON Cliente.idcliente = Pedido.idcliente
JOIN FormaPago 
ON FormaPago.idformadepago = Pedido.idformadepago
JOIN Cadete
ON Cadete.idcadete = Pedido.idcadete
JOIN EstadoCategoria 
ON Pedido.idestadocategoria = EstadoCategoria.idestadocategoria 
WHERE 
Pedido.idcliente = @idcliente
AND
(Pedido.idestadocategoria = 1
OR Pedido.idestadocategoria = 2)
END
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarPescados]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarPescados]asselect * from Productowhere idproductocategoria  = 11
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarPollos]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarPollos]asselect * from Productowhere idproductocategoria  = 9
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarPostres]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarPostres]asselect * from Productowhere idproductocategoria  = 25
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarProductoMasVendidodia]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPBuscarProductoMasVendidodia]
AS
BEGIN

	select  Producto.descripcion as 'Descripción', count(Producto.descripcion) as 'Cantidad'
	from DetallePedido 
	join Producto on detallepedido.idproducto=Producto.idproducto
	join Pedido on DetallePedido.idpedido = Pedido.idpedido
	where day(Pedido.fechayhora) = day(CURRENT_TIMESTAMP)

	group by producto.descripcion
		
	order by count(Producto.descripcion) desc 

END
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarProductoMasVendidoMesAño]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPBuscarProductoMasVendidoMesAño]
(
                    @mes INT, 
                   
					@año INT
					)
AS
BEGIN

	select  Producto.descripcion as 'Descripcion', count(Producto.descripcion) as 'Cantidad'
	from DetallePedido 
	join Producto on detallepedido.idproducto=Producto.idproducto
	join Pedido on DetallePedido.idpedido = Pedido.idpedido
	where month(Pedido.fechayhora) = @mes and  YEAR(pedido.fechayhora) = @año

	group by Producto.descripcion
		
	order by count(Producto.descripcion) desc

END
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarPromos]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarPromos]asselect * from Productowhere idproductocategoria  = 27
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarRodados]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarRodados]

as

begin

select * from Rodado

end
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarSandwiches]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarSandwiches]asselect * from Productowhere idproductocategoria  = 22
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarSupremas]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarSupremas]asselect * from Productowhere idproductocategoria  = 5
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarTodosLosProductos]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[SPBuscarTodosLosProductos]

as
begin

select idproducto, producto.descripcion as 'Nombre', productocategoria.descripcion as 'Categoria', precio, productocategoria.idproductocategoria as 'ID Categoria'  from Producto  
join ProductoCategoria on Producto.idproductocategoria= ProductoCategoria.idproductocategoria


end
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarTortillas]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarTortillas]asselect * from Productowhere idproductocategoria  = 3
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarTradicionales]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarTradicionales]asselect * from Productowhere idproductocategoria  = 14
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarUsuario]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPBuscarUsuario]
AS
BEGIN

SELECT * FROM Usuario

END
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarUsuariosSinContraseña]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[SPBuscarUsuariosSinContraseña]
AS
BEGIN

SELECT idusuario, nombre, apellido, CUIL , fechadecontratacion, UsuarioCategoria.descripcion   
FROM Usuario join UsuarioCategoria on usuario.idcategoriausuario= UsuarioCategoria.idcategoriausuario

END
GO
/****** Object:  StoredProcedure [dbo].[SPCargarCajas]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SPCargarCajas]

as

begin

select idcaja as 'ID Caja', Usuario.nombre as 'Usuario', efectivocaja as 'Efectivo en Caja', postnetcaja as 'Posnet en Caja',
fechayhora as 'Fecha y Hora', efectivoinicial as 'Efectivo Inicial', estado 'Estado Caja'

from Caja 

JOIN Usuario 
ON Usuario.idusuario = Caja.idusuario

where estado=1

end
GO
/****** Object:  StoredProcedure [dbo].[SPCrearCadete]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPCrearCadete](
                    @nombre varchar(20),
                    @apellido varchar(20),
                    @tel INT, 
					@licencia INT
					)
as
BEGIN
INSERT INTO Cadete(
    [nombre],
    [apellido],
    [telefono],
    [licencia]
    )
VALUES (
    @nombre,
    @apellido,
    @tel,
	@licencia
	)
END
GO
/****** Object:  StoredProcedure [dbo].[SPCrearCaja]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPCrearCaja](
                    @idusuario INT, 
					@efectivocaja INT,
					@posnetcaja INT,
                    @fechayhora DATETIME,
					@efectivoinicial INT,
										@estado INT
					)
AS
BEGIN
INSERT INTO Caja(
    [idusuario],
	[efectivocaja],
	[postnetcaja],
    [fechayhora],
    [efectivoinicial]
        )
VALUES (
    @idusuario,
	@efectivocaja,
	@posnetcaja,
    @fechayhora,
    @efectivoinicial
   
	)
END
GO
/****** Object:  StoredProcedure [dbo].[SPCrearCliente]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPCrearCliente](
                    @nombre varchar(20),
                    @apellido varchar(20),
                    @telefono INT, 
                    @direccion varchar(50)
					)
AS
BEGIN
INSERT INTO Cliente(
    [nombre],
    [apellido],
    [telefono],
    [direccion]
    )
VALUES (
    @nombre,
    @apellido,
    @telefono,
    @direccion
	)
END
GO
/****** Object:  StoredProcedure [dbo].[SPCrearDetallePedido]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPCrearDetallePedido](
                    @idproducto INT,
                    @idpedido INT,
                    @cantidad INT, 
                    @precioventa INT
					)
AS
BEGIN
INSERT INTO DetallePedido(
    [idproducto],
    [idpedido],
    [cantidad],
    [precioventa]
    )
VALUES (
    @idproducto,
    @idpedido,
    @cantidad,
    @precioventa
	)
END
GO
/****** Object:  StoredProcedure [dbo].[SPCrearPedido]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPCrearPedido](
                    @idformadepago INT,
                    @idcliente INT,
                    @idusuario INT, 
                    @fechayhora DATETIME,
                    @observaciones VARCHAR(100),
					@idcadete INT,
					@idestadocategoria INT
					)
AS
BEGIN
INSERT INTO Pedido(
    [idformadepago],
    [idcliente],
    [idusuario],
    [fechayhora],
    [observaciones],
    [idcadete],
    [idestadocategoria]
    )
VALUES (
    @idformadepago,
    @idcliente,
    @idusuario,
    @fechayhora,
    @observaciones,
    @idcadete,
    @idestadocategoria
	)
END
GO
/****** Object:  StoredProcedure [dbo].[SPCrearProducto]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SPCrearProducto](
					@descripcion varchar (50),
					@idproductocategoria INT,
                    @precio int
					)
AS
BEGIN
INSERT INTO Producto(
    
	[descripcion],
	[idproductocategoria],
    [precio]
    
        )
VALUES (
    
	@descripcion,
	@idproductocategoria,
     @precio
    
   
	)
END
GO
/****** Object:  StoredProcedure [dbo].[SPCrearUsuario]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SPCrearUsuario](
                    @nombre varchar(20),
                    @apellido varchar(20),
                    @CUIL INT, 
                    @contraseña varchar(50),
					@fechacontratacion DATETIME,
					@idcategoriausuario INT
					)
as
BEGIN
INSERT INTO Usuario(
    [nombre],
    [apellido],
    [CUIL],
	[contraseña],
    [fechadecontratacion],
        [idcategoriausuario]
   
    )
VALUES (
    @nombre,
    @apellido,
    @CUIL,
    @contraseña,
	@fechacontratacion,
    @idcategoriausuario
   
	)
END
GO
/****** Object:  StoredProcedure [dbo].[SPEliminarCadete]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[SPEliminarCadete](@idcadete INT)
AS
BEGIN
delete from Cadete
WHERE idcadete = @idcadete
END
GO
/****** Object:  StoredProcedure [dbo].[SPEliminarProducto]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[SPEliminarProducto](@idproducto INT)
AS
BEGIN
delete from Producto
WHERE idproducto = @idproducto
END
GO
/****** Object:  StoredProcedure [dbo].[SPEliminarUsuario]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[SPEliminarUsuario](@idusuario INT)
AS
BEGIN
delete from Usuario
WHERE idusuario = @idusuario
END
GO
/****** Object:  StoredProcedure [dbo].[SPFiltroProductoPorNombreYCategoria]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPFiltroProductoPorNombreYCategoria](
                    @filtro varchar(20)
					)
AS
BEGIN
select idproducto, producto.descripcion as 'Nombre', productocategoria.descripcion as 'Categoria', precio, productocategoria.idproductocategoria as 'ID Categoria'  from Producto  
join ProductoCategoria on Producto.idproductocategoria= ProductoCategoria.idproductocategoria



WHERE Producto.descripcion like @filtro or ProductoCategoria.descripcion like @filtro 

END
GO
/****** Object:  StoredProcedure [dbo].[SPModificarCadete]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPModificarCadete](@idcadete INT, @nombre varchar(20), @apellido varchar(20), @telefono INT, @licencia int)
AS
BEGIN
UPDATE Cadete
SET nombre = @nombre, apellido = @apellido, telefono = @telefono, licencia= @licencia
WHERE idcadete = @idcadete
END
GO
/****** Object:  StoredProcedure [dbo].[SPModificarCliente]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPModificarCliente](@idcliente INT, @nombre varchar(20), @apellido varchar(20), @telefono INT, @direccion varchar(50))
AS
BEGIN
UPDATE Cliente
SET nombre = @nombre, apellido = @apellido, telefono = @telefono, direccion = @direccion
WHERE idcliente = @idcliente
END
GO
/****** Object:  StoredProcedure [dbo].[SPModificarEstadoPedido]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPModificarEstadoPedido](@idpedido INT, @idestadocategoria INT)
AS
BEGIN
UPDATE Pedido
SET idestadocategoria = @idestadocategoria 
WHERE idpedido = @idpedido
END
GO
/****** Object:  StoredProcedure [dbo].[SPModificarProducto]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPModificarProducto](@idproducto INT, @nombre varchar(20), @idproductocategoria int, @precio INT)
AS
BEGIN
UPDATE Producto
SET descripcion = @nombre, idproductocategoria = @idproductocategoria, precio = @precio
WHERE idproducto = @idproducto
END
GO
/****** Object:  StoredProcedure [dbo].[SPModificarUsuario]    Script Date: 26/11/2020 12:45:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SPModificarUsuario](@idusuario INT, @nombre varchar(20), @apellido varchar(20), @cuil INT, @contraseña int, @idcategoriausuario int)
AS
BEGIN
UPDATE Usuario
SET nombre = @nombre, apellido = @apellido, CUIL = @cuil, contraseña= @contraseña, idcategoriausuario=@idcategoriausuario
WHERE idusuario = @idusuario
END
GO
