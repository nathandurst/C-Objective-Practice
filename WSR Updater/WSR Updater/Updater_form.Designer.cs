namespace WSR_Updater
{
    partial class Updater_form
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
            this.browse_textBox = new System.Windows.Forms.TextBox();
            this.Browse_button = new System.Windows.Forms.Button();
            this.line_textBox = new System.Windows.Forms.TextBox();
            this.entries_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Update_button = new System.Windows.Forms.Button();
            this.message_textBox = new System.Windows.Forms.TextBox();
            this.total_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.add_RadioButton = new System.Windows.Forms.RadioButton();
            this.gaps_RadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // browse_textBox
            // 
            this.browse_textBox.Location = new System.Drawing.Point(12, 21);
            this.browse_textBox.Name = "browse_textBox";
            this.browse_textBox.Size = new System.Drawing.Size(272, 20);
            this.browse_textBox.TabIndex = 0;
            // 
            // Browse_button
            // 
            this.Browse_button.Location = new System.Drawing.Point(290, 21);
            this.Browse_button.Name = "Browse_button";
            this.Browse_button.Size = new System.Drawing.Size(107, 20);
            this.Browse_button.TabIndex = 1;
            this.Browse_button.Text = "Browse";
            this.Browse_button.UseVisualStyleBackColor = true;
            this.Browse_button.Click += new System.EventHandler(this.Browse_button_Click);
            // 
            // line_textBox
            // 
            this.line_textBox.Location = new System.Drawing.Point(190, 55);
            this.line_textBox.Name = "line_textBox";
            this.line_textBox.Size = new System.Drawing.Size(61, 20);
            this.line_textBox.TabIndex = 2;
            // 
            // entries_textBox
            // 
            this.entries_textBox.Location = new System.Drawing.Point(190, 78);
            this.entries_textBox.Name = "entries_textBox";
            this.entries_textBox.Size = new System.Drawing.Size(61, 20);
            this.entries_textBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Line number to update:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of new entries:";
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(290, 95);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(97, 27);
            this.Update_button.TabIndex = 6;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // message_textBox
            // 
            this.message_textBox.Location = new System.Drawing.Point(12, 128);
            this.message_textBox.Multiline = true;
            this.message_textBox.Name = "message_textBox";
            this.message_textBox.Size = new System.Drawing.Size(385, 203);
            this.message_textBox.TabIndex = 7;
            // 
            // total_textBox
            // 
            this.total_textBox.Location = new System.Drawing.Point(190, 102);
            this.total_textBox.Name = "total_textBox";
            this.total_textBox.Size = new System.Drawing.Size(61, 20);
            this.total_textBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Number of lines (pre update):";
            // 
            // add_RadioButton
            // 
            this.add_RadioButton.AutoSize = true;
            this.add_RadioButton.Checked = true;
            this.add_RadioButton.Location = new System.Drawing.Point(290, 47);
            this.add_RadioButton.Name = "add_RadioButton";
            this.add_RadioButton.Size = new System.Drawing.Size(104, 17);
            this.add_RadioButton.TabIndex = 10;
            this.add_RadioButton.TabStop = true;
            this.add_RadioButton.Text = "Add Empty Lines";
            this.add_RadioButton.UseVisualStyleBackColor = true;
            this.add_RadioButton.CheckedChanged += new System.EventHandler(this.add_RadioButton_CheckedChanged);
            // 
            // gaps_RadioButton
            // 
            this.gaps_RadioButton.AutoSize = true;
            this.gaps_RadioButton.Location = new System.Drawing.Point(290, 70);
            this.gaps_RadioButton.Name = "gaps_RadioButton";
            this.gaps_RadioButton.Size = new System.Drawing.Size(88, 17);
            this.gaps_RadioButton.TabIndex = 11;
            this.gaps_RadioButton.Text = "Update Gaps";
            this.gaps_RadioButton.UseVisualStyleBackColor = true;
            this.gaps_RadioButton.CheckedChanged += new System.EventHandler(this.gaps_RadioButton_CheckedChanged);
            // 
            // Updater_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 343);
            this.Controls.Add(this.gaps_RadioButton);
            this.Controls.Add(this.add_RadioButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.total_textBox);
            this.Controls.Add(this.message_textBox);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entries_textBox);
            this.Controls.Add(this.line_textBox);
            this.Controls.Add(this.Browse_button);
            this.Controls.Add(this.browse_textBox);
            this.Name = "Updater_form";
            this.Text = "WSR Updater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox browse_textBox;
        private System.Windows.Forms.Button Browse_button;
        private System.Windows.Forms.TextBox line_textBox;
        private System.Windows.Forms.TextBox entries_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.TextBox message_textBox;
        private System.Windows.Forms.TextBox total_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton add_RadioButton;
        private System.Windows.Forms.RadioButton gaps_RadioButton;
    }
}

