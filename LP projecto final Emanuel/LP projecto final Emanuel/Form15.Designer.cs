﻿namespace LP_projecto_final_Emanuel
{
    partial class Form15
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.quartoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new LP_projecto_final_Emanuel.Database1DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quarto2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quarto2TableAdapter = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.Quarto2TableAdapter();
            this.tableAdapterManager = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.TableAdapterManager();
            this.quartoTableAdapter = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.QuartoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.quartoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quarto2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ajuda";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(279, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ir Para Menu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.quartoBindingSource;
            this.comboBox1.DisplayMember = "andar_quarto";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "id_quarto";
            // 
            // quartoBindingSource
            // 
            this.quartoBindingSource.DataMember = "Quarto";
            this.quartoBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quartos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Eliminar Quartos";
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
            this.tableAdapterManager.Reserva_quartosTableAdapter = null;
            this.tableAdapterManager.Reserva1TableAdapter = null;
            this.tableAdapterManager.ReservaTableAdapter = null;
            this.tableAdapterManager.Tipos_de_pagamento1TableAdapter = null;
            this.tableAdapterManager.Tipos_de_pagamentoTableAdapter = null;
            this.tableAdapterManager.Tipos_de_quartosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LP_projecto_final_Emanuel.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilizadoresTableAdapter = null;
            // 
            // quartoTableAdapter
            // 
            this.quartoTableAdapter.ClearBeforeFill = true;
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 239);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form15";
            this.Text = "Form15";
            this.Load += new System.EventHandler(this.Form15_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quartoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quarto2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource quarto2BindingSource;
        private Database1DataSetTableAdapters.Quarto2TableAdapter quarto2TableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource quartoBindingSource;
        private Database1DataSetTableAdapters.QuartoTableAdapter quartoTableAdapter;
    }
}