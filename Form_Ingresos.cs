using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShantySystem
{
    public partial class Form_Ingresos : Form
    {
        public Form_Ingresos()
        {
            InitializeComponent();
        }

        private void Form_Ingresos_Load(object sender, EventArgs e)
        {
            ConfiguracionDataGrid configuracionDataGrid = new ConfiguracionDataGrid();

            configuracionDataGrid.configurarDataGrid(dataGridViewIngresos);
           
            Conexion conexion = new Conexion();

            conexion.actualizarDataGrid(this.dataGridViewIngresos,"SELECT * FROM CLIENTE");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
