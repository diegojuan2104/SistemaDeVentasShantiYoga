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

        Configuracion configuracion;
        public Form_ProveedorAgregar()
        {
            InitializeComponent();
            configuracion = new Configuracion();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            
            //Validación de campos obligatorios
            if (txtNombre.Text == "" || txtTelefono.Text == "") { MessageBox.Show("Todos los campos señalados con '*' son obligatorios "); return; }
            
            //Validación de que no exita proveedor con ese nombre
            List<String> listaProveedores = (conexion.listaDeUnCampo("SElECT nombre from Proveedor", "nombre"));
            bool yaExiste =  listaProveedores.Any(str => str.Contains(txtNombre.Text.ToUpper().Trim()));
            if (yaExiste) {MessageBox.Show("Ya existe un Proveedor con el nombre:  "+ txtNombre.Text.ToUpper()); return;}


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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Configuracion.soloNumeros(e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
