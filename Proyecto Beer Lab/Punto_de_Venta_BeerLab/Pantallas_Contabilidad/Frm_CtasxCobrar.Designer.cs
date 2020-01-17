namespace Punto_de_Venta_BeerLab.UI
{
    partial class Frm_CtasxCobrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CtasxCobrar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Txt_NumeroFactura = new System.Windows.Forms.TextBox();
            this.Btn_GenerarReporte = new System.Windows.Forms.Button();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Dgv_CuentaCobrar = new System.Windows.Forms.DataGridView();
            this.Lbl_FechaCierre = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CuentaCobrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 87);
            this.panel1.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 257;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(511, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 25);
            this.label3.TabIndex = 259;
            this.label3.Text = "Pantalla de Cuentas por Cobrar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(1, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 258;
            this.label2.Text = "label2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Controls.Add(this.Txt_NumeroFactura);
            this.panel2.Controls.Add(this.Btn_GenerarReporte);
            this.panel2.Controls.Add(this.Btn_Actualizar);
            this.panel2.Controls.Add(this.Btn_Buscar);
            this.panel2.Controls.Add(this.Btn_Salir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 319);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(837, 37);
            this.panel2.TabIndex = 54;
            // 
            // Txt_NumeroFactura
            // 
            this.Txt_NumeroFactura.Location = new System.Drawing.Point(153, 7);
            this.Txt_NumeroFactura.Name = "Txt_NumeroFactura";
            this.Txt_NumeroFactura.Size = new System.Drawing.Size(274, 20);
            this.Txt_NumeroFactura.TabIndex = 265;
            // 
            // Btn_GenerarReporte
            // 
            this.Btn_GenerarReporte.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_GenerarReporte.Enabled = false;
            this.Btn_GenerarReporte.FlatAppearance.BorderSize = 0;
            this.Btn_GenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_GenerarReporte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GenerarReporte.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_GenerarReporte.Location = new System.Drawing.Point(562, 7);
            this.Btn_GenerarReporte.Name = "Btn_GenerarReporte";
            this.Btn_GenerarReporte.Size = new System.Drawing.Size(155, 23);
            this.Btn_GenerarReporte.TabIndex = 264;
            this.Btn_GenerarReporte.Text = "Generar Reporte";
            this.Btn_GenerarReporte.UseVisualStyleBackColor = false;
            this.Btn_GenerarReporte.Click += new System.EventHandler(this.Btn_GenerarReporte_Click);
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Actualizar.FlatAppearance.BorderSize = 0;
            this.Btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Actualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Actualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Actualizar.Location = new System.Drawing.Point(431, 7);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(126, 23);
            this.Btn_Actualizar.TabIndex = 263;
            this.Btn_Actualizar.Text = "Actualizar";
            this.Btn_Actualizar.UseVisualStyleBackColor = false;
            this.Btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Buscar.FlatAppearance.BorderSize = 0;
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Buscar.Location = new System.Drawing.Point(7, 7);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(141, 23);
            this.Btn_Buscar.TabIndex = 262;
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
            this.Btn_Salir.Location = new System.Drawing.Point(723, 7);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(107, 23);
            this.Btn_Salir.TabIndex = 261;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Dgv_CuentaCobrar
            // 
            this.Dgv_CuentaCobrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_CuentaCobrar.Location = new System.Drawing.Point(12, 120);
            this.Dgv_CuentaCobrar.Name = "Dgv_CuentaCobrar";
            this.Dgv_CuentaCobrar.RowHeadersWidth = 62;
            this.Dgv_CuentaCobrar.Size = new System.Drawing.Size(813, 193);
            this.Dgv_CuentaCobrar.TabIndex = 260;
            // 
            // Lbl_FechaCierre
            // 
            this.Lbl_FechaCierre.AutoSize = true;
            this.Lbl_FechaCierre.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl_FechaCierre.Location = new System.Drawing.Point(638, 99);
            this.Lbl_FechaCierre.Name = "Lbl_FechaCierre";
            this.Lbl_FechaCierre.Size = new System.Drawing.Size(87, 13);
            this.Lbl_FechaCierre.TabIndex = 261;
            this.Lbl_FechaCierre.Text = "Fecha del Cierre:";
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl_Fecha.Location = new System.Drawing.Point(731, 99);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Fecha.TabIndex = 262;
            this.Lbl_Fecha.Text = "label4";
            // 
            // Frm_CtasxCobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(837, 356);
            this.Controls.Add(this.Lbl_Fecha);
            this.Controls.Add(this.Lbl_FechaCierre);
            this.Controls.Add(this.Dgv_CuentaCobrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_CtasxCobrar";
            this.Text = "Pantalla de Cuentas por Cobrar";
            this.Load += new System.EventHandler(this.Frm_CtasxCobrar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CuentaCobrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView Dgv_CuentaCobrar;
        private System.Windows.Forms.TextBox Txt_NumeroFactura;
        private System.Windows.Forms.Button Btn_GenerarReporte;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Label Lbl_FechaCierre;
        private System.Windows.Forms.Label Lbl_Fecha;
    }
}