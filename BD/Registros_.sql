-- Insertar registros en la tabla Area
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('SECRETARIA DE ALCALDIA', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('OFICINA PROCURADURIA PUBLICA MUNICIPAL', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('OFICINA DE CONTROL INSTITUCIONAL', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('UNIDAD DE SECRETARÍA GENERAL E IMAGEN', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('EQUIPO FUNCIONAL DE REGISTRO CIVIL', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('EQUIPO FUNCIONAL DE IMAGEN INSTITUCIONAL', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('MÓDULO DE ATENCIÓN', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('MESA DE PARTES', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('PORTERIA DE INGRESO DE PERSONAL', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('EQUIPO FUNCIONAL DE ARCHIVO CENTRAL', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('GERENCIA MUNICIPAL', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('SECRETARÍA DE GERENCIA MUNICIPAL', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('GERENCIA DE ADMINISTRACIÓN Y FINANZAS', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('SUB GERENCIA DE TESORERIA', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('SUB GERENCIA DE RECURSOS HUMANOS', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('SUB GERENCIA DE ABASTECIMIENTOS', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('SUB GERENCIA DE BIENES PATRIMONIALES', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('SUB GERENCIA DE CONTABILIDAD', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('GERENCIA DE ADMINISTRACIÓN TRIBUTARIA', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('SUB GERENCIA DE EJECUTORIA COACTIVA', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('GERENCIA DE DESARROLLO URBANO E INFRAESTRUCTURA', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('SUBGERENCIA DE ESTUDIOS DE INVERSIONES', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('SUBGERENCIA DE PLANEAMIENTO URBANO Y CATASTRO', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('GERENCIA DE ASESORIA JURÍDICA', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('GERENCIA DE PLANEAMIENTO, PRESUPUESTO Y DESARROLLO ORGANIZACIONAL', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('EQUIPO FUNCIONAL DE TECNOLOGÍAS DE LA INFORMACIÓN Y COMUNICACIONES', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('GERENCIA DE DESARROLLO SOCIAL Y ECONÓMICO', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('SUBGERENCIA DE GESTIÓN AMBIENTAL Y MANTENIMIENTO', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('ULE SISFOH', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('DEMUNA', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('OMAPED - CIAM', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('ALMACÉN CENTRAL', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('SUBGERENCIA DE SERENAZGO MUNICIPAL', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('SERVICIO CEMENTERIO MUNICIPAL', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('SERVICIO EQUIPO MECÁNICO', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('SUBGERENCIA DE DESARROLLO ECONÓMICO Y TURISMO', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('SERVICIO GRIFO MUNICIPAL', NULL);
INSERT INTO Area (Nombre_Area, Descripcion_Area) VALUES ('SEGURIDAD CIUDADANA', NULL);

-- Insertar registros en la tabla Sede
INSERT INTO Sede(Nombre_Sede, Descripcion) VALUES ('PALACIO MUNICIPAL', NULL);
INSERT INTO Sede(Nombre_Sede, Descripcion) VALUES ('POLIDEPORTIVO', NULL);
INSERT INTO Sede(Nombre_Sede, Descripcion) VALUES ('CASA AGRICULTOR', NULL);
INSERT INTO Sede(Nombre_Sede, Descripcion) VALUES ('CULTURAL', NULL);

-- Insertar registros en la tabla TipoEquipos
INSERT INTO Tipo_Equipo(Nombre, Descripcion) VALUES ('IMPRESORA', NULL);
INSERT INTO Tipo_Equipo(Nombre, Descripcion) VALUES ('MONITOR', NULL);
INSERT INTO Tipo_Equipo(Nombre, Descripcion) VALUES ('LAPTOP', NULL);
INSERT INTO Tipo_Equipo(Nombre, Descripcion) VALUES ('ESTABILIZADOR', NULL);
INSERT INTO Tipo_Equipo(Nombre, Descripcion) VALUES ('CPU', NULL);
INSERT INTO Tipo_Equipo(Nombre, Descripcion) VALUES ('TECLADO', NULL);

-- Insertar registros en la tabla Estado
INSERT INTO Estados(Nombre_Estado, Descripcion_Estado) VALUES ('COMPLETO', NULL);
INSERT INTO Estados(Nombre_Estado, Descripcion_Estado) VALUES ('PENDIENTE', NULL);

-- Insertar registros en la tabla Fallas
INSERT INTO Falla(Nombre_Falla, Descripcion_Falla) VALUES ('NO FUNCIONA', NULL);
INSERT INTO Falla(Nombre_Falla, Descripcion_Falla) VALUES ('INFECCION VIRUS', NULL);
INSERT INTO Falla(Nombre_Falla, Descripcion_Falla) VALUES ('SIN SISTEMAS', NULL);
INSERT INTO Falla(Nombre_Falla, Descripcion_Falla) VALUES ('NO IMPRIME', NULL);
INSERT INTO Falla(Nombre_Falla, Descripcion_Falla) VALUES ('LENTITUD', NULL);
INSERT INTO Falla(Nombre_Falla, Descripcion_Falla) VALUES ('FUNCION ERRATICA', NULL);
INSERT INTO Falla(Nombre_Falla, Descripcion_Falla) VALUES ('SONIDO ANORMAL', NULL);
INSERT INTO Falla(Nombre_Falla, Descripcion_Falla) VALUES ('SIN INTERNET', NULL);

-- Insertar registros en la tabla Otras_actividades
INSERT INTO O_Actividades(Nombre_O_Actividad, Descripcion_O_Actividad) VALUES ('DIAGNOSTICO', NULL);
INSERT INTO O_Actividades(Nombre_O_Actividad, Descripcion_O_Actividad) VALUES ('MANTENIMIENTO', NULL);
INSERT INTO O_Actividades(Nombre_O_Actividad, Descripcion_O_Actividad) VALUES ('INSTALACION', NULL);
INSERT INTO O_Actividades(Nombre_O_Actividad, Descripcion_O_Actividad) VALUES ('ESCANEO', NULL);
INSERT INTO O_Actividades(Nombre_O_Actividad, Descripcion_O_Actividad) VALUES ('CONFIGURACION', NULL);
INSERT INTO O_Actividades(Nombre_O_Actividad, Descripcion_O_Actividad) VALUES ('IMPRESION', NULL);
INSERT INTO O_Actividades(Nombre_O_Actividad, Descripcion_O_Actividad) VALUES ('BACKUPS', NULL);
INSERT INTO O_Actividades(Nombre_O_Actividad, Descripcion_O_Actividad) VALUES ('CAPACITACION', NULL);

-- Insertar registros en la tabla Usuario
INSERT INTO Usuario(DNI,Nombre_Usuario,Apellido_Usuario,Correo,Password ) VALUES ('77235530', 'JESUS LEONEL','CASTRO GUTIERREZ','jescastrog@úpt.pe','77235530');