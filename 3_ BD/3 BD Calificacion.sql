CREATE DATABASE ESCUELA

USE ESCUELA
CREATE TABLE Calificacion
(
	ID INT PRIMARY KEY  NOT NULL,
	Nombre VARCHAR(40) NOT NULL,
	Apellido_Paterno VARCHAR (40) NOT NULL,
    Apellido_Materno VARCHAR (40) NOT NULL,
    Calificacion FLOAT (10) NOT NULL,
    Salon VARCHAR (10) NOT NULL,
);

INSERT INTO Calificacion (ID,Nombre,Apellido_Paterno,Apellido_Materno,Calificacion,Salon)
VALUES (1,'Hugo','Palomino','Avila',9.9,'A')
INSERT INTO Calificacion (ID,Nombre,Apellido_Paterno,Apellido_Materno,Calificacion,Salon)
VALUES (2,'Nia','Perez','Lopez',7.9,'B')
INSERT INTO Calificacion (ID,Nombre,Apellido_Paterno,Apellido_Materno,Calificacion,Salon)
VALUES (3,'Brenda','Lopez','Argudo',9.7,'A')
INSERT INTO Calificacion (ID,Nombre,Apellido_Paterno,Apellido_Materno,Calificacion,Salon)
VALUES (4,'Jore','Ramirez','Gonzalez',9.9,'B')
INSERT INTO Calificacion (ID,Nombre,Apellido_Paterno,Apellido_Materno,Calificacion,Salon)
VALUES (5,'Lilia','Olivo','Zepeda',5.9,'A')
INSERT INTO Calificacion (ID,Nombre,Apellido_Paterno,Apellido_Materno,Calificacion,Salon)
VALUES (6,'Brandon','Zepeda','Olvo',8.9,'A')
INSERT INTO Calificacion (ID,Nombre,Apellido_Paterno,Apellido_Materno,Calificacion,Salon)
VALUES (7,'Mauricio','Sevilla','Britto',9.7,'A')
INSERT INTO Calificacion (ID,Nombre,Apellido_Paterno,Apellido_Materno,Calificacion,Salon)
VALUES (8,'Monica','Valde','Leon',9.6,'A')
INSERT INTO Calificacion (ID,Nombre,Apellido_Paterno,Apellido_Materno,Calificacion,Salon)
VALUES (9,'Antonio','Suarez','Prado',7.9,'A')
INSERT INTO Calificacion (ID,Nombre,Apellido_Paterno,Apellido_Materno,Calificacion,Salon)
VALUES (10,'Carmen','Castano','Monte',8.8,'A')
INSERT INTO Calificacion (ID,Nombre,Apellido_Paterno,Apellido_Materno,Calificacion,Salon)
VALUES (11,'Natalia','Cordoba','Vivian',10.0,'A')
INSERT INTO Calificacion (ID,Nombre,Apellido_Paterno,Apellido_Materno,Calificacion,Salon)
VALUES (12,'Cesar','Marrugo','Florez',5.9,'A')
INSERT INTO Calificacion (ID,Nombre,Apellido_Paterno,Apellido_Materno,Calificacion,Salon)
VALUES (13,'Cesar','Javier','Hernandez',6.9,'A')
INSERT INTO Calificacion (ID,Nombre,Apellido_Paterno,Apellido_Materno,Calificacion,Salon)
VALUES (14,'Monica','Lucia','Blanco',8.9,'A')
INSERT INTO Calificacion (ID,Nombre,Apellido_Paterno,Apellido_Materno,Calificacion,Salon)
VALUES (15,'Cristian','Lopez','Gonzalez',8.9,'A')

SELECT TOP 10 Nombre,Calificacion
FROM Calificacion
ORDER BY Calificacion DESC;

SELECT TOP 10 Nombre,Calificacion
FROM Alumno
INNER JOIN Calificacion
ON Alumno.id_User = Alumno.id_User
ORDER BY Calificacion DESC;