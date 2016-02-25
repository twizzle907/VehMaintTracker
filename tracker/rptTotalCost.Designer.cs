namespace tracker
{
    partial class rptTotalCost
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
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dBtrackerDataSet2 = new tracker.DBtrackerDataSet2();
            this.totalMaintCostByVehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.total_Maint_Cost_by_VehicleTableAdapter = new tracker.DBtrackerDataSet2TableAdapters.Total_Maint_Cost_by_VehicleTableAdapter();
            this.licensePlateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMaintCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBtrackerDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalMaintCostByVehicleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(13, 227);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.licensePlateDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.totalMaintCostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.totalMaintCostByVehicleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(56, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(357, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(52, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(286, 20);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Total Maintenance Cost by Vehicle";
            // 
            // dBtrackerDataSet2
            // 
            this.dBtrackerDataSet2.DataSetName = "DBtrackerDataSet2";
            this.dBtrackerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // totalMaintCostByVehicleBindingSource
            // 
            this.totalMaintCostByVehicleBindingSource.DataMember = "Total Maint Cost by Vehicle";
            this.totalMaintCostByVehicleBindingSource.DataSource = this.dBtrackerDataSet2;
            // 
            // total_Maint_Cost_by_VehicleTableAdapter
            // 
            this.total_Maint_Cost_by_VehicleTableAdapter.ClearBeforeFill = true;
            // 
            // licensePlateDataGridViewTextBoxColumn
            // 
            this.licensePlateDataGridViewTextBoxColumn.DataPropertyName = "LicensePlate";
            this.licensePlateDataGridViewTextBoxColumn.HeaderText = "LicensePlate";
            this.licensePlateDataGridViewTextBoxColumn.Name = "licensePlateDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // totalMaintCostDataGridViewTextBoxColumn
            // 
            this.totalMaintCostDataGridViewTextBoxColumn.DataPropertyName = "TotalMaintCost";
            this.totalMaintCostDataGridViewTextBoxColumn.HeaderText = "TotalMaintCost";
            this.totalMaintCostDataGridViewTextBoxColumn.Name = "totalMaintCostDataGridViewTextBoxColumn";
            // 
            // rptTotalCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 262);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClose);
            this.Name = "rptTotalCost";
            this.Text = "Total Maintenance Cost";
            this.Load += new System.EventHandler(this.rptTotalCost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBtrackerDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalMaintCostByVehicleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTitle;
        private DBtrackerDataSet2 dBtrackerDataSet2;
        private System.Windows.Forms.BindingSource totalMaintCostByVehicleBindingSource;
        private DBtrackerDataSet2TableAdapters.Total_Maint_Cost_by_VehicleTableAdapter total_Maint_Cost_by_VehicleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn licensePlateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMaintCostDataGridViewTextBoxColumn;
    }
}