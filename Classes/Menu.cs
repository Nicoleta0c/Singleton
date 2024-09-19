using ImpresoraSingleton;
using ImpresoraSingleton.Clases;
using System;
using System.Collections.Generic;

public class Menu
{
    private readonly List<Empleado> _empleados;
    private readonly ImpresoraSingleton _impresora;

    public Menu(List<Empleado> empleados, ImpresoraSingleton impresora)
    {
        _empleados = empleados;
        _impresora = impresora;
    }

    public void MostrarMenu()
    {
        while (true)
        {
            Console.WriteLine("Opciones");
            Console.WriteLine("1 Ver empleados");
            Console.WriteLine("2 Imprimir documento");
            Console.WriteLine("3 Ver historial");
            Console.WriteLine("4 Salir");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    VerEmpleados();
                    break;
                case "2":
                    ImprimirDocumento();
                    break;
                case "3":
                    _impresora.VerHistorial();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Vuelve a intentaqlo");
                    break;
            }
        }
    }

    private void VerEmpleados()
    {
        Console.WriteLine("Lista de empleados");
        foreach (var empleado in _empleados)
        {
            Console.WriteLine($"{empleado.Id} {empleado.Nombre}");
        }
    }

    private void ImprimirDocumento()
    {
        VerEmpleados();

        Console.Write("Ingrese el id para el documento ");
        if (int.TryParse(Console.ReadLine(), out int idEmpleado))
        {
            Empleado empleado = _empleados.Find(e => e.Id == idEmpleado);
            if (empleado != null)
            {
                Console.Write("Ingrese el nombre del documento ");
                string documento = Console.ReadLine();
                _impresora.Imprimir(empleado, documento);
            }
            else
            {
                Console.WriteLine("No se encuentra el empleado");
            }
        }
        else
        {
            Console.WriteLine("Id no invalido");
        }
    }
}



