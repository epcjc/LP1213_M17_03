﻿namespace LP_projecto_final_Emanuel
{
    partial class Form17
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idprecoquartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoquartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preçoDoQuartoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new LP_projecto_final_Emanuel.Database1DataSet();
            this.preço_do_quartoTableAdapter = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.Preço_do_quartoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preçoDoQuartoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprecoquartoDataGridViewTextBoxColumn,
            this.precoquartoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.preçoDoQuartoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(184, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(246, 235);
            this.dataGridView1.TabIndex = 0;
            // 
            // idprecoquartoDataGridViewTextBoxColumn
            // 
            this.idprecoquartoDataGridViewTextBoxColumn.DataPropertyName = "id_preco_quarto";
            this.idprecoquartoDataGridViewTextBoxColumn.HeaderText = "id_preco_quarto";
            this.idprecoquartoDataGridViewTextBoxColumn.Name = "idprecoquartoDataGridViewTextBoxColumn";
            this.idprecoquartoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precoquartoDataGridViewTextBoxColumn
            // 
            this.precoquartoDataGridViewTextBoxColumn.DataPropertyName = "preco_quarto";
            this.precoquartoDataGridViewTextBoxColumn.HeaderText = "preco_quarto";
            this.precoquartoDataGridViewTextBoxColumn.Name = "precoquartoDataGridViewTextBoxColumn";
            // 
            // preçoDoQuartoBindingSource
            // 
            this.preçoDoQuartoBindingSource.DataMember = "Preço do quarto";
            this.preçoDoQuartoBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // preço_do_quartoTableAdapter
            // 
            this.preço_do_quartoTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista dos Preços  dos Quartos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ir para Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LP_projecto_final_Emanuel.Properties.Resources.hotel1;
            this.ClientSize = new System.Drawing.Size(622, 307);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MediumBlue;
            this.Name = "Form17";
            this.Text = "Form17";
            this.Load += new System.EventHandler(this.Form17_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preçoDoQuartoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource preçoDoQuartoBindingSource;
        private Database1DataSetTableAdapters.Preço_do_quartoTableAdapter preço_do_quartoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprecoquartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoquartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;

    }
}