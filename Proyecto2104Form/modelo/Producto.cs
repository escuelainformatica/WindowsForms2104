using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2104Form.modelo
{
    public class Producto
    {
        public int Id { set; get; }
        public string Nombre { set; get; }
        public int Precio { set; get; }
        public string Categoria { set; get; }

        public Producto(int id,string nombre, int precio, string categoria)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            Categoria = categoria;
        }

        public Producto()
        {
        }
    }
}
