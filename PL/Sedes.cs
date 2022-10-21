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
    public partial class Sedes : Form
    {
        public Sedes()
        {
            InitializeComponent();
        }

        private void Sedes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'joyeria_el_diamanteDataSet.sedes' Puede moverla o quitarla según sea necesario.
            this.sedesTableAdapter.Fill(this.joyeria_el_diamanteDataSet.sedes);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
