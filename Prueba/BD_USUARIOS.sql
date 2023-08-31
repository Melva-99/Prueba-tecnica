CREATE DATABASE BD_USUARIOS

create table Sexos(
IdSexo int primary key Identity,
Sexo char(1)
);

INSERT INTO Sexos(Sexo) values ('F'),('M')

create table Usuarios(
Id int primary key IDENTITY(0,1),
Nombre varchar(30),
Apellido varchar (30),
Identidad numeric(13),
FKSexo int,
Celular numeric(8),
Correo varchar(50),
Usuario varchar(30),
Foreign Key(FKSexo) references Sexos(IdSexo)
);


CREATE PROCEDURE Insertar
    @Nombre varchar(30),
	@Apellido varchar (30),
	@Identidad numeric(13),
	@Sexo char(1),
	@Celular numeric(8),
	@Correo varchar(50),
	@Usuario varchar(30)
AS
BEGIN
	IF NOT EXISTS (SELECT Identidad from Usuarios WHERE Identidad = Identidad)
		INSERT INTO Usuarios(Nombre,Apellido,Identidad,FKSexo,Celular,Correo,Usuario)
		VALUES(@Nombre,@Apellido,@Identidad,@Sexo,@Celular,@Correo,@Usuario)
	ELSE
		RAISERROR('Ya existe ese usuario',16,1)
		
END;


CREATE PROCEDURE mostrar
as
SELECT Id as 'Id', Nombre as 'Nombre', Apellido as 'Apellido', Identidad as 'Identidad', Sexo as 'Sexo', Celular as 'Celular', Correo as 'Correo', Usuario as 'Usuario' from Usuarios
INNER JOIN Sexos ON Sexos.IdSexo = Usuarios.FKSexo;
go


CREATE PROCEDURE modificar
	@Id int,
    @Nombre varchar(30),
	@Apellido varchar (30),
	@Identidad numeric(13),
	@Sexo char(1),
	@Celular numeric(8),
	@Correo varchar(50),
	@Usuario varchar(30)
AS
    UPDATE Usuarios SET Nombre = @Nombre, Apellido = @Apellido, Identidad = @Identidad, FKSexo = @Sexo, Celular = @Celular, Correo = @Correo, Usuario = @Usuario
	WHERE Id = @Id


CREATE PROCEDURE eliminar
@Id INT
AS BEGIN
DELETE FROM [dbo].[Usuarios] 
	WHERE Id = @Id
END