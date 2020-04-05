namespace ShantySystem
{
    partial class Form_ProveedorInformacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnActualizarProveedor = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminarProveedor = new System.Windows.Forms.Button();
            this.btnEgresosProveedor = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Nombre(s):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Celular/Fijo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(93, 76);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(202, 20);
            this.txtNombre.TabIndex = 52;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(92, 109);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(202, 20);
            this.txtTelefono.TabIndex = 54;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 39);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(299, 76);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "*";
            // 
            // btnActualizarProveedor
            // 
            this.btnActualizarProveedor.Location = new System.Drawing.Point(154, 168);
            this.btnActualizarProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarProveedor.Name = "btnActualizarProveedor";
            this.btnActualizarProveedor.Size = new System.Drawing.Size(69, 29);
            this.btnActualizarProveedor.TabIndex = 60;
            this.btnActualizarProveedor.Text = "Actualizar";
            this.btnActualizarProveedor.UseVisualStyleBackColor = true;
            this.btnActualizarProveedor.Click += new System.EventHandler(this.btnActualizarProveedor_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 39);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 61;
            this.label10.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(93, 39);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(202, 20);
            this.txtId.TabIndex = 62;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnActualizarProveedor);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(356, 265);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Actuales";
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.BackColor = System.Drawing.Color.Red;
            this.btnEliminarProveedor.Location = new System.Drawing.Point(418, 293);
            this.btnEliminarProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.Size = new System.Drawing.Size(139, 28);
            this.btnEliminarProveedor.TabIndex = 36;
            this.btnEliminarProveedor.Text = "Eliminar Proveedor";
            this.btnEliminarProveedor.UseVisualStyleBackColor = false;
            this.btnEliminarProveedor.Click += new System.EventHandler(this.btnEliminarProveedor_Click);
            // 
            // btnEgresosProveedor
            // 
            this.btnEgresosProveedor.Location = new System.Drawing.Point(418, 36);
            this.btnEgresosProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.btnEgresosProveedor.Name = "btnEgresosProveedor";
            this.btnEgresosProveedor.Size = new System.Drawing.Size(122, 29);
            this.btnEgresosProveedor.TabIndex = 63;
            this.btnEgresosProveedor.Text = "Egresos Proveedor";
            this.btnEgresosProveedor.UseVisualStyleBackColor = true;
            // 
            // Form_ProveedorInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 332);
            this.Controls.Add(this.btnEgresosProveedor);
            this.Controls.Add(this.btnEliminarProveedor);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_ProveedorInformacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ProveedorInformacion";
            this.Load += new System.EventHandler(this.Form_ProveedorInformacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnActualizarProveedor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminarProveedor;
        private System.Windows.Forms.Button btnEgresosProveedor;
    }
}