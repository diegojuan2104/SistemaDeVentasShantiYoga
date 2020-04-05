namespace ShantySystem
{
    partial class Form_Ingresos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewIngresos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIngresos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewIngresos
            // 
            this.dataGridViewIngresos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIngresos.Location = new System.Drawing.Point(25, 54);
            this.dataGridViewIngresos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewIngresos.Name = "dataGridViewIngresos";
            this.dataGridViewIngresos.RowHeadersWidth = 51;
            this.dataGridViewIngresos.RowTemplate.Height = 24;
            this.dataGridViewIngresos.Size = new System.Drawing.Size(959, 353);
            this.dataGridViewIngresos.TabIndex = 0;
            this.dataGridViewIngresos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "INGRESOS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form_Ingresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 583);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewIngresos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_Ingresos";
            this.Text = "Form_Ingresos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Ingresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIngresos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewIngresos;
        private System.Windows.Forms.Label label2;
    }
}