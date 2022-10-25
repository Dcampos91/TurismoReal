namespace Turismo.Models
{
    partial class Reserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reserva));
            this.FechaIngreso = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaSalida = new System.Windows.Forms.MonthCalendar();
            this.txtCantidadDias = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxEstadoReserva = new System.Windows.Forms.ComboBox();
            this.FechaEstado = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxDepartamento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvReserva = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.Location = new System.Drawing.Point(18, 62);
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Ingreso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Salida";
            // 
            // FechaSalida
            // 
            this.FechaSalida.Location = new System.Drawing.Point(342, 62);
            this.FechaSalida.Name = "FechaSalida";
            this.FechaSalida.TabIndex = 4;
            // 
            // txtCantidadDias
            // 
            this.txtCantidadDias.Location = new System.Drawing.Point(18, 318);
            this.txtCantidadDias.Name = "txtCantidadDias";
            this.txtCantidadDias.Size = new System.Drawing.Size(111, 22);
            this.txtCantidadDias.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad de Dias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estado Reserva";
            // 
            // cbxEstadoReserva
            // 
            this.cbxEstadoReserva.FormattingEnabled = true;
            this.cbxEstadoReserva.Items.AddRange(new object[] {
            "Habilitado",
            "Deshabilitado"});
            this.cbxEstadoReserva.Location = new System.Drawing.Point(187, 315);
            this.cbxEstadoReserva.Name = "cbxEstadoReserva";
            this.cbxEstadoReserva.Size = new System.Drawing.Size(121, 24);
            this.cbxEstadoReserva.TabIndex = 8;
            // 
            // FechaEstado
            // 
            this.FechaEstado.Location = new System.Drawing.Point(342, 315);
            this.FechaEstado.Name = "FechaEstado";
            this.FechaEstado.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha Modificacion Estado";
            // 
            // cbxDepartamento
            // 
            this.cbxDepartamento.FormattingEnabled = true;
            this.cbxDepartamento.Location = new System.Drawing.Point(18, 387);
            this.cbxDepartamento.Name = "cbxDepartamento";
            this.cbxDepartamento.Size = new System.Drawing.Size(121, 24);
            this.cbxDepartamento.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Departamento";
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(187, 387);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(121, 24);
            this.cbxCliente.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(184, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cliente";
            // 
            // dgvReserva
            // 
            this.dgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReserva.Location = new System.Drawing.Point(660, 62);
            this.dgvReserva.Name = "dgvReserva";
            this.dgvReserva.RowHeadersWidth = 51;
            this.dgvReserva.RowTemplate.Height = 24;
            this.dgvReserva.Size = new System.Drawing.Size(558, 460);
            this.dgvReserva.TabIndex = 15;
            this.dgvReserva.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReserva_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(21, 456);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 28);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(130, 456);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(89, 28);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(237, 456);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(93, 28);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(1131, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(1008, 26);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 22);
            this.txtBuscar.TabIndex = 20;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.Menu;
            this.btnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.BackgroundImage")));
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(660, 26);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnActualizar.Size = new System.Drawing.Size(37, 35);
            this.btnActualizar.TabIndex = 75;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 560);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvReserva);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxDepartamento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FechaEstado);
            this.Controls.Add(this.cbxEstadoReserva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantidadDias);
            this.Controls.Add(this.FechaSalida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FechaIngreso);
            this.Name = "Reserva";
            this.Text = "Reserva";
            this.Load += new System.EventHandler(this.Reserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar FechaIngreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar FechaSalida;
        private System.Windows.Forms.TextBox txtCantidadDias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxEstadoReserva;
        private System.Windows.Forms.MonthCalendar FechaEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxDepartamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvReserva;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnActualizar;
    }
}