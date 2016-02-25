namespace tracker
{
    partial class frmFuelEntry
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
            this.lstVehicle = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtOdometer = new System.Windows.Forms.TextBox();
            this.txtVendor = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblOdometer = new System.Windows.Forms.Label();
            this.lblVendor = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGallons = new System.Windows.Forms.TextBox();
            this.lblTripOdom = new System.Windows.Forms.Label();
            this.txtTripOdometer = new System.Windows.Forms.TextBox();
            this.lstState = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstVehicle
            // 
            this.lstVehicle.FormattingEnabled = true;
            this.lstVehicle.Location = new System.Drawing.Point(22, 12);
            this.lstVehicle.Name = "lstVehicle";
            this.lstVehicle.Size = new System.Drawing.Size(120, 95);
            this.lstVehicle.TabIndex = 14;
            this.lstVehicle.SelectedIndexChanged += new System.EventHandler(this.lstVehicle_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(125, 196);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtOdometer
            // 
            this.txtOdometer.Location = new System.Drawing.Point(107, 143);
            this.txtOdometer.Name = "txtOdometer";
            this.txtOdometer.Size = new System.Drawing.Size(100, 20);
            this.txtOdometer.TabIndex = 19;
            // 
            // txtVendor
            // 
            this.txtVendor.Location = new System.Drawing.Point(216, 142);
            this.txtVendor.Name = "txtVendor";
            this.txtVendor.Size = new System.Drawing.Size(100, 20);
            this.txtVendor.TabIndex = 20;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(327, 143);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 21;
            // 
            // txtDate
            // 
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Location = new System.Drawing.Point(17, 143);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(83, 20);
            this.txtDate.TabIndex = 18;
            this.txtDate.Value = new System.DateTime(2015, 11, 22, 13, 39, 42, 0);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(14, 126);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 20;
            this.lblDate.Text = "Date";
            // 
            // lblOdometer
            // 
            this.lblOdometer.AutoSize = true;
            this.lblOdometer.Location = new System.Drawing.Point(104, 126);
            this.lblOdometer.Name = "lblOdometer";
            this.lblOdometer.Size = new System.Drawing.Size(53, 13);
            this.lblOdometer.TabIndex = 21;
            this.lblOdometer.Text = "Odometer";
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Location = new System.Drawing.Point(213, 126);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(41, 13);
            this.lblVendor.TabIndex = 22;
            this.lblVendor.Text = "Vendor";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(324, 126);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(28, 13);
            this.lblCost.TabIndex = 23;
            this.lblCost.Text = "Cost";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(17, 196);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Gallons";
            // 
            // txtGallons
            // 
            this.txtGallons.Location = new System.Drawing.Point(245, 75);
            this.txtGallons.Name = "txtGallons";
            this.txtGallons.Size = new System.Drawing.Size(100, 20);
            this.txtGallons.TabIndex = 17;
            // 
            // lblTripOdom
            // 
            this.lblTripOdom.AutoSize = true;
            this.lblTripOdom.Location = new System.Drawing.Point(242, 12);
            this.lblTripOdom.Name = "lblTripOdom";
            this.lblTripOdom.Size = new System.Drawing.Size(74, 13);
            this.lblTripOdom.TabIndex = 27;
            this.lblTripOdom.Text = "Trip Odometer";
            // 
            // txtTripOdometer
            // 
            this.txtTripOdometer.Location = new System.Drawing.Point(245, 29);
            this.txtTripOdometer.Name = "txtTripOdometer";
            this.txtTripOdometer.Size = new System.Drawing.Size(100, 20);
            this.txtTripOdometer.TabIndex = 16;
            // 
            // lstState
            // 
            this.lstState.FormattingEnabled = true;
            this.lstState.Location = new System.Drawing.Point(148, 12);
            this.lstState.Name = "lstState";
            this.lstState.Size = new System.Drawing.Size(48, 95);
            this.lstState.TabIndex = 15;
            this.lstState.SelectedIndexChanged += new System.EventHandler(this.lstState_SelectedIndexChanged);
            // 
            // frmFuelEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 261);
            this.Controls.Add(this.lstState);
            this.Controls.Add(this.txtTripOdometer);
            this.Controls.Add(this.lblTripOdom);
            this.Controls.Add(this.txtGallons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblVendor);
            this.Controls.Add(this.lblOdometer);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtVendor);
            this.Controls.Add(this.txtOdometer);
            this.Controls.Add(this.lstVehicle);
            this.Controls.Add(this.btnClose);
            this.Name = "frmFuelEntry";
            this.Text = "Fuel Entry";
            this.Load += new System.EventHandler(this.frmFuelEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVehicle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtOdometer;
        private System.Windows.Forms.TextBox txtVendor;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblOdometer;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGallons;
        private System.Windows.Forms.Label lblTripOdom;
        private System.Windows.Forms.TextBox txtTripOdometer;
        private System.Windows.Forms.ListBox lstState;

    }
}