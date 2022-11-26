namespace Turismo.Models
{
    partial class FuncionarioPrincipal
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
            this.panelMenuFuncionario = new System.Windows.Forms.Panel();
            this.panelReservFuncionario = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.panelDeptoFuncionario = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelLogoFuncionario = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBarFuncionario = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelFuncionarioPrincipal = new System.Windows.Forms.Panel();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.FechaHora = new System.Windows.Forms.Timer(this.components);
            this.panelMenuFuncionario.SuspendLayout();
            this.panelDeptoFuncionario.SuspendLayout();
            this.panelLogoFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBarFuncionario.SuspendLayout();
            this.panelFuncionarioPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuFuncionario
            // 
            this.panelMenuFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.panelMenuFuncionario.Controls.Add(this.panelReservFuncionario);
            this.panelMenuFuncionario.Controls.Add(this.iconButton3);
            this.panelMenuFuncionario.Controls.Add(this.panelDeptoFuncionario);
            this.panelMenuFuncionario.Controls.Add(this.iconButton2);
            this.panelMenuFuncionario.Controls.Add(this.iconButton1);
            this.panelMenuFuncionario.Controls.Add(this.panelLogoFuncionario);
            this.panelMenuFuncionario.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuFuncionario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelMenuFuncionario.Location = new System.Drawing.Point(0, 0);
            this.panelMenuFuncionario.Name = "panelMenuFuncionario";
            this.panelMenuFuncionario.Size = new System.Drawing.Size(273, 813);
            this.panelMenuFuncionario.TabIndex = 0;
            // 
            // panelReservFuncionario
            // 
            this.panelReservFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(39)))));
            this.panelReservFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReservFuncionario.Location = new System.Drawing.Point(0, 399);
            this.panelReservFuncionario.Name = "panelReservFuncionario";
            this.panelReservFuncionario.Size = new System.Drawing.Size(273, 100);
            this.panelReservFuncionario.TabIndex = 5;
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 348);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton3.Size = new System.Drawing.Size(273, 51);
            this.iconButton3.TabIndex = 4;
            this.iconButton3.Text = "  Checklist";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // panelDeptoFuncionario
            // 
            this.panelDeptoFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(39)))));
            this.panelDeptoFuncionario.Controls.Add(this.button2);
            this.panelDeptoFuncionario.Controls.Add(this.button1);
            this.panelDeptoFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDeptoFuncionario.Location = new System.Drawing.Point(0, 228);
            this.panelDeptoFuncionario.Name = "panelDeptoFuncionario";
            this.panelDeptoFuncionario.Size = new System.Drawing.Size(273, 120);
            this.panelDeptoFuncionario.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(39)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Check-Out";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(39)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Check-In";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 177);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(273, 51);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.Text = "  Depto";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 126);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(273, 51);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "  Home";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // panelLogoFuncionario
            // 
            this.panelLogoFuncionario.Controls.Add(this.pictureBox1);
            this.panelLogoFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogoFuncionario.Location = new System.Drawing.Point(0, 0);
            this.panelLogoFuncionario.Name = "panelLogoFuncionario";
            this.panelLogoFuncionario.Size = new System.Drawing.Size(273, 126);
            this.panelLogoFuncionario.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Turismo.Properties.Resources.TurismoReal_removebg_preview__1_1;
            this.pictureBox1.Location = new System.Drawing.Point(92, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 92);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelBarFuncionario
            // 
            this.panelBarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(39)))));
            this.panelBarFuncionario.Controls.Add(this.label2);
            this.panelBarFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarFuncionario.Location = new System.Drawing.Point(273, 0);
            this.panelBarFuncionario.Name = "panelBarFuncionario";
            this.panelBarFuncionario.Size = new System.Drawing.Size(1309, 49);
            this.panelBarFuncionario.TabIndex = 1;
            this.panelBarFuncionario.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBarFuncionario_Paint);
            this.panelBarFuncionario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarFuncionario_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(464, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bienvenido Funcionario";
            // 
            // panelFuncionarioPrincipal
            // 
            this.panelFuncionarioPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelFuncionarioPrincipal.Controls.Add(this.lblfecha);
            this.panelFuncionarioPrincipal.Controls.Add(this.lblhora);
            this.panelFuncionarioPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFuncionarioPrincipal.Location = new System.Drawing.Point(273, 49);
            this.panelFuncionarioPrincipal.Name = "panelFuncionarioPrincipal";
            this.panelFuncionarioPrincipal.Size = new System.Drawing.Size(1309, 764);
            this.panelFuncionarioPrincipal.TabIndex = 2;
            this.panelFuncionarioPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFuncionarioPrincipal_Paint);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblfecha.Location = new System.Drawing.Point(474, 416);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(159, 58);
            this.lblfecha.TabIndex = 5;
            this.lblfecha.Text = "label1";
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblhora.Location = new System.Drawing.Point(516, 290);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(318, 113);
            this.lblhora.TabIndex = 4;
            this.lblhora.Text = "label1";
            // 
            // FechaHora
            // 
            this.FechaHora.Enabled = true;
            this.FechaHora.Tick += new System.EventHandler(this.FechaHora_Tick);
            // 
            // FuncionarioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 813);
            this.Controls.Add(this.panelFuncionarioPrincipal);
            this.Controls.Add(this.panelBarFuncionario);
            this.Controls.Add(this.panelMenuFuncionario);
            this.Name = "FuncionarioPrincipal";
            this.Text = "FuncionarioPrincipal";
            this.Load += new System.EventHandler(this.FuncionarioPrincipal_Load);
            this.Resize += new System.EventHandler(this.FuncionarioPrincipal_Resize);
            this.panelMenuFuncionario.ResumeLayout(false);
            this.panelDeptoFuncionario.ResumeLayout(false);
            this.panelLogoFuncionario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBarFuncionario.ResumeLayout(false);
            this.panelBarFuncionario.PerformLayout();
            this.panelFuncionarioPrincipal.ResumeLayout(false);
            this.panelFuncionarioPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuFuncionario;
        private System.Windows.Forms.Panel panelBarFuncionario;
        private System.Windows.Forms.Panel panelFuncionarioPrincipal;
        private System.Windows.Forms.Panel panelLogoFuncionario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panelDeptoFuncionario;
        private System.Windows.Forms.Button button1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Panel panelReservFuncionario;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Timer FechaHora;
        private System.Windows.Forms.Label label2;
    }
}