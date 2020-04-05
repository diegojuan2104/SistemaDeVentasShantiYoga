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
    public partial class Form_Proveedor : Form
    {
        public Form_Proveedor()
        {
            InitializeComponent();
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            conexion.conectar();

            conexion.actualizarDataGrid(dataGridViewProveedores, "SELECT idProveedor AS id,nombre AS Nombre,celular AS Celular FROM Proveedor");
            conexion.desconectar();

            ConfiguracionDataGrid configuracionDataGrid = new ConfiguracionDataGrid();
            configuracionDataGrid.configurarDataGrid(dataGridViewProveedores);
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            Form_AInicial.form_ProveedorAgregar.ShowDialog();
        }
    }
}
