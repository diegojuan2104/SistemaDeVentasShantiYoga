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
    public partial class Form_ProveedorAgregar : Form
    {
        public Form_ProveedorAgregar()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            

            //Validación de campos obligatorios
            if (txtNombre.Text == "" || txtTelefono.Text == "") { MessageBox.Show("Todos los campos señalados con '*' son obligatorios "); return; }


            string consulta = "INSERT INTO Proveedor (nombre,celular) values ('" + txtNombre.Text.ToUpper().Trim() + "'," + txtTelefono.Text.Trim() + ")";

            conexion.conectar();
            conexion.ejecutarSql(consulta);
            conexion.desconectar();

            //Recargar página de clientes
            Form_AInicial pagina_Inicial = Owner as Form_AInicial;
            pagina_Inicial.abrirformContenido(new Form_Proveedor());

            limpiarCampos();
            Close();
        }

        public void limpiarCampos()
        {
            txtNombre.Clear(); txtTelefono.Clear(); 
        }
    }
}
