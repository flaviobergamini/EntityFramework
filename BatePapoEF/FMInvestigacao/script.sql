IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Vilao] (
    [idVilao] int NOT NULL IDENTITY,
    [nome] VARCHAR(45) NOT NULL,
    [numCrime] INT NOT NULL,
    CONSTRAINT [PK_Vilao] PRIMARY KEY ([idVilao])
);
GO

CREATE TABLE [Crime] (
    [idCrime] int NOT NULL IDENTITY,
    [data] DATETIME NOT NULL,
    [nome] VARCHAR(45) NOT NULL,
    [local] VARCHAR(45) NULL,
    [duracao] INT NOT NULL,
    [VilaoidVilao] int NULL,
    CONSTRAINT [PK_Crime] PRIMARY KEY ([idCrime]),
    CONSTRAINT [FK_Vilao_Crime] FOREIGN KEY ([VilaoidVilao]) REFERENCES [Vilao] ([idVilao]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Crime_VilaoidVilao] ON [Crime] ([VilaoidVilao]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220619200257_migration1', N'6.0.6');
GO

COMMIT;
GO

