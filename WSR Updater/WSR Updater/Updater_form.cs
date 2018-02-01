using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WSR_Updater
{
    public partial class Updater_form : Form
    {
        private string path = "";

        public Updater_form()
        {
            InitializeComponent();
        }

        private void Browse_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "WSR files (*.wsr)|*.wsr";
            openDialog.Title = "Select a File";

            if (openDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = openDialog.FileName;
                browse_textBox.Text = path;
            }
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            if (line_textBox.Text == "" || entries_textBox.Text == ""
                || browse_textBox.Text == "" || total_textBox.Text == "")
            {
                message_textBox.Text += "Error: All fields are required.\r\n";
            }

            else if (!path.Contains(".wsr"))
                message_textBox.Text += "Error: Only WSR file types are supported.";

            else
            {
                try
                {
                    if (add_RadioButton.Checked)
                    {
                        int changeline = int.Parse(line_textBox.Text);
                        int addline = int.Parse(entries_textBox.Text);
                        int totalline = int.Parse(total_textBox.Text);

                        AlterLines(changeline, totalline, addline);
                    }
                    else
                    {
                        FillGaps();

                    }

                    message_textBox.Text = "Success! WSR successfully updated here:\r\n\r\n" + path;
                    line_textBox.Text = ""; entries_textBox.Text = "";
                    browse_textBox.Text = ""; total_textBox.Text = "";
                }
                catch (Exception)
                {
                    message_textBox.Text += "Error: Invalid value entered.\r\n";
                }
            }
        }

        public void AlterLines(int c, int t, int a)
        {
            string text = File.ReadAllText(path);
            string empty = "", pre, post;

            for (int i = c; i < c + a; i++)
            {
                empty += String.Format(i + "=\r\n");
            }

            for (int i = t; i >= c; i--)
            {
                pre = String.Format(i + "=");
                if (i != c)
                    post = String.Format((i + a) + "=");
                else
                    post = String.Format(empty + (i + a) + "=");


                text = text.Replace(pre, post);
            }

            File.WriteAllText(@path, text);

        }

        private void FillGaps()
        {

        }

        private void gaps_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            line_textBox.Enabled = false;
            entries_textBox.Enabled = false;
        }

        private void add_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            line_textBox.Enabled = true;
            entries_textBox.Enabled = true;
        }
    }
}
