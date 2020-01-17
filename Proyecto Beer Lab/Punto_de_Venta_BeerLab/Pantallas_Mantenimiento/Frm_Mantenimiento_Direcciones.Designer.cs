namespace Punto_de_Venta_BeerLab.UI.Pantallas_Mantenimiento
{
    partial class Frm_Mantenimiento_Direcciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Mantenimiento_Direcciones));
            this.Lbl_ID_Cliente = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Txt_Numero_Identificacion = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Gpb_Lista = new System.Windows.Forms.GroupBox();
            this.Dgv_Lista_Direcciones = new System.Windows.Forms.DataGridView();
            this.Cmb_Distrito = new System.Windows.Forms.ComboBox();
            this.Cmb_Canton = new System.Windows.Forms.ComboBox();
            this.Cmb_Provincia = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Gpb_Lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Lista_Direcciones)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_ID_Cliente
            // 
            this.Lbl_ID_Cliente.AutoSize = true;
            this.Lbl_ID_Cliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_ID_Cliente.Location = new System.Drawing.Point(19, 99);
            this.Lbl_ID_Cliente.Name = "Lbl_ID_Cliente";
            this.Lbl_ID_Cliente.Size = new System.Drawing.Size(128, 13);
            this.Lbl_ID_Cliente.TabIndex = 288;
            this.Lbl_ID_Cliente.Text = "Número de Identificación:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Controls.Add(this.Btn_Buscar);
            this.panel2.Controls.Add(this.Btn_Salir);
            this.panel2.Controls.Add(this.Btn_Modificar);
            this.panel2.Controls.Add(this.Btn_Agregar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 389);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 68);
            this.panel2.TabIndex = 287;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Buscar.FlatAppearance.BorderSize = 0;
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Buscar.Location = new System.Drawing.Point(417, 10);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(178, 46);
            this.Btn_Buscar.TabIndex = 284;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Salir.FlatAppearance.BorderSize = 0;
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Salir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Salir.Location = new System.Drawing.Point(601, 10);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(187, 46);
            this.Btn_Salir.TabIndex = 283;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Modificar.FlatAppearance.BorderSize = 0;
            this.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Modificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Modificar.Location = new System.Drawing.Point(221, 10);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(190, 46);
            this.Btn_Modificar.TabIndex = 280;
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
            this.Btn_Agregar.Location = new System.Drawing.Point(15, 10);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(200, 46);
            this.Btn_Agregar.TabIndex = 279;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = false;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Txt_Numero_Identificacion
            // 
            this.Txt_Numero_Identificacion.Location = new System.Drawing.Point(184, 96);
            this.Txt_Numero_Identificacion.Name = "Txt_Numero_Identificacion";
            this.Txt_Numero_Identificacion.Size = new System.Drawing.Size(322, 20);
            this.Txt_Numero_Identificacion.TabIndex = 290;
            this.Txt_Numero_Identificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersAllowed_KeyPress);
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
            this.panel1.Size = new System.Drawing.Size(800, 86);
            this.panel1.TabIndex = 286;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(686, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 253;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(338, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mantenimiento direcciones Cliente";
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
            // Gpb_Lista
            // 
            this.Gpb_Lista.Controls.Add(this.Dgv_Lista_Direcciones);
            this.Gpb_Lista.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Gpb_Lista.Location = new System.Drawing.Point(15, 163);
            this.Gpb_Lista.Name = "Gpb_Lista";
            this.Gpb_Lista.Size = new System.Drawing.Size(773, 221);
            this.Gpb_Lista.TabIndex = 296;
            this.Gpb_Lista.TabStop = false;
            this.Gpb_Lista.Text = "Lista de Direcciones";
            // 
            // Dgv_Lista_Direcciones
            // 
            this.Dgv_Lista_Direcciones.AllowUserToAddRows = false;
            this.Dgv_Lista_Direcciones.AllowUserToDeleteRows = false;
            this.Dgv_Lista_Direcciones.AllowUserToResizeColumns = false;
            this.Dgv_Lista_Direcciones.AllowUserToResizeRows = false;
            this.Dgv_Lista_Direcciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dgv_Lista_Direcciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv_Lista_Direcciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Lista_Direcciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Dgv_Lista_Direcciones.Location = new System.Drawing.Point(7, 19);
            this.Dgv_Lista_Direcciones.Name = "Dgv_Lista_Direcciones";
            this.Dgv_Lista_Direcciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Lista_Direcciones.Size = new System.Drawing.Size(760, 196);
            this.Dgv_Lista_Direcciones.TabIndex = 324;
            this.Dgv_Lista_Direcciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Lista_Direcciones_CellClick);
            // 
            // Cmb_Distrito
            // 
            this.Cmb_Distrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Distrito.FormattingEnabled = true;
            this.Cmb_Distrito.Location = new System.Drawing.Point(559, 136);
            this.Cmb_Distrito.Name = "Cmb_Distrito";
            this.Cmb_Distrito.Size = new System.Drawing.Size(223, 21);
            this.Cmb_Distrito.TabIndex = 297;
            this.Cmb_Distrito.SelectedIndexChanged += new System.EventHandler(this.Cmb_Distrito_SelectedIndexChanged);
            // 
            // Cmb_Canton
            // 
            this.Cmb_Canton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Canton.FormattingEnabled = true;
            this.Cmb_Canton.Location = new System.Drawing.Point(281, 136);
            this.Cmb_Canton.Name = "Cmb_Canton";
            this.Cmb_Canton.Size = new System.Drawing.Size(225, 21);
            this.Cmb_Canton.TabIndex = 298;
            this.Cmb_Canton.SelectedIndexChanged += new System.EventHandler(this.Cmb_Canton_SelectedIndexChanged);
            // 
            // Cmb_Provincia
            // 
            this.Cmb_Provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Provincia.FormattingEnabled = true;
            this.Cmb_Provincia.Location = new System.Drawing.Point(75, 136);
            this.Cmb_Provincia.Name = "Cmb_Provincia";
            this.Cmb_Provincia.Size = new System.Drawing.Size(148, 21);
            this.Cmb_Provincia.TabIndex = 299;
            this.Cmb_Provincia.SelectedIndexChanged += new System.EventHandler(this.Cmb_Provincia_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(16, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 300;
            this.label4.Text = "Provincia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(512, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 301;
            this.label5.Text = "Distrito:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(231, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 302;
            this.label6.Text = "Cantón:";
            // 
            // Frm_Mantenimiento_Direcciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cmb_Provincia);
            this.Controls.Add(this.Cmb_Canton);
            this.Controls.Add(this.Cmb_Distrito);
            this.Controls.Add(this.Lbl_ID_Cliente);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Txt_Numero_Identificacion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Gpb_Lista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Mantenimiento_Direcciones";
            this.Text = "Frm_Mantenimiento_Direcciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Mantenimiento_Direcciones_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Mantenimiento_Direcciones_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Gpb_Lista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Lista_Direcciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_ID_Cliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.TextBox Txt_Numero_Identificacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Gpb_Lista;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.ComboBox Cmb_Distrito;
        private System.Windows.Forms.ComboBox Cmb_Canton;
        private System.Windows.Forms.ComboBox Cmb_Provincia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView Dgv_Lista_Direcciones;
    }
}