using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joyeria_el_diamante.BLL
{
    public class COMPRASBLL
    {
        private int id_compra;
        private string nombre_producto;
        private int codigo_producto;
        private int precio;
        public COMPRASBLL(int id_compra, string nombre_producto, int codigo_producto, int precio)
        {
            this.id_compra = id_compra;
            this.id_compra = id_compra;
            this.Nombre_producto = nombre_producto;
            this.Codigo_producto = codigo_producto;
            this.Precio = precio;
        }

    private int Id_compra { get => id_compra; set => id_compra = value; }
    private string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
    private int Codigo_producto { get => codigo_producto; set => codigo_producto = value; }
    private int Precio { get => precio; set => precio = value; }


    
    
    
    
    
    
    }
}