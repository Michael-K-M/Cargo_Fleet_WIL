namespace WILL_Project
{
    partial class Update_FuelCon
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fuelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberPlateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lBTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelConsumptionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseDataSet3 = new WILL_Project.DataBaseDataSet3();
            this.fuelConsumptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Bt_Remove = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.tb_BeforeTrip = new System.Windows.Forms.TextBox();
            this.tb_AfterTrip = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tb_NP = new System.Windows.Forms.TextBox();
            this.fuel_ConsumptionTableAdapter = new WILL_Project.DataBaseDataSet3TableAdapters.Fuel_ConsumptionTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelConsumptionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelConsumptionBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.fuelIDDataGridViewTextBoxColumn,
            this.numberPlateDataGridViewTextBoxColumn,
            this.lBTDataGridViewTextBoxColumn,
            this.lATDataGridViewTextBoxColumn,
            this.pPLDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fuelConsumptionBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(42, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(751, 263);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // fuelIDDataGridViewTextBoxColumn
            // 
            this.fuelIDDataGridViewTextBoxColumn.DataPropertyName = "FuelID";
            this.fuelIDDataGridViewTextBoxColumn.HeaderText = "FuelID";
            this.fuelIDDataGridViewTextBoxColumn.Name = "fuelIDDataGridViewTextBoxColumn";
            this.fuelIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberPlateDataGridViewTextBoxColumn
            // 
            this.numberPlateDataGridViewTextBoxColumn.DataPropertyName = "Number_Plate";
            this.numberPlateDataGridViewTextBoxColumn.HeaderText = "Number_Plate";
            this.numberPlateDataGridViewTextBoxColumn.Name = "numberPlateDataGridViewTextBoxColumn";
            // 
            // lBTDataGridViewTextBoxColumn
            // 
            this.lBTDataGridViewTextBoxColumn.DataPropertyName = "L_B_T";
            this.lBTDataGridViewTextBoxColumn.HeaderText = "L_B_T";
            this.lBTDataGridViewTextBoxColumn.Name = "lBTDataGridViewTextBoxColumn";
            // 
            // lATDataGridViewTextBoxColumn
            // 
            this.lATDataGridViewTextBoxColumn.DataPropertyName = "L_A_T";
            this.lATDataGridViewTextBoxColumn.HeaderText = "L_A_T";
            this.lATDataGridViewTextBoxColumn.Name = "lATDataGridViewTextBoxColumn";
            // 
            // pPLDataGridViewTextBoxColumn
            // 
            this.pPLDataGridViewTextBoxColumn.DataPropertyName = "PPL";
            this.pPLDataGridViewTextBoxColumn.HeaderText = "PPL";
            this.pPLDataGridViewTextBoxColumn.Name = "pPLDataGridViewTextBoxColumn";
            // 
            // fuelConsumptionBindingSource1
            // 
            this.fuelConsumptionBindingSource1.DataMember = "Fuel_Consumption";
            this.fuelConsumptionBindingSource1.DataSource = this.dataBaseDataSet3;
            // 
            // dataBaseDataSet3
            // 
            this.dataBaseDataSet3.DataSetName = "DataBaseDataSet3";
            this.dataBaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fuelConsumptionBindingSource
            // 
            this.fuelConsumptionBindingSource.DataMember = "Fuel_Consumption";
            // 
            // Bt_Remove
            // 
            this.Bt_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(131)))), ((int)(((byte)(47)))));
            this.Bt_Remove.FlatAppearance.BorderSize = 0;
            this.Bt_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Remove.Location = new System.Drawing.Point(667, 506);
            this.Bt_Remove.Name = "Bt_Remove";
            this.Bt_Remove.Size = new System.Drawing.Size(130, 27);
            this.Bt_Remove.TabIndex = 16;
            this.Bt_Remove.Text = "Remove";
            this.Bt_Remove.UseVisualStyleBackColor = false;
            this.Bt_Remove.Click += new System.EventHandler(this.Bt_Remove_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(131)))), ((int)(((byte)(47)))));
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Location = new System.Drawing.Point(527, 506);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(130, 27);
            this.btn_Update.TabIndex = 15;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // tb_BeforeTrip
            // 
            this.tb_BeforeTrip.Location = new System.Drawing.Point(135, 429);
            this.tb_BeforeTrip.Name = "tb_BeforeTrip";
            this.tb_BeforeTrip.Size = new System.Drawing.Size(196, 20);
            this.tb_BeforeTrip.TabIndex = 14;
            // 
            // tb_AfterTrip
            // 
            this.tb_AfterTrip.Location = new System.Drawing.Point(135, 461);
            this.tb_AfterTrip.Name = "tb_AfterTrip";
            this.tb_AfterTrip.Size = new System.Drawing.Size(196, 20);
            this.tb_AfterTrip.TabIndex = 13;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(135, 490);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(196, 20);
            this.tbPrice.TabIndex = 12;
            // 
            // tb_NP
            // 
            this.tb_NP.Location = new System.Drawing.Point(135, 399);
            this.tb_NP.Name = "tb_NP";
            this.tb_NP.Size = new System.Drawing.Size(196, 20);
            this.tb_NP.TabIndex = 11;
            // 
            // fuel_ConsumptionTableAdapter
            // 
            this.fuel_ConsumptionTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 16);
            this.label7.TabIndex = 72;
            this.label7.Text = "Select the row you would like to edit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(38, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(219, 24);
            this.label10.TabIndex = 71;
            this.label10.Text = "FUEL CONSUMPTION";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(277, 16);
            this.label8.TabIndex = 73;
            this.label8.Text = "Enter the information you would like to change";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 79;
            this.label4.Text = "Fuel Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "Milage after trip:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "Milage before trip:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "Number Plate:";
            // 
            // Update_FuelCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Bt_Remove);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.tb_BeforeTrip);
            this.Controls.Add(this.tb_AfterTrip);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tb_NP);
            this.Name = "Update_FuelCon";
            this.Size = new System.Drawing.Size(853, 574);
            this.Load += new System.EventHandler(this.Update_FuelCon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelConsumptionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelConsumptionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberPlateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lBTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPLDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fuelConsumptionBindingSource1;
        private DataBaseDataSet3 dataBaseDataSet3;
        private System.Windows.Forms.BindingSource fuelConsumptionBindingSource;
        private System.Windows.Forms.Button Bt_Remove;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox tb_BeforeTrip;
        private System.Windows.Forms.TextBox tb_AfterTrip;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tb_NP;
        private DataBaseDataSet3TableAdapters.Fuel_ConsumptionTableAdapter fuel_ConsumptionTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
