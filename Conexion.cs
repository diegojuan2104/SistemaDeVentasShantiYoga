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
        SqlConnection conexion;
        SqlCommand comando;

        public void conectar() {
            conexion = new SqlConnection("Data Source=DESKTOP-D7ETEFD;Initial Catalog=dbshanti;Integrated Security=True");
            conexion.Open();
        }

        public void desconectar() {
            conexion.Close();
        }

        public void ejecutarSql(string consulta) {

            try
            {
                 comando = new SqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Operación exitosa");
            }
            catch (Exception e) {
                MessageBox.Show("Error en la base de datos: " + e);
            }
        }

        public void cargarDataGrid(DataGridView dataGridView, string consulta) {
            try
            {
                conectar();

                System.Data.DataSet dataSet = new System.Data.DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(consulta, conexion);

                dataAdapter.Fill(dataSet, "Cliente");


                dataGridView.DataSource = dataSet;
                dataGridView.DataMember = "Cliente";

                desconectar();
            }
            catch (Exception e) {
                MessageBox.Show("Error en la base de datos: "+e);
            }
        }

        public void cargarComboBox(ComboBox comboBox,String consulta,String campo) {
            try
            {
                conectar();
                comando = new SqlCommand(consulta, conexion);
                SqlDataReader dataReader = comando.ExecuteReader();

                while (dataReader.Read()) {
                    comboBox.Items.Add(dataReader[campo].ToString());
                }
                desconectar();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en la base de datos: " + e);
            }

        }

        public List<String> listaDeUnCampo(String consulta, String campo) {
            try
            {
                conectar();
                comando = new SqlCommand(consulta, conexion);
                SqlDataReader dataReader = comando.ExecuteReader();

                List<String> list = new List<String>();

                while (dataReader.Read())
                {
                    list.Add(dataReader[campo].ToString());
                    Console.WriteLine(dataReader[campo].ToString());
                }
                desconectar();
                return list;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en la base de datos: " + e);
                return null;
            }
        }
    }
}
