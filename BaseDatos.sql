CREATE DATABASE Usuario
GO

USE inicioUsuario

CREATE TABLE usuarios (
  ID_usuario INT IDENTITY(1,1) PRIMARY KEY,
  nombre NVARCHAR(20) NOT NULL
  )
GO

CREATE PROC mostarUsuario
AS
SELECT * FROM inicioUsuarios
GO

CREATE PROC agregarUsuario
  @nombre NVARCHAR(20)
AS
INSERT INTO inicioUsuario VALUES (@nombre)
GO