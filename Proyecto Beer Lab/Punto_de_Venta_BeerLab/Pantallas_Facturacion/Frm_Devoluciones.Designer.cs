namespace Punto_de_Venta_BeerLab.UI.Pantallas_Facturacion
{
    partial class Frm_Devoluciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Devoluciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Numero_Factura = new System.Windows.Forms.TextBox();
            this.Txt_Numero_Identificacion = new System.Windows.Forms.TextBox();
            this.Txt_Nombre_Cliente = new System.Windows.Forms.TextBox();
            this.Txt_Fecha_Emision = new System.Windows.Forms.TextBox();
            this.Dgv_Detalle_Factura = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Dgv_Articulos_Devolver = new System.Windows.Forms.DataGridView();
            this.Clm_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Descripcion_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Codigo_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Precio_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Btn_Remover = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rtxt_Descripcion = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Cmb_Razon_Devolucion = new System.Windows.Forms.ComboBox();
            this.Cmb_Estado_Fisico = new System.Windows.Forms.ComboBox();
            this.Cmb_Estado_Inventario = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Detalle_Factura)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Articulos_Devolver)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(800, 67);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(696, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(434, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pantalla de Devoluciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(13, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Controls.Add(this.Btn_Guardar);
            this.panel2.Controls.Add(this.Btn_Salir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 434);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 70);
            this.panel2.TabIndex = 4;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Enabled = false;
            this.Btn_Guardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Guardar.Location = new System.Drawing.Point(17, 14);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(458, 44);
            this.Btn_Guardar.TabIndex = 20;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Salir.Location = new System.Drawing.Point(481, 14);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(301, 44);
            this.Btn_Salir.TabIndex = 19;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(94, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Número de factura:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(29, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Número de Identificación Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(110, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nombre Cliente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(98, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Fecha de Emisión:";
            // 
            // Txt_Numero_Factura
            // 
            this.Txt_Numero_Factura.Location = new System.Drawing.Point(198, 95);
            this.Txt_Numero_Factura.Name = "Txt_Numero_Factura";
            this.Txt_Numero_Factura.Size = new System.Drawing.Size(172, 20);
            this.Txt_Numero_Factura.TabIndex = 10;
            this.Txt_Numero_Factura.TextChanged += new System.EventHandler(this.Txt_Numero_Factura_TextChanged);
            this.Txt_Numero_Factura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Numero_Factura_KeyPress);
            // 
            // Txt_Numero_Identificacion
            // 
            this.Txt_Numero_Identificacion.Enabled = false;
            this.Txt_Numero_Identificacion.Location = new System.Drawing.Point(198, 121);
            this.Txt_Numero_Identificacion.Name = "Txt_Numero_Identificacion";
            this.Txt_Numero_Identificacion.Size = new System.Drawing.Size(172, 20);
            this.Txt_Numero_Identificacion.TabIndex = 11;
            // 
            // Txt_Nombre_Cliente
            // 
            this.Txt_Nombre_Cliente.Enabled = false;
            this.Txt_Nombre_Cliente.Location = new System.Drawing.Point(198, 147);
            this.Txt_Nombre_Cliente.Name = "Txt_Nombre_Cliente";
            this.Txt_Nombre_Cliente.Size = new System.Drawing.Size(172, 20);
            this.Txt_Nombre_Cliente.TabIndex = 12;
            // 
            // Txt_Fecha_Emision
            // 
            this.Txt_Fecha_Emision.Enabled = false;
            this.Txt_Fecha_Emision.Location = new System.Drawing.Point(198, 173);
            this.Txt_Fecha_Emision.Name = "Txt_Fecha_Emision";
            this.Txt_Fecha_Emision.Size = new System.Drawing.Size(172, 20);
            this.Txt_Fecha_Emision.TabIndex = 13;
            // 
            // Dgv_Detalle_Factura
            // 
            this.Dgv_Detalle_Factura.AllowUserToAddRows = false;
            this.Dgv_Detalle_Factura.AllowUserToDeleteRows = false;
            this.Dgv_Detalle_Factura.AllowUserToResizeColumns = false;
            this.Dgv_Detalle_Factura.AllowUserToResizeRows = false;
            this.Dgv_Detalle_Factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Detalle_Factura.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Dgv_Detalle_Factura.Location = new System.Drawing.Point(6, 19);
            this.Dgv_Detalle_Factura.Name = "Dgv_Detalle_Factura";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Detalle_Factura.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Detalle_Factura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Detalle_Factura.Size = new System.Drawing.Size(370, 142);
            this.Dgv_Detalle_Factura.TabIndex = 14;
            this.Dgv_Detalle_Factura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Detalle_Factura_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dgv_Detalle_Factura);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(17, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 170);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de Factura:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Dgv_Articulos_Devolver);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(407, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 170);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Artículos a Devolver:";
            // 
            // Dgv_Articulos_Devolver
            // 
            this.Dgv_Articulos_Devolver.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Articulos_Devolver.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dgv_Articulos_Devolver.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.Dgv_Articulos_Devolver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Articulos_Devolver.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clm_ID,
            this.Clm_Descripcion_Producto,
            this.Clm_Codigo_Producto,
            this.Clm_Precio_Unitario,
            this.Clm_Cantidad});
            this.Dgv_Articulos_Devolver.Location = new System.Drawing.Point(9, 20);
            this.Dgv_Articulos_Devolver.Margin = new System.Windows.Forms.Padding(6);
            this.Dgv_Articulos_Devolver.Name = "Dgv_Articulos_Devolver";
            this.Dgv_Articulos_Devolver.ReadOnly = true;
            this.Dgv_Articulos_Devolver.RowHeadersWidth = 20;
            this.Dgv_Articulos_Devolver.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgv_Articulos_Devolver.RowTemplate.ReadOnly = true;
            this.Dgv_Articulos_Devolver.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Articulos_Devolver.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Articulos_Devolver.Size = new System.Drawing.Size(364, 141);
            this.Dgv_Articulos_Devolver.TabIndex = 9;
            // 
            // Clm_ID
            // 
            this.Clm_ID.HeaderText = "ID";
            this.Clm_ID.Name = "Clm_ID";
            this.Clm_ID.ReadOnly = true;
            // 
            // Clm_Descripcion_Producto
            // 
            this.Clm_Descripcion_Producto.HeaderText = "Descripción Producto";
            this.Clm_Descripcion_Producto.Name = "Clm_Descripcion_Producto";
            this.Clm_Descripcion_Producto.ReadOnly = true;
            // 
            // Clm_Codigo_Producto
            // 
            this.Clm_Codigo_Producto.HeaderText = "Código";
            this.Clm_Codigo_Producto.Name = "Clm_Codigo_Producto";
            this.Clm_Codigo_Producto.ReadOnly = true;
            // 
            // Clm_Precio_Unitario
            // 
            this.Clm_Precio_Unitario.HeaderText = "Precio_Unitario";
            this.Clm_Precio_Unitario.Name = "Clm_Precio_Unitario";
            this.Clm_Precio_Unitario.ReadOnly = true;
            // 
            // Clm_Cantidad
            // 
            this.Clm_Cantidad.HeaderText = "Cantidad";
            this.Clm_Cantidad.Name = "Clm_Cantidad";
            this.Clm_Cantidad.ReadOnly = true;
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Enabled = false;
            this.Btn_Agregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Agregar.Location = new System.Drawing.Point(17, 401);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(383, 27);
            this.Btn_Agregar.TabIndex = 17;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Btn_Remover
            // 
            this.Btn_Remover.Enabled = false;
            this.Btn_Remover.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Remover.Location = new System.Drawing.Point(407, 401);
            this.Btn_Remover.Name = "Btn_Remover";
            this.Btn_Remover.Size = new System.Drawing.Size(382, 27);
            this.Btn_Remover.TabIndex = 18;
            this.Btn_Remover.Text = "Remover";
            this.Btn_Remover.UseVisualStyleBackColor = true;
            this.Btn_Remover.Click += new System.EventHandler(this.Btn_Desactivar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(445, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Descripción:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(404, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Estado de inventario:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(377, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Estado físico del producto:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(389, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Razón de la devolución:";
            // 
            // rtxt_Descripcion
            // 
            this.rtxt_Descripcion.Location = new System.Drawing.Point(517, 173);
            this.rtxt_Descripcion.Name = "rtxt_Descripcion";
            this.rtxt_Descripcion.Size = new System.Drawing.Size(271, 46);
            this.rtxt_Descripcion.TabIndex = 24;
            this.rtxt_Descripcion.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(14, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(201, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Ingreso de datos para devolución:";
            // 
            // Cmb_Razon_Devolucion
            // 
            this.Cmb_Razon_Devolucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Razon_Devolucion.FormattingEnabled = true;
            this.Cmb_Razon_Devolucion.Items.AddRange(new object[] {
            "Cambio por producto de mayor precio",
            "Cambio por producto de menor precio",
            "Cambio por producto de igual precio",
            "Devolución de Efectivo"});
            this.Cmb_Razon_Devolucion.Location = new System.Drawing.Point(518, 95);
            this.Cmb_Razon_Devolucion.Name = "Cmb_Razon_Devolucion";
            this.Cmb_Razon_Devolucion.Size = new System.Drawing.Size(272, 21);
            this.Cmb_Razon_Devolucion.TabIndex = 26;
            // 
            // Cmb_Estado_Fisico
            // 
            this.Cmb_Estado_Fisico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Estado_Fisico.FormattingEnabled = true;
            this.Cmb_Estado_Fisico.Items.AddRange(new object[] {
            "Producto en buena estado",
            "Producto en mal estado"});
            this.Cmb_Estado_Fisico.Location = new System.Drawing.Point(518, 121);
            this.Cmb_Estado_Fisico.Name = "Cmb_Estado_Fisico";
            this.Cmb_Estado_Fisico.Size = new System.Drawing.Size(272, 21);
            this.Cmb_Estado_Fisico.TabIndex = 27;
            // 
            // Cmb_Estado_Inventario
            // 
            this.Cmb_Estado_Inventario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Estado_Inventario.FormattingEnabled = true;
            this.Cmb_Estado_Inventario.Items.AddRange(new object[] {
            "Reintegrar en Inventario",
            "Excluir del Inventario"});
            this.Cmb_Estado_Inventario.Location = new System.Drawing.Point(518, 147);
            this.Cmb_Estado_Inventario.Name = "Cmb_Estado_Inventario";
            this.Cmb_Estado_Inventario.Size = new System.Drawing.Size(272, 21);
            this.Cmb_Estado_Inventario.TabIndex = 28;
            // 
            // Frm_Devoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.Btn_Remover);
            this.Controls.Add(this.Cmb_Estado_Inventario);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.Cmb_Estado_Fisico);
            this.Controls.Add(this.Cmb_Razon_Devolucion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.rtxt_Descripcion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Txt_Fecha_Emision);
            this.Controls.Add(this.Txt_Nombre_Cliente);
            this.Controls.Add(this.Txt_Numero_Identificacion);
            this.Controls.Add(this.Txt_Numero_Factura);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Devoluciones";
            this.Text = "Pantalla Devoluciones";
            this.Load += new System.EventHandler(this.Frm_Devoluciones_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Detalle_Factura)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Articulos_Devolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Remover;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Numero_Factura;
        private System.Windows.Forms.TextBox Txt_Numero_Identificacion;
        private System.Windows.Forms.TextBox Txt_Nombre_Cliente;
        private System.Windows.Forms.TextBox Txt_Fecha_Emision;
        private System.Windows.Forms.DataGridView Dgv_Detalle_Factura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rtxt_Descripcion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox Cmb_Razon_Devolucion;
        private System.Windows.Forms.ComboBox Cmb_Estado_Fisico;
        private System.Windows.Forms.ComboBox Cmb_Estado_Inventario;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.DataGridView Dgv_Articulos_Devolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Descripcion_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Codigo_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Precio_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Cantidad;
    }
}