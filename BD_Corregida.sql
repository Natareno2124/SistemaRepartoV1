CREATE DATABASE SistemaReparto;
USE SistemaReparto;

CREATE TABLE tbl_clientes (
	id_cliente INT PRIMARY KEY,
	nombre_cliente VARCHAR(50),
	apellido_cliente VARCHAR(50),
	nit_cliente VARCHAR(15)
);

CREATE TABLE tbl_cliente_contacto (
	id_cliente_contacto INT PRIMARY KEY AUTO_INCREMENT,
	id_cliente INT,
	telefono_cliente VARCHAR(20),
	correo_cliente VARCHAR(100),
	FOREIGN KEY (id_cliente) REFERENCES tbl_clientes(id_cliente)
);

CREATE TABLE tbl_cliente_direccion (
	id_cliente_direccion INT PRIMARY KEY AUTO_INCREMENT,
	id_cliente INT,
	calle_cliente VARCHAR(50),
	avenida_cliente VARCHAR(50),
	zona_cliente INT,
	ciudad_cliente VARCHAR(100),
	municipio_cliente VARCHAR(100),
	FOREIGN KEY (id_cliente) REFERENCES tbl_clientes(id_cliente)
);


CREATE TABLE tbl_encargado (
	id_encargado INT AUTO_INCREMENT PRIMARY KEY,
	nombre_encargado VARCHAR(50),
	apellido_encargado VARCHAR(50),
	codigo_encargado INT
);

CREATE TABLE tbl_encargado_contacto (
	id_encargado_contacto INT PRIMARY KEY AUTO_INCREMENT,
	id_encargado INT,
	telefono_encargado VARCHAR(20),
	correo_encargado VARCHAR(100),
	FOREIGN KEY (id_encargado) REFERENCES tbl_encargado(id_encargado)
);

CREATE TABLE tbl_encargado_direccion (
	id_encargado_direccion INT PRIMARY KEY AUTO_INCREMENT,
	id_encargado INT,
	calle_encargado VARCHAR(50),
	avenida_encargado VARCHAR(50),
	zona_encargado INT,
	ciudad_encargado VARCHAR(100),
	municipio_encargado VARCHAR(100),
	FOREIGN KEY (id_encargado) REFERENCES tbl_encargado(id_encargado)
);



CREATE TABLE tbl_contacto_sucursal (
	id_contacto_sucursal INT AUTO_INCREMENT PRIMARY KEY,
	telefono_sucursal VARCHAR(9),
	correo_sucursal VARCHAR(50)
);

CREATE TABLE tbl_direccion_sucursal (
	id_direccion_sucursal INT AUTO_INCREMENT PRIMARY KEY,
	calle_sucursal VARCHAR(50),
	avenida_sucursal VARCHAR(50),
	zona_sucursal INT,
	ciudad_sucursal VARCHAR(50),
	municipio_sucursal VARCHAR(50)
);
CREATE TABLE tbl_sucursal (
	id_sucursal INT AUTO_INCREMENT PRIMARY KEY,
	codigo_sucursal INT,
	id_encargado INT,
	id_direccion_sucursal INT,
	id_contacto_sucursal INT,
	FOREIGN KEY (id_encargado) REFERENCES tbl_encargado(id_encargado),
	FOREIGN KEY (id_direccion_sucursal) REFERENCES tbl_direccion_sucursal(id_direccion_sucursal),
	FOREIGN KEY (id_contacto_sucursal) REFERENCES tbl_contacto_sucursal(id_contacto_sucursal)
);




CREATE TABLE tbl_conductores (
	id_conductor INT AUTO_INCREMENT PRIMARY KEY,
	nombre_conductor VARCHAR(50),
	apellido_conductor VARCHAR(50),
	fecha_nacimiento_conductor DATE,
	sexo_conductor VARCHAR(1),
	tipo_licencia_conductor VARCHAR(2),
	id_sucursal INT,
	FOREIGN KEY (id_sucursal) REFERENCES tbl_sucursal(id_sucursal)
);

CREATE TABLE tbl_conductor_contacto (
	id_conductor_contacto INT PRIMARY KEY AUTO_INCREMENT,
	id_conductor INT,
	telefono_conductor VARCHAR(20),
	correo_conductor VARCHAR(100),
	FOREIGN KEY (id_conductor) REFERENCES tbl_conductores(id_conductor)
);

CREATE TABLE tbl_conductor_direccion (
	id_conductor_direccion INT PRIMARY KEY AUTO_INCREMENT,
	id_conductor INT,
	calle_conductor VARCHAR(50),
	avenida_conductor VARCHAR(50),
	zona_conductor INT,
	ciudad_conductor VARCHAR(100),
	municipio_conductor VARCHAR(100),
	FOREIGN KEY (id_conductor) REFERENCES tbl_conductores(id_conductor)
);

CREATE TABLE tbl_tipo_vehiculo (
	id_tipo_vehiculo INT PRIMARY KEY,
	nombre_tipo_vehiculo VARCHAR(50)
);

CREATE TABLE tbl_estado_vehiculo (
	id_estado_vehiculo INT PRIMARY KEY,
	nombre_estado_vehiculo VARCHAR(50)
);

CREATE TABLE tbl_vehiculos (
	id_placa INT PRIMARY KEY,
	marca_vehiculo VARCHAR(50),
	modelo_vehiculo VARCHAR(50),
	color_vehiculo VARCHAR(15),
	capacidad_vehiculo VARCHAR(20),
	id_sucursal INT,
	id_tipo_vehiculo INT,
	id_estado_vehiculo INT,
	FOREIGN KEY (id_sucursal) REFERENCES tbl_sucursal(id_sucursal),
	FOREIGN KEY (id_tipo_vehiculo) REFERENCES tbl_tipo_vehiculo(id_tipo_vehiculo),
	FOREIGN KEY (id_estado_vehiculo) REFERENCES tbl_estado_vehiculo(id_estado_vehiculo)
);

CREATE TABLE tbl_asignacion_vehiculo (
	id_asignacion_vehiculo INT PRIMARY KEY AUTO_INCREMENT,
	id_conductor INT,
	id_placa INT,
	fecha_inicio_asignacion DATE,
	fecha_final_asignacion DATE,
	FOREIGN KEY (id_conductor) REFERENCES tbl_conductores(id_conductor),
	FOREIGN KEY (id_placa) REFERENCES tbl_vehiculos(id_placa)
);


CREATE TABLE tbl_tipo_ruta (
	id_tipo_ruta INT PRIMARY KEY,
	nombre_tipo_ruta VARCHAR(20)
);

CREATE TABLE tbl_rutas (
	id_ruta INT PRIMARY KEY,
	nombre_ruta VARCHAR(50),
	fecha_ruta DATE,
	hora_inicio_ruta TIME,
	hora_final_ruta TIME,
	id_conductor INT,
	FOREIGN KEY (id_conductor) REFERENCES tbl_conductores(id_conductor)
);
CREATE TABLE tbl_bodega (
	id_bodega INT PRIMARY KEY AUTO_INCREMENT,
	codigo_bodega INT,
	id_encargado INT,
	id_sucursal INT,
	capacidad_bodega INT,
	FOREIGN KEY (id_encargado) REFERENCES tbl_encargado(id_encargado),
	FOREIGN KEY (id_sucursal) REFERENCES tbl_sucursal(id_sucursal)
);
CREATE TABLE tbl_asignacion_ruta_conductor (
	id_asignacion_ruta_conductor INT PRIMARY KEY AUTO_INCREMENT,
	id_conductor INT,
	id_cliente_direccion INT,
	fecha_asignacion DATE,
	id_tipo_ruta INT,
	id_bodega INT,
	FOREIGN KEY (id_conductor) REFERENCES tbl_conductores(id_conductor),
	FOREIGN KEY (id_cliente_direccion) REFERENCES tbl_cliente_direccion(id_cliente_direccion),
	FOREIGN KEY (id_tipo_ruta) REFERENCES tbl_tipo_ruta(id_tipo_ruta),
	FOREIGN KEY (id_bodega) REFERENCES tbl_bodega(id_bodega)
);

CREATE TABLE tbl_paquete (
	id_guia_madre INT PRIMARY KEY,
	peso_kg_paquete FLOAT,
	largo_cm_paquete FLOAT,
	ancho_cm_paquete FLOAT,
	alto_cm_paquete FLOAT,
	descripcion_paquete VARCHAR(250),
	precio_paquete FLOAT,
	fragil_paquete VARCHAR(1),
	tiempo_entrega_paquete INT,
	id_bodega INT,
	id_sucursal INT,
	FOREIGN KEY (id_bodega) REFERENCES tbl_bodega(id_bodega),
	FOREIGN KEY (id_sucursal) REFERENCES tbl_sucursal(id_sucursal)
);

CREATE TABLE tbl_tipo_pago (
	id_tipo_pago INT PRIMARY KEY,
	nombre_tipo_pago VARCHAR(25)
);


CREATE TABLE tbl_pedido (
	id_pedido INT PRIMARY KEY,
	id_guia_madre INT,
	id_cliente INT,
	estado_pedido VARCHAR(50),
	id_tipo_pago INT,
	id_sucursal INT,
	fecha_creacion_pedido DATE,
	fecha_salida_pedido DATE,
	FOREIGN KEY (id_guia_madre) REFERENCES tbl_paquete(id_guia_madre),
	FOREIGN KEY (id_cliente) REFERENCES tbl_clientes(id_cliente),
	FOREIGN KEY (id_tipo_pago) REFERENCES tbl_tipo_pago(id_tipo_pago),
	FOREIGN KEY (id_sucursal) REFERENCES tbl_sucursal(id_sucursal)
);


CREATE TABLE tbl_ruta_detalle (
	id_ruta_detalle INT PRIMARY KEY,
	id_ruta INT,
	id_pedido INT,
	FOREIGN KEY (id_ruta) REFERENCES tbl_rutas(id_ruta),
	FOREIGN KEY (id_pedido) REFERENCES tbl_pedido(id_pedido)
);

CREATE TABLE tbl_evaluacion_conductores (
	id_evaluacion INT PRIMARY KEY,
	id_ruta INT,
	calificacion_evaluacion INT,
	comentario_evaluacion VARCHAR(255),
	fecha_evaluacion DATE,
	FOREIGN KEY (id_ruta) REFERENCES tbl_rutas(id_ruta)
);


CREATE TABLE tbl_producto (
	id_producto INT PRIMARY KEY,
	nombre_producto VARCHAR(70),
	descripcion_producto VARCHAR(250),
	precio_producto FLOAT
);



CREATE TABLE tbl_paquete_producto (
	id_paquete_producto INT PRIMARY KEY,
	id_producto INT,
	id_paquete INT,
	FOREIGN KEY (id_producto) REFERENCES tbl_producto(id_producto),
	FOREIGN KEY (id_paquete) REFERENCES tbl_paquete(id_guia_madre)
);





CREATE TABLE tbl_movimiento_bodega (
	id_movimiento_bodega INT PRIMARY KEY AUTO_INCREMENT,
	id_paquete INT,
	id_bodega INT,
	fecha_ingreso DATE,
	fecha_salida DATE,
	id_sucursal INT,
	FOREIGN KEY (id_paquete) REFERENCES tbl_paquete(id_guia_madre),
	FOREIGN KEY (id_bodega) REFERENCES tbl_bodega(id_bodega),
	FOREIGN KEY (id_sucursal) REFERENCES tbl_sucursal(id_sucursal)
);

CREATE TABLE tbl_rol_usuario (
	id_rol INT PRIMARY KEY AUTO_INCREMENT,
	nombre_rol VARCHAR(50)
);

CREATE TABLE tbl_usuarios (
	id_usuario INT PRIMARY KEY AUTO_INCREMENT,
	nombres_usuario VARCHAR(80),
	apellidos_usuario VARCHAR(80),
	usuario VARCHAR(45) UNIQUE,
	contrasena_usuario VARCHAR(100),
	email_usuario VARCHAR(100),
	telefono_usuario VARCHAR(20),
	rol_usuario INT,
	FOREIGN KEY (rol_usuario) REFERENCES tbl_rol_usuario(id_rol)
);


insert into tbl_rol_usuario (nombre_rol) values('Administrador'),('Usuario');

