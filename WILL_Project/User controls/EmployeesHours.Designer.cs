namespace WILL_Project
{
    partial class EmployeesHours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesHours));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LbWorkDate = new System.Windows.Forms.Label();
            this.DTPDate = new System.Windows.Forms.DateTimePicker();
            this.btn_Create = new System.Windows.Forms.Button();
            this.label_Money = new System.Windows.Forms.Label();
            this.tb_HourWage = new System.Windows.Forms.TextBox();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.label_StartDate = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Role = new System.Windows.Forms.Label();
            this.DTP_End = new System.Windows.Forms.DateTimePicker();
            this.DTP_Start = new System.Windows.Forms.DateTimePicker();
            this.cb_Name = new System.Windows.Forms.ComboBox();
            this.cb_Role = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.LbWorkDate);
            this.panel1.Controls.Add(this.DTPDate);
            this.panel1.Controls.Add(this.btn_Create);
            this.panel1.Controls.Add(this.label_Money);
            this.panel1.Controls.Add(this.tb_HourWage);
            this.panel1.Controls.Add(this.labelEndDate);
            this.panel1.Controls.Add(this.label_StartDate);
            this.panel1.Controls.Add(this.label_Name);
            this.panel1.Controls.Add(this.label_Role);
            this.panel1.Controls.Add(this.DTP_End);
            this.panel1.Controls.Add(this.DTP_Start);
            this.panel1.Controls.Add(this.cb_Name);
            this.panel1.Controls.Add(this.cb_Role);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 571);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(243, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(330, 24);
            this.label10.TabIndex = 63;
            this.label10.Text = "EMPLOYEE HOURS AND WAGES";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(863, 175);
            this.panel2.TabIndex = 62;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(351, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // LbWorkDate
            // 
            this.LbWorkDate.AutoSize = true;
            this.LbWorkDate.Location = new System.Drawing.Point(266, 310);
            this.LbWorkDate.Name = "LbWorkDate";
            this.LbWorkDate.Size = new System.Drawing.Size(62, 13);
            this.LbWorkDate.TabIndex = 25;
            this.LbWorkDate.Text = "Work Date:";
            // 
            // DTPDate
            // 
            this.DTPDate.Location = new System.Drawing.Point(346, 304);
            this.DTPDate.Name = "DTPDate";
            this.DTPDate.Size = new System.Drawing.Size(200, 20);
            this.DTPDate.TabIndex = 24;
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(131)))), ((int)(((byte)(47)))));
            this.btn_Create.FlatAppearance.BorderSize = 0;
            this.btn_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Create.Location = new System.Drawing.Point(321, 446);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(180, 27);
            this.btn_Create.TabIndex = 21;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Click += new System.EventHandler(this.Btn_Create_Click);
            // 
            // label_Money
            // 
            this.label_Money.AutoSize = true;
            this.label_Money.Location = new System.Drawing.Point(266, 404);
            this.label_Money.Name = "label_Money";
            this.label_Money.Size = new System.Drawing.Size(72, 13);
            this.label_Money.TabIndex = 20;
            this.label_Money.Text = "Hourly Wage:";
            // 
            // tb_HourWage
            // 
            this.tb_HourWage.Location = new System.Drawing.Point(346, 400);
            this.tb_HourWage.Name = "tb_HourWage";
            this.tb_HourWage.Size = new System.Drawing.Size(200, 20);
            this.tb_HourWage.TabIndex = 19;
            this.tb_HourWage.TextChanged += new System.EventHandler(this.tb_HourWage_TextChanged);
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(266, 375);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(55, 13);
            this.labelEndDate.TabIndex = 7;
            this.labelEndDate.Text = "End Time:";
            // 
            // label_StartDate
            // 
            this.label_StartDate.AutoSize = true;
            this.label_StartDate.Location = new System.Drawing.Point(265, 343);
            this.label_StartDate.Name = "label_StartDate";
            this.label_StartDate.Size = new System.Drawing.Size(58, 13);
            this.label_StartDate.TabIndex = 6;
            this.label_StartDate.Text = "Start Time:";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(266, 275);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(57, 13);
            this.label_Name.TabIndex = 5;
            this.label_Name.Text = "Full Name:";
            // 
            // label_Role
            // 
            this.label_Role.AutoSize = true;
            this.label_Role.Location = new System.Drawing.Point(266, 247);
            this.label_Role.Name = "label_Role";
            this.label_Role.Size = new System.Drawing.Size(74, 13);
            this.label_Role.TabIndex = 4;
            this.label_Role.Text = "Position/Role:";
            // 
            // DTP_End
            // 
            this.DTP_End.CustomFormat = " ";
            this.DTP_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_End.Location = new System.Drawing.Point(346, 369);
            this.DTP_End.Name = "DTP_End";
            this.DTP_End.ShowUpDown = true;
            this.DTP_End.Size = new System.Drawing.Size(200, 20);
            this.DTP_End.TabIndex = 3;
            // 
            // DTP_Start
            // 
            this.DTP_Start.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.DTP_Start.CustomFormat = " ";
            this.DTP_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_Start.Location = new System.Drawing.Point(346, 336);
            this.DTP_Start.Name = "DTP_Start";
            this.DTP_Start.ShowUpDown = true;
            this.DTP_Start.Size = new System.Drawing.Size(200, 20);
            this.DTP_Start.TabIndex = 2;
            this.DTP_Start.Value = new System.DateTime(2019, 10, 25, 23, 59, 59, 0);
            this.DTP_Start.ValueChanged += new System.EventHandler(this.DTP_Start_ValueChanged);
            // 
            // cb_Name
            // 
            this.cb_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Name.FormattingEnabled = true;
            this.cb_Name.Location = new System.Drawing.Point(346, 272);
            this.cb_Name.Name = "cb_Name";
            this.cb_Name.Size = new System.Drawing.Size(200, 21);
            this.cb_Name.TabIndex = 1;
            this.cb_Name.SelectedIndexChanged += new System.EventHandler(this.Cb_Name_SelectedIndexChanged);
            // 
            // cb_Role
            // 
            this.cb_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Role.FormattingEnabled = true;
            this.cb_Role.Location = new System.Drawing.Point(346, 243);
            this.cb_Role.Name = "cb_Role";
            this.cb_Role.Size = new System.Drawing.Size(200, 21);
            this.cb_Role.TabIndex = 0;
            this.cb_Role.SelectedIndexChanged += new System.EventHandler(this.Cb_Role_SelectedIndexChanged);
            // 
            // EmployeesHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel1);
            this.Name = "EmployeesHours";
            this.Size = new System.Drawing.Size(853, 574);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label label_StartDate;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Role;
        private System.Windows.Forms.DateTimePicker DTP_End;
        private System.Windows.Forms.DateTimePicker DTP_Start;
        private System.Windows.Forms.ComboBox cb_Name;
        private System.Windows.Forms.ComboBox cb_Role;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label_Money;
        private System.Windows.Forms.TextBox tb_HourWage;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Label LbWorkDate;
        private System.Windows.Forms.DateTimePicker DTPDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
    }
}
