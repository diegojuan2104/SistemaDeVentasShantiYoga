using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShantySystem
{
    class Configuracion
    {
        public static void configurarDataGrid(DataGridView dataGridView1)
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.ScrollBars = ScrollBars.Both;
            dataGridView1.ForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.Size = new Size(1100, 580);
        }

        public static void soloNumeros(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public static bool isValidEmail(string email)
        {
            System.Text.RegularExpressions.Regex emailRegex = new System.Text.RegularExpressions.Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            System.Text.RegularExpressions.Match emailMatch = emailRegex.Match(email);
            return emailMatch.Success;
        }


        public static bool confirmacion() {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de continuar con la operación?", "Confirmación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Operación Cancelada");
                return false;
            }
            else {
                return true;
            }
        }
    }
}
