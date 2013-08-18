/****** Object:  ForeignKey [FK_Modelo_Marca]    Script Date: 08/18/2013 09:59:50 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Modelo_Marca]') AND parent_object_id = OBJECT_ID(N'[dbo].[Modelo]'))
ALTER TABLE [dbo].[Modelo] DROP CONSTRAINT [FK_Modelo_Marca]
GO
/****** Object:  ForeignKey [FK_Produto_Categoria]    Script Date: 08/18/2013 09:59:50 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Produto_Categoria]') AND parent_object_id = OBJECT_ID(N'[dbo].[Produto]'))
ALTER TABLE [dbo].[Produto] DROP CONSTRAINT [FK_Produto_Categoria]
GO
/****** Object:  ForeignKey [FK_Produto_Loja]    Script Date: 08/18/2013 09:59:50 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Produto_Loja]') AND parent_object_id = OBJECT_ID(N'[dbo].[Produto]'))
ALTER TABLE [dbo].[Produto] DROP CONSTRAINT [FK_Produto_Loja]
GO
/****** Object:  ForeignKey [FK_Produto_Modelo]    Script Date: 08/18/2013 09:59:50 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Produto_Modelo]') AND parent_object_id = OBJECT_ID(N'[dbo].[Produto]'))
ALTER TABLE [dbo].[Produto] DROP CONSTRAINT [FK_Produto_Modelo]
GO
/****** Object:  Table [dbo].[Produto]    Script Date: 08/18/2013 09:59:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Produto]') AND type in (N'U'))
DROP TABLE [dbo].[Produto]
GO
/****** Object:  Table [dbo].[Modelo]    Script Date: 08/18/2013 09:59:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Modelo]') AND type in (N'U'))
DROP TABLE [dbo].[Modelo]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 08/18/2013 09:59:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Categoria]') AND type in (N'U'))
DROP TABLE [dbo].[Categoria]
GO
/****** Object:  Table [dbo].[Loja]    Script Date: 08/18/2013 09:59:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Loja]') AND type in (N'U'))
DROP TABLE [dbo].[Loja]
GO
/****** Object:  Table [dbo].[Marca]    Script Date: 08/18/2013 09:59:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Marca]') AND type in (N'U'))
DROP TABLE [dbo].[Marca]
GO
/****** Object:  Table [dbo].[Marca]    Script Date: 08/18/2013 09:59:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Marca]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Marca](
	[Id] [uniqueidentifier] NOT NULL,
	[Nome] [nvarchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_Marca] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[Loja]    Script Date: 08/18/2013 09:59:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Loja]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Loja](
	[Id] [uniqueidentifier] NOT NULL,
	[Email] [nvarchar](max) COLLATE Latin1_General_CI_AS NOT NULL,
	[Nome] [nvarchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
	[NomeUsuario] [nvarchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
	[Senha] [nchar](10) COLLATE Latin1_General_CI_AS NOT NULL,
	[Endereco] [nvarchar](max) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_Loja] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 08/18/2013 09:59:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Categoria]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Categoria](
	[Id] [uniqueidentifier] NOT NULL,
	[Nome] [nvarchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
	[Descricao] [nvarchar](max) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[Categoria] ([Id], [Nome], [Descricao]) VALUES (N'cd5eeaca-b24c-43b9-a9fd-f8ffe4d03ea2', N'Arrefecimento', N'Descrição')
/****** Object:  Table [dbo].[Modelo]    Script Date: 08/18/2013 09:59:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Modelo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Modelo](
	[Id] [uniqueidentifier] NOT NULL,
	[Nome] [nvarchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
	[Ano] [int] NOT NULL,
 CONSTRAINT [PK_Modelo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[Produto]    Script Date: 08/18/2013 09:59:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Produto]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Produto](
	[Id] [uniqueidentifier] NOT NULL,
	[Nome] [nchar](10) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_Produto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  ForeignKey [FK_Modelo_Marca]    Script Date: 08/18/2013 09:59:50 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Modelo_Marca]') AND parent_object_id = OBJECT_ID(N'[dbo].[Modelo]'))
ALTER TABLE [dbo].[Modelo]  WITH CHECK ADD  CONSTRAINT [FK_Modelo_Marca] FOREIGN KEY([Id])
REFERENCES [dbo].[Marca] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Modelo_Marca]') AND parent_object_id = OBJECT_ID(N'[dbo].[Modelo]'))
ALTER TABLE [dbo].[Modelo] CHECK CONSTRAINT [FK_Modelo_Marca]
GO
/****** Object:  ForeignKey [FK_Produto_Categoria]    Script Date: 08/18/2013 09:59:50 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Produto_Categoria]') AND parent_object_id = OBJECT_ID(N'[dbo].[Produto]'))
ALTER TABLE [dbo].[Produto]  WITH CHECK ADD  CONSTRAINT [FK_Produto_Categoria] FOREIGN KEY([Id])
REFERENCES [dbo].[Categoria] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Produto_Categoria]') AND parent_object_id = OBJECT_ID(N'[dbo].[Produto]'))
ALTER TABLE [dbo].[Produto] CHECK CONSTRAINT [FK_Produto_Categoria]
GO
/****** Object:  ForeignKey [FK_Produto_Loja]    Script Date: 08/18/2013 09:59:50 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Produto_Loja]') AND parent_object_id = OBJECT_ID(N'[dbo].[Produto]'))
ALTER TABLE [dbo].[Produto]  WITH CHECK ADD  CONSTRAINT [FK_Produto_Loja] FOREIGN KEY([Id])
REFERENCES [dbo].[Loja] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Produto_Loja]') AND parent_object_id = OBJECT_ID(N'[dbo].[Produto]'))
ALTER TABLE [dbo].[Produto] CHECK CONSTRAINT [FK_Produto_Loja]
GO
/****** Object:  ForeignKey [FK_Produto_Modelo]    Script Date: 08/18/2013 09:59:50 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Produto_Modelo]') AND parent_object_id = OBJECT_ID(N'[dbo].[Produto]'))
ALTER TABLE [dbo].[Produto]  WITH CHECK ADD  CONSTRAINT [FK_Produto_Modelo] FOREIGN KEY([Id])
REFERENCES [dbo].[Modelo] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Produto_Modelo]') AND parent_object_id = OBJECT_ID(N'[dbo].[Produto]'))
ALTER TABLE [dbo].[Produto] CHECK CONSTRAINT [FK_Produto_Modelo]
GO
