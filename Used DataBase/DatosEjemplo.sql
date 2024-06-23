USE ClinicaDB;
GO

-- Insertar datos en la tabla Especialidades
INSERT INTO Especialidades (Nombre) VALUES ('Cirugia'), ('Pediatria'), ('Medicina');

-- Insertar datos en la tabla Medicos
INSERT INTO Medicos (Nombre, EspecialidadID) VALUES 
('Benjamin Soto', 1), 
('Eduardo Cortes', 2), 
('Claudio Gomez', 3);

-- Insertar datos en la tabla Pacientes
INSERT INTO Pacientes (Nombre) VALUES 
('Pedro Peres'), 
('Carlos Solar'), 
('Luis Rojas');

-- Insertar datos en la tabla Actividades
INSERT INTO Actividades (Nombre) VALUES 
('Cirugia Hernia'), 
('Control Medico'), 
('Lectura de Receta');

-- Insertar datos en la tabla Atenciones
INSERT INTO Atenciones (Fecha, PacienteID, MedicoID, EspecialidadID, ActividadID) VALUES 
('2023-09-28', 1, 1, 1, 1),
('2023-09-27', 2, 2, 2, 2),
('2023-09-26', 3, 3, 3, 3);



SELECT MedicoID, Nombre FROM Medicos;
SELECT PacienteID, Nombre FROM Pacientes;
SELECT ActividadID, Nombre FROM Actividades;
SELECT EspecialidadID, Nombre FROM Especialidades;
