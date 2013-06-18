namespace LP_projecto_final_Emanuel
{
    partial class RelatorioPrecoQuarto
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
            this.Preço_do_quartoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Database1DataSet = new LP_projecto_final_Emanuel.Database1DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Preço_do_quartoTableAdapter = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.Preço_do_quartoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Preço_do_quartoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Preço_do_quartoBindingSource
            // 
            this.Preço_do_quartoBindingSource.DataMember = "Preço do quarto";
            this.Preço_do_quartoBindingSource.DataSource = this.Database1DataSet;
            // 
            // Database1DataSet
            // 
            this.Database1DataSet.DataSetName = "Database1DataSet";
            this.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Preço_do_quartoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LP_projecto_final_Emanuel.PreçoQuarto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(29, 28);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // Preço_do_quartoTableAdapter
            // 
            this.Preço_do_quartoTableAdapter.ClearBeforeFill = true;
            // 
            // RelatorioPrecoQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 331);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelatorioPrecoQuarto";
            this.Text = "RelatorioPrecoQuarto";
            this.Load += new System.EventHandler(this.PrecoQuarto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Preço_do_quartoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Preço_do_quartoBindingSource;
        private Database1DataSet Database1DataSet;
        private Database1DataSetTableAdapters.Preço_do_quartoTableAdapter Preço_do_quartoTableAdapter;
    }
}