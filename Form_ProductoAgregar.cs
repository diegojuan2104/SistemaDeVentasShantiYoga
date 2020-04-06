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
    public partial class Form_ProductoAgregar : Form
    {

        Conexion conexion;
        public Form_ProductoAgregar()
        {
            InitializeComponent();
        }


        private void Form_ProductoAgregar_Load(object sender, EventArgs e)
        {
            //Carga inicialmete el nombre de los proveedores vigentes   
            conexion = new Conexion();
            conexion.cargarComboBox(cbxProveedor, "SELECT nombre from Proveedor", "nombre");
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {
           if(txtCosto.Text != ""){
                txtCosto.Text =  Double.Parse(txtCosto.Text).ToString("0,0");
                txtCosto.SelectionStart = txtCosto.Text.Length;
            }

            if (txtCosto.Text == "00") txtCosto.Clear();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            //Validación de campos obligatorios
            if (txtNombre.Text == "" || txtCosto.Text == "") { MessageBox.Show("Todos los campos señalados con '*' son obligatorios "); return; }

        }
    }
}
