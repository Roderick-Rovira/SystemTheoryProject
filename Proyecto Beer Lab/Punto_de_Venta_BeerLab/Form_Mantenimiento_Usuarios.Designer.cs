namespace Punto_de_Venta_BeerLab.UI
{
    partial class Form_Mantenimiento_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Mantenimiento_Usuarios));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Consultar = new System.Windows.Forms.Button();
            this.Lb_NumeroIdentificacion = new System.Windows.Forms.Label();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Lbl_Apellido1 = new System.Windows.Forms.Label();
            this.Lbl_Apellido2 = new System.Windows.Forms.Label();
            this.Txt_NumeroIdentificacion = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_ApellidoI = new System.Windows.Forms.TextBox();
            this.Txt_ApellidoII = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Tbl_ListaUsuarios = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_ConfirmarContrasenna = new System.Windows.Forms.TextBox();
            this.Lbl_Contraseñña = new System.Windows.Forms.Label();
            this.Btn_CrearContrasenna = new System.Windows.Forms.Button();
            this.Txt_Contrasenna = new System.Windows.Forms.TextBox();
            this.Lbl_Constrasenna = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_ListaUsuarios)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lb_NumeroIdentificacion);
            this.groupBox1.Controls.Add(this.Lbl_Nombre);
            this.groupBox1.Controls.Add(this.Lbl_Apellido1);
            this.groupBox1.Controls.Add(this.Lbl_Apellido2);
            this.groupBox1.Controls.Add(this.Txt_NumeroIdentificacion);
            this.groupBox1.Controls.Add(this.Txt_Nombre);
            this.groupBox1.Controls.Add(this.Txt_ApellidoI);
            this.groupBox1.Controls.Add(this.Txt_ApellidoII);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(9, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(424, 155);
            this.groupBox1.TabIndex = 295;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Usuario";
            // 
            // Btn_Consultar
            // 
            this.Btn_Consultar.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Consultar.FlatAppearance.BorderSize = 0;
            this.Btn_Consultar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Consultar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Btn_Consultar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Consultar.Location = new System.Drawing.Point(28, 219);
            this.Btn_Consultar.Name = "Btn_Consultar";
            this.Btn_Consultar.Size = new System.Drawing.Size(400, 21);
            this.Btn_Consultar.TabIndex = 285;
            this.Btn_Consultar.Text = "Consultar";
            this.Btn_Consultar.UseVisualStyleBackColor = false;
            // 
            // Lb_NumeroIdentificacion
            // 
            this.Lb_NumeroIdentificacion.AutoSize = true;
            this.Lb_NumeroIdentificacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lb_NumeroIdentificacion.Location = new System.Drawing.Point(16, 24);
            this.Lb_NumeroIdentificacion.Name = "Lb_NumeroIdentificacion";
            this.Lb_NumeroIdentificacion.Size = new System.Drawing.Size(76, 13);
            this.Lb_NumeroIdentificacion.TabIndex = 254;
            this.Lb_NumeroIdentificacion.Text = "Identificación :";
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Nombre.Location = new System.Drawing.Point(16, 50);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(50, 13);
            this.Lbl_Nombre.TabIndex = 255;
            this.Lbl_Nombre.Text = "Nombre :";
            // 
            // Lbl_Apellido1
            // 
            this.Lbl_Apellido1.AutoSize = true;
            this.Lbl_Apellido1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Apellido1.Location = new System.Drawing.Point(16, 76);
            this.Lbl_Apellido1.Name = "Lbl_Apellido1";
            this.Lbl_Apellido1.Size = new System.Drawing.Size(81, 13);
            this.Lbl_Apellido1.TabIndex = 256;
            this.Lbl_Apellido1.Text = "Primer apellido :";
            // 
            // Lbl_Apellido2
            // 
            this.Lbl_Apellido2.AutoSize = true;
            this.Lbl_Apellido2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Apellido2.Location = new System.Drawing.Point(16, 102);
            this.Lbl_Apellido2.Name = "Lbl_Apellido2";
            this.Lbl_Apellido2.Size = new System.Drawing.Size(96, 13);
            this.Lbl_Apellido2.TabIndex = 257;
            this.Lbl_Apellido2.Text = "Segundo Apellido :";
            // 
            // Txt_NumeroIdentificacion
            // 
            this.Txt_NumeroIdentificacion.Location = new System.Drawing.Point(142, 18);
            this.Txt_NumeroIdentificacion.Name = "Txt_NumeroIdentificacion";
            this.Txt_NumeroIdentificacion.Size = new System.Drawing.Size(277, 20);
            this.Txt_NumeroIdentificacion.TabIndex = 259;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(142, 44);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(277, 20);
            this.Txt_Nombre.TabIndex = 260;
            // 
            // Txt_ApellidoI
            // 
            this.Txt_ApellidoI.Location = new System.Drawing.Point(142, 70);
            this.Txt_ApellidoI.Name = "Txt_ApellidoI";
            this.Txt_ApellidoI.Size = new System.Drawing.Size(277, 20);
            this.Txt_ApellidoI.TabIndex = 261;
            // 
            // Txt_ApellidoII
            // 
            this.Txt_ApellidoII.Location = new System.Drawing.Point(142, 96);
            this.Txt_ApellidoII.Name = "Txt_ApellidoII";
            this.Txt_ApellidoII.Size = new System.Drawing.Size(277, 20);
            this.Txt_ApellidoII.TabIndex = 262;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Controls.Add(this.button5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 391);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(809, 56);
            this.panel2.TabIndex = 294;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkGray;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(571, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(228, 46);
            this.button5.TabIndex = 282;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Tbl_ListaUsuarios);
            this.groupBox3.ForeColor = System.Drawing.Color.Snow;
            this.groupBox3.Location = new System.Drawing.Point(11, 250);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(790, 139);
            this.groupBox3.TabIndex = 297;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de Usuarios";
            // 
            // Tbl_ListaUsuarios
            // 
            this.Tbl_ListaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Tbl_ListaUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Tbl_ListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tbl_ListaUsuarios.Location = new System.Drawing.Point(18, 18);
            this.Tbl_ListaUsuarios.Name = "Tbl_ListaUsuarios";
            this.Tbl_ListaUsuarios.RowHeadersWidth = 51;
            this.Tbl_ListaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tbl_ListaUsuarios.Size = new System.Drawing.Size(754, 104);
            this.Tbl_ListaUsuarios.TabIndex = 279;
            this.Tbl_ListaUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Txt_ConfirmarContrasenna);
            this.groupBox2.Controls.Add(this.Lbl_Contraseñña);
            this.groupBox2.Controls.Add(this.Btn_CrearContrasenna);
            this.groupBox2.Controls.Add(this.Txt_Contrasenna);
            this.groupBox2.Controls.Add(this.Lbl_Constrasenna);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(437, 91);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(363, 154);
            this.groupBox2.TabIndex = 296;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crear Contraseña";
            // 
            // Txt_ConfirmarContrasenna
            // 
            this.Txt_ConfirmarContrasenna.Location = new System.Drawing.Point(148, 68);
            this.Txt_ConfirmarContrasenna.Name = "Txt_ConfirmarContrasenna";
            this.Txt_ConfirmarContrasenna.Size = new System.Drawing.Size(170, 20);
            this.Txt_ConfirmarContrasenna.TabIndex = 267;
            // 
            // Lbl_Contraseñña
            // 
            this.Lbl_Contraseñña.AutoSize = true;
            this.Lbl_Contraseñña.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Contraseñña.Location = new System.Drawing.Point(16, 71);
            this.Lbl_Contraseñña.Name = "Lbl_Contraseñña";
            this.Lbl_Contraseñña.Size = new System.Drawing.Size(114, 13);
            this.Lbl_Contraseñña.TabIndex = 266;
            this.Lbl_Contraseñña.Text = "Confirmar Contraseña :";
            // 
            // Btn_CrearContrasenna
            // 
            this.Btn_CrearContrasenna.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_CrearContrasenna.FlatAppearance.BorderSize = 0;
            this.Btn_CrearContrasenna.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_CrearContrasenna.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CrearContrasenna.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_CrearContrasenna.Location = new System.Drawing.Point(19, 107);
            this.Btn_CrearContrasenna.Name = "Btn_CrearContrasenna";
            this.Btn_CrearContrasenna.Size = new System.Drawing.Size(299, 24);
            this.Btn_CrearContrasenna.TabIndex = 276;
            this.Btn_CrearContrasenna.Text = "Crear Contraseña";
            this.Btn_CrearContrasenna.UseVisualStyleBackColor = false;
            // 
            // Txt_Contrasenna
            // 
            this.Txt_Contrasenna.Location = new System.Drawing.Point(148, 28);
            this.Txt_Contrasenna.Name = "Txt_Contrasenna";
            this.Txt_Contrasenna.ReadOnly = true;
            this.Txt_Contrasenna.Size = new System.Drawing.Size(170, 20);
            this.Txt_Contrasenna.TabIndex = 283;
            // 
            // Lbl_Constrasenna
            // 
            this.Lbl_Constrasenna.AutoSize = true;
            this.Lbl_Constrasenna.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Constrasenna.Location = new System.Drawing.Point(16, 32);
            this.Lbl_Constrasenna.Name = "Lbl_Constrasenna";
            this.Lbl_Constrasenna.Size = new System.Drawing.Size(67, 13);
            this.Lbl_Constrasenna.TabIndex = 264;
            this.Lbl_Constrasenna.Text = "Contraseña :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 86);
            this.panel1.TabIndex = 293;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(662, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(583, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Form_Mantenimiento_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(809, 447);
            this.Controls.Add(this.Btn_Consultar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Mantenimiento_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Mantenimiento_Usuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Mantenimiento_Usuarios_FormClosing);
            this.Load += new System.EventHandler(this.Form_Mantenimiento_Usuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_ListaUsuarios)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Consultar;
        private System.Windows.Forms.Label Lb_NumeroIdentificacion;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.Label Lbl_Apellido1;
        private System.Windows.Forms.Label Lbl_Apellido2;
        private System.Windows.Forms.TextBox Txt_NumeroIdentificacion;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox Txt_ApellidoI;
        private System.Windows.Forms.TextBox Txt_ApellidoII;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView Tbl_ListaUsuarios;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txt_ConfirmarContrasenna;
        private System.Windows.Forms.Label Lbl_Contraseñña;
        private System.Windows.Forms.Button Btn_CrearContrasenna;
        private System.Windows.Forms.TextBox Txt_Contrasenna;
        private System.Windows.Forms.Label Lbl_Constrasenna;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}