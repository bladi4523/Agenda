create database Face;
use Face;

Create table contacto (
IdCon int identity(1,1) Primary key,
Nombre varchar(50),
Celular varchar(50),
Email varchar(60),
Direccion varchar(80)
)

Create table Grupo (
IdGru int identity (1,1) primary key,
Nombre varchar(30),
Asignatura varchar(50),
Cuatrimestre varchar(40)
)