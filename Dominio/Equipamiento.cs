using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio.Dominio
{
    public class Equipamiento
    {
        private static int ultimoId = 1;

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }

        public Equipamiento(string nombre, string descripcion)
        {
            Id = ultimoId;
            ultimoId++;
            Nombre = nombre;
            Descripcion = descripcion;
            Stock = 0;
            Validar();
        }

        public void Validar()
        {
            if (string.IsNullOrEmpty(Nombre))
            {
                throw new Exception("El Nombre no puede ser vacío");
            }
            if (string.IsNullOrEmpty(Descripcion))
            {
                throw new Exception("La Descripcion no puede ser vacía");
            }
            if (Stock < 0)
            {
                throw new Exception("El Stock no puede ser negativo");
            }
        }

        public override string ToString()
        {
            return Nombre + " - Stock: " + Stock;
        }
    }
}
