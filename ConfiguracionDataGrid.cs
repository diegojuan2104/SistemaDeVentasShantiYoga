using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShantySystem
{
    class ConfiguracionDataGrid
    {
        public void configurarDataGrid(DataGridView dataGridView1) {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.ScrollBars = ScrollBars.Both;
            dataGridView1.ForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.RowTemplate.Height = 40;

        }
    }
}
