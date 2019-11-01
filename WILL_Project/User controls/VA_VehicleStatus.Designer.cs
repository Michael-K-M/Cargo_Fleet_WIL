namespace WILL_Project
{
    partial class VA_VehicleStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VA_VehicleStatus));
            this.button2 = new System.Windows.Forms.Button();
            this.btn_SV = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_InService = new System.Windows.Forms.Button();
            this.DGV_TripStatus = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TripStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(131)))), ((int)(((byte)(47)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(338, 514);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Active / in-use";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btn_SV
            // 
            this.btn_SV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(131)))), ((int)(((byte)(47)))));
            this.btn_SV.FlatAppearance.BorderSize = 0;
            this.btn_SV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SV.Location = new System.Drawing.Point(159, 514);
            this.btn_SV.Name = "btn_SV";
            this.btn_SV.Size = new System.Drawing.Size(173, 29);
            this.btn_SV.TabIndex = 8;
            this.btn_SV.Text = "Stationary";
            this.btn_SV.UseVisualStyleBackColor = false;
            this.btn_SV.Click += new System.EventHandler(this.Btn_SV_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btn_InService);
            this.panel1.Controls.Add(this.DGV_TripStatus);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_SV);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 571);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(-5, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 177);
            this.panel2.TabIndex = 65;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(319, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 24);
            this.label10.TabIndex = 60;
            this.label10.Text = "VEHICLE STATUS";
            // 
            // btn_InService
            // 
            this.btn_InService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(131)))), ((int)(((byte)(47)))));
            this.btn_InService.FlatAppearance.BorderSize = 0;
            this.btn_InService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InService.Location = new System.Drawing.Point(517, 514);
            this.btn_InService.Name = "btn_InService";
            this.btn_InService.Size = new System.Drawing.Size(173, 29);
            this.btn_InService.TabIndex = 11;
            this.btn_InService.Text = "In service / repairs";
            this.btn_InService.UseVisualStyleBackColor = false;
            this.btn_InService.Click += new System.EventHandler(this.btn_InService_Click);
            // 
            // DGV_TripStatus
            // 
            this.DGV_TripStatus.AllowUserToAddRows = false;
            this.DGV_TripStatus.AllowUserToDeleteRows = false;
            this.DGV_TripStatus.AllowUserToOrderColumns = true;
            this.DGV_TripStatus.AllowUserToResizeColumns = false;
            this.DGV_TripStatus.AllowUserToResizeRows = false;
            this.DGV_TripStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_TripStatus.Location = new System.Drawing.Point(35, 231);
            this.DGV_TripStatus.Name = "DGV_TripStatus";
            this.DGV_TripStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_TripStatus.Size = new System.Drawing.Size(770, 267);
            this.DGV_TripStatus.TabIndex = 10;
            // 
            // VA_VehicleStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel1);
            this.Name = "VA_VehicleStatus";
            this.Size = new System.Drawing.Size(853, 574);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TripStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_SV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGV_TripStatus;
        private System.Windows.Forms.Button btn_InService;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
