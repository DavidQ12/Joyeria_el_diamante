using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joyeria_el_diamante.BLL
{
    public class PRODUCTOSBLL
    {
        private int id_producto;
        private string nombre_producto;
        private int codigo_producto;
        private int precio;

        public PRODUCTOSBLL(int id_producto)
        {
            this.id_producto = id_producto;
        }

        public PRODUCTOSBLL(int id_producto, string nombre_producto, int codigo_producto, int precio)
        {
            this.id_producto = id_producto;
            this.nombre_producto = nombre_producto;
            this.codigo_producto = codigo_producto;
            this.precio = precio;
        }

        public int Id_producto { get => id_producto; set => id_producto = value; }
        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public int Codigo_producto { get => codigo_producto; set => codigo_producto = value; }
        public int Precio { get => precio; set => precio = value; }
    }

}

