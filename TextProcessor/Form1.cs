using System;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace TextProcessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                textBoxText.Text = File.ReadAllText(openFileDialog.FileName, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                File.WriteAllText(saveFileDialog.FileName, textBoxText.Text, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
                return;
            textBoxText.Text = textBoxText.Text.Replace(textBoxSearch.Text, textBoxChange.Text);
        }
    }
}
