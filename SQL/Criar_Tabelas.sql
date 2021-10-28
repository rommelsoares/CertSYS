CREATE TABLE [usuario]
( 
	[usu_cod]            int  NOT NULL  IDENTITY ( 1,1 ) ,
	[usu_nome]           varchar(95)  NULL ,
	[usu_login]          varchar(15)  NULL ,
	[usu_senha]          varchar(15)  NULL
)
go

ALTER TABLE [usuario]
	ADD CONSTRAINT [XPKusuario] PRIMARY KEY  NONCLUSTERED ([usu_cod] ASC)
go

CREATE TABLE [fornecedor]
( 
	[for_cod]            int  NOT NULL  IDENTITY ( 1,1 ) ,
	[for_nome]           varchar(95)  NULL ,
	[for_cnpj]           varchar(95)  NULL ,
	[for_endereco]       varchar(95)  NULL
)
go

ALTER TABLE [fornecedor]
	ADD CONSTRAINT [XPKfornecedor] PRIMARY KEY  NONCLUSTERED ([for_cod] ASC)
go

CREATE TABLE [produto]
( 
	[pro_cod]            int  NOT NULL  IDENTITY ( 1,1 ) ,
	[pro_nome]           varchar(95)  NULL ,
	[pro_qtde]           float  NULL,
	[for_cod]            int  NOT NULL
	CONSTRAINT PK_fornecedor_pro_cod PRIMARY KEY(pro_cod),
	CONSTRAINT FK_produto_fornecedor_for_cod FOREIGN KEY(for_cod) REFERENCES [fornecedor](for_cod)
)
go

ALTER TABLE [produto] ALTER COLUMN [pro_qtde] varchar(95) ;  
GO  