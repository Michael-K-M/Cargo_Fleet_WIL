namespace WILL_Project
{
    partial class CreateTrip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTrip));
            this.cb_RProv = new System.Windows.Forms.ComboBox();
            this.cb_SProv = new System.Windows.Forms.ComboBox();
            this.btn_Create = new System.Windows.Forms.Button();
            this.tb_RDesc = new System.Windows.Forms.TextBox();
            this.tb_RPhone = new System.Windows.Forms.TextBox();
            this.tb_RPostcode = new System.Windows.Forms.TextBox();
            this.tb_RTown = new System.Windows.Forms.TextBox();
            this.R_SAddress = new System.Windows.Forms.TextBox();
            this.tb_RName = new System.Windows.Forms.TextBox();
            this.tb_SenderPhone = new System.Windows.Forms.TextBox();
            this.tb_senderPC = new System.Windows.Forms.TextBox();
            this.tb_SenderCity = new System.Windows.Forms.TextBox();
            this.tb_SenderSA = new System.Windows.Forms.TextBox();
            this.tb_SenderName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_SP = new System.Windows.Forms.Label();
            this.label_Postcode = new System.Windows.Forms.Label();
            this.label_Prov = new System.Windows.Forms.Label();
            this.label_City = new System.Windows.Forms.Label();
            this.label_Sender = new System.Windows.Forms.Label();
            this.label_From = new System.Windows.Forms.Label();
            this.label_To = new System.Windows.Forms.Label();
            this.label_Desc = new System.Windows.Forms.Label();
            this.label_Address = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_RProv
            // 
            this.cb_RProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_RProv.FormattingEnabled = true;
            this.cb_RProv.Items.AddRange(new object[] {
            "--Select Porovince--",
            "Northern Cape",
            "Mpumalanga",
            "Eastern Cape",
            "Gauteng",
            "KwaZulu-Natal",
            "Limpopo",
            "North West",
            "Free State",
            "Western Cape"});
            this.cb_RProv.Location = new System.Drawing.Point(552, 402);
            this.cb_RProv.Name = "cb_RProv";
            this.cb_RProv.Size = new System.Drawing.Size(185, 21);
            this.cb_RProv.TabIndex = 61;
            // 
            // cb_SProv
            // 
            this.cb_SProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SProv.FormattingEnabled = true;
            this.cb_SProv.Items.AddRange(new object[] {
            "--Select Province--",
            "Northern Cape",
            "Mpumalanga",
            "Eastern Cape",
            "Gauteng",
            "KwaZulu-Natal",
            "Limpopo",
            "North West",
            "Free State",
            "Western Cape"});
            this.cb_SProv.Location = new System.Drawing.Point(151, 402);
            this.cb_SProv.Name = "cb_SProv";
            this.cb_SProv.Size = new System.Drawing.Size(180, 21);
            this.cb_SProv.TabIndex = 60;
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(131)))), ((int)(((byte)(47)))));
            this.btn_Create.FlatAppearance.BorderSize = 0;
            this.btn_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Create.Location = new System.Drawing.Point(607, 518);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(130, 27);
            this.btn_Create.TabIndex = 59;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click_1);
            // 
            // tb_RDesc
            // 
            this.tb_RDesc.Location = new System.Drawing.Point(552, 436);
            this.tb_RDesc.Name = "tb_RDesc";
            this.tb_RDesc.Size = new System.Drawing.Size(185, 20);
            this.tb_RDesc.TabIndex = 58;
            this.tb_RDesc.TextChanged += new System.EventHandler(this.tb_RDesc_TextChanged);
            // 
            // tb_RPhone
            // 
            this.tb_RPhone.Location = new System.Drawing.Point(552, 469);
            this.tb_RPhone.Name = "tb_RPhone";
            this.tb_RPhone.Size = new System.Drawing.Size(185, 20);
            this.tb_RPhone.TabIndex = 57;
            this.tb_RPhone.TextChanged += new System.EventHandler(this.tb_RPhone_TextChanged);
            // 
            // tb_RPostcode
            // 
            this.tb_RPostcode.Location = new System.Drawing.Point(552, 366);
            this.tb_RPostcode.Name = "tb_RPostcode";
            this.tb_RPostcode.Size = new System.Drawing.Size(185, 20);
            this.tb_RPostcode.TabIndex = 56;
            this.tb_RPostcode.TextChanged += new System.EventHandler(this.tb_RPostcode_TextChanged);
            // 
            // tb_RTown
            // 
            this.tb_RTown.Location = new System.Drawing.Point(552, 332);
            this.tb_RTown.Name = "tb_RTown";
            this.tb_RTown.Size = new System.Drawing.Size(185, 20);
            this.tb_RTown.TabIndex = 55;
            this.tb_RTown.TextChanged += new System.EventHandler(this.tb_RTown_TextChanged);
            // 
            // R_SAddress
            // 
            this.R_SAddress.Location = new System.Drawing.Point(552, 297);
            this.R_SAddress.Name = "R_SAddress";
            this.R_SAddress.Size = new System.Drawing.Size(185, 20);
            this.R_SAddress.TabIndex = 54;
            this.R_SAddress.TextChanged += new System.EventHandler(this.R_SAddress_TextChanged);
            // 
            // tb_RName
            // 
            this.tb_RName.Location = new System.Drawing.Point(552, 264);
            this.tb_RName.Name = "tb_RName";
            this.tb_RName.Size = new System.Drawing.Size(185, 20);
            this.tb_RName.TabIndex = 53;
            this.tb_RName.TextChanged += new System.EventHandler(this.tb_RName_TextChanged);
            // 
            // tb_SenderPhone
            // 
            this.tb_SenderPhone.Location = new System.Drawing.Point(151, 437);
            this.tb_SenderPhone.Name = "tb_SenderPhone";
            this.tb_SenderPhone.Size = new System.Drawing.Size(180, 20);
            this.tb_SenderPhone.TabIndex = 52;
            this.tb_SenderPhone.TextChanged += new System.EventHandler(this.tb_SenderPhone_TextChanged);
            // 
            // tb_senderPC
            // 
            this.tb_senderPC.Location = new System.Drawing.Point(151, 369);
            this.tb_senderPC.Name = "tb_senderPC";
            this.tb_senderPC.Size = new System.Drawing.Size(180, 20);
            this.tb_senderPC.TabIndex = 51;
            this.tb_senderPC.TextChanged += new System.EventHandler(this.tb_senderPC_TextChanged);
            // 
            // tb_SenderCity
            // 
            this.tb_SenderCity.Location = new System.Drawing.Point(151, 335);
            this.tb_SenderCity.Name = "tb_SenderCity";
            this.tb_SenderCity.Size = new System.Drawing.Size(180, 20);
            this.tb_SenderCity.TabIndex = 50;
            this.tb_SenderCity.TextChanged += new System.EventHandler(this.tb_SenderCity_TextChanged);
            // 
            // tb_SenderSA
            // 
            this.tb_SenderSA.Location = new System.Drawing.Point(151, 301);
            this.tb_SenderSA.Name = "tb_SenderSA";
            this.tb_SenderSA.Size = new System.Drawing.Size(180, 20);
            this.tb_SenderSA.TabIndex = 49;
            this.tb_SenderSA.TextChanged += new System.EventHandler(this.tb_SenderSA_TextChanged);
            // 
            // tb_SenderName
            // 
            this.tb_SenderName.Location = new System.Drawing.Point(151, 268);
            this.tb_SenderName.Name = "tb_SenderName";
            this.tb_SenderName.Size = new System.Drawing.Size(180, 20);
            this.tb_SenderName.TabIndex = 48;
            this.tb_SenderName.TextChanged += new System.EventHandler(this.tb_SenderName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Contact:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Postcode:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Province:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "City/Town:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Street Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Receiving location:";
            // 
            // label_SP
            // 
            this.label_SP.AutoSize = true;
            this.label_SP.Location = new System.Drawing.Point(58, 440);
            this.label_SP.Name = "label_SP";
            this.label_SP.Size = new System.Drawing.Size(47, 13);
            this.label_SP.TabIndex = 41;
            this.label_SP.Text = "Contact:";
            // 
            // label_Postcode
            // 
            this.label_Postcode.AutoSize = true;
            this.label_Postcode.Location = new System.Drawing.Point(58, 373);
            this.label_Postcode.Name = "label_Postcode";
            this.label_Postcode.Size = new System.Drawing.Size(55, 13);
            this.label_Postcode.TabIndex = 40;
            this.label_Postcode.Text = "Postcode:";
            // 
            // label_Prov
            // 
            this.label_Prov.AutoSize = true;
            this.label_Prov.Location = new System.Drawing.Point(58, 406);
            this.label_Prov.Name = "label_Prov";
            this.label_Prov.Size = new System.Drawing.Size(52, 13);
            this.label_Prov.TabIndex = 39;
            this.label_Prov.Text = "Province:";
            // 
            // label_City
            // 
            this.label_City.AutoSize = true;
            this.label_City.Location = new System.Drawing.Point(58, 338);
            this.label_City.Name = "label_City";
            this.label_City.Size = new System.Drawing.Size(59, 13);
            this.label_City.TabIndex = 38;
            this.label_City.Text = "City/Town:";
            // 
            // label_Sender
            // 
            this.label_Sender.AutoSize = true;
            this.label_Sender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Sender.Location = new System.Drawing.Point(58, 223);
            this.label_Sender.Name = "label_Sender";
            this.label_Sender.Size = new System.Drawing.Size(193, 20);
            this.label_Sender.TabIndex = 37;
            this.label_Sender.Text = "DEPO PICK-UP DETAILS";
            // 
            // label_From
            // 
            this.label_From.AutoSize = true;
            this.label_From.Location = new System.Drawing.Point(59, 271);
            this.label_From.Name = "label_From";
            this.label_From.Size = new System.Drawing.Size(89, 13);
            this.label_From.TabIndex = 36;
            this.label_From.Text = "Sending location:";
            // 
            // label_To
            // 
            this.label_To.AutoSize = true;
            this.label_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_To.Location = new System.Drawing.Point(445, 223);
            this.label_To.Name = "label_To";
            this.label_To.Size = new System.Drawing.Size(163, 20);
            this.label_To.TabIndex = 35;
            this.label_To.Text = "DROP OFF DETAILS";
            // 
            // label_Desc
            // 
            this.label_Desc.AutoSize = true;
            this.label_Desc.Location = new System.Drawing.Point(448, 443);
            this.label_Desc.Name = "label_Desc";
            this.label_Desc.Size = new System.Drawing.Size(63, 13);
            this.label_Desc.TabIndex = 34;
            this.label_Desc.Text = "Description:";
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Location = new System.Drawing.Point(58, 304);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(79, 13);
            this.label_Address.TabIndex = 33;
            this.label_Address.Text = "Street Address:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(349, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(853, 166);
            this.panel2.TabIndex = 62;
            // 
            // CreateTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cb_RProv);
            this.Controls.Add(this.cb_SProv);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.tb_RDesc);
            this.Controls.Add(this.tb_RPhone);
            this.Controls.Add(this.tb_RPostcode);
            this.Controls.Add(this.tb_RTown);
            this.Controls.Add(this.R_SAddress);
            this.Controls.Add(this.tb_RName);
            this.Controls.Add(this.tb_SenderPhone);
            this.Controls.Add(this.tb_senderPC);
            this.Controls.Add(this.tb_SenderCity);
            this.Controls.Add(this.tb_SenderSA);
            this.Controls.Add(this.tb_SenderName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_SP);
            this.Controls.Add(this.label_Postcode);
            this.Controls.Add(this.label_Prov);
            this.Controls.Add(this.label_City);
            this.Controls.Add(this.label_Sender);
            this.Controls.Add(this.label_From);
            this.Controls.Add(this.label_To);
            this.Controls.Add(this.label_Desc);
            this.Controls.Add(this.label_Address);
            this.Name = "CreateTrip";
            this.Size = new System.Drawing.Size(853, 574);
            this.Load += new System.EventHandler(this.CreateTrip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_RProv;
        private System.Windows.Forms.ComboBox cb_SProv;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.TextBox tb_RDesc;
        private System.Windows.Forms.TextBox tb_RPhone;
        private System.Windows.Forms.TextBox tb_RPostcode;
        private System.Windows.Forms.TextBox tb_RTown;
        private System.Windows.Forms.TextBox R_SAddress;
        private System.Windows.Forms.TextBox tb_RName;
        private System.Windows.Forms.TextBox tb_SenderPhone;
        private System.Windows.Forms.TextBox tb_senderPC;
        private System.Windows.Forms.TextBox tb_SenderCity;
        private System.Windows.Forms.TextBox tb_SenderSA;
        private System.Windows.Forms.TextBox tb_SenderName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_SP;
        private System.Windows.Forms.Label label_Postcode;
        private System.Windows.Forms.Label label_Prov;
        private System.Windows.Forms.Label label_City;
        private System.Windows.Forms.Label label_Sender;
        private System.Windows.Forms.Label label_From;
        private System.Windows.Forms.Label label_To;
        private System.Windows.Forms.Label label_Desc;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
    }
}
