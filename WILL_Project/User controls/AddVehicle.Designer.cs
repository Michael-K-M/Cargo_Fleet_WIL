namespace WILL_Project
{
    partial class AddVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVehicle));
            this.panel_AddVehicle = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Create = new System.Windows.Forms.Button();
            this.cb_capa = new System.Windows.Forms.ComboBox();
            this.tb_ES = new System.Windows.Forms.TextBox();
            this.tb_VM = new System.Windows.Forms.TextBox();
            this.tb_NP = new System.Windows.Forms.TextBox();
            this.tb_VIN = new System.Windows.Forms.TextBox();
            this.tb_VYear = new System.Windows.Forms.TextBox();
            this.tb_VMake = new System.Windows.Forms.TextBox();
            this.label_NP = new System.Windows.Forms.Label();
            this.label_VIN = new System.Windows.Forms.Label();
            this.label_Capa = new System.Windows.Forms.Label();
            this.label_ES = new System.Windows.Forms.Label();
            this.label_VY = new System.Windows.Forms.Label();
            this.label_VM = new System.Windows.Forms.Label();
            this.label_Make = new System.Windows.Forms.Label();
            this.panel_AddVehicle.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_AddVehicle
            // 
            this.panel_AddVehicle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_AddVehicle.Controls.Add(this.panel1);
            this.panel_AddVehicle.Controls.Add(this.label10);
            this.panel_AddVehicle.Controls.Add(this.btn_Create);
            this.panel_AddVehicle.Controls.Add(this.cb_capa);
            this.panel_AddVehicle.Controls.Add(this.tb_ES);
            this.panel_AddVehicle.Controls.Add(this.tb_VM);
            this.panel_AddVehicle.Controls.Add(this.tb_NP);
            this.panel_AddVehicle.Controls.Add(this.tb_VIN);
            this.panel_AddVehicle.Controls.Add(this.tb_VYear);
            this.panel_AddVehicle.Controls.Add(this.tb_VMake);
            this.panel_AddVehicle.Controls.Add(this.label_NP);
            this.panel_AddVehicle.Controls.Add(this.label_VIN);
            this.panel_AddVehicle.Controls.Add(this.label_Capa);
            this.panel_AddVehicle.Controls.Add(this.label_ES);
            this.panel_AddVehicle.Controls.Add(this.label_VY);
            this.panel_AddVehicle.Controls.Add(this.label_VM);
            this.panel_AddVehicle.Controls.Add(this.label_Make);
            this.panel_AddVehicle.Location = new System.Drawing.Point(0, 0);
            this.panel_AddVehicle.Name = "panel_AddVehicle";
            this.panel_AddVehicle.Size = new System.Drawing.Size(853, 571);
            this.panel_AddVehicle.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 183);
            this.panel1.TabIndex = 61;
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
            this.label10.Location = new System.Drawing.Point(331, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 24);
            this.label10.TabIndex = 60;
            this.label10.Text = "ADD VEHICLES";
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(131)))), ((int)(((byte)(47)))));
            this.btn_Create.FlatAppearance.BorderSize = 0;
            this.btn_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Create.Location = new System.Drawing.Point(335, 469);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(170, 27);
            this.btn_Create.TabIndex = 14;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Click += new System.EventHandler(this.Btn_Create_Click);
            // 
            // cb_capa
            // 
            this.cb_capa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_capa.FormattingEnabled = true;
            this.cb_capa.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "XLarg",
            "XX Large",
            "XXX Large"});
            this.cb_capa.Location = new System.Drawing.Point(371, 429);
            this.cb_capa.Name = "cb_capa";
            this.cb_capa.Size = new System.Drawing.Size(168, 21);
            this.cb_capa.TabIndex = 13;
            // 
            // tb_ES
            // 
            this.tb_ES.Location = new System.Drawing.Point(371, 397);
            this.tb_ES.Name = "tb_ES";
            this.tb_ES.Size = new System.Drawing.Size(168, 20);
            this.tb_ES.TabIndex = 12;
            this.tb_ES.TextChanged += new System.EventHandler(this.tb_ES_TextChanged);
            // 
            // tb_VM
            // 
            this.tb_VM.Location = new System.Drawing.Point(371, 367);
            this.tb_VM.Name = "tb_VM";
            this.tb_VM.Size = new System.Drawing.Size(168, 20);
            this.tb_VM.TabIndex = 11;
            this.tb_VM.TextChanged += new System.EventHandler(this.tb_VM_TextChanged);
            // 
            // tb_NP
            // 
            this.tb_NP.Location = new System.Drawing.Point(371, 336);
            this.tb_NP.Name = "tb_NP";
            this.tb_NP.Size = new System.Drawing.Size(168, 20);
            this.tb_NP.TabIndex = 10;
            this.tb_NP.TextChanged += new System.EventHandler(this.tb_NP_TextChanged);
            // 
            // tb_VIN
            // 
            this.tb_VIN.Location = new System.Drawing.Point(371, 305);
            this.tb_VIN.Name = "tb_VIN";
            this.tb_VIN.Size = new System.Drawing.Size(168, 20);
            this.tb_VIN.TabIndex = 9;
            this.tb_VIN.TextChanged += new System.EventHandler(this.tb_VIN_TextChanged);
            // 
            // tb_VYear
            // 
            this.tb_VYear.Location = new System.Drawing.Point(371, 275);
            this.tb_VYear.Name = "tb_VYear";
            this.tb_VYear.Size = new System.Drawing.Size(168, 20);
            this.tb_VYear.TabIndex = 8;
            this.tb_VYear.TextChanged += new System.EventHandler(this.tb_VYear_TextChanged);
            // 
            // tb_VMake
            // 
            this.tb_VMake.Location = new System.Drawing.Point(371, 245);
            this.tb_VMake.Name = "tb_VMake";
            this.tb_VMake.Size = new System.Drawing.Size(168, 20);
            this.tb_VMake.TabIndex = 7;
            this.tb_VMake.TextChanged += new System.EventHandler(this.tb_VMake_TextChanged);
            // 
            // label_NP
            // 
            this.label_NP.AutoSize = true;
            this.label_NP.Location = new System.Drawing.Point(286, 339);
            this.label_NP.Name = "label_NP";
            this.label_NP.Size = new System.Drawing.Size(74, 13);
            this.label_NP.TabIndex = 6;
            this.label_NP.Text = "Number Plate:";
            // 
            // label_VIN
            // 
            this.label_VIN.AutoSize = true;
            this.label_VIN.Location = new System.Drawing.Point(286, 308);
            this.label_VIN.Name = "label_VIN";
            this.label_VIN.Size = new System.Drawing.Size(68, 13);
            this.label_VIN.TabIndex = 5;
            this.label_VIN.Text = "VIN Number:";
            // 
            // label_Capa
            // 
            this.label_Capa.AutoSize = true;
            this.label_Capa.Location = new System.Drawing.Point(286, 428);
            this.label_Capa.Name = "label_Capa";
            this.label_Capa.Size = new System.Drawing.Size(51, 13);
            this.label_Capa.TabIndex = 4;
            this.label_Capa.Text = "Capacity:";
            this.label_Capa.Click += new System.EventHandler(this.Label_Capa_Click);
            // 
            // label_ES
            // 
            this.label_ES.AutoSize = true;
            this.label_ES.Location = new System.Drawing.Point(286, 400);
            this.label_ES.Name = "label_ES";
            this.label_ES.Size = new System.Drawing.Size(66, 13);
            this.label_ES.TabIndex = 3;
            this.label_ES.Text = "Engine Size:";
            // 
            // label_VY
            // 
            this.label_VY.AutoSize = true;
            this.label_VY.Location = new System.Drawing.Point(286, 282);
            this.label_VY.Name = "label_VY";
            this.label_VY.Size = new System.Drawing.Size(70, 13);
            this.label_VY.TabIndex = 2;
            this.label_VY.Text = "Vehical Year:";
            // 
            // label_VM
            // 
            this.label_VM.AutoSize = true;
            this.label_VM.Location = new System.Drawing.Point(286, 370);
            this.label_VM.Name = "label_VM";
            this.label_VM.Size = new System.Drawing.Size(77, 13);
            this.label_VM.TabIndex = 1;
            this.label_VM.Text = "Vehical Model:";
            // 
            // label_Make
            // 
            this.label_Make.AutoSize = true;
            this.label_Make.Location = new System.Drawing.Point(286, 252);
            this.label_Make.Name = "label_Make";
            this.label_Make.Size = new System.Drawing.Size(75, 13);
            this.label_Make.TabIndex = 0;
            this.label_Make.Text = "Vehical Make:";
            // 
            // AddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel_AddVehicle);
            this.Name = "AddVehicle";
            this.Size = new System.Drawing.Size(853, 574);
            this.panel_AddVehicle.ResumeLayout(false);
            this.panel_AddVehicle.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_AddVehicle;
        private System.Windows.Forms.Label label_Capa;
        private System.Windows.Forms.Label label_ES;
        private System.Windows.Forms.Label label_VY;
        private System.Windows.Forms.Label label_VM;
        private System.Windows.Forms.Label label_Make;
        private System.Windows.Forms.ComboBox cb_capa;
        private System.Windows.Forms.TextBox tb_ES;
        private System.Windows.Forms.TextBox tb_VM;
        private System.Windows.Forms.TextBox tb_NP;
        private System.Windows.Forms.TextBox tb_VIN;
        private System.Windows.Forms.TextBox tb_VYear;
        private System.Windows.Forms.TextBox tb_VMake;
        private System.Windows.Forms.Label label_NP;
        private System.Windows.Forms.Label label_VIN;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
