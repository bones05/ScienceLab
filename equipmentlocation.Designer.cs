namespace Science
{
    partial class equipmentlocation
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.roomnocombo = new System.Windows.Forms.ComboBox();
            this.sectioncombo = new System.Windows.Forms.ComboBox();
            this.columncombo = new System.Windows.Forms.ComboBox();
            this.shelfcombo = new System.Windows.Forms.ComboBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Equipment Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Section";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Column";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Shelf";
            // 
            // roomnocombo
            // 
            this.roomnocombo.FormattingEnabled = true;
            this.roomnocombo.Location = new System.Drawing.Point(179, 71);
            this.roomnocombo.Name = "roomnocombo";
            this.roomnocombo.Size = new System.Drawing.Size(121, 21);
            this.roomnocombo.TabIndex = 5;
            this.roomnocombo.SelectedIndexChanged += new System.EventHandler(this.roomnocombo_SelectedIndexChanged);
            // 
            // sectioncombo
            // 
            this.sectioncombo.FormattingEnabled = true;
            this.sectioncombo.Location = new System.Drawing.Point(179, 105);
            this.sectioncombo.Name = "sectioncombo";
            this.sectioncombo.Size = new System.Drawing.Size(121, 21);
            this.sectioncombo.TabIndex = 6;
            // 
            // columncombo
            // 
            this.columncombo.FormattingEnabled = true;
            this.columncombo.Location = new System.Drawing.Point(179, 139);
            this.columncombo.Name = "columncombo";
            this.columncombo.Size = new System.Drawing.Size(121, 21);
            this.columncombo.TabIndex = 7;
            // 
            // shelfcombo
            // 
            this.shelfcombo.FormattingEnabled = true;
            this.shelfcombo.Location = new System.Drawing.Point(179, 173);
            this.shelfcombo.Name = "shelfcombo";
            this.shelfcombo.Size = new System.Drawing.Size(121, 21);
            this.shelfcombo.TabIndex = 8;
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(225, 233);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 9;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(127, 233);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelbutton.TabIndex = 10;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(16, 233);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 23);
            this.deletebutton.TabIndex = 11;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // equipmentlocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 279);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.shelfcombo);
            this.Controls.Add(this.columncombo);
            this.Controls.Add(this.sectioncombo);
            this.Controls.Add(this.roomnocombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "equipmentlocation";
            this.Text = "New Equipment Location";
            this.Load += new System.EventHandler(this.equipmentlocation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox roomnocombo;
        private System.Windows.Forms.ComboBox sectioncombo;
        private System.Windows.Forms.ComboBox columncombo;
        private System.Windows.Forms.ComboBox shelfcombo;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button deletebutton;
    }
}