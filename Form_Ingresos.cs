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
            Conexion conexion = new Conexion();

            conexion.actualizarDataGrid(this.dataGridView1,"SELECT * FROM CLIENTE");
        }
    }
}
