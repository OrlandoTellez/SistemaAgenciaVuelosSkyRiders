CREATE DATABASE BaseDeDatosAgenciaVuelosSkyRiders

USE	BaseDeDatosAgenciaVuelosSkyRiders



-- TABLA DE USUARIO 
CREATE TABLE usuario(
	id BIGINT IDENTITY(1, 1) NOT NULL,
	numeroCliente VARCHAR(900) NOT NULL,
	nombre VARCHAR(50) NOT NULL,
	correoUsuario varchar(50) NOT NULL,
	password VARCHAR(15) NOT NULL,
	FOREIGN KEY (numeroCliente) REFERENCES clientes(numeroCliente)
)

drop table usuario

Select * from usuario

-- TABLA DE CLIENTES
CREATE TABLE clientes (
    numeroCliente VARCHAR(900) PRIMARY KEY NOT NULL,
    nombre VARCHAR(100) NOT NULL,
    apellido VARCHAR(100) NOT NULL,
    telefono VARCHAR(15) NOT NULL
)

SELECT TOP 1 numeroCliente FROM clientes ORDER BY numeroCliente DESC;

Drop table clientes
Select * from clientes
Select * from vuelos
select * from reservas

SELECT * FROM clientes WHERE numeroCliente = @numeroCliente

-- TABLA VUELOS
CREATE TABLE vuelos (
    numeroVuelo VARCHAR(900) PRIMARY KEY NOT NULL,
	origen VARCHAR(100) NOT NULL,
    destino VARCHAR(100) NOT NULL,
    fechaSalida DATE NOT NULL,
    fechaLlegada DATE NOT NULL,
    horaSalida TIME NOT NULL,
    horaLlegada TIME NOT NULL,
	clase VARCHAR(30) NOT NULL,
);

DROP TABLE vuelos
select * from vuelos

-- TABLA RESERVAS
CREATE TABLE reservas (
    codigoReserva VARCHAR(900) PRIMARY KEY NOT NULL,
    numeroCliente VARCHAR(900) NOT NULL,
    numeroVuelo VARCHAR(900) NOT NULL,
    fechaReserva DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    cantidadPasajeros INT NOT NULL,
    FOREIGN KEY (numeroCliente) REFERENCES clientes(numeroCliente),
    FOREIGN KEY (numeroVuelo) REFERENCES vuelos(numeroVuelo)
);

SELECT * from reservas
drop table reservas

SELECT TOP 1 codigoReserva FROM reservas ORDER BY codigoReserva DESC;


CREATE TABLE pasajeros(
	numeroPasajero VARCHAR(900) PRIMARY KEY NOT NULL,
	codigoReserva VARCHAR(900),
	nombrePasajero VARCHAR(30) NOT NULL,
	apellidoPasajero VARCHAR(30) NOT NULL,
	pasaportePasajero VARCHAR(25) NOT NULL,
	correoPasajero VARCHAR(50) NOT NULL,
	asiento VARCHAR(6) NOT NULL,
	FOREIGN KEY (codigoReserva) REFERENCES reservas(codigoReserva),
)

drop table pasajeros

SELECT TOP 1 numeroPasajero FROM pasajeros ORDER BY numeroPasajero DESC

CREATE TABLE pagos(
	codigoReserva VARCHAR(900) NOT NULL,
	metodoPago VARCHAR(30) NOT NULL,
	tarjeta VARCHAR(25) NOT NULL,
	montoTotal MONEY NOT NULL,
	FOREIGN KEY (codigoReserva) REFERENCES reservas(codigoReserva),
)

DROP TABLE pagos





-- PROCEDIMIENTO ALMACENADO PARA VERIFICARUSUARIO
CREATE PROCEDURE VerificarUsuario
    @NombreUsuario NVARCHAR(50), 
    @Password NVARCHAR(50)      
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM usuario
    WHERE nombre = @NombreUsuario AND Password = @Password;
END;

-- PROCEDIMIENTO ALMACENADO PARA VERIFICAR CLIENTE
CREATE PROCEDURE VerificarCliente
    @usuario NVARCHAR(50),          
    @password NVARCHAR(15)          
AS
BEGIN
    SET NOCOUNT ON;
    SELECT c.numeroCliente

    FROM usuario u
    INNER JOIN clientes c ON u.numeroCliente = c.numeroCliente
    WHERE u.nombre = @usuario AND u.password = @password;
END;

-- PROCEDIMIENTO ALMACENADO PARA EL REGISTRO DE USUARIOS Y AUTENTICACION
CREATE PROCEDURE RegistrarUsuario
    @numeroCliente VARCHAR(900),
    @nombre VARCHAR(50),
    @correoUsuario VARCHAR(50),
    @password VARCHAR(15)
AS
BEGIN
    SET NOCOUNT ON;
	IF EXISTS (SELECT 1 FROM usuario WHERE nombre = @nombre)
    BEGIN
        RAISERROR('El usuario ya existe.', 16, 1)
        RETURN
    END
    INSERT INTO usuario (numeroCliente, nombre, correoUsuario, password) VALUES (@numeroCliente, @nombre, @correoUsuario, @password);
END;

-- PROCEDIMIENTO ALMACENADO PARA REGISTRAR CLIENTES
CREATE PROCEDURE RegistrarCliente
	@numeroCliente VARCHAR(100),
    @clienteNombre VARCHAR(50), 
    @clienteApellido VARCHAR(50),
	@clienteTelefono VARCHAR(15)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO clientes VALUES (@numeroCliente, @clienteNombre, @clienteApellido,  @clienteTelefono)
END;

-- PROCEDIMIENTO ALMACENADO PARA REGISTRAR VUELOS
CREATE PROCEDURE RegistrarVuelo
	@numeroVuelo VARCHAR(100),
    @Origen VARCHAR(50), 
    @Destino VARCHAR(50),
	@FechaSalida DATE,
	@FechaLlegada DATE,
	@HoraSalida TIME,
	@HoraLlegada TIME,
	@Clase VARCHAR(15)

AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO vuelos VALUES (@numeroVuelo, @Origen, @Destino, @FechaSalida, @FechaLlegada, @HoraSalida, @HoraLlegada, @Clase)
END;

-- PROCEDIMIENTO ALMACENADO PARA REGISTRAR RESERVAS
CREATE PROCEDURE RegistrarReserva
    @codigoReserva VARCHAR(900),
    @numeroCliente VARCHAR(900),
    @numeroVuelo VARCHAR(900),
    @fechaReserva DATETIME = NULL, 
    @cantidadPasajeros INT
AS
BEGIN
    SET NOCOUNT ON;
    IF @fechaReserva IS NULL
        SET @fechaReserva = GETDATE();
    INSERT INTO reservas (codigoReserva, numeroCliente, numeroVuelo, fechaReserva, cantidadPasajeros)
    VALUES (@codigoReserva, @numeroCliente, @numeroVuelo, @fechaReserva, @cantidadPasajeros);
END;

-- PROCEDIMIENTO ALMACENADO PARA REGISTRAR PASAJEROS
CREATE PROCEDURE RegistrarPasajeros
	@numeroPasajeros VARCHAR(100),
    @codigoReserva VARCHAR(900), 
    @pasajeroNombre VARCHAR(30), 
    @pasajeroApellido VARCHAR(30),
	@pasajeroPasaporte VARCHAR(25),
	@pasajeroCorreo VARCHAR(50),
	@asiento VARCHAR(6)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO pasajeros (numeroPasajero, codigoReserva, nombrePasajero, apellidoPasajero, pasaportePasajero, correoPasajero, asiento)
    VALUES (@numeroPasajeros, @codigoReserva, @pasajeroNombre, @pasajeroApellido, @pasajeroPasaporte, @pasajeroCorreo, @asiento);
END;

-- PROCEDIMIENTO ALMACENADO PARA REGISTRAR PAGOS
CREATE PROCEDURE RegistrarPagos
    @codigoReserva VARCHAR(900), 
    @metodoPago VARCHAR(50), 
	@tarjeta VARCHAR(50),
	@montoTotal VARCHAR(6)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO pagos 
    VALUES (@codigoReserva, @metodoPago, @tarjeta, @montoTotal);
END;


-- CONSULTAS
SELECT * FROM clientes WHERE numeroCliente = @numeroCliente

SELECT TOP 1 numeroVuelo FROM vuelos ORDER BY numeroVuelo DESC;


select * from usuario
Select * from clientes
select * from pasajeros
Select * from vuelos
select * from reservas
select * from pagos

Drop table clientes
Drop table usuario
Drop table pasajeros
Drop table vuelos
Drop table reservas
Drop table pagos
