using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joyeria_el_diamante.PL
{
    public partial class EMPLEADOS : Form
    {
        public EMPLEADOS()
        {
            InitializeComponent();
        }

        private void EMPLEADOS_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'joyeria_el_diamanteDataSet.empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.joyeria_el_diamanteDataSet.empleados);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
