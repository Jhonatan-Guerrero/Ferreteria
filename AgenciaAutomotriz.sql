CREATE DATABASE AgenciaAutomotriz;
USE AgenciaAutomotriz;
DROP DATABASE AgenciaAutomotriz;



-- Tabla de Usuarios
CREATE TABLE Usuarios (
    IdUsuario INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
    ApellidoP VARCHAR(50) NOT NULL,
    ApellidoM VARCHAR(50) NOT NULL,
    FechaNacimiento DATE NOT NULL,
    RFC VARCHAR(13) NOT NULL UNIQUE,
    Usuario VARCHAR(16) NOT NULL UNIQUE,
    Contraseña VARCHAR(40) NOT NULL
);

-- Tabla de Permisos
CREATE TABLE Permisos (
    IdPermiso INT AUTO_INCREMENT PRIMARY KEY,
    Descripcion VARCHAR(50) NOT NULL
);

-- Tabla de Formularios
CREATE TABLE Formularios (
    IdFormulario INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
    Modulo VARCHAR(50) NOT NULL
);

-- Tabla de PermisosUsuario
CREATE TABLE PermisosUsuario (
    IdUsuario INT,
    IdFormulario INT,
    Lectura BOOLEAN DEFAULT FALSE,
    Escritura BOOLEAN DEFAULT FALSE,
    Eliminacion BOOLEAN DEFAULT FALSE,
    Actualizacion BOOLEAN DEFAULT FALSE,
    PRIMARY KEY (IdUsuario, IdFormulario),
    FOREIGN KEY (IdUsuario) REFERENCES Usuarios(IdUsuario),
    FOREIGN KEY (IdFormulario) REFERENCES Formularios(IdFormulario)
);

-- Tabla de Productos
CREATE TABLE Productos (
    CodigoBarras INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Descripcion TEXT,
    Marca VARCHAR(50) NOT NULL
);

-- Tabla de Herramientas
CREATE TABLE Herramientas (
    CodigoHerramienta INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Medida VARCHAR(50) NOT NULL,
    Marca VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(255)
);


INSERT INTO Formularios (Nombre, Modulo) VALUES ('Producto', 'Gestión de Productos');
INSERT INTO Formularios (Nombre, Modulo) VALUES ('Herramientas', 'Gestión de Herramientas');
INSERT INTO Formularios (Nombre, Modulo) VALUES ('Usuarios', 'Gestión de Usuarios');



DELIMITER //


CREATE PROCEDURE p_InsertarUsuario(
    IN _Nombre VARCHAR(50),
    IN _ApellidoP VARCHAR(50),
    IN _ApellidoM VARCHAR(50),
    IN _FechaNacimiento DATE,
    IN _RFC VARCHAR(13),
    IN _Usuario VARCHAR(16),
    IN _Contraseña VARCHAR(40)
)
BEGIN
    INSERT INTO Usuarios (Nombre, ApellidoP, ApellidoM, FechaNacimiento, RFC, Usuario, Contraseña)
    VALUES (_Nombre, _ApellidoP, _ApellidoM, _FechaNacimiento, _RFC, _Usuario, _Contraseña);
END //

DELIMITER //

CREATE PROCEDURE p_ActualizarUsuario(
    IN _IdUsuario INT,
    IN _Nombre VARCHAR(50),
    IN _ApellidoP VARCHAR(50),
    IN _ApellidoM VARCHAR(50),
    IN _FechaNacimiento DATE,
    IN _RFC VARCHAR(13),
    IN _Usuario VARCHAR(16),
    IN _Contraseña VARCHAR(40)
)
BEGIN
    UPDATE Usuarios
    SET Nombre = _Nombre, ApellidoP = _ApellidoP, ApellidoM = _ApellidoM, FechaNacimiento = _FechaNacimiento, 
        RFC = _RFC, Usuario = _Usuario, Contraseña = _Contraseña
    WHERE IdUsuario = _IdUsuario;
END //
DELIMITER ;

DELIMITER //

CREATE PROCEDURE p_EliminarUsuario(
    IN _IdUsuario INT
)
BEGIN
    DELETE FROM Usuarios WHERE IdUsuario = _IdUsuario;
END //
DELIMITER ;

DELIMITER //

CREATE PROCEDURE p_InsertarProducto(
    IN _Nombre VARCHAR(100),
    IN _Descripcion TEXT,
    IN _Marca VARCHAR(50)
)
BEGIN
    INSERT INTO Productos (Nombre, Descripcion, Marca)
    VALUES (_Nombre, _Descripcion, _Marca);
END //
DELIMITER ;


CREATE PROCEDURE p_ActualizarProducto(
    IN _CodigoBarras INT,
    IN _Nombre VARCHAR(100),
    IN _Descripcion TEXT,
    IN _Marca VARCHAR(50)
)
BEGIN
    UPDATE Productos
    SET Nombre = _Nombre, Descripcion = _Descripcion, Marca = _Marca
    WHERE CodigoBarras = _CodigoBarras;
END //

-- Procedimiento para eliminar producto
CREATE PROCEDURE p_EliminarProducto(
    IN _CodigoBarras INT
)
BEGIN
    DELETE FROM Productos WHERE CodigoBarras = _CodigoBarras;
END //


CREATE PROCEDURE p_InsertarHerramienta(
    IN _Nombre VARCHAR(100),
    IN _Medida VARCHAR(50),
    IN _Marca VARCHAR(50),
    IN _Descripcion VARCHAR(255)
)
BEGIN
    INSERT INTO Herramientas (Nombre, Medida, Marca, Descripcion)
    VALUES (_Nombre, _Medida, _Marca, _Descripcion);
END //


CREATE PROCEDURE p_ActualizarHerramienta(
    IN _CodigoHerramienta INT,
    IN _Nombre VARCHAR(100),
    IN _Medida VARCHAR(50),
    IN _Marca VARCHAR(50),
    IN _Descripcion VARCHAR(255)
)
BEGIN
    UPDATE Herramientas
    SET Nombre = _Nombre, Medida = _Medida, Marca = _Marca, Descripcion = _Descripcion
    WHERE CodigoHerramienta = _CodigoHerramienta;
END //


CREATE PROCEDURE p_EliminarHerramienta(
    IN _CodigoHerramienta INT
)
BEGIN
    DELETE FROM Herramientas WHERE CodigoHerramienta = _CodigoHerramienta;
END //


CREATE PROCEDURE p_AsignarPermisosUsuario(
    IN _IdUsuario INT,
    IN _IdFormulario INT,
    IN _Lectura BOOLEAN,
    IN _Escritura BOOLEAN,
    IN _Eliminacion BOOLEAN,
    IN _Actualizacion BOOLEAN
)
BEGIN
    INSERT INTO PermisosUsuario (IdUsuario, IdFormulario, Lectura, Escritura, Eliminacion, Actualizacion)
    VALUES (_IdUsuario, _IdFormulario, _Lectura, _Escritura, _Eliminacion, _Actualizacion);
END //

-- Procedimiento para eliminar permisos de un usuario
CREATE PROCEDURE p_EliminarPermisosUsuario(
    IN _IdUsuario INT,
    IN _IdFormulario INT
)
BEGIN
    DELETE FROM PermisosUsuario
    WHERE IdUsuario = _IdUsuario AND IdFormulario = _IdFormulario;
END //


CREATE PROCEDURE p_InsertarFormulario(
    IN _Nombre VARCHAR(50),
    IN _Modulo VARCHAR(50)
)
BEGIN
    INSERT INTO Formularios (Nombre, Modulo)
    VALUES (_Nombre, _Modulo);
END //


CREATE PROCEDURE p_ActualizarFormulario(
    IN _IdFormulario INT,
    IN _Nombre VARCHAR(50),
    IN _Modulo VARCHAR(50)
)
BEGIN
    UPDATE Formularios
    SET Nombre = _Nombre, Modulo = _Modulo
    WHERE IdFormulario = _IdFormulario;
END //

CREATE PROCEDURE p_EliminarFormulario(
    IN _IdFormulario INT
)
BEGIN
    DELETE FROM Formularios WHERE IdFormulario = _IdFormulario;
END //


CREATE PROCEDURE LoginUsuario(
    IN _Usuario VARCHAR(16),
    IN _Contraseña VARCHAR(40) 
)
BEGIN
    SELECT IdUsuario, Nombre, ApellidoP, ApellidoM, RFC, Usuario
    FROM Usuarios
    WHERE Usuario = _Usuario AND Contraseña = _Contraseña;
END //


CREATE PROCEDURE ObtenerUsuarios()
BEGIN
    SELECT IdUsuario, Nombre, ApellidoP, ApellidoM, FechaNacimiento, RFC, Usuario
    FROM Usuarios;
END //


DELIMITER //
CREATE PROCEDURE ObtenerPermisosUsuario(
    IN _IdUsuario INT
)
BEGIN
    SELECT 
        pu.IdFormulario,
        f.Nombre AS NombreFormulario,
        pu.Lectura,
        pu.Escritura,
        pu.Eliminacion,
        pu.Actualizacion
    FROM PermisosUsuario pu
    INNER JOIN Formularios f ON pu.IdFormulario = f.IdFormulario
    WHERE pu.IdUsuario = _IdUsuario;
END //

DELIMITER ;

INSERT INTO Usuarios (Nombre, ApellidoP, ApellidoM, FechaNacimiento, RFC, Usuario, Contraseña)
VALUES ('Admin', 'Admin', 'Admin', '1990-01-01', 'XAXX010101000', 'admin', SHA1('123'));
UPDATE Usuarios
SET Contraseña =SHA1('123')
WHERE Usuario = 'admin'; 
INSERT INTO Usuarios (Nombre, ApellidoP, ApellidoM, FechaNacimiento, RFC, Usuario, Contraseña)
VALUES ('Juan', 'Pérez', 'García', '1995-05-10', 'PEJG950510123', 'juan', SHA1('456'));
INSERT INTO Usuarios (Nombre, ApellidoP, ApellidoM, FechaNacimiento, RFC, Usuario, Contraseña)
VALUES ('Jose', 'Pérez', 'García', '1995-05-10', 'AEJG950510123', 'jose', SHA1('456'));
INSERT INTO PermisosUsuario (IdUsuario, IdFormulario,Lectura, Escritura, Eliminacion, Actualizacion)
VALUES 
    (1, 1, TRUE,TRUE, TRUE, TRUE),  
    (1, 2, TRUe,TRUE, TRUE, TRUE),  
    (1, 3, TRUE,TRUE, TRUE, TRUE);  
INSERT INTO PermisosUsuario (IdUsuario, IdFormulario, Lectura, Escritura, Eliminacion, Actualizacion)
VALUES 
    (2, 1, TRUE, TRUE, FALSE, FALSE),  
    (2, 2, FALSE, FALSE, FALSE, FALSE), 
    (2, 3, TRUE, True, False, True); 
INSERT INTO PermisosUsuario (IdUsuario, IdFormulario,Lectura, Escritura, Eliminacion, Actualizacion)
VALUES 
    (4, 1, FALSE, FALSE, FALSE, FALSE),  
    (4, 2, FALSE, FALSE, FALSE, FALSE),  
    (4, 3, FALSE, FALSE, FALSE, FALSE);
TRUNCATE PermisosUsuario;
	  
SELECT *FROM formularios;
SELECT * FROM Usuarios WHERE Usuario = 'admin';
TRUNCATE usuarios;

CREATE PROCEDURE LoginUsuario(
    IN _Usuario VARCHAR(16),
    IN _Contraseña VARCHAR(40)
)
BEGIN
    SELECT IdUsuario, Nombre, ApellidoP, ApellidoM, RFC, Usuario
    FROM Usuarios
    WHERE Usuario = _Usuario AND Contraseña = _Contraseña;
END;
DROP PROCEDURE LoginUsuario;
SELECT *FROM permisosusuario;
TRUNCATE permisosusuario;
SELECT *FROM usuarios;
SELECT * FROM PermisosUsuario WHERE IdUsuario = 2; 
SELECT *FROM formularios;
SELECT *FROM usuarios;
SHOW TABLES;