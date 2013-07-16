namespace LP_projecto_final_Emanuel
{
    partial class Form19
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form19));
            this.database1DataSet = new LP_projecto_final_Emanuel.Database1DataSet();
            this.quarto2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quarto2TableAdapter = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.Quarto2TableAdapter();
            this.tableAdapterManager = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.TableAdapterManager();
            this.reserva_quartosTableAdapter = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.Reserva_quartosTableAdapter();
            this.quarto2BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quarto2BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.reserva_quartosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reserva_quartosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKReservaQuartosQuarto5BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idquartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoquartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoquartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.andarquartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagemDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.quarto2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quartoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quartoTableAdapter = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.QuartoTableAdapter();
            this.fKReservaQuartosQuartoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKReservaQuartosQuarto5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reserva_quartos1TableAdapter = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.Reserva_quartos1TableAdapter();
            this.fKReservaQuartosQuarto2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quarto2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quarto2BindingNavigator)).BeginInit();
            this.quarto2BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reserva_quartosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserva_quartosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKReservaQuartosQuarto5BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quarto2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKReservaQuartosQuartoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKReservaQuartosQuarto5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKReservaQuartosQuarto2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.Quarto2TableAdapter = this.quarto2TableAdapter;
            this.tableAdapterManager.QuartoTableAdapter = null;
            this.tableAdapterManager.Reserva_quartos1TableAdapter = null;
            this.tableAdapterManager.Reserva_quartosTableAdapter = this.reserva_quartosTableAdapter;
            this.tableAdapterManager.Reserva1TableAdapter = null;
            this.tableAdapterManager.ReservaTableAdapter = null;
            this.tableAdapterManager.Tipos_de_pagamento1TableAdapter = null;
            this.tableAdapterManager.Tipos_de_pagamentoTableAdapter = null;
            this.tableAdapterManager.Tipos_de_quartosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LP_projecto_final_Emanuel.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilizadoresTableAdapter = null;
            // 
            // reserva_quartosTableAdapter
            // 
            this.reserva_quartosTableAdapter.ClearBeforeFill = true;
            // 
            // quarto2BindingNavigator
            // 
            this.quarto2BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.quarto2BindingNavigator.BindingSource = this.quarto2BindingSource;
            this.quarto2BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.quarto2BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.quarto2BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.quarto2BindingNavigatorSaveItem});
            this.quarto2BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.quarto2BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.quarto2BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.quarto2BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.quarto2BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.quarto2BindingNavigator.Name = "quarto2BindingNavigator";
            this.quarto2BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.quarto2BindingNavigator.Size = new System.Drawing.Size(696, 25);
            this.quarto2BindingNavigator.TabIndex = 0;
            this.quarto2BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // quarto2BindingNavigatorSaveItem
            // 
            this.quarto2BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.quarto2BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("quarto2BindingNavigatorSaveItem.Image")));
            this.quarto2BindingNavigatorSaveItem.Name = "quarto2BindingNavigatorSaveItem";
            this.quarto2BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.quarto2BindingNavigatorSaveItem.Text = "Save Data";
            this.quarto2BindingNavigatorSaveItem.Click += new System.EventHandler(this.quarto2BindingNavigatorSaveItem_Click);
            // 
            // reserva_quartosBindingSource
            // 
            this.reserva_quartosBindingSource.DataMember = "Reserva quartos";
            this.reserva_quartosBindingSource.DataSource = this.database1DataSet;
            // 
            // reserva_quartosDataGridView
            // 
            this.reserva_quartosDataGridView.AutoGenerateColumns = false;
            this.reserva_quartosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reserva_quartosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.reserva_quartosDataGridView.DataSource = this.fKReservaQuartosQuarto5BindingSource1;
            this.reserva_quartosDataGridView.Location = new System.Drawing.Point(72, 236);
            this.reserva_quartosDataGridView.Name = "reserva_quartosDataGridView";
            this.reserva_quartosDataGridView.Size = new System.Drawing.Size(248, 94);
            this.reserva_quartosDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Id_reserva_quarto";
            this.dataGridViewTextBoxColumn5.HeaderText = "Id_reserva_quarto";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_quartos";
            this.dataGridViewTextBoxColumn6.HeaderText = "id_quartos";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // fKReservaQuartosQuarto5BindingSource1
            // 
            this.fKReservaQuartosQuarto5BindingSource1.DataMember = "FK_Reserva quartos_Quarto5";
            this.fKReservaQuartosQuarto5BindingSource1.DataSource = this.quarto2BindingSource;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PapayaWhip;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MediumBlue;
            this.button1.Location = new System.Drawing.Point(72, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Inserir Novo Quarto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PapayaWhip;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(220, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Eliminar Quarto";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PapayaWhip;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Location = new System.Drawing.Point(381, 345);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Ajuda";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PapayaWhip;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.Location = new System.Drawing.Point(518, 345);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Ir para Menu";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(261, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lista dos Quartos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idquartoDataGridViewTextBoxColumn,
            this.tipoquartoDataGridViewTextBoxColumn,
            this.precoquartoDataGridViewTextBoxColumn,
            this.andarquartoDataGridViewTextBoxColumn,
            this.imagemDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.quarto2BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(72, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // idquartoDataGridViewTextBoxColumn
            // 
            this.idquartoDataGridViewTextBoxColumn.DataPropertyName = "id_quarto";
            this.idquartoDataGridViewTextBoxColumn.HeaderText = "id_quarto";
            this.idquartoDataGridViewTextBoxColumn.Name = "idquartoDataGridViewTextBoxColumn";
            this.idquartoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoquartoDataGridViewTextBoxColumn
            // 
            this.tipoquartoDataGridViewTextBoxColumn.DataPropertyName = "tipo_quarto";
            this.tipoquartoDataGridViewTextBoxColumn.HeaderText = "tipo_quarto";
            this.tipoquartoDataGridViewTextBoxColumn.Name = "tipoquartoDataGridViewTextBoxColumn";
            // 
            // precoquartoDataGridViewTextBoxColumn
            // 
            this.precoquartoDataGridViewTextBoxColumn.DataPropertyName = "preco_quarto";
            this.precoquartoDataGridViewTextBoxColumn.HeaderText = "preco_quarto";
            this.precoquartoDataGridViewTextBoxColumn.Name = "precoquartoDataGridViewTextBoxColumn";
            // 
            // andarquartoDataGridViewTextBoxColumn
            // 
            this.andarquartoDataGridViewTextBoxColumn.DataPropertyName = "andar_quarto";
            this.andarquartoDataGridViewTextBoxColumn.HeaderText = "andar_quarto";
            this.andarquartoDataGridViewTextBoxColumn.Name = "andarquartoDataGridViewTextBoxColumn";
            // 
            // imagemDataGridViewImageColumn
            // 
            this.imagemDataGridViewImageColumn.DataPropertyName = "imagem";
            this.imagemDataGridViewImageColumn.HeaderText = "imagem";
            this.imagemDataGridViewImageColumn.Name = "imagemDataGridViewImageColumn";
            // 
            // quarto2BindingSource1
            // 
            this.quarto2BindingSource1.DataMember = "Quarto2";
            this.quarto2BindingSource1.DataSource = this.database1DataSet;
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
            // fKReservaQuartosQuartoBindingSource
            // 
            this.fKReservaQuartosQuartoBindingSource.DataMember = "FK_Reserva quartos_Quarto";
            this.fKReservaQuartosQuartoBindingSource.DataSource = this.quartoBindingSource;
            // 
            // fKReservaQuartosQuarto5BindingSource
            // 
            this.fKReservaQuartosQuarto5BindingSource.DataMember = "FK_Reserva quartos_Quarto5";
            this.fKReservaQuartosQuarto5BindingSource.DataSource = this.quarto2BindingSource;
            // 
            // reserva_quartos1TableAdapter
            // 
            this.reserva_quartos1TableAdapter.ClearBeforeFill = true;
            // 
            // fKReservaQuartosQuarto2BindingSource
            // 
            this.fKReservaQuartosQuarto2BindingSource.DataMember = "FK_Reserva quartos_Quarto2";
            this.fKReservaQuartosQuarto2BindingSource.DataSource = this.quarto2BindingSource;
            // 
            // Form19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(696, 374);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reserva_quartosDataGridView);
            this.Controls.Add(this.quarto2BindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MediumBlue;
            this.Name = "Form19";
            this.Text = "Form19";
            this.Load += new System.EventHandler(this.Form19_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quarto2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quarto2BindingNavigator)).EndInit();
            this.quarto2BindingNavigator.ResumeLayout(false);
            this.quarto2BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reserva_quartosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserva_quartosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKReservaQuartosQuarto5BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quarto2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKReservaQuartosQuartoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKReservaQuartosQuarto5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKReservaQuartosQuarto2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource quarto2BindingSource;
        private Database1DataSetTableAdapters.Quarto2TableAdapter quarto2TableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator quarto2BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton quarto2BindingNavigatorSaveItem;
        private Database1DataSetTableAdapters.Reserva_quartosTableAdapter reserva_quartosTableAdapter;
        private System.Windows.Forms.BindingSource reserva_quartosBindingSource;
        private System.Windows.Forms.DataGridView reserva_quartosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idquartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoquartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoquartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn andarquartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagemDataGridViewImageColumn;
        private System.Windows.Forms.BindingSource quarto2BindingSource1;
        private System.Windows.Forms.BindingSource quartoBindingSource;
        private Database1DataSetTableAdapters.QuartoTableAdapter quartoTableAdapter;
        private System.Windows.Forms.BindingSource fKReservaQuartosQuartoBindingSource;
        private System.Windows.Forms.BindingSource fKReservaQuartosQuarto5BindingSource;
        private Database1DataSetTableAdapters.Reserva_quartos1TableAdapter reserva_quartos1TableAdapter;
        private System.Windows.Forms.BindingSource fKReservaQuartosQuarto2BindingSource;
        private System.Windows.Forms.BindingSource fKReservaQuartosQuarto5BindingSource1;
    }
}