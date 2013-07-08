namespace LP_projecto_final_Emanuel
{
    partial class RelatorioReserva
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
            this.ReservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Database1DataSet = new LP_projecto_final_Emanuel.Database1DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReservaTableAdapter = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.ReservaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ReservaBindingSource
            // 
            this.ReservaBindingSource.DataMember = "Reserva";
            this.ReservaBindingSource.DataSource = this.Database1DataSet;
            // 
            // Database1DataSet
            // 
            this.Database1DataSet.DataSetName = "Database1DataSet";
            this.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReservaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LP_projecto_final_Emanuel.Reserva.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(36, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(742, 725);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReservaTableAdapter
            // 
            this.ReservaTableAdapter.ClearBeforeFill = true;
            // 
            // RelatorioReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 749);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelatorioReserva";
            this.Text = "RelatorioReserva";
            this.Load += new System.EventHandler(this.RelatorioReservacs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReservaBindingSource;
        private Database1DataSet Database1DataSet;
        private Database1DataSetTableAdapters.ReservaTableAdapter ReservaTableAdapter;
    }
}