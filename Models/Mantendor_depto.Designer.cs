namespace Turismo
{
    partial class Mantendor_depto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantendor_depto));
            this.dgvDepartamento = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarDepto = new System.Windows.Forms.Button();
            this.txtBuscarDepto = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminarDepto = new System.Windows.Forms.Button();
            this.cbxDisponibilidad = new System.Windows.Forms.ComboBox();
            this.cbxTelevision = new System.Windows.Forms.ComboBox();
            this.cbxAmoblado = new System.Windows.Forms.ComboBox();
            this.cbxInternet = new System.Windows.Forms.ComboBox();
            this.cbxCalefaccion = new System.Windows.Forms.ComboBox();
            this.cbxBanio = new System.Windows.Forms.ComboBox();
            this.cbxHabitacion = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtNomdepto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnActualizarDepto = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cbxComuna = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDepartamento
            // 
            this.dgvDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepartamento.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepartamento.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDepartamento.Location = new System.Drawing.Point(544, 173);
            this.dgvDepartamento.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDepartamento.Name = "dgvDepartamento";
            this.dgvDepartamento.RowHeadersWidth = 51;
            this.dgvDepartamento.RowTemplate.Height = 24;
            this.dgvDepartamento.Size = new System.Drawing.Size(795, 786);
            this.dgvDepartamento.TabIndex = 1;
            this.dgvDepartamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartamento_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(794, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "LISTADO DEPARTAMENTOS";
            // 
            // btnAgregarDepto
            // 
            this.btnAgregarDepto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarDepto.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAgregarDepto.FlatAppearance.BorderSize = 0;
            this.btnAgregarDepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDepto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarDepto.Location = new System.Drawing.Point(393, 769);
            this.btnAgregarDepto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarDepto.Name = "btnAgregarDepto";
            this.btnAgregarDepto.Size = new System.Drawing.Size(131, 56);
            this.btnAgregarDepto.TabIndex = 4;
            this.btnAgregarDepto.Text = "AGREGAR";
            this.btnAgregarDepto.UseVisualStyleBackColor = false;
            this.btnAgregarDepto.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtBuscarDepto
            // 
            this.txtBuscarDepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarDepto.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarDepto.Location = new System.Drawing.Point(692, 118);
            this.txtBuscarDepto.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarDepto.Name = "txtBuscarDepto";
            this.txtBuscarDepto.Size = new System.Drawing.Size(174, 30);
            this.txtBuscarDepto.TabIndex = 5;
            this.txtBuscarDepto.Text = "ESCRIBE AQUI";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(544, 111);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(131, 44);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminarDepto
            // 
            this.btnEliminarDepto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarDepto.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarDepto.FlatAppearance.BorderSize = 0;
            this.btnEliminarDepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDepto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarDepto.Location = new System.Drawing.Point(101, 769);
            this.btnEliminarDepto.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarDepto.Name = "btnEliminarDepto";
            this.btnEliminarDepto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEliminarDepto.Size = new System.Drawing.Size(131, 56);
            this.btnEliminarDepto.TabIndex = 8;
            this.btnEliminarDepto.Text = "ELIMINAR";
            this.btnEliminarDepto.UseVisualStyleBackColor = false;
            this.btnEliminarDepto.Click += new System.EventHandler(this.btnEliminarDepto_Click);
            // 
            // cbxDisponibilidad
            // 
            this.cbxDisponibilidad.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDisponibilidad.FormattingEnabled = true;
            this.cbxDisponibilidad.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbxDisponibilidad.Location = new System.Drawing.Point(207, 333);
            this.cbxDisponibilidad.Margin = new System.Windows.Forms.Padding(2);
            this.cbxDisponibilidad.Name = "cbxDisponibilidad";
            this.cbxDisponibilidad.Size = new System.Drawing.Size(149, 33);
            this.cbxDisponibilidad.TabIndex = 72;
            // 
            // cbxTelevision
            // 
            this.cbxTelevision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTelevision.FormattingEnabled = true;
            this.cbxTelevision.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbxTelevision.Location = new System.Drawing.Point(31, 201);
            this.cbxTelevision.Margin = new System.Windows.Forms.Padding(2);
            this.cbxTelevision.Name = "cbxTelevision";
            this.cbxTelevision.Size = new System.Drawing.Size(148, 33);
            this.cbxTelevision.TabIndex = 71;
            // 
            // cbxAmoblado
            // 
            this.cbxAmoblado.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAmoblado.FormattingEnabled = true;
            this.cbxAmoblado.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbxAmoblado.Location = new System.Drawing.Point(212, 134);
            this.cbxAmoblado.Margin = new System.Windows.Forms.Padding(2);
            this.cbxAmoblado.Name = "cbxAmoblado";
            this.cbxAmoblado.Size = new System.Drawing.Size(144, 33);
            this.cbxAmoblado.TabIndex = 70;
            // 
            // cbxInternet
            // 
            this.cbxInternet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxInternet.FormattingEnabled = true;
            this.cbxInternet.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbxInternet.Location = new System.Drawing.Point(32, 134);
            this.cbxInternet.Margin = new System.Windows.Forms.Padding(2);
            this.cbxInternet.Name = "cbxInternet";
            this.cbxInternet.Size = new System.Drawing.Size(147, 33);
            this.cbxInternet.TabIndex = 69;
            // 
            // cbxCalefaccion
            // 
            this.cbxCalefaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCalefaccion.FormattingEnabled = true;
            this.cbxCalefaccion.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbxCalefaccion.Location = new System.Drawing.Point(211, 201);
            this.cbxCalefaccion.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCalefaccion.Name = "cbxCalefaccion";
            this.cbxCalefaccion.Size = new System.Drawing.Size(145, 33);
            this.cbxCalefaccion.TabIndex = 68;
            // 
            // cbxBanio
            // 
            this.cbxBanio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBanio.FormattingEnabled = true;
            this.cbxBanio.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbxBanio.Location = new System.Drawing.Point(31, 266);
            this.cbxBanio.Margin = new System.Windows.Forms.Padding(2);
            this.cbxBanio.Name = "cbxBanio";
            this.cbxBanio.Size = new System.Drawing.Size(148, 33);
            this.cbxBanio.TabIndex = 67;
            // 
            // cbxHabitacion
            // 
            this.cbxHabitacion.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxHabitacion.FormattingEnabled = true;
            this.cbxHabitacion.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxHabitacion.Location = new System.Drawing.Point(210, 267);
            this.cbxHabitacion.Margin = new System.Windows.Forms.Padding(2);
            this.cbxHabitacion.Name = "cbxHabitacion";
            this.cbxHabitacion.Size = new System.Drawing.Size(146, 33);
            this.cbxHabitacion.TabIndex = 66;
            // 
            // txtValor
            // 
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(367, 580);
            this.txtValor.Margin = new System.Windows.Forms.Padding(2);
            this.txtValor.MaxLength = 20;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(146, 23);
            this.txtValor.TabIndex = 65;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // txtdireccion
            // 
            this.txtdireccion.BackColor = System.Drawing.Color.Gainsboro;
            this.txtdireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdireccion.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.Location = new System.Drawing.Point(366, 514);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtdireccion.MaxLength = 30;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(146, 23);
            this.txtdireccion.TabIndex = 64;
            this.txtdireccion.Leave += new System.EventHandler(this.txtdireccion_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(363, 484);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 17);
            this.label14.TabIndex = 63;
            this.label14.Text = "DIRECCIÓN";
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(31, 420);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(325, 183);
            this.txtDesc.TabIndex = 62;
            this.txtDesc.Leave += new System.EventHandler(this.txtDesc_Leave);
            // 
            // txtNomdepto
            // 
            this.txtNomdepto.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNomdepto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomdepto.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomdepto.Location = new System.Drawing.Point(366, 450);
            this.txtNomdepto.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomdepto.MaxLength = 30;
            this.txtNomdepto.Name = "txtNomdepto";
            this.txtNomdepto.Size = new System.Drawing.Size(147, 23);
            this.txtNomdepto.TabIndex = 61;
            this.txtNomdepto.Leave += new System.EventHandler(this.txtNomdepto_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(205, 307);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 17);
            this.label13.TabIndex = 59;
            this.label13.Text = "DISPONIBILIDAD";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(363, 551);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 17);
            this.label12.TabIndex = 58;
            this.label12.Text = "VALOR DIARIO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(29, 175);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 17);
            this.label11.TabIndex = 57;
            this.label11.Text = "TELEVISOR";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(209, 111);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 56;
            this.label10.Text = "AMOBLADO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(30, 111);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 55;
            this.label9.Text = "INTERNET";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(29, 243);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 54;
            this.label8.Text = "CANT. BAÑOS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(208, 177);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 53;
            this.label7.Text = "CALEFACCIÓN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(208, 243);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 17);
            this.label6.TabIndex = 52;
            this.label6.Text = "CANT. HABITACIONES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(29, 391);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "DESCRIPCIÓN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(363, 420);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "NOMBRE DEPTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(33, 307);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "COMUNA";
            // 
            // btnActualizarDepto
            // 
            this.btnActualizarDepto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnActualizarDepto.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnActualizarDepto.FlatAppearance.BorderSize = 0;
            this.btnActualizarDepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarDepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarDepto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualizarDepto.Location = new System.Drawing.Point(248, 769);
            this.btnActualizarDepto.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarDepto.Name = "btnActualizarDepto";
            this.btnActualizarDepto.Size = new System.Drawing.Size(131, 56);
            this.btnActualizarDepto.TabIndex = 73;
            this.btnActualizarDepto.Text = "ACTUALIZAR";
            this.btnActualizarDepto.UseVisualStyleBackColor = false;
            this.btnActualizarDepto.Click += new System.EventHandler(this.btnActualizarDepto_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnActualizar.BackColor = System.Drawing.SystemColors.Menu;
            this.btnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.BackgroundImage")));
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(12, 754);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnActualizar.Size = new System.Drawing.Size(87, 86);
            this.btnActualizar.TabIndex = 74;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cbxComuna
            // 
            this.cbxComuna.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxComuna.FormattingEnabled = true;
            this.cbxComuna.Location = new System.Drawing.Point(31, 333);
            this.cbxComuna.Margin = new System.Windows.Forms.Padding(2);
            this.cbxComuna.Name = "cbxComuna";
            this.cbxComuna.Size = new System.Drawing.Size(148, 33);
            this.cbxComuna.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(455, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(391, 38);
            this.label4.TabIndex = 77;
            this.label4.Text = "AGREGAR DEPARTAMENTO";
            // 
            // Mantendor_depto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1364, 986);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxComuna);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnActualizarDepto);
            this.Controls.Add(this.cbxDisponibilidad);
            this.Controls.Add(this.cbxTelevision);
            this.Controls.Add(this.cbxAmoblado);
            this.Controls.Add(this.cbxInternet);
            this.Controls.Add(this.cbxCalefaccion);
            this.Controls.Add(this.cbxBanio);
            this.Controls.Add(this.cbxHabitacion);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtNomdepto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminarDepto);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscarDepto);
            this.Controls.Add(this.btnAgregarDepto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDepartamento);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Mantendor_depto";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Mantendor_depto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDepartamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarDepto;
        private System.Windows.Forms.TextBox txtBuscarDepto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminarDepto;
        private System.Windows.Forms.ComboBox cbxDisponibilidad;
        private System.Windows.Forms.ComboBox cbxTelevision;
        private System.Windows.Forms.ComboBox cbxAmoblado;
        private System.Windows.Forms.ComboBox cbxInternet;
        private System.Windows.Forms.ComboBox cbxCalefaccion;
        private System.Windows.Forms.ComboBox cbxBanio;
        private System.Windows.Forms.ComboBox cbxHabitacion;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtNomdepto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnActualizarDepto;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ComboBox cbxComuna;
        private System.Windows.Forms.Label label4;
    }
}

