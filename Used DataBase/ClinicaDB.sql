CREATE DATABASE ClinicaDB;
GO

USE ClinicaDB;
GO

CREATE TABLE Especialidades (
    EspecialidadID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL
);

CREATE TABLE Medicos (
    MedicoID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    EspecialidadID INT NOT NULL,
    FOREIGN KEY (EspecialidadID) REFERENCES Especialidades(EspecialidadID)
);

CREATE TABLE Pacientes (
    PacienteID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL
);

CREATE TABLE Actividades (
    ActividadID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL
);

CREATE TABLE Atenciones (
    AtencionID INT PRIMARY KEY IDENTITY(1,1),
    Fecha DATE NOT NULL,
    PacienteID INT NOT NULL,
    MedicoID INT NOT NULL,
    EspecialidadID INT NOT NULL,
    ActividadID INT NOT NULL,
    FOREIGN KEY (PacienteID) REFERENCES Pacientes(PacienteID),
    FOREIGN KEY (MedicoID) REFERENCES Medicos(MedicoID),
    FOREIGN KEY (EspecialidadID) REFERENCES Especialidades(EspecialidadID),
    FOREIGN KEY (ActividadID) REFERENCES Actividades(ActividadID)
);
