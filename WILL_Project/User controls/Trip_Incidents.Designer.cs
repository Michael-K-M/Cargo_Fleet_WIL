namespace WILL_Project
{
    partial class Trip_Incidents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trip_Incidents));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cb_NP = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Model = new System.Windows.Forms.TextBox();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Driver = new System.Windows.Forms.TextBox();
            this.tb_Make = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtb_Parties = new System.Windows.Forms.RichTextBox();
            this.rtb_Cause = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Location = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cb_NP);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tb_Model);
            this.panel1.Controls.Add(this.btn_Enter);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_Driver);
            this.panel1.Controls.Add(this.tb_Make);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rtb_Parties);
            this.panel1.Controls.Add(this.rtb_Cause);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_Location);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 571);
            this.panel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(226, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(246, 24);
            this.label10.TabIndex = 67;
            this.label10.Text = "REPORT TRIP INCIDENT";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(853, 177);
            this.panel2.TabIndex = 66;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(289, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // cb_NP
            // 
            this.cb_NP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_NP.FormattingEnabled = true;
            this.cb_NP.Location = new System.Drawing.Point(95, 256);
            this.cb_NP.Name = "cb_NP";
            this.cb_NP.Size = new System.Drawing.Size(172, 21);
            this.cb_NP.TabIndex = 15;
            this.cb_NP.SelectedIndexChanged += new System.EventHandler(this.cb_NP_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Vehicle Model:";
            // 
            // tb_Model
            // 
            this.tb_Model.Location = new System.Drawing.Point(97, 390);
            this.tb_Model.Name = "tb_Model";
            this.tb_Model.ReadOnly = true;
            this.tb_Model.Size = new System.Drawing.Size(172, 20);
            this.tb_Model.TabIndex = 13;
            // 
            // btn_Enter
            // 
            this.btn_Enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(131)))), ((int)(((byte)(47)))));
            this.btn_Enter.FlatAppearance.BorderSize = 0;
            this.btn_Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Enter.Location = new System.Drawing.Point(257, 433);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(180, 27);
            this.btn_Enter.TabIndex = 12;
            this.btn_Enter.Text = "Enter";
            this.btn_Enter.UseVisualStyleBackColor = false;
            this.btn_Enter.Click += new System.EventHandler(this.Btn_Enter_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Other Involved Parties:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vehicle Number Plate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vehicle Make:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Driver of Vehicle";
            // 
            // tb_Driver
            // 
            this.tb_Driver.Location = new System.Drawing.Point(96, 302);
            this.tb_Driver.Name = "tb_Driver";
            this.tb_Driver.ReadOnly = true;
            this.tb_Driver.Size = new System.Drawing.Size(172, 20);
            this.tb_Driver.TabIndex = 7;
            // 
            // tb_Make
            // 
            this.tb_Make.Location = new System.Drawing.Point(97, 346);
            this.tb_Make.Name = "tb_Make";
            this.tb_Make.ReadOnly = true;
            this.tb_Make.Size = new System.Drawing.Size(172, 20);
            this.tb_Make.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Incident description / cause:";
            // 
            // rtb_Parties
            // 
            this.rtb_Parties.Location = new System.Drawing.Point(298, 353);
            this.rtb_Parties.Name = "rtb_Parties";
            this.rtb_Parties.Size = new System.Drawing.Size(294, 57);
            this.rtb_Parties.TabIndex = 3;
            this.rtb_Parties.Text = "";
            this.rtb_Parties.TextChanged += new System.EventHandler(this.rtb_Parties_TextChanged);
            // 
            // rtb_Cause
            // 
            this.rtb_Cause.Location = new System.Drawing.Point(298, 274);
            this.rtb_Cause.Name = "rtb_Cause";
            this.rtb_Cause.Size = new System.Drawing.Size(294, 57);
            this.rtb_Cause.TabIndex = 2;
            this.rtb_Cause.Text = "";
            this.rtb_Cause.TextChanged += new System.EventHandler(this.rtb_Cause_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Location of Incident:";
            // 
            // tb_Location
            // 
            this.tb_Location.Location = new System.Drawing.Point(404, 231);
            this.tb_Location.Name = "tb_Location";
            this.tb_Location.Size = new System.Drawing.Size(188, 20);
            this.tb_Location.TabIndex = 0;
            this.tb_Location.TextChanged += new System.EventHandler(this.tb_Location_TextChanged);
            // 
            // Trip_Incidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel1);
            this.Name = "Trip_Incidents";
            this.Size = new System.Drawing.Size(853, 574);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Driver;
        private System.Windows.Forms.TextBox tb_Make;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtb_Parties;
        private System.Windows.Forms.RichTextBox rtb_Cause;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Location;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_Model;
        private System.Windows.Forms.ComboBox cb_NP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
    }
}
