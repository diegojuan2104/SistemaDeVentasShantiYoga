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
            connect = new SqlConnection("Data Source=DESKTOP-F1MGRLV;Initial Catalog=bdShanti;Integrated Security=True");
            connect.Open();
        }

        public void desconectar() {
            connect.Close();
        }

        public void ejecutarSql(string consulta) {
            SqlCommand comando = new SqlCommand(consulta,connect);

            int informacion = comando.ExecuteNonQuery();

            if (informacion > 0)
            {

                MessageBox.Show("Ok");
            }
            else {
                MessageBox.Show("Fail");
            }
        }

        public void actualizarDataGrid(DataGridView dataGridView, string consulta) {
            this.conectar();

            System.Data.DataSet dataSet = new System.Data.DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(consulta,connect);

            dataAdapter.Fill(dataSet, "Cliente");

            dataGridView.DataSource = dataSet;
            dataGridView.DataMember = "Cliente";

            this.desconectar();
        
        
        }
    }
}
