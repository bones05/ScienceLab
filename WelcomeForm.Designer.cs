namespace Science
{
    partial class WelcomeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.equipmentTableDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.addEquipment = new System.Windows.Forms.Button();
            this.newlocbutton = new System.Windows.Forms.Button();
            this.EquipmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperatingNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Information = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Science Stock Application";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(34, 142);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(305, 20);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // equipmentTableDataGridView
            // 
            this.equipmentTableDataGridView.AllowUserToAddRows = false;
            this.equipmentTableDataGridView.AllowUserToDeleteRows = false;
            this.equipmentTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipmentTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EquipmentName,
            this.Description,
            this.OperatingNotes,
            this.ID,
            this.Information});
            this.equipmentTableDataGridView.Location = new System.Drawing.Point(1, 236);
            this.equipmentTableDataGridView.Name = "equipmentTableDataGridView";
            this.equipmentTableDataGridView.ReadOnly = true;
            this.equipmentTableDataGridView.Size = new System.Drawing.Size(475, 262);
            this.equipmentTableDataGridView.TabIndex = 4;
            this.equipmentTableDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.equipmentTableDataGridView_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // addEquipment
            // 
            this.addEquipment.Location = new System.Drawing.Point(34, 188);
            this.addEquipment.Name = "addEquipment";
            this.addEquipment.Size = new System.Drawing.Size(127, 23);
            this.addEquipment.TabIndex = 6;
            this.addEquipment.Text = "Add Equipment";
            this.addEquipment.UseVisualStyleBackColor = true;
            this.addEquipment.Click += new System.EventHandler(this.addEquipment_Click);
            // 
            // newlocbutton
            // 
            this.newlocbutton.Location = new System.Drawing.Point(184, 188);
            this.newlocbutton.Name = "newlocbutton";
            this.newlocbutton.Size = new System.Drawing.Size(127, 23);
            this.newlocbutton.TabIndex = 7;
            this.newlocbutton.Text = "Add Room";
            this.newlocbutton.UseVisualStyleBackColor = true;
            this.newlocbutton.Click += new System.EventHandler(this.newlocbutton_Click);
            // 
            // EquipmentName
            // 
            this.EquipmentName.DataPropertyName = "EquipmentName";
            this.EquipmentName.HeaderText = "Equipment Name";
            this.EquipmentName.Name = "EquipmentName";
            this.EquipmentName.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // OperatingNotes
            // 
            this.OperatingNotes.DataPropertyName = "OperatingNotes";
            this.OperatingNotes.HeaderText = "Operating Notes";
            this.OperatingNotes.Name = "OperatingNotes";
            this.OperatingNotes.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Information
            // 
            this.Information.DataPropertyName = "Information";
            this.Information.HeaderText = "";
            this.Information.Name = "Information";
            this.Information.ReadOnly = true;
            this.Information.Text = "more";
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 499);
            this.Controls.Add(this.newlocbutton);
            this.Controls.Add(this.addEquipment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.equipmentTableDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label1);
            this.Name = "WelcomeForm";
            this.Text = "WelcomeForm";
            this.Activated += new System.EventHandler(this.WelcomeForm_Activated);
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView equipmentTableDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addEquipment;
        private System.Windows.Forms.Button newlocbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperatingNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewLinkColumn Information;
    }
}