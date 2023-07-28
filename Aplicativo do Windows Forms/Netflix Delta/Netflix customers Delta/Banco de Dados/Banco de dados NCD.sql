create table Usuario
( 
	idUsuario int identity(1,1) not null primary key,
	nome varchar(60) not null,
	email varchar(60) not null,
	telefone varchar(13) not null,
	endereco varchar(250) not null,
	dtime varchar(2)not null
);