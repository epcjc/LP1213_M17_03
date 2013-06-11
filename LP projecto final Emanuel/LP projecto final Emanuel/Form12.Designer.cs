namespace LP_projecto_final_Emanuel
{
    partial class Form12
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
            System.Windows.Forms.Label id_preco_quartoLabel;
            System.Windows.Forms.Label preco_quartoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.database1DataSet = new LP_projecto_final_Emanuel.Database1DataSet();
            this.preço_do_quartoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.preço_do_quartoTableAdapter = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.Preço_do_quartoTableAdapter();
            this.tableAdapterManager = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.TableAdapterManager();
            this.preço_do_quartoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.preço_do_quartoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_preco_quartoTextBox = new System.Windows.Forms.TextBox();
            this.preco_quartoTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.quartoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quartoTableAdapter = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.QuartoTableAdapter();
            this.quarto1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quarto1TableAdapter = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.Quarto1TableAdapter();
            id_preco_quartoLabel = new System.Windows.Forms.Label();
            preco_quartoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preço_do_quartoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preço_do_quartoBindingNavigator)).BeginInit();
            this.preço_do_quartoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quartoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quarto1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_preco_quartoLabel
            // 
            id_preco_quartoLabel.AutoSize = true;
            id_preco_quartoLabel.Location = new System.Drawing.Point(27, 101);
            id_preco_quartoLabel.Name = "id_preco_quartoLabel";
            id_preco_quartoLabel.Size = new System.Drawing.Size(81, 13);
            id_preco_quartoLabel.TabIndex = 1;
            id_preco_quartoLabel.Text = "id preco quarto:";
            // 
            // preco_quartoLabel
            // 
            preco_quartoLabel.AutoSize = true;
            preco_quartoLabel.Location = new System.Drawing.Point(27, 127);
            preco_quartoLabel.Name = "preco_quartoLabel";
            preco_quartoLabel.Size = new System.Drawing.Size(70, 13);
            preco_quartoLabel.TabIndex = 3;
            preco_quartoLabel.Text = "preco quarto:";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // preço_do_quartoBindingSource
            // 
            this.preço_do_quartoBindingSource.DataMember = "Preço do quarto";
            this.preço_do_quartoBindingSource.DataSource = this.database1DataSet;
            // 
            // preço_do_quartoTableAdapter
            // 
            this.preço_do_quartoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.codigo_postalTableAdapter = null;
            this.tableAdapterManager.PagamentoTableAdapter = null;
            this.tableAdapterManager.Preço_do_quartoTableAdapter = this.preço_do_quartoTableAdapter;
            this.tableAdapterManager.Quarto1TableAdapter = null;
            this.tableAdapterManager.QuartoTableAdapter = null;
            this.tableAdapterManager.Reserva_quartosTableAdapter = null;
            this.tableAdapterManager.ReservaTableAdapter = null;
            this.tableAdapterManager.Tipos_de_pagamentoTableAdapter = null;
            this.tableAdapterManager.Tipos_de_quartosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LP_projecto_final_Emanuel.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // preço_do_quartoBindingNavigator
            // 
            this.preço_do_quartoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.preço_do_quartoBindingNavigator.BindingSource = this.preço_do_quartoBindingSource;
            this.preço_do_quartoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.preço_do_quartoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.preço_do_quartoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.preço_do_quartoBindingNavigatorSaveItem});
            this.preço_do_quartoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.preço_do_quartoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.preço_do_quartoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.preço_do_quartoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.preço_do_quartoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.preço_do_quartoBindingNavigator.Name = "preço_do_quartoBindingNavigator";
            this.preço_do_quartoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.preço_do_quartoBindingNavigator.Size = new System.Drawing.Size(471, 25);
            this.preço_do_quartoBindingNavigator.TabIndex = 0;
            this.preço_do_quartoBindingNavigator.Text = "bindingNavigator1";
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
            // preço_do_quartoBindingNavigatorSaveItem
            // 
            this.preço_do_quartoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.preço_do_quartoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("preço_do_quartoBindingNavigatorSaveItem.Image")));
            this.preço_do_quartoBindingNavigatorSaveItem.Name = "preço_do_quartoBindingNavigatorSaveItem";
            this.preço_do_quartoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.preço_do_quartoBindingNavigatorSaveItem.Text = "Save Data";
            this.preço_do_quartoBindingNavigatorSaveItem.Click += new System.EventHandler(this.preço_do_quartoBindingNavigatorSaveItem_Click);
            // 
            // id_preco_quartoTextBox
            // 
            this.id_preco_quartoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.preço_do_quartoBindingSource, "id_preco_quarto", true));
            this.id_preco_quartoTextBox.Location = new System.Drawing.Point(114, 98);
            this.id_preco_quartoTextBox.Name = "id_preco_quartoTextBox";
            this.id_preco_quartoTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_preco_quartoTextBox.TabIndex = 2;
            // 
            // preco_quartoTextBox
            // 
            this.preco_quartoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.preço_do_quartoBindingSource, "preco_quarto", true));
            this.preco_quartoTextBox.Location = new System.Drawing.Point(114, 124);
            this.preco_quartoTextBox.Name = "preco_quartoTextBox";
            this.preco_quartoTextBox.Size = new System.Drawing.Size(100, 20);
            this.preco_quartoTextBox.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.quartoBindingSource;
            this.listBox1.DisplayMember = "tipo_quarto";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(299, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 173);
            this.listBox1.TabIndex = 5;
            this.listBox1.ValueMember = "andar_quarto";
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
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 460);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(id_preco_quartoLabel);
            this.Controls.Add(this.id_preco_quartoTextBox);
            this.Controls.Add(preco_quartoLabel);
            this.Controls.Add(this.preco_quartoTextBox);
            this.Controls.Add(this.preço_do_quartoBindingNavigator);
            this.Name = "Form12";
            this.Text = "Form12";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preço_do_quartoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preço_do_quartoBindingNavigator)).EndInit();
            this.preço_do_quartoBindingNavigator.ResumeLayout(false);
            this.preço_do_quartoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quartoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quarto1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource preço_do_quartoBindingSource;
        private Database1DataSetTableAdapters.Preço_do_quartoTableAdapter preço_do_quartoTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator preço_do_quartoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton preço_do_quartoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_preco_quartoTextBox;
        private System.Windows.Forms.TextBox preco_quartoTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource quartoBindingSource;
        private Database1DataSetTableAdapters.QuartoTableAdapter quartoTableAdapter;
        private System.Windows.Forms.BindingSource quarto1BindingSource;
        private Database1DataSetTableAdapters.Quarto1TableAdapter quarto1TableAdapter;
    }
}