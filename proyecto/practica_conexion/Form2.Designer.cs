namespace practica_conexion
{
    partial class Usuarios
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
            this.nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tipo = new System.Windows.Forms.Label();
            this.tipo_usuario = new System.Windows.Forms.ComboBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnvisualizar = new System.Windows.Forms.Button();
            this.btnregresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(157, 105);
            this.nombre.Margin = new System.Windows.Forms.Padding(2);
            this.nombre.Multiline = true;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(300, 22);
            this.nombre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(43, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOMBRE";
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(157, 165);
            this.usuario.Margin = new System.Windows.Forms.Padding(2);
            this.usuario.Multiline = true;
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(300, 22);
            this.usuario.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(41, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "USUARIO";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(157, 210);
            this.password.Margin = new System.Windows.Forms.Padding(2);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(300, 22);
            this.password.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(41, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "PASSWORD";
            // 
            // tipo
            // 
            this.tipo.AutoSize = true;
            this.tipo.BackColor = System.Drawing.Color.Transparent;
            this.tipo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo.ForeColor = System.Drawing.Color.Black;
            this.tipo.Location = new System.Drawing.Point(43, 265);
            this.tipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(46, 19);
            this.tipo.TabIndex = 8;
            this.tipo.Text = "TIPO";
            // 
            // tipo_usuario
            // 
            this.tipo_usuario.FormattingEnabled = true;
            this.tipo_usuario.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "USUARIO"});
            this.tipo_usuario.Location = new System.Drawing.Point(157, 263);
            this.tipo_usuario.Margin = new System.Windows.Forms.Padding(2);
            this.tipo_usuario.Name = "tipo_usuario";
            this.tipo_usuario.Size = new System.Drawing.Size(176, 21);
            this.tipo_usuario.TabIndex = 9;
            // 
            // btnagregar
            // 
            this.btnagregar.AutoSize = true;
            this.btnagregar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnagregar.Image = global::practica_conexion.Properties.Resources.Crystal_Clear_device_3floppy_mount_opt;
            this.btnagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnagregar.Location = new System.Drawing.Point(29, 433);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(153, 46);
            this.btnagregar.TabIndex = 28;
            this.btnagregar.Text = "SAVE";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click_1);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MediumBlue;
            this.button1.Image = global::practica_conexion.Properties.Resources.Crystal_Clear_app_download_manager_opt;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(217, 433);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 46);
            this.button1.TabIndex = 29;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(489, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(456, 269);
            this.dataGridView1.TabIndex = 30;
            // 
            // btnvisualizar
            // 
            this.btnvisualizar.AutoSize = true;
            this.btnvisualizar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnvisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvisualizar.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnvisualizar.Image = global::practica_conexion.Properties.Resources.Crystal_Clear_app_download_manager_opt;
            this.btnvisualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvisualizar.Location = new System.Drawing.Point(412, 433);
            this.btnvisualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnvisualizar.Name = "btnvisualizar";
            this.btnvisualizar.Size = new System.Drawing.Size(193, 46);
            this.btnvisualizar.TabIndex = 31;
            this.btnvisualizar.Text = "VER REGISTROS";
            this.btnvisualizar.UseVisualStyleBackColor = false;
            this.btnvisualizar.Click += new System.EventHandler(this.btnvisualizar_Click_1);
            // 
            // btnregresar
            // 
            this.btnregresar.AutoSize = true;
            this.btnregresar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnregresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregresar.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnregresar.Image = global::practica_conexion.Properties.Resources.Crystal_Clear_app_download_manager_opt;
            this.btnregresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnregresar.Location = new System.Drawing.Point(636, 433);
            this.btnregresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(170, 46);
            this.btnregresar.TabIndex = 32;
            this.btnregresar.Text = "REGRESAR";
            this.btnregresar.UseVisualStyleBackColor = false;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click_1);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(987, 568);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.btnvisualizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.tipo_usuario);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Usuarios";
            this.Text = "REG_USUARIOS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tipo;
        private System.Windows.Forms.ComboBox tipo_usuario;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnvisualizar;
        private System.Windows.Forms.Button btnregresar;
    }
}