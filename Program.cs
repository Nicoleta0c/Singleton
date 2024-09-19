using ImpresoraSingleton;
using ImpresoraSingleton.Clases;
using System;
using System.Collections.Generic;

class ProgramaPrincipal
{
    static void Main(string[] args)
    {  
        List<Empleado> empleados = CrearEmpleados();
        ImpresoraSingleton impresora = ImpresoraSingleton.ObtenerInstancia();
        Menu menu = new Menu(empleados, impresora);
        menu.MostrarMenu();
    }

    private static List<Empleado> CrearEmpleados()
    {
        return new List<Empleado>
        {
            new Empleado(1, "Nicolle"),
            new Empleado(2, "Alexander"),
            new Empleado(3, "Pedro")
        };
    }
}

