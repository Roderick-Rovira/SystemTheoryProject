namespace Punto_de_Venta_BeerLab.UI.Pantallas_Seguridad
{
    partial class Frm_PermisosXModulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PermisosXModulo));
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Dgv_ListaUsuarios = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_NombreUsuario = new System.Windows.Forms.TextBox();
            this.Txt_Identificiacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Cmb_Rol = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ListaUsuarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.Btn_Salir);
            this.panel2.Controls.Add(this.Btn_Guardar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 386);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(870, 64);
            this.panel2.TabIndex = 267;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Salir.FlatAppearance.BorderSize = 0;
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Salir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Salir.Location = new System.Drawing.Point(634, 6);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(228, 46);
            this.Btn_Salir.TabIndex = 248;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Guardar.FlatAppearance.BorderSize = 0;
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Guardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Guardar.Location = new System.Drawing.Point(6, 6);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(216, 46);
            this.Btn_Guardar.TabIndex = 265;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Dgv_ListaUsuarios
            // 
            this.Dgv_ListaUsuarios.AllowUserToAddRows = false;
            this.Dgv_ListaUsuarios.AllowUserToDeleteRows = false;
            this.Dgv_ListaUsuarios.AllowUserToResizeColumns = false;
            this.Dgv_ListaUsuarios.AllowUserToResizeRows = false;
            this.Dgv_ListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ListaUsuarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Dgv_ListaUsuarios.Location = new System.Drawing.Point(6, 171);
            this.Dgv_ListaUsuarios.Name = "Dgv_ListaUsuarios";
            this.Dgv_ListaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_ListaUsuarios.Size = new System.Drawing.Size(852, 209);
            this.Dgv_ListaUsuarios.TabIndex = 266;
            this.Dgv_ListaUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_ListaUsuarios_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(35, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 264;
            this.label4.Text = "Nombre de usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(9, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 263;
            this.label5.Text = "Identificación de usuario:";
            // 
            // Txt_NombreUsuario
            // 
            this.Txt_NombreUsuario.Location = new System.Drawing.Point(140, 145);
            this.Txt_NombreUsuario.Name = "Txt_NombreUsuario";
            this.Txt_NombreUsuario.Size = new System.Drawing.Size(170, 20);
            this.Txt_NombreUsuario.TabIndex = 262;
            // 
            // Txt_Identificiacion
            // 
            this.Txt_Identificiacion.Location = new System.Drawing.Point(140, 108);
            this.Txt_Identificiacion.Name = "Txt_Identificiacion";
            this.Txt_Identificiacion.Size = new System.Drawing.Size(170, 20);
            this.Txt_Identificiacion.TabIndex = 261;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(44, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 260;
            this.label6.Text = "Tipo de privilegio;";
            // 
            // Cmb_Rol
            // 
            this.Cmb_Rol.FormattingEnabled = true;
            this.Cmb_Rol.Items.AddRange(new object[] {
            "Administrador",
            "Contabilidad",
            "Inventario",
            "Vendedor",
            "Sin Privilegios"});
            this.Cmb_Rol.Location = new System.Drawing.Point(140, 71);
            this.Cmb_Rol.Name = "Cmb_Rol";
            this.Cmb_Rol.Size = new System.Drawing.Size(170, 21);
            this.Cmb_Rol.TabIndex = 259;
            this.Cmb_Rol.Text = "Seleccione un tipo de privilegio";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 64);
            this.panel1.TabIndex = 268;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(576, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Permisos por módulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(3, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Frm_PermisosXModulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Dgv_ListaUsuarios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_NombreUsuario);
            this.Controls.Add(this.Txt_Identificiacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Cmb_Rol);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_PermisosXModulo";
            this.Text = "Frm_PermisosXModulo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_PermisosXModulo_FormClosing);
            this.Load += new System.EventHandler(this.Frm_PermisosXModulo_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ListaUsuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.DataGridView Dgv_ListaUsuarios;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_NombreUsuario;
        private System.Windows.Forms.TextBox Txt_Identificiacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Cmb_Rol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}