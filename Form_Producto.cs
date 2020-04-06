using System;
using System.Windows.Forms;

namespace ShantySystem
{
    public partial class Form_Producto : Form
    {
        Conexion conexion;
        public Form_Producto()
        {
            InitializeComponent();
        }

        private void Form_Producto_Load(object sender, EventArgs e)
        {
            conexion = new Conexion();
            conexion.conectar();

            conexion.cargarDataGrid(dataGridViewProductos, "SELECT Producto.idProducto AS Id,Producto.nombre AS Nombre" +
                ",Producto.costo AS Costo, Proveedor.nombre AS Proveedor FROM Producto INNER JOIN Proveedor ON Producto.idProveedorProducto = Proveedor.idProveedor");
            conexion.desconectar();

            Configuracion.configurarDataGrid(dataGridViewProductos);
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Form_AInicial.form_ProductoAgregar.ShowDialog();
        }
    }
}
