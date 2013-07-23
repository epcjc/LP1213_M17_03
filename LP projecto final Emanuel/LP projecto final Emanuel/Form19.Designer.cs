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
            System.Windows.Forms.Label id_quartoLabel;
            System.Windows.Forms.Label preco_quartoLabel;
            System.Windows.Forms.Label andar_quartoLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label id_tipoLabel;
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.database1DataSet = new LP_projecto_final_Emanuel.Database1DataSet();
            this.quartoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quartoTableAdapter = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.QuartoTableAdapter();
            this.tableAdapterManager = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.TableAdapterManager();
            this.quartoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.quartoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_quartoTextBox = new System.Windows.Forms.TextBox();
            this.preco_quartoTextBox = new System.Windows.Forms.TextBox();
            this.andar_quartoTextBox = new System.Windows.Forms.TextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.id_tipoTextBox = new System.Windows.Forms.TextBox();
            id_quartoLabel = new System.Windows.Forms.Label();
            preco_quartoLabel = new System.Windows.Forms.Label();
            andar_quartoLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            id_tipoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartoBindingNavigator)).BeginInit();
            this.quartoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PapayaWhip;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Location = new System.Drawing.Point(329, 345);
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
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.codigo_postalTableAdapter = null;
            this.tableAdapterManager.Pagamento1TableAdapter = null;
            this.tableAdapterManager.PagamentoTableAdapter = null;
          
            this.tableAdapterManager.Preço_do_quartoTableAdapter = null;
            this.tableAdapterManager.Quarto1TableAdapter = null;
            this.tableAdapterManager.Quarto2TableAdapter = null;
            this.tableAdapterManager.QuartoTableAdapter = this.quartoTableAdapter;
            this.tableAdapterManager.Reserva_quartos1TableAdapter = null;
            this.tableAdapterManager.Reserva_quartosTableAdapter = null;
            this.tableAdapterManager.Reserva1TableAdapter = null;
            this.tableAdapterManager.ReservaTableAdapter = null;
            this.tableAdapterManager.Tipos_de_pagamento1TableAdapter = null;
            this.tableAdapterManager.Tipos_de_pagamentoTableAdapter = null;
            this.tableAdapterManager.Tipos_de_quartosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LP_projecto_final_Emanuel.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilizadoresTableAdapter = null;
            // 
            // quartoBindingNavigator
            // 
            this.quartoBindingNavigator.AddNewItem = null;
            this.quartoBindingNavigator.BindingSource = this.quartoBindingSource;
            this.quartoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.quartoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.quartoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.quartoBindingNavigatorSaveItem});
            this.quartoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.quartoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.quartoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.quartoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.quartoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.quartoBindingNavigator.Name = "quartoBindingNavigator";
            this.quartoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.quartoBindingNavigator.Size = new System.Drawing.Size(696, 25);
            this.quartoBindingNavigator.TabIndex = 7;
            this.quartoBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // quartoBindingNavigatorSaveItem
            // 
            this.quartoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.quartoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("quartoBindingNavigatorSaveItem.Image")));
            this.quartoBindingNavigatorSaveItem.Name = "quartoBindingNavigatorSaveItem";
            this.quartoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.quartoBindingNavigatorSaveItem.Text = "Save Data";
            this.quartoBindingNavigatorSaveItem.Click += new System.EventHandler(this.quartoBindingNavigatorSaveItem_Click_1);
            // 
            // id_quartoLabel
            // 
            id_quartoLabel.AutoSize = true;
            id_quartoLabel.Location = new System.Drawing.Point(48, 84);
            id_quartoLabel.Name = "id_quartoLabel";
            id_quartoLabel.Size = new System.Drawing.Size(61, 13);
            id_quartoLabel.TabIndex = 7;
            id_quartoLabel.Text = "id quarto:";
            // 
            // id_quartoTextBox
            // 
            this.id_quartoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartoBindingSource, "id_quarto", true));
            this.id_quartoTextBox.Location = new System.Drawing.Point(137, 81);
            this.id_quartoTextBox.Name = "id_quartoTextBox";
            this.id_quartoTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_quartoTextBox.TabIndex = 8;
            // 
            // preco_quartoLabel
            // 
            preco_quartoLabel.AutoSize = true;
            preco_quartoLabel.Location = new System.Drawing.Point(48, 110);
            preco_quartoLabel.Name = "preco_quartoLabel";
            preco_quartoLabel.Size = new System.Drawing.Size(83, 13);
            preco_quartoLabel.TabIndex = 9;
            preco_quartoLabel.Text = "preco quarto:";
            // 
            // preco_quartoTextBox
            // 
            this.preco_quartoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartoBindingSource, "preco_quarto", true));
            this.preco_quartoTextBox.Location = new System.Drawing.Point(137, 107);
            this.preco_quartoTextBox.Name = "preco_quartoTextBox";
            this.preco_quartoTextBox.Size = new System.Drawing.Size(100, 20);
            this.preco_quartoTextBox.TabIndex = 10;
            // 
            // andar_quartoLabel
            // 
            andar_quartoLabel.AutoSize = true;
            andar_quartoLabel.Location = new System.Drawing.Point(48, 136);
            andar_quartoLabel.Name = "andar_quartoLabel";
            andar_quartoLabel.Size = new System.Drawing.Size(83, 13);
            andar_quartoLabel.TabIndex = 11;
            andar_quartoLabel.Text = "andar quarto:";
            // 
            // andar_quartoTextBox
            // 
            this.andar_quartoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartoBindingSource, "andar_quarto", true));
            this.andar_quartoTextBox.Location = new System.Drawing.Point(137, 133);
            this.andar_quartoTextBox.Name = "andar_quartoTextBox";
            this.andar_quartoTextBox.Size = new System.Drawing.Size(100, 20);
            this.andar_quartoTextBox.TabIndex = 12;
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(48, 162);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(49, 13);
            estadoLabel.TabIndex = 13;
            estadoLabel.Text = "estado:";
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartoBindingSource, "estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(137, 159);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(100, 20);
            this.estadoTextBox.TabIndex = 14;
            // 
            // id_tipoLabel
            // 
            id_tipoLabel.AutoSize = true;
            id_tipoLabel.Location = new System.Drawing.Point(48, 188);
            id_tipoLabel.Name = "id_tipoLabel";
            id_tipoLabel.Size = new System.Drawing.Size(46, 13);
            id_tipoLabel.TabIndex = 15;
            id_tipoLabel.Text = "id tipo:";
            // 
            // id_tipoTextBox
            // 
            this.id_tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartoBindingSource, "id_tipo", true));
            this.id_tipoTextBox.Location = new System.Drawing.Point(137, 185);
            this.id_tipoTextBox.Name = "id_tipoTextBox";
            this.id_tipoTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_tipoTextBox.TabIndex = 16;
            // 
            // Form19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(696, 388);
            this.Controls.Add(id_quartoLabel);
            this.Controls.Add(this.id_quartoTextBox);
            this.Controls.Add(preco_quartoLabel);
            this.Controls.Add(this.preco_quartoTextBox);
            this.Controls.Add(andar_quartoLabel);
            this.Controls.Add(this.andar_quartoTextBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoTextBox);
            this.Controls.Add(id_tipoLabel);
            this.Controls.Add(this.id_tipoTextBox);
            this.Controls.Add(this.quartoBindingNavigator);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MediumBlue;
            this.Name = "Form19";
            this.Text = "Lista dos Quartos";
            this.Load += new System.EventHandler(this.Form19_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartoBindingNavigator)).EndInit();
            this.quartoBindingNavigator.ResumeLayout(false);
            this.quartoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource quartoBindingSource;
        private Database1DataSetTableAdapters.QuartoTableAdapter quartoTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator quartoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton quartoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_quartoTextBox;
        private System.Windows.Forms.TextBox preco_quartoTextBox;
        private System.Windows.Forms.TextBox andar_quartoTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.TextBox id_tipoTextBox;
    }
}