CREATE DATABASE ComercioDB
-- Tabla de Clientes
CREATE TABLE Clientes (
    ClienteID INT PRIMARY KEY IDENTITY (1,1),
    Nombre VARCHAR(100),
	DNI VARCHAR (250),
    Direccion VARCHAR(MAX),
    Telefono VARCHAR(20),
    Email VARCHAR(100),
    SaldoCuentaCorriente DECIMAL(18, 2) DEFAULT 0
);
--INSERT clientes
INSERT INTO Clientes (Nombre, DNI,  Direccion, Telefono, Email, SaldoCuentaCorriente)
VALUES ('Juan Pérez','43678298', 'Montevideo 123', '555-1234', 'juan.perez@gmail.com', 0.00),
('María Gómez', '43678111','Av. Principal 456', '555-5678', 'maria.gomez@hotmail.com', 100.50),
('Carlos López', '43672222','Paseo de las Flores 789', '555-9876', 'carlos.lopez@gmail.com', -50.75);
-- Tabla de Proveedores
CREATE TABLE Proveedores (
    ProveedorID INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100),
	CUIT VARCHAR (13),
    Direccion VARCHAR(255),
    Telefono VARCHAR(20),
    Email VARCHAR(100),
    SaldoCuentaCorriente DECIMAL(18, 2) DEFAULT 0
);
-- Insertar primer proveedor
INSERT INTO Proveedores (Nombre,CUIT, Direccion, Telefono, Email, SaldoCuentaCorriente)
VALUES ('Floreria MArgaritas', '30-12345678-1','Av. Comercio 101', '555-1001', 'Lopesdistribuidora@gmail.com', 2000.00),
('Proveedora Macetas R&R','34-12345678-2', 'Calle Industrial 202', '555-2002', 'R&RmacetasZonaSur@hotmail.com', -500.50),
('Importaciones AgroAbono', '34-12345678-3', 'Zona Comercial 303', '555-3003', 'infoAgroAbono@hotmail.com', 0.00);
-- Tabla de Productos
CREATE TABLE Productos (
    ProductoID INT PRIMARY KEY IDENTITY,
	CodigoProducto VARCHAR (MAX) UNIQUE,
    NombreProducto VARCHAR(100),
    Descripcion TEXT,
    PrecioCompra DECIMAL(18, 2),
    PrecioVenta DECIMAL(18, 2),
    Stock INT
);


-- Tabla de Compras
CREATE TABLE Compras (
    CompraID INT PRIMARY KEY IDENTITY,
    ProveedorID INT FOREIGN KEY REFERENCES Proveedores(ProveedorID),
    FechaCompra DATETIME DEFAULT GETDATE(),
    TotalCompra DECIMAL(18, 2),
    SaldoCuentaCorriente DECIMAL(18, 2)
);

-- Detalle de Compras
CREATE TABLE DetalleCompras (
    DetalleCompraID INT PRIMARY KEY IDENTITY,
    CompraID INT FOREIGN KEY REFERENCES Compras(CompraID),
    ProductoID INT FOREIGN KEY REFERENCES Productos(ProductoID),
    Cantidad INT,
    PrecioUnitario DECIMAL(18, 2),
    Subtotal DECIMAL(18, 2)
);


CREATE PROCEDURE InsertarCompra -----------------------------------------------------------------------------PROCEDIMIEMTO ALMACENADO DE INSERTAR COMPRA----------
    @ProveedorID INT,
	@MetodoPago VARCHAR(MAX);
	@ProductosCompra TABLE
	( @CodigoProducto VARCHAR (MAX) UNIQUE,
    @NombreProducto VARCHAR(100),	
	@Descripcion TEXT,
    @PrecioUniCompra DECIMAL(18, 2),
    @PrecioUniVenta DECIMAL(18, 2),
    @Cantidad INT) -- Tabla de productos
AS
AS
BEGIN
    -- Declarar variables
    DECLARE @CompraID INT;
	DECLARE @SubTotal BIGINT;
	DECLARE  @ProductoID INT;   DECLARE TotalCompra DECIMAL(18, 2);

    -- Inicio de la transacción
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Verificar que el proveedor exista
        IF NOT EXISTS (SELECT 1 FROM Proveedores WHERE ProveedorID = @ProveedorID)
        BEGIN
            RAISERROR('El proveedor no existe.', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END;
		--Verificar si el Codigo del producto Existe  
        IF EXISTS (SELECT 1 FROM Productos WHERE CodigoProducto = @CodigoProducto)
            BEGIN  -- Si existe, obtener el ProductoID
              SELECT @ProductoID = ProductoID
              FROM Productos
              WHERE CodigoProducto = @CodigoProducto;
			    -- Actualizar el stock de los productos
              UPDATE Productos
              SET Stock = Stock + @Cantidad
              WHERE ProductoID =@ProductoID ;
            END;
        ELSE
           BEGIN -- Si no existe, insertar el nuevo producto
             INSERT INTO Productos (CodigoProducto , NombreProducto, Descripcion, PrecioCompra, PrecioVenta, Stock)
             SELECT @CodigoProducto, @NombreProducto,@Descripcion, @PrecioUniCompra,@PrecioUniVenta, @Cantidad
	         FROM @ProductosCompra 
             SET @ProductoID = SCOPE_IDENTITY();-- Obtener el ProductoID recién insertado
           END;
        -- Calcular el total de la compra
        SELECT @TotalCompra = SUM(Cantidad * PrecioUnitario)
        FROM @ProductosCompra;

        -- Insertar en la tabla Compras
        INSERT INTO Compras (ProveedorID, TotalCompra, SaldoCuentaCorriente)
        VALUES (@ProveedorID, @TotalCompra, 0);

        -- Obtener el ID de la compra recién insertada
        SET @CompraID = SCOPE_IDENTITY();

        -- Insertar en la tabla DetalleCompras
        INSERT INTO DetalleCompras (CompraID, ProductoID, Cantidad, PrecioUnitario, Subtotal)
        SELECT @CompraID, @ProductoID, Cantidad, PrecioUnitario, Cantidad * PrecioUnitario
        FROM @ProductosCompra;

        -- Si el método de pago es "Cuenta Corriente", actualizar saldo y registrar el movimiento
        IF @MetodoPago = 'Cuenta Corriente'
          BEGIN 
		  -- Actualizar saldo de cuenta corriente del proveedor
		     UPDATE Proveedores 
             SET SaldoCuentaCorriente = SaldoCuentaCorriente + @TotalCompra
             WHERE ProveedorID = @ProveedorID;
			   -- Registrar movimiento en la tabla MovimientosCuentaCorriente
             INSERT INTO MovimientosCuentaCorriente (EntidadID, TipoEntidad, Monto, TipoMovimiento)
             VALUES (@ProveedorID, 'Proveedor', @TotalCompra, 'Compra');
          END; 
		ELSE
           BEGIN -- Si no existe, insertar el nuevo producto
            END;

		 BalanceContable (
    BalanceID INT PRIMARY KEY IDENTITY,
    Fecha DATETIME DEFAULT GETDATE(),
    TotalVentas DECIMAL(18, 2),
    TotalCompras DECIMAL(18, 2),
    BalanceFinal DECIMAL(18, 2)













        -- Confirmar la transacción
        COMMIT TRANSACTION; 
	 END TRY
	 BEGIN CATCH
        -- Si ocurre un error, hacer rollback
        ROLLBACK TRANSACTION;

        -- Mostrar el mensaje de error
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        RAISERROR(@ErrorMessage, 16, 1);
     END CATCH;
END;






-- Tabla de Ventas
CREATE TABLE Ventas (
    VentaID INT PRIMARY KEY IDENTITY,
    ClienteID INT FOREIGN KEY REFERENCES Clientes(ClienteID),
    FechaVenta DATETIME DEFAULT GETDATE(),
    TotalVenta DECIMAL(18, 2),
    SaldoCuentaCorriente DECIMAL(18, 2)
);

-- Detalle de Ventas
CREATE TABLE DetalleVentas (
    DetalleVentaID INT PRIMARY KEY IDENTITY,
    VentaID INT FOREIGN KEY REFERENCES Ventas(VentaID),
    ProductoID INT FOREIGN KEY REFERENCES Productos(ProductoID),
    Cantidad INT,
    PrecioUnitario DECIMAL(18, 2),
    Subtotal DECIMAL(18, 2)
);

-- Movimientos de Cuenta Corriente
CREATE TABLE MovimientosCuentaCorriente (
    MovimientoID INT PRIMARY KEY IDENTITY,
    EntidadID INT,
    TipoEntidad VARCHAR(10) CHECK (TipoEntidad IN ('Cliente', 'Proveedor')),
    FechaMovimiento DATETIME DEFAULT GETDATE(),
    Monto DECIMAL(18, 2),
    TipoMovimiento VARCHAR(10) CHECK (TipoMovimiento IN ('Compra', 'Venta', 'Pago'))
);

-- Pagos
CREATE TABLE Pagos (
    PagoID INT PRIMARY KEY IDENTITY,
    EntidadID INT,
    TipoEntidad VARCHAR(10) CHECK (TipoEntidad IN ('Cliente', 'Proveedor')),
    FechaPago DATETIME DEFAULT GETDATE(),
    MontoPago DECIMAL(18, 2)
);

-- Balance Contable
CREATE TABLE BalanceContable (
    BalanceID INT PRIMARY KEY IDENTITY,
    Fecha DATETIME DEFAULT GETDATE(),
    TotalVentas DECIMAL(18, 2),
    TotalCompras DECIMAL(18, 2),
    BalanceFinal DECIMAL(18, 2)
);

--Historial de movimientos
CREATE TABLE Historial(
ID_Historial BIGINT PRIMARY KEY IDENTITY (1,1),
Movimiento VARHCAR (MAX),
Monto DECIMAL(18, 2),
Fecha  DATETIME DEFAULT GETDATE()
);
