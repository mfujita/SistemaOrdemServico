create table cadFunc (
	idFunc int primary key not null identity,
	cpf nvarchar(11) ,
	nome nvarchar(60),
	sexo char,
	dtNasc date,
	endereço nvarchar(40),
	cep nvarchar(8),
	telefone nvarchar(10),
	celular nvarchar(11),
	email nvarchar(50)
)

create table cadClientForn (
	idCad int primary key not null identity,
	cpfCnpj nvarchar(15) ,
	categoria nvarchar(15),
	nomeRazSoc nvarchar(60),
	endereço nvarchar(40),
	bairro nvarchar(40),
	numero nvarchar(20),
	cep nvarchar(8),
	telefone nvarchar(10),
	celular nvarchar(11),
	email nvarchar(50)
)

create table cadPeca (
	codPeca int primary key identity,
	nomePeca nvarchar(60),
	fkFornecedor integer,
	foreign key (fkFornecedor) references cadClientForn(idCad),
	fabricante nvarchar(40),
	vlCompra numeric (8,2),
	vlVenda numeric (8,2)
)

create table cadOrcamento (
	idOrc int primary key identity,
	fkClienteForn integer,
	foreign key (fkClienteForn) references cadClientForn(idCad),
	dtEntrada date,
	descricao text,
	vlServico numeric (8,2),

)

create table cadOrdemServico (
	idOrdemServiço int primary key identity,
	dtEntrada date,
	dtGarantia date,
	fkFunc integer,
	foreign key (fkFunc) references cadFunc(idFunc),
	fkPeca integer,
	foreign key (fkPeca) references cadPeca(codPeca),
	vlOrdemServico numeric (8,2),
)