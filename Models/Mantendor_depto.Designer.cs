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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDepartamento
            // 
            this.dgvDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartamento.Location = new System.Drawing.Point(12, 337);
            this.dgvDepartamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDepartamento.Name = "dgvDepartamento";
            this.dgvDepartamento.RowHeadersWidth = 51;
            this.dgvDepartamento.RowTemplate.Height = 24;
            this.dgvDepartamento.Size = new System.Drawing.Size(1102, 366);
            this.dgvDepartamento.TabIndex = 1;
            this.dgvDepartamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartamento_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Listado Departamento";
            // 
            // btnAgregarDepto
            // 
            this.btnAgregarDepto.Location = new System.Drawing.Point(958, 116);
            this.btnAgregarDepto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarDepto.Name = "btnAgregarDepto";
            this.btnAgregarDepto.Size = new System.Drawing.Size(119, 32);
            this.btnAgregarDepto.TabIndex = 4;
            this.btnAgregarDepto.Text = "Agregar Depto";
            this.btnAgregarDepto.UseVisualStyleBackColor = true;
            this.btnAgregarDepto.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtBuscarDepto
            // 
            this.txtBuscarDepto.Location = new System.Drawing.Point(911, 38);
            this.txtBuscarDepto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarDepto.Name = "txtBuscarDepto";
            this.txtBuscarDepto.Size = new System.Drawing.Size(100, 22);
            this.txtBuscarDepto.TabIndex = 5;
            this.txtBuscarDepto.Text = "Buscar...";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(1030, 38);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminarDepto
            // 
            this.btnEliminarDepto.Location = new System.Drawing.Point(958, 224);
            this.btnEliminarDepto.Name = "btnEliminarDepto";
            this.btnEliminarDepto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEliminarDepto.Size = new System.Drawing.Size(119, 31);
            this.btnEliminarDepto.TabIndex = 8;
            this.btnEliminarDepto.Text = "Eliminar";
            this.btnEliminarDepto.UseVisualStyleBackColor = true;
            this.btnEliminarDepto.Click += new System.EventHandler(this.btnEliminarDepto_Click);
            // 
            // cbxDisponibilidad
            // 
            this.cbxDisponibilidad.FormattingEnabled = true;
            this.cbxDisponibilidad.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbxDisponibilidad.Location = new System.Drawing.Point(368, 233);
            this.cbxDisponibilidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxDisponibilidad.Name = "cbxDisponibilidad";
            this.cbxDisponibilidad.Size = new System.Drawing.Size(121, 24);
            this.cbxDisponibilidad.TabIndex = 72;
            // 
            // cbxTelevision
            // 
            this.cbxTelevision.FormattingEnabled = true;
            this.cbxTelevision.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbxTelevision.Location = new System.Drawing.Point(192, 233);
            this.cbxTelevision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxTelevision.Name = "cbxTelevision";
            this.cbxTelevision.Size = new System.Drawing.Size(121, 24);
            this.cbxTelevision.TabIndex = 71;
            // 
            // cbxAmoblado
            // 
            this.cbxAmoblado.FormattingEnabled = true;
            this.cbxAmoblado.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbxAmoblado.Location = new System.Drawing.Point(36, 233);
            this.cbxAmoblado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxAmoblado.Name = "cbxAmoblado";
            this.cbxAmoblado.Size = new System.Drawing.Size(121, 24);
            this.cbxAmoblado.TabIndex = 70;
            // 
            // cbxInternet
            // 
            this.cbxInternet.FormattingEnabled = true;
            this.cbxInternet.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbxInternet.Location = new System.Drawing.Point(523, 156);
            this.cbxInternet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxInternet.Name = "cbxInternet";
            this.cbxInternet.Size = new System.Drawing.Size(121, 24);
            this.cbxInternet.TabIndex = 69;
            // 
            // cbxCalefaccion
            // 
            this.cbxCalefaccion.FormattingEnabled = true;
            this.cbxCalefaccion.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbxCalefaccion.Location = new System.Drawing.Point(368, 156);
            this.cbxCalefaccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxCalefaccion.Name = "cbxCalefaccion";
            this.cbxCalefaccion.Size = new System.Drawing.Size(121, 24);
            this.cbxCalefaccion.TabIndex = 68;
            // 
            // cbxBanio
            // 
            this.cbxBanio.FormattingEnabled = true;
            this.cbxBanio.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbxBanio.Location = new System.Drawing.Point(192, 156);
            this.cbxBanio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxBanio.Name = "cbxBanio";
            this.cbxBanio.Size = new System.Drawing.Size(121, 24);
            this.cbxBanio.TabIndex = 67;
            // 
            // cbxHabitacion
            // 
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
            this.cbxHabitacion.Location = new System.Drawing.Point(36, 156);
            this.cbxHabitacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxHabitacion.Name = "cbxHabitacion";
            this.cbxHabitacion.Size = new System.Drawing.Size(121, 24);
            this.cbxHabitacion.TabIndex = 66;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(523, 233);
            this.txtValor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 22);
            this.txtValor.TabIndex = 65;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(484, 86);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(100, 22);
            this.txtdireccion.TabIndex = 64;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(483, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 17);
            this.label14.TabIndex = 63;
            this.label14.Text = "Dirección";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(664, 98);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(210, 159);
            this.txtDesc.TabIndex = 62;
            // 
            // txtNomdepto
            // 
            this.txtNomdepto.Location = new System.Drawing.Point(230, 85);
            this.txtNomdepto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomdepto.Name = "txtNomdepto";
            this.txtNomdepto.Size = new System.Drawing.Size(168, 22);
            this.txtNomdepto.TabIndex = 61;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(365, 204);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 17);
            this.label13.TabIndex = 59;
            this.label13.Text = "Disponibilidad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(520, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 17);
            this.label12.TabIndex = 58;
            this.label12.Text = "Valor Diario";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(189, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 57;
            this.label11.Text = "Television";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 56;
            this.label10.Text = "Amoblado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(520, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 55;
            this.label9.Text = "Internet";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(189, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 54;
            this.label8.Text = "Baño";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(365, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 53;
            this.label7.Text = "Calefacción";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 52;
            this.label6.Text = "Habitaciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(661, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Nombre Departamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "Comuna";
            // 
            // btnActualizarDepto
            // 
            this.btnActualizarDepto.Location = new System.Drawing.Point(958, 170);
            this.btnActualizarDepto.Name = "btnActualizarDepto";
            this.btnActualizarDepto.Size = new System.Drawing.Size(119, 33);
            this.btnActualizarDepto.TabIndex = 73;
            this.btnActualizarDepto.Text = "Actualizar";
            this.btnActualizarDepto.UseVisualStyleBackColor = true;
            this.btnActualizarDepto.Click += new System.EventHandler(this.btnActualizarDepto_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.Menu;
            this.btnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.BackgroundImage")));
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Location = new System.Drawing.Point(12, 282);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnActualizar.Size = new System.Drawing.Size(52, 50);
            this.btnActualizar.TabIndex = 74;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cbxComuna
            // 
            this.cbxComuna.FormattingEnabled = true;
            this.cbxComuna.Location = new System.Drawing.Point(36, 85);
            this.cbxComuna.Name = "cbxComuna";
            this.cbxComuna.Size = new System.Drawing.Size(168, 24);
            this.cbxComuna.TabIndex = 76;
            // 
            // Mantendor_depto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 714);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Mantendor_depto";
            this.Text = "Mantenedor Departamento";
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
    }
}

