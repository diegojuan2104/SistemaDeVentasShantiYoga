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
    public partial class Pagina_Inicial : Form
    {
        public Pagina_Inicial()
        {
            InitializeComponent();
            estadoInicialSubmenus();
        }


        private void estadoInicialSubmenus() {
            panelClientes.Visible = false;
            panelProductos.Visible = false;
            panelVentas.Visible = false;
            panelEstadisticas.Visible = false;
        }

        private void esconderSubmenus() {
            if (panelEstadisticas.Visible == true) panelEstadisticas.Visible = false;
            if (panelClientes.Visible == true) panelClientes.Visible = false;
            if (panelProductos.Visible == true) panelProductos.Visible = false;
            if (panelVentas.Visible == true) panelVentas.Visible = false;
        }

        private void mostrarSubMenu(Panel subMenu) {
            if (subMenu.Visible == false)
            {
                esconderSubmenus();
                subMenu.Visible = true;
            }
            else {
                subMenu.Visible = false;
            }
        }

        private void Pagina_Inicial_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelVentas);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mostrarSubMenu(panelProductos);
        }

        private void btnProductosPV_Click(object sender, EventArgs e)
        {

        }

        private void btnProductosEO_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void btnPClientes_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelClientes);
        }

        private void Estadisticas_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelEstadisticas);
        }
    }
}
