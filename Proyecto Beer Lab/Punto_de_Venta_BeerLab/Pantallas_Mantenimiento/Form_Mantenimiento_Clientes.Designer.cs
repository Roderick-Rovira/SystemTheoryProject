namespace Punto_de_Venta_BeerLab.UI
{
    partial class Form_Mantenimiento_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Mantenimiento_Clientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_Tipo_Identificacion = new System.Windows.Forms.ComboBox();
            this.Dtp_FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.Txt_Correo = new System.Windows.Forms.TextBox();
            this.Txt_Apellido_II = new System.Windows.Forms.TextBox();
            this.Txt_Apellido_I = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_Num_Identificacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Btn_Desactivar = new System.Windows.Forms.Button();
            this.Btn_Activar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Dgv_Lista_Clientes = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Txt_Telefono = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.Txt_Estado = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Lista_Clientes)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(938, 86);
            this.panel1.TabIndex = 253;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(832, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 253;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(563, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mantenimiento de clientes";
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
            // Cmb_Tipo_Identificacion
            // 
            this.Cmb_Tipo_Identificacion.FormattingEnabled = true;
            this.Cmb_Tipo_Identificacion.Items.AddRange(new object[] {
            "Cédula",
            "DIMEX",
            "Pasaporte"});
            this.Cmb_Tipo_Identificacion.Location = new System.Drawing.Point(158, 101);
            this.Cmb_Tipo_Identificacion.Name = "Cmb_Tipo_Identificacion";
            this.Cmb_Tipo_Identificacion.Size = new System.Drawing.Size(270, 21);
            this.Cmb_Tipo_Identificacion.TabIndex = 311;
            // 
            // Dtp_FechaNacimiento
            // 
            this.Dtp_FechaNacimiento.Location = new System.Drawing.Point(654, 116);
            this.Dtp_FechaNacimiento.Name = "Dtp_FechaNacimiento";
            this.Dtp_FechaNacimiento.Size = new System.Drawing.Size(270, 20);
            this.Dtp_FechaNacimiento.TabIndex = 310;
            // 
            // Txt_Correo
            // 
            this.Txt_Correo.Location = new System.Drawing.Point(654, 142);
            this.Txt_Correo.Name = "Txt_Correo";
            this.Txt_Correo.Size = new System.Drawing.Size(270, 20);
            this.Txt_Correo.TabIndex = 309;
            // 
            // Txt_Apellido_II
            // 
            this.Txt_Apellido_II.Location = new System.Drawing.Point(654, 90);
            this.Txt_Apellido_II.Name = "Txt_Apellido_II";
            this.Txt_Apellido_II.Size = new System.Drawing.Size(270, 20);
            this.Txt_Apellido_II.TabIndex = 308;
            this.Txt_Apellido_II.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLettersAllowed_KeyPress);
            // 
            // Txt_Apellido_I
            // 
            this.Txt_Apellido_I.Location = new System.Drawing.Point(158, 180);
            this.Txt_Apellido_I.Name = "Txt_Apellido_I";
            this.Txt_Apellido_I.Size = new System.Drawing.Size(270, 20);
            this.Txt_Apellido_I.TabIndex = 307;
            this.Txt_Apellido_I.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLettersAllowed_KeyPress);
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(158, 154);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(270, 20);
            this.Txt_Nombre.TabIndex = 306;
            this.Txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLettersAllowed_KeyPress);
            // 
            // Txt_Num_Identificacion
            // 
            this.Txt_Num_Identificacion.Location = new System.Drawing.Point(158, 128);
            this.Txt_Num_Identificacion.Name = "Txt_Num_Identificacion";
            this.Txt_Num_Identificacion.Size = new System.Drawing.Size(270, 20);
            this.Txt_Num_Identificacion.TabIndex = 305;
            this.Txt_Num_Identificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersAllow_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(29, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 312;
            this.label4.Text = "Tipo de identificación:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(22, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 313;
            this.label5.Text = "Número de identificación:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(26, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 314;
            this.label6.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(22, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 315;
            this.label7.Text = "Primer apellido:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(538, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 316;
            this.label8.Text = "Segundo apellido:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(538, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 317;
            this.label9.Text = "Correo electrónico:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(538, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 318;
            this.label10.Text = "Fecha de nacimiento:";
            // 
            // Btn_Desactivar
            // 
            this.Btn_Desactivar.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Desactivar.FlatAppearance.BorderSize = 0;
            this.Btn_Desactivar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Desactivar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Desactivar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Desactivar.Location = new System.Drawing.Point(811, 220);
            this.Btn_Desactivar.Name = "Btn_Desactivar";
            this.Btn_Desactivar.Size = new System.Drawing.Size(113, 23);
            this.Btn_Desactivar.TabIndex = 322;
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
            this.Btn_Activar.Location = new System.Drawing.Point(654, 220);
            this.Btn_Activar.Name = "Btn_Activar";
            this.Btn_Activar.Size = new System.Drawing.Size(113, 23);
            this.Btn_Activar.TabIndex = 321;
            this.Btn_Activar.Text = "Activar";
            this.Btn_Activar.UseVisualStyleBackColor = false;
            this.Btn_Activar.Click += new System.EventHandler(this.Btn_Activar_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Modificar.FlatAppearance.BorderSize = 0;
            this.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Modificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Modificar.Location = new System.Drawing.Point(324, 10);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(294, 46);
            this.Btn_Modificar.TabIndex = 320;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Agregar.FlatAppearance.BorderSize = 0;
            this.Btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Agregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Agregar.Location = new System.Drawing.Point(24, 10);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(294, 46);
            this.Btn_Agregar.TabIndex = 319;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = false;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Dgv_Lista_Clientes
            // 
            this.Dgv_Lista_Clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dgv_Lista_Clientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Lista_Clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Lista_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Lista_Clientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Dgv_Lista_Clientes.Location = new System.Drawing.Point(25, 249);
            this.Dgv_Lista_Clientes.Name = "Dgv_Lista_Clientes";
            this.Dgv_Lista_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Lista_Clientes.Size = new System.Drawing.Size(899, 125);
            this.Dgv_Lista_Clientes.TabIndex = 323;
            this.Dgv_Lista_Clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Lista_Clientes_CellClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(26, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 324;
            this.label11.Text = "Lista de clientes:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(538, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 326;
            this.label12.Text = "Teléfono:";
            // 
            // Txt_Telefono
            // 
            this.Txt_Telefono.Location = new System.Drawing.Point(654, 168);
            this.Txt_Telefono.Name = "Txt_Telefono";
            this.Txt_Telefono.Size = new System.Drawing.Size(270, 20);
            this.Txt_Telefono.TabIndex = 325;
            this.Txt_Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersAllow_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.Btn_Agregar);
            this.panel2.Controls.Add(this.Btn_Modificar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 379);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(938, 68);
            this.panel2.TabIndex = 328;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkGray;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(796, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 46);
            this.button5.TabIndex = 323;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Txt_Estado
            // 
            this.Txt_Estado.Location = new System.Drawing.Point(654, 194);
            this.Txt_Estado.Name = "Txt_Estado";
            this.Txt_Estado.Size = new System.Drawing.Size(270, 20);
            this.Txt_Estado.TabIndex = 329;
            this.Txt_Estado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLettersAllowed_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(591, 197);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 330;
            this.label13.Text = "Estado:";
            // 
            // Form_Mantenimiento_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(938, 447);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Txt_Estado);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Btn_Desactivar);
            this.Controls.Add(this.Btn_Activar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Txt_Telefono);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Dgv_Lista_Clientes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cmb_Tipo_Identificacion);
            this.Controls.Add(this.Dtp_FechaNacimiento);
            this.Controls.Add(this.Txt_Correo);
            this.Controls.Add(this.Txt_Apellido_II);
            this.Controls.Add(this.Txt_Apellido_I);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.Txt_Num_Identificacion);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Mantenimiento_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Mantenimiento_Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Mantenimiento_Clientes_FormClosing);
            this.Load += new System.EventHandler(this.Form_Mantenimiento_Clientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Lista_Clientes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cmb_Tipo_Identificacion;
        private System.Windows.Forms.DateTimePicker Dtp_FechaNacimiento;
        private System.Windows.Forms.TextBox Txt_Correo;
        private System.Windows.Forms.TextBox Txt_Apellido_II;
        private System.Windows.Forms.TextBox Txt_Apellido_I;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox Txt_Num_Identificacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Btn_Desactivar;
        private System.Windows.Forms.Button Btn_Activar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.DataGridView Dgv_Lista_Clientes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Txt_Telefono;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox Txt_Estado;
        private System.Windows.Forms.Label label13;
    }
}