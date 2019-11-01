namespace WILL_Project
{
    partial class Report_employees
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dg_emp_report = new System.Windows.Forms.DataGridView();
            this.btn_View_emp_rates = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_emp_report)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_emp_report
            // 
            this.dg_emp_report.AllowUserToAddRows = false;
            this.dg_emp_report.AllowUserToDeleteRows = false;
            this.dg_emp_report.AllowUserToOrderColumns = true;
            this.dg_emp_report.AllowUserToResizeColumns = false;
            this.dg_emp_report.AllowUserToResizeRows = false;
            this.dg_emp_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_emp_report.Location = new System.Drawing.Point(53, 41);
            this.dg_emp_report.Name = "dg_emp_report";
            this.dg_emp_report.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_emp_report.Size = new System.Drawing.Size(718, 343);
            this.dg_emp_report.TabIndex = 0;
            // 
            // btn_View_emp_rates
            // 
            this.btn_View_emp_rates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(131)))), ((int)(((byte)(47)))));
            this.btn_View_emp_rates.FlatAppearance.BorderSize = 0;
            this.btn_View_emp_rates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_View_emp_rates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_emp_rates.Location = new System.Drawing.Point(53, 409);
            this.btn_View_emp_rates.Name = "btn_View_emp_rates";
            this.btn_View_emp_rates.Size = new System.Drawing.Size(217, 29);
            this.btn_View_emp_rates.TabIndex = 13;
            this.btn_View_emp_rates.Text = "View Employee Wages";
            this.btn_View_emp_rates.UseVisualStyleBackColor = false;
            this.btn_View_emp_rates.Click += new System.EventHandler(this.btn_View_emp_rates_Click);
            // 
            // Report_employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_View_emp_rates);
            this.Controls.Add(this.dg_emp_report);
            this.Name = "Report_employees";
            this.Size = new System.Drawing.Size(853, 574);
            ((System.ComponentModel.ISupportInitialize)(this.dg_emp_report)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_emp_report;
        private System.Windows.Forms.Button btn_View_emp_rates;
    }
}
