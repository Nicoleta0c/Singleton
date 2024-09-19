using ImpresoraSingleton.Clases;
using System;
using System.Collections.Generic;

namespace ImpresoraSingleton
{
    public class ImpresoraSingleton
    {
        private static ImpresoraSingleton _instancia;
        private List<RegistroDeImpresiones> _historial;

        private ImpresoraSingleton()
        {
            _historial = new List<RegistroDeImpresiones>();
        }

        public static ImpresoraSingleton ObtenerInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new ImpresoraSingleton();
            }
            return _instancia;
        }

        public void Imprimir(Empleado empleado, string documento)
        {
            string mensaje = $"{empleado.Nombre} imprimio '{documento}' el {DateTime.Now}";
            Console.WriteLine(mensaje);
            _historial.Add(new RegistroDeImpresiones(empleado, documento, DateTime.Now));
        }

        public void VerHistorial()
        {
            if (_historial.Count == 0)
            {
                Console.WriteLine("No hay impresiones");
            }
            else
            {
                foreach (var registro in _historial)
                {
                    Console.WriteLine($"{registro.Empleado.Nombre} imprimio '{registro.Documento}' el {registro.FechaHora}");
                }
            }
        }
    }
}
