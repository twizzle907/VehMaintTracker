namespace tracker
{
    partial class rptAvgMPG
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dBtrackerDataSet2 = new tracker.DBtrackerDataSet2();
            this.avgMPGByVehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avg_MPG_by_VehicleTableAdapter = new tracker.DBtrackerDataSet2TableAdapters.Avg_MPG_by_VehicleTableAdapter();
            this.licensePlateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageMPGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBtrackerDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgMPGByVehicleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(206, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Average MPG by Vehicle";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.licensePlateDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.averageMPGDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.avgMPGByVehicleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(353, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // dBtrackerDataSet2
            // 
            this.dBtrackerDataSet2.DataSetName = "DBtrackerDataSet2";
            this.dBtrackerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avgMPGByVehicleBindingSource
            // 
            this.avgMPGByVehicleBindingSource.DataMember = "Avg MPG by Vehicle";
            this.avgMPGByVehicleBindingSource.DataSource = this.dBtrackerDataSet2;
            // 
            // avg_MPG_by_VehicleTableAdapter
            // 
            this.avg_MPG_by_VehicleTableAdapter.ClearBeforeFill = true;
            // 
            // licensePlateDataGridViewTextBoxColumn
            // 
            this.licensePlateDataGridViewTextBoxColumn.DataPropertyName = "LicensePlate";
            this.licensePlateDataGridViewTextBoxColumn.HeaderText = "LicensePlate";
            this.licensePlateDataGridViewTextBoxColumn.Name = "licensePlateDataGridViewTextBoxColumn";
            this.licensePlateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // averageMPGDataGridViewTextBoxColumn
            // 
            this.averageMPGDataGridViewTextBoxColumn.DataPropertyName = "AverageMPG";
            this.averageMPGDataGridViewTextBoxColumn.HeaderText = "AverageMPG";
            this.averageMPGDataGridViewTextBoxColumn.Name = "averageMPGDataGridViewTextBoxColumn";
            this.averageMPGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(17, 204);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rptAvgMPG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 261);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTitle);
            this.Name = "rptAvgMPG";
            this.Text = "Average MPG by Vehicle";
            this.Load += new System.EventHandler(this.rptAvgMPG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBtrackerDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgMPGByVehicleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBtrackerDataSet2 dBtrackerDataSet2;
        private System.Windows.Forms.BindingSource avgMPGByVehicleBindingSource;
        private DBtrackerDataSet2TableAdapters.Avg_MPG_by_VehicleTableAdapter avg_MPG_by_VehicleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn licensePlateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageMPGDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnClose;
    }
}