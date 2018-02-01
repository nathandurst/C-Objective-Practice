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
        private string source = "", destination = "";
        private int linesOfSQL;
        private int startline, entries, updated, added;

        public Updater_form()
        {
            InitializeComponent();
        }

        private void Browse_source_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "WSR files (*.wsr)|*.wsr";
            openDialog.Title = "Select a File";

            if (openDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                source = openDialog.FileName;
                browse_source_textBox.Text = source;
            }
        }

        private void Browse_destination_button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            
            if(folderDialog.ShowDialog() == DialogResult.OK)
            {
                destination = folderDialog.SelectedPath;
                browse_destination_textBox.Text = destination;
            }
                
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            if (((line_textBox.Text == "" || entries_textBox.Text == "" || browse_source_textBox.Text == "" 
                || browse_destination_textBox.Text == "" ) && add_RadioButton.Checked) 
                || ((browse_source_textBox.Text == "" || browse_destination_textBox.Text == "") 
                && gaps_RadioButton.Checked))
            {
                message_textBox.Text += "Error: All fields are required.\r\n";
            }

            else if (!source.Contains(".wsr"))
                message_textBox.Text += "Error: Only WSR file types are supported.";

            else
            {
                try
                {
                    if (add_RadioButton.Checked)
                    {
                        startline = int.Parse(line_textBox.Text);
                        entries = int.Parse(entries_textBox.Text);

                        GetTotalLines();
                    }
                    else
                    {
                        GetTotalLines();
                        UpdateAllLines();

                    }

                    message_textBox.Text = "Success! WSR successfully updated here:\r\n\r\n" + destination;
                    line_textBox.Text = ""; entries_textBox.Text = "";
                    browse_source_textBox.Text = ""; browse_destination_textBox.Text = "";
                    source = ""; destination = "";
                }
                catch (Exception)
                {
                    message_textBox.Text += "Error: Invalid value entered.\r\n";
                }
            }
        }

        public void UpdateAllLines()
        {
            string text = File.ReadAllText(source);
            StreamReader sr = new StreamReader(source);
            string oldline = sr.ReadLine(), newline = "";
            int i = 0;

            while (oldline != "[PreProcessSQL]" && !sr.EndOfStream)
                oldline = sr.ReadLine();

            oldline = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                if ((oldline.IndexOf("=INSERT INTO", 0, StringComparison.CurrentCultureIgnoreCase) > -1
                    || oldline.IndexOf("=CREATE", 0, StringComparison.CurrentCultureIgnoreCase) > -1
                    || oldline.IndexOf("=ALTER ", 0, StringComparison.CurrentCultureIgnoreCase) > -1
                    || oldline.IndexOf("=UPDATE ", 0, StringComparison.CurrentCultureIgnoreCase) > -1
                    || oldline.IndexOf("=DELETE ", 0, StringComparison.CurrentCultureIgnoreCase) > -1
                    || oldline.IndexOf("=SELECT ", 0, StringComparison.CurrentCultureIgnoreCase) > -1)
                    && oldline.IndexOf(";--", 0, StringComparison.CurrentCultureIgnoreCase) <= -1)
                {
                    i++;
                    string[] splitline = oldline.Split('=');
                    string oldnum = String.Format(splitline[0] + "=");
                    newline = oldline.Replace(oldnum, String.Format(i + "="));
                    text = text.Replace(oldline, newline);
                }

                oldline = sr.ReadLine();
            }

            //MessageBox.Show(text);
            File.WriteAllText(destination + "\\" + $@"{Guid.NewGuid()}.wsr", text);

        }

        private void GetTotalLines()
        {
            StreamReader sr = new StreamReader(source);
            string line = sr.ReadLine();
            linesOfSQL = 0;

            while (line != "[PreProcessSQL]" && !sr.EndOfStream)
                line = sr.ReadLine();

            while (!sr.EndOfStream)
            {
                if ((line.IndexOf("=INSERT INTO", 0, StringComparison.CurrentCultureIgnoreCase) > -1
                    || line.IndexOf("=CREATE", 0, StringComparison.CurrentCultureIgnoreCase) > -1
                    || line.IndexOf("=ALTER ", 0, StringComparison.CurrentCultureIgnoreCase) > -1
                    || line.IndexOf("=UPDATE ", 0, StringComparison.CurrentCultureIgnoreCase) > -1
                    || line.IndexOf("=DELETE ", 0, StringComparison.CurrentCultureIgnoreCase) > -1
                    || line.IndexOf("=SELECT ", 0, StringComparison.CurrentCultureIgnoreCase) > -1)
                    && line.IndexOf(";--", 0, StringComparison.CurrentCultureIgnoreCase) <= -1)
                    linesOfSQL++;

                line = sr.ReadLine();
            }
            //message_textBox.Text = "There are " + linesOfSQL + " lines of SQL\r\n";

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
