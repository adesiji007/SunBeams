using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunBeams
{
    public partial class Reffered_Form : Form
    {
        public Reffered_Form()
        {
            InitializeComponent();
        }

        private void Reffered_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard ds = new Dashboard();
            ds.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
