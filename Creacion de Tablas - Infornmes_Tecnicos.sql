-- Crear la base de datos
CREATE DATABASE Muni_InformesTecnicos;
GO

-- Usar la base de datos creada
USE Muni_InformesTecnicos;
GO

-- Crear la tabla Usuario
CREATE TABLE Usuario (
    UsuarioID INT PRIMARY KEY IDENTITY(1,1),
    DNI NVARCHAR(100),
    Nombre_Usuario NVARCHAR(100),
    Apellido_Usuario NVARCHAR(100),
    Correo NVARCHAR(100),
    Password NVARCHAR(100)
);

-- Crear la tabla Area
CREATE TABLE Area (
    AreaID INT PRIMARY KEY IDENTITY(1,1),
    Nombre_Area NVARCHAR(100),
    Descripcion_Area NVARCHAR(255)
);

-- Crear la tabla Estados
CREATE TABLE Estados (
    EstadoID INT PRIMARY KEY IDENTITY(1,1),
    Nombre_Estado NVARCHAR(50),
    Descripcion_Estado NVARCHAR(255)
);

-- Crear la tabla Falla
CREATE TABLE Falla (
    FallaID INT PRIMARY KEY IDENTITY(1,1),
    Nombre_Falla NVARCHAR(50),
    Descripcion_Falla NVARCHAR(255)
);

-- Crear la tabla O_Actividades
CREATE TABLE O_Actividades (
    O_ActividadesID INT PRIMARY KEY IDENTITY(1,1),
    Nombre_O_Actividad NVARCHAR(50),
    Descripcion_O_Actividad NVARCHAR(255)
);

-- Crear la tabla Sede
CREATE TABLE Sede (
    SedeID INT PRIMARY KEY IDENTITY(1,1),
    Nombre_Sede NVARCHAR(50),
    Descripcion NVARCHAR(255)
);

-- Crear la tabla Tipo_Equipo
CREATE TABLE Tipo_Equipo (
    Tipo_EquipoID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100),
    Descripcion NVARCHAR(255)
);

-- Crear la tabla Equipo
CREATE TABLE Equipo (
    EquipoID INT PRIMARY KEY IDENTITY(1,1),
    Nombre_Equipo NVARCHAR(100),
    Tipo NVARCHAR(100),
    Color NVARCHAR(255),
    Serie NVARCHAR(255),
    Cod_Patrimonial NVARCHAR(255),
    Sub_Tipo NVARCHAR(100),
    Modelo NVARCHAR(100),
    Marca NVARCHAR(100),
    Codigo_Interno NVARCHAR(100),
	Observaciones NVARCHAR(100),
	Ingreso date
);

-- Crear la tabla Informes con las relaciones
CREATE TABLE Informes (
    InformeID INT PRIMARY KEY IDENTITY(1,1),
    Titulo NVARCHAR(255),
    Fecha_Solicitud DATE,
    Fecha_Informe DATE,
    Diagnostico NVARCHAR(1000),
    Solucion_Primaria NVARCHAR(1000),
    EstadoID INT,
    UsuarioID INT,
    Tipo_EquipoID INT,
    AreaID INT,
    SedeID INT,
    FallaID INT,
    O_ActividadesID INT,
    EquipoID INT,
    FOREIGN KEY (EstadoID) REFERENCES Estados(EstadoID),
    FOREIGN KEY (UsuarioID) REFERENCES Usuario(UsuarioID),
    FOREIGN KEY (Tipo_EquipoID) REFERENCES Tipo_Equipo(Tipo_EquipoID),
    FOREIGN KEY (AreaID) REFERENCES Area(AreaID),
    FOREIGN KEY (SedeID) REFERENCES Sede(SedeID),
    FOREIGN KEY (FallaID) REFERENCES Falla(FallaID),
    FOREIGN KEY (O_ActividadesID) REFERENCES O_Actividades(O_ActividadesID),
    FOREIGN KEY (EquipoID) REFERENCES Equipo(EquipoID)
);
