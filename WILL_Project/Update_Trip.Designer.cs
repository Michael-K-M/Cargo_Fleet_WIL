namespace WILL_Project
{
    partial class Update_Trip
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
            this.tripIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sStreetAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPostcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sProvinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rStreetAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rPostcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rProvinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tripBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseDataSet6 = new WILL_Project.DataBaseDataSet6();
            this.Bt_Update = new System.Windows.Forms.Button();
            this.Tb_Statue = new System.Windows.Forms.TextBox();
            this.Tb_Description = new System.Windows.Forms.TextBox();
            this.Tb_Phone2 = new System.Windows.Forms.TextBox();
            this.Tb_Province2 = new System.Windows.Forms.TextBox();
            this.Tb_Postcode2 = new System.Windows.Forms.TextBox();
            this.Tb_City2 = new System.Windows.Forms.TextBox();
            this.Tb_StreetAddress2 = new System.Windows.Forms.TextBox();
            this.Tb_Name2 = new System.Windows.Forms.TextBox();
            this.Tb_Phone = new System.Windows.Forms.TextBox();
            this.Tb_Province = new System.Windows.Forms.TextBox();
            this.Tb_PostCode = new System.Windows.Forms.TextBox();
            this.Tb_City = new System.Windows.Forms.TextBox();
            this.Tb_Streetname = new System.Windows.Forms.TextBox();
            this.Tb_Name = new System.Windows.Forms.TextBox();
            this.tripTableAdapter = new WILL_Project.DataBaseDataSet6TableAdapters.TripTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet6)).BeginInit();
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
            this.tripIDDataGridViewTextBoxColumn,
            this.sNameDataGridViewTextBoxColumn,
            this.sStreetAddressDataGridViewTextBoxColumn,
            this.sCityDataGridViewTextBoxColumn,
            this.sPostcodeDataGridViewTextBoxColumn,
            this.sProvinceDataGridViewTextBoxColumn,
            this.sPhoneDataGridViewTextBoxColumn,
            this.rNameDataGridViewTextBoxColumn,
            this.rStreetAddressDataGridViewTextBoxColumn,
            this.rCityDataGridViewTextBoxColumn,
            this.rPostcodeDataGridViewTextBoxColumn,
            this.rProvinceDataGridViewTextBoxColumn,
            this.rPhoneDataGridViewTextBoxColumn,
            this.rDescriptionDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tripBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(817, 260);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // tripIDDataGridViewTextBoxColumn
            // 
            this.tripIDDataGridViewTextBoxColumn.DataPropertyName = "TripID";
            this.tripIDDataGridViewTextBoxColumn.HeaderText = "TripID";
            this.tripIDDataGridViewTextBoxColumn.Name = "tripIDDataGridViewTextBoxColumn";
            this.tripIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sNameDataGridViewTextBoxColumn
            // 
            this.sNameDataGridViewTextBoxColumn.DataPropertyName = "S_Name";
            this.sNameDataGridViewTextBoxColumn.HeaderText = "S_Name";
            this.sNameDataGridViewTextBoxColumn.Name = "sNameDataGridViewTextBoxColumn";
            // 
            // sStreetAddressDataGridViewTextBoxColumn
            // 
            this.sStreetAddressDataGridViewTextBoxColumn.DataPropertyName = "S_StreetAddress";
            this.sStreetAddressDataGridViewTextBoxColumn.HeaderText = "S_StreetAddress";
            this.sStreetAddressDataGridViewTextBoxColumn.Name = "sStreetAddressDataGridViewTextBoxColumn";
            // 
            // sCityDataGridViewTextBoxColumn
            // 
            this.sCityDataGridViewTextBoxColumn.DataPropertyName = "S_City";
            this.sCityDataGridViewTextBoxColumn.HeaderText = "S_City";
            this.sCityDataGridViewTextBoxColumn.Name = "sCityDataGridViewTextBoxColumn";
            // 
            // sPostcodeDataGridViewTextBoxColumn
            // 
            this.sPostcodeDataGridViewTextBoxColumn.DataPropertyName = "S_Postcode";
            this.sPostcodeDataGridViewTextBoxColumn.HeaderText = "S_Postcode";
            this.sPostcodeDataGridViewTextBoxColumn.Name = "sPostcodeDataGridViewTextBoxColumn";
            // 
            // sProvinceDataGridViewTextBoxColumn
            // 
            this.sProvinceDataGridViewTextBoxColumn.DataPropertyName = "S_Province";
            this.sProvinceDataGridViewTextBoxColumn.HeaderText = "S_Province";
            this.sProvinceDataGridViewTextBoxColumn.Name = "sProvinceDataGridViewTextBoxColumn";
            // 
            // sPhoneDataGridViewTextBoxColumn
            // 
            this.sPhoneDataGridViewTextBoxColumn.DataPropertyName = "S_Phone";
            this.sPhoneDataGridViewTextBoxColumn.HeaderText = "S_Phone";
            this.sPhoneDataGridViewTextBoxColumn.Name = "sPhoneDataGridViewTextBoxColumn";
            // 
            // rNameDataGridViewTextBoxColumn
            // 
            this.rNameDataGridViewTextBoxColumn.DataPropertyName = "R_Name";
            this.rNameDataGridViewTextBoxColumn.HeaderText = "R_Name";
            this.rNameDataGridViewTextBoxColumn.Name = "rNameDataGridViewTextBoxColumn";
            // 
            // rStreetAddressDataGridViewTextBoxColumn
            // 
            this.rStreetAddressDataGridViewTextBoxColumn.DataPropertyName = "R_StreetAddress";
            this.rStreetAddressDataGridViewTextBoxColumn.HeaderText = "R_StreetAddress";
            this.rStreetAddressDataGridViewTextBoxColumn.Name = "rStreetAddressDataGridViewTextBoxColumn";
            // 
            // rCityDataGridViewTextBoxColumn
            // 
            this.rCityDataGridViewTextBoxColumn.DataPropertyName = "R_City";
            this.rCityDataGridViewTextBoxColumn.HeaderText = "R_City";
            this.rCityDataGridViewTextBoxColumn.Name = "rCityDataGridViewTextBoxColumn";
            // 
            // rPostcodeDataGridViewTextBoxColumn
            // 
            this.rPostcodeDataGridViewTextBoxColumn.DataPropertyName = "R_Postcode";
            this.rPostcodeDataGridViewTextBoxColumn.HeaderText = "R_Postcode";
            this.rPostcodeDataGridViewTextBoxColumn.Name = "rPostcodeDataGridViewTextBoxColumn";
            // 
            // rProvinceDataGridViewTextBoxColumn
            // 
            this.rProvinceDataGridViewTextBoxColumn.DataPropertyName = "R_Province";
            this.rProvinceDataGridViewTextBoxColumn.HeaderText = "R_Province";
            this.rProvinceDataGridViewTextBoxColumn.Name = "rProvinceDataGridViewTextBoxColumn";
            // 
            // rPhoneDataGridViewTextBoxColumn
            // 
            this.rPhoneDataGridViewTextBoxColumn.DataPropertyName = "R_Phone";
            this.rPhoneDataGridViewTextBoxColumn.HeaderText = "R_Phone";
            this.rPhoneDataGridViewTextBoxColumn.Name = "rPhoneDataGridViewTextBoxColumn";
            // 
            // rDescriptionDataGridViewTextBoxColumn
            // 
            this.rDescriptionDataGridViewTextBoxColumn.DataPropertyName = "R_Description";
            this.rDescriptionDataGridViewTextBoxColumn.HeaderText = "R_Description";
            this.rDescriptionDataGridViewTextBoxColumn.Name = "rDescriptionDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // tripBindingSource
            // 
            this.tripBindingSource.DataMember = "Trip";
            this.tripBindingSource.DataSource = this.dataBaseDataSet6;
            // 
            // dataBaseDataSet6
            // 
            this.dataBaseDataSet6.DataSetName = "DataBaseDataSet6";
            this.dataBaseDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Bt_Update
            // 
            this.Bt_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(131)))), ((int)(((byte)(47)))));
            this.Bt_Update.FlatAppearance.BorderSize = 0;
            this.Bt_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Update.Location = new System.Drawing.Point(658, 517);
            this.Bt_Update.Name = "Bt_Update";
            this.Bt_Update.Size = new System.Drawing.Size(130, 27);
            this.Bt_Update.TabIndex = 30;
            this.Bt_Update.Text = "Update";
            this.Bt_Update.UseVisualStyleBackColor = false;
            this.Bt_Update.Click += new System.EventHandler(this.Bt_Update_Click);
            // 
            // Tb_Statue
            // 
            this.Tb_Statue.Location = new System.Drawing.Point(602, 463);
            this.Tb_Statue.Name = "Tb_Statue";
            this.Tb_Statue.Size = new System.Drawing.Size(187, 20);
            this.Tb_Statue.TabIndex = 29;
            // 
            // Tb_Description
            // 
            this.Tb_Description.Location = new System.Drawing.Point(602, 414);
            this.Tb_Description.Name = "Tb_Description";
            this.Tb_Description.Size = new System.Drawing.Size(187, 20);
            this.Tb_Description.TabIndex = 28;
            // 
            // Tb_Phone2
            // 
            this.Tb_Phone2.Location = new System.Drawing.Point(374, 524);
            this.Tb_Phone2.Name = "Tb_Phone2";
            this.Tb_Phone2.Size = new System.Drawing.Size(178, 20);
            this.Tb_Phone2.TabIndex = 27;
            // 
            // Tb_Province2
            // 
            this.Tb_Province2.Location = new System.Drawing.Point(374, 473);
            this.Tb_Province2.Name = "Tb_Province2";
            this.Tb_Province2.Size = new System.Drawing.Size(178, 20);
            this.Tb_Province2.TabIndex = 26;
            // 
            // Tb_Postcode2
            // 
            this.Tb_Postcode2.Location = new System.Drawing.Point(374, 498);
            this.Tb_Postcode2.Name = "Tb_Postcode2";
            this.Tb_Postcode2.Size = new System.Drawing.Size(178, 20);
            this.Tb_Postcode2.TabIndex = 25;
            // 
            // Tb_City2
            // 
            this.Tb_City2.Location = new System.Drawing.Point(374, 447);
            this.Tb_City2.Name = "Tb_City2";
            this.Tb_City2.Size = new System.Drawing.Size(178, 20);
            this.Tb_City2.TabIndex = 24;
            // 
            // Tb_StreetAddress2
            // 
            this.Tb_StreetAddress2.Location = new System.Drawing.Point(374, 421);
            this.Tb_StreetAddress2.Name = "Tb_StreetAddress2";
            this.Tb_StreetAddress2.Size = new System.Drawing.Size(178, 20);
            this.Tb_StreetAddress2.TabIndex = 23;
            // 
            // Tb_Name2
            // 
            this.Tb_Name2.Location = new System.Drawing.Point(374, 395);
            this.Tb_Name2.Name = "Tb_Name2";
            this.Tb_Name2.Size = new System.Drawing.Size(178, 20);
            this.Tb_Name2.TabIndex = 22;
            // 
            // Tb_Phone
            // 
            this.Tb_Phone.Location = new System.Drawing.Point(84, 524);
            this.Tb_Phone.Name = "Tb_Phone";
            this.Tb_Phone.Size = new System.Drawing.Size(179, 20);
            this.Tb_Phone.TabIndex = 21;
            this.Tb_Phone.TextChanged += new System.EventHandler(this.Tb_Phone_TextChanged);
            // 
            // Tb_Province
            // 
            this.Tb_Province.Location = new System.Drawing.Point(84, 473);
            this.Tb_Province.Name = "Tb_Province";
            this.Tb_Province.Size = new System.Drawing.Size(179, 20);
            this.Tb_Province.TabIndex = 20;
            // 
            // Tb_PostCode
            // 
            this.Tb_PostCode.Location = new System.Drawing.Point(84, 498);
            this.Tb_PostCode.Name = "Tb_PostCode";
            this.Tb_PostCode.Size = new System.Drawing.Size(179, 20);
            this.Tb_PostCode.TabIndex = 19;
            this.Tb_PostCode.TextChanged += new System.EventHandler(this.Tb_PostCode_TextChanged);
            // 
            // Tb_City
            // 
            this.Tb_City.Location = new System.Drawing.Point(84, 447);
            this.Tb_City.Name = "Tb_City";
            this.Tb_City.Size = new System.Drawing.Size(179, 20);
            this.Tb_City.TabIndex = 18;
            // 
            // Tb_Streetname
            // 
            this.Tb_Streetname.Location = new System.Drawing.Point(84, 421);
            this.Tb_Streetname.Name = "Tb_Streetname";
            this.Tb_Streetname.Size = new System.Drawing.Size(179, 20);
            this.Tb_Streetname.TabIndex = 17;
            this.Tb_Streetname.TextChanged += new System.EventHandler(this.Tb_Streetname_TextChanged);
            // 
            // Tb_Name
            // 
            this.Tb_Name.Location = new System.Drawing.Point(84, 395);
            this.Tb_Name.Name = "Tb_Name";
            this.Tb_Name.Size = new System.Drawing.Size(179, 20);
            this.Tb_Name.TabIndex = 16;
            // 
            // tripTableAdapter
            // 
            this.tripTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 16);
            this.label7.TabIndex = 72;
            this.label7.Text = "Select the row you would like to edit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(228, 24);
            this.label10.TabIndex = 71;
            this.label10.Text = "Update Trip Information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(277, 16);
            this.label8.TabIndex = 73;
            this.label8.Text = "Enter the information you would like to change";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 79;
            this.label4.Text = "Province";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "Street:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 531);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 81;
            this.label5.Text = "Contact";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 507);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 80;
            this.label6.Text = "Postal Code:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(302, 527);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 87;
            this.label9.Text = "Contact";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(301, 501);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 86;
            this.label11.Text = "Postal Code:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(302, 477);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 85;
            this.label12.Text = "Province";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(302, 453);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 84;
            this.label13.Text = "City:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(302, 423);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 83;
            this.label14.Text = "Street:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(302, 395);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 82;
            this.label15.Text = "Name:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(599, 395);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 13);
            this.label16.TabIndex = 88;
            this.label16.Text = "Trip Description:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(599, 443);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 89;
            this.label17.Text = "Trip Status:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(13, 367);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(146, 16);
            this.label18.TabIndex = 90;
            this.label18.Text = "Cargo Pick-up location:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(302, 367);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(109, 16);
            this.label19.TabIndex = 91;
            this.label19.Text = "Drop-off location:";
            // 
            // Update_Trip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Bt_Update);
            this.Controls.Add(this.Tb_Statue);
            this.Controls.Add(this.Tb_Description);
            this.Controls.Add(this.Tb_Phone2);
            this.Controls.Add(this.Tb_Province2);
            this.Controls.Add(this.Tb_Postcode2);
            this.Controls.Add(this.Tb_City2);
            this.Controls.Add(this.Tb_StreetAddress2);
            this.Controls.Add(this.Tb_Name2);
            this.Controls.Add(this.Tb_Phone);
            this.Controls.Add(this.Tb_Province);
            this.Controls.Add(this.Tb_PostCode);
            this.Controls.Add(this.Tb_City);
            this.Controls.Add(this.Tb_Streetname);
            this.Controls.Add(this.Tb_Name);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Update_Trip";
            this.Size = new System.Drawing.Size(853, 574);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tripIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sStreetAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPostcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sProvinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rStreetAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rPostcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rProvinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tripBindingSource;
        private DataBaseDataSet6 dataBaseDataSet6;
        private System.Windows.Forms.Button Bt_Update;
        private System.Windows.Forms.TextBox Tb_Statue;
        private System.Windows.Forms.TextBox Tb_Description;
        private System.Windows.Forms.TextBox Tb_Phone2;
        private System.Windows.Forms.TextBox Tb_Province2;
        private System.Windows.Forms.TextBox Tb_Postcode2;
        private System.Windows.Forms.TextBox Tb_City2;
        private System.Windows.Forms.TextBox Tb_StreetAddress2;
        private System.Windows.Forms.TextBox Tb_Name2;
        private System.Windows.Forms.TextBox Tb_Phone;
        private System.Windows.Forms.TextBox Tb_Province;
        private System.Windows.Forms.TextBox Tb_PostCode;
        private System.Windows.Forms.TextBox Tb_City;
        private System.Windows.Forms.TextBox Tb_Streetname;
        private System.Windows.Forms.TextBox Tb_Name;
        private DataBaseDataSet6TableAdapters.TripTableAdapter tripTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}
