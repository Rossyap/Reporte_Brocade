namespace practica_conexion
{
    partial class RUCKUS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RUCKUS));
            this.TITULO = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.restaurar = new System.Windows.Forms.PictureBox();
            this.maximizar = new System.Windows.Forms.PictureBox();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.CERRAR = new System.Windows.Forms.PictureBox();
            this.MENU = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mostrar = new System.Windows.Forms.Panel();
            this.TITULO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CERRAR)).BeginInit();
            this.MENU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TITULO
            // 
            this.TITULO.AutoSize = true;
            this.TITULO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(168)))));
            this.TITULO.Controls.Add(this.pictureBox2);
            this.TITULO.Controls.Add(this.restaurar);
            this.TITULO.Controls.Add(this.maximizar);
            this.TITULO.Controls.Add(this.minimizar);
            this.TITULO.Controls.Add(this.CERRAR);
            this.TITULO.Dock = System.Windows.Forms.DockStyle.Top;
            this.TITULO.Location = new System.Drawing.Point(0, 0);
            this.TITULO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TITULO.Name = "TITULO";
            this.TITULO.Size = new System.Drawing.Size(1040, 32);
            this.TITULO.TabIndex = 10;
            this.TITULO.Paint += new System.Windows.Forms.PaintEventHandler(this.TITULO_Paint);
            this.TITULO.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TITULO_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(4, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 30);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // restaurar
            // 
            this.restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restaurar.Image = global::practica_conexion.Properties.Resources.restoration_window_3491;
            this.restaurar.Location = new System.Drawing.Point(980, 0);
            this.restaurar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.restaurar.Name = "restaurar";
            this.restaurar.Size = new System.Drawing.Size(26, 26);
            this.restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.restaurar.TabIndex = 2;
            this.restaurar.TabStop = false;
            this.restaurar.Visible = false;
            this.restaurar.Click += new System.EventHandler(this.restaurar_Click);
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizar.Image = global::practica_conexion.Properties.Resources.black_white_metro_maximize_window_icon;
            this.maximizar.Location = new System.Drawing.Point(980, 0);
            this.maximizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(26, 28);
            this.maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizar.TabIndex = 2;
            this.maximizar.TabStop = false;
            this.maximizar.Click += new System.EventHandler(this.maximizar_Click);
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizar.Image = global::practica_conexion.Properties.Resources.minimize_thewindow_theapplication_2872;
            this.minimizar.Location = new System.Drawing.Point(950, 2);
            this.minimizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(26, 26);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizar.TabIndex = 1;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // CERRAR
            // 
            this.CERRAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CERRAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CERRAR.Image = global::practica_conexion.Properties.Resources.close_27402_960_720;
            this.CERRAR.Location = new System.Drawing.Point(1011, 0);
            this.CERRAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CERRAR.Name = "CERRAR";
            this.CERRAR.Size = new System.Drawing.Size(26, 28);
            this.CERRAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CERRAR.TabIndex = 0;
            this.CERRAR.TabStop = false;
            this.CERRAR.Click += new System.EventHandler(this.CERRAR_Click);
            // 
            // MENU
            // 
            this.MENU.BackColor = System.Drawing.Color.White;
            this.MENU.Controls.Add(this.panel1);
            this.MENU.Controls.Add(this.button5);
            this.MENU.Controls.Add(this.panel5);
            this.MENU.Controls.Add(this.panel3);
            this.MENU.Controls.Add(this.panel4);
            this.MENU.Controls.Add(this.panel2);
            this.MENU.Controls.Add(this.button4);
            this.MENU.Controls.Add(this.button3);
            this.MENU.Controls.Add(this.button2);
            this.MENU.Controls.Add(this.button1);
            this.MENU.Controls.Add(this.pictureBox1);
            this.MENU.Dock = System.Windows.Forms.DockStyle.Left;
            this.MENU.Location = new System.Drawing.Point(0, 32);
            this.MENU.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MENU.Name = "MENU";
            this.MENU.Size = new System.Drawing.Size(214, 564);
            this.MENU.TabIndex = 11;
            this.MENU.Paint += new System.Windows.Forms.PaintEventHandler(this.MENU_Paint);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(168)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(168)))));
            this.panel1.Location = new System.Drawing.Point(-1, 422);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(14, 42);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(168)))));
            this.button5.Image = global::practica_conexion.Properties.Resources.USUARIO_opt;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(11, 422);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(202, 46);
            this.button5.TabIndex = 7;
            this.button5.Text = "ADD USER";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(168)))));
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(168)))));
            this.panel5.Location = new System.Drawing.Point(0, 355);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(14, 42);
            this.panel5.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(168)))));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(168)))));
            this.panel3.Location = new System.Drawing.Point(0, 276);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(14, 40);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(168)))));
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(168)))));
            this.panel4.Location = new System.Drawing.Point(0, 197);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 39);
            this.panel4.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(168)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(168)))));
            this.panel2.Location = new System.Drawing.Point(0, 125);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(15, 38);
            this.panel2.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(168)))));
            this.button4.Image = global::practica_conexion.Properties.Resources.inspection_opt;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(12, 197);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(201, 46);
            this.button4.TabIndex = 4;
            this.button4.Text = "COSMETICS";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(168)))));
            this.button3.Image = global::practica_conexion.Properties.Resources.transparenta_opt;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(12, 276);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "INSPECTION";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(168)))));
            this.button2.Image = global::practica_conexion.Properties.Resources.buscar__1__opt;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 355);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "SEARCH";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(168)))));
            this.button1.Image = global::practica_conexion.Properties.Resources.serviceicon_opt;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 125);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "REPAIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::practica_conexion.Properties.Resources._2000px_Foxconn_Logo_svg;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mostrar
            // 
            this.mostrar.AutoSize = true;
            this.mostrar.BackColor = System.Drawing.Color.Silver;
            this.mostrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mostrar.Location = new System.Drawing.Point(214, 32);
            this.mostrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(826, 564);
            this.mostrar.TabIndex = 12;
            this.mostrar.Paint += new System.Windows.Forms.PaintEventHandler(this.mostrar_Paint);
            // 
            // RUCKUS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1040, 596);
            this.Controls.Add(this.mostrar);
            this.Controls.Add(this.MENU);
            this.Controls.Add(this.TITULO);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RUCKUS";
            this.Text = "RUCKUS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.TITULO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CERRAR)).EndInit();
            this.MENU.ResumeLayout(false);
            this.MENU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TITULO;
        private System.Windows.Forms.PictureBox CERRAR;
        private System.Windows.Forms.Panel MENU;
        private System.Windows.Forms.Panel mostrar;
        private System.Windows.Forms.PictureBox maximizar;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox restaurar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
    }
}