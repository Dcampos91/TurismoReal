namespace Turismo.Models
{
    partial class ListarReserva
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReserva = new System.Windows.Forms.DataGridView();
            this.btnInforme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(491, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTADO DE RESERVAS";
            // 
            // dgvReserva
            // 
            this.dgvReserva.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvReserva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReserva.Location = new System.Drawing.Point(127, 105);
            this.dgvReserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvReserva.Name = "dgvReserva";
            this.dgvReserva.RowHeadersWidth = 51;
            this.dgvReserva.RowTemplate.Height = 24;
            this.dgvReserva.Size = new System.Drawing.Size(1027, 439);
            this.dgvReserva.TabIndex = 1;
            // 
            // btnInforme
            // 
            this.btnInforme.Location = new System.Drawing.Point(1016, 563);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(138, 28);
            this.btnInforme.TabIndex = 2;
            this.btnInforme.Text = "Generar Informe";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // ListarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 754);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.dgvReserva);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListarReserva";
            this.Text = "ListarReserva";
            this.Load += new System.EventHandler(this.ListarReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReserva;
        private System.Windows.Forms.Button btnInforme;
    }
}