namespace WILL_Project
{
    partial class Update_Emp_Rates
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
            this.components = new System.ComponentModel.Container();
            this.Bt_Remove = new System.Windows.Forms.Button();
            this.Tb_Date = new System.Windows.Forms.TextBox();
            this.Tb_RPH = new System.Windows.Forms.TextBox();
            this.Tb_EndTime = new System.Windows.Forms.TextBox();
            this.Tb_Starttime = new System.Windows.Forms.TextBox();
            this.Tb_Name = new System.Windows.Forms.TextBox();
            this.Tb_Role = new System.Windows.Forms.TextBox();
            this.Bt_Update = new System.Windows.Forms.Button();
            this.empRateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rateIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rPHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empRateBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseDataSet1 = new WILL_Project.DataBaseDataSet1();
            this.emp_RateTableAdapter = new WILL_Project.DataBaseDataSet1TableAdapters.Emp_RateTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.empRateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empRateBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Bt_Remove
            // 
            this.Bt_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(131)))), ((int)(((byte)(47)))));
            this.Bt_Remove.FlatAppearance.BorderSize = 0;
            this.Bt_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Remove.Location = new System.Drawing.Point(653, 518);
            this.Bt_Remove.Name = "Bt_Remove";
            this.Bt_Remove.Size = new System.Drawing.Size(130, 27);
            this.Bt_Remove.TabIndex = 17;
            this.Bt_Remove.Text = "Remove";
            this.Bt_Remove.UseVisualStyleBackColor = false;
            this.Bt_Remove.Click += new System.EventHandler(this.Bt_Remove_Click);
            // 
            // Tb_Date
            // 
            this.Tb_Date.Location = new System.Drawing.Point(561, 480);
            this.Tb_Date.Name = "Tb_Date";
            this.Tb_Date.Size = new System.Drawing.Size(222, 20);
            this.Tb_Date.TabIndex = 15;
            // 
            // Tb_RPH
            // 
            this.Tb_RPH.Location = new System.Drawing.Point(561, 446);
            this.Tb_RPH.Name = "Tb_RPH";
            this.Tb_RPH.Size = new System.Drawing.Size(222, 20);
            this.Tb_RPH.TabIndex = 14;
            // 
            // Tb_EndTime
            // 
            this.Tb_EndTime.Location = new System.Drawing.Point(561, 412);
            this.Tb_EndTime.Name = "Tb_EndTime";
            this.Tb_EndTime.Size = new System.Drawing.Size(222, 20);
            this.Tb_EndTime.TabIndex = 13;
            // 
            // Tb_Starttime
            // 
            this.Tb_Starttime.Location = new System.Drawing.Point(134, 480);
            this.Tb_Starttime.Name = "Tb_Starttime";
            this.Tb_Starttime.Size = new System.Drawing.Size(222, 20);
            this.Tb_Starttime.TabIndex = 12;
            // 
            // Tb_Name
            // 
            this.Tb_Name.Location = new System.Drawing.Point(134, 446);
            this.Tb_Name.Name = "Tb_Name";
            this.Tb_Name.Size = new System.Drawing.Size(222, 20);
            this.Tb_Name.TabIndex = 11;
            // 
            // Tb_Role
            // 
            this.Tb_Role.Location = new System.Drawing.Point(134, 412);
            this.Tb_Role.Name = "Tb_Role";
            this.Tb_Role.Size = new System.Drawing.Size(222, 20);
            this.Tb_Role.TabIndex = 10;
            // 
            // Bt_Update
            // 
            this.Bt_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(131)))), ((int)(((byte)(47)))));
            this.Bt_Update.FlatAppearance.BorderSize = 0;
            this.Bt_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Update.Location = new System.Drawing.Point(512, 518);
            this.Bt_Update.Name = "Bt_Update";
            this.Bt_Update.Size = new System.Drawing.Size(130, 27);
            this.Bt_Update.TabIndex = 16;
            this.Bt_Update.Text = "Update";
            this.Bt_Update.UseVisualStyleBackColor = false;
            this.Bt_Update.Click += new System.EventHandler(this.Bt_Update_Click);
            // 
            // empRateBindingSource
            // 
            this.empRateBindingSource.DataMember = "Emp_Rate";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rateIDDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.rPHDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.empRateBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(42, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(745, 282);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // rateIDDataGridViewTextBoxColumn
            // 
            this.rateIDDataGridViewTextBoxColumn.DataPropertyName = "RateID";
            this.rateIDDataGridViewTextBoxColumn.HeaderText = "RateID";
            this.rateIDDataGridViewTextBoxColumn.Name = "rateIDDataGridViewTextBoxColumn";
            this.rateIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            // 
            // rPHDataGridViewTextBoxColumn
            // 
            this.rPHDataGridViewTextBoxColumn.DataPropertyName = "RPH";
            this.rPHDataGridViewTextBoxColumn.HeaderText = "RPH";
            this.rPHDataGridViewTextBoxColumn.Name = "rPHDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // empRateBindingSource1
            // 
            this.empRateBindingSource1.DataMember = "Emp_Rate";
            this.empRateBindingSource1.DataSource = this.dataBaseDataSet1;
            // 
            // dataBaseDataSet1
            // 
            this.dataBaseDataSet1.DataSetName = "DataBaseDataSet1";
            this.dataBaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emp_RateTableAdapter
            // 
            this.emp_RateTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(38, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 24);
            this.label10.TabIndex = 61;
            this.label10.Text = "EMPLOYEE RATES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Employee Role:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Employee Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Start Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "Rate Per Hour:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(472, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "End Time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 16);
            this.label7.TabIndex = 68;
            this.label7.Text = "Select the row you would like to edit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(277, 16);
            this.label8.TabIndex = 69;
            this.label8.Text = "Enter the information you would like to change";
            // 
            // Update_Emp_Rates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Bt_Remove);
            this.Controls.Add(this.Tb_Date);
            this.Controls.Add(this.Tb_RPH);
            this.Controls.Add(this.Tb_EndTime);
            this.Controls.Add(this.Tb_Starttime);
            this.Controls.Add(this.Tb_Name);
            this.Controls.Add(this.Tb_Role);
            this.Controls.Add(this.Bt_Update);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Update_Emp_Rates";
            this.Size = new System.Drawing.Size(853, 574);
            this.Load += new System.EventHandler(this.Update_Emp_Rates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empRateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empRateBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_Remove;
        private System.Windows.Forms.TextBox Tb_Date;
        private System.Windows.Forms.TextBox Tb_RPH;
        private System.Windows.Forms.TextBox Tb_EndTime;
        private System.Windows.Forms.TextBox Tb_Starttime;
        private System.Windows.Forms.TextBox Tb_Name;
        private System.Windows.Forms.TextBox Tb_Role;
        private System.Windows.Forms.Button Bt_Update;
        private System.Windows.Forms.BindingSource empRateBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rPHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource empRateBindingSource1;
        private DataBaseDataSet1 dataBaseDataSet1;
        private DataBaseDataSet1TableAdapters.Emp_RateTableAdapter emp_RateTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
