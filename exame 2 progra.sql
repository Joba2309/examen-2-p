create database DBTeam
go
use DBTeam

CREATE TABLE Equipos (
    id_equipo INT PRIMARY KEY,
    nombre_equipo NVARCHAR(50),
    descripcion NVARCHAR(100),
    estado NVARCHAR(20)
);
INSERT INTO Equipos (nombre_equipo, descripcion, estado)
VALUES ('Equipo1', 'Descripción del Equipo 1', 'Activo');
DELETE FROM Equipos WHERE id_equipo = 1;
SELECT * FROM Equipos WHERE estado = 'Activo';
UPDATE Equipos SET descripcion = 'Nueva descripción' WHERE id_equipo = 1;
