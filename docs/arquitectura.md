# Arquitectura técnica

## 1. Arquitectura propuesta

El proyecto utilizará una arquitectura por capas para separar responsabilidades y facilitar el mantenimiento.

### Capa de presentación
Será una aplicación Windows Forms desarrollada en C#. Se encargará de las ventanas, formularios, navegación y captura de información.

### Capa de negocio
Contendrá las reglas del sistema y validaciones relacionadas con pagos, horarios, planes nutricionales y rutinas.

### Capa de datos
Se encargará de la comunicación con SQL Server y de las operaciones de consulta, inserción, actualización y eliminación.

### Base de datos
SQL Server almacenará la información del sistema.

## 2. Componentes previstos

- IronPeak.Presentacion
- IronPeak.Negocio
- IronPeak.Datos
- SQL Server

## 3. Interfaces

No se contempla una API externa en la primera versión. La aplicación de escritorio se comunicará con la base de datos mediante la capa de datos.

## 4. Dependencias y herramientas

- .NET 8 SDK
- Visual Studio 2022 o versión compatible con .NET 8
- SQL Server
- Git
- GitHub

## 5. Estado

La arquitectura anterior es la propuesta técnica para iniciar el desarrollo. La implementación detallada podrá ajustarse cuando se construyan las funcionalidades.
