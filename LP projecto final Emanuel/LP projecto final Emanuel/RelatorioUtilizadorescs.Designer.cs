﻿namespace LP_projecto_final_Emanuel
{
    partial class RelatorioUtilizadorescs
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
            this.UtilizadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Database1DataSet = new LP_projecto_final_Emanuel.Database1DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.UtilizadoresTableAdapter = new LP_projecto_final_Emanuel.Database1DataSetTableAdapters.UtilizadoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.UtilizadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // UtilizadoresBindingSource
            // 
            this.UtilizadoresBindingSource.DataMember = "Utilizadores";
            this.UtilizadoresBindingSource.DataSource = this.Database1DataSet;
            // 
            // Database1DataSet
            // 
            this.Database1DataSet.DataSetName = "Database1DataSet";
            this.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.UtilizadoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LP_projecto_final_Emanuel.Utilizadores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(44, 50);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(652, 655);
            this.reportViewer1.TabIndex = 0;
            // 
            // UtilizadoresTableAdapter
            // 
            this.UtilizadoresTableAdapter.ClearBeforeFill = true;
            // 
            // RelatorioUtilizadorescs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 717);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelatorioUtilizadorescs";
            this.Text = "RelatorioUtilizadorescs";
            this.Load += new System.EventHandler(this.RelatorioUtilizadorescs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UtilizadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource UtilizadoresBindingSource;
        private Database1DataSet Database1DataSet;
        private Database1DataSetTableAdapters.UtilizadoresTableAdapter UtilizadoresTableAdapter;
    }
}