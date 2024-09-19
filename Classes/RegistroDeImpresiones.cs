using ImpresoraSingleton.Clases;
using System;

namespace ImpresoraSingleton
{
    public class RegistroDeImpresiones
    {
        public Empleado Empleado { get; private set; }
        public string Documento { get; private set; }
        public DateTime FechaHora { get; private set; }

        public RegistroDeImpresiones(Empleado empleado, string documento, DateTime fechaHora)
        {
            Empleado = empleado;
            Documento = documento;
            FechaHora = fechaHora;
        }
    }
}

