namespace Punto_de_Venta_BeerLab.UI
{
    partial class Form_Mantenimiento_Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Mantenimiento_Productos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_Cod_Producto = new System.Windows.Forms.TextBox();
            this.Txt_Nombre_Producto = new System.Windows.Forms.TextBox();
            this.Cmb_Tipo = new System.Windows.Forms.ComboBox();
            this.Cmd_Fragilidad = new System.Windows.Forms.ComboBox();
            this.Dgv_Lista_Productos = new System.Windows.Forms.DataGridView();
            this.Txt_Cantidad_Litros = new System.Windows.Forms.TextBox();
            this.Txt_Nivel_Alcohol = new System.Windows.Forms.ComboBox();
            this.Txt_Precio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Txt_Stock_Ini = new System.Windows.Forms.TextBox();
            this.Txt_Stock_Act = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Btn_Desactivar = new System.Windows.Forms.Button();
            this.Btn_Activar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Dtp_Emision = new System.Windows.Forms.DateTimePicker();
            this.Dtp_Caducidad = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Txt_Estado = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Gpb_ListaProductos = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Lista_Productos)).BeginInit();
            this.panel2.SuspendLayout();
            this.Gpb_ListaProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 83);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(909, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 257;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(2, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 254;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(541, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 25);
            this.label3.TabIndex = 256;
            this.label3.Text = "Mantenimiento de productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 255;
            this.label2.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(11, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Código del producto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(7, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre del producto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(32, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tipo de envase:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(16, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nivel de Fragilidad :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(540, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Cantidad en mililitros:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(484, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Nivel de alcohol en porcentaje:";
            // 
            // Txt_Cod_Producto
            // 
            this.Txt_Cod_Producto.Location = new System.Drawing.Point(122, 94);
            this.Txt_Cod_Producto.Name = "Txt_Cod_Producto";
            this.Txt_Cod_Producto.Size = new System.Drawing.Size(353, 20);
            this.Txt_Cod_Producto.TabIndex = 7;
            this.Txt_Cod_Producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersAllowed_Click);
            // 
            // Txt_Nombre_Producto
            // 
            this.Txt_Nombre_Producto.Location = new System.Drawing.Point(122, 120);
            this.Txt_Nombre_Producto.Name = "Txt_Nombre_Producto";
            this.Txt_Nombre_Producto.Size = new System.Drawing.Size(353, 20);
            this.Txt_Nombre_Producto.TabIndex = 8;
            this.Txt_Nombre_Producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLettersAllowed_Click);
            // 
            // Cmb_Tipo
            // 
            this.Cmb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Tipo.FormattingEnabled = true;
            this.Cmb_Tipo.Items.AddRange(new object[] {
            "Botella de vidrio",
            "Lata de aluminio"});
            this.Cmb_Tipo.Location = new System.Drawing.Point(122, 146);
            this.Cmb_Tipo.Name = "Cmb_Tipo";
            this.Cmb_Tipo.Size = new System.Drawing.Size(353, 21);
            this.Cmb_Tipo.TabIndex = 9;
            // 
            // Cmd_Fragilidad
            // 
            this.Cmd_Fragilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmd_Fragilidad.FormattingEnabled = true;
            this.Cmd_Fragilidad.Items.AddRange(new object[] {
            "Frágil",
            "Muy frágil"});
            this.Cmd_Fragilidad.Location = new System.Drawing.Point(122, 173);
            this.Cmd_Fragilidad.Name = "Cmd_Fragilidad";
            this.Cmd_Fragilidad.Size = new System.Drawing.Size(353, 21);
            this.Cmd_Fragilidad.TabIndex = 10;
            // 
            // Dgv_Lista_Productos
            // 
            this.Dgv_Lista_Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dgv_Lista_Productos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv_Lista_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Lista_Productos.Location = new System.Drawing.Point(6, 19);
            this.Dgv_Lista_Productos.Name = "Dgv_Lista_Productos";
            this.Dgv_Lista_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Lista_Productos.Size = new System.Drawing.Size(873, 181);
            this.Dgv_Lista_Productos.TabIndex = 11;
            this.Dgv_Lista_Productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Lista_Productos_CellClick);
            // 
            // Txt_Cantidad_Litros
            // 
            this.Txt_Cantidad_Litros.Location = new System.Drawing.Point(651, 94);
            this.Txt_Cantidad_Litros.Name = "Txt_Cantidad_Litros";
            this.Txt_Cantidad_Litros.Size = new System.Drawing.Size(353, 20);
            this.Txt_Cantidad_Litros.TabIndex = 12;
            this.Txt_Cantidad_Litros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersAllowed_Click);
            // 
            // Txt_Nivel_Alcohol
            // 
            this.Txt_Nivel_Alcohol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Txt_Nivel_Alcohol.FormattingEnabled = true;
            this.Txt_Nivel_Alcohol.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.Txt_Nivel_Alcohol.Location = new System.Drawing.Point(651, 120);
            this.Txt_Nivel_Alcohol.Name = "Txt_Nivel_Alcohol";
            this.Txt_Nivel_Alcohol.Size = new System.Drawing.Size(353, 21);
            this.Txt_Nivel_Alcohol.TabIndex = 13;
            // 
            // Txt_Precio
            // 
            this.Txt_Precio.Location = new System.Drawing.Point(651, 199);
            this.Txt_Precio.Name = "Txt_Precio";
            this.Txt_Precio.Size = new System.Drawing.Size(353, 20);
            this.Txt_Precio.TabIndex = 14;
            this.Txt_Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersAllowed_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(543, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Precio del producto:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(23, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Fecha de emisión:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(8, 229);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Fecha de caducidad:";
            // 
            // Txt_Stock_Ini
            // 
            this.Txt_Stock_Ini.Location = new System.Drawing.Point(651, 147);
            this.Txt_Stock_Ini.Name = "Txt_Stock_Ini";
            this.Txt_Stock_Ini.Size = new System.Drawing.Size(353, 20);
            this.Txt_Stock_Ini.TabIndex = 18;
            this.Txt_Stock_Ini.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersAllowed_Click);
            // 
            // Txt_Stock_Act
            // 
            this.Txt_Stock_Act.Location = new System.Drawing.Point(651, 173);
            this.Txt_Stock_Act.Name = "Txt_Stock_Act";
            this.Txt_Stock_Act.Size = new System.Drawing.Size(353, 20);
            this.Txt_Stock_Act.TabIndex = 19;
            this.Txt_Stock_Act.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersAllowed_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(580, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Stock inical:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(575, 176);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Stock actual:";
            // 
            // Btn_Desactivar
            // 
            this.Btn_Desactivar.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Desactivar.FlatAppearance.BorderSize = 0;
            this.Btn_Desactivar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Desactivar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Desactivar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Desactivar.Location = new System.Drawing.Point(892, 369);
            this.Btn_Desactivar.Name = "Btn_Desactivar";
            this.Btn_Desactivar.Size = new System.Drawing.Size(106, 83);
            this.Btn_Desactivar.TabIndex = 331;
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
            this.Btn_Activar.Location = new System.Drawing.Point(885, 19);
            this.Btn_Activar.Name = "Btn_Activar";
            this.Btn_Activar.Size = new System.Drawing.Size(106, 92);
            this.Btn_Activar.TabIndex = 330;
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
            this.Btn_Modificar.Location = new System.Drawing.Point(392, 10);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(380, 46);
            this.Btn_Modificar.TabIndex = 329;
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
            this.Btn_Agregar.Location = new System.Drawing.Point(7, 10);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(380, 46);
            this.Btn_Agregar.TabIndex = 328;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = false;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Dtp_Emision
            // 
            this.Dtp_Emision.Location = new System.Drawing.Point(122, 200);
            this.Dtp_Emision.Name = "Dtp_Emision";
            this.Dtp_Emision.Size = new System.Drawing.Size(353, 20);
            this.Dtp_Emision.TabIndex = 333;
            this.Dtp_Emision.ValueChanged += new System.EventHandler(this.Dtp_Emision_ValueChanged);
            // 
            // Dtp_Caducidad
            // 
            this.Dtp_Caducidad.Location = new System.Drawing.Point(122, 226);
            this.Dtp_Caducidad.Name = "Dtp_Caducidad";
            this.Dtp_Caducidad.Size = new System.Drawing.Size(353, 20);
            this.Dtp_Caducidad.TabIndex = 334;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Controls.Add(this.Btn_Salir);
            this.panel2.Controls.Add(this.Btn_Agregar);
            this.panel2.Controls.Add(this.Btn_Modificar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 470);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1013, 64);
            this.panel2.TabIndex = 335;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Salir.FlatAppearance.BorderSize = 0;
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Salir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Salir.Location = new System.Drawing.Point(778, 10);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(226, 46);
            this.Btn_Salir.TabIndex = 332;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Txt_Estado
            // 
            this.Txt_Estado.Enabled = false;
            this.Txt_Estado.Location = new System.Drawing.Point(651, 225);
            this.Txt_Estado.Name = "Txt_Estado";
            this.Txt_Estado.Size = new System.Drawing.Size(353, 20);
            this.Txt_Estado.TabIndex = 336;
            this.Txt_Estado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLettersAllowed_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(599, 228);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 337;
            this.label15.Text = "Estado :";
            // 
            // Gpb_ListaProductos
            // 
            this.Gpb_ListaProductos.Controls.Add(this.Btn_Activar);
            this.Gpb_ListaProductos.Controls.Add(this.Dgv_Lista_Productos);
            this.Gpb_ListaProductos.ForeColor = System.Drawing.Color.Snow;
            this.Gpb_ListaProductos.Location = new System.Drawing.Point(7, 252);
            this.Gpb_ListaProductos.Name = "Gpb_ListaProductos";
            this.Gpb_ListaProductos.Size = new System.Drawing.Size(997, 213);
            this.Gpb_ListaProductos.TabIndex = 338;
            this.Gpb_ListaProductos.TabStop = false;
            this.Gpb_ListaProductos.Text = "Lista de Productos";
            // 
            // Form_Mantenimiento_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(1013, 534);
            this.Controls.Add(this.Cmd_Fragilidad);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Btn_Desactivar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Estado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Dtp_Caducidad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Dtp_Emision);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Txt_Cod_Producto);
            this.Controls.Add(this.Txt_Nombre_Producto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Cmb_Tipo);
            this.Controls.Add(this.Txt_Stock_Act);
            this.Controls.Add(this.Txt_Stock_Ini);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Txt_Precio);
            this.Controls.Add(this.Txt_Nivel_Alcohol);
            this.Controls.Add(this.Txt_Cantidad_Litros);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Gpb_ListaProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Mantenimiento_Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Mantenimiento_Productos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Mantenimiento_Productos_FormClosing);
            this.Load += new System.EventHandler(this.Form_Mantenimiento_Productos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Lista_Productos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.Gpb_ListaProductos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_Cod_Producto;
        private System.Windows.Forms.TextBox Txt_Nombre_Producto;
        private System.Windows.Forms.ComboBox Cmb_Tipo;
        private System.Windows.Forms.ComboBox Cmd_Fragilidad;
        private System.Windows.Forms.DataGridView Dgv_Lista_Productos;
        private System.Windows.Forms.TextBox Txt_Cantidad_Litros;
        private System.Windows.Forms.ComboBox Txt_Nivel_Alcohol;
        private System.Windows.Forms.TextBox Txt_Precio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Txt_Stock_Ini;
        private System.Windows.Forms.TextBox Txt_Stock_Act;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Btn_Desactivar;
        private System.Windows.Forms.Button Btn_Activar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.DateTimePicker Dtp_Emision;
        private System.Windows.Forms.DateTimePicker Dtp_Caducidad;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.TextBox Txt_Estado;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox Gpb_ListaProductos;
    }
}