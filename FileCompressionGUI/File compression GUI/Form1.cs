using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_compression_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Compress_Click(object sender, EventArgs ea)
        {
            var Form1 = new form2();
            new form2().Show();
        }

        private void DeCompress_Click(object sender, EventArgs e)
        {
            var Form1 = new DeCompress();
            new DeCompress().Show();
        }
    }
}
