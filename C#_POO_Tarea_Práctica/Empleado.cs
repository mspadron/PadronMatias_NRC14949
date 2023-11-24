
using System;

public class Empleado : IMostrarInformacion
{
    public string Nombre { get; set; }
    public double Salario { get; set; }

    public Empleado(string nombre, double salario)
    {
        Nombre = nombre;
        Salario = salario;
    }

    public virtual double CalcularSalarioAnual()
    {
        return Salario * 12;
    }

    public virtual void MostrarInformacion()
    {
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Salario: " + Salario.ToString("C"));
        Console.WriteLine("Salario Anual: " + CalcularSalarioAnual().ToString("C"));

    }
}
