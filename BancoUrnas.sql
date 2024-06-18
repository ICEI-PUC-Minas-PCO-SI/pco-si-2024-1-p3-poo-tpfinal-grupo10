create schema UrnasBr;
create table partidos(
	id int auto_increment,
    nome_partido varchar(50) not null,
    sigla varchar(5) not null,
    presidente_partido varchar(50) not null,
    constraint PK_idPartido primary key (id)
);

create table tipoCargo(
	id_tipo int not null,
    descricao varchar(30),
    constraint PK_idTipo primary key (id_tipo)
);

create table cargos(
	id_cargo int auto_increment,
    descricao_cargo varchar(50) not null,
    tipo_cargo int not null,
    constraint PK_idCargo primary key (id_cargo),
    constraint FK_tipoCargo foreign key (tipo_cargo) references tipoCargo(id_tipo)
);

create table candidatos(
	id_candidato int auto_increment,
    nome_candidato varchar(50) not null,
    cpf_candidato varchar(11) not null,
    naturalidade_candidato varchar(50) not null,
    partido_candidato int not null,
    cargo_candidato int not null,
    constraint PK_idPartido primary key (id_candidato),
    constraint FK_partidoCandidato foreign key (partido_candidato) references partidos(id),
    constraint FK_cargoCandidato foreign key (cargo_candidato) references cargos(id_cargo)
);

-- Insert do Tipo de cargo
INSERT INTO tipoCargo(id_tipo, descricao) values (1,"Executivo");
INSERT INTO tipoCargo(id_tipo, descricao) values (2,"Legislativo");

-- Insert dos Cargos políticos
INSERT INTO cargos(descricao_cargo,tipo_cargo) values ("Presidente",1);
INSERT INTO cargos(descricao_cargo,tipo_cargo) values ("Governador",1);
INSERT INTO cargos(descricao_cargo,tipo_cargo) values ("Prefeito",1);
INSERT INTO cargos(descricao_cargo,tipo_cargo) values ("Deputado Estadual",2);
INSERT INTO cargos(descricao_cargo,tipo_cargo) values ("Deputado Federal",2);
INSERT INTO cargos(descricao_cargo,tipo_cargo) values ("Vereador",2);