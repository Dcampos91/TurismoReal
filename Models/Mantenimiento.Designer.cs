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
            System.Windows.Forms.MonthCalendar FechaSalida;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FechaIngreso = new System.Windows.Forms.MonthCalendar();
            this.txtDescripcionMtto = new System.Windows.Forms.TextBox();
            this.txtDisponible = new System.Windows.Forms.TextBox();
            this.dgvMTTO = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnModificarMtto = new System.Windows.Forms.Button();
            this.btnEliminarMtto = new System.Windows.Forms.Button();
            FechaSalida = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMTTO)).BeginInit();
            this.SuspendLayout();
            // 
            // FechaSalida
            // 
            FechaSalida.BackColor = System.Drawing.SystemColors.Window;
            FechaSalida.Cursor = System.Windows.Forms.Cursors.Hand;
            FechaSalida.Location = new System.Drawing.Point(27, 425);
            FechaSalida.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            FechaSalida.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            FechaSalida.Name = "FechaSalida";
            FechaSalida.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Ingreso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 399);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Salida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(360, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion Mantenimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(198, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Disponibilidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID Departamento ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(359, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(309, 36);
            this.label6.TabIndex = 5;
            this.label6.Text = "Crear Mantenimiento";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 80);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 23);
            this.textBox1.TabIndex = 6;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FechaIngreso.Location = new System.Drawing.Point(27, 164);
            this.FechaIngreso.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.FechaIngreso.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.TabIndex = 7;
            // 
            // txtDescripcionMtto
            // 
            this.txtDescripcionMtto.Location = new System.Drawing.Point(363, 80);
            this.txtDescripcionMtto.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcionMtto.Multiline = true;
            this.txtDescripcionMtto.Name = "txtDescripcionMtto";
            this.txtDescripcionMtto.Size = new System.Drawing.Size(338, 152);
            this.txtDescripcionMtto.TabIndex = 9;
            // 
            // txtDisponible
            // 
            this.txtDisponible.Location = new System.Drawing.Point(201, 80);
            this.txtDisponible.Margin = new System.Windows.Forms.Padding(2);
            this.txtDisponible.Name = "txtDisponible";
            this.txtDisponible.Size = new System.Drawing.Size(88, 23);
            this.txtDisponible.TabIndex = 10;
            // 
            // dgvMTTO
            // 
            this.dgvMTTO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMTTO.Location = new System.Drawing.Point(365, 300);
            this.dgvMTTO.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMTTO.Name = "dgvMTTO";
            this.dgvMTTO.RowHeadersWidth = 51;
            this.dgvMTTO.RowTemplate.Height = 24;
            this.dgvMTTO.Size = new System.Drawing.Size(545, 332);
            this.dgvMTTO.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(362, 281);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Listado Departamentos en MTTO";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(789, 80);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 71);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ingresar Orden de MTTO";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnModificarMtto
            // 
            this.btnModificarMtto.Location = new System.Drawing.Point(789, 164);
            this.btnModificarMtto.Name = "btnModificarMtto";
            this.btnModificarMtto.Size = new System.Drawing.Size(121, 23);
            this.btnModificarMtto.TabIndex = 15;
            this.btnModificarMtto.Text = "Modificar";
            this.btnModificarMtto.UseVisualStyleBackColor = true;
            // 
            // btnEliminarMtto
            // 
            this.btnEliminarMtto.Location = new System.Drawing.Point(789, 208);
            this.btnEliminarMtto.Name = "btnEliminarMtto";
            this.btnEliminarMtto.Size = new System.Drawing.Size(121, 23);
            this.btnEliminarMtto.TabIndex = 16;
            this.btnEliminarMtto.Text = "Eliminar";
            this.btnEliminarMtto.UseVisualStyleBackColor = true;
            // 
            // Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 692);
            this.Controls.Add(this.btnEliminarMtto);
            this.Controls.Add(this.btnModificarMtto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvMTTO);
            this.Controls.Add(this.txtDisponible);
            this.Controls.Add(this.txtDescripcionMtto);
            this.Controls.Add(FechaSalida);
            this.Controls.Add(this.FechaIngreso);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MonthCalendar FechaIngreso;
        private System.Windows.Forms.TextBox txtDescripcionMtto;
        private System.Windows.Forms.TextBox txtDisponible;
        private System.Windows.Forms.DataGridView dgvMTTO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnModificarMtto;
        private System.Windows.Forms.Button btnEliminarMtto;
    }
}