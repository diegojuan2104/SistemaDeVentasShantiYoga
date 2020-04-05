using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ShantySystem
{
    class Conexion
    {
        SqlConnection connect;

        public void conectar() {
            connect = new SqlConnection("Data Source=DESKTOP-D7ETEFD;Initial Catalog=dbshanti;Integrated Security=True");
            connect.Open();
        }

        public void desconectar() {
            connect.Close();
        }

        public void ejecutarSql(string consulta) {

            try
            {
                SqlCommand comando = new SqlCommand(consulta, connect);
                comando.ExecuteNonQuery();
                MessageBox.Show("Operación exitosa");
            }
            catch (Exception e) {
                MessageBox.Show("Error en la base de datos: " + e);
            }
        }

        public void actualizarDataGrid(DataGridView dataGridView, string consulta) {
            try
            {
                conectar();

                System.Data.DataSet dataSet = new System.Data.DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(consulta, connect);

                dataAdapter.Fill(dataSet, "Cliente");


                dataGridView.DataSource = dataSet;
                dataGridView.DataMember = "Cliente";

                desconectar();
            }
            catch (Exception e) {
                MessageBox.Show("Error en la base de datos: "+e);
            }
        }
    }
}
