namespace LP_projecto_final_Emanuel
{
    partial class RelatorioTipoQuarto
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Database1DataSet = new LP_projecto_final_Emanuel.Database1DataSet();
            this.Tipos_de_quartosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tipos_de_quartosTableAdapter = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.Tipos_de_quartosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tipos_de_quartosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Tipos_de_quartosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LP_projecto_final_Emanuel.TipoQuarto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(44, 43);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // Database1DataSet
            // 
            this.Database1DataSet.DataSetName = "Database1DataSet";
            this.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Tipos_de_quartosBindingSource
            // 
            this.Tipos_de_quartosBindingSource.DataMember = "Tipos de quartos";
            this.Tipos_de_quartosBindingSource.DataSource = this.Database1DataSet;
            // 
            // Tipos_de_quartosTableAdapter
            // 
            this.Tipos_de_quartosTableAdapter.ClearBeforeFill = true;
            // 
            // RelatorioTipoQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 325);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelatorioTipoQuarto";
            this.Text = "RelatorioTipoQuarto";
            this.Load += new System.EventHandler(this.RelatorioTipoQuarto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tipos_de_quartosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Tipos_de_quartosBindingSource;
        private Database1DataSet Database1DataSet;
        private Database1DataSetTableAdapters.Tipos_de_quartosTableAdapter Tipos_de_quartosTableAdapter;
    }
}