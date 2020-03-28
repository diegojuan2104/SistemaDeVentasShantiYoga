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
    public partial class Form_Clientes : Form
    {
        public Form_Clientes()
        {
            InitializeComponent();
        }

        private void Form_Clientes_Load(object sender, EventArgs e)
        {
          
            Conexion conexion = new Conexion();
            conexion.conectar();

            conexion.actualizarDataGrid(dataGridViewClientes, "SELECT * FROM CLIENTE");
            conexion.desconectar();

            ConfiguracionDataGrid configuracionDataGrid = new ConfiguracionDataGrid();
            configuracionDataGrid.configurarDataGrid(dataGridViewClientes);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Pagina_Inicial.form_AgregarCliente.ShowDialog();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            Conexion conexion = new Conexion();
            conexion.conectar();

            conexion.actualizarDataGrid(dataGridViewClientes, "SELECT * FROM Cliente where nombres like('" + txtBuscador.Text + "%') or apellidos like('" + txtBuscador.Text + "%')");
            conexion.desconectar();
        }

        private void dataGridViewClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow registro = dataGridViewClientes.Rows[e.RowIndex];

                MessageBox.Show(registro.Cells["nombres"].Value.ToString());
            }

        }

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

         
        }
    }
}
