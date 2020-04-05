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
    public partial class Form_ClienteInformacion : Form
    {
        Configuracion configuracion;
        Conexion conexion;
        public Form_ClienteInformacion()
        {
            InitializeComponent();
        }

        private void Form_InformacionCliente_Load(object sender, EventArgs e)
        {
            // Se carga toda la información del cliente seleccionado

            configuracion = new Configuracion();
            conexion = new Conexion();

            txtId.Text = Form_Cliente.id.Trim();
            txtNombre.Text = Form_Cliente.nombres.Trim();
            txtApellido.Text = Form_Cliente.apellidos.Trim();
            txtTelefono.Text = Form_Cliente.celular.Trim();
            txtEmail.Text = Form_Cliente.correo.Trim();
            txtDireccion.Text = Form_Cliente.direccion.Trim();
        }

        private void btnAgregarCliente_Click_1(object sender, EventArgs e)
        {
            //Validación email (El email no es obligatorio)
            if (!string.IsNullOrEmpty(txtEmail.Text.Trim())) { if (!(Configuracion.isValidEmail(txtEmail.Text.Trim()))) { MessageBox.Show("Email invalido:" + txtEmail.Text); return; } }

            //Validación de campos obligatorios
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtTelefono.Text == "") { MessageBox.Show("Todos los campos señalados con '*' son obligatorios "); return; }

            
            conexion.conectar();

            string consulta = "UPDATE Cliente SET nombres='" + txtNombre.Text.ToUpper().Trim() + "',apellidos='" + txtApellido.Text.ToUpper().Trim() + "',celular=" + txtTelefono.Text.Trim() + ",correo='" + txtEmail.Text.Trim() + "',direccion='" + txtDireccion.Text.ToUpper().Trim() + "'  WHERE idCliente =" + txtId.Text.Trim();
            conexion.ejecutarSql(consulta);
            conexion.desconectar();

            Form_AInicial pagina_Inicial = Owner as Form_AInicial;
            pagina_Inicial.abrirformContenido(new Form_Cliente());

            Close();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (!Configuracion.confirmacion()) return;
            conexion.conectar();

            string consulta = "DELETE FROM Cliente WHERE idCliente =" + txtId.Text;
            conexion.ejecutarSql(consulta);

            conexion.desconectar();

            Form_AInicial pagina_Inicial = Owner as Form_AInicial;
            pagina_Inicial.abrirformContenido(new Form_Cliente());

            Close();
        }


        //Método de validación de email


        private void txtNombre_MouseClick(object sender, MouseEventArgs e)
        {
            txtNombre.SelectionStart = txtNombre.Text.Length;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Configuracion.soloNumeros(e);
        }
    }
}
