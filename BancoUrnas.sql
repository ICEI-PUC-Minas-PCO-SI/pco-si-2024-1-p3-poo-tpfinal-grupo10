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

create table eleicoes(
	id_eleicao int auto_increment,
    nome_eleicao varchar(45) unique,
    id_cargo int not null,
    constraint PK_idEleicao primary key (id_eleicao),
    constraint FK_idCargo foreign key (id_cargo) references cargos(id_cargo)
);

create table votos(
	id_eleicao int not null,
	id_candidato int not null,
    quant_votos int default 0,
	constraint FK_idCandidato foreign key (id_candidato) references candidatos(id_candidato),
    constraint FK_idEleicao foreign key (id_eleicao) references eleicoes(id_eleicao)
);

ALTER TABLE `urnasbr`.`eleicoes` 
CHANGE COLUMN `votos_candidato1` `votos_candidato1` INT(11) NULL DEFAULT 0 ,
CHANGE COLUMN `votos_candidato2` `votos_candidato2` INT(11) NULL DEFAULT 0 ,
CHANGE COLUMN `votos_candidato3` `votos_candidato3` INT(11) NULL DEFAULT 0 ,
CHANGE COLUMN `votos_candidato4` `votos_candidato4` INT(11) NULL DEFAULT 0 ,
CHANGE COLUMN `votos_candidato5` `votos_candidato5` INT(11) NULL DEFAULT 0 ;

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
INSERT INTO cargos(descricao_cargo,tipo_cargo) values ("Nenhum",2);

-- Insert partido TRE
INSERT INTO partidos(nome_partido, sigla, presidente_partido) VALUES ('Tribunal Regional Eleitoral', 'TRE', 'Octavio Augusto');

-- Insert nulo e branco
INSERT INTO candidatos(nome_candidato, cpf_candidato, naturalidade_candidato, partido_candidato, cargo_candidato) VALUES ('VOTOS EM BRANCO', '00000000', 'XXXXXX', 1, 7);
INSERT INTO candidatos(nome_candidato, cpf_candidato, naturalidade_candidato, partido_candidato, cargo_candidato) VALUES ('VOTOS NULOS', '00000000', 'XXXXXX', 1, 7);