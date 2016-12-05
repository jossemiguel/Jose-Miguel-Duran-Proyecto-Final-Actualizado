namespace MenuPrincipal.Fomularios_de_Registros.RegistroUsuarios
{
    partial class VerEmpleados
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
            this.btnBuscarEmpleados = new System.Windows.Forms.Button();
            this.btnAtrasBC = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iTalk_HeaderLabel1 = new iTalk.iTalk_HeaderLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarEmpleados
            // 
            this.btnBuscarEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarEmpleados.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnBuscarEmpleados.Image = global::MenuPrincipal.Properties.Resources._1478747007_xmag;
            this.btnBuscarEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarEmpleados.Location = new System.Drawing.Point(310, 49);
            this.btnBuscarEmpleados.Name = "btnBuscarEmpleados";
            this.btnBuscarEmpleados.Size = new System.Drawing.Size(73, 40);
            this.btnBuscarEmpleados.TabIndex = 22;
            this.btnBuscarEmpleados.Text = "Buscar";
            this.btnBuscarEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarEmpleados.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleados.Click += new System.EventHandler(this.btnBuscarEmpleados_Click);
            // 
            // btnAtrasBC
            // 
            this.btnAtrasBC.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAtrasBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtrasBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtrasBC.Location = new System.Drawing.Point(-218, -86);
            this.btnAtrasBC.Name = "btnAtrasBC";
            this.btnAtrasBC.Size = new System.Drawing.Size(48, 30);
            this.btnAtrasBC.TabIndex = 25;
            this.btnAtrasBC.Text = "<<";
            this.btnAtrasBC.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(720, 205);
            this.dataGridView1.TabIndex = 19;
            // 
            // iTalk_HeaderLabel1
            // 
            this.iTalk_HeaderLabel1.AutoSize = true;
            this.iTalk_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_HeaderLabel1.ForeColor = System.Drawing.Color.Black;
            this.iTalk_HeaderLabel1.Location = new System.Drawing.Point(-29, -86);
            this.iTalk_HeaderLabel1.Name = "iTalk_HeaderLabel1";
            this.iTalk_HeaderLabel1.Size = new System.Drawing.Size(343, 45);
            this.iTalk_HeaderLabel1.TabIndex = 23;
            this.iTalk_HeaderLabel1.Text = "Registro de Compras";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::MenuPrincipal.Properties.Resources.Casa1_0;
            this.pictureBox1.InitialImage = global::MenuPrincipal.Properties.Resources.Casa;
            this.pictureBox1.Location = new System.Drawing.Point(87, -43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Registro de Empleados";
            // 
            // VerEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtrasBC);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.iTalk_HeaderLabel1);
            this.Controls.Add(this.btnBuscarEmpleados);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VerEmpleados";
            this.Text = "VerEmpleados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarEmpleados;
        private System.Windows.Forms.Button btnAtrasBC;
        private System.Windows.Forms.DataGridView dataGridView1;
        private iTalk.iTalk_HeaderLabel iTalk_HeaderLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}