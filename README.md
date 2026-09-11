<<<<<<< HEAD
# Vault Electrónico de Contactos (ASP.NET Core, API REST & Docker)

Aplicación web y API REST desarrollada como agenda de contactos utilizando **ASP.NET Core MVC**, **Entity Framework Core**, **SQLite**, **Swagger / OpenAPI** y contenerizada con **Docker**.

##  Características Principales
- **Arquitectura Dual:** Interfaz web interactiva tradicional (MVC) junto con una **API REST** completa.
- **Documentación de API:** Interfaz interactiva de **Swagger** integrada y accesible de forma directa.
- **Operaciones CRUD Completas:** Gestión completa de contactos (Crear, Leer, Actualizar y Eliminar) tanto en la interfaz visual como en la API.
- **Validaciones Robustas:** Reglas de validación en los modelos mediante Data Annotations (control de formato para nombres, apellidos, números de teléfono y dominios de correo electrónico válidos).
- **Diseño Estilo :** Tema oscuro personalizado aplicado a la interfaz para una mejor experiencia visual.
- **Base de Datos Autogestionada:** Aplicación automática de migraciones de Entity Framework Core al iniciar la aplicación (diseñado para máxima estabilidad dentro de contenedores).
- **Contenerización:** Despliegue listo para producción utilizando **Docker**.

##  Tecnologías Utilizadas
- **ASP.NET Core 10.0 / C#**
- **Entity Framework Core (SQLite)**
- **Swashbuckle.AspNetCore (Swagger / OpenAPI)**
- **Bootstrap / CSS Customizado**
- **Docker Desktop**

##  Requisitos Previos
- Tener instalado [.NET 10 SDK](https://dotnet.microsoft.com/)
- Tener instalado [Docker Desktop](https://www.docker.com/)

---

##  Instrucciones de Instalación y Ejecución

1. Clonar el repositorio o descargar el código fuente:
   ```bash
   git clone [https://github.com/Auza056/Agenda-de-Contactos-con-ASP.NET-Core-y-Docker.git](https://github.com/Auza056/Agenda-de-Contactos-con-ASP.NET-Core-y-Docker.git)
   cd VaultContactos

### Opcion A - Ejecucion mediante Docker (Recomendado):
-- Para levantar la aplicacion de forma automatica utilizando el archivo de orquestacion, ejecutar el siguiente comando en la raiz del proyecto:
 - - - > docker compose up -d --build
 
-- Una vez iniciado el contenedor, la interfaz web estara disponible en http://localhost:8080 (o http://localhost:8080/Contactos) y la documentacion interactiva de Swagger en http://localhost:8080/swagger. Para detener el servicio, ejecutar docker compose down.

### Opcion B - Ejecucion Local en Desarrollo:
Restaurar las dependencias del proyecto mediante dotnet restore y ejecutar la aplicacion con dotnet run (el sistema aplicara las migraciones de SQLite de manera automatica al iniciar). Finalmente, abrir el navegador en la URL proporcionada por la consola, accediendo a la interfaz web en https://localhost:puerto/Contactos y a la documentacion de la API en https://localhost:puerto/swagger.
=======
