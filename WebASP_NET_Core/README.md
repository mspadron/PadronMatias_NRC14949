# Proyecto de Aplicación Web con ASP .NET Core

Este proyecto es una Aplicación Web desarrollada con ASP .NET Core que implementa un sistema de Agenda. La aplicación utiliza el patrón de diseño MVC (Model-View-Controller) para organizar y gestionar el código de manera eficiente.

## Configuración Inicial

Para comenzar a trabajar con este proyecto, sigue los siguientes pasos:

1. **Clonar el Repositorio:**
   - Clona este repositorio en tu máquina local utilizando el siguiente comando:

     ```bash
     git clone https://tu-repositorio.git
     ```

2. **Abrir el Proyecto:**
   - Abre el proyecto en Visual Studio Code o Visual Studio.

3. **Configurar el Proyecto con ASP .NET Core:**
   - Asegúrate de tener ASP .NET Core instalado en tu máquina.
   - Abre la terminal en la carpeta del proyecto y ejecuta el siguiente comando para restaurar las dependencias:

     ```bash
     dotnet restore
     ```

4. **Ejecutar la Aplicación:**
   - Utiliza el siguiente comando para iniciar la aplicación:

     ```bash
     dotnet run
     ```

   - Abre tu navegador y visita `https://localhost:5001` para ver la aplicación en acción.

## Creación de Páginas Razor

### Categorías

Para las categorías, se han creado las siguientes páginas Razor:

1. **Index:** Muestra la lista de categorías.
2. **Detalle:** Muestra los detalles de una categoría específica.
3. **Crear:** Permite agregar una nueva categoría.
4. **Editar:** Permite modificar la información de una categoría existente.
5. **Borrar:** Permite eliminar una categoría.

### Contactos

Para los contactos, se han creado las mismas páginas Razor con las operaciones CRUD:

1. **Index:** Muestra la lista de contactos.
2. **Detalle:** Muestra los detalles de un contacto específico.
3. **Crear:** Permite agregar un nuevo contacto.
4. **Editar:** Permite modificar la información de un contacto existente.
5. **Borrar:** Permite eliminar un contacto.

## Integración con Entity Framework Core

Se ha integrado Entity Framework Core para gestionar la relación entre los modelos de Categoría y Contacto. Asegúrate de ejecutar las migraciones necesarias para crear la base de datos y aplicar los cambios en el esquema.

```bash
dotnet ef migrations add InitialMigration
dotnet ef database update
```

Con estos pasos, tu aplicación estará lista para su ejecución y prueba. ¡Disfruta desarrollando con ASP .NET Core!
