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

CREATE TABLE [Category] (
    [id] int NOT NULL IDENTITY,
    [Name] NVARCHAR(80) NOT NULL,
    [Slug] VARCHAR(80) NOT NULL,
    CONSTRAINT [PK_Category] PRIMARY KEY ([id])
);
GO

CREATE TABLE [Role] (
    [id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [Slug] nvarchar(max) NULL,
    CONSTRAINT [PK_Role] PRIMARY KEY ([id])
);
GO

CREATE TABLE [Tag] (
    [id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [Slug] nvarchar(max) NULL,
    CONSTRAINT [PK_Tag] PRIMARY KEY ([id])
);
GO

CREATE TABLE [User] (
    [id] int NOT NULL IDENTITY,
    [Name] VARCHAR(80) NOT NULL,
    [Email] VARCHAR(200) NOT NULL,
    [PasswordHash] VARCHAR(255) NOT NULL,
    [Bio] TEXT NOT NULL,
    [Image] VARCHAR(2000) NOT NULL,
    [Slug] VARCHAR(80) NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY ([id])
);
GO

CREATE TABLE [Post] (
    [id] int NOT NULL IDENTITY,
    [Title] VARCHAR(160) NOT NULL,
    [Summary] VARCHAR(255) NOT NULL,
    [Body] TEXT NOT NULL,
    [Slug] VARCHAR(80) NOT NULL,
    [CreateDate] DATETIME NOT NULL,
    [LastUpdateDate] SMALLDATETIME NOT NULL DEFAULT (GETDATE()),
    [Categoryid] int NULL,
    [Authorid] int NULL,
    CONSTRAINT [PK_Post] PRIMARY KEY ([id]),
    CONSTRAINT [FK_Post_Author] FOREIGN KEY ([Authorid]) REFERENCES [User] ([id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Post_Category] FOREIGN KEY ([Categoryid]) REFERENCES [Category] ([id]) ON DELETE CASCADE
);
GO

CREATE TABLE [UserRole] (
    [RoleID] int NOT NULL,
    [UserId] int NOT NULL,
    CONSTRAINT [PK_UserRole] PRIMARY KEY ([RoleID], [UserId]),
    CONSTRAINT [FK_UserRole_RoleId] FOREIGN KEY ([RoleID]) REFERENCES [Role] ([id]) ON DELETE CASCADE,
    CONSTRAINT [FK_UserRole_UserId] FOREIGN KEY ([UserId]) REFERENCES [User] ([id]) ON DELETE CASCADE
);
GO

CREATE TABLE [PostTag] (
    [PostID] int NOT NULL,
    [TagId] int NOT NULL,
    CONSTRAINT [PK_PostTag] PRIMARY KEY ([PostID], [TagId]),
    CONSTRAINT [FK_PostTag_PostId] FOREIGN KEY ([PostID]) REFERENCES [Tag] ([id]) ON DELETE CASCADE,
    CONSTRAINT [FK_PostTag_TagId] FOREIGN KEY ([TagId]) REFERENCES [Post] ([id]) ON DELETE CASCADE
);
GO

CREATE UNIQUE INDEX [IX_Category_Slug] ON [Category] ([Slug]);
GO

CREATE INDEX [IX_Post_Authorid] ON [Post] ([Authorid]);
GO

CREATE INDEX [IX_Post_Categoryid] ON [Post] ([Categoryid]);
GO

CREATE UNIQUE INDEX [IX_Post_Slug] ON [Post] ([Slug]);
GO

CREATE INDEX [IX_PostTag_TagId] ON [PostTag] ([TagId]);
GO

CREATE UNIQUE INDEX [IX_User_Slug] ON [User] ([Slug]);
GO

CREATE INDEX [IX_UserRole_UserId] ON [UserRole] ([UserId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220610165910_InitialCreation', N'6.0.5');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [User] ADD [GitHub] nvarchar(max) NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220610171556_AdicionandoCampoGitHubNoUser', N'6.0.5');
GO

COMMIT;
GO

