namespace MenuPrincipal.Fomularios_de_Registros.RegistroUsuarios
{
    partial class VerClientes
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
            this.btnAtrasBC = new System.Windows.Forms.Button();
            this.iTalk_HeaderLabel1 = new iTalk.iTalk_HeaderLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBuscarEmpleados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtrasBC
            // 
            this.btnAtrasBC.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAtrasBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtrasBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtrasBC.Location = new System.Drawing.Point(-60, 53);
            this.btnAtrasBC.Name = "btnAtrasBC";
            this.btnAtrasBC.Size = new System.Drawing.Size(48, 30);
            this.btnAtrasBC.TabIndex = 30;
            this.btnAtrasBC.Text = "<<";
            this.btnAtrasBC.UseVisualStyleBackColor = true;
            // 
            // iTalk_HeaderLabel1
            // 
            this.iTalk_HeaderLabel1.AutoSize = true;
            this.iTalk_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_HeaderLabel1.ForeColor = System.Drawing.Color.Black;
            this.iTalk_HeaderLabel1.Location = new System.Drawing.Point(196, -3);
            this.iTalk_HeaderLabel1.Name = "iTalk_HeaderLabel1";
            this.iTalk_HeaderLabel1.Size = new System.Drawing.Size(329, 45);
            this.iTalk_HeaderLabel1.TabIndex = 28;
            this.iTalk_HeaderLabel1.Text = "Registro de Clientes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(720, 205);
            this.dataGridView1.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::MenuPrincipal.Properties.Resources.Casa1_0;
            this.pictureBox1.InitialImage = global::MenuPrincipal.Properties.Resources.Casa;
            this.pictureBox1.Location = new System.Drawing.Point(305, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // btnBuscarEmpleados
            // 
            this.btnBuscarEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarEmpleados.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnBuscarEmpleados.Image = global::MenuPrincipal.Properties.Resources._1478747007_xmag;
            this.btnBuscarEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarEmpleados.Location = new System.Drawing.Point(305, 78);
            this.btnBuscarEmpleados.Name = "btnBuscarEmpleados";
            this.btnBuscarEmpleados.Size = new System.Drawing.Size(73, 40);
            this.btnBuscarEmpleados.TabIndex = 27;
            this.btnBuscarEmpleados.Text = "Buscar";
            this.btnBuscarEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarEmpleados.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleados.Click += new System.EventHandler(this.btnBuscarEmpleados_Click);
            // 
            // VerClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 347);
            this.Controls.Add(this.btnAtrasBC);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.iTalk_HeaderLabel1);
            this.Controls.Add(this.btnBuscarEmpleados);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VerClientes";
            this.Text = "VerClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtrasBC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private iTalk.iTalk_HeaderLabel iTalk_HeaderLabel1;
        private System.Windows.Forms.Button btnBuscarEmpleados;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}