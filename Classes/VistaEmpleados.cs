using ImpresoraSingleton.Clases;
using System;
using System.Collections.Generic;

public class VistaEmpleados
{
    private readonly List<Empleado> _empleados;

    public VistaEmpleados(List<Empleado> empleados)
    {
        _empleados = empleados;
    }

    public void VerEmpleados()
    {
        Console.WriteLine("Lista de empleados");
        foreach (var empleado in _empleados)
        {
            Console.WriteLine($"{empleado.Id} {empleado.Nombre}");
        }
    }
}

