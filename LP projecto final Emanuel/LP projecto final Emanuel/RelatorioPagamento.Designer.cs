namespace LP_projecto_final_Emanuel
{
    partial class RelatorioPagamento
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
            this.PagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Database1DataSet = new LP_projecto_final_Emanuel.Database1DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PagamentoTableAdapter = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.PagamentoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PagamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PagamentoBindingSource
            // 
            this.PagamentoBindingSource.DataMember = "Pagamento";
            this.PagamentoBindingSource.DataSource = this.Database1DataSet;
            // 
            // Database1DataSet
            // 
            this.Database1DataSet.DataSetName = "Database1DataSet";
            this.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PagamentoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LP_projecto_final_Emanuel.Pagamentos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(42, 30);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(769, 693);
            this.reportViewer1.TabIndex = 0;
            // 
            // PagamentoTableAdapter
            // 
            this.PagamentoTableAdapter.ClearBeforeFill = true;
            // 
            // RelatorioPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 749);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelatorioPagamento";
            this.Text = "RelatorioPagamento";
            this.Load += new System.EventHandler(this.RelatorioPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PagamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PagamentoBindingSource;
        private Database1DataSet Database1DataSet;
        private Database1DataSetTableAdapters.PagamentoTableAdapter PagamentoTableAdapter;
    }
}