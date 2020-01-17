namespace Punto_de_Venta_BeerLab.UI
{
    partial class Frm_EnvioCorreo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EnvioCorreo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_AdjuntarArchivo = new System.Windows.Forms.Button();
            this.Btn_EnviarCorreo = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Txt_Receptor = new System.Windows.Forms.TextBox();
            this.Txt_Asunto = new System.Windows.Forms.TextBox();
            this.Txt_Emisor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Adjunto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(506, 87);
            this.panel1.TabIndex = 55;
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
            this.label3.Location = new System.Drawing.Point(325, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 259;
            this.label3.Text = "Envío de Correo";
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
            this.panel2.Controls.Add(this.Btn_Salir);
            this.panel2.Controls.Add(this.Btn_AdjuntarArchivo);
            this.panel2.Controls.Add(this.Btn_EnviarCorreo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(506, 68);
            this.panel2.TabIndex = 56;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Salir.FlatAppearance.BorderSize = 0;
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Salir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Salir.Location = new System.Drawing.Point(365, 10);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(125, 49);
            this.Btn_Salir.TabIndex = 263;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_AdjuntarArchivo
            // 
            this.Btn_AdjuntarArchivo.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_AdjuntarArchivo.FlatAppearance.BorderSize = 0;
            this.Btn_AdjuntarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_AdjuntarArchivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AdjuntarArchivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_AdjuntarArchivo.Location = new System.Drawing.Point(10, 10);
            this.Btn_AdjuntarArchivo.Name = "Btn_AdjuntarArchivo";
            this.Btn_AdjuntarArchivo.Size = new System.Drawing.Size(350, 23);
            this.Btn_AdjuntarArchivo.TabIndex = 261;
            this.Btn_AdjuntarArchivo.Text = "Adjuntar Archivo";
            this.Btn_AdjuntarArchivo.UseVisualStyleBackColor = false;
            this.Btn_AdjuntarArchivo.Click += new System.EventHandler(this.Btn_AdjuntarArchivo_Click);
            // 
            // Btn_EnviarCorreo
            // 
            this.Btn_EnviarCorreo.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_EnviarCorreo.FlatAppearance.BorderSize = 0;
            this.Btn_EnviarCorreo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_EnviarCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EnviarCorreo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_EnviarCorreo.Location = new System.Drawing.Point(10, 40);
            this.Btn_EnviarCorreo.Name = "Btn_EnviarCorreo";
            this.Btn_EnviarCorreo.Size = new System.Drawing.Size(350, 19);
            this.Btn_EnviarCorreo.TabIndex = 262;
            this.Btn_EnviarCorreo.Text = "Enviar Correo";
            this.Btn_EnviarCorreo.UseVisualStyleBackColor = false;
            this.Btn_EnviarCorreo.Click += new System.EventHandler(this.Btn_EnviarCorreo_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Txt_Receptor
            // 
            this.Txt_Receptor.Location = new System.Drawing.Point(104, 120);
            this.Txt_Receptor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Receptor.Name = "Txt_Receptor";
            this.Txt_Receptor.Size = new System.Drawing.Size(387, 20);
            this.Txt_Receptor.TabIndex = 58;
            // 
            // Txt_Asunto
            // 
            this.Txt_Asunto.Location = new System.Drawing.Point(104, 148);
            this.Txt_Asunto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Asunto.Name = "Txt_Asunto";
            this.Txt_Asunto.Size = new System.Drawing.Size(387, 20);
            this.Txt_Asunto.TabIndex = 59;
            // 
            // Txt_Emisor
            // 
            this.Txt_Emisor.Location = new System.Drawing.Point(104, 92);
            this.Txt_Emisor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Emisor.Name = "Txt_Emisor";
            this.Txt_Emisor.Size = new System.Drawing.Size(387, 20);
            this.Txt_Emisor.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(26, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 61;
            this.label4.Text = "Emisor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(6, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 62;
            this.label5.Text = "Receptor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(25, 143);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 24);
            this.label6.TabIndex = 63;
            this.label6.Text = "Asunto:";
            // 
            // Txt_Adjunto
            // 
            this.Txt_Adjunto.Location = new System.Drawing.Point(104, 176);
            this.Txt_Adjunto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Adjunto.Name = "Txt_Adjunto";
            this.Txt_Adjunto.Size = new System.Drawing.Size(387, 20);
            this.Txt_Adjunto.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(19, 172);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 24);
            this.label7.TabIndex = 65;
            this.label7.Text = "Adjunto:";
            // 
            // Frm_EnvioCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(506, 276);
            this.Controls.Add(this.Txt_Adjunto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Emisor);
            this.Controls.Add(this.Txt_Asunto);
            this.Controls.Add(this.Txt_Receptor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_EnvioCorreo";
            this.Text = "Frm_EnvioCorreo";
            this.Load += new System.EventHandler(this.Frm_EnvioCorreo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_AdjuntarArchivo;
        private System.Windows.Forms.Button Btn_EnviarCorreo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox Txt_Receptor;
        private System.Windows.Forms.TextBox Txt_Asunto;
        private System.Windows.Forms.TextBox Txt_Emisor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Adjunto;
        private System.Windows.Forms.Label label7;
    }
}