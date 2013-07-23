namespace LP_projecto_final_Emanuel
{
    partial class frmQuartosPorTipo
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.database1DataSet = new LP_projecto_final_Emanuel.Database1DataSet();
            this.tiposDeQuartosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipos_de_quartosTableAdapter = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.Tipos_de_quartosTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fKQuartoTiposDeQuartosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quartoTableAdapter = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.QuartoTableAdapter();
            this.idquartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoquartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.andarquartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeQuartosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKQuartoTiposDeQuartosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tiposDeQuartosBindingSource;
            this.comboBox1.DisplayMember = "tipo_quarto";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(59, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "id_tipo_quartos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idquartoDataGridViewTextBoxColumn,
            this.precoquartoDataGridViewTextBoxColumn,
            this.andarquartoDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fKQuartoTiposDeQuartosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(387, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // fKQuartoTiposDeQuartosBindingSource
            // 
            this.fKQuartoTiposDeQuartosBindingSource.DataMember = "FK_Quarto_Tipos de quartos";
            this.fKQuartoTiposDeQuartosBindingSource.DataSource = this.tiposDeQuartosBindingSource;
            // 
            // quartoTableAdapter
            // 
            this.quartoTableAdapter.ClearBeforeFill = true;
            // 
            // idquartoDataGridViewTextBoxColumn
            // 
            this.idquartoDataGridViewTextBoxColumn.DataPropertyName = "id_quarto";
            this.idquartoDataGridViewTextBoxColumn.HeaderText = "id_quarto";
            this.idquartoDataGridViewTextBoxColumn.Name = "idquartoDataGridViewTextBoxColumn";
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
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // frmQuartosPorTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(411, 264);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "frmQuartosPorTipo";
            this.Text = "Quartos Por Tipo";
            this.Load += new System.EventHandler(this.frmQuartosPorTipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeQuartosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKQuartoTiposDeQuartosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource tiposDeQuartosBindingSource;
        private Database1DataSetTableAdapters.Tipos_de_quartosTableAdapter tipos_de_quartosTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fKQuartoTiposDeQuartosBindingSource;
        private Database1DataSetTableAdapters.QuartoTableAdapter quartoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idquartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoquartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn andarquartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
    }
}