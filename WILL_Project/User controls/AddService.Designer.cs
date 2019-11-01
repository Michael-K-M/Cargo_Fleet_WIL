namespace WILL_Project
{
    partial class AddService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddService));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_NP = new System.Windows.Forms.ComboBox();
            this.cb_VehicleMake = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.tb_Model = new System.Windows.Forms.TextBox();
            this.tb_TM = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cb_NP);
            this.panel1.Controls.Add(this.cb_VehicleMake);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.DTP);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_Enter);
            this.panel1.Controls.Add(this.tb_Model);
            this.panel1.Controls.Add(this.tb_TM);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 571);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(308, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 24);
            this.label8.TabIndex = 41;
            this.label8.Text = "STANDARD SERVICE";
            // 
            // cb_NP
            // 
            this.cb_NP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_NP.FormattingEnabled = true;
            this.cb_NP.Location = new System.Drawing.Point(340, 302);
            this.cb_NP.Name = "cb_NP";
            this.cb_NP.Size = new System.Drawing.Size(220, 21);
            this.cb_NP.TabIndex = 13;
            this.cb_NP.SelectedIndexChanged += new System.EventHandler(this.cb_NP_SelectedIndexChanged);
            // 
            // cb_VehicleMake
            // 
            this.cb_VehicleMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_VehicleMake.FormattingEnabled = true;
            this.cb_VehicleMake.Location = new System.Drawing.Point(340, 267);
            this.cb_VehicleMake.Name = "cb_VehicleMake";
            this.cb_VehicleMake.Size = new System.Drawing.Size(220, 21);
            this.cb_VehicleMake.TabIndex = 12;
            this.cb_VehicleMake.SelectedIndexChanged += new System.EventHandler(this.cb_VehicleMake_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Service Date";
            // 
            // DTP
            // 
            this.DTP.Location = new System.Drawing.Point(340, 337);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(220, 20);
            this.DTP.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Vehicle Make";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vehicle Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total Milage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number Plate";
            // 
            // btn_Enter
            // 
            this.btn_Enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(131)))), ((int)(((byte)(47)))));
            this.btn_Enter.FlatAppearance.BorderSize = 0;
            this.btn_Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enter.Location = new System.Drawing.Point(340, 442);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(170, 27);
            this.btn_Enter.TabIndex = 5;
            this.btn_Enter.Text = "Enter";
            this.btn_Enter.UseVisualStyleBackColor = false;
            this.btn_Enter.Click += new System.EventHandler(this.Btn_Enter_Click);
            // 
            // tb_Model
            // 
            this.tb_Model.Location = new System.Drawing.Point(340, 370);
            this.tb_Model.Name = "tb_Model";
            this.tb_Model.ReadOnly = true;
            this.tb_Model.Size = new System.Drawing.Size(220, 20);
            this.tb_Model.TabIndex = 4;
            this.tb_Model.TextChanged += new System.EventHandler(this.tb_Model_TextChanged);
            // 
            // tb_TM
            // 
            this.tb_TM.Location = new System.Drawing.Point(340, 404);
            this.tb_TM.Name = "tb_TM";
            this.tb_TM.Size = new System.Drawing.Size(220, 20);
            this.tb_TM.TabIndex = 3;
            this.tb_TM.TextChanged += new System.EventHandler(this.tb_TM_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(858, 177);
            this.panel2.TabIndex = 60;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(351, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // AddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel1);
            this.Name = "AddService";
            this.Size = new System.Drawing.Size(853, 574);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.TextBox tb_Model;
        private System.Windows.Forms.TextBox tb_TM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DTP;
        private System.Windows.Forms.ComboBox cb_NP;
        private System.Windows.Forms.ComboBox cb_VehicleMake;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
