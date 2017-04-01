using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCrypter
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        private void main_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Show Passphrase checkbox
            if (checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            // File Select
            DialogResult FileSelectResult = FileSelect.ShowDialog();
            if (FileSelectResult == DialogResult.OK)
            {
                textBox1.Text = FileSelect.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // File Save
            DialogResult FileSaveResult = FileSave.ShowDialog();
            if (FileSaveResult == DialogResult.OK)
            {
                MessageBox.Show(FileSelect.FileName);
            }
        }
    }
}
