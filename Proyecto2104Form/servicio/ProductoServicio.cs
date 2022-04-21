using Proyecto2104Form.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2104Form.servicio
{
    public class ProductoServicio
    {
        public static List<Producto> ObtenerDatos()
        {
            var resultado = new List<Producto>();

            var prod = new Producto(1,"cocacola", 1000, "bebida");
            resultado.Add(prod);
            
            var prod2 = new Producto();
            prod2.Id = 2;
            prod2.Nombre = "fanta";
            prod2.Precio = 555;
            prod2.Categoria = "bebida";
            resultado.Add(prod2);
            for (int i = 0; i < 5000; i++)
            {
                var prod3 = new Producto
                {
                    Id = 3+i,
                    Nombre = "sprite #"+i,
                    Precio = 777+i,
                    Categoria = "bebida"
                };
                resultado.Add(prod3);
            }

            return resultado;
        }
    }
}
