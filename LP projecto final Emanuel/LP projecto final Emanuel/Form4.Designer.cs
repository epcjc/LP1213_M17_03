namespace LP_projecto_final_Emanuel
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.database1DataSet = new LP_projecto_final_Emanuel.Database1DataSet();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservaTableAdapter = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.ReservaTableAdapter();
            this.tableAdapterManager = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.ClienteTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tiposDeQuartosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipos_de_quartosTableAdapter = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.Tipos_de_quartosTableAdapter();
            this.quartoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quartoTableAdapter = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.QuartoTableAdapter();
            this.quarto1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quarto1TableAdapter = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.Quarto1TableAdapter();
            this.quarto2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quarto2TableAdapter = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.Quarto2TableAdapter();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeQuartosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quarto1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quarto2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataMember = "Reserva";
            this.reservaBindingSource.DataSource = this.database1DataSet;
            // 
            // reservaTableAdapter
            // 
            this.reservaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Cliente1TableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.codigo_postalTableAdapter = null;
            this.tableAdapterManager.Pagamento1TableAdapter = null;
            this.tableAdapterManager.PagamentoTableAdapter = null;
            this.tableAdapterManager.Preço_do_quarto1TableAdapter = null;
            this.tableAdapterManager.Preço_do_quarto2TableAdapter = null;
            this.tableAdapterManager.Preço_do_quartoTableAdapter = null;
            this.tableAdapterManager.Quarto1TableAdapter = null;
            this.tableAdapterManager.Quarto2TableAdapter = null;
            this.tableAdapterManager.QuartoTableAdapter = null;
            this.tableAdapterManager.Reserva_quartos1TableAdapter = null;
            this.tableAdapterManager.Reserva_quartosTableAdapter = null;
            this.tableAdapterManager.Reserva1TableAdapter = null;
            this.tableAdapterManager.ReservaTableAdapter = this.reservaTableAdapter;
            this.tableAdapterManager.Tipos_de_pagamento1TableAdapter = null;
            this.tableAdapterManager.Tipos_de_pagamentoTableAdapter = null;
            this.tableAdapterManager.Tipos_de_quartosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LP_projecto_final_Emanuel.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilizadoresTableAdapter = null;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(509, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 24);
            this.button1.TabIndex = 19;
            this.button1.Text = "Ir para Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Clientes";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.clienteBindingSource;
            this.comboBox1.DisplayMember = "nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(464, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.ValueMember = "id_cliente";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.database1DataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(37, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 24);
            this.button2.TabIndex = 23;
            this.button2.Text = "Inserir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(323, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Inserir  Reservas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "data reserva";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "hora reserva";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "data inicio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "data fim";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "comentarios";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 358);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "estado";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(135, 274);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(159, 78);
            this.textBox8.TabIndex = 43;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(135, 358);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(159, 20);
            this.textBox9.TabIndex = 44;
            this.textBox9.Visible = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1980",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993"});
            this.comboBox3.Location = new System.Drawing.Point(241, 139);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(53, 21);
            this.comboBox3.TabIndex = 47;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
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
            "31"});
            this.comboBox2.Location = new System.Drawing.Point(202, 139);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(35, 21);
            this.comboBox2.TabIndex = 46;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.comboBox4.Location = new System.Drawing.Point(135, 139);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(62, 21);
            this.comboBox4.TabIndex = 45;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
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
            "",
            ""});
            this.comboBox5.Location = new System.Drawing.Point(135, 169);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(50, 21);
            this.comboBox5.TabIndex = 48;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "1980",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993"});
            this.comboBox6.Location = new System.Drawing.Point(241, 193);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(53, 21);
            this.comboBox6.TabIndex = 51;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
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
            "31"});
            this.comboBox7.Location = new System.Drawing.Point(202, 193);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(35, 21);
            this.comboBox7.TabIndex = 50;
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.comboBox8.Location = new System.Drawing.Point(135, 193);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(62, 21);
            this.comboBox8.TabIndex = 49;
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            "1980",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993"});
            this.comboBox9.Location = new System.Drawing.Point(241, 220);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(53, 21);
            this.comboBox9.TabIndex = 54;
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
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
            "31"});
            this.comboBox10.Location = new System.Drawing.Point(202, 220);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(35, 21);
            this.comboBox10.TabIndex = 53;
            // 
            // comboBox11
            // 
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.comboBox11.Location = new System.Drawing.Point(135, 220);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(62, 21);
            this.comboBox11.TabIndex = 52;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.Location = new System.Drawing.Point(158, 395);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 23);
            this.button4.TabIndex = 55;
            this.button4.Text = "Listar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.Location = new System.Drawing.Point(268, 394);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 23);
            this.button5.TabIndex = 56;
            this.button5.Text = "Eliminar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.Location = new System.Drawing.Point(378, 395);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 23);
            this.button6.TabIndex = 57;
            this.button6.Text = "Ajuda";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "id reserva";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 36;
            this.textBox1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "id cliente";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 20);
            this.textBox2.TabIndex = 37;
            this.textBox2.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "total";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(135, 247);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(159, 20);
            this.textBox7.TabIndex = 42;
            this.textBox7.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.quarto2BindingSource;
            this.listBox1.DisplayMember = "tipo_quarto";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(464, 153);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(139, 108);
            this.listBox1.TabIndex = 58;
            this.listBox1.ValueMember = "id_quarto";
            // 
            // tiposDeQuartosBindingSource
            // 
            this.tiposDeQuartosBindingSource.DataMember = "Tipos de quartos";
            this.tiposDeQuartosBindingSource.DataSource = this.database1DataSet;
            // 
            // tipos_de_quartosTableAdapter
            // 
            this.tipos_de_quartosTableAdapter.ClearBeforeFill = true;
            // 
            // quartoBindingSource
            // 
            this.quartoBindingSource.DataMember = "Quarto";
            this.quartoBindingSource.DataSource = this.database1DataSet;
            // 
            // quartoTableAdapter
            // 
            this.quartoTableAdapter.ClearBeforeFill = true;
            // 
            // quarto1BindingSource
            // 
            this.quarto1BindingSource.DataMember = "Quarto1";
            this.quarto1BindingSource.DataSource = this.database1DataSet;
            // 
            // quarto1TableAdapter
            // 
            this.quarto1TableAdapter.ClearBeforeFill = true;
            // 
            // quarto2BindingSource
            // 
            this.quarto2BindingSource.DataMember = "Quarto2";
            this.quarto2BindingSource.DataSource = this.database1DataSet;
            // 
            // quarto2TableAdapter
            // 
            this.quarto2TableAdapter.ClearBeforeFill = true;
            // 
            // comboBox12
            // 
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
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
            ""});
            this.comboBox12.Location = new System.Drawing.Point(194, 169);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(48, 21);
            this.comboBox12.TabIndex = 59;
            // 
            // comboBox13
            // 
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
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
            ""});
            this.comboBox13.Location = new System.Drawing.Point(248, 169);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(48, 21);
            this.comboBox13.TabIndex = 60;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 430);
            this.Controls.Add(this.comboBox13);
            this.Controls.Add(this.comboBox12);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox9);
            this.Controls.Add(this.comboBox10);
            this.Controls.Add(this.comboBox11);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MediumBlue;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form4";
            this.Text = "Lista das Reservas";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeQuartosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quarto1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quarto2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource reservaBindingSource;
        private Database1DataSetTableAdapters.ReservaTableAdapter reservaTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private Database1DataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource tiposDeQuartosBindingSource;
        private Database1DataSetTableAdapters.Tipos_de_quartosTableAdapter tipos_de_quartosTableAdapter;
        private System.Windows.Forms.BindingSource quartoBindingSource;
        private Database1DataSetTableAdapters.QuartoTableAdapter quartoTableAdapter;
        private System.Windows.Forms.BindingSource quarto1BindingSource;
        private Database1DataSetTableAdapters.Quarto1TableAdapter quarto1TableAdapter;
        private System.Windows.Forms.BindingSource quarto2BindingSource;
        private Database1DataSetTableAdapters.Quarto2TableAdapter quarto2TableAdapter;
        private System.Windows.Forms.ComboBox comboBox12;
        private System.Windows.Forms.ComboBox comboBox13;
    }
}