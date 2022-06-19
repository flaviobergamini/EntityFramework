USE [Master]
GO

DROP DATABASE IF EXISTS [Pantanal]     -- Use com cuidado
GO

CREATE DATABASE [Pantanal]
GO 

USE [Pantanal]
GO 

CREATE TABLE [Animal](
    [id_animal] INT NOT NULL IDENTITY(1,1),
    [especie] NVARCHAR(30) NOT NULL,
    [alimentacao] NVARCHAR(100) NOT NULL,
    [sexo] NVARCHAR(1) NOT NULL CHECK([sexo] IN('M', 'F')),
    CONSTRAINT [PK_Animal] PRIMARY KEY([id_animal])
)

CREATE TABLE [Planta](
    [id_planta] INT NOT NULL IDENTITY(1,1),
    [especie] NVARCHAR(30) NOT NULL,
    [grupo] NVARCHAR(100) NOT NULL,
    CONSTRAINT [PK_Planta] PRIMARY KEY([id_planta])
)

CREATE TABLE [Responsavel](
    [id_responsavel] INT NOT NULL IDENTITY(1,1),
    [nome] NVARCHAR(100) NOT NULL,
    [cpf] NVARCHAR(14) NOT NULL,
    [profissao] NVARCHAR(40) NOT NULL,
    [email] NVARCHAR(50),
    CONSTRAINT [PK_Responsavel] PRIMARY KEY([id_responsavel]),
    CONSTRAINT [UQ_CPF] UNIQUE([cpf])
)

CREATE TABLE [Parque](
    [id_parque] INT NOT NULL IDENTITY(1,1),
    [localizacao] NVARCHAR(30) NOT NULL,
    [area] FLOAT NOT NULL,
    [relevo] NVARCHAR(15) NOT NULL,
    [fk_animal] INT,
    [fk_planta] INT,
    CONSTRAINT [PK_Parque] PRIMARY KEY([id_parque]),
    CONSTRAINT [FK_Animal] FOREIGN KEY([fk_animal]) REFERENCES [Animal]([id_animal]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_Planta] FOREIGN KEY([fk_planta]) REFERENCES [Planta]([id_planta]) ON DELETE CASCADE ON UPDATE CASCADE
)

CREATE TABLE [Pertence](
    fk_responsavel INT NOT NULL,
    fk_parque INT NOT NULL,
    CONSTRAINT [PK_Pertence] PRIMARY KEY([fk_responsavel], [fk_parque]),
    CONSTRAINT [FK_Responsavel] FOREIGN KEY([fk_responsavel]) REFERENCES [Responsavel]([id_responsavel]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_Parque] FOREIGN KEY([fk_parque]) REFERENCES [Parque]([id_parque]) ON DELETE CASCADE ON UPDATE CASCADE

)