namespace Science
{
    partial class SupplierDetails
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label lastPurchaseLabel;
            System.Windows.Forms.Label supplierNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierDetails));
            this.sciencedbDataSet = new Science.sciencedbDataSet();
            this.supplierTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierTableTableAdapter = new Science.sciencedbDataSetTableAdapters.SupplierTableTableAdapter();
            this.tableAdapterManager = new Science.sciencedbDataSetTableAdapters.TableAdapterManager();
            this.supplierTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.supplierTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.supplierNameTextBox = new System.Windows.Forms.TextBox();
            this.saveValues = new System.Windows.Forms.Button();
            this.stockidlabel = new System.Windows.Forms.Label();
            this.equipmentTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentTableTableAdapter = new Science.sciencedbDataSetTableAdapters.EquipmentTableTableAdapter();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lastPurchaseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.suppcombo = new System.Windows.Forms.ComboBox();
            iDLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            lastPurchaseLabel = new System.Windows.Forms.Label();
            supplierNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sciencedbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierTableBindingNavigator)).BeginInit();
            this.supplierTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(257, 9);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            iDLabel.Visible = false;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(38, 88);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(31, 13);
            costLabel.TabIndex = 3;
            costLabel.Text = "Cost:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(38, 114);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(49, 13);
            quantityLabel.TabIndex = 5;
            quantityLabel.Text = "Quantity:";
            // 
            // lastPurchaseLabel
            // 
            lastPurchaseLabel.AutoSize = true;
            lastPurchaseLabel.Location = new System.Drawing.Point(38, 141);
            lastPurchaseLabel.Name = "lastPurchaseLabel";
            lastPurchaseLabel.Size = new System.Drawing.Size(78, 13);
            lastPurchaseLabel.TabIndex = 7;
            lastPurchaseLabel.Text = "Last Purchase:";
            // 
            // supplierNameLabel
            // 
            supplierNameLabel.AutoSize = true;
            supplierNameLabel.Location = new System.Drawing.Point(38, 166);
            supplierNameLabel.Name = "supplierNameLabel";
            supplierNameLabel.Size = new System.Drawing.Size(79, 13);
            supplierNameLabel.TabIndex = 9;
            supplierNameLabel.Text = "Supplier Name:";
            // 
            // sciencedbDataSet
            // 
            this.sciencedbDataSet.DataSetName = "sciencedbDataSet";
            this.sciencedbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierTableBindingSource
            // 
            this.supplierTableBindingSource.DataMember = "SupplierTable";
            this.supplierTableBindingSource.DataSource = this.sciencedbDataSet;
            this.supplierTableBindingSource.Filter = "";
            // 
            // supplierTableTableAdapter
            // 
            this.supplierTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EquipmentTableTableAdapter = null;
            this.tableAdapterManager.LocationLinkTableTableAdapter = null;
            this.tableAdapterManager.LocationTableTableAdapter = null;
            this.tableAdapterManager.SupplierTableTableAdapter = this.supplierTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Science.sciencedbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // supplierTableBindingNavigator
            // 
            this.supplierTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.supplierTableBindingNavigator.BindingSource = this.supplierTableBindingSource;
            this.supplierTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.supplierTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.supplierTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.supplierTableBindingNavigatorSaveItem});
            this.supplierTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.supplierTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.supplierTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.supplierTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.supplierTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.supplierTableBindingNavigator.Name = "supplierTableBindingNavigator";
            this.supplierTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.supplierTableBindingNavigator.Size = new System.Drawing.Size(343, 25);
            this.supplierTableBindingNavigator.TabIndex = 0;
            this.supplierTableBindingNavigator.Text = "bindingNavigator1";
            this.supplierTableBindingNavigator.Visible = false;
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
            // supplierTableBindingNavigatorSaveItem
            // 
            this.supplierTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.supplierTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("supplierTableBindingNavigatorSaveItem.Image")));
            this.supplierTableBindingNavigatorSaveItem.Name = "supplierTableBindingNavigatorSaveItem";
            this.supplierTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.supplierTableBindingNavigatorSaveItem.Text = "Save Data";
            this.supplierTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.supplierTableBindingNavigatorSaveItem_Click_1);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierTableBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(293, 9);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(30, 20);
            this.iDTextBox.TabIndex = 2;
            this.iDTextBox.Visible = false;
            // 
            // costTextBox
            // 
            this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierTableBindingSource, "Cost", true));
            this.costTextBox.Location = new System.Drawing.Point(123, 85);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(200, 20);
            this.costTextBox.TabIndex = 4;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierTableBindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(123, 111);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(200, 20);
            this.quantityTextBox.TabIndex = 6;
            // 
            // supplierNameTextBox
            // 
            this.supplierNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierTableBindingSource, "SupplierName", true));
            this.supplierNameTextBox.Location = new System.Drawing.Point(123, 163);
            this.supplierNameTextBox.Name = "supplierNameTextBox";
            this.supplierNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.supplierNameTextBox.TabIndex = 10;
            // 
            // saveValues
            // 
            this.saveValues.Location = new System.Drawing.Point(153, 222);
            this.saveValues.Name = "saveValues";
            this.saveValues.Size = new System.Drawing.Size(75, 23);
            this.saveValues.TabIndex = 11;
            this.saveValues.Text = "Save";
            this.saveValues.UseVisualStyleBackColor = true;
            this.saveValues.Click += new System.EventHandler(this.saveValues_Click);
            // 
            // stockidlabel
            // 
            this.stockidlabel.AutoSize = true;
            this.stockidlabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentTableBindingSource, "ID", true));
            this.stockidlabel.Location = new System.Drawing.Point(38, 210);
            this.stockidlabel.Name = "stockidlabel";
            this.stockidlabel.Size = new System.Drawing.Size(0, 13);
            this.stockidlabel.TabIndex = 12;
            this.stockidlabel.Visible = false;
            // 
            // equipmentTableBindingSource
            // 
            this.equipmentTableBindingSource.DataMember = "EquipmentTable";
            this.equipmentTableBindingSource.DataSource = this.sciencedbDataSet;
            // 
            // equipmentTableTableAdapter
            // 
            this.equipmentTableTableAdapter.ClearBeforeFill = true;
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(249, 222);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(74, 23);
            this.cancelbutton.TabIndex = 13;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Supplier Details";
            // 
            // lastPurchaseDateTimePicker
            // 
            this.lastPurchaseDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.supplierTableBindingSource, "LastPurchase", true));
            this.lastPurchaseDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.lastPurchaseDateTimePicker.Location = new System.Drawing.Point(123, 135);
            this.lastPurchaseDateTimePicker.Name = "lastPurchaseDateTimePicker";
            this.lastPurchaseDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.lastPurchaseDateTimePicker.TabIndex = 15;
            // 
            // suppcombo
            // 
            this.suppcombo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.supplierTableBindingSource, "SupplierName", true));
            this.suppcombo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.supplierTableBindingSource, "ID", true));
            this.suppcombo.FormattingEnabled = true;
            this.suppcombo.Location = new System.Drawing.Point(123, 58);
            this.suppcombo.Name = "suppcombo";
            this.suppcombo.Size = new System.Drawing.Size(200, 21);
            this.suppcombo.TabIndex = 16;
            this.suppcombo.SelectedIndexChanged += new System.EventHandler(this.suppcombo_SelectedIndexChanged);
            // 
            // SupplierDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 257);
            this.Controls.Add(this.suppcombo);
            this.Controls.Add(this.lastPurchaseDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.stockidlabel);
            this.Controls.Add(this.saveValues);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(lastPurchaseLabel);
            this.Controls.Add(supplierNameLabel);
            this.Controls.Add(this.supplierNameTextBox);
            this.Controls.Add(this.supplierTableBindingNavigator);
            this.Name = "SupplierDetails";
            this.Text = "SupplierDetails";
            this.Load += new System.EventHandler(this.SupplierDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sciencedbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierTableBindingNavigator)).EndInit();
            this.supplierTableBindingNavigator.ResumeLayout(false);
            this.supplierTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sciencedbDataSet sciencedbDataSet;
        private System.Windows.Forms.BindingSource supplierTableBindingSource;
        private sciencedbDataSetTableAdapters.SupplierTableTableAdapter supplierTableTableAdapter;
        private sciencedbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator supplierTableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton supplierTableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox supplierNameTextBox;
        private System.Windows.Forms.Button saveValues;
        private System.Windows.Forms.Label stockidlabel;
        private System.Windows.Forms.BindingSource equipmentTableBindingSource;
        private sciencedbDataSetTableAdapters.EquipmentTableTableAdapter equipmentTableTableAdapter;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker lastPurchaseDateTimePicker;
        private System.Windows.Forms.ComboBox suppcombo;

    }
}