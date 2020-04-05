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
    public partial class Form_Cliente : Form
    {
        Conexion conexion;
        public static string id,nombres,apellidos,celular,direccion,correo;
      

        public Form_Cliente()
        {
            InitializeComponent();
        }

        private void Form_Clientes_Load(object sender, EventArgs e)
        {
          
            conexion = new Conexion();
            conexion.conectar();

            conexion.actualizarDataGrid(dataGridViewClientes, "SELECT idCliente AS id,nombres AS Nombres,apellidos AS Apellidos,celular AS Celular,correo AS Correo,direccion AS Dirección FROM CLIENTE");
            conexion.desconectar();

            Configuracion.configurarDataGrid(dataGridViewClientes);
        }


        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Form_AInicial.form_ClienteAgregar.ShowDialog();
        }

        //Realiza una consulta cada ves que se ingresa una letra
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            conexion.conectar();
            conexion.actualizarDataGrid(dataGridViewClientes, "SELECT idCliente AS id,nombres AS Nombres,apellidos AS Apellidos,celular AS Celular,correo AS Correo,direccion AS Dirección FROM Cliente where nombres like('" + txtBuscador.Text + "%') or apellidos like('" + txtBuscador.Text + "%') or idCliente like('" + txtBuscador.Text + "%')");
            conexion.desconectar();
        }

        private void dataGridViewClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow registro = dataGridViewClientes.Rows[e.RowIndex];

                id = registro.Cells["id"].Value.ToString();
                nombres = registro.Cells["Nombres"].Value.ToString();
                apellidos = registro.Cells["Apellidos"].Value.ToString();
                celular = registro.Cells["Celular"].Value.ToString();
                correo = registro.Cells["Correo"].Value.ToString();
                direccion = registro.Cells["Dirección"].Value.ToString();

                Form_AInicial.form_ClienteInformacion.ShowDialog();
            }

        }
    }
}
