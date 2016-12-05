namespace MenuPrincipal.Compra
{
    partial class BucarCompras
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textTotalCcompras = new System.Windows.Forms.TextBox();
            this.btnBuscarCompras = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAtrasBC = new System.Windows.Forms.Button();
            this.btnVolverBC = new System.Windows.Forms.Button();
            this.iTalk_HeaderLabel1 = new iTalk.iTalk_HeaderLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(720, 205);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(547, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Invertido";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textTotalCcompras
            // 
            this.textTotalCcompras.Enabled = false;
            this.textTotalCcompras.Location = new System.Drawing.Point(548, 376);
            this.textTotalCcompras.Multiline = true;
            this.textTotalCcompras.Name = "textTotalCcompras";
            this.textTotalCcompras.Size = new System.Drawing.Size(111, 37);
            this.textTotalCcompras.TabIndex = 2;
            // 
            // btnBuscarCompras
            // 
            this.btnBuscarCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarCompras.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnBuscarCompras.Image = global::MenuPrincipal.Properties.Resources._1478747007_xmag;
            this.btnBuscarCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCompras.Location = new System.Drawing.Point(306, 104);
            this.btnBuscarCompras.Name = "btnBuscarCompras";
            this.btnBuscarCompras.Size = new System.Drawing.Size(73, 40);
            this.btnBuscarCompras.TabIndex = 3;
            this.btnBuscarCompras.Text = "Buscar";
            this.btnBuscarCompras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCompras.UseVisualStyleBackColor = true;
            this.btnBuscarCompras.Click += new System.EventHandler(this.btnBuscarCompras_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::MenuPrincipal.Properties.Resources.Casa1_0;
            this.pictureBox1.InitialImage = global::MenuPrincipal.Properties.Resources.Casa;
            this.pictureBox1.Location = new System.Drawing.Point(306, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnAtrasBC
            // 
            this.btnAtrasBC.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAtrasBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtrasBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtrasBC.Location = new System.Drawing.Point(1, -3);
            this.btnAtrasBC.Name = "btnAtrasBC";
            this.btnAtrasBC.Size = new System.Drawing.Size(48, 30);
            this.btnAtrasBC.TabIndex = 16;
            this.btnAtrasBC.Text = "<<";
            this.btnAtrasBC.UseVisualStyleBackColor = true;
            // 
            // btnVolverBC
            // 
            this.btnVolverBC.BackgroundImage = global::MenuPrincipal.Properties.Resources.Casa1_0;
            this.btnVolverBC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolverBC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverBC.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVolverBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverBC.Location = new System.Drawing.Point(306, 389);
            this.btnVolverBC.Name = "btnVolverBC";
            this.btnVolverBC.Size = new System.Drawing.Size(57, 36);
            this.btnVolverBC.TabIndex = 18;
            this.btnVolverBC.UseVisualStyleBackColor = true;
            this.btnVolverBC.Click += new System.EventHandler(this.btnVolverBC_Click_1);
            // 
            // iTalk_HeaderLabel1
            // 
            this.iTalk_HeaderLabel1.AutoSize = true;
            this.iTalk_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_HeaderLabel1.ForeColor = System.Drawing.Color.Black;
            this.iTalk_HeaderLabel1.Location = new System.Drawing.Point(190, -3);
            this.iTalk_HeaderLabel1.Name = "iTalk_HeaderLabel1";
            this.iTalk_HeaderLabel1.Size = new System.Drawing.Size(343, 45);
            this.iTalk_HeaderLabel1.TabIndex = 14;
            this.iTalk_HeaderLabel1.Text = "Registro de Compras";
            // 
            // BucarCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(721, 437);
            this.Controls.Add(this.btnVolverBC);
            this.Controls.Add(this.btnAtrasBC);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.iTalk_HeaderLabel1);
            this.Controls.Add(this.btnBuscarCompras);
            this.Controls.Add(this.textTotalCcompras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BucarCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BucarCompras";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTotalCcompras;
        private System.Windows.Forms.Button btnBuscarCompras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private iTalk.iTalk_HeaderLabel iTalk_HeaderLabel1;
        private System.Windows.Forms.Button btnAtrasBC;
        private System.Windows.Forms.Button btnVolverBC;
    }
}