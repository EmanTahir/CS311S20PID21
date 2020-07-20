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
    public partial class DeCompress : Form
    {

        public DeCompress()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        private void DeCompress_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = ofd.FileName;
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            var Form2 = new form2();
            this.Hide();
            new Form1().Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string path1 = textBox1.Text;
            string path2 = textBox3.Text;
            
            if(path1 != null && path2 !=null)
            {
                MessageBox.Show("Decompression successful");
                File_compression_GUI.Huffman.Decoder(path1, path2);
            }
            else
            {
                MessageBox.Show("Enter File paths");
            }

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
