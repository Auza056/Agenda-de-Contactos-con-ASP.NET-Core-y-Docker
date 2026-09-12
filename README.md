# Vault Electrónico de Contactos (ASP.NET Core, API REST & Docker)

Aplicación web y API REST desarrollada como agenda de contactos utilizando **ASP.NET Core MVC**, **Entity Framework Core**, **SQLite**, **Swagger / OpenAPI** y contenerizada con **Docker**.

## Características Principales
- **Arquitectura Dual:** Interfaz web interactiva tradicional (MVC) junto con una **API REST** completa.
- **Documentación de API:** Interfaz interactiva de **Swagger** integrada y accesible de forma directa.
- **Operaciones CRUD Completas:** Gestión completa de contactos (Crear, Leer, Actualizar y Eliminar) tanto en la interfaz visual como en la API.
- **Validaciones Robustas:** Reglas de validación en los modelos mediante Data Annotations (control de formato para nombres, apellidos, números de teléfono y dominios de correo electrónico válidos).
- **Diseño Estilo Oscuro:** Tema oscuro personalizado aplicado a la interfaz para una mejor experiencia visual.
- **Base de Datos Autogestionada:** Aplicación automática de migraciones de Entity Framework Core al iniciar la aplicación (diseñado para máxima estabilidad dentro de contenedores).
- **Contenerización:** Despliegue listo para producción utilizando **Docker**.

## Tecnologías Utilizadas
- **ASP.NET Core 10.0 / C#**
- **Entity Framework Core (SQLite)**
- **Swashbuckle.AspNetCore (Swagger / OpenAPI)**
- **Bootstrap / CSS Customizado**
- **Docker Desktop**

## Requisitos Previos
- Tener instalado [.NET 10 SDK](https://dotnet.microsoft.com/)
- Tener instalado [Docker Desktop](https://www.docker.com/)

---

## Instrucciones de Instalación y Ejecución

1. Clonar el repositorio o descargar el código fuente:
```bash
   git clone https://github.com/Auza056/Agenda-de-Contactos-con-ASP.NET-Core-y-Docker.git
   cd VaultContactos
```

2. Elegir uno de los siguientes métodos de ejecución:

   ### Opción A - Ejecución mediante Docker (Recomendado)

   Levantar la aplicación de forma automática utilizando el archivo de orquestación, ejecutando el siguiente comando en la raíz del proyecto:

```bash
   docker compose up -d --build
```

   Una vez iniciado el contenedor, la aplicación estará disponible en:
   - Interfaz web: [http://localhost:8080](http://localhost:8080) (o [http://localhost:8080/Contactos](http://localhost:8080/Contactos))
   - Documentación de Swagger: [http://localhost:8080/swagger](http://localhost:8080/swagger)

   Para detener el servicio, ejecutar:

```bash
   docker compose down
```

   ### Opción B - Ejecución Local en Desarrollo

   1. Restaurar las dependencias del proyecto:
```bash
      dotnet restore
```
   2. Ejecutar la aplicación:
```bash
      dotnet run
```
      (El sistema aplicará las migraciones de SQLite de manera automática al iniciar.)
   3. Abrir el navegador en la URL proporcionada por la consola, accediendo a:
      - Interfaz web: `https://localhost:puerto/Contactos`
      - Documentación de la API: `https://localhost:puerto/swagger`
