namespace Turismo.Models
{
    partial class Mantenimiento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenimiento));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FechaIngreso = new System.Windows.Forms.MonthCalendar();
            this.txtDescripcionMtto = new System.Windows.Forms.TextBox();
            this.dgvMTTO = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregarMTTO = new System.Windows.Forms.Button();
            this.btnModificarMtto = new System.Windows.Forms.Button();
            this.btnEliminarMtto = new System.Windows.Forms.Button();
            this.FechaSalida = new System.Windows.Forms.MonthCalendar();
            this.cbxDepartamento = new System.Windows.Forms.ComboBox();
            this.cbxDisponibilidad = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMTTO)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 229);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "FECHA INGRESO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 495);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "FECHA SALIDA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(352, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "DESCRIPCION MANTENIMIENTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(194, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "DISPONIBILIDAD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID DEPARTAMENTO";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(426, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(356, 38);
            this.label6.TabIndex = 5;
            this.label6.Text = "CREAR MANTENIMIENTO";
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.BackColor = System.Drawing.Color.Gainsboro;
            this.FechaIngreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FechaIngreso.Location = new System.Drawing.Point(45, 261);
            this.FechaIngreso.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.FechaIngreso.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.FechaIngreso.MaxSelectionCount = 1;
            this.FechaIngreso.MinDate = new System.DateTime(2022, 12, 15, 12, 31, 19, 0);
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.TabIndex = 7;
            this.FechaIngreso.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(101)))));
            // 
            // txtDescripcionMtto
            // 
            this.txtDescripcionMtto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcionMtto.BackColor = System.Drawing.Color.White;
            this.txtDescripcionMtto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcionMtto.Location = new System.Drawing.Point(357, 177);
            this.txtDescripcionMtto.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcionMtto.Multiline = true;
            this.txtDescripcionMtto.Name = "txtDescripcionMtto";
            this.txtDescripcionMtto.Size = new System.Drawing.Size(823, 200);
            this.txtDescripcionMtto.TabIndex = 9;
            this.txtDescripcionMtto.Leave += new System.EventHandler(this.txtDescripcionMtto_Leave);
            // 
            // dgvMTTO
            // 
            this.dgvMTTO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMTTO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMTTO.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMTTO.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.dgvMTTO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMTTO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMTTO.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMTTO.EnableHeadersVisualStyles = false;
            this.dgvMTTO.Location = new System.Drawing.Point(357, 454);
            this.dgvMTTO.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMTTO.Name = "dgvMTTO";
            this.dgvMTTO.RowHeadersWidth = 51;
            this.dgvMTTO.RowTemplate.Height = 24;
            this.dgvMTTO.Size = new System.Drawing.Size(823, 476);
            this.dgvMTTO.TabIndex = 11;
            this.dgvMTTO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMTTO_CellContentClick);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(352, 425);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(304, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "LISTADO DE DEPARTAMENTOS EN MTTO";
            // 
            // btnAgregarMTTO
            // 
            this.btnAgregarMTTO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarMTTO.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAgregarMTTO.FlatAppearance.BorderSize = 0;
            this.btnAgregarMTTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMTTO.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMTTO.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarMTTO.Location = new System.Drawing.Point(1033, 95);
            this.btnAgregarMTTO.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarMTTO.Name = "btnAgregarMTTO";
            this.btnAgregarMTTO.Size = new System.Drawing.Size(147, 62);
            this.btnAgregarMTTO.TabIndex = 13;
            this.btnAgregarMTTO.Text = "INGRESAR ORDEN DE MTTO";
            this.btnAgregarMTTO.UseVisualStyleBackColor = false;
            this.btnAgregarMTTO.Click += new System.EventHandler(this.btnAgregarMTTO_Click);
            // 
            // btnModificarMtto
            // 
            this.btnModificarMtto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarMtto.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnModificarMtto.FlatAppearance.BorderSize = 0;
            this.btnModificarMtto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarMtto.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMtto.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnModificarMtto.Location = new System.Drawing.Point(1201, 148);
            this.btnModificarMtto.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarMtto.Name = "btnModificarMtto";
            this.btnModificarMtto.Size = new System.Drawing.Size(103, 64);
            this.btnModificarMtto.TabIndex = 15;
            this.btnModificarMtto.Text = "MODIFICAR";
            this.btnModificarMtto.UseVisualStyleBackColor = false;
            this.btnModificarMtto.Click += new System.EventHandler(this.btnModificarMtto_Click);
            // 
            // btnEliminarMtto
            // 
            this.btnEliminarMtto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarMtto.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarMtto.FlatAppearance.BorderSize = 0;
            this.btnEliminarMtto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMtto.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMtto.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEliminarMtto.Location = new System.Drawing.Point(1201, 310);
            this.btnEliminarMtto.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarMtto.Name = "btnEliminarMtto";
            this.btnEliminarMtto.Size = new System.Drawing.Size(103, 61);
            this.btnEliminarMtto.TabIndex = 16;
            this.btnEliminarMtto.Text = "ELIMINAR";
            this.btnEliminarMtto.UseVisualStyleBackColor = false;
            this.btnEliminarMtto.Click += new System.EventHandler(this.btnEliminarMtto_Click);
            // 
            // FechaSalida
            // 
            this.FechaSalida.Location = new System.Drawing.Point(45, 534);
            this.FechaSalida.Margin = new System.Windows.Forms.Padding(8);
            this.FechaSalida.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.FechaSalida.MaxSelectionCount = 1;
            this.FechaSalida.MinDate = new System.DateTime(2022, 12, 15, 12, 31, 23, 0);
            this.FechaSalida.Name = "FechaSalida";
            this.FechaSalida.TabIndex = 17;
            this.FechaSalida.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(101)))));
            // 
            // cbxDepartamento
            // 
            this.cbxDepartamento.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDepartamento.FormattingEnabled = true;
            this.cbxDepartamento.Location = new System.Drawing.Point(47, 177);
            this.cbxDepartamento.Margin = new System.Windows.Forms.Padding(2);
            this.cbxDepartamento.Name = "cbxDepartamento";
            this.cbxDepartamento.Size = new System.Drawing.Size(130, 33);
            this.cbxDepartamento.TabIndex = 18;
            // 
            // cbxDisponibilidad
            // 
            this.cbxDisponibilidad.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDisponibilidad.FormattingEnabled = true;
            this.cbxDisponibilidad.Items.AddRange(new object[] {
            "Habilitado",
            "Deshabilitado"});
            this.cbxDisponibilidad.Location = new System.Drawing.Point(197, 177);
            this.cbxDisponibilidad.Margin = new System.Windows.Forms.Padding(2);
            this.cbxDisponibilidad.Name = "cbxDisponibilidad";
            this.cbxDisponibilidad.Size = new System.Drawing.Size(138, 33);
            this.cbxDisponibilidad.TabIndex = 19;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBuscar.Location = new System.Drawing.Point(1201, 232);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(103, 60);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(997, 427);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(183, 23);
            this.txtBuscar.TabIndex = 21;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.BackColor = System.Drawing.SystemColors.Menu;
            this.btnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.BackgroundImage")));
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(1184, 876);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnActualizar.Size = new System.Drawing.Size(65, 66);
            this.btnActualizar.TabIndex = 76;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1364, 986);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbxDisponibilidad);
            this.Controls.Add(this.cbxDepartamento);
            this.Controls.Add(this.FechaSalida);
            this.Controls.Add(this.btnEliminarMtto);
            this.Controls.Add(this.btnModificarMtto);
            this.Controls.Add(this.btnAgregarMTTO);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvMTTO);
            this.Controls.Add(this.txtDescripcionMtto);
            this.Controls.Add(this.FechaIngreso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Mantenimiento";
            this.Text = "Mantenimiento";
            this.Load += new System.EventHandler(this.Mantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMTTO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MonthCalendar FechaIngreso;
        private System.Windows.Forms.TextBox txtDescripcionMtto;
        private System.Windows.Forms.DataGridView dgvMTTO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregarMTTO;
        private System.Windows.Forms.Button btnModificarMtto;
        private System.Windows.Forms.Button btnEliminarMtto;
        private System.Windows.Forms.MonthCalendar FechaSalida;
        private System.Windows.Forms.ComboBox cbxDepartamento;
        private System.Windows.Forms.ComboBox cbxDisponibilidad;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnActualizar;
    }
}