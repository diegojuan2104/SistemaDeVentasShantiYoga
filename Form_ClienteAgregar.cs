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
    public partial class Form_ClienteAgregar : Form
    {
        Conexion conexion;

        public Form_ClienteAgregar()
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
        public static bool isValidEmail(string email)
        {
            System.Text.RegularExpressions.Regex emailRegex = new System.Text.RegularExpressions.Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            System.Text.RegularExpressions.Match emailMatch = emailRegex.Match(email);
            return emailMatch.Success;
        }


        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {


            //Validación email (El email no es obligatorio)
            if (txtEmail.Text != "") if (!(isValidEmail(txtEmail.Text))) { MessageBox.Show("Email invalido"); return; }

            //Validación de campos obligatorios
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtTelefono.Text == "") { MessageBox.Show("Todos los campos señalados con '*' son obligatorios "); return; }


            string consulta = "INSERT INTO Cliente (nombres,apellidos,celular,correo,direccion) values ('" + txtNombre.Text.ToUpper().Trim() + "','" + txtApellido.Text.ToUpper().Trim() + "'," + txtTelefono.Text.Trim() + ",'" + txtEmail.Text.Trim() + "','" + txtDireccion.Text.ToUpper().Trim() + "')";

            conexion.conectar();
            conexion.ejecutarSql(consulta);
            conexion.desconectar();

            //Recargar página de clientes
            Form_AInicial pagina_Inicial = Owner as Form_AInicial;
            pagina_Inicial.abrirformContenido(new Form_Cliente());

            limpiarCampos();
            Close();
        }


        public void limpiarCampos() {
            txtNombre.Clear();txtApellido.Clear();txtTelefono.Clear();txtEmail.Clear();txtDireccion.Clear();
           }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            txtNombre.SelectionStart = txtNombre.Text.Length;
        }
    }
}
