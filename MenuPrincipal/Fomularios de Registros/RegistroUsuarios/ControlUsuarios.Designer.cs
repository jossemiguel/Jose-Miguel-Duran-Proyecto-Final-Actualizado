namespace MenuPrincipal.RegistroUsuario
{
    partial class ControlUsuarios
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRcontrasena = new System.Windows.Forms.TextBox();
            this.txtRConfirmaContrasena = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTipoUsuario = new System.Windows.Forms.ComboBox();
            this.personasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compraventasDbDataSet1 = new MenuPrincipal.CompraventasDbDataSet1();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.registroUsuarioTableAdapter = new MenuPrincipal.CompraventasDbDataSetTableAdapters.RegistroUsuarioTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.ComboBox();
            this.personasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personasTableAdapter = new MenuPrincipal.CompraventasDbDataSet1TableAdapters.PersonasTableAdapter();
            this.DatosUsuario = new System.Windows.Forms.DataGridView();
            this.personaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compraventasDbDataSet = new MenuPrincipal.CompraventasDbDataSet();
            this.registroUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnUsuario = new System.Windows.Forms.Button();
            this.personasDataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.FechaR = new System.Windows.Forms.MaskedTextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPrueba = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraventasDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraventasDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasDataTable1BindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Usuarios";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirme Contraseña";
            // 
            // txtRcontrasena
            // 
            this.txtRcontrasena.Location = new System.Drawing.Point(163, 184);
            this.txtRcontrasena.Name = "txtRcontrasena";
            this.txtRcontrasena.PasswordChar = '*';
            this.txtRcontrasena.Size = new System.Drawing.Size(164, 20);
            this.txtRcontrasena.TabIndex = 3;
            this.txtRcontrasena.TextChanged += new System.EventHandler(this.txtRcontrasena_TextChanged);
            this.txtRcontrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRcontrasena_KeyPress);
            // 
            // txtRConfirmaContrasena
            // 
            this.txtRConfirmaContrasena.Location = new System.Drawing.Point(163, 216);
            this.txtRConfirmaContrasena.Name = "txtRConfirmaContrasena";
            this.txtRConfirmaContrasena.PasswordChar = '*';
            this.txtRConfirmaContrasena.Size = new System.Drawing.Size(164, 20);
            this.txtRConfirmaContrasena.TabIndex = 4;
            this.txtRConfirmaContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRConfirmaContrasena_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo Usuario";
            // 
            // txtTipoUsuario
            // 
            this.txtTipoUsuario.BackColor = System.Drawing.Color.White;
            this.txtTipoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtTipoUsuario.FormattingEnabled = true;
            this.txtTipoUsuario.Items.AddRange(new object[] {
            "Presidente",
            "Vice-Presidente",
            "Gerente",
            "Supervisor"});
            this.txtTipoUsuario.Location = new System.Drawing.Point(163, 129);
            this.txtTipoUsuario.Name = "txtTipoUsuario";
            this.txtTipoUsuario.Size = new System.Drawing.Size(164, 21);
            this.txtTipoUsuario.TabIndex = 2;
            this.txtTipoUsuario.Tag = "Enter";
            this.txtTipoUsuario.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.txtTipoUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipoUsuario_KeyPress);
            // 
            // personasBindingSource
            // 
            this.personasBindingSource.DataMember = "Personas";
            this.personasBindingSource.DataSource = this.compraventasDbDataSet1;
            // 
            // compraventasDbDataSet1
            // 
            this.compraventasDbDataSet1.DataSetName = "CompraventasDbDataSet1";
            this.compraventasDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "UsuarioId";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // registroUsuarioTableAdapter
            // 
            this.registroUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(249, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Auto";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(99, 321);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(246, 17);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 52;
            this.progressBar1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModificar.Image = global::MenuPrincipal.Properties.Resources._1480756610_Modify1;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(222, 257);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(83, 36);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnModificar, "Ver Registro Usuarios");
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminar.Image = global::MenuPrincipal.Properties.Resources._1478747086_button_cancel;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(311, 257);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(83, 36);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Elininar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnEliminar, "Cancelar Registro");
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.Image = global::MenuPrincipal.Properties.Resources._1478747176_Save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(125, 257);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 36);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnGuardar, "Guardar Registro");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 15);
            this.label8.TabIndex = 53;
            this.label8.Text = "Fecha Registro";
            // 
            // user
            // 
            this.user.FormattingEnabled = true;
            this.user.Location = new System.Drawing.Point(161, 98);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(166, 21);
            this.user.TabIndex = 55;
            this.user.LocationChanged += new System.EventHandler(this.comboBox1_LocationChanged);
            // 
            // personasBindingSource1
            // 
            this.personasBindingSource1.DataMember = "Personas";
            // 
            // personasTableAdapter
            // 
            this.personasTableAdapter.ClearBeforeFill = true;
            // 
            // DatosUsuario
            // 
            this.DatosUsuario.AutoGenerateColumns = false;
            this.DatosUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personaIdDataGridViewTextBoxColumn,
            this.cedulaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn});
            this.DatosUsuario.DataSource = this.personasBindingSource;
            this.DatosUsuario.Location = new System.Drawing.Point(744, 9);
            this.DatosUsuario.Name = "DatosUsuario";
            this.DatosUsuario.Size = new System.Drawing.Size(10, 10);
            this.DatosUsuario.TabIndex = 58;
            this.DatosUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatosUsuario_CellClick);
            this.DatosUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatosUsuario_CellContentClick);
            // 
            // personaIdDataGridViewTextBoxColumn
            // 
            this.personaIdDataGridViewTextBoxColumn.DataPropertyName = "PersonaId";
            this.personaIdDataGridViewTextBoxColumn.HeaderText = "PersonaId";
            this.personaIdDataGridViewTextBoxColumn.Name = "personaIdDataGridViewTextBoxColumn";
            this.personaIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            // 
            // compraventasDbDataSet
            // 
            this.compraventasDbDataSet.DataSetName = "CompraventasDbDataSet";
            this.compraventasDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registroUsuarioBindingSource
            // 
            this.registroUsuarioBindingSource.DataMember = "RegistroUsuario";
            this.registroUsuarioBindingSource.DataSource = this.compraventasDbDataSet;
            // 
            // btnUsuario
            // 
            this.btnUsuario.Image = global::MenuPrincipal.Properties.Resources.Lupa;
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(230, 61);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(75, 31);
            this.btnUsuario.TabIndex = 60;
            this.btnUsuario.Text = "buscar";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // personasDataTable1BindingSource
            // 
            this.personasDataTable1BindingSource.DataMember = "Personas_DataTable1";
            this.personasDataTable1BindingSource.DataSource = this.personasBindingSource;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(821, 25);
            this.fillByToolStrip.TabIndex = 61;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.Visible = false;
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click_2);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Image = global::MenuPrincipal.Properties.Resources._1480756529_Add_Male_User;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(33, 257);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 36);
            this.btnNuevo.TabIndex = 62;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // FechaR
            // 
            this.FechaR.Location = new System.Drawing.Point(163, 155);
            this.FechaR.Mask = "00/00/0000";
            this.FechaR.Name = "FechaR";
            this.FechaR.Size = new System.Drawing.Size(161, 20);
            this.FechaR.TabIndex = 63;
            this.FechaR.ValidatingType = typeof(System.DateTime);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(162, 61);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(62, 29);
            this.txtId.TabIndex = 64;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrueba
            // 
            this.txtPrueba.Location = new System.Drawing.Point(342, 48);
            this.txtPrueba.Name = "txtPrueba";
            this.txtPrueba.Size = new System.Drawing.Size(52, 20);
            this.txtPrueba.TabIndex = 65;
            // 
            // ControlUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(434, 359);
            this.Controls.Add(this.txtPrueba);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.FechaR);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.DatosUsuario);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTipoUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtRConfirmaContrasena);
            this.Controls.Add(this.txtRcontrasena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "ControlUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlUsuarios";
            this.Load += new System.EventHandler(this.ControlUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraventasDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraventasDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroUsuarioBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.personasDataTable1BindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRcontrasena;
        private System.Windows.Forms.TextBox txtRConfirmaContrasena;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtTipoUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnModificar;
        private CompraventasDbDataSetTableAdapters.RegistroUsuarioTableAdapter registroUsuarioTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox user;
        private CompraventasDbDataSet1 compraventasDbDataSet1;
        private System.Windows.Forms.BindingSource personasBindingSource;
        private CompraventasDbDataSet1TableAdapters.PersonasTableAdapter personasTableAdapter;
        private System.Windows.Forms.DataGridView DatosUsuario;
        private System.Windows.Forms.BindingSource registroUsuarioBindingSource;
        private CompraventasDbDataSet compraventasDbDataSet;
        //private CompraventasDbDataSet2 compraventasDbDataSet2;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        //private CompraventasDbDataSet2TableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.BindingSource personasDataTable1BindingSource;
       // private CompraventasDbDataSet1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
       // private CompraventasDbDataSet3 compraventasDbDataSet3;
        private System.Windows.Forms.BindingSource personasBindingSource1;
       // private CompraventasDbDataSet3TableAdapters.PersonasTableAdapter personasTableAdapter1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.MaskedTextBox FechaR;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPrueba;
    }
}