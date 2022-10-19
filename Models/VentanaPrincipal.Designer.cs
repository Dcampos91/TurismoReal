namespace Turismo
{
    partial class VentanaPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnMinimizar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnMaximizar = new FontAwesome.Sharp.IconButton();
            this.LogoMenu = new System.Windows.Forms.Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton10 = new FontAwesome.Sharp.IconButton();
            this.PrincipalMenu = new System.Windows.Forms.Panel();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.PanelSubMenuCliente = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.PanelSubMenuDepa = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PanelTr = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.LogoMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.PrincipalMenu.SuspendLayout();
            this.PanelSubMenuCliente.SuspendLayout();
            this.PanelSubMenuDepa.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Principal";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BtnMinimizar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BtnMaximizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 49);
            this.panel1.TabIndex = 24;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnMinimizar.FlatAppearance.BorderSize = 0;
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.BtnMinimizar.IconColor = System.Drawing.Color.White;
            this.BtnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMinimizar.IconSize = 20;
            this.BtnMinimizar.Location = new System.Drawing.Point(1019, 0);
            this.BtnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(47, 31);
            this.BtnMinimizar.TabIndex = 5;
            this.BtnMinimizar.UseVisualStyleBackColor = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "BIENVENIDO/A";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximizar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnMaximizar.FlatAppearance.BorderSize = 0;
            this.BtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.BtnMaximizar.IconColor = System.Drawing.Color.White;
            this.BtnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMaximizar.IconSize = 20;
            this.BtnMaximizar.Location = new System.Drawing.Point(1065, 0);
            this.BtnMaximizar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(47, 31);
            this.BtnMaximizar.TabIndex = 3;
            this.BtnMaximizar.UseVisualStyleBackColor = false;
            this.BtnMaximizar.Click += new System.EventHandler(this.iconButton12_Click);
            // 
            // LogoMenu
            // 
            this.LogoMenu.Controls.Add(this.btnMenu);
            this.LogoMenu.Controls.Add(this.pictureBox12);
            this.LogoMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoMenu.Location = new System.Drawing.Point(0, 0);
            this.LogoMenu.Margin = new System.Windows.Forms.Padding(4);
            this.LogoMenu.Name = "LogoMenu";
            this.LogoMenu.Size = new System.Drawing.Size(200, 126);
            this.LogoMenu.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.DownLeftAndUpRightToCenter;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 30;
            this.btnMenu.Location = new System.Drawing.Point(137, 43);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(40, 37);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Tag = "menuButton";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::Turismo.Properties.Resources.TurismoReal_removebg_preview__1_1;
            this.pictureBox12.Location = new System.Drawing.Point(43, 20);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(64, 64);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox12.TabIndex = 0;
            this.pictureBox12.TabStop = false;
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 126);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(200, 47);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.Tag = "Home";
            this.iconButton2.Text = "  Home";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 173);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.iconButton3.Size = new System.Drawing.Size(200, 47);
            this.iconButton3.TabIndex = 2;
            this.iconButton3.Tag = "Departamento";
            this.iconButton3.Text = "  Departamento";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            this.iconButton3.MouseLeave += new System.EventHandler(this.iconButton3_MouseLeave);
            this.iconButton3.MouseHover += new System.EventHandler(this.iconButton3_MouseHover);
            // 
            // iconButton10
            // 
            this.iconButton10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton10.FlatAppearance.BorderSize = 0;
            this.iconButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton10.ForeColor = System.Drawing.Color.White;
            this.iconButton10.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.iconButton10.IconColor = System.Drawing.Color.White;
            this.iconButton10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton10.IconSize = 30;
            this.iconButton10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton10.Location = new System.Drawing.Point(0, 781);
            this.iconButton10.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton10.Name = "iconButton10";
            this.iconButton10.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.iconButton10.Size = new System.Drawing.Size(200, 47);
            this.iconButton10.TabIndex = 9;
            this.iconButton10.Tag = "Salir";
            this.iconButton10.Text = "  Cerrar sesión";
            this.iconButton10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton10.UseVisualStyleBackColor = true;
            this.iconButton10.Click += new System.EventHandler(this.iconButton10_Click_1);
            // 
            // PrincipalMenu
            // 
            this.PrincipalMenu.AutoScroll = true;
            this.PrincipalMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.PrincipalMenu.Controls.Add(this.iconButton7);
            this.PrincipalMenu.Controls.Add(this.iconButton6);
            this.PrincipalMenu.Controls.Add(this.iconButton5);
            this.PrincipalMenu.Controls.Add(this.iconButton4);
            this.PrincipalMenu.Controls.Add(this.PanelSubMenuCliente);
            this.PrincipalMenu.Controls.Add(this.iconButton1);
            this.PrincipalMenu.Controls.Add(this.PanelSubMenuDepa);
            this.PrincipalMenu.Controls.Add(this.iconButton10);
            this.PrincipalMenu.Controls.Add(this.iconButton3);
            this.PrincipalMenu.Controls.Add(this.iconButton2);
            this.PrincipalMenu.Controls.Add(this.LogoMenu);
            this.PrincipalMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PrincipalMenu.Location = new System.Drawing.Point(0, 0);
            this.PrincipalMenu.Margin = new System.Windows.Forms.Padding(4);
            this.PrincipalMenu.Name = "PrincipalMenu";
            this.PrincipalMenu.Size = new System.Drawing.Size(200, 828);
            this.PrincipalMenu.TabIndex = 23;
            this.PrincipalMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // iconButton7
            // 
            this.iconButton7.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.ForeColor = System.Drawing.Color.White;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.iconButton7.IconColor = System.Drawing.Color.White;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.IconSize = 30;
            this.iconButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.Location = new System.Drawing.Point(0, 714);
            this.iconButton7.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.iconButton7.Size = new System.Drawing.Size(200, 47);
            this.iconButton7.TabIndex = 16;
            this.iconButton7.Tag = "Informes";
            this.iconButton7.Text = "  Informes";
            this.iconButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton7.UseVisualStyleBackColor = true;
            // 
            // iconButton6
            // 
            this.iconButton6.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.ForeColor = System.Drawing.Color.White;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.StarOfLife;
            this.iconButton6.IconColor = System.Drawing.Color.White;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 30;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.Location = new System.Drawing.Point(0, 667);
            this.iconButton6.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.iconButton6.Size = new System.Drawing.Size(200, 47);
            this.iconButton6.TabIndex = 15;
            this.iconButton6.Tag = "Servicios";
            this.iconButton6.Text = "  Servicios";
            this.iconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton6.UseVisualStyleBackColor = true;
            // 
            // iconButton5
            // 
            this.iconButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.ForeColor = System.Drawing.Color.White;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            this.iconButton5.IconColor = System.Drawing.Color.White;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 30;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(0, 620);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.iconButton5.Size = new System.Drawing.Size(200, 47);
            this.iconButton5.TabIndex = 14;
            this.iconButton5.Tag = "Pagos";
            this.iconButton5.Text = "  Pagos";
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Bus;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 30;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(0, 573);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.iconButton4.Size = new System.Drawing.Size(200, 47);
            this.iconButton4.TabIndex = 13;
            this.iconButton4.Tag = "Transporte";
            this.iconButton4.Text = "  Transporte";
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // PanelSubMenuCliente
            // 
            this.PanelSubMenuCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(39)))));
            this.PanelSubMenuCliente.Controls.Add(this.button7);
            this.PanelSubMenuCliente.Controls.Add(this.button5);
            this.PanelSubMenuCliente.Controls.Add(this.button8);
            this.PanelSubMenuCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenuCliente.Location = new System.Drawing.Point(0, 459);
            this.PanelSubMenuCliente.Margin = new System.Windows.Forms.Padding(4);
            this.PanelSubMenuCliente.Name = "PanelSubMenuCliente";
            this.PanelSubMenuCliente.Size = new System.Drawing.Size(200, 114);
            this.PanelSubMenuCliente.TabIndex = 12;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(0, 66);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(43, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(200, 42);
            this.button7.TabIndex = 2;
            this.button7.Text = "Administrar Cliente";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 36);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(43, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(200, 30);
            this.button5.TabIndex = 1;
            this.button5.Text = "Autenticar";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(0, 0);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(43, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(200, 36);
            this.button8.TabIndex = 0;
            this.button8.Text = "Administrar Usuario";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 412);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(200, 47);
            this.iconButton1.TabIndex = 11;
            this.iconButton1.Tag = "Clientes";
            this.iconButton1.Text = "  Clientes";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // PanelSubMenuDepa
            // 
            this.PanelSubMenuDepa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(39)))));
            this.PanelSubMenuDepa.Controls.Add(this.button6);
            this.PanelSubMenuDepa.Controls.Add(this.button4);
            this.PanelSubMenuDepa.Controls.Add(this.button3);
            this.PanelSubMenuDepa.Controls.Add(this.button2);
            this.PanelSubMenuDepa.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenuDepa.Location = new System.Drawing.Point(0, 220);
            this.PanelSubMenuDepa.Margin = new System.Windows.Forms.Padding(4);
            this.PanelSubMenuDepa.Name = "PanelSubMenuDepa";
            this.PanelSubMenuDepa.Size = new System.Drawing.Size(200, 192);
            this.PanelSubMenuDepa.TabIndex = 10;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(0, 127);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(43, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(200, 37);
            this.button6.TabIndex = 4;
            this.button6.Text = "Disponibilidad";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 74);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(43, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(200, 53);
            this.button4.TabIndex = 3;
            this.button4.Text = "Administrar Departamento";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 37);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(43, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(200, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "Inventario";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(43, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(200, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Mantención";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // PanelTr
            // 
            this.PanelTr.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PanelTr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTr.Location = new System.Drawing.Point(200, 49);
            this.PanelTr.Margin = new System.Windows.Forms.Padding(4);
            this.PanelTr.Name = "PanelTr";
            this.PanelTr.Size = new System.Drawing.Size(1112, 779);
            this.PanelTr.TabIndex = 25;
            this.PanelTr.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelTr_Paint);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 828);
            this.Controls.Add(this.PanelTr);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrincipalMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaPrincipal";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.Resize += new System.EventHandler(this.VentanaPrincipal_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.LogoMenu.ResumeLayout(false);
            this.LogoMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.PrincipalMenu.ResumeLayout(false);
            this.PanelSubMenuCliente.ResumeLayout(false);
            this.PanelSubMenuDepa.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton BtnMaximizar;
        private FontAwesome.Sharp.IconButton BtnMinimizar;
        private System.Windows.Forms.Panel LogoMenu;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.PictureBox pictureBox12;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton10;
        private System.Windows.Forms.Panel PrincipalMenu;
        private System.Windows.Forms.Panel PanelTr;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Panel PanelSubMenuCliente;
        private System.Windows.Forms.Button button8;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel PanelSubMenuDepa;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}