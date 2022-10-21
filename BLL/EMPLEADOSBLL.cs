using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joyeria_el_diamante.BLL
{
    public class EMPLEADOSBLL
    {
        private int id;
        private string nombres_empleados;
        private string apellidos;
        private string email;
        private string telefono;
        private int id_sede;

        public EMPLEADOSBLL(int id)
        {
            this.id = id;
        }

        public EMPLEADOSBLL(int id, string nombres_empleados, string apellidos, string email, string telefono, int id_sede)
        {
            this.id = id;
            this.nombres_empleados = nombres_empleados;
            this.apellidos = apellidos;
            this.email = email;
            this.telefono = telefono;
            this.id_sede = id_sede;
        }

        public int Id { get => id; set => id = value; }
        public string Nombres_empleados { get => nombres_empleados; set => nombres_empleados = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int Id_sede { get => id_sede; set => id_sede = value; }
    }
}