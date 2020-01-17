namespace Punto_de_Venta_BeerLab.UI.Pantallas_Inventario
{
    partial class Form_Ubicacciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ubicacciones));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_LetraAlmacen = new System.Windows.Forms.Label();
            this.Lbl_NumeroPasillo = new System.Windows.Forms.Label();
            this.Lbl_CodigoLote = new System.Windows.Forms.Label();
            this.Lbl_CantidadLote = new System.Windows.Forms.Label();
            this.Lbl_NumeroEstante = new System.Windows.Forms.Label();
            this.Lbl_UbicacionEstante = new System.Windows.Forms.Label();
            this.Lbl_TipoCerveza = new System.Windows.Forms.Label();
            this.Lbl_FechaProduccion = new System.Windows.Forms.Label();
            this.Lbl_TipoEnvasado = new System.Windows.Forms.Label();
            this.Lbl_NivelFragilidad = new System.Windows.Forms.Label();
            this.Lbl_UbicaccionReceptora = new System.Windows.Forms.Label();
            this.Lbl_UbicaccionEntrega = new System.Windows.Forms.Label();
            this.Lbl_ValorLote = new System.Windows.Forms.Label();
            this.Lbl_CodigoUbicaccion = new System.Windows.Forms.Label();
            this.Lbl_PesoLote = new System.Windows.Forms.Label();
            this.Cmb_LetraAlmacen = new System.Windows.Forms.ComboBox();
            this.Cmb_NumeroPasillo = new System.Windows.Forms.ComboBox();
            this.Cmb_NumeroEstante = new System.Windows.Forms.ComboBox();
            this.CmbUbicaccionEstante = new System.Windows.Forms.ComboBox();
            this.Cmb_TipoCerveza = new System.Windows.Forms.ComboBox();
            this.Cmb_TipoEnvasado = new System.Windows.Forms.ComboBox();
            this.Cmb_NivelFragilidad = new System.Windows.Forms.ComboBox();
            this.Cmb_UbicaccionReceptora = new System.Windows.Forms.ComboBox();
            this.Cmb_UbicaccionEntrega = new System.Windows.Forms.ComboBox();
            this.Txt_CodigoLote = new System.Windows.Forms.TextBox();
            this.Txt_CantidadLote = new System.Windows.Forms.TextBox();
            this.Txt_ValorLote = new System.Windows.Forms.TextBox();
            this.Txt_PesoLote = new System.Windows.Forms.TextBox();
            this.Txt_CodigoUbicacion = new System.Windows.Forms.TextBox();
            this.Dtp_FechaProduccion = new System.Windows.Forms.DateTimePicker();
            this.Dgv_Ubicaccion = new System.Windows.Forms.DataGridView();
            this.Btn_GenerarCodigo = new System.Windows.Forms.Button();
            this.Btn_AgregarUbicaccion = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_ActualizarUbicaccion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Ubicaccion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 70);
            this.panel1.TabIndex = 55;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(623, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 261;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(358, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 25);
            this.label3.TabIndex = 260;
            this.label3.Text = "Menu de Ubicaciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 54;
            this.label1.Text = "label1";
            // 
            // Lbl_LetraAlmacen
            // 
            this.Lbl_LetraAlmacen.AutoSize = true;
            this.Lbl_LetraAlmacen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_LetraAlmacen.Location = new System.Drawing.Point(43, 102);
            this.Lbl_LetraAlmacen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_LetraAlmacen.Name = "Lbl_LetraAlmacen";
            this.Lbl_LetraAlmacen.Size = new System.Drawing.Size(78, 13);
            this.Lbl_LetraAlmacen.TabIndex = 262;
            this.Lbl_LetraAlmacen.Text = "Letra Almacén:";
            // 
            // Lbl_NumeroPasillo
            // 
            this.Lbl_NumeroPasillo.AutoSize = true;
            this.Lbl_NumeroPasillo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_NumeroPasillo.Location = new System.Drawing.Point(43, 127);
            this.Lbl_NumeroPasillo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_NumeroPasillo.Name = "Lbl_NumeroPasillo";
            this.Lbl_NumeroPasillo.Size = new System.Drawing.Size(95, 13);
            this.Lbl_NumeroPasillo.TabIndex = 263;
            this.Lbl_NumeroPasillo.Text = "Numero de Pasillo:";
            // 
            // Lbl_CodigoLote
            // 
            this.Lbl_CodigoLote.AutoSize = true;
            this.Lbl_CodigoLote.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_CodigoLote.Location = new System.Drawing.Point(43, 154);
            this.Lbl_CodigoLote.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_CodigoLote.Name = "Lbl_CodigoLote";
            this.Lbl_CodigoLote.Size = new System.Drawing.Size(67, 13);
            this.Lbl_CodigoLote.TabIndex = 264;
            this.Lbl_CodigoLote.Text = "Codigo Lote:";
            this.Lbl_CodigoLote.Click += new System.EventHandler(this.Label4_Click);
            // 
            // Lbl_CantidadLote
            // 
            this.Lbl_CantidadLote.AutoSize = true;
            this.Lbl_CantidadLote.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_CantidadLote.Location = new System.Drawing.Point(43, 182);
            this.Lbl_CantidadLote.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_CantidadLote.Name = "Lbl_CantidadLote";
            this.Lbl_CantidadLote.Size = new System.Drawing.Size(76, 13);
            this.Lbl_CantidadLote.TabIndex = 265;
            this.Lbl_CantidadLote.Text = "Cantidad Lote:";
            // 
            // Lbl_NumeroEstante
            // 
            this.Lbl_NumeroEstante.AutoSize = true;
            this.Lbl_NumeroEstante.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_NumeroEstante.Location = new System.Drawing.Point(43, 208);
            this.Lbl_NumeroEstante.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_NumeroEstante.Name = "Lbl_NumeroEstante";
            this.Lbl_NumeroEstante.Size = new System.Drawing.Size(86, 13);
            this.Lbl_NumeroEstante.TabIndex = 266;
            this.Lbl_NumeroEstante.Text = "Número Estante:";
            // 
            // Lbl_UbicacionEstante
            // 
            this.Lbl_UbicacionEstante.AutoSize = true;
            this.Lbl_UbicacionEstante.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_UbicacionEstante.Location = new System.Drawing.Point(43, 236);
            this.Lbl_UbicacionEstante.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_UbicacionEstante.Name = "Lbl_UbicacionEstante";
            this.Lbl_UbicacionEstante.Size = new System.Drawing.Size(123, 13);
            this.Lbl_UbicacionEstante.TabIndex = 267;
            this.Lbl_UbicacionEstante.Text = "Ubicación en el Estante:";
            // 
            // Lbl_TipoCerveza
            // 
            this.Lbl_TipoCerveza.AutoSize = true;
            this.Lbl_TipoCerveza.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_TipoCerveza.Location = new System.Drawing.Point(43, 265);
            this.Lbl_TipoCerveza.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_TipoCerveza.Name = "Lbl_TipoCerveza";
            this.Lbl_TipoCerveza.Size = new System.Drawing.Size(88, 13);
            this.Lbl_TipoCerveza.TabIndex = 268;
            this.Lbl_TipoCerveza.Text = "Tipo de Cerveza:";
            // 
            // Lbl_FechaProduccion
            // 
            this.Lbl_FechaProduccion.AutoSize = true;
            this.Lbl_FechaProduccion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_FechaProduccion.Location = new System.Drawing.Point(399, 102);
            this.Lbl_FechaProduccion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_FechaProduccion.Name = "Lbl_FechaProduccion";
            this.Lbl_FechaProduccion.Size = new System.Drawing.Size(112, 13);
            this.Lbl_FechaProduccion.TabIndex = 269;
            this.Lbl_FechaProduccion.Text = "Fecha de Producción:";
            // 
            // Lbl_TipoEnvasado
            // 
            this.Lbl_TipoEnvasado.AutoSize = true;
            this.Lbl_TipoEnvasado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_TipoEnvasado.Location = new System.Drawing.Point(399, 127);
            this.Lbl_TipoEnvasado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_TipoEnvasado.Name = "Lbl_TipoEnvasado";
            this.Lbl_TipoEnvasado.Size = new System.Drawing.Size(97, 13);
            this.Lbl_TipoEnvasado.TabIndex = 270;
            this.Lbl_TipoEnvasado.Text = "Tipo de Envasado:";
            // 
            // Lbl_NivelFragilidad
            // 
            this.Lbl_NivelFragilidad.AutoSize = true;
            this.Lbl_NivelFragilidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_NivelFragilidad.Location = new System.Drawing.Point(399, 154);
            this.Lbl_NivelFragilidad.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_NivelFragilidad.Name = "Lbl_NivelFragilidad";
            this.Lbl_NivelFragilidad.Size = new System.Drawing.Size(97, 13);
            this.Lbl_NivelFragilidad.TabIndex = 271;
            this.Lbl_NivelFragilidad.Text = "Nivel de Fragilidad:";
            // 
            // Lbl_UbicaccionReceptora
            // 
            this.Lbl_UbicaccionReceptora.AutoSize = true;
            this.Lbl_UbicaccionReceptora.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_UbicaccionReceptora.Location = new System.Drawing.Point(399, 182);
            this.Lbl_UbicaccionReceptora.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_UbicaccionReceptora.Name = "Lbl_UbicaccionReceptora";
            this.Lbl_UbicaccionReceptora.Size = new System.Drawing.Size(117, 13);
            this.Lbl_UbicaccionReceptora.TabIndex = 272;
            this.Lbl_UbicaccionReceptora.Text = "Ubicacción Receptora:";
            // 
            // Lbl_UbicaccionEntrega
            // 
            this.Lbl_UbicaccionEntrega.AutoSize = true;
            this.Lbl_UbicaccionEntrega.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_UbicaccionEntrega.Location = new System.Drawing.Point(399, 208);
            this.Lbl_UbicaccionEntrega.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_UbicaccionEntrega.Name = "Lbl_UbicaccionEntrega";
            this.Lbl_UbicaccionEntrega.Size = new System.Drawing.Size(119, 13);
            this.Lbl_UbicaccionEntrega.TabIndex = 273;
            this.Lbl_UbicaccionEntrega.Text = "Ubicacción de Entrega:";
            // 
            // Lbl_ValorLote
            // 
            this.Lbl_ValorLote.AutoSize = true;
            this.Lbl_ValorLote.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_ValorLote.Location = new System.Drawing.Point(399, 236);
            this.Lbl_ValorLote.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_ValorLote.Name = "Lbl_ValorLote";
            this.Lbl_ValorLote.Size = new System.Drawing.Size(58, 13);
            this.Lbl_ValorLote.TabIndex = 274;
            this.Lbl_ValorLote.Text = "Valor Lote:";
            // 
            // Lbl_CodigoUbicaccion
            // 
            this.Lbl_CodigoUbicaccion.AutoSize = true;
            this.Lbl_CodigoUbicaccion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_CodigoUbicaccion.Location = new System.Drawing.Point(399, 265);
            this.Lbl_CodigoUbicaccion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_CodigoUbicaccion.Name = "Lbl_CodigoUbicaccion";
            this.Lbl_CodigoUbicaccion.Size = new System.Drawing.Size(115, 13);
            this.Lbl_CodigoUbicaccion.TabIndex = 275;
            this.Lbl_CodigoUbicaccion.Text = "Codigo de Ubicacción:";
            // 
            // Lbl_PesoLote
            // 
            this.Lbl_PesoLote.AutoSize = true;
            this.Lbl_PesoLote.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_PesoLote.Location = new System.Drawing.Point(43, 291);
            this.Lbl_PesoLote.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_PesoLote.Name = "Lbl_PesoLote";
            this.Lbl_PesoLote.Size = new System.Drawing.Size(58, 13);
            this.Lbl_PesoLote.TabIndex = 276;
            this.Lbl_PesoLote.Text = "Peso Lote:";
            this.Lbl_PesoLote.Click += new System.EventHandler(this.Label4_Click_1);
            // 
            // Cmb_LetraAlmacen
            // 
            this.Cmb_LetraAlmacen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_LetraAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_LetraAlmacen.FormattingEnabled = true;
            this.Cmb_LetraAlmacen.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.Cmb_LetraAlmacen.Location = new System.Drawing.Point(254, 99);
            this.Cmb_LetraAlmacen.Margin = new System.Windows.Forms.Padding(6);
            this.Cmb_LetraAlmacen.Name = "Cmb_LetraAlmacen";
            this.Cmb_LetraAlmacen.Size = new System.Drawing.Size(105, 21);
            this.Cmb_LetraAlmacen.TabIndex = 277;
            this.Cmb_LetraAlmacen.Tag = "AAA";
            // 
            // Cmb_NumeroPasillo
            // 
            this.Cmb_NumeroPasillo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_NumeroPasillo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_NumeroPasillo.FormattingEnabled = true;
            this.Cmb_NumeroPasillo.Items.AddRange(new object[] {
            "1",
            "2"});
            this.Cmb_NumeroPasillo.Location = new System.Drawing.Point(254, 124);
            this.Cmb_NumeroPasillo.Margin = new System.Windows.Forms.Padding(6);
            this.Cmb_NumeroPasillo.Name = "Cmb_NumeroPasillo";
            this.Cmb_NumeroPasillo.Size = new System.Drawing.Size(105, 21);
            this.Cmb_NumeroPasillo.TabIndex = 278;
            this.Cmb_NumeroPasillo.Tag = "AAA";
            // 
            // Cmb_NumeroEstante
            // 
            this.Cmb_NumeroEstante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_NumeroEstante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_NumeroEstante.FormattingEnabled = true;
            this.Cmb_NumeroEstante.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "A4",
            "A5",
            "A6",
            "A7",
            "A8",
            "A9",
            "B1",
            "B2",
            "B3",
            "B4",
            "B5",
            "B6",
            "B7",
            "B8",
            "B9",
            "C1",
            "C2",
            "C3",
            "C4",
            "C5",
            "C6",
            "C7",
            "C8",
            "C9"});
            this.Cmb_NumeroEstante.Location = new System.Drawing.Point(254, 205);
            this.Cmb_NumeroEstante.Margin = new System.Windows.Forms.Padding(6);
            this.Cmb_NumeroEstante.Name = "Cmb_NumeroEstante";
            this.Cmb_NumeroEstante.Size = new System.Drawing.Size(105, 21);
            this.Cmb_NumeroEstante.TabIndex = 279;
            this.Cmb_NumeroEstante.Tag = "AAA";
            // 
            // CmbUbicaccionEstante
            // 
            this.CmbUbicaccionEstante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbUbicaccionEstante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUbicaccionEstante.FormattingEnabled = true;
            this.CmbUbicaccionEstante.Items.AddRange(new object[] {
            "UP",
            "MID",
            "DOWN"});
            this.CmbUbicaccionEstante.Location = new System.Drawing.Point(254, 233);
            this.CmbUbicaccionEstante.Margin = new System.Windows.Forms.Padding(6);
            this.CmbUbicaccionEstante.Name = "CmbUbicaccionEstante";
            this.CmbUbicaccionEstante.Size = new System.Drawing.Size(105, 21);
            this.CmbUbicaccionEstante.TabIndex = 280;
            this.CmbUbicaccionEstante.Tag = "AAA";
            // 
            // Cmb_TipoCerveza
            // 
            this.Cmb_TipoCerveza.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_TipoCerveza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_TipoCerveza.FormattingEnabled = true;
            this.Cmb_TipoCerveza.Items.AddRange(new object[] {
            "UP",
            "MID",
            "DOWN"});
            this.Cmb_TipoCerveza.Location = new System.Drawing.Point(254, 262);
            this.Cmb_TipoCerveza.Margin = new System.Windows.Forms.Padding(6);
            this.Cmb_TipoCerveza.Name = "Cmb_TipoCerveza";
            this.Cmb_TipoCerveza.Size = new System.Drawing.Size(105, 21);
            this.Cmb_TipoCerveza.TabIndex = 281;
            this.Cmb_TipoCerveza.Tag = "AAA";
            // 
            // Cmb_TipoEnvasado
            // 
            this.Cmb_TipoEnvasado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_TipoEnvasado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_TipoEnvasado.FormattingEnabled = true;
            this.Cmb_TipoEnvasado.Items.AddRange(new object[] {
            "V",
            "L"});
            this.Cmb_TipoEnvasado.Location = new System.Drawing.Point(597, 124);
            this.Cmb_TipoEnvasado.Margin = new System.Windows.Forms.Padding(6);
            this.Cmb_TipoEnvasado.Name = "Cmb_TipoEnvasado";
            this.Cmb_TipoEnvasado.Size = new System.Drawing.Size(105, 21);
            this.Cmb_TipoEnvasado.TabIndex = 282;
            this.Cmb_TipoEnvasado.Tag = "AAA";
            // 
            // Cmb_NivelFragilidad
            // 
            this.Cmb_NivelFragilidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_NivelFragilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_NivelFragilidad.FormattingEnabled = true;
            this.Cmb_NivelFragilidad.Items.AddRange(new object[] {
            "F",
            "MF"});
            this.Cmb_NivelFragilidad.Location = new System.Drawing.Point(597, 151);
            this.Cmb_NivelFragilidad.Margin = new System.Windows.Forms.Padding(6);
            this.Cmb_NivelFragilidad.Name = "Cmb_NivelFragilidad";
            this.Cmb_NivelFragilidad.Size = new System.Drawing.Size(105, 21);
            this.Cmb_NivelFragilidad.TabIndex = 283;
            this.Cmb_NivelFragilidad.Tag = "AAA";
            // 
            // Cmb_UbicaccionReceptora
            // 
            this.Cmb_UbicaccionReceptora.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_UbicaccionReceptora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_UbicaccionReceptora.FormattingEnabled = true;
            this.Cmb_UbicaccionReceptora.Items.AddRange(new object[] {
            "RA",
            "RB",
            "RC"});
            this.Cmb_UbicaccionReceptora.Location = new System.Drawing.Point(597, 179);
            this.Cmb_UbicaccionReceptora.Margin = new System.Windows.Forms.Padding(6);
            this.Cmb_UbicaccionReceptora.Name = "Cmb_UbicaccionReceptora";
            this.Cmb_UbicaccionReceptora.Size = new System.Drawing.Size(105, 21);
            this.Cmb_UbicaccionReceptora.TabIndex = 284;
            this.Cmb_UbicaccionReceptora.Tag = "AAA";
            // 
            // Cmb_UbicaccionEntrega
            // 
            this.Cmb_UbicaccionEntrega.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_UbicaccionEntrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_UbicaccionEntrega.FormattingEnabled = true;
            this.Cmb_UbicaccionEntrega.Items.AddRange(new object[] {
            "EA",
            "EB",
            "EC"});
            this.Cmb_UbicaccionEntrega.Location = new System.Drawing.Point(597, 205);
            this.Cmb_UbicaccionEntrega.Margin = new System.Windows.Forms.Padding(6);
            this.Cmb_UbicaccionEntrega.Name = "Cmb_UbicaccionEntrega";
            this.Cmb_UbicaccionEntrega.Size = new System.Drawing.Size(105, 21);
            this.Cmb_UbicaccionEntrega.TabIndex = 285;
            this.Cmb_UbicaccionEntrega.Tag = "AAA";
            // 
            // Txt_CodigoLote
            // 
            this.Txt_CodigoLote.Location = new System.Drawing.Point(254, 151);
            this.Txt_CodigoLote.Margin = new System.Windows.Forms.Padding(6);
            this.Txt_CodigoLote.MaxLength = 10;
            this.Txt_CodigoLote.Name = "Txt_CodigoLote";
            this.Txt_CodigoLote.Size = new System.Drawing.Size(105, 20);
            this.Txt_CodigoLote.TabIndex = 286;
            // 
            // Txt_CantidadLote
            // 
            this.Txt_CantidadLote.Location = new System.Drawing.Point(254, 179);
            this.Txt_CantidadLote.Margin = new System.Windows.Forms.Padding(6);
            this.Txt_CantidadLote.MaxLength = 10;
            this.Txt_CantidadLote.Name = "Txt_CantidadLote";
            this.Txt_CantidadLote.Size = new System.Drawing.Size(105, 20);
            this.Txt_CantidadLote.TabIndex = 287;
            // 
            // Txt_ValorLote
            // 
            this.Txt_ValorLote.Location = new System.Drawing.Point(597, 233);
            this.Txt_ValorLote.Margin = new System.Windows.Forms.Padding(6);
            this.Txt_ValorLote.MaxLength = 10;
            this.Txt_ValorLote.Name = "Txt_ValorLote";
            this.Txt_ValorLote.Size = new System.Drawing.Size(105, 20);
            this.Txt_ValorLote.TabIndex = 288;
            // 
            // Txt_PesoLote
            // 
            this.Txt_PesoLote.Location = new System.Drawing.Point(254, 288);
            this.Txt_PesoLote.Margin = new System.Windows.Forms.Padding(6);
            this.Txt_PesoLote.MaxLength = 10;
            this.Txt_PesoLote.Name = "Txt_PesoLote";
            this.Txt_PesoLote.Size = new System.Drawing.Size(105, 20);
            this.Txt_PesoLote.TabIndex = 289;
            // 
            // Txt_CodigoUbicacion
            // 
            this.Txt_CodigoUbicacion.Location = new System.Drawing.Point(597, 262);
            this.Txt_CodigoUbicacion.Margin = new System.Windows.Forms.Padding(6);
            this.Txt_CodigoUbicacion.MaxLength = 10;
            this.Txt_CodigoUbicacion.Name = "Txt_CodigoUbicacion";
            this.Txt_CodigoUbicacion.Size = new System.Drawing.Size(105, 20);
            this.Txt_CodigoUbicacion.TabIndex = 290;
            // 
            // Dtp_FechaProduccion
            // 
            this.Dtp_FechaProduccion.Location = new System.Drawing.Point(597, 96);
            this.Dtp_FechaProduccion.Name = "Dtp_FechaProduccion";
            this.Dtp_FechaProduccion.Size = new System.Drawing.Size(105, 20);
            this.Dtp_FechaProduccion.TabIndex = 291;
            // 
            // Dgv_Ubicaccion
            // 
            this.Dgv_Ubicaccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Ubicaccion.Location = new System.Drawing.Point(46, 336);
            this.Dgv_Ubicaccion.Name = "Dgv_Ubicaccion";
            this.Dgv_Ubicaccion.Size = new System.Drawing.Size(554, 206);
            this.Dgv_Ubicaccion.TabIndex = 292;
            // 
            // Btn_GenerarCodigo
            // 
            this.Btn_GenerarCodigo.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_GenerarCodigo.FlatAppearance.BorderSize = 0;
            this.Btn_GenerarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_GenerarCodigo.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.Btn_GenerarCodigo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_GenerarCodigo.Location = new System.Drawing.Point(623, 336);
            this.Btn_GenerarCodigo.Name = "Btn_GenerarCodigo";
            this.Btn_GenerarCodigo.Size = new System.Drawing.Size(154, 28);
            this.Btn_GenerarCodigo.TabIndex = 293;
            this.Btn_GenerarCodigo.Text = "Generar Código";
            this.Btn_GenerarCodigo.UseVisualStyleBackColor = false;
            // 
            // Btn_AgregarUbicaccion
            // 
            this.Btn_AgregarUbicaccion.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_AgregarUbicaccion.FlatAppearance.BorderSize = 0;
            this.Btn_AgregarUbicaccion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_AgregarUbicaccion.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.Btn_AgregarUbicaccion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_AgregarUbicaccion.Location = new System.Drawing.Point(623, 370);
            this.Btn_AgregarUbicaccion.Name = "Btn_AgregarUbicaccion";
            this.Btn_AgregarUbicaccion.Size = new System.Drawing.Size(154, 28);
            this.Btn_AgregarUbicaccion.TabIndex = 294;
            this.Btn_AgregarUbicaccion.Text = "Agregar Ubicación";
            this.Btn_AgregarUbicaccion.UseVisualStyleBackColor = false;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Salir.FlatAppearance.BorderSize = 0;
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Salir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Salir.Location = new System.Drawing.Point(623, 507);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(154, 35);
            this.Btn_Salir.TabIndex = 296;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_ActualizarUbicaccion
            // 
            this.Btn_ActualizarUbicaccion.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_ActualizarUbicaccion.FlatAppearance.BorderSize = 0;
            this.Btn_ActualizarUbicaccion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_ActualizarUbicaccion.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.Btn_ActualizarUbicaccion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_ActualizarUbicaccion.Location = new System.Drawing.Point(623, 404);
            this.Btn_ActualizarUbicaccion.Name = "Btn_ActualizarUbicaccion";
            this.Btn_ActualizarUbicaccion.Size = new System.Drawing.Size(154, 28);
            this.Btn_ActualizarUbicaccion.TabIndex = 295;
            this.Btn_ActualizarUbicaccion.Text = "Actualizar Ubicacción";
            this.Btn_ActualizarUbicaccion.UseVisualStyleBackColor = false;
            // 
            // Form_Ubicacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_ActualizarUbicaccion);
            this.Controls.Add(this.Btn_AgregarUbicaccion);
            this.Controls.Add(this.Btn_GenerarCodigo);
            this.Controls.Add(this.Dgv_Ubicaccion);
            this.Controls.Add(this.Dtp_FechaProduccion);
            this.Controls.Add(this.Txt_CodigoUbicacion);
            this.Controls.Add(this.Txt_PesoLote);
            this.Controls.Add(this.Txt_ValorLote);
            this.Controls.Add(this.Txt_CantidadLote);
            this.Controls.Add(this.Txt_CodigoLote);
            this.Controls.Add(this.Cmb_UbicaccionEntrega);
            this.Controls.Add(this.Cmb_UbicaccionReceptora);
            this.Controls.Add(this.Cmb_NivelFragilidad);
            this.Controls.Add(this.Cmb_TipoEnvasado);
            this.Controls.Add(this.Cmb_TipoCerveza);
            this.Controls.Add(this.CmbUbicaccionEstante);
            this.Controls.Add(this.Cmb_NumeroEstante);
            this.Controls.Add(this.Cmb_NumeroPasillo);
            this.Controls.Add(this.Cmb_LetraAlmacen);
            this.Controls.Add(this.Lbl_PesoLote);
            this.Controls.Add(this.Lbl_CodigoUbicaccion);
            this.Controls.Add(this.Lbl_ValorLote);
            this.Controls.Add(this.Lbl_UbicaccionEntrega);
            this.Controls.Add(this.Lbl_UbicaccionReceptora);
            this.Controls.Add(this.Lbl_NivelFragilidad);
            this.Controls.Add(this.Lbl_TipoEnvasado);
            this.Controls.Add(this.Lbl_FechaProduccion);
            this.Controls.Add(this.Lbl_TipoCerveza);
            this.Controls.Add(this.Lbl_UbicacionEstante);
            this.Controls.Add(this.Lbl_NumeroEstante);
            this.Controls.Add(this.Lbl_CantidadLote);
            this.Controls.Add(this.Lbl_CodigoLote);
            this.Controls.Add(this.Lbl_NumeroPasillo);
            this.Controls.Add(this.Lbl_LetraAlmacen);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Ubicacciones";
            this.Text = "Form_Ubicacciones";
            this.Load += new System.EventHandler(this.Form_Ubicacciones_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Ubicaccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_LetraAlmacen;
        private System.Windows.Forms.Label Lbl_NumeroPasillo;
        private System.Windows.Forms.Label Lbl_CodigoLote;
        private System.Windows.Forms.Label Lbl_CantidadLote;
        private System.Windows.Forms.Label Lbl_NumeroEstante;
        private System.Windows.Forms.Label Lbl_UbicacionEstante;
        private System.Windows.Forms.Label Lbl_TipoCerveza;
        private System.Windows.Forms.Label Lbl_FechaProduccion;
        private System.Windows.Forms.Label Lbl_TipoEnvasado;
        private System.Windows.Forms.Label Lbl_NivelFragilidad;
        private System.Windows.Forms.Label Lbl_UbicaccionReceptora;
        private System.Windows.Forms.Label Lbl_UbicaccionEntrega;
        private System.Windows.Forms.Label Lbl_ValorLote;
        private System.Windows.Forms.Label Lbl_CodigoUbicaccion;
        private System.Windows.Forms.Label Lbl_PesoLote;
        private System.Windows.Forms.ComboBox Cmb_LetraAlmacen;
        private System.Windows.Forms.ComboBox Cmb_NumeroPasillo;
        private System.Windows.Forms.ComboBox Cmb_NumeroEstante;
        private System.Windows.Forms.ComboBox CmbUbicaccionEstante;
        private System.Windows.Forms.ComboBox Cmb_TipoCerveza;
        private System.Windows.Forms.ComboBox Cmb_TipoEnvasado;
        private System.Windows.Forms.ComboBox Cmb_NivelFragilidad;
        private System.Windows.Forms.ComboBox Cmb_UbicaccionReceptora;
        private System.Windows.Forms.ComboBox Cmb_UbicaccionEntrega;
        private System.Windows.Forms.TextBox Txt_CodigoLote;
        private System.Windows.Forms.TextBox Txt_CantidadLote;
        private System.Windows.Forms.TextBox Txt_ValorLote;
        private System.Windows.Forms.TextBox Txt_PesoLote;
        private System.Windows.Forms.TextBox Txt_CodigoUbicacion;
        private System.Windows.Forms.DateTimePicker Dtp_FechaProduccion;
        private System.Windows.Forms.DataGridView Dgv_Ubicaccion;
        private System.Windows.Forms.Button Btn_GenerarCodigo;
        private System.Windows.Forms.Button Btn_AgregarUbicaccion;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_ActualizarUbicaccion;
    }
}