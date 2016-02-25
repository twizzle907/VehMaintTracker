namespace tracker
{
    partial class frmServiceEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServiceEntry));
            this.btnClose = new System.Windows.Forms.Button();
            this.lstVehicle = new System.Windows.Forms.ListBox();
            this.lstServices = new System.Windows.Forms.ListBox();
            this.txtOdometer = new System.Windows.Forms.TextBox();
            this.txtVendor = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblOdometer = new System.Windows.Forms.Label();
            this.lblVendor = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblVehSelect = new System.Windows.Forms.Label();
            this.lblSelectService = new System.Windows.Forms.Label();
            this.dBtrackerDataSet = new tracker.DBtrackerDataSet();
            this.mAINTENANCEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mAINTENANCETableAdapter = new tracker.DBtrackerDataSetTableAdapters.MAINTENANCETableAdapter();
            this.tableAdapterManager = new tracker.DBtrackerDataSetTableAdapters.TableAdapterManager();
            this.mAINTENANCEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mAINTENANCEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.lstState = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dBtrackerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAINTENANCEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAINTENANCEBindingNavigator)).BeginInit();
            this.mAINTENANCEBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(281, 233);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lstVehicle
            // 
            this.lstVehicle.FormattingEnabled = true;
            this.lstVehicle.Location = new System.Drawing.Point(60, 56);
            this.lstVehicle.Name = "lstVehicle";
            this.lstVehicle.Size = new System.Drawing.Size(72, 95);
            this.lstVehicle.TabIndex = 1;
            this.lstVehicle.SelectedIndexChanged += new System.EventHandler(this.lstVehicle_SelectedIndexChanged);
            // 
            // lstServices
            // 
            this.lstServices.FormattingEnabled = true;
            this.lstServices.Location = new System.Drawing.Point(192, 56);
            this.lstServices.Name = "lstServices";
            this.lstServices.Size = new System.Drawing.Size(224, 95);
            this.lstServices.TabIndex = 2;
            // 
            // txtOdometer
            // 
            this.txtOdometer.Location = new System.Drawing.Point(102, 183);
            this.txtOdometer.Name = "txtOdometer";
            this.txtOdometer.Size = new System.Drawing.Size(100, 20);
            this.txtOdometer.TabIndex = 4;
            // 
            // txtVendor
            // 
            this.txtVendor.Location = new System.Drawing.Point(209, 184);
            this.txtVendor.Name = "txtVendor";
            this.txtVendor.Size = new System.Drawing.Size(100, 20);
            this.txtVendor.TabIndex = 5;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(316, 183);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 6;
            // 
            // txtDate
            // 
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Location = new System.Drawing.Point(12, 183);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(83, 20);
            this.txtDate.TabIndex = 7;
            this.txtDate.Value = new System.DateTime(2015, 11, 22, 13, 39, 42, 0);
            this.txtDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(13, 164);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Date";
            // 
            // lblOdometer
            // 
            this.lblOdometer.AutoSize = true;
            this.lblOdometer.Location = new System.Drawing.Point(102, 164);
            this.lblOdometer.Name = "lblOdometer";
            this.lblOdometer.Size = new System.Drawing.Size(53, 13);
            this.lblOdometer.TabIndex = 9;
            this.lblOdometer.Text = "Odometer";
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Location = new System.Drawing.Point(209, 165);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(41, 13);
            this.lblVendor.TabIndex = 10;
            this.lblVendor.Text = "Vendor";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(316, 163);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(28, 13);
            this.lblCost.TabIndex = 11;
            this.lblCost.Text = "Cost";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(79, 233);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblVehSelect
            // 
            this.lblVehSelect.AutoSize = true;
            this.lblVehSelect.Location = new System.Drawing.Point(57, 13);
            this.lblVehSelect.Name = "lblVehSelect";
            this.lblVehSelect.Size = new System.Drawing.Size(75, 13);
            this.lblVehSelect.TabIndex = 13;
            this.lblVehSelect.Text = "Select Vehicle";
            // 
            // lblSelectService
            // 
            this.lblSelectService.AutoSize = true;
            this.lblSelectService.Location = new System.Drawing.Point(188, 13);
            this.lblSelectService.Name = "lblSelectService";
            this.lblSelectService.Size = new System.Drawing.Size(76, 13);
            this.lblSelectService.TabIndex = 14;
            this.lblSelectService.Text = "Select Service";
            // 
            // dBtrackerDataSet
            // 
            this.dBtrackerDataSet.DataSetName = "DBtrackerDataSet";
            this.dBtrackerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mAINTENANCEBindingSource
            // 
            this.mAINTENANCEBindingSource.DataMember = "MAINTENANCE";
            this.mAINTENANCEBindingSource.DataSource = this.dBtrackerDataSet;
            this.mAINTENANCEBindingSource.CurrentChanged += new System.EventHandler(this.mAINTENANCEBindingSource_CurrentChanged);
            // 
            // mAINTENANCETableAdapter
            // 
            this.mAINTENANCETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FUELTableAdapter = null;
            this.tableAdapterManager.MAINTENANCETableAdapter = this.mAINTENANCETableAdapter;
            this.tableAdapterManager.SERVICETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = tracker.DBtrackerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VEHICLETableAdapter = null;
            // 
            // mAINTENANCEBindingNavigator
            // 
            this.mAINTENANCEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mAINTENANCEBindingNavigator.BindingSource = this.mAINTENANCEBindingSource;
            this.mAINTENANCEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mAINTENANCEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mAINTENANCEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.mAINTENANCEBindingNavigatorSaveItem});
            this.mAINTENANCEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mAINTENANCEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mAINTENANCEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mAINTENANCEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mAINTENANCEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mAINTENANCEBindingNavigator.Name = "mAINTENANCEBindingNavigator";
            this.mAINTENANCEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mAINTENANCEBindingNavigator.Size = new System.Drawing.Size(435, 25);
            this.mAINTENANCEBindingNavigator.TabIndex = 15;
            this.mAINTENANCEBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // mAINTENANCEBindingNavigatorSaveItem
            // 
            this.mAINTENANCEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mAINTENANCEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mAINTENANCEBindingNavigatorSaveItem.Image")));
            this.mAINTENANCEBindingNavigatorSaveItem.Name = "mAINTENANCEBindingNavigatorSaveItem";
            this.mAINTENANCEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.mAINTENANCEBindingNavigatorSaveItem.Text = "Save Data";
            this.mAINTENANCEBindingNavigatorSaveItem.Click += new System.EventHandler(this.mAINTENANCEBindingNavigatorSaveItem_Click);
            // 
            // lstState
            // 
            this.lstState.FormattingEnabled = true;
            this.lstState.Location = new System.Drawing.Point(138, 56);
            this.lstState.Name = "lstState";
            this.lstState.Size = new System.Drawing.Size(48, 95);
            this.lstState.TabIndex = 16;
            // 
            // frmServiceEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 330);
            this.Controls.Add(this.lstState);
            this.Controls.Add(this.mAINTENANCEBindingNavigator);
            this.Controls.Add(this.lblSelectService);
            this.Controls.Add(this.lblVehSelect);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblVendor);
            this.Controls.Add(this.lblOdometer);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtVendor);
            this.Controls.Add(this.txtOdometer);
            this.Controls.Add(this.lstServices);
            this.Controls.Add(this.lstVehicle);
            this.Controls.Add(this.btnClose);
            this.Name = "frmServiceEntry";
            this.Text = "Service Entry";
            this.Load += new System.EventHandler(this.frmServiceEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBtrackerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAINTENANCEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAINTENANCEBindingNavigator)).EndInit();
            this.mAINTENANCEBindingNavigator.ResumeLayout(false);
            this.mAINTENANCEBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lstVehicle;
        private System.Windows.Forms.ListBox lstServices;
        private System.Windows.Forms.TextBox txtOdometer;
        private System.Windows.Forms.TextBox txtVendor;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblOdometer;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblVehSelect;
        private System.Windows.Forms.Label lblSelectService;
        private DBtrackerDataSet dBtrackerDataSet;
        private System.Windows.Forms.BindingSource mAINTENANCEBindingSource;
        private DBtrackerDataSetTableAdapters.MAINTENANCETableAdapter mAINTENANCETableAdapter;
        private DBtrackerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mAINTENANCEBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton mAINTENANCEBindingNavigatorSaveItem;
        private System.Windows.Forms.ListBox lstState;
    }
}