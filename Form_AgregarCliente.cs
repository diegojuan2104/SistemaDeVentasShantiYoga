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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

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

            if (txtNombre.Text != "" && txtApellido.Text != "" && txtTelefono.Text != "")
            {

                bool emailValidation = (txtEmail.Text != "" && isValidEmail(txtEmail.Text));
                conexion = new Conexion();
                conexion.conectar();

                if (emailValidation)
                {
                    return;
                }
                else
                {
                    MessageBox.Show("Email insertado es invalido");
                }
                string consulta = "INSERT INTO Cliente (nombres,apellidos,celular,correo,direccion) values ('" + txtNombre.Text.ToUpper() + "','" + txtApellido.Text.ToUpper() + "'," + txtTelefono.Text + ",'" + txtEmail.Text + "','" + txtDireccion.Text + "')";


                    conexion.ejecutarSql(consulta);

                    conexion.desconectar();

                
            
            }
            else {
                MessageBox.Show("Todos los campos señalados con '*' son obligatorios ");
            }

           // conexion.actualizarDataGrid(this.dataGridViewCliente, "SELECT * FROM CLIENTE");
        }
    }
}
