namespace tracker
{
    partial class frmServiceSelection
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
            this.btnFuel = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFuel
            // 
            this.btnFuel.Location = new System.Drawing.Point(12, 88);
            this.btnFuel.Name = "btnFuel";
            this.btnFuel.Size = new System.Drawing.Size(120, 99);
            this.btnFuel.TabIndex = 0;
            this.btnFuel.Text = "Fuel";
            this.btnFuel.UseVisualStyleBackColor = true;
            this.btnFuel.Click += new System.EventHandler(this.btnFuel_Click);
            // 
            // btnService
            // 
            this.btnService.Location = new System.Drawing.Point(138, 88);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(120, 99);
            this.btnService.TabIndex = 1;
            this.btnService.Text = "Service";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(63, 48);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(139, 13);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "What do you want to enter?";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(97, 226);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmServiceSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 261);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnService);
            this.Controls.Add(this.btnFuel);
            this.Name = "frmServiceSelection";
            this.Text = "Select Service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFuel;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnClose;
    }
}