Autor: Matías Padrón
Fecha: 23/11/2023

Este es un ejemplo simple de una aplicación en C# que utiliza Programación Orientada a Objetos (POO) con las siguientes características:

Definición de Clases:

La clase Empleado tiene atributos como Nombre (string) y Salario (double).
Se implementa un método para calcular el salario anual en la clase Empleado.
Herencia:

La clase Gerente hereda de la clase Empleado.
Se agrega un nuevo atributo Departamento a la clase Gerente.
Interfaz:

Se define una interfaz IMostrarInformacion con un método para mostrar información general.
Implementación:

Se implementa la interfaz IMostrarInformacion en ambas clases (Empleado y Gerente).
En el archivo Program.cs, se crean instancias de Empleado y Gerente y se muestra su información utilizando polimorfismo a través de la interfaz.

------------------------------------------------------------------------------------------

## Instrucciones de Ejecución en Visual Studio Community

1. Requisitos:
   - Asegúrate de tener instalado [Visual Studio Community](https://visualstudio.microsoft.com/es/vs/community/) en tu sistema.

2. Crear un Nuevo Proyecto:
   - Abre Visual Studio Community y crea un nuevo proyecto de consola en C#.

     - Selecciona "Crear un nuevo proyecto".
     - Elige "Aplicación de consola (.NET Core)" en la lista de plantillas.
     - Asigna un nombre al proyecto, por ejemplo, "EmpleadoGerenteApp".
     - Haz clic en "Crear".

3. Crear Clases y Copiar Código:
   - Dentro del proyecto, crea tres archivos: `Empleado.cs`, `Gerente.cs`, y `IMostrarInformacion.cs`.
   - Copia y pega el código correspondiente en cada uno de los archivos:

     - `Empleado.cs`: Contendrá la definición de la clase `Empleado`.
     - `Gerente.cs`: Contendrá la definición de la clase `Gerente`.
     - `IMostrarInformacion.cs`: Contendrá la definición de la interfaz `IMostrarInformacion`.

   
   // Empleado.cs
   using System;

   public class Empleado : IMostrarInformacion
   {
       // ... (Código de la clase Empleado)
   }

   // Gerente.cs
   using System;

   public class Gerente : Empleado
   {
       // ... (Código de la clase Gerente)
   }

   // IMostrarInformacion.cs
   using System;

   public interface IMostrarInformacion
   {
       void MostrarInformacion();
   }
   

4. Crear Program.cs y Copiar Código:
   - Crea un nuevo archivo `Program.cs` y copia y pega el siguiente código:

   
   // Program.cs
   using System;

   class Program
   {
       static void Main()
       {
           //Instancio mi clase Empleado
           Empleado empleado = new Empleado("Adrian Padron", 1500);
           empleado.MostrarInformacion();

           Console.WriteLine();
           //Instancio mi clase gerente aplicando herencia
           Gerente gerente = new Gerente("Lorena Aguilar", 1200, "Ventas");
           gerente.MostrarInformacion();

           Console.ReadLine();
       }
   }
   

5. Compilar y Ejecutar:
   - Haz clic en "Compilar" en la parte superior de Visual Studio.
   - Luego, presiona "Ctrl + F5" para ejecutar la aplicación.

6. Interactuar con la Aplicación:
   - La aplicación mostrará la información del empleado y del gerente en la consola.
