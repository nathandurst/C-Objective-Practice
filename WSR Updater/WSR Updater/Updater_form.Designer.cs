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
            this.message_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Browse_source_button = new System.Windows.Forms.Button();
            this.browse_source_textBox = new System.Windows.Forms.TextBox();
            this.Browse_destination_button = new System.Windows.Forms.Button();
            this.browse_destination_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.line_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.entries_textBox = new System.Windows.Forms.TextBox();
            this.update_RadioButton = new System.Windows.Forms.RadioButton();
            this.add_RadioButton = new System.Windows.Forms.RadioButton();
            this.Update_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // message_textBox
            // 
            this.message_textBox.Location = new System.Drawing.Point(12, 166);
            this.message_textBox.Multiline = true;
            this.message_textBox.Name = "message_textBox";
            this.message_textBox.ReadOnly = true;
            this.message_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.message_textBox.Size = new System.Drawing.Size(385, 174);
            this.message_textBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Messages:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Source:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Destination:";
            // 
            // Browse_source_button
            // 
            this.Browse_source_button.Location = new System.Drawing.Point(290, 21);
            this.Browse_source_button.Name = "Browse_source_button";
            this.Browse_source_button.Size = new System.Drawing.Size(107, 20);
            this.Browse_source_button.TabIndex = 20;
            this.Browse_source_button.Text = "Browse";
            this.Browse_source_button.UseVisualStyleBackColor = true;
            this.Browse_source_button.Click += new System.EventHandler(this.Browse_source_button_Click);
            // 
            // browse_source_textBox
            // 
            this.browse_source_textBox.Location = new System.Drawing.Point(12, 21);
            this.browse_source_textBox.Name = "browse_source_textBox";
            this.browse_source_textBox.Size = new System.Drawing.Size(272, 20);
            this.browse_source_textBox.TabIndex = 19;
            // 
            // Browse_destination_button
            // 
            this.Browse_destination_button.Location = new System.Drawing.Point(290, 56);
            this.Browse_destination_button.Name = "Browse_destination_button";
            this.Browse_destination_button.Size = new System.Drawing.Size(107, 20);
            this.Browse_destination_button.TabIndex = 22;
            this.Browse_destination_button.Text = "Browse";
            this.Browse_destination_button.UseVisualStyleBackColor = true;
            this.Browse_destination_button.Click += new System.EventHandler(this.Browse_destination_button_Click);
            // 
            // browse_destination_textBox
            // 
            this.browse_destination_textBox.Location = new System.Drawing.Point(12, 56);
            this.browse_destination_textBox.Name = "browse_destination_textBox";
            this.browse_destination_textBox.Size = new System.Drawing.Size(272, 20);
            this.browse_destination_textBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Line number to update:";
            // 
            // line_textBox
            // 
            this.line_textBox.Location = new System.Drawing.Point(160, 80);
            this.line_textBox.Name = "line_textBox";
            this.line_textBox.Size = new System.Drawing.Size(61, 20);
            this.line_textBox.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Number of new entries:";
            // 
            // entries_textBox
            // 
            this.entries_textBox.Location = new System.Drawing.Point(160, 104);
            this.entries_textBox.Name = "entries_textBox";
            this.entries_textBox.Size = new System.Drawing.Size(61, 20);
            this.entries_textBox.TabIndex = 25;
            // 
            // update_RadioButton
            // 
            this.update_RadioButton.AutoSize = true;
            this.update_RadioButton.Location = new System.Drawing.Point(290, 106);
            this.update_RadioButton.Name = "update_RadioButton";
            this.update_RadioButton.Size = new System.Drawing.Size(102, 17);
            this.update_RadioButton.TabIndex = 30;
            this.update_RadioButton.Text = "Update All Lines";
            this.update_RadioButton.UseVisualStyleBackColor = true;
            this.update_RadioButton.CheckedChanged += new System.EventHandler(this.update_RadioButton_CheckedChanged);
            // 
            // add_RadioButton
            // 
            this.add_RadioButton.AutoSize = true;
            this.add_RadioButton.Checked = true;
            this.add_RadioButton.Location = new System.Drawing.Point(290, 83);
            this.add_RadioButton.Name = "add_RadioButton";
            this.add_RadioButton.Size = new System.Drawing.Size(104, 17);
            this.add_RadioButton.TabIndex = 29;
            this.add_RadioButton.TabStop = true;
            this.add_RadioButton.Text = "Insert New Lines";
            this.add_RadioButton.UseVisualStyleBackColor = true;
            this.add_RadioButton.CheckedChanged += new System.EventHandler(this.add_RadioButton_CheckedChanged);
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(297, 131);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(97, 27);
            this.Update_button.TabIndex = 31;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Updater_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 343);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.update_RadioButton);
            this.Controls.Add(this.add_RadioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.entries_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.line_textBox);
            this.Controls.Add(this.Browse_destination_button);
            this.Controls.Add(this.browse_destination_textBox);
            this.Controls.Add(this.Browse_source_button);
            this.Controls.Add(this.browse_source_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.message_textBox);
            this.Name = "Updater_form";
            this.Text = "WSR Updater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox message_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Browse_source_button;
        private System.Windows.Forms.TextBox browse_source_textBox;
        private System.Windows.Forms.Button Browse_destination_button;
        private System.Windows.Forms.TextBox browse_destination_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox line_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox entries_textBox;
        private System.Windows.Forms.RadioButton update_RadioButton;
        private System.Windows.Forms.RadioButton add_RadioButton;
        private System.Windows.Forms.Button Update_button;
    }
}

