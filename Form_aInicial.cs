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
    public partial class Form_AInicial : Form
    {


        public static Form_ClienteAgregar form_AgregarCliente;
        public static Form_ClienteInformacion form_InformacionCliente;
        public static Form_ProveedorAgregar form_ProveedorAgregar;


        public Form_AInicial()
        {
            InitializeComponent();
            estadoInicialSubmenus();
            form_AgregarCliente = new Form_ClienteAgregar();
            form_InformacionCliente = new Form_ClienteInformacion();
            form_ProveedorAgregar = new Form_ProveedorAgregar();

            AddOwnedForm(form_AgregarCliente);
            AddOwnedForm(form_InformacionCliente);
            AddOwnedForm(form_ProveedorAgregar);
        }



        //Constructor
        private void Pagina_Inicial_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

        }

        // Panel Principal
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        // btn Ventas
        private void btnMedia_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelVentas);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //btn Proveedores BD
        private void button3_Click(object sender, EventArgs e)
        {
            abrirformContenido(new Form_Proveedor());
        }

        //btn Productos
        private void button1_Click_1(object sender, EventArgs e)
        {
            mostrarSubMenu(panelProductos);
        }


        // btn Lista de productos
        private void btnProductosPV_Click(object sender, EventArgs e)
        {

        }


        // btn Productos por vencer 
        private void btnProductosEO_Click(object sender, EventArgs e)
        {

        }


        //btn ganancias
        private void button13_Click(object sender, EventArgs e)
        {

        }

        // btn clientes
        private void btnPClientes_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelClientes);

        }


        //btn estadisticas
        private void Estadisticas_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelEstadisticas);
        }


        //btn clientes en yoga
        private void btnClientesYoga_Click(object sender, EventArgs e)
        {

        }


        //btn clientes con deuda
        private void btnClientesCD_Click(object sender, EventArgs e)
        {

        }


        //btn listado de clientes
        private void btnClientesBD_Click(object sender, EventArgs e)
        {
            abrirformContenido(new Form_Cliente());
            
        }


        //btn compradores frecuentes
        private void btnCompradoresF_Click(object sender, EventArgs e)
        {

        }


        //btn Egresos
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        //btnIngresos
        private void btnIngresos_Click(object sender, EventArgs e)
        {
            
            abrirformContenido(new Form_Ingresos());

        }

        private void btnProductosSS_Click(object sender, EventArgs e)
        {

        }

        private void btnProductosEO_Click_1(object sender, EventArgs e)
        {

        }

        private void btnProductosMV_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        //Esconde todos los submenus incialmente
        private void estadoInicialSubmenus()
        {
            panelClientes.Visible = false;
            panelProductos.Visible = false;
            panelVentas.Visible = false;
            panelEstadisticas.Visible = false;
        }

        //Esconde el submenu que se encuentre desplegado actualmente
        private void esconderSubmenus()
        {
            if (panelEstadisticas.Visible == true) panelEstadisticas.Visible = false;
            if (panelClientes.Visible == true) panelClientes.Visible = false;
            if (panelProductos.Visible == true) panelProductos.Visible = false;
            if (panelVentas.Visible == true) panelVentas.Visible = false;
        }

        //Muestra el submenu seleccionado
        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                esconderSubmenus();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }


        private Form formActivo = null;

        // Abre el contenido del panel interno
        public void abrirformContenido(Form formContenido) {
            if (formActivo != null) formActivo.Close();

            formActivo = formContenido;
            formContenido.TopLevel = false;
            formContenido.FormBorderStyle = FormBorderStyle.None;
            formContenido.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formContenido);
            panelContenedor.Tag = formContenido;
            formContenido.BringToFront();
            formContenido.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                
        }
    }
}
