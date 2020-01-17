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
            this.Txt_Estado = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Nope = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.Dgv_Lista_Usuarios = new System.Windows.Forms.DataGridView();
            this.Btn_Desactivar = new System.Windows.Forms.Button();
            this.Btn_Activar = new System.Windows.Forms.Button();
            this.Btn_Modifcar = new System.Windows.Forms.Button();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Txt_Correo = new System.Windows.Forms.TextBox();
            this.Txt_ApellidoII = new System.Windows.Forms.TextBox();
            this.Txt_ApellidoI = new System.Windows.Forms.TextBox();
            this.Txt_NumeroIdentificacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Nope.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Lista_Usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_Estado
            // 
            this.Txt_Estado.Location = new System.Drawing.Point(631, 196);
            this.Txt_Estado.Name = "Txt_Estado";
            this.Txt_Estado.ReadOnly = true;
            this.Txt_Estado.Size = new System.Drawing.Size(170, 20);
            this.Txt_Estado.TabIndex = 303;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkGray;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(573, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(228, 46);
            this.button5.TabIndex = 282;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(579, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 302;
            this.label10.Text = "Estado :";
            // 
            // Nope
            // 
            this.Nope.BackColor = System.Drawing.SystemColors.Desktop;
            this.Nope.Controls.Add(this.button5);
            this.Nope.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Nope.Location = new System.Drawing.Point(0, 412);
            this.Nope.Name = "Nope";
            this.Nope.Size = new System.Drawing.Size(808, 62);
            this.Nope.TabIndex = 301;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(12, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 300;
            this.label9.Text = "Lista de usuarios";
            // 
            // Dgv_Lista_Usuarios
            // 
            this.Dgv_Lista_Usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dgv_Lista_Usuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv_Lista_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Lista_Usuarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Dgv_Lista_Usuarios.Location = new System.Drawing.Point(13, 255);
            this.Dgv_Lista_Usuarios.Name = "Dgv_Lista_Usuarios";
            this.Dgv_Lista_Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Lista_Usuarios.Size = new System.Drawing.Size(788, 150);
            this.Dgv_Lista_Usuarios.TabIndex = 299;
            this.Dgv_Lista_Usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Lista_Usuarios_CellClick);
            // 
            // Btn_Desactivar
            // 
            this.Btn_Desactivar.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Desactivar.FlatAppearance.BorderSize = 0;
            this.Btn_Desactivar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Desactivar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Desactivar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Desactivar.Location = new System.Drawing.Point(573, 144);
            this.Btn_Desactivar.Name = "Btn_Desactivar";
            this.Btn_Desactivar.Size = new System.Drawing.Size(228, 46);
            this.Btn_Desactivar.TabIndex = 298;
            this.Btn_Desactivar.Text = "Desactivar";
            this.Btn_Desactivar.UseVisualStyleBackColor = false;
            this.Btn_Desactivar.Click += new System.EventHandler(this.Btn_Desactivar_Click);
            // 
            // Btn_Activar
            // 
            this.Btn_Activar.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Activar.FlatAppearance.BorderSize = 0;
            this.Btn_Activar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Activar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Activar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Activar.Location = new System.Drawing.Point(339, 144);
            this.Btn_Activar.Name = "Btn_Activar";
            this.Btn_Activar.Size = new System.Drawing.Size(228, 46);
            this.Btn_Activar.TabIndex = 297;
            this.Btn_Activar.Text = "Activar";
            this.Btn_Activar.UseVisualStyleBackColor = false;
            this.Btn_Activar.Click += new System.EventHandler(this.Btn_Activar_Click);
            // 
            // Btn_Modifcar
            // 
            this.Btn_Modifcar.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Modifcar.FlatAppearance.BorderSize = 0;
            this.Btn_Modifcar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Modifcar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modifcar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Modifcar.Location = new System.Drawing.Point(573, 92);
            this.Btn_Modifcar.Name = "Btn_Modifcar";
            this.Btn_Modifcar.Size = new System.Drawing.Size(228, 46);
            this.Btn_Modifcar.TabIndex = 296;
            this.Btn_Modifcar.Text = "Modificar";
            this.Btn_Modifcar.UseVisualStyleBackColor = false;
            this.Btn_Modifcar.Click += new System.EventHandler(this.Btn_Modifcar_Click);
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Agregar.FlatAppearance.BorderSize = 0;
            this.Btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Agregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Agregar.Location = new System.Drawing.Point(339, 92);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(228, 46);
            this.Btn_Agregar.TabIndex = 295;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = false;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Txt_Correo
            // 
            this.Txt_Correo.Location = new System.Drawing.Point(137, 196);
            this.Txt_Correo.MaxLength = 50;
            this.Txt_Correo.Name = "Txt_Correo";
            this.Txt_Correo.Size = new System.Drawing.Size(170, 20);
            this.Txt_Correo.TabIndex = 294;
            // 
            // Txt_ApellidoII
            // 
            this.Txt_ApellidoII.Location = new System.Drawing.Point(137, 170);
            this.Txt_ApellidoII.MaxLength = 50;
            this.Txt_ApellidoII.Name = "Txt_ApellidoII";
            this.Txt_ApellidoII.Size = new System.Drawing.Size(170, 20);
            this.Txt_ApellidoII.TabIndex = 293;
            // 
            // Txt_ApellidoI
            // 
            this.Txt_ApellidoI.Location = new System.Drawing.Point(137, 144);
            this.Txt_ApellidoI.MaxLength = 50;
            this.Txt_ApellidoI.Name = "Txt_ApellidoI";
            this.Txt_ApellidoI.Size = new System.Drawing.Size(170, 20);
            this.Txt_ApellidoI.TabIndex = 292;
            // 
            // Txt_NumeroIdentificacion
            // 
            this.Txt_NumeroIdentificacion.Location = new System.Drawing.Point(137, 92);
            this.Txt_NumeroIdentificacion.MaxLength = 10;
            this.Txt_NumeroIdentificacion.Name = "Txt_NumeroIdentificacion";
            this.Txt_NumeroIdentificacion.Size = new System.Drawing.Size(170, 20);
            this.Txt_NumeroIdentificacion.TabIndex = 290;
            this.Txt_NumeroIdentificacion.TextChanged += new System.EventHandler(this.Txt_NumeroIdentificacion_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(10, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 289;
            this.label8.Text = "Correo :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(10, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 288;
            this.label7.Text = "Segundo Apellido :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(10, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 287;
            this.label6.Text = "Primer apellido :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(10, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 286;
            this.label5.Text = "Nombre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(10, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 285;
            this.label4.Text = "Identificación :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(689, 0);
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
            this.label3.Location = new System.Drawing.Point(388, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mantenimiento de usuarios";
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
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(137, 118);
            this.Txt_Nombre.MaxLength = 50;
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(170, 20);
            this.Txt_Nombre.TabIndex = 291;
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
            this.panel1.Size = new System.Drawing.Size(808, 86);
            this.panel1.TabIndex = 284;
            // 
            // Form_Mantenimiento_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(808, 474);
            this.Controls.Add(this.Txt_Estado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Nope);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Dgv_Lista_Usuarios);
            this.Controls.Add(this.Btn_Desactivar);
            this.Controls.Add(this.Btn_Activar);
            this.Controls.Add(this.Btn_Modifcar);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.Txt_Correo);
            this.Controls.Add(this.Txt_ApellidoII);
            this.Controls.Add(this.Txt_ApellidoI);
            this.Controls.Add(this.Txt_NumeroIdentificacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Mantenimiento_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Mantenimiento_Usuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Mantenimiento_Usuarios_FormClosing);
            this.Load += new System.EventHandler(this.Form_Mantenimiento_Usuarios_Load);
            this.Nope.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Lista_Usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Estado;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel Nope;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView Dgv_Lista_Usuarios;
        private System.Windows.Forms.Button Btn_Desactivar;
        private System.Windows.Forms.Button Btn_Activar;
        private System.Windows.Forms.Button Btn_Modifcar;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.TextBox Txt_Correo;
        private System.Windows.Forms.TextBox Txt_ApellidoII;
        private System.Windows.Forms.TextBox Txt_ApellidoI;
        private System.Windows.Forms.TextBox Txt_NumeroIdentificacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Panel panel1;
    }
}