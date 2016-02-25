namespace tracker
{
    partial class frmMain
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
            this.btnAddVeh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddServiceType = new System.Windows.Forms.Button();
            this.btnEnterTrans = new System.Windows.Forms.Button();
            this.btnAvgMpg = new System.Windows.Forms.Button();
            this.btnMaintCost = new System.Windows.Forms.Button();
            this.btnFuelCost = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddVeh
            // 
            this.btnAddVeh.Location = new System.Drawing.Point(12, 51);
            this.btnAddVeh.Name = "btnAddVeh";
            this.btnAddVeh.Size = new System.Drawing.Size(145, 23);
            this.btnAddVeh.TabIndex = 0;
            this.btnAddVeh.Text = "Add Vehicle";
            this.btnAddVeh.UseVisualStyleBackColor = true;
            this.btnAddVeh.Click += new System.EventHandler(this.btnAddVeh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Forms";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAddServiceType
            // 
            this.btnAddServiceType.Location = new System.Drawing.Point(12, 80);
            this.btnAddServiceType.Name = "btnAddServiceType";
            this.btnAddServiceType.Size = new System.Drawing.Size(145, 23);
            this.btnAddServiceType.TabIndex = 3;
            this.btnAddServiceType.Text = "Add Service Type";
            this.btnAddServiceType.UseVisualStyleBackColor = true;
            this.btnAddServiceType.Click += new System.EventHandler(this.btnAddServiceType_Click);
            // 
            // btnEnterTrans
            // 
            this.btnEnterTrans.Location = new System.Drawing.Point(13, 109);
            this.btnEnterTrans.Name = "btnEnterTrans";
            this.btnEnterTrans.Size = new System.Drawing.Size(144, 23);
            this.btnEnterTrans.TabIndex = 4;
            this.btnEnterTrans.Text = "Enter Transaction";
            this.btnEnterTrans.UseVisualStyleBackColor = true;
            this.btnEnterTrans.Click += new System.EventHandler(this.btnEnterTrans_Click);
            // 
            // btnAvgMpg
            // 
            this.btnAvgMpg.Location = new System.Drawing.Point(15, 213);
            this.btnAvgMpg.Name = "btnAvgMpg";
            this.btnAvgMpg.Size = new System.Drawing.Size(154, 23);
            this.btnAvgMpg.TabIndex = 5;
            this.btnAvgMpg.Text = "Average MPG";
            this.btnAvgMpg.UseVisualStyleBackColor = true;
            this.btnAvgMpg.Click += new System.EventHandler(this.btnAvgMpg_Click);
            // 
            // btnMaintCost
            // 
            this.btnMaintCost.Location = new System.Drawing.Point(13, 242);
            this.btnMaintCost.Name = "btnMaintCost";
            this.btnMaintCost.Size = new System.Drawing.Size(156, 23);
            this.btnMaintCost.TabIndex = 6;
            this.btnMaintCost.Text = "Total Maintenance Cost";
            this.btnMaintCost.UseVisualStyleBackColor = true;
            this.btnMaintCost.Click += new System.EventHandler(this.btnMaintCost_Click);
            // 
            // btnFuelCost
            // 
            this.btnFuelCost.Location = new System.Drawing.Point(12, 271);
            this.btnFuelCost.Name = "btnFuelCost";
            this.btnFuelCost.Size = new System.Drawing.Size(157, 23);
            this.btnFuelCost.TabIndex = 7;
            this.btnFuelCost.Text = "Total Fuel Cost";
            this.btnFuelCost.UseVisualStyleBackColor = true;
            this.btnFuelCost.Click += new System.EventHandler(this.btnFuelCost_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Reports";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(107, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(147, 13);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Vehicle Maintenance Tracker";
            this.lblTitle.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(292, 271);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 306);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFuelCost);
            this.Controls.Add(this.btnMaintCost);
            this.Controls.Add(this.btnAvgMpg);
            this.Controls.Add(this.btnEnterTrans);
            this.Controls.Add(this.btnAddServiceType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddVeh);
            this.Name = "frmMain";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddVeh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddServiceType;
        private System.Windows.Forms.Button btnEnterTrans;
        private System.Windows.Forms.Button btnAvgMpg;
        private System.Windows.Forms.Button btnMaintCost;
        private System.Windows.Forms.Button btnFuelCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
    }
}

