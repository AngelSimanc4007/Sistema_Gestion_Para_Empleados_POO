# Sistema de Gestión para Empleados
-----

Ejercicio en **C#** para practicar **Programación Orientada a Objetos (POO)**, aplicando el concepto de **herencia** en un sistema que modela a los empleados de una empresa.



![C#](https://img.shields.io/badge/C%23-512BD4?logo=csharp&logoColor=white)




![.NET](https://img.shields.io/badge/.NET-[versión]-512BD4?logo=dotnet&logoColor=white)




![Visual Studio](https://img.shields.io/badge/Visual%20Studio-2026-5C2D91?logo=visualstudio&logoColor=white)



## 📖 Descripción

El proyecto representa una empresa con distintos tipos de empleados. Una clase base reúne los atributos y comportamientos comunes, y cada rol hereda de ella añadiendo o sobrescribiendo lo que lo hace diferente.

## 🎯 Conceptos de POO aplicados

- **Herencia:** los roles heredan de una clase base de empleado.
- **[Encapsulamiento]:** [propiedades y modificadores de acceso]

## 📁 Estructura del proyecto

```
Sistema_Gestion_Para_Empleados_POO/
├── Roles/            # Clases de los distintos roles de empleado
├── Program.cs        # Punto de entrada de la aplicación
├── Empresa.csproj    # Configuración del proyecto
├── Empresa.slnx      # Solución de Visual Studio
└── README.md
```

## 🧱 Jerarquía de clases

```
Empleado (clase base)
├── Secretario
├── Jefe
└── Vendedor

Cliente(un rol independiente y externo)

```

## 🛠️ Requisitos

- [Visual Studio 2026](https://visualstudio.microsoft.com/) con la carga de trabajo de **desarrollo de escritorio con .NET**
- [.NET SDK [versión]](https://dotnet.microsoft.com/download)

## ▶️ Cómo ejecutarlo

**Desde Visual Studio**

1. Clona el repositorio:
   ```bash
   git clone https://github.com/AngelSimanc4007/Sistema_Gestion_Para_Empleados_POO.git
   ```
2. Abre `Empresa.slnx` con Visual Studio 2026.
3. Presiona `F5` (o `Ctrl + F5` para ejecutar sin depurar).

**Desde la terminal**

```bash
cd Sistema_Gestion_Para_Empleados_POO
dotnet run
```

- Agregar persistencia de datos (archivos o base de datos)
- Incluir más roles y reglas de negocio
- Añadir pruebas unitarias

## 👤 Autor

**AngelSimanc4007**  
[GitHub](https://github.com/AngelSimanc4007)
