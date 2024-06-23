USE GerenciadorFrotas
GO

CREATE TABLE tblEstado (
    id      INT IDENTITY,
    uf  VARCHAR(2),

    CONSTRAINT pk_estado        PRIMARY KEY(id)
)

CREATE TABLE tblSexo (
    id              INT IDENTITY,
    descricao       VARCHAR(30),

    CONSTRAINT pk_sexo         PRIMARY KEY(id)
)

CREATE TABLE tblMarca (
    id              INT IDENTITY,
    nome            VARCHAR(30),
    dataCadastro    DATETIME,

    CONSTRAINT pk_marca         PRIMARY KEY(id)
)

CREATE TABLE tblCategoria (
    id              INT IDENTITY,
    descricao       VARCHAR(30),
    dataCadastro    DATETIME,

    CONSTRAINT pk_categoria     PRIMARY KEY(id)
)

CREATE TABLE tblStatus (
    id          INT IDENTITY,
    descricao   VARCHAR(30),

    CONSTRAINT pk_status        PRIMARY KEY(id)
)

CREATE TABLE tblCidade (
    id          INT IDENTITY,
    cidade      VARCHAR(100),
    estadoId   INT,

    CONSTRAINT pk_cidade        PRIMARY KEY(id),
	CONSTRAINT fk_cidadeEstado  FOREIGN KEY(estadoId) REFERENCES tblEstado
)

CREATE TABLE tblModelo (
    id              INT IDENTITY,
    nome            VARCHAR(30),
    ano             INT,
    dataCadastro    DATETIME,
    marcaId         INT,
    categoriaId     INT,

    CONSTRAINT pk_modelo            PRIMARY KEY(id),
    CONSTRAINT fk_modelo_marca      FOREIGN KEY(marcaId)       REFERENCES tblMarca,
    CONSTRAINT fk_modelo_categoria  FOREIGN KEY(categoriaId)   REFERENCES tblCategoria
)

CREATE TABLE tblUsuario (
    id          INT IDENTITY,
    login       VARCHAR(20),
    nome        VARCHAR(100),
    email       VARCHAR(100),
    senha       VARCHAR(100),
    ativo       BIT,

    CONSTRAINT pk_tarefa        PRIMARY KEY(ID)
)

CREATE TABLE tblColaborador (
    id              INT IDENTITY,
    nome            VARCHAR(100), 
    cpf             VARCHAR(14),
    email           VARCHAR(100),
    dataAdmissao    DATE,
    celular         VARCHAR(15),
    sexoId          INT,
    statusId        INT,
    usuarioId       INT,

    CONSTRAINT pk_colaborador           PRIMARY KEY(id),
    CONSTRAINT fk_colaborador_sexo      FOREIGN KEY(sexoId)     REFERENCES tblSexo,
    CONSTRAINT fk_colaborador_status    FOREIGN KEY(statusId)   REFERENCES tblStatus,
    CONSTRAINT fk_colaborador_usuario   FOREIGN KEY(usuarioId)  REFERENCES tblUsuario
)

CREATE TABLE tblVeiculo (
    id	                    INT IDENTITY,
    placa                   VARCHAR(7),
    chassi                  VARCHAR(17),
    quilometragemInicial    INT,
    quilometragemAtual      INT,
    ativo                   BIT,
    usuarioId               INT,
    modeloId                INT,

    CONSTRAINT pk_veiculo               PRIMARY KEY(id),
    CONSTRAINT fk_veiculo_usuario       FOREIGN KEY(usuarioId)   REFERENCES tblUsuario,
    CONSTRAINT fk_veiculo_modelo        FOREIGN KEY(modeloId)    REFERENCES tblModelo
)

CREATE TABLE tblControle (
    id	                INT IDENTITY,
    dataSaida           DATETIME,
    dataEntrada         DATETIME,
    totalPercorrido     INT,
    concluido           BIT,
    usuarioId           INT,
    colaboradorId       INT,
    veiculoId           INT,

    CONSTRAINT pk_controle              PRIMARY KEY(id),
	CONSTRAINT fk_controle_usuario      FOREIGN KEY(usuarioId)      REFERENCES tblUsuario,
    CONSTRAINT fk_controle_colaborador  FOREIGN KEY(colaboradorId)  REFERENCES tblColaborador,
    CONSTRAINT fk_controle_veiculo      FOREIGN KEY(veiculoId)      REFERENCES tblVeiculo
)

CREATE TABLE tblOficina (
    id              INT IDENTITY,
    razaoSocial     VARCHAR(50),
    nomeFantasia    VARCHAR(50),
    cnpj            VARCHAR(18),
    email           VARCHAR(100),
    urlSite         VARCHAR(100),
    telefone        VARCHAR(15),
    usuarioId       INT,

    CONSTRAINT pk_oficina           PRIMARY KEY(id),
    CONSTRAINT fk_oficina_usuario   FOREIGN KEY(usuarioId) REFERENCES tblUsuario
)

CREATE TABLE tblEnderecoOficina (
    id	            INT IDENTITY,
    logradouro	    VARCHAR(100),
    numero	        INT,
    complemento	    VARCHAR(50),
    bairro	        VARCHAR(50),
    cep	            VARCHAR(9),
    referencia	    VARCHAR(50),
    cidadeId	    INT,
    oficinaId       INT,

    CONSTRAINT pk_enderecoOficina           PRIMARY KEY(id),
	CONSTRAINT fk_enderecoOficina_cidade    FOREIGN KEY(cidadeId)  REFERENCES tblCidade,
    CONSTRAINT fk_enderecoOficina_oficina   FOREIGN KEY(oficinaId) REFERENCES tblOficina
)

CREATE TABLE tblManutencao (
    id          INT IDENTITY,
    descricao   VARCHAR(255),
    orcamento   MONEY,
    dataSaida   DATETIME,
    dataEntrada DATETIME,
    concluido   BIT,
    oficinaId   INT,
    veiculoId   INT, 

    CONSTRAINT pk_manutencao            PRIMARY KEY(id),
    CONSTRAINT fk_manutencao_oficina    FOREIGN KEY(oficinaId) REFERENCES tblOficina,
    CONSTRAINT fk_manutencao_veiculo    FOREIGN KEY(veiculoId) REFERENCES tblVeiculo
)