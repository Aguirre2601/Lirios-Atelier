# liriosAtelier_CSharp_SQL

Este proyecto es una aplicación de escritorio desarrollada en C# con Windows Forms que implementa un sistema de ABM (Alta, Baja, Modificación) para la gestión de clientes de una florería.
El software fue diseñado con un enfoque educativo para demostrar la separación de responsabilidades mediante el uso de clases, la validación de datos en tiempo real y la conexión a bases de datos SQL Server.

## 🚀 Características

Gestión Completa de Clientes: Permite registrar, buscar, editar y eliminar datos (DNI, Nombre, Apellido, Teléfono, Email, Modelo de producto, Estado de entrega y Total).

Validación Robusta: Control de entrada de datos para asegurar que los campos no estén vacíos, que los formatos de email sean correctos y que se respeten tipos de datos (solo números o solo letras).

Búsqueda Dinámica: Filtrado de registros en tiempo real mediante el número de DNI.

Interfaz Modular: Uso de un formulario principal (FormInicio) que carga formularios hijos dentro de un contenedor, mejorando la experiencia de usuario.

## 🛠️ Arquitectura y Clases Principales

El proyecto destaca por su organización lógica, facilitando la comprensión de cómo interactúan los componentes de un software profesional:

BaseDeDatos.cs: Clase encargada de toda la lógica de persistencia. Contiene los métodos para abrir/cerrar conexiones, ejecutar consultas SELECT (Leer), realizar búsquedas filtradas y ejecutar comandos INSERT/UPDATE/DELETE (ABM).

Validaciones.cs: Una clase utilitaria reutilizable que centraliza la lógica de control de errores. Valida formatos de correo, longitud de documentos y restricciones de caracteres en los TextBox.

FormInicio.cs: Actúa como el orquestador de la aplicación, gestionando la navegación entre las distintas funcionalidades sin abrir múltiples ventanas independientes.

## 💻 Tecnologías Utilizadas

-Lenguaje: C#

-Framework: .NET Framework (Windows Forms)

-Base de Datos: SQL Server

-Librerías: System.Data.SqlClient para la comunicación con el servidor de base de datos.

## ⚙️ Configuración del Proyecto

Para ejecutar este proyecto localmente, asegúrate de seguir estos pasos:

Base de Datos:

Debes tener instalado SQL Server.

Crea una base de datos llamada atelier_lilies.

Crea una tabla clientes02 con las columnas correspondientes (DNI, Apellido, Nombre, Télefono, email, Modelo, Entregado, Total_a_pagar).

Cadena de Conexión:

Dirígete a la clase BaseDeDatos.cs. modifica la variable Conexion con tu instancia local de SQL Server:

`  C#

`  private SqlConnection Conexion = new SqlConnection(@"Data Source=TU_SERVIDOR;Initial Catalog=atelier_lilies;Trusted_Connection=True;"); 

## 💡 Valor Educativo
Este repositorio es ideal para estudiantes o desarrolladores junior que deseen aprender:

Encapsulamiento: Cómo proteger la lógica de negocio en clases separadas.

Eventos en WinForms: Manejo de KeyPress y TextChanged para mejorar la UX.

ADO.NET: Uso de SqlCommand, SqlDataReader y DataTable para manipular datos.
