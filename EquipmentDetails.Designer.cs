namespace Science
{
    partial class EquipmentDetails
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
            System.Windows.Forms.Label equipmentNameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label operatingNotesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipmentDetails));
            this.equipmentTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.equipmentTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sciencedbDataSet = new Science.sciencedbDataSet();
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
            this.equipmentTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.equipmentNameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.operatingNotesTextBox = new System.Windows.Forms.TextBox();
            this.supplierIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.supplierNames = new System.Windows.Forms.ComboBox();
            this.supplierTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.supplyCost = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.supplyDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.locationTableDataGridView = new System.Windows.Forms.DataGridView();
            this.locationTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockLocationTextBox = new System.Windows.Forms.TextBox();
            this.equipmentTableTableAdapter = new Science.sciencedbDataSetTableAdapters.EquipmentTableTableAdapter();
            this.tableAdapterManager = new Science.sciencedbDataSetTableAdapters.TableAdapterManager();
            this.locationTableTableAdapter = new Science.sciencedbDataSetTableAdapters.LocationTableTableAdapter();
            this.supplierTableTableAdapter1 = new Science.sciencedbDataSetTableAdapters.SupplierTableTableAdapter();
            this.locationLinkTableTableAdapter1 = new Science.sciencedbDataSetTableAdapters.LocationLinkTableTableAdapter();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.equipmentTableTableAdapter1 = new Science.sciencedbDataSetTableAdapters.EquipmentTableTableAdapter();
            this.addnewLabel = new System.Windows.Forms.LinkLabel();
            this.addlocbutton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.updatePicture = new System.Windows.Forms.Button();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.stocklocationlabel = new System.Windows.Forms.Label();
            this.stocksuppidlbl = new System.Windows.Forms.Label();
            this.equipmentTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.suppnamelbl = new System.Windows.Forms.Label();
            this.dellocbutton = new System.Windows.Forms.Button();
            equipmentNameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            operatingNotesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTableBindingNavigator)).BeginInit();
            this.equipmentTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sciencedbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // equipmentNameLabel
            // 
            equipmentNameLabel.AutoSize = true;
            equipmentNameLabel.Location = new System.Drawing.Point(46, 72);
            equipmentNameLabel.Name = "equipmentNameLabel";
            equipmentNameLabel.Size = new System.Drawing.Size(91, 13);
            equipmentNameLabel.TabIndex = 3;
            equipmentNameLabel.Text = "Equipment Name:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(46, 105);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Description:";
            // 
            // operatingNotesLabel
            // 
            operatingNotesLabel.AutoSize = true;
            operatingNotesLabel.Location = new System.Drawing.Point(46, 138);
            operatingNotesLabel.Name = "operatingNotesLabel";
            operatingNotesLabel.Size = new System.Drawing.Size(87, 13);
            operatingNotesLabel.TabIndex = 9;
            operatingNotesLabel.Text = "Operating Notes:";
            // 
            // equipmentTableBindingNavigator
            // 
            this.equipmentTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.equipmentTableBindingNavigator.BindingSource = this.equipmentTableBindingSource;
            this.equipmentTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.equipmentTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.equipmentTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.equipmentTableBindingNavigatorSaveItem});
            this.equipmentTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.equipmentTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.equipmentTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.equipmentTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.equipmentTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.equipmentTableBindingNavigator.Name = "equipmentTableBindingNavigator";
            this.equipmentTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.equipmentTableBindingNavigator.Size = new System.Drawing.Size(577, 25);
            this.equipmentTableBindingNavigator.TabIndex = 0;
            this.equipmentTableBindingNavigator.Text = "bindingNavigator1";
            this.equipmentTableBindingNavigator.MouseClick += new System.Windows.Forms.MouseEventHandler(this.equipmentTableBindingNavigator_MouseClick);
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
            // equipmentTableBindingSource
            // 
            this.equipmentTableBindingSource.DataMember = "EquipmentTable";
            this.equipmentTableBindingSource.DataSource = this.sciencedbDataSet;
            // 
            // sciencedbDataSet
            // 
            this.sciencedbDataSet.DataSetName = "sciencedbDataSet";
            this.sciencedbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
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
            // equipmentTableBindingNavigatorSaveItem
            // 
            this.equipmentTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.equipmentTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("equipmentTableBindingNavigatorSaveItem.Image")));
            this.equipmentTableBindingNavigatorSaveItem.Name = "equipmentTableBindingNavigatorSaveItem";
            this.equipmentTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.equipmentTableBindingNavigatorSaveItem.Text = "Save Data";
            this.equipmentTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.equipmentTableBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentTableBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(184, 515);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // equipmentNameTextBox
            // 
            this.equipmentNameTextBox.Location = new System.Drawing.Point(143, 72);
            this.equipmentNameTextBox.Name = "equipmentNameTextBox";
            this.equipmentNameTextBox.Size = new System.Drawing.Size(141, 20);
            this.equipmentNameTextBox.TabIndex = 4;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(143, 105);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(141, 20);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.equipmentTableBindingSource, "Image", true));
            this.imagePictureBox.Location = new System.Drawing.Point(306, 46);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(251, 218);
            this.imagePictureBox.TabIndex = 8;
            this.imagePictureBox.TabStop = false;
            // 
            // operatingNotesTextBox
            // 
            this.operatingNotesTextBox.Location = new System.Drawing.Point(143, 138);
            this.operatingNotesTextBox.Multiline = true;
            this.operatingNotesTextBox.Name = "operatingNotesTextBox";
            this.operatingNotesTextBox.Size = new System.Drawing.Size(141, 42);
            this.operatingNotesTextBox.TabIndex = 10;
            // 
            // supplierIDTextBox
            // 
            this.supplierIDTextBox.Location = new System.Drawing.Point(306, 282);
            this.supplierIDTextBox.Name = "supplierIDTextBox";
            this.supplierIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.supplierIDTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 15;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(162, 195);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(24, 13);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "edit";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // supplierNames
            // 
            this.supplierNames.DataSource = this.supplierTableBindingSource;
            this.supplierNames.DisplayMember = "SupplierName";
            this.supplierNames.FormattingEnabled = true;
            this.supplierNames.Location = new System.Drawing.Point(293, 432);
            this.supplierNames.Name = "supplierNames";
            this.supplierNames.Size = new System.Drawing.Size(111, 21);
            this.supplierNames.TabIndex = 17;
            this.supplierNames.ValueMember = "ID";
            this.supplierNames.SelectedIndexChanged += new System.EventHandler(this.supplierNames_SelectedIndexChanged);
            // 
            // supplierTableBindingSource
            // 
            this.supplierTableBindingSource.DataMember = "SupplierTable";
            this.supplierTableBindingSource.DataSource = this.sciencedbDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Equipment Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Supply Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Supplier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Cost";
            // 
            // supplyCost
            // 
            this.supplyCost.AutoSize = true;
            this.supplyCost.Location = new System.Drawing.Point(140, 282);
            this.supplyCost.Name = "supplyCost";
            this.supplyCost.Size = new System.Drawing.Size(0, 13);
            this.supplyCost.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Last Purchased";
            // 
            // supplyDate
            // 
            this.supplyDate.AutoSize = true;
            this.supplyDate.Location = new System.Drawing.Point(140, 308);
            this.supplyDate.Name = "supplyDate";
            this.supplyDate.Size = new System.Drawing.Size(0, 13);
            this.supplyDate.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Item Location";
            // 
            // locationTableDataGridView
            // 
            this.locationTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.locationTableDataGridView.Location = new System.Drawing.Point(17, 372);
            this.locationTableDataGridView.Name = "locationTableDataGridView";
            this.locationTableDataGridView.Size = new System.Drawing.Size(540, 178);
            this.locationTableDataGridView.TabIndex = 26;
            // 
            // locationTableBindingSource
            // 
            this.locationTableBindingSource.DataMember = "LocationTable";
            this.locationTableBindingSource.DataSource = this.sciencedbDataSet;
            // 
            // stockLocationTextBox
            // 
            this.stockLocationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentTableBindingSource, "StockLocation", true));
            this.stockLocationTextBox.Location = new System.Drawing.Point(143, 489);
            this.stockLocationTextBox.Name = "stockLocationTextBox";
            this.stockLocationTextBox.Size = new System.Drawing.Size(100, 20);
            this.stockLocationTextBox.TabIndex = 27;
            this.stockLocationTextBox.Visible = false;
            // 
            // equipmentTableTableAdapter
            // 
            this.equipmentTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EquipmentTableTableAdapter = this.equipmentTableTableAdapter;
            this.tableAdapterManager.LocationLinkTableTableAdapter = null;
            this.tableAdapterManager.LocationTableTableAdapter = this.locationTableTableAdapter;
            this.tableAdapterManager.SupplierTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Science.sciencedbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // locationTableTableAdapter
            // 
            this.locationTableTableAdapter.ClearBeforeFill = true;
            // 
            // supplierTableTableAdapter1
            // 
            this.supplierTableTableAdapter1.ClearBeforeFill = true;
            // 
            // locationLinkTableTableAdapter1
            // 
            this.locationLinkTableTableAdapter1.ClearBeforeFill = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(402, 556);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 29;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(497, 556);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 30;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // equipmentTableTableAdapter1
            // 
            this.equipmentTableTableAdapter1.ClearBeforeFill = true;
            // 
            // addnewLabel
            // 
            this.addnewLabel.AutoSize = true;
            this.addnewLabel.Location = new System.Drawing.Point(192, 195);
            this.addnewLabel.Name = "addnewLabel";
            this.addnewLabel.Size = new System.Drawing.Size(51, 13);
            this.addnewLabel.TabIndex = 31;
            this.addnewLabel.TabStop = true;
            this.addnewLabel.Text = "Add New";
            this.addnewLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addnewLabel_LinkClicked);
            // 
            // addlocbutton
            // 
            this.addlocbutton.Location = new System.Drawing.Point(453, 334);
            this.addlocbutton.Name = "addlocbutton";
            this.addlocbutton.Size = new System.Drawing.Size(104, 29);
            this.addlocbutton.TabIndex = 32;
            this.addlocbutton.Text = "New Location";
            this.addlocbutton.UseVisualStyleBackColor = true;
            this.addlocbutton.Click += new System.EventHandler(this.addlocbutton_Click);
            // 
            // updatePicture
            // 
            this.updatePicture.Location = new System.Drawing.Point(453, 270);
            this.updatePicture.Name = "updatePicture";
            this.updatePicture.Size = new System.Drawing.Size(104, 30);
            this.updatePicture.TabIndex = 33;
            this.updatePicture.Text = "Update Picture";
            this.updatePicture.UseVisualStyleBackColor = true;
            this.updatePicture.Click += new System.EventHandler(this.updatePicture_Click);
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // stocklocationlabel
            // 
            this.stocklocationlabel.AutoSize = true;
            this.stocklocationlabel.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.equipmentTableBindingSource, "StockLocation", true));
            this.stocklocationlabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentTableBindingSource, "StockLocation", true));
            this.stocklocationlabel.Location = new System.Drawing.Point(434, 451);
            this.stocklocationlabel.Name = "stocklocationlabel";
            this.stocklocationlabel.Size = new System.Drawing.Size(78, 13);
            this.stocklocationlabel.TabIndex = 34;
            this.stocklocationlabel.Text = "stocklocationid";
            // 
            // stocksuppidlbl
            // 
            this.stocksuppidlbl.AutoSize = true;
            this.stocksuppidlbl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentTableBindingSource, "SupplierID", true));
            this.stocksuppidlbl.Location = new System.Drawing.Point(85, 459);
            this.stocksuppidlbl.Name = "stocksuppidlbl";
            this.stocksuppidlbl.Size = new System.Drawing.Size(64, 13);
            this.stocksuppidlbl.TabIndex = 35;
            this.stocksuppidlbl.Text = "stocksuppid";
            // 
            // equipmentTableBindingSource1
            // 
            this.equipmentTableBindingSource1.DataMember = "EquipmentTable";
            this.equipmentTableBindingSource1.DataSource = this.sciencedbDataSet;
            // 
            // suppnamelbl
            // 
            this.suppnamelbl.AutoSize = true;
            this.suppnamelbl.Location = new System.Drawing.Point(140, 229);
            this.suppnamelbl.Name = "suppnamelbl";
            this.suppnamelbl.Size = new System.Drawing.Size(0, 13);
            this.suppnamelbl.TabIndex = 36;
            // 
            // dellocbutton
            // 
            this.dellocbutton.Location = new System.Drawing.Point(331, 334);
            this.dellocbutton.Name = "dellocbutton";
            this.dellocbutton.Size = new System.Drawing.Size(104, 29);
            this.dellocbutton.TabIndex = 37;
            this.dellocbutton.Text = "Delete Location";
            this.dellocbutton.UseVisualStyleBackColor = true;
            this.dellocbutton.Click += new System.EventHandler(this.dellocbutton_Click);
            // 
            // EquipmentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 587);
            this.Controls.Add(this.dellocbutton);
            this.Controls.Add(this.suppnamelbl);
            this.Controls.Add(this.updatePicture);
            this.Controls.Add(this.addlocbutton);
            this.Controls.Add(this.addnewLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.locationTableDataGridView);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.supplyDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.supplyCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.supplierNames);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(equipmentNameLabel);
            this.Controls.Add(this.equipmentNameTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(operatingNotesLabel);
            this.Controls.Add(this.operatingNotesTextBox);
            this.Controls.Add(this.supplierIDTextBox);
            this.Controls.Add(this.equipmentTableBindingNavigator);
            this.Controls.Add(this.stocklocationlabel);
            this.Controls.Add(this.stocksuppidlbl);
            this.Controls.Add(this.stockLocationTextBox);
            this.Name = "EquipmentDetails";
            this.Text = "Equipment Details";
//            this.Activated += new System.EventHandler(this.EquipmentDetails_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTableBindingNavigator)).EndInit();
            this.equipmentTableBindingNavigator.ResumeLayout(false);
            this.equipmentTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sciencedbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTableBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sciencedbDataSet sciencedbDataSet;
        private System.Windows.Forms.BindingSource equipmentTableBindingSource;
        private sciencedbDataSetTableAdapters.EquipmentTableTableAdapter equipmentTableTableAdapter;
        private sciencedbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator equipmentTableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton equipmentTableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox equipmentNameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.TextBox operatingNotesTextBox;
        private System.Windows.Forms.TextBox supplierIDTextBox;
        private sciencedbDataSetTableAdapters.LocationTableTableAdapter locationTableTableAdapter;
        private System.Windows.Forms.Label label1;
        private sciencedbDataSetTableAdapters.SupplierTableTableAdapter supplierTableTableAdapter1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox supplierNames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label supplyCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label supplyDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource locationTableBindingSource;
        private System.Windows.Forms.DataGridView locationTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private sciencedbDataSetTableAdapters.LocationLinkTableTableAdapter locationLinkTableTableAdapter1;
        private System.Windows.Forms.TextBox stockLocationTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private sciencedbDataSetTableAdapters.EquipmentTableTableAdapter equipmentTableTableAdapter1;
        private System.Windows.Forms.LinkLabel addnewLabel;
        private System.Windows.Forms.Button addlocbutton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button updatePicture;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.Label stocklocationlabel;
        private System.Windows.Forms.Label stocksuppidlbl;
        private System.Windows.Forms.BindingSource supplierTableBindingSource;
        private System.Windows.Forms.BindingSource equipmentTableBindingSource1;
        private System.Windows.Forms.Label suppnamelbl;
        private System.Windows.Forms.Button dellocbutton;
    }
}