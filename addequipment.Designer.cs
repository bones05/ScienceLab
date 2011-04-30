namespace Science
{
    partial class addequipment
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
            this.equiptextBox = new System.Windows.Forms.TextBox();
            this.desctextBox = new System.Windows.Forms.TextBox();
            this.opnotestextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.savebutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Equipment Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Operating Notes";
            // 
            // equiptextBox
            // 
            this.equiptextBox.Location = new System.Drawing.Point(156, 67);
            this.equiptextBox.Name = "equiptextBox";
            this.equiptextBox.Size = new System.Drawing.Size(165, 20);
            this.equiptextBox.TabIndex = 3;
            // 
            // desctextBox
            // 
            this.desctextBox.Location = new System.Drawing.Point(156, 107);
            this.desctextBox.Name = "desctextBox";
            this.desctextBox.Size = new System.Drawing.Size(165, 20);
            this.desctextBox.TabIndex = 4;
            // 
            // opnotestextBox
            // 
            this.opnotestextBox.Location = new System.Drawing.Point(156, 143);
            this.opnotestextBox.Multiline = true;
            this.opnotestextBox.Name = "opnotestextBox";
            this.opnotestextBox.Size = new System.Drawing.Size(165, 51);
            this.opnotestextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Add New Equipment";
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(156, 218);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 7;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(246, 218);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelbutton.TabIndex = 8;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // addequipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 262);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.opnotestextBox);
            this.Controls.Add(this.desctextBox);
            this.Controls.Add(this.equiptextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addequipment";
            this.Text = "Add New Equipment";
            this.Load += new System.EventHandler(this.addequipment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox equiptextBox;
        private System.Windows.Forms.TextBox desctextBox;
        private System.Windows.Forms.TextBox opnotestextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button cancelbutton;
    }
}