
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
