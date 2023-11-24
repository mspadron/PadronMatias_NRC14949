// Gerente.csusing System;

public class Gerente : Empleado
{
    public string Departamento { get; set; }

    public Gerente(string nombre, double salario, string departamento) : base(nombre, salario)
    {
        Departamento = departamento;
    }

    public override double CalcularSalarioAnual()
    {
        return Salario * 12 + 1000;
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine("Departamento: "+ Departamento);
    }
}
