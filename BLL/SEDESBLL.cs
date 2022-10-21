using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joyeria_el_diamante.BLL
{
    public class SEDESBLL
    {
        private int id_sede;
        private string nombre_sede;
        private string ubicacion;
        private int telefono;

        public SEDESBLL(int id_sede)
        {
            this.id_sede = id_sede;
        }

        public SEDESBLL(int id_sede, string nombre_sede, string ubicacion, int telefono)
        {
            this.id_sede = id_sede;
            this.nombre_sede = nombre_sede;
            this.ubicacion = ubicacion;
            this.telefono = telefono;
        }

        public int Id_sede { get => id_sede; set => id_sede = value; }
        public string Nombre_sede { get => nombre_sede; set => nombre_sede = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
    }
}

