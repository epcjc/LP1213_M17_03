﻿namespace LP_projecto_final_Emanuel
{
    partial class Form3
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
            System.Windows.Forms.Label id_clienteLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label moradaLabel;
            System.Windows.Forms.Label contactoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label data_nascLabel;
            System.Windows.Forms.Label bILabel;
            System.Windows.Forms.Label codigo_postalLabel;
            System.Windows.Forms.Label fotoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.clienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new LP_projecto_final_Emanuel.Database1DataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_clienteTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.moradaTextBox = new System.Windows.Forms.TextBox();
            this.contactoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.data_nascDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bITextBox = new System.Windows.Forms.TextBox();
            this.codigo_postalTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clienteTableAdapter = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.ClienteTableAdapter();
            this.tableAdapterManager = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.TableAdapterManager();
            this.button3 = new System.Windows.Forms.Button();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            id_clienteLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            moradaLabel = new System.Windows.Forms.Label();
            contactoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            data_nascLabel = new System.Windows.Forms.Label();
            bILabel = new System.Windows.Forms.Label();
            codigo_postalLabel = new System.Windows.Forms.Label();
            fotoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).BeginInit();
            this.clienteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // id_clienteLabel
            // 
            id_clienteLabel.AutoSize = true;
            id_clienteLabel.Location = new System.Drawing.Point(49, 102);
            id_clienteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            id_clienteLabel.Name = "id_clienteLabel";
            id_clienteLabel.Size = new System.Drawing.Size(67, 13);
            id_clienteLabel.TabIndex = 1;
            id_clienteLabel.Text = "ID Cliente:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(49, 128);
            nomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(43, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // moradaLabel
            // 
            moradaLabel.AutoSize = true;
            moradaLabel.Location = new System.Drawing.Point(49, 154);
            moradaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            moradaLabel.Name = "moradaLabel";
            moradaLabel.Size = new System.Drawing.Size(53, 13);
            moradaLabel.TabIndex = 5;
            moradaLabel.Text = "Morada:";
            // 
            // contactoLabel
            // 
            contactoLabel.AutoSize = true;
            contactoLabel.Location = new System.Drawing.Point(49, 206);
            contactoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            contactoLabel.Name = "contactoLabel";
            contactoLabel.Size = new System.Drawing.Size(58, 13);
            contactoLabel.TabIndex = 7;
            contactoLabel.Text = "Contacto";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(49, 232);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(41, 13);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Email:";
            // 
            // data_nascLabel
            // 
            data_nascLabel.AutoSize = true;
            data_nascLabel.Location = new System.Drawing.Point(49, 258);
            data_nascLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            data_nascLabel.Name = "data_nascLabel";
            data_nascLabel.Size = new System.Drawing.Size(108, 13);
            data_nascLabel.TabIndex = 11;
            data_nascLabel.Text = "Data Nascimento:";
            // 
            // bILabel
            // 
            bILabel.AutoSize = true;
            bILabel.Location = new System.Drawing.Point(49, 284);
            bILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            bILabel.Name = "bILabel";
            bILabel.Size = new System.Drawing.Size(23, 13);
            bILabel.TabIndex = 13;
            bILabel.Text = "BI:";
            // 
            // codigo_postalLabel
            // 
            codigo_postalLabel.AutoSize = true;
            codigo_postalLabel.Location = new System.Drawing.Point(49, 180);
            codigo_postalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codigo_postalLabel.Name = "codigo_postalLabel";
            codigo_postalLabel.Size = new System.Drawing.Size(88, 13);
            codigo_postalLabel.TabIndex = 15;
            codigo_postalLabel.Text = "Codigo postal:";
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.Location = new System.Drawing.Point(428, 99);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(36, 13);
            fotoLabel.TabIndex = 22;
            fotoLabel.Text = "Foto:";
            // 
            // clienteBindingNavigator
            // 
            this.clienteBindingNavigator.AddNewItem = null;
            this.clienteBindingNavigator.BindingSource = this.clienteBindingSource;
            this.clienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clienteBindingNavigator.DeleteItem = null;
            this.clienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.clienteBindingNavigatorSaveItem});
            this.clienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clienteBindingNavigator.Name = "clienteBindingNavigator";
            this.clienteBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.clienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clienteBindingNavigator.Size = new System.Drawing.Size(641, 25);
            this.clienteBindingNavigator.TabIndex = 0;
            this.clienteBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(44, 23);
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
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
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
            // clienteBindingNavigatorSaveItem
            // 
            this.clienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clienteBindingNavigatorSaveItem.Image")));
            this.clienteBindingNavigatorSaveItem.Name = "clienteBindingNavigatorSaveItem";
            this.clienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.clienteBindingNavigatorSaveItem.Text = "Save Data";
            this.clienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.clienteBindingNavigatorSaveItem_Click);
            // 
            // id_clienteTextBox
            // 
            this.id_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "id_cliente", true));
            this.id_clienteTextBox.Location = new System.Drawing.Point(157, 99);
            this.id_clienteTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.id_clienteTextBox.Name = "id_clienteTextBox";
            this.id_clienteTextBox.ReadOnly = true;
            this.id_clienteTextBox.Size = new System.Drawing.Size(232, 20);
            this.id_clienteTextBox.TabIndex = 2;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(157, 125);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(232, 20);
            this.nomeTextBox.TabIndex = 4;
            // 
            // moradaTextBox
            // 
            this.moradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "morada", true));
            this.moradaTextBox.Location = new System.Drawing.Point(157, 151);
            this.moradaTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.moradaTextBox.Name = "moradaTextBox";
            this.moradaTextBox.Size = new System.Drawing.Size(232, 20);
            this.moradaTextBox.TabIndex = 6;
            // 
            // contactoTextBox
            // 
            this.contactoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "contacto", true));
            this.contactoTextBox.Location = new System.Drawing.Point(157, 203);
            this.contactoTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.contactoTextBox.Name = "contactoTextBox";
            this.contactoTextBox.Size = new System.Drawing.Size(232, 20);
            this.contactoTextBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(157, 229);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(232, 20);
            this.emailTextBox.TabIndex = 10;
            // 
            // data_nascDateTimePicker
            // 
            this.data_nascDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clienteBindingSource, "data_nasc", true));
            this.data_nascDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_nascDateTimePicker.Location = new System.Drawing.Point(157, 255);
            this.data_nascDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.data_nascDateTimePicker.Name = "data_nascDateTimePicker";
            this.data_nascDateTimePicker.Size = new System.Drawing.Size(232, 20);
            this.data_nascDateTimePicker.TabIndex = 12;
            // 
            // bITextBox
            // 
            this.bITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "BI", true));
            this.bITextBox.Location = new System.Drawing.Point(157, 281);
            this.bITextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bITextBox.Name = "bITextBox";
            this.bITextBox.Size = new System.Drawing.Size(232, 20);
            this.bITextBox.TabIndex = 14;
            // 
            // codigo_postalTextBox
            // 
            this.codigo_postalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Codigo_postal", true));
            this.codigo_postalTextBox.Location = new System.Drawing.Point(157, 177);
            this.codigo_postalTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.codigo_postalTextBox.Name = "codigo_postalTextBox";
            this.codigo_postalTextBox.Size = new System.Drawing.Size(232, 20);
            this.codigo_postalTextBox.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(519, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Ir para Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Pesquisar por nome:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.codigo_postalTableAdapter = null;
            this.tableAdapterManager.Pagamento1TableAdapter = null;
            this.tableAdapterManager.PagamentoTableAdapter = null;
            
            this.tableAdapterManager.Preço_do_quartoTableAdapter = null;
            this.tableAdapterManager.Quarto1TableAdapter = null;
            this.tableAdapterManager.Quarto2TableAdapter = null;
            this.tableAdapterManager.QuartoTableAdapter = null;
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
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Location = new System.Drawing.Point(519, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Ajuda";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.clienteBindingSource, "Foto", true));
            this.fotoPictureBox.Location = new System.Drawing.Point(470, 99);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(150, 160);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 23;
            this.fotoPictureBox.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(641, 358);
            this.Controls.Add(fotoLabel);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_clienteLabel);
            this.Controls.Add(this.id_clienteTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(moradaLabel);
            this.Controls.Add(this.moradaTextBox);
            this.Controls.Add(contactoLabel);
            this.Controls.Add(this.contactoTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(data_nascLabel);
            this.Controls.Add(this.data_nascDateTimePicker);
            this.Controls.Add(bILabel);
            this.Controls.Add(this.bITextBox);
            this.Controls.Add(codigo_postalLabel);
            this.Controls.Add(this.codigo_postalTextBox);
            this.Controls.Add(this.clienteBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MediumBlue;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form3";
            this.Text = "Lista dos clientes";
            this.TransparencyKey = System.Drawing.Color.Blue;
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).EndInit();
            this.clienteBindingNavigator.ResumeLayout(false);
            this.clienteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private Database1DataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clienteBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton clienteBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_clienteTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox moradaTextBox;
        private System.Windows.Forms.TextBox contactoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DateTimePicker data_nascDateTimePicker;
        private System.Windows.Forms.TextBox bITextBox;
        private System.Windows.Forms.TextBox codigo_postalTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox fotoPictureBox;
    }
}