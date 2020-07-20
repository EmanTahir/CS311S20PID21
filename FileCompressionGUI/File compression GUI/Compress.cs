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

namespace File_compression_GUI
{
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        private void Button1_Click(object sender, EventArgs e)
        {
           if(ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var Form2 = new form2();
            this.Hide();
            new Form1().Show();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string path = textBox1.Text;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            
            if (path != null)
            {
                File_compression_GUI.Huffman.Start(path);
                MessageBox.Show("Compression successful");
            }
            else
            {
                MessageBox.Show("Enter File paths");
            }
        }
    }
}
