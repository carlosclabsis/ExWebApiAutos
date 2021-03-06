USE [ExWebApiAutos]
GO
/****** Object:  Table [dbo].[T_auto]    Script Date: 22/01/2019 22:33:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_auto](
	[auto_id] [uniqueidentifier] NOT NULL,
	[auto_color] [varchar](20) NOT NULL,
	[auto_anio_fab] [varchar](4) NOT NULL,
	[auto_placa] [varchar](10) NOT NULL,
	[auto_nro_asientos] [varchar](2) NOT NULL,
	[auto_transmision] [varchar](20) NOT NULL,
	[auto_version] [varchar](10) NOT NULL,
	[marca_id] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_T_auto] PRIMARY KEY CLUSTERED 
(
	[auto_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_marca]    Script Date: 22/01/2019 22:33:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_marca](
	[marca_id] [uniqueidentifier] NOT NULL,
	[marca_nombre] [varchar](30) NOT NULL,
 CONSTRAINT [PK_T_marca] PRIMARY KEY CLUSTERED 
(
	[marca_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[T_auto]  WITH CHECK ADD  CONSTRAINT [FK_T_auto_T_marca] FOREIGN KEY([marca_id])
REFERENCES [dbo].[T_marca] ([marca_id])
GO
ALTER TABLE [dbo].[T_auto] CHECK CONSTRAINT [FK_T_auto_T_marca]
GO
