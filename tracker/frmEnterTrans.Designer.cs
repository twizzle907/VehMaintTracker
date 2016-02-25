namespace tracker
{
    partial class frmEnterTrans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnterTrans));
            System.Windows.Forms.Label tIDLabel;
            System.Windows.Forms.Label licensePlateLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label sIDLabel;
            System.Windows.Forms.Label odometerLabel;
            System.Windows.Forms.Label vendorLabel;
            System.Windows.Forms.Label costLabel;
            this.btnClose = new System.Windows.Forms.Button();
            this.dBtrackerDataSet = new tracker.DBtrackerDataSet();
            this.mAINTENANCEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mAINTENANCETableAdapter = new tracker.DBtrackerDataSetTableAdapters.MAINTENANCETableAdapter();
            this.tableAdapterManager = new tracker.DBtrackerDataSetTableAdapters.TableAdapterManager();
            this.mAINTENANCEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.mAINTENANCEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tIDTextBox = new System.Windows.Forms.TextBox();
            this.licensePlateTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sIDTextBox = new System.Windows.Forms.TextBox();
            this.odometerTextBox = new System.Windows.Forms.TextBox();
            this.vendorTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.mAINTENANCEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tIDLabel = new System.Windows.Forms.Label();
            licensePlateLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            sIDLabel = new System.Windows.Forms.Label();
            odometerLabel = new System.Windows.Forms.Label();
            vendorLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBtrackerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAINTENANCEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAINTENANCEBindingNavigator)).BeginInit();
            this.mAINTENANCEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mAINTENANCEDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(4, 302);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.mAINTENANCEBindingNavigator.Size = new System.Drawing.Size(1166, 25);
            this.mAINTENANCEBindingNavigator.TabIndex = 1;
            this.mAINTENANCEBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // mAINTENANCEBindingNavigatorSaveItem
            // 
            this.mAINTENANCEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mAINTENANCEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mAINTENANCEBindingNavigatorSaveItem.Image")));
            this.mAINTENANCEBindingNavigatorSaveItem.Name = "mAINTENANCEBindingNavigatorSaveItem";
            this.mAINTENANCEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.mAINTENANCEBindingNavigatorSaveItem.Text = "Save Data";
            this.mAINTENANCEBindingNavigatorSaveItem.Click += new System.EventHandler(this.mAINTENANCEBindingNavigatorSaveItem_Click);
            // 
            // tIDLabel
            // 
            tIDLabel.AutoSize = true;
            tIDLabel.Location = new System.Drawing.Point(12, 73);
            tIDLabel.Name = "tIDLabel";
            tIDLabel.Size = new System.Drawing.Size(28, 13);
            tIDLabel.TabIndex = 2;
            tIDLabel.Text = "TID:";
            // 
            // tIDTextBox
            // 
            this.tIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mAINTENANCEBindingSource, "TID", true));
            this.tIDTextBox.Location = new System.Drawing.Point(92, 66);
            this.tIDTextBox.Name = "tIDTextBox";
            this.tIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.tIDTextBox.TabIndex = 3;
            // 
            // licensePlateLabel
            // 
            licensePlateLabel.AutoSize = true;
            licensePlateLabel.Location = new System.Drawing.Point(12, 95);
            licensePlateLabel.Name = "licensePlateLabel";
            licensePlateLabel.Size = new System.Drawing.Size(74, 13);
            licensePlateLabel.TabIndex = 4;
            licensePlateLabel.Text = "License Plate:";
            // 
            // licensePlateTextBox
            // 
            this.licensePlateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mAINTENANCEBindingSource, "LicensePlate", true));
            this.licensePlateTextBox.Location = new System.Drawing.Point(92, 92);
            this.licensePlateTextBox.Name = "licensePlateTextBox";
            this.licensePlateTextBox.Size = new System.Drawing.Size(200, 20);
            this.licensePlateTextBox.TabIndex = 5;
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(12, 121);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(35, 13);
            stateLabel.TabIndex = 6;
            stateLabel.Text = "State:";
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mAINTENANCEBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(92, 118);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(200, 20);
            this.stateTextBox.TabIndex = 7;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(12, 148);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 8;
            dateLabel.Text = "Date:";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mAINTENANCEBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(92, 144);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 9;
            // 
            // sIDLabel
            // 
            sIDLabel.AutoSize = true;
            sIDLabel.Location = new System.Drawing.Point(12, 173);
            sIDLabel.Name = "sIDLabel";
            sIDLabel.Size = new System.Drawing.Size(28, 13);
            sIDLabel.TabIndex = 10;
            sIDLabel.Text = "SID:";
            // 
            // sIDTextBox
            // 
            this.sIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mAINTENANCEBindingSource, "SID", true));
            this.sIDTextBox.Location = new System.Drawing.Point(92, 170);
            this.sIDTextBox.Name = "sIDTextBox";
            this.sIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.sIDTextBox.TabIndex = 11;
            // 
            // odometerLabel
            // 
            odometerLabel.AutoSize = true;
            odometerLabel.Location = new System.Drawing.Point(12, 199);
            odometerLabel.Name = "odometerLabel";
            odometerLabel.Size = new System.Drawing.Size(56, 13);
            odometerLabel.TabIndex = 12;
            odometerLabel.Text = "Odometer:";
            // 
            // odometerTextBox
            // 
            this.odometerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mAINTENANCEBindingSource, "Odometer", true));
            this.odometerTextBox.Location = new System.Drawing.Point(92, 196);
            this.odometerTextBox.Name = "odometerTextBox";
            this.odometerTextBox.Size = new System.Drawing.Size(200, 20);
            this.odometerTextBox.TabIndex = 13;
            // 
            // vendorLabel
            // 
            vendorLabel.AutoSize = true;
            vendorLabel.Location = new System.Drawing.Point(12, 225);
            vendorLabel.Name = "vendorLabel";
            vendorLabel.Size = new System.Drawing.Size(44, 13);
            vendorLabel.TabIndex = 14;
            vendorLabel.Text = "Vendor:";
            // 
            // vendorTextBox
            // 
            this.vendorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mAINTENANCEBindingSource, "Vendor", true));
            this.vendorTextBox.Location = new System.Drawing.Point(92, 222);
            this.vendorTextBox.Name = "vendorTextBox";
            this.vendorTextBox.Size = new System.Drawing.Size(200, 20);
            this.vendorTextBox.TabIndex = 15;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(12, 251);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(31, 13);
            costLabel.TabIndex = 16;
            costLabel.Text = "Cost:";
            // 
            // costTextBox
            // 
            this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mAINTENANCEBindingSource, "Cost", true));
            this.costTextBox.Location = new System.Drawing.Point(92, 248);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(200, 20);
            this.costTextBox.TabIndex = 17;
            // 
            // mAINTENANCEDataGridView
            // 
            this.mAINTENANCEDataGridView.AutoGenerateColumns = false;
            this.mAINTENANCEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mAINTENANCEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.mAINTENANCEDataGridView.DataSource = this.mAINTENANCEBindingSource;
            this.mAINTENANCEDataGridView.Location = new System.Drawing.Point(306, 60);
            this.mAINTENANCEDataGridView.Name = "mAINTENANCEDataGridView";
            this.mAINTENANCEDataGridView.Size = new System.Drawing.Size(842, 220);
            this.mAINTENANCEDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TID";
            this.dataGridViewTextBoxColumn1.HeaderText = "TID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LicensePlate";
            this.dataGridViewTextBoxColumn2.HeaderText = "LicensePlate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn3.HeaderText = "State";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SID";
            this.dataGridViewTextBoxColumn5.HeaderText = "SID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Odometer";
            this.dataGridViewTextBoxColumn6.HeaderText = "Odometer";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Vendor";
            this.dataGridViewTextBoxColumn7.HeaderText = "Vendor";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Cost";
            this.dataGridViewTextBoxColumn8.HeaderText = "Cost";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // frmEnterTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 345);
            this.Controls.Add(this.mAINTENANCEDataGridView);
            this.Controls.Add(tIDLabel);
            this.Controls.Add(this.tIDTextBox);
            this.Controls.Add(licensePlateLabel);
            this.Controls.Add(this.licensePlateTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(sIDLabel);
            this.Controls.Add(this.sIDTextBox);
            this.Controls.Add(odometerLabel);
            this.Controls.Add(this.odometerTextBox);
            this.Controls.Add(vendorLabel);
            this.Controls.Add(this.vendorTextBox);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.mAINTENANCEBindingNavigator);
            this.Controls.Add(this.btnClose);
            this.Name = "frmEnterTrans";
            this.Text = "Enter Transaction";
            this.Load += new System.EventHandler(this.frmEnterTrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBtrackerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAINTENANCEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAINTENANCEBindingNavigator)).EndInit();
            this.mAINTENANCEBindingNavigator.ResumeLayout(false);
            this.mAINTENANCEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mAINTENANCEDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
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
        private System.Windows.Forms.TextBox tIDTextBox;
        private System.Windows.Forms.TextBox licensePlateTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox sIDTextBox;
        private System.Windows.Forms.TextBox odometerTextBox;
        private System.Windows.Forms.TextBox vendorTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.DataGridView mAINTENANCEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}