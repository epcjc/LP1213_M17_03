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
            System.Windows.Forms.Label id_reservaLabel;
            System.Windows.Forms.Label id_clienteLabel;
            System.Windows.Forms.Label data_reservaLabel;
            System.Windows.Forms.Label hora_reservaLabel;
            System.Windows.Forms.Label data_inicioLabel;
            System.Windows.Forms.Label data_fimLabel;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label comentariosLabel;
            System.Windows.Forms.Label estadoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.database1DataSet = new LP_projecto_final_Emanuel.Database1DataSet();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservaTableAdapter = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.ReservaTableAdapter();
            this.tableAdapterManager = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.TableAdapterManager();
            this.reservaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.reservaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_reservaTextBox = new System.Windows.Forms.TextBox();
            this.id_clienteTextBox = new System.Windows.Forms.TextBox();
            this.data_reservaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hora_reservaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.data_inicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.data_fimDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.comentariosTextBox = new System.Windows.Forms.TextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            id_reservaLabel = new System.Windows.Forms.Label();
            id_clienteLabel = new System.Windows.Forms.Label();
            data_reservaLabel = new System.Windows.Forms.Label();
            hora_reservaLabel = new System.Windows.Forms.Label();
            data_inicioLabel = new System.Windows.Forms.Label();
            data_fimLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            comentariosLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingNavigator)).BeginInit();
            this.reservaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_reservaLabel
            // 
            id_reservaLabel.AutoSize = true;
            id_reservaLabel.Location = new System.Drawing.Point(173, 40);
            id_reservaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            id_reservaLabel.Name = "id_reservaLabel";
            id_reservaLabel.Size = new System.Drawing.Size(74, 15);
            id_reservaLabel.TabIndex = 1;
            id_reservaLabel.Text = "id reserva:";
            // 
            // id_clienteLabel
            // 
            id_clienteLabel.AutoSize = true;
            id_clienteLabel.Location = new System.Drawing.Point(173, 70);
            id_clienteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            id_clienteLabel.Name = "id_clienteLabel";
            id_clienteLabel.Size = new System.Drawing.Size(70, 15);
            id_clienteLabel.TabIndex = 3;
            id_clienteLabel.Text = "id cliente:";
            // 
            // data_reservaLabel
            // 
            data_reservaLabel.AutoSize = true;
            data_reservaLabel.Location = new System.Drawing.Point(173, 102);
            data_reservaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            data_reservaLabel.Name = "data_reservaLabel";
            data_reservaLabel.Size = new System.Drawing.Size(90, 15);
            data_reservaLabel.TabIndex = 5;
            data_reservaLabel.Text = "data reserva:";
            // 
            // hora_reservaLabel
            // 
            hora_reservaLabel.AutoSize = true;
            hora_reservaLabel.Location = new System.Drawing.Point(173, 132);
            hora_reservaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            hora_reservaLabel.Name = "hora_reservaLabel";
            hora_reservaLabel.Size = new System.Drawing.Size(91, 15);
            hora_reservaLabel.TabIndex = 7;
            hora_reservaLabel.Text = "hora reserva:";
            // 
            // data_inicioLabel
            // 
            data_inicioLabel.AutoSize = true;
            data_inicioLabel.Location = new System.Drawing.Point(173, 162);
            data_inicioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            data_inicioLabel.Name = "data_inicioLabel";
            data_inicioLabel.Size = new System.Drawing.Size(80, 15);
            data_inicioLabel.TabIndex = 9;
            data_inicioLabel.Text = "Data inicio:";
            // 
            // data_fimLabel
            // 
            data_fimLabel.AutoSize = true;
            data_fimLabel.Location = new System.Drawing.Point(173, 192);
            data_fimLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            data_fimLabel.Name = "data_fimLabel";
            data_fimLabel.Size = new System.Drawing.Size(65, 15);
            data_fimLabel.TabIndex = 11;
            data_fimLabel.Text = "Data fim:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(173, 220);
            totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(43, 15);
            totalLabel.TabIndex = 13;
            totalLabel.Text = "Total:";
            // 
            // comentariosLabel
            // 
            comentariosLabel.AutoSize = true;
            comentariosLabel.Location = new System.Drawing.Point(173, 250);
            comentariosLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            comentariosLabel.Name = "comentariosLabel";
            comentariosLabel.Size = new System.Drawing.Size(90, 15);
            comentariosLabel.TabIndex = 15;
            comentariosLabel.Text = "comentarios:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(173, 280);
            estadoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(54, 15);
            estadoLabel.TabIndex = 17;
            estadoLabel.Text = "estado:";
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
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.codigo_postalTableAdapter = null;
            this.tableAdapterManager.PagamentoTableAdapter = null;
            this.tableAdapterManager.Preço_do_quartoTableAdapter = null;
            this.tableAdapterManager.QuartoTableAdapter = null;
            this.tableAdapterManager.Reserva_quartosTableAdapter = null;
            this.tableAdapterManager.ReservaTableAdapter = this.reservaTableAdapter;
            this.tableAdapterManager.Tipos_de_pagamentoTableAdapter = null;
            this.tableAdapterManager.Tipos_de_quartosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LP_projecto_final_Emanuel.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // reservaBindingNavigator
            // 
            this.reservaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.reservaBindingNavigator.BindingSource = this.reservaBindingSource;
            this.reservaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.reservaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.reservaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.reservaBindingNavigatorSaveItem});
            this.reservaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.reservaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.reservaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.reservaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.reservaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.reservaBindingNavigator.Name = "reservaBindingNavigator";
            this.reservaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.reservaBindingNavigator.Size = new System.Drawing.Size(805, 25);
            this.reservaBindingNavigator.TabIndex = 0;
            this.reservaBindingNavigator.Text = "bindingNavigator1";
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
            // reservaBindingNavigatorSaveItem
            // 
            this.reservaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reservaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("reservaBindingNavigatorSaveItem.Image")));
            this.reservaBindingNavigatorSaveItem.Name = "reservaBindingNavigatorSaveItem";
            this.reservaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.reservaBindingNavigatorSaveItem.Text = "Save Data";
            this.reservaBindingNavigatorSaveItem.Click += new System.EventHandler(this.reservaBindingNavigatorSaveItem_Click);
            // 
            // id_reservaTextBox
            // 
            this.id_reservaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "id_reserva", true));
            this.id_reservaTextBox.Location = new System.Drawing.Point(273, 37);
            this.id_reservaTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.id_reservaTextBox.Name = "id_reservaTextBox";
            this.id_reservaTextBox.Size = new System.Drawing.Size(265, 21);
            this.id_reservaTextBox.TabIndex = 2;
            // 
            // id_clienteTextBox
            // 
            this.id_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "id_cliente", true));
            this.id_clienteTextBox.Location = new System.Drawing.Point(273, 67);
            this.id_clienteTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.id_clienteTextBox.Name = "id_clienteTextBox";
            this.id_clienteTextBox.Size = new System.Drawing.Size(265, 21);
            this.id_clienteTextBox.TabIndex = 4;
            // 
            // data_reservaDateTimePicker
            // 
            this.data_reservaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "data_reserva", true));
            this.data_reservaDateTimePicker.Location = new System.Drawing.Point(273, 97);
            this.data_reservaDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.data_reservaDateTimePicker.Name = "data_reservaDateTimePicker";
            this.data_reservaDateTimePicker.Size = new System.Drawing.Size(265, 21);
            this.data_reservaDateTimePicker.TabIndex = 6;
            // 
            // hora_reservaDateTimePicker
            // 
            this.hora_reservaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "hora_reserva", true));
            this.hora_reservaDateTimePicker.Location = new System.Drawing.Point(273, 127);
            this.hora_reservaDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hora_reservaDateTimePicker.Name = "hora_reservaDateTimePicker";
            this.hora_reservaDateTimePicker.Size = new System.Drawing.Size(265, 21);
            this.hora_reservaDateTimePicker.TabIndex = 8;
            // 
            // data_inicioDateTimePicker
            // 
            this.data_inicioDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "Data_inicio", true));
            this.data_inicioDateTimePicker.Location = new System.Drawing.Point(273, 157);
            this.data_inicioDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.data_inicioDateTimePicker.Name = "data_inicioDateTimePicker";
            this.data_inicioDateTimePicker.Size = new System.Drawing.Size(265, 21);
            this.data_inicioDateTimePicker.TabIndex = 10;
            // 
            // data_fimDateTimePicker
            // 
            this.data_fimDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "Data_fim", true));
            this.data_fimDateTimePicker.Location = new System.Drawing.Point(273, 187);
            this.data_fimDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.data_fimDateTimePicker.Name = "data_fimDateTimePicker";
            this.data_fimDateTimePicker.Size = new System.Drawing.Size(265, 21);
            this.data_fimDateTimePicker.TabIndex = 12;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Total", true));
            this.totalTextBox.Location = new System.Drawing.Point(273, 217);
            this.totalTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(265, 21);
            this.totalTextBox.TabIndex = 14;
            // 
            // comentariosTextBox
            // 
            this.comentariosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "comentarios", true));
            this.comentariosTextBox.Location = new System.Drawing.Point(273, 247);
            this.comentariosTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comentariosTextBox.Name = "comentariosTextBox";
            this.comentariosTextBox.Size = new System.Drawing.Size(265, 21);
            this.comentariosTextBox.TabIndex = 16;
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(273, 277);
            this.estadoTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(265, 21);
            this.estadoTextBox.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(576, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LP_projecto_final_Emanuel.Properties.Resources.nuel;
            this.ClientSize = new System.Drawing.Size(805, 407);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_reservaLabel);
            this.Controls.Add(this.id_reservaTextBox);
            this.Controls.Add(id_clienteLabel);
            this.Controls.Add(this.id_clienteTextBox);
            this.Controls.Add(data_reservaLabel);
            this.Controls.Add(this.data_reservaDateTimePicker);
            this.Controls.Add(hora_reservaLabel);
            this.Controls.Add(this.hora_reservaDateTimePicker);
            this.Controls.Add(data_inicioLabel);
            this.Controls.Add(this.data_inicioDateTimePicker);
            this.Controls.Add(data_fimLabel);
            this.Controls.Add(this.data_fimDateTimePicker);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(comentariosLabel);
            this.Controls.Add(this.comentariosTextBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoTextBox);
            this.Controls.Add(this.reservaBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MediumBlue;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form4";
            this.Text = "Lista das Reservas";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingNavigator)).EndInit();
            this.reservaBindingNavigator.ResumeLayout(false);
            this.reservaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource reservaBindingSource;
        private Database1DataSetTableAdapters.ReservaTableAdapter reservaTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator reservaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton reservaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_reservaTextBox;
        private System.Windows.Forms.TextBox id_clienteTextBox;
        private System.Windows.Forms.DateTimePicker data_reservaDateTimePicker;
        private System.Windows.Forms.DateTimePicker hora_reservaDateTimePicker;
        private System.Windows.Forms.DateTimePicker data_inicioDateTimePicker;
        private System.Windows.Forms.DateTimePicker data_fimDateTimePicker;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox comentariosTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.Button button1;
    }
}