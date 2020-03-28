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
    public partial class Form_InformacionCliente : Form
    {
        public Form_InformacionCliente()
        {
            InitializeComponent();
        }

        private void Form_InformacionCliente_Load(object sender, EventArgs e)
        {
            txtId.Text = Form_Clientes.id;
            txtNombre.Text = Form_Clientes.nombres;
            txtApellido.Text = Form_Clientes.apellidos;
            txtTelefono.Text = Form_Clientes.celular;
            txtEmail.Text = Form_Clientes.correo;
            txtDireccion.Text = Form_Clientes.direccion;
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarCliente_Click_1(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            conexion.conectar();

            string consulta = "UPDATE Cliente SET nombres='" + txtNombre.Text.ToUpper() + "',apellidos='" + txtApellido.Text.ToUpper() +  "',celular=" + txtTelefono.Text + ",correo='" + txtEmail.Text + "',direccion='" + txtDireccion.Text.ToUpper()+ "'  WHERE idCliente =" + txtId.Text;
            conexion.ejecutarSql(consulta);
            conexion.desconectar();

            Pagina_Inicial pagina_Inicial = Owner as Pagina_Inicial;
            pagina_Inicial.abrirformContenido(new Form_Clientes());

            Close();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            conexion.conectar();

            string consulta = "DELETE FROM Cliente WHERE idCliente ="+txtId.Text;
            conexion.ejecutarSql(consulta);

            conexion.desconectar();

            Pagina_Inicial pagina_Inicial = Owner as Pagina_Inicial;
            pagina_Inicial.abrirformContenido(new Form_Clientes());

            Close();
        }
    }
}
