using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joyeria_el_diamante.BLL
{
    public class PROVEEDORABLL
    {
        private int id_proveedor;
        private string nombre_proveedor;
        private string producto_proveedor;
        private string nombre_repartidor;
        private string apellidos_repartidor;
        private int telefono_proveedor;
        private string direccion_proveedor;
        public PROVEEDORABLL(int id_proveedor)
        {
            this.id_proveedor = id_proveedor;
        }

        public PROVEEDORABLL(int id_proveedor, string nombre_proveedor, string producto_proveedor, string nombre_repartidor, string apellidos_repartidos, int telefono_proveedor, string direccion_proveedor)
        { 
        this.id_proveedor = id_proveedor;
            this.nombre_proveedor = nombre_proveedor;
            this.producto_proveedor = producto_proveedor;
            this.nombre_repartidor  = nombre_repartidor;
            this.apellidos_proveedor = producto_proveedor;
            this.telefono_proveedor = telefono_proveedor;
            this.dirrecion_proveedor = direccion_proveedor;
        }
        public int Id_proveedor { get => id_proveedor;  set => id_proveedor = value; }
        public string Nombre_proveedor { get => nombre_proveedor;  set => nombre_proveedor = value; }
        public string Producto_proveedor { get => producto_proveedor; set => producto_proveedor = value; }
        public string Nombre_repartidor { get => nombre_repartidor; set => nombre_repartidor = value; }
        public string Apellidos_proveedor { get => apellidos_repartidor; set => apellidos_repartidor = value; }
        public int Telefono_Proveedor { get => telefono_proveedor; set => telefono_proveedor = value; }
        public string direccion_proveedor { get => direccion_proveedor; set => direccion_proveedor = value; }




    }
