namespace LP_projecto_final_Emanuel
{
    partial class Form16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form16));
            System.Windows.Forms.Label id_pagamentoLabel;
            System.Windows.Forms.Label id_reservaLabel;
            System.Windows.Forms.Label id_clienteLabel;
            System.Windows.Forms.Label id_metodo_pagamentoLabel;
            System.Windows.Forms.Label valor_pagamentoLabel;
            System.Windows.Forms.Label comentariosLabel;
            System.Windows.Forms.Label dataLabel;
            this.database1DataSet = new LP_projecto_final_Emanuel.Database1DataSet();
            this.pagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pagamentoTableAdapter = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.PagamentoTableAdapter();
            this.tableAdapterManager = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.TableAdapterManager();
            this.pagamentoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.pagamentoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_pagamentoTextBox = new System.Windows.Forms.TextBox();
            this.id_reservaTextBox = new System.Windows.Forms.TextBox();
            this.id_clienteTextBox = new System.Windows.Forms.TextBox();
            this.id_metodo_pagamentoTextBox = new System.Windows.Forms.TextBox();
            this.valor_pagamentoTextBox = new System.Windows.Forms.TextBox();
            this.comentariosTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            id_pagamentoLabel = new System.Windows.Forms.Label();
            id_reservaLabel = new System.Windows.Forms.Label();
            id_clienteLabel = new System.Windows.Forms.Label();
            id_metodo_pagamentoLabel = new System.Windows.Forms.Label();
            valor_pagamentoLabel = new System.Windows.Forms.Label();
            comentariosLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingNavigator)).BeginInit();
            this.pagamentoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pagamentoBindingSource
            // 
            this.pagamentoBindingSource.DataMember = "Pagamento";
            this.pagamentoBindingSource.DataSource = this.database1DataSet;
            // 
            // pagamentoTableAdapter
            // 
            this.pagamentoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.codigo_postalTableAdapter = null;
            this.tableAdapterManager.PagamentoTableAdapter = this.pagamentoTableAdapter;
            this.tableAdapterManager.Preço_do_quartoTableAdapter = null;
            this.tableAdapterManager.Quarto1TableAdapter = null;
            this.tableAdapterManager.QuartoTableAdapter = null;
            this.tableAdapterManager.Reserva_quartosTableAdapter = null;
            this.tableAdapterManager.ReservaTableAdapter = null;
            this.tableAdapterManager.Tipos_de_pagamentoTableAdapter = null;
            this.tableAdapterManager.Tipos_de_quartosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LP_projecto_final_Emanuel.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pagamentoBindingNavigator
            // 
            this.pagamentoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pagamentoBindingNavigator.BindingSource = this.pagamentoBindingSource;
            this.pagamentoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pagamentoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pagamentoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pagamentoBindingNavigatorSaveItem});
            this.pagamentoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pagamentoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pagamentoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pagamentoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pagamentoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pagamentoBindingNavigator.Name = "pagamentoBindingNavigator";
            this.pagamentoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pagamentoBindingNavigator.Size = new System.Drawing.Size(593, 25);
            this.pagamentoBindingNavigator.TabIndex = 0;
            this.pagamentoBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // pagamentoBindingNavigatorSaveItem
            // 
            this.pagamentoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pagamentoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pagamentoBindingNavigatorSaveItem.Image")));
            this.pagamentoBindingNavigatorSaveItem.Name = "pagamentoBindingNavigatorSaveItem";
            this.pagamentoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.pagamentoBindingNavigatorSaveItem.Text = "Save Data";
            this.pagamentoBindingNavigatorSaveItem.Click += new System.EventHandler(this.pagamentoBindingNavigatorSaveItem_Click);
            // 
            // id_pagamentoLabel
            // 
            id_pagamentoLabel.AutoSize = true;
            id_pagamentoLabel.Location = new System.Drawing.Point(20, 99);
            id_pagamentoLabel.Name = "id_pagamentoLabel";
            id_pagamentoLabel.Size = new System.Drawing.Size(74, 13);
            id_pagamentoLabel.TabIndex = 1;
            id_pagamentoLabel.Text = "id pagamento:";
            // 
            // id_pagamentoTextBox
            // 
            this.id_pagamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamentoBindingSource, "id_pagamento", true));
            this.id_pagamentoTextBox.Location = new System.Drawing.Point(138, 96);
            this.id_pagamentoTextBox.Name = "id_pagamentoTextBox";
            this.id_pagamentoTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_pagamentoTextBox.TabIndex = 2;
            // 
            // id_reservaLabel
            // 
            id_reservaLabel.AutoSize = true;
            id_reservaLabel.Location = new System.Drawing.Point(20, 125);
            id_reservaLabel.Name = "id_reservaLabel";
            id_reservaLabel.Size = new System.Drawing.Size(56, 13);
            id_reservaLabel.TabIndex = 3;
            id_reservaLabel.Text = "id reserva:";
            // 
            // id_reservaTextBox
            // 
            this.id_reservaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamentoBindingSource, "id_reserva", true));
            this.id_reservaTextBox.Location = new System.Drawing.Point(138, 122);
            this.id_reservaTextBox.Name = "id_reservaTextBox";
            this.id_reservaTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_reservaTextBox.TabIndex = 4;
            // 
            // id_clienteLabel
            // 
            id_clienteLabel.AutoSize = true;
            id_clienteLabel.Location = new System.Drawing.Point(20, 151);
            id_clienteLabel.Name = "id_clienteLabel";
            id_clienteLabel.Size = new System.Drawing.Size(52, 13);
            id_clienteLabel.TabIndex = 5;
            id_clienteLabel.Text = "id cliente:";
            // 
            // id_clienteTextBox
            // 
            this.id_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamentoBindingSource, "id_cliente", true));
            this.id_clienteTextBox.Location = new System.Drawing.Point(138, 148);
            this.id_clienteTextBox.Name = "id_clienteTextBox";
            this.id_clienteTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_clienteTextBox.TabIndex = 6;
            // 
            // id_metodo_pagamentoLabel
            // 
            id_metodo_pagamentoLabel.AutoSize = true;
            id_metodo_pagamentoLabel.Location = new System.Drawing.Point(20, 177);
            id_metodo_pagamentoLabel.Name = "id_metodo_pagamentoLabel";
            id_metodo_pagamentoLabel.Size = new System.Drawing.Size(112, 13);
            id_metodo_pagamentoLabel.TabIndex = 7;
            id_metodo_pagamentoLabel.Text = "id metodo pagamento:";
            // 
            // id_metodo_pagamentoTextBox
            // 
            this.id_metodo_pagamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamentoBindingSource, "id_metodo_pagamento", true));
            this.id_metodo_pagamentoTextBox.Location = new System.Drawing.Point(138, 174);
            this.id_metodo_pagamentoTextBox.Name = "id_metodo_pagamentoTextBox";
            this.id_metodo_pagamentoTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_metodo_pagamentoTextBox.TabIndex = 8;
            // 
            // valor_pagamentoLabel
            // 
            valor_pagamentoLabel.AutoSize = true;
            valor_pagamentoLabel.Location = new System.Drawing.Point(20, 203);
            valor_pagamentoLabel.Name = "valor_pagamentoLabel";
            valor_pagamentoLabel.Size = new System.Drawing.Size(89, 13);
            valor_pagamentoLabel.TabIndex = 9;
            valor_pagamentoLabel.Text = "valor pagamento:";
            // 
            // valor_pagamentoTextBox
            // 
            this.valor_pagamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamentoBindingSource, "valor_pagamento", true));
            this.valor_pagamentoTextBox.Location = new System.Drawing.Point(138, 200);
            this.valor_pagamentoTextBox.Name = "valor_pagamentoTextBox";
            this.valor_pagamentoTextBox.Size = new System.Drawing.Size(200, 20);
            this.valor_pagamentoTextBox.TabIndex = 10;
            // 
            // comentariosLabel
            // 
            comentariosLabel.AutoSize = true;
            comentariosLabel.Location = new System.Drawing.Point(20, 229);
            comentariosLabel.Name = "comentariosLabel";
            comentariosLabel.Size = new System.Drawing.Size(67, 13);
            comentariosLabel.TabIndex = 11;
            comentariosLabel.Text = "comentarios:";
            // 
            // comentariosTextBox
            // 
            this.comentariosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamentoBindingSource, "comentarios", true));
            this.comentariosTextBox.Location = new System.Drawing.Point(138, 226);
            this.comentariosTextBox.Name = "comentariosTextBox";
            this.comentariosTextBox.Size = new System.Drawing.Size(200, 20);
            this.comentariosTextBox.TabIndex = 12;
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(20, 256);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(31, 13);
            dataLabel.TabIndex = 13;
            dataLabel.Text = "data:";
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pagamentoBindingSource, "data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(138, 252);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataDateTimePicker.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Inserir Pagamento";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 334);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(id_pagamentoLabel);
            this.Controls.Add(this.id_pagamentoTextBox);
            this.Controls.Add(id_reservaLabel);
            this.Controls.Add(this.id_reservaTextBox);
            this.Controls.Add(id_clienteLabel);
            this.Controls.Add(this.id_clienteTextBox);
            this.Controls.Add(id_metodo_pagamentoLabel);
            this.Controls.Add(this.id_metodo_pagamentoTextBox);
            this.Controls.Add(valor_pagamentoLabel);
            this.Controls.Add(this.valor_pagamentoTextBox);
            this.Controls.Add(comentariosLabel);
            this.Controls.Add(this.comentariosTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(this.pagamentoBindingNavigator);
            this.Name = "Form16";
            this.Text = "Form16";
            this.Load += new System.EventHandler(this.Form16_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingNavigator)).EndInit();
            this.pagamentoBindingNavigator.ResumeLayout(false);
            this.pagamentoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource pagamentoBindingSource;
        private Database1DataSetTableAdapters.PagamentoTableAdapter pagamentoTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pagamentoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pagamentoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_pagamentoTextBox;
        private System.Windows.Forms.TextBox id_reservaTextBox;
        private System.Windows.Forms.TextBox id_clienteTextBox;
        private System.Windows.Forms.TextBox id_metodo_pagamentoTextBox;
        private System.Windows.Forms.TextBox valor_pagamentoTextBox;
        private System.Windows.Forms.TextBox comentariosTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}