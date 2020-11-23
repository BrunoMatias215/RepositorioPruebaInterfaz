USE [Che Miranda]
GO
/****** Object:  Table [dbo].[Cadete]    Script Date: 23/11/2020 06:21:03 ******/
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
	[licencia] [int] NOT NULL,
 CONSTRAINT [PK_Cadete] PRIMARY KEY CLUSTERED 
(
	[idcadete] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Caja]    Script Date: 23/11/2020 06:21:03 ******/
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
/****** Object:  Table [dbo].[Cliente]    Script Date: 23/11/2020 06:21:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[idcliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NULL,
	[apellido] [varchar](20) NULL,
	[telefono] [int] NULL,
	[direccion] [varchar](50) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[idcliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallePedido]    Script Date: 23/11/2020 06:21:03 ******/
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
/****** Object:  Table [dbo].[EstadoCategoria]    Script Date: 23/11/2020 06:21:03 ******/
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
/****** Object:  Table [dbo].[FormaPago]    Script Date: 23/11/2020 06:21:03 ******/
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
/****** Object:  Table [dbo].[Pedido]    Script Date: 23/11/2020 06:21:03 ******/
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
/****** Object:  Table [dbo].[Producto]    Script Date: 23/11/2020 06:21:03 ******/
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
/****** Object:  Table [dbo].[ProductoCategoria]    Script Date: 23/11/2020 06:21:03 ******/
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
/****** Object:  Table [dbo].[Rodado]    Script Date: 23/11/2020 06:21:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rodado](
	[idrodado] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](20) NOT NULL,
	[patente] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Rodado] PRIMARY KEY CLUSTERED 
(
	[idrodado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 23/11/2020 06:21:03 ******/
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
/****** Object:  Table [dbo].[UsuarioCategoria]    Script Date: 23/11/2020 06:21:03 ******/
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
/****** Object:  StoredProcedure [dbo].[SPAsignarCadete]    Script Date: 23/11/2020 06:21:03 ******/
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
/****** Object:  StoredProcedure [dbo].[SPBuscarBebidas]    Script Date: 23/11/2020 06:21:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarBebidas]asselect * from Productowhere idproductocategoria  = 24
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarCadetes]    Script Date: 23/11/2020 06:21:03 ******/
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
/****** Object:  StoredProcedure [dbo].[SPBuscarCalzones]    Script Date: 23/11/2020 06:21:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarCalzones]asselect * from Productowhere idproductocategoria  = 19
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarCategoriaProducto]    Script Date: 23/11/2020 06:21:03 ******/
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
/****** Object:  StoredProcedure [dbo].[SPBuscarClientePorNombre]    Script Date: 23/11/2020 06:21:03 ******/
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
WHERE Cliente.nombre = @nombre
END
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarClientes]    Script Date: 23/11/2020 06:21:03 ******/
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
/****** Object:  StoredProcedure [dbo].[SPBuscarDetallePedidoSegunPedido]    Script Date: 23/11/2020 06:21:03 ******/
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
/****** Object:  StoredProcedure [dbo].[SPBuscarEmpanadas]    Script Date: 23/11/2020 06:21:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarEmpanadas]asselect * from Productowhere idproductocategoria  = 21
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarEnsaladas]    Script Date: 23/11/2020 06:21:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarEnsaladas]asselect * from Productowhere idproductocategoria  = 12
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarEnsaladasEsp]    Script Date: 23/11/2020 06:21:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarEnsaladasEsp]asselect * from Productowhere idproductocategoria  = 13
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarEntradas]    Script Date: 23/11/2020 06:21:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SPBuscarEntradas]asselect * from Productowhere idproductocategoria  = 1
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarEspecialesI]    Script Date: 23/11/2020 06:21:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarEspecialesI]asselect * from Productowhere idproductocategoria  = 15
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarEspecialesII]    Script Date: 23/11/2020 06:21:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarEspecialesII]asselect * from Productowhere idproductocategoria  = 16
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarEstadosCategorias]    Script Date: 23/11/2020 06:21:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SPBuscarEstadosCategorias]

as

begin

select * from EstadoCategoria

where EstadoCategoria.idestadocategoria <> 2

end
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarFormasDePago]    Script Date: 23/11/2020 06:21:03 ******/
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
/****** Object:  StoredProcedure [dbo].[SPBuscarFugazzas]    Script Date: 23/11/2020 06:21:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarFugazzas]asselect * from Productowhere idproductocategoria  = 17
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarFugazzetas]    Script Date: 23/11/2020 06:21:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarFugazzetas]asselect * from Productowhere idproductocategoria  = 18
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarGuarnicion]    Script Date: 23/11/2020 06:21:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarGuarnicion]asselect * from Productowhere idproductocategoria  = 8
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarMatambre]    Script Date: 23/11/2020 06:21:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarMatambre]asselect * from Productowhere idproductocategoria  = 6
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarMenus]    Script Date: 23/11/2020 06:21:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarMenus]asselect * from Productowhere idproductocategoria  = 26
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarMilanesas]    Script Date: 23/11/2020 06:21:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarMilanesas]asselect * from Productowhere idproductocategoria  = 4
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarOmelletes]    Script Date: 23/11/2020 06:21:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarOmelletes]asselect * from Productowhere idproductocategoria  = 2
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarOtrasEspecialidades]    Script Date: 23/11/2020 06:21:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarOtrasEspecialidades]asselect * from Productowhere idproductocategoria  = 20
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarParillas]    Script Date: 23/11/2020 06:21:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarParillas]asselect * from Productowhere idproductocategoria  = 10
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarPastas]    Script Date: 23/11/2020 06:21:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarPastas]asselect * from Productowhere idproductocategoria  = 23
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarPedidosActivos]    Script Date: 23/11/2020 06:21:03 ******/
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

END
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarPedidosSegunCliente]    Script Date: 23/11/2020 06:21:03 ******/
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
/****** Object:  StoredProcedure [dbo].[SPBuscarPescados]    Script Date: 23/11/2020 06:21:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarPescados]asselect * from Productowhere idproductocategoria  = 11
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarPollos]    Script Date: 23/11/2020 06:21:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarPollos]asselect * from Productowhere idproductocategoria  = 9
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarPostres]    Script Date: 23/11/2020 06:21:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarPostres]asselect * from Productowhere idproductocategoria  = 25
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarPromos]    Script Date: 23/11/2020 06:21:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarPromos]asselect * from Productowhere idproductocategoria  = 27
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarRodados]    Script Date: 23/11/2020 06:21:03 ******/
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
/****** Object:  StoredProcedure [dbo].[SPBuscarSandwiches]    Script Date: 23/11/2020 06:21:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarSandwiches]asselect * from Productowhere idproductocategoria  = 22
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarSupremas]    Script Date: 23/11/2020 06:21:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarSupremas]asselect * from Productowhere idproductocategoria  = 5
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarTodosLosProductos]    Script Date: 23/11/2020 06:21:03 ******/
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
/****** Object:  StoredProcedure [dbo].[SPBuscarTortillas]    Script Date: 23/11/2020 06:21:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarTortillas]asselect * from Productowhere idproductocategoria  = 3
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarTradicionales]    Script Date: 23/11/2020 06:21:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPBuscarTradicionales]asselect * from Productowhere idproductocategoria  = 14
GO
/****** Object:  StoredProcedure [dbo].[SPBuscarUsuario]    Script Date: 23/11/2020 06:21:03 ******/
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
/****** Object:  StoredProcedure [dbo].[SPCargarCajas]    Script Date: 23/11/2020 06:21:03 ******/
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
/****** Object:  StoredProcedure [dbo].[SPCrearCaja]    Script Date: 23/11/2020 06:21:03 ******/
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
/****** Object:  StoredProcedure [dbo].[SPCrearCliente]    Script Date: 23/11/2020 06:21:03 ******/
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
/****** Object:  StoredProcedure [dbo].[SPCrearDetallePedido]    Script Date: 23/11/2020 06:21:03 ******/
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
/****** Object:  StoredProcedure [dbo].[SPCrearPedido]    Script Date: 23/11/2020 06:21:03 ******/
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
/****** Object:  StoredProcedure [dbo].[SPCrearProducto]    Script Date: 23/11/2020 06:21:03 ******/
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
/****** Object:  StoredProcedure [dbo].[SPCrearUsuario]    Script Date: 23/11/2020 06:21:03 ******/
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
/****** Object:  StoredProcedure [dbo].[SPFiltroProductoPorNombreYCategoria]    Script Date: 23/11/2020 06:21:03 ******/
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
/****** Object:  StoredProcedure [dbo].[SPModificarCliente]    Script Date: 23/11/2020 06:21:03 ******/
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
/****** Object:  StoredProcedure [dbo].[SPModificarEstadoPedido]    Script Date: 23/11/2020 06:21:03 ******/
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
/****** Object:  StoredProcedure [dbo].[SPModificarProducto]    Script Date: 23/11/2020 06:21:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[SPModificarProducto](@idproducto INT, @nombre varchar(20), @idproductocategoria int, @precio INT)
AS
BEGIN
UPDATE Producto
SET descripcion = @nombre, idproductocategoria = @idproductocategoria, precio = @precio
WHERE idproducto = @idproducto
END
GO
