namespace LP_projecto_final_Emanuel
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanascDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigopostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new LP_projecto_final_Emanuel.Database1DataSet();
            this.clienteTableAdapter = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.ClienteTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fKPagamentoCliente2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKPagamentoReservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKPagamentoClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.fKReservaCliente2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKReservaClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pagamentoTableAdapter = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.PagamentoTableAdapter();
            this.reservaTableAdapter = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.ReservaTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.fKReservaCliente2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reserva1TableAdapter = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.Reserva1TableAdapter();
            this.fKPagamentoClienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pagamento1TableAdapter = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.Pagamento1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPagamentoCliente2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPagamentoReservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPagamentoClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKReservaCliente2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKReservaClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKReservaCliente2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPagamentoClienteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclienteDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.moradaDataGridViewTextBoxColumn,
            this.contactoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.datanascDataGridViewTextBoxColumn,
            this.bIDataGridViewTextBoxColumn,
            this.codigopostalDataGridViewTextBoxColumn,
            this.fotoDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.clienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 156);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(886, 162);
            this.dataGridView1.TabIndex = 0;
            // 
            // idclienteDataGridViewTextBoxColumn
            // 
            this.idclienteDataGridViewTextBoxColumn.DataPropertyName = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.HeaderText = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.Name = "idclienteDataGridViewTextBoxColumn";
            this.idclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // moradaDataGridViewTextBoxColumn
            // 
            this.moradaDataGridViewTextBoxColumn.DataPropertyName = "morada";
            this.moradaDataGridViewTextBoxColumn.HeaderText = "morada";
            this.moradaDataGridViewTextBoxColumn.Name = "moradaDataGridViewTextBoxColumn";
            // 
            // contactoDataGridViewTextBoxColumn
            // 
            this.contactoDataGridViewTextBoxColumn.DataPropertyName = "contacto";
            this.contactoDataGridViewTextBoxColumn.HeaderText = "contacto";
            this.contactoDataGridViewTextBoxColumn.Name = "contactoDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // datanascDataGridViewTextBoxColumn
            // 
            this.datanascDataGridViewTextBoxColumn.DataPropertyName = "data_nasc";
            this.datanascDataGridViewTextBoxColumn.HeaderText = "data_nasc";
            this.datanascDataGridViewTextBoxColumn.Name = "datanascDataGridViewTextBoxColumn";
            // 
            // bIDataGridViewTextBoxColumn
            // 
            this.bIDataGridViewTextBoxColumn.DataPropertyName = "BI";
            this.bIDataGridViewTextBoxColumn.HeaderText = "BI";
            this.bIDataGridViewTextBoxColumn.Name = "bIDataGridViewTextBoxColumn";
            // 
            // codigopostalDataGridViewTextBoxColumn
            // 
            this.codigopostalDataGridViewTextBoxColumn.DataPropertyName = "Codigo_postal";
            this.codigopostalDataGridViewTextBoxColumn.HeaderText = "Codigo_postal";
            this.codigopostalDataGridViewTextBoxColumn.Name = "codigopostalDataGridViewTextBoxColumn";
            // 
            // fotoDataGridViewImageColumn
            // 
            this.fotoDataGridViewImageColumn.DataPropertyName = "Foto";
            this.fotoDataGridViewImageColumn.HeaderText = "Foto";
            this.fotoDataGridViewImageColumn.Name = "fotoDataGridViewImageColumn";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.fKPagamentoCliente2BindingSource;
            this.comboBox1.DisplayMember = "valor_pagamento";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 129);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "id_pagamento";
            // 
            // fKPagamentoCliente2BindingSource
            // 
            this.fKPagamentoCliente2BindingSource.DataMember = "FK_Pagamento_Cliente2";
            this.fKPagamentoCliente2BindingSource.DataSource = this.clienteBindingSource;
            // 
            // fKPagamentoReservaBindingSource
            // 
            this.fKPagamentoReservaBindingSource.DataMember = "FK_Pagamento_Reserva";
            this.fKPagamentoReservaBindingSource.DataSource = this.reservaBindingSource;
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataMember = "Reserva";
            this.reservaBindingSource.DataSource = this.database1DataSet;
            // 
            // fKPagamentoClienteBindingSource
            // 
            this.fKPagamentoClienteBindingSource.DataMember = "FK_Pagamento_Cliente";
            this.fKPagamentoClienteBindingSource.DataSource = this.clienteBindingSource;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.fKReservaCliente2BindingSource1;
            this.comboBox2.DisplayMember = "Data_inicio";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(125, 82);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.ValueMember = "id_reserva";
            // 
            // fKReservaCliente2BindingSource1
            // 
            this.fKReservaCliente2BindingSource1.DataMember = "FK_Reserva_Cliente2";
            this.fKReservaCliente2BindingSource1.DataSource = this.clienteBindingSource;
            // 
            // fKReservaClienteBindingSource
            // 
            this.fKReservaClienteBindingSource.DataMember = "FK_Reserva_Cliente";
            this.fKReservaClienteBindingSource.DataSource = this.clienteBindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pagamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reserva";
            // 
            // pagamentoTableAdapter
            // 
            this.pagamentoTableAdapter.ClearBeforeFill = true;
            // 
            // reservaTableAdapter
            // 
            this.reservaTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(382, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pesquiza por reserva";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(780, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ir para Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(527, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Ajuda";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Location = new System.Drawing.Point(15, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Inserir Reserva";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.Location = new System.Drawing.Point(247, 324);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // fKReservaCliente2BindingSource
            // 
            this.fKReservaCliente2BindingSource.DataMember = "FK_Reserva_Cliente2";
            this.fKReservaCliente2BindingSource.DataSource = this.clienteBindingSource;
            // 
            // reserva1TableAdapter
            // 
            this.reserva1TableAdapter.ClearBeforeFill = true;
            // 
            // fKPagamentoClienteBindingSource1
            // 
            this.fKPagamentoClienteBindingSource1.DataMember = "FK_Pagamento_Cliente";
            this.fKPagamentoClienteBindingSource1.DataSource = this.clienteBindingSource;
            // 
            // pagamento1TableAdapter
            // 
            this.pagamento1TableAdapter.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 354);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MediumBlue;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form5";
            this.Text = "Pesquisar";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPagamentoCliente2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPagamentoReservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPagamentoClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKReservaCliente2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKReservaClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKReservaCliente2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPagamentoClienteBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private Database1DataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanascDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigopostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoDataGridViewImageColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource fKPagamentoClienteBindingSource;
        private Database1DataSetTableAdapters.PagamentoTableAdapter pagamentoTableAdapter;
        private System.Windows.Forms.BindingSource fKReservaClienteBindingSource;
        private Database1DataSetTableAdapters.ReservaTableAdapter reservaTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource fKPagamentoReservaBindingSource;
        private System.Windows.Forms.BindingSource reservaBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource fKReservaCliente2BindingSource;
        private Database1DataSetTableAdapters.Reserva1TableAdapter reserva1TableAdapter;
        private System.Windows.Forms.BindingSource fKPagamentoClienteBindingSource1;
        private System.Windows.Forms.BindingSource fKPagamentoCliente2BindingSource;
        private Database1DataSetTableAdapters.Pagamento1TableAdapter pagamento1TableAdapter;
        private System.Windows.Forms.BindingSource fKReservaCliente2BindingSource1;
    }
}