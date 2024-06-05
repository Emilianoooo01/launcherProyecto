CREATE DATABASE Usuario
GO

USE Usuario

CREATE TABLE usuarios (
  ID_usuario INT IDENTITY(1,1) PRIMARY KEY,
  nombre NVARCHAR(20) NOT NULL
  )
GO

CREATE PROC mostrarUsuario
AS
SELECT * FROM Usuario
GO

CREATE PROC agregarUsuario
  @nombre NVARCHAR(20)
AS
INSERT INTO Usuario VALUES (@nombre)
GO