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
    public partial class Form_AgregarCliente : Form
    {
        Conexion conexion;

        public Form_AgregarCliente()
        {
            InitializeComponent();
        }

        private void Form_AgregarCliente_Load(object sender, EventArgs e)
        {
            conexion = new Conexion();
        }

        //Evento de sólo números
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        //Método de validación de email
        public bool isValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {


            //Validación email (El email no es obligatorio)
            if (txtEmail.Text != "") if (!(isValidEmail(txtEmail.Text))) { MessageBox.Show("Email invalido"); return; }

            //Validación de campos obligatorios
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtTelefono.Text == "") { MessageBox.Show("Todos los campos señalados con '*' son obligatorios "); return; }


            string consulta = "INSERT INTO Cliente (nombres,apellidos,celular,correo,direccion) values ('" + txtNombre.Text.ToUpper() + "','" + txtApellido.Text.ToUpper() + "'," + txtTelefono.Text + ",'" + txtEmail.Text + "','" + txtDireccion.Text.ToUpper() + "')";

            conexion.conectar();
            conexion.ejecutarSql(consulta);
            conexion.desconectar();

            //Recargar página de clientes
            Pagina_Inicial pagina_Inicial = Owner as Pagina_Inicial;
            pagina_Inicial.abrirformContenido(new Form_Clientes());

            limpiarCampos();
            Close();
        }


        public void limpiarCampos() {
            txtNombre.Clear();txtApellido.Clear();txtTelefono.Clear();txtEmail.Clear();txtDireccion.Clear();
           }
    }
}
