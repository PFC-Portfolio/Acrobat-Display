using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metrophile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Directory.SetCurrentDirectory(Directory.GetCurrentDirectory().ToString() + "/PDF Repository");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile("King County Metro 106.pdf");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile("King County Metro 775.pdf");
        }
    }
}
