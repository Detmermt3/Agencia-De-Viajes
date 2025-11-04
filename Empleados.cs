using System;
namespace Proyecto_DetmerMedina_
{
    public class Empleado
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }

        public Empleado(string dni, string nombre)
        {
            Dni = dni;
            Nombre = nombre;
        }
    }
}