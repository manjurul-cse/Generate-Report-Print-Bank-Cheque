namespace PrintApp
{
    partial class PrintUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxExcelTable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.buttonGetExcel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PrintReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.checkBoxAllpart = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxAllpart);
            this.panel1.Controls.Add(this.comboBoxExcelTable);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonGenerateReport);
            this.panel1.Controls.Add(this.buttonGetExcel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 94);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxExcelTable
            // 
            this.comboBoxExcelTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExcelTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxExcelTable.FormattingEnabled = true;
            this.comboBoxExcelTable.Location = new System.Drawing.Point(249, 30);
            this.comboBoxExcelTable.Name = "comboBoxExcelTable";
            this.comboBoxExcelTable.Size = new System.Drawing.Size(220, 28);
            this.comboBoxExcelTable.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Table";
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerateReport.ForeColor = System.Drawing.Color.Black;
            this.buttonGenerateReport.Location = new System.Drawing.Point(762, 12);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(111, 51);
            this.buttonGenerateReport.TabIndex = 0;
            this.buttonGenerateReport.Text = "Generate Report";
            this.buttonGenerateReport.UseVisualStyleBackColor = true;
            this.buttonGenerateReport.Click += new System.EventHandler(this.buttonGenerateReport_Click);
            // 
            // buttonGetExcel
            // 
            this.buttonGetExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetExcel.Location = new System.Drawing.Point(28, 12);
            this.buttonGetExcel.Name = "buttonGetExcel";
            this.buttonGetExcel.Size = new System.Drawing.Size(111, 51);
            this.buttonGetExcel.TabIndex = 0;
            this.buttonGetExcel.Text = "Get Excel File";
            this.buttonGetExcel.UseVisualStyleBackColor = true;
            this.buttonGetExcel.Click += new System.EventHandler(this.buttonGetExcel_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PrintReportViewer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(968, 420);
            this.panel2.TabIndex = 1;
            // 
            // PrintReportViewer
            // 
            this.PrintReportViewer.ActiveViewIndex = -1;
            this.PrintReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrintReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.PrintReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrintReportViewer.Location = new System.Drawing.Point(0, 0);
            this.PrintReportViewer.Name = "PrintReportViewer";
            this.PrintReportViewer.Size = new System.Drawing.Size(968, 420);
            this.PrintReportViewer.TabIndex = 0;
            this.PrintReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // checkBoxAllpart
            // 
            this.checkBoxAllpart.AutoSize = true;
            this.checkBoxAllpart.Location = new System.Drawing.Point(568, 27);
            this.checkBoxAllpart.Name = "checkBoxAllpart";
            this.checkBoxAllpart.Size = new System.Drawing.Size(59, 17);
            this.checkBoxAllpart.TabIndex = 3;
            this.checkBoxAllpart.Text = "All Part";
            this.checkBoxAllpart.UseVisualStyleBackColor = true;
            // 
            // PrintUI
            // 
            this.AcceptButton = this.buttonGenerateReport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 514);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PrintUI";
            this.Text = "PrintUI";
            this.Load += new System.EventHandler(this.PrintUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonGetExcel;
        private System.Windows.Forms.Panel panel2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer PrintReportViewer;
        private System.Windows.Forms.ComboBox comboBoxExcelTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.CheckBox checkBoxAllpart;
    }
}