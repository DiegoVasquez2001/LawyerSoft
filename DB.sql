CREATE DATABASE sys_agenda;
USE sys_agenda;

-- TABLA CLIENTE
CREATE TABLE cliente
(dpi_cliente VARCHAR(20) PRIMARY KEY,
nombre_cliente VARCHAR(100) NOT NULL,
apellido_cliente VARCHAR(100) NOT NULL,
telefono_cliente VARCHAR(8) NOT NULL, 
celular_cliente VARCHAR(8) NOT NULL,
correo_cliente VARCHAR(100) NOT NULL,
direccion_cliente VARCHAR(60) NOT NULL
);

-- TABLA EXPEDIENTE
CREATE TABLE expediente
(numero_expediente INT PRIMARY KEY, 
tipo_expediente VARCHAR(20) NOT NULL,
estado_expediente VARCHAR(10) NOT NULL,
fecha_expediente DATE NOT NULL,
FK_cliente VARCHAR(20) FOREIGN KEY REFERENCES cliente(dpi_cliente)
);

-- TABLA CITA
CREATE TABLE cita
(id_cita VARCHAR(50) PRIMARY KEY,
fecha_cita DATE NOT NULL,
hora_cita VARCHAR(5) NOT NULL,
asunto_cita VARCHAR(255) NOT NULL,
FK_cliente VARCHAR(20) FOREIGN KEY REFERENCES cliente(dpi_cliente)
);

-- PROCEDIMIENTO ALMACENADO: REGISTRAR CLIENTE
CREATE PROCEDURE RegistrarCliente
@dpi_cliente VARCHAR(20),
@nombre_cliente VARCHAR(100),
@apellido_cliente VARCHAR(100),
@telefono_cliente VARCHAR(8), 
@celular_cliente VARCHAR(8),
@correo_cliente VARCHAR(100),
@direccion_cliente VARCHAR(60)
AS
BEGIN
	INSERT INTO cliente VALUES(@dpi_cliente, @nombre_cliente, @apellido_cliente, @telefono_cliente, @celular_cliente, @correo_cliente, @direccion_cliente);
END

-- PROCEDIMIENTO ALMACENADO: EDITAR CLIENTE
CREATE PROCEDURE EditarCliente
@dpi_cliente VARCHAR(20),
@nombre_cliente VARCHAR(100),
@apellido_cliente VARCHAR(100),
@telefono_cliente VARCHAR(8), 
@celular_cliente VARCHAR(8),
@correo_cliente VARCHAR(100),
@direccion_cliente VARCHAR(60)
AS
BEGIN
	UPDATE cliente SET nombre_cliente = @nombre_cliente, apellido_cliente = @apellido_cliente, telefono_cliente = @telefono_cliente, celular_cliente = @celular_cliente, correo_cliente = @correo_cliente, direccion_cliente = @direccion_cliente WHERE dpi_cliente = @dpi_cliente
END

-- PROCEDIMIENTO ALMACENADO: BUSCAR CLIENTE
CREATE PROCEDURE BuscarCliente
@dpi_cliente VARCHAR(20)
AS
BEGIN
	SELECT*FROM cliente WHERE dpi_cliente=@dpi_cliente
END

-- PROCEDIMIENTO ALMACENADO: ELIMINAR CLIENTE
CREATE PROCEDURE EliminarCliente
@dpi_cliente VARCHAR(20)
AS
BEGIN
	DELETE FROM cliente WHERE dpi_cliente=@dpi_cliente
END

-- PROCEDIMIENTO ALMACENADO: CREAR CITA

CREATE PROCEDURE RegistrarCita
@id_cita varchar(50),
@fecha_cita date,
@hora_cita varchar(5),
@asunto_cita varchar(255),
@fk_cliente varchar(20)
AS
BEGIN
	INSERT INTO cita VALUES(@id_cita, @fecha_cita, @hora_cita, @asunto_cita, @fk_cliente)
END