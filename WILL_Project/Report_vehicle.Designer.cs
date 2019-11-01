namespace WILL_Project
{
    partial class Report_vehicle
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
            this.dg_vehicle_report = new System.Windows.Forms.DataGridView();
            this.btn_vehicles_service_complete = new System.Windows.Forms.Button();
            this.btn_vehicles_booked_service = new System.Windows.Forms.Button();
            this.btn_View_all_vehicles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_vehicle_report)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_vehicle_report
            // 
            this.dg_vehicle_report.AllowUserToDeleteRows = false;
            this.dg_vehicle_report.AllowUserToResizeColumns = false;
            this.dg_vehicle_report.AllowUserToResizeRows = false;
            this.dg_vehicle_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_vehicle_report.Location = new System.Drawing.Point(35, 52);
            this.dg_vehicle_report.Name = "dg_vehicle_report";
            this.dg_vehicle_report.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_vehicle_report.Size = new System.Drawing.Size(766, 341);
            this.dg_vehicle_report.TabIndex = 0;
            // 
            // btn_vehicles_service_complete
            // 
            this.btn_vehicles_service_complete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(131)))), ((int)(((byte)(47)))));
            this.btn_vehicles_service_complete.FlatAppearance.BorderSize = 0;
            this.btn_vehicles_service_complete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vehicles_service_complete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vehicles_service_complete.Location = new System.Drawing.Point(571, 428);
            this.btn_vehicles_service_complete.Name = "btn_vehicles_service_complete";
            this.btn_vehicles_service_complete.Size = new System.Drawing.Size(215, 29);
            this.btn_vehicles_service_complete.TabIndex = 14;
            this.btn_vehicles_service_complete.Text = "Vehicle service completed";
            this.btn_vehicles_service_complete.UseVisualStyleBackColor = false;
            this.btn_vehicles_service_complete.Click += new System.EventHandler(this.Btn_vehicles_service_complete_Click);
            // 
            // btn_vehicles_booked_service
            // 
            this.btn_vehicles_booked_service.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(131)))), ((int)(((byte)(47)))));
            this.btn_vehicles_booked_service.FlatAppearance.BorderSize = 0;
            this.btn_vehicles_booked_service.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vehicles_booked_service.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vehicles_booked_service.Location = new System.Drawing.Point(318, 428);
            this.btn_vehicles_booked_service.Name = "btn_vehicles_booked_service";
            this.btn_vehicles_booked_service.Size = new System.Drawing.Size(247, 29);
            this.btn_vehicles_booked_service.TabIndex = 13;
            this.btn_vehicles_booked_service.Text = "Vehicles booked for a service";
            this.btn_vehicles_booked_service.UseVisualStyleBackColor = false;
            this.btn_vehicles_booked_service.Click += new System.EventHandler(this.Btn_vehicles_booked_service_Click);
            // 
            // btn_View_all_vehicles
            // 
            this.btn_View_all_vehicles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(131)))), ((int)(((byte)(47)))));
            this.btn_View_all_vehicles.FlatAppearance.BorderSize = 0;
            this.btn_View_all_vehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_View_all_vehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_all_vehicles.Location = new System.Drawing.Point(95, 428);
            this.btn_View_all_vehicles.Name = "btn_View_all_vehicles";
            this.btn_View_all_vehicles.Size = new System.Drawing.Size(217, 29);
            this.btn_View_all_vehicles.TabIndex = 12;
            this.btn_View_all_vehicles.Text = "View all Vehicles";
            this.btn_View_all_vehicles.UseVisualStyleBackColor = false;
            this.btn_View_all_vehicles.Click += new System.EventHandler(this.Btn_View_all_vehicles_Click);
            // 
            // Report_vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_vehicles_service_complete);
            this.Controls.Add(this.btn_vehicles_booked_service);
            this.Controls.Add(this.btn_View_all_vehicles);
            this.Controls.Add(this.dg_vehicle_report);
            this.Name = "Report_vehicle";
            this.Size = new System.Drawing.Size(853, 574);
            ((System.ComponentModel.ISupportInitialize)(this.dg_vehicle_report)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_vehicle_report;
        private System.Windows.Forms.Button btn_vehicles_service_complete;
        private System.Windows.Forms.Button btn_vehicles_booked_service;
        private System.Windows.Forms.Button btn_View_all_vehicles;
    }
}
