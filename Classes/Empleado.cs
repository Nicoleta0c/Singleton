using System;

namespace ImpresoraSingleton.Clases
{
    public class Empleado
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; }

        public Empleado(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
