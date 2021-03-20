IF OBJECT_ID (N'User', N'U') IS NULL 
  BEGIN
    CREATE TABLE [User] (
           Id UNIQUEIDENTIFIER NOT NULL,
           Name VARCHAR(200),
           Email VARCHAR(200) UNIQUE,
           Password VARCHAR(200),
           RefreshToken VARCHAR(8000),
           DataAtualizacao DATETIME
    )

    ALTER TABLE [User] ADD CONSTRAINT USER_PK PRIMARY KEY (Id);
  END
GO