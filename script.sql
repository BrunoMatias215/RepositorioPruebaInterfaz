USE [Che Miranda]
GO
/****** Object:  Table [dbo].[Cadete]    Script Date: 14/11/2020 12:00:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cadete](
	[idcadete] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[apellido] [varchar](20) NOT NULL,
	[telefono] [int] NOT NULL,
	[idrodado] [int] NOT NULL,
	[licencia] [int] NULL,
 CONSTRAINT [PK_Cadete] PRIMARY KEY CLUSTERED 
(
	[idcadete] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Caja]    Script Date: 14/11/2020 12:00:58 ******/
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
/****** Object:  Table [dbo].[Cliente]    Script Date: 14/11/2020 12:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[idcliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[apellido] [varchar](20) NOT NULL,
	[telefono] [int] NOT NULL,
	[direccion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[idcliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallePedido]    Script Date: 14/11/2020 12:00:58 ******/
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
/****** Object:  Table [dbo].[EstadoCategoria]    Script Date: 14/11/2020 12:00:58 ******/
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
/****** Object:  Table [dbo].[FormaPago]    Script Date: 14/11/2020 12:00:58 ******/
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
/****** Object:  Table [dbo].[Pedido]    Script Date: 14/11/2020 12:00:58 ******/
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
	[observaciones] [varchar](100) NOT NULL,
	[idcadete] [int] NOT NULL,
	[idestadocategoria] [int] NOT NULL,
 CONSTRAINT [PK_Pedido] PRIMARY KEY CLUSTERED 
(
	[idpedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 14/11/2020 12:00:58 ******/
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
/****** Object:  Table [dbo].[ProductoCategoria]    Script Date: 14/11/2020 12:00:58 ******/
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
/****** Object:  Table [dbo].[Rodado]    Script Date: 14/11/2020 12:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rodado](
	[idrodado] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](20) NULL,
	[patente] [varchar](20) NULL,
 CONSTRAINT [PK_Rodado] PRIMARY KEY CLUSTERED 
(
	[idrodado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 14/11/2020 12:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[idusuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[apellido] [varchar](20) NOT NULL,
	[CUIL] [int] NOT NULL,
	[numerodecontacto] [int] NOT NULL,
	[fechadecontratacion] [date] NOT NULL,
	[idcategoriausuario] [int] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[idusuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuarioCategoria]    Script Date: 14/11/2020 12:00:58 ******/
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

INSERT [dbo].[Cadete] ([idcadete], [nombre], [apellido], [telefono], [idrodado], [licencia]) VALUES (1, N'Gonzalo', N'Perez', 49356851, 1, 12345)
SET IDENTITY_INSERT [dbo].[Cadete] OFF
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([idcliente], [nombre], [apellido], [telefono], [direccion]) VALUES (1, N'Javier', N'Hernández', 49862457, N'Las Heras 233')
INSERT [dbo].[Cliente] ([idcliente], [nombre], [apellido], [telefono], [direccion]) VALUES (2, N'Pablo', N'Martín', 48213652, N'Av Rivadavia 859 1P A')
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[DetallePedido] ON 

INSERT [dbo].[DetallePedido] ([iddetallepedido], [idproducto], [idpedido], [cantidad], [precioventa]) VALUES (1, 1, 1, 1, 240)
INSERT [dbo].[DetallePedido] ([iddetallepedido], [idproducto], [idpedido], [cantidad], [precioventa]) VALUES (2, 2, 1, 2, 680)
INSERT [dbo].[DetallePedido] ([iddetallepedido], [idproducto], [idpedido], [cantidad], [precioventa]) VALUES (3, 3, 1, 1, 350)
INSERT [dbo].[DetallePedido] ([iddetallepedido], [idproducto], [idpedido], [cantidad], [precioventa]) VALUES (4, 4, 2, 1, 750)
INSERT [dbo].[DetallePedido] ([iddetallepedido], [idproducto], [idpedido], [cantidad], [precioventa]) VALUES (9, 10, 11, 1, 295)
INSERT [dbo].[DetallePedido] ([iddetallepedido], [idproducto], [idpedido], [cantidad], [precioventa]) VALUES (10, 69, 11, 1, 170)
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

INSERT [dbo].[Pedido] ([idpedido], [idformadepago], [idcliente], [idusuario], [fechayhora], [observaciones], [idcadete], [idestadocategoria]) VALUES (1, 1, 1, 1, CAST(N'2020-10-18T00:00:00.000' AS DateTime), N'Primer Pedido', 1, 1)
INSERT [dbo].[Pedido] ([idpedido], [idformadepago], [idcliente], [idusuario], [fechayhora], [observaciones], [idcadete], [idestadocategoria]) VALUES (2, 2, 1, 1, CAST(N'2020-10-18T00:00:00.000' AS DateTime), N'Segundo Pedido', 1, 1)
INSERT [dbo].[Pedido] ([idpedido], [idformadepago], [idcliente], [idusuario], [fechayhora], [observaciones], [idcadete], [idestadocategoria]) VALUES (3, 2, 1, 1, CAST(N'2020-10-18T00:00:00.000' AS DateTime), N'Tercer Pedido', 1, 1)
INSERT [dbo].[Pedido] ([idpedido], [idformadepago], [idcliente], [idusuario], [fechayhora], [observaciones], [idcadete], [idestadocategoria]) VALUES (11, 1, 1, 1, CAST(N'2020-11-01T12:42:45.653' AS DateTime), N'', 1, 1)
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
SET IDENTITY_INSERT [dbo].[Rodado] ON 

INSERT [dbo].[Rodado] ([idrodado], [descripcion], [patente]) VALUES (1, N'Moto', N'ABC123')
SET IDENTITY_INSERT [dbo].[Rodado] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([idusuario], [nombre], [apellido], [CUIL], [numerodecontacto], [fechadecontratacion], [idcategoriausuario]) VALUES (1, N'Dueño', N'Dueño', 1234, 12345, CAST(N'2012-12-12' AS Date), 1)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
SET IDENTITY_INSERT [dbo].[UsuarioCategoria] ON 

INSERT [dbo].[UsuarioCategoria] ([idcategoriausuario], [descripcion]) VALUES (1, N'Administrador')
INSERT [dbo].[UsuarioCategoria] ([idcategoriausuario], [descripcion]) VALUES (2, N'Encargado')
INSERT [dbo].[UsuarioCategoria] ([idcategoriausuario], [descripcion]) VALUES (3, N'Cocinero')
SET IDENTITY_INSERT [dbo].[UsuarioCategoria] OFF
GO
ALTER TABLE [dbo].[Cadete]  WITH CHECK ADD  CONSTRAINT [FK_Cadete_Rodado] FOREIGN KEY([idrodado])
REFERENCES [dbo].[Rodado] ([idrodado])
GO
ALTER TABLE [dbo].[Cadete] CHECK CONSTRAINT [FK_Cadete_Rodado]
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
/****** Object:  StoredProcedure [dbo].[SPBuscarBebidas]    Script Date: 14/11/2020 12:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarBebidas]asselect * from Productowhere idproductocategoria  = 24
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarCadetes]    Script Date: 14/11/2020 12:00:58 ******/
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
/****** Object:  StoredProcedure [dbo].[SPBuscarCadeteYRodado]    Script Date: 14/11/2020 12:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SPBuscarCadeteYRodado]
as
begin

select Cadete.idcadete, Cadete.nombre, Cadete.apellido, Cadete.telefono, Rodado.idrodado, Rodado.descripcion, Rodado.patente

from Cadete join Rodado on Cadete.idrodado = rodado.idrodado

end
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarCalzones]    Script Date: 14/11/2020 12:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarCalzones]asselect * from Productowhere idproductocategoria  = 19
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarClientes]    Script Date: 14/11/2020 12:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SPBuscarClientes]
as
begin

select * from Cliente

end
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarEmpanadas]    Script Date: 14/11/2020 12:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarEmpanadas]asselect * from Productowhere idproductocategoria  = 21
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarEnsaladas]    Script Date: 14/11/2020 12:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarEnsaladas]asselect * from Productowhere idproductocategoria  = 12
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarEnsaladasEsp]    Script Date: 14/11/2020 12:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarEnsaladasEsp]asselect * from Productowhere idproductocategoria  = 13
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarEntradas]    Script Date: 14/11/2020 12:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SPBuscarEntradas]asselect * from Productowhere idproductocategoria  = 1
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarEspecialesI]    Script Date: 14/11/2020 12:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarEspecialesI]asselect * from Productowhere idproductocategoria  = 15
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarEspecialesII]    Script Date: 14/11/2020 12:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarEspecialesII]asselect * from Productowhere idproductocategoria  = 16
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarEstadosCategorias]    Script Date: 14/11/2020 12:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarEstadosCategorias]

as

begin

select * from EstadoCategoria

end
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarFormasDePago]    Script Date: 14/11/2020 12:00:58 ******/
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
/****** Object:  StoredProcedure [dbo].[SPBuscarFugazzas]    Script Date: 14/11/2020 12:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarFugazzas]asselect * from Productowhere idproductocategoria  = 17
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarFugazzetas]    Script Date: 14/11/2020 12:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarFugazzetas]asselect * from Productowhere idproductocategoria  = 18
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarGuarnicion]    Script Date: 14/11/2020 12:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarGuarnicion]asselect * from Productowhere idproductocategoria  = 8
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarMatambre]    Script Date: 14/11/2020 12:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarMatambre]asselect * from Productowhere idproductocategoria  = 6
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarMenus]    Script Date: 14/11/2020 12:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarMenus]asselect * from Productowhere idproductocategoria  = 26
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarMilanesas]    Script Date: 14/11/2020 12:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarMilanesas]asselect * from Productowhere idproductocategoria  = 4
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarOmelletes]    Script Date: 14/11/2020 12:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarOmelletes]asselect * from Productowhere idproductocategoria  = 2
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarOtrasEspecialidades]    Script Date: 14/11/2020 12:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarOtrasEspecialidades]asselect * from Productowhere idproductocategoria  = 20
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarParillas]    Script Date: 14/11/2020 12:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarParillas]asselect * from Productowhere idproductocategoria  = 10
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarPastas]    Script Date: 14/11/2020 12:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarPastas]asselect * from Productowhere idproductocategoria  = 23
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarPescados]    Script Date: 14/11/2020 12:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarPescados]asselect * from Productowhere idproductocategoria  = 11
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarPollos]    Script Date: 14/11/2020 12:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarPollos]asselect * from Productowhere idproductocategoria  = 9
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarPostres]    Script Date: 14/11/2020 12:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarPostres]asselect * from Productowhere idproductocategoria  = 25
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarPromos]    Script Date: 14/11/2020 12:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarPromos]asselect * from Productowhere idproductocategoria  = 27
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarRodados]    Script Date: 14/11/2020 12:00:58 ******/
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
/****** Object:  StoredProcedure [dbo].[SPBuscarSandwiches]    Script Date: 14/11/2020 12:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarSandwiches]asselect * from Productowhere idproductocategoria  = 22
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarSupremas]    Script Date: 14/11/2020 12:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarSupremas]asselect * from Productowhere idproductocategoria  = 5
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarTortillas]    Script Date: 14/11/2020 12:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarTortillas]asselect * from Productowhere idproductocategoria  = 3
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarTradicionales]    Script Date: 14/11/2020 12:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarTradicionales]asselect * from Productowhere idproductocategoria  = 14
GO
/****** Object:  StoredProcedure [dbo].[SPCrearDetallePedido]    Script Date: 14/11/2020 12:00:58 ******/
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
/****** Object:  StoredProcedure [dbo].[SPCrearPedido]    Script Date: 14/11/2020 12:00:58 ******/
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
