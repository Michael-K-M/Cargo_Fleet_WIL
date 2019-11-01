namespace WILL_Project
{
    partial class serviceManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(serviceManager));
            this.panel_SM = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_ASS = new System.Windows.Forms.Button();
            this.btn_AIS = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_Names = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Minimiza = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exit2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_SM
            // 
            this.panel_SM.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_SM.Location = new System.Drawing.Point(226, 26);
            this.panel_SM.Name = "panel_SM";
            this.panel_SM.Size = new System.Drawing.Size(853, 574);
            this.panel_SM.TabIndex = 1;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(157)))), ((int)(((byte)(69)))));
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Location = new System.Drawing.Point(12, 562);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(203, 29);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // btn_ASS
            // 
            this.btn_ASS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ASS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ASS.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_ASS.Location = new System.Drawing.Point(-3, 266);
            this.btn_ASS.Name = "btn_ASS";
            this.btn_ASS.Size = new System.Drawing.Size(234, 39);
            this.btn_ASS.TabIndex = 3;
            this.btn_ASS.Text = "Add Standard Service";
            this.btn_ASS.UseVisualStyleBackColor = true;
            this.btn_ASS.Click += new System.EventHandler(this.Btn_AddService_Click);
            // 
            // btn_AIS
            // 
            this.btn_AIS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AIS.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_AIS.Location = new System.Drawing.Point(-3, 304);
            this.btn_AIS.Name = "btn_AIS";
            this.btn_AIS.Size = new System.Drawing.Size(234, 39);
            this.btn_AIS.TabIndex = 4;
            this.btn_AIS.Text = "Add Incident Service";
            this.btn_AIS.UseVisualStyleBackColor = true;
            this.btn_AIS.Click += new System.EventHandler(this.Btn_AIS_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(157)))), ((int)(((byte)(69)))));
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(12, 526);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(203, 29);
            this.btn_logout.TabIndex = 25;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(31, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(162, 158);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // label_Names
            // 
            this.label_Names.AutoSize = true;
            this.label_Names.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Names.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Names.Location = new System.Drawing.Point(43, 221);
            this.label_Names.Name = "label_Names";
            this.label_Names.Size = new System.Drawing.Size(101, 18);
            this.label_Names.TabIndex = 30;
            this.label_Names.Text = "USERNAME";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.btn_Minimiza);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_exit2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 27);
            this.panel1.TabIndex = 31;
            // 
            // btn_Minimiza
            // 
            this.btn_Minimiza.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minimiza.FlatAppearance.BorderSize = 0;
            this.btn_Minimiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimiza.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimiza.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_Minimiza.Location = new System.Drawing.Point(1028, -6);
            this.btn_Minimiza.Name = "btn_Minimiza";
            this.btn_Minimiza.Size = new System.Drawing.Size(29, 36);
            this.btn_Minimiza.TabIndex = 22;
            this.btn_Minimiza.Text = "—";
            this.btn_Minimiza.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Minimiza.UseVisualStyleBackColor = false;
            this.btn_Minimiza.Click += new System.EventHandler(this.btn_Minimiza_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Service Manager Dashboard";
            // 
            // btn_exit2
            // 
            this.btn_exit2.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit2.FlatAppearance.BorderSize = 0;
            this.btn_exit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_exit2.Location = new System.Drawing.Point(1057, -2);
            this.btn_exit2.Name = "btn_exit2";
            this.btn_exit2.Size = new System.Drawing.Size(27, 27);
            this.btn_exit2.TabIndex = 20;
            this.btn_exit2.Text = "X";
            this.btn_exit2.UseVisualStyleBackColor = false;
            this.btn_exit2.Click += new System.EventHandler(this.btn_exit2_Click);
            // 
            // serviceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1080, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_Names);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.panel_SM);
            this.Controls.Add(this.btn_ASS);
            this.Controls.Add(this.btn_AIS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "serviceManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Manager Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_SM;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_ASS;
        private System.Windows.Forms.Button btn_AIS;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_Names;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Minimiza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_exit2;
    }
}