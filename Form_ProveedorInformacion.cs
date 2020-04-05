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
    public partial class Form_ProveedorInformacion : Form
    {

        Conexion conexion;
        public Form_ProveedorInformacion()
        {
            InitializeComponent();
        }

        private void Form_ProveedorInformacion_Load(object sender, EventArgs e)
        {
            conexion = new Conexion();

            txtId.Text = Form_Proveedor.id.Trim();
            txtNombre.Text = Form_Proveedor.nombre.Trim();
            txtTelefono.Text = Form_Proveedor.celular.Trim();
        }

        private void btnActualizarProveedor_Click(object sender, EventArgs e)
        {
            //Validación de campos obligatorios
            if (txtNombre.Text == "" || txtTelefono.Text == "") { MessageBox.Show("Todos los campos señalados con '*' son obligatorios "); return; }


            conexion.conectar();

            string consulta = "UPDATE Proveedor SET nombre='" + txtNombre.Text.ToUpper().Trim() + "',celular=" + txtTelefono.Text.Trim() + "  WHERE idProveedor =" + txtId.Text.Trim();
            conexion.ejecutarSql(consulta);
            conexion.desconectar();

            Form_AInicial pagina_Inicial = Owner as Form_AInicial;
            pagina_Inicial.abrirformContenido(new Form_Proveedor());

            Close();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Configuracion.soloNumeros(e);
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (!Configuracion.confirmacion()) return;

            conexion.conectar();

            string consulta = "DELETE FROM Proveedor WHERE idProveedor =" + txtId.Text;
            conexion.ejecutarSql(consulta);

            conexion.desconectar();

            Form_AInicial pagina_Inicial = Owner as Form_AInicial;
            pagina_Inicial.abrirformContenido(new Form_Proveedor());

            Close();
        }
    }
}