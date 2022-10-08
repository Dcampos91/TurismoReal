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
            this.dgvDepartamento = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtBuscarDepto = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnEliminarDepto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDepartamento
            // 
            this.dgvDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartamento.Location = new System.Drawing.Point(13, 141);
            this.dgvDepartamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDepartamento.Name = "dgvDepartamento";
            this.dgvDepartamento.RowHeadersWidth = 51;
            this.dgvDepartamento.RowTemplate.Height = 24;
            this.dgvDepartamento.Size = new System.Drawing.Size(801, 299);
            this.dgvDepartamento.TabIndex = 1;
            this.dgvDepartamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartamento_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Listado Departamento";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(695, 473);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Agregar Depto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtBuscarDepto
            // 
            this.txtBuscarDepto.Location = new System.Drawing.Point(27, 100);
            this.txtBuscarDepto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarDepto.Name = "txtBuscarDepto";
            this.txtBuscarDepto.Size = new System.Drawing.Size(100, 22);
            this.txtBuscarDepto.TabIndex = 5;
            this.txtBuscarDepto.Text = "Buscar...";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(156, 100);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(13, 477);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(100, 28);
            this.btnAtras.TabIndex = 7;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminarDepto
            // 
            this.btnEliminarDepto.Location = new System.Drawing.Point(267, 100);
            this.btnEliminarDepto.Name = "btnEliminarDepto";
            this.btnEliminarDepto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEliminarDepto.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarDepto.TabIndex = 8;
            this.btnEliminarDepto.Text = "Eliminar";
            this.btnEliminarDepto.UseVisualStyleBackColor = true;
            this.btnEliminarDepto.Click += new System.EventHandler(this.btnEliminarDepto_Click);
            // 
            // Mantendor_depto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 518);
            this.Controls.Add(this.btnEliminarDepto);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscarDepto);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtBuscarDepto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnEliminarDepto;
    }
}

