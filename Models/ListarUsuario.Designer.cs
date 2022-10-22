namespace Turismo.Models
{
    partial class ListarUsuario
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
            this.dgvListarUsuario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListarUsuario
            // 
            this.dgvListarUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarUsuario.Location = new System.Drawing.Point(27, 115);
            this.dgvListarUsuario.Name = "dgvListarUsuario";
            this.dgvListarUsuario.RowHeadersWidth = 51;
            this.dgvListarUsuario.RowTemplate.Height = 24;
            this.dgvListarUsuario.Size = new System.Drawing.Size(761, 378);
            this.dgvListarUsuario.TabIndex = 0;
            this.dgvListarUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarUsuario_CellContentClick);
            // 
            // ListarUsuario
            // 
            this.ClientSize = new System.Drawing.Size(828, 515);
            this.Controls.Add(this.dgvListarUsuario);
            this.Name = "ListarUsuario";
            this.Load += new System.EventHandler(this.ListarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListarUsuario;
       
    }
}