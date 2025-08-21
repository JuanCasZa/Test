// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;

Console.WriteLine("Hello, World!");

public class Personas
{
    public String nombre;
    public String cedula;
    public int edad;
    public decimal estatura;
    public decimal peso;
    public DateTime nacimiento;
}

public class EstadosMembresias
{
    public bool estado;
}

public class Clientes : Personas
{
    public EstadosMembresias estadoMembresia;
}

public class Entrenadores : Personas
{
    public String titulo;
    public int anhosExperiencia;
    public decimal salario;
}


