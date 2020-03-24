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
            ConfiguracionDataGrid configuracionDataGrid = new ConfiguracionDataGrid();

            configuracionDataGrid.configurarDataGrid(dataGridViewClientes);

            Conexion conexion = new Conexion();

            conexion.conectar();

            conexion.actualizarDataGrid(dataGridViewClientes, "SELECT * FROM CLIENTE");

            conexion.desconectar();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Form_AgregarCliente form_AgregarCliente = new Form_AgregarCliente();

            form_AgregarCliente.ShowDialog();
        }
    }
}
