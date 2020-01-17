namespace Punto_de_Venta_BeerLab.UI
{
    partial class Form_Pagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Pagar));
            this.Txt_Monto_Pagar = new System.Windows.Forms.TextBox();
            this.Txt_Monto_Cliente = new System.Windows.Forms.TextBox();
            this.Txt_Vuelto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Pagar = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_Monto_Pagar
            // 
            this.Txt_Monto_Pagar.Location = new System.Drawing.Point(201, 31);
            this.Txt_Monto_Pagar.Name = "Txt_Monto_Pagar";
            this.Txt_Monto_Pagar.Size = new System.Drawing.Size(305, 20);
            this.Txt_Monto_Pagar.TabIndex = 0;
            // 
            // Txt_Monto_Cliente
            // 
            this.Txt_Monto_Cliente.Location = new System.Drawing.Point(201, 73);
            this.Txt_Monto_Cliente.Name = "Txt_Monto_Cliente";
            this.Txt_Monto_Cliente.Size = new System.Drawing.Size(305, 20);
            this.Txt_Monto_Cliente.TabIndex = 1;
            this.Txt_Monto_Cliente.TextChanged += new System.EventHandler(this.Txt_Monto_Cliente_TextChanged);
            this.Txt_Monto_Cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersAllowed_KeyPress);
            // 
            // Txt_Vuelto
            // 
            this.Txt_Vuelto.Location = new System.Drawing.Point(201, 115);
            this.Txt_Vuelto.Name = "Txt_Vuelto";
            this.Txt_Vuelto.Size = new System.Drawing.Size(305, 20);
            this.Txt_Vuelto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(79, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Monto a pagar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(21, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Monto con el que paga :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(135, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vuelto :";
            // 
            // Btn_Pagar
            // 
            this.Btn_Pagar.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Pagar.FlatAppearance.BorderSize = 0;
            this.Btn_Pagar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Pagar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Pagar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Pagar.Location = new System.Drawing.Point(12, 158);
            this.Btn_Pagar.Name = "Btn_Pagar";
            this.Btn_Pagar.Size = new System.Drawing.Size(244, 46);
            this.Btn_Pagar.TabIndex = 42;
            this.Btn_Pagar.Text = "Pagar";
            this.Btn_Pagar.UseVisualStyleBackColor = false;
            this.Btn_Pagar.Click += new System.EventHandler(this.Btn_Pagar_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Salir.FlatAppearance.BorderSize = 0;
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Salir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Salir.Location = new System.Drawing.Point(262, 158);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(244, 46);
            this.Btn_Salir.TabIndex = 43;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Form_Pagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(518, 216);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Pagar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Vuelto);
            this.Controls.Add(this.Txt_Monto_Cliente);
            this.Controls.Add(this.Txt_Monto_Pagar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Pagar";
            this.Text = "Pantalla de Pago con Efectivo";
            this.Load += new System.EventHandler(this.Form_Pagar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Monto_Pagar;
        private System.Windows.Forms.TextBox Txt_Monto_Cliente;
        private System.Windows.Forms.TextBox Txt_Vuelto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Pagar;
        private System.Windows.Forms.Button Btn_Salir;
    }
}