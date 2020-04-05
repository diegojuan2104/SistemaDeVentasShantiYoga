using System;
using System.Windows.Forms;

namespace ShantySystem
{
    public partial class Form_Proveedor : Form
    {

        Conexion conexion;
        public static string id, nombre, celular;
        public Form_Proveedor()
        {
            InitializeComponent();
        }

        //Cargar cliente inicialmente
        private void Proveedor_Load(object sender, EventArgs e)
        {
            conexion = new Conexion();
            conexion.conectar();

            conexion.actualizarDataGrid(dataGridViewProveedores, "SELECT idProveedor AS id,nombre AS Nombre,celular AS Celular FROM Proveedor");
            conexion.desconectar();

            Configuracion.configurarDataGrid(dataGridViewProveedores);
        }

        private void dataGridViewProveedores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow registro = dataGridViewProveedores.Rows[e.RowIndex];

                id = registro.Cells["id"].Value.ToString();
                nombre = registro.Cells["Nombre"].Value.ToString();
                celular = registro.Cells["Celular"].Value.ToString();
                Form_AInicial.form_ProveedorInformacion.ShowDialog();
            }
        }

        //Agregar nuevo cliente
        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            Form_AInicial.form_ProveedorAgregar.ShowDialog();
        }


        //Buscador de clientes
        private void txtBuscador_KeyUp(object sender, KeyEventArgs e)
        {
            conexion.conectar();
            conexion.actualizarDataGrid(dataGridViewProveedores, "SELECT idProveedor AS id,nombre AS Nombre,celular AS Celular FROM Proveedor where nombre like('" + txtBuscador.Text + "%') or celular like('" + txtBuscador.Text + "%') or idProveedor like('" + txtBuscador.Text + "%')");
            conexion.desconectar();
        }
    }
}
