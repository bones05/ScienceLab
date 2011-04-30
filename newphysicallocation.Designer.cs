namespace Science
{
    partial class newphysicallocation
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
            this.label6 = new System.Windows.Forms.Label();
            this.roomnumtextBox = new System.Windows.Forms.TextBox();
            this.roomdesctextBox = new System.Windows.Forms.TextBox();
            this.sectionstextBox = new System.Windows.Forms.TextBox();
            this.columntextBox = new System.Windows.Forms.TextBox();
            this.shelvestextBox = new System.Windows.Forms.TextBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Location Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Room Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of Sections";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number of Columns";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Number of Shelves";
            // 
            // roomnumtextBox
            // 
            this.roomnumtextBox.Location = new System.Drawing.Point(145, 51);
            this.roomnumtextBox.Name = "roomnumtextBox";
            this.roomnumtextBox.Size = new System.Drawing.Size(120, 20);
            this.roomnumtextBox.TabIndex = 6;
            // 
            // roomdesctextBox
            // 
            this.roomdesctextBox.Location = new System.Drawing.Point(145, 87);
            this.roomdesctextBox.Name = "roomdesctextBox";
            this.roomdesctextBox.Size = new System.Drawing.Size(120, 20);
            this.roomdesctextBox.TabIndex = 7;
            // 
            // sectionstextBox
            // 
            this.sectionstextBox.Location = new System.Drawing.Point(146, 123);
            this.sectionstextBox.Name = "sectionstextBox";
            this.sectionstextBox.Size = new System.Drawing.Size(120, 20);
            this.sectionstextBox.TabIndex = 8;
            // 
            // columntextBox
            // 
            this.columntextBox.Location = new System.Drawing.Point(145, 159);
            this.columntextBox.Name = "columntextBox";
            this.columntextBox.Size = new System.Drawing.Size(120, 20);
            this.columntextBox.TabIndex = 9;
            // 
            // shelvestextBox
            // 
            this.shelvestextBox.Location = new System.Drawing.Point(146, 195);
            this.shelvestextBox.Name = "shelvestextBox";
            this.shelvestextBox.Size = new System.Drawing.Size(120, 20);
            this.shelvestextBox.TabIndex = 10;
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(237, 255);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 11;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(137, 255);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelbutton.TabIndex = 12;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // newphysicallocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 300);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.shelvestextBox);
            this.Controls.Add(this.columntextBox);
            this.Controls.Add(this.sectionstextBox);
            this.Controls.Add(this.roomdesctextBox);
            this.Controls.Add(this.roomnumtextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "newphysicallocation";
            this.Text = "Add New Location";
            this.Load += new System.EventHandler(this.newphysicallocation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox roomnumtextBox;
        private System.Windows.Forms.TextBox roomdesctextBox;
        private System.Windows.Forms.TextBox sectionstextBox;
        private System.Windows.Forms.TextBox columntextBox;
        private System.Windows.Forms.TextBox shelvestextBox;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button cancelbutton;
    }
}