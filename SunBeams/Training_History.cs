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
    public partial class Training_History : Form
    {
        public Training_History()
        {
            InitializeComponent();
            this.VisibleChanged += Training_History_VisibleChanged;
        }

        private void Training_History_VisibleChanged(object sender, EventArgs e)
        
        
        {
            if (this.Visible $$ )
            throw new NotImplementedException();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard ds = new Dashboard();
            ds.Show();
        }

        private void Training_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Training_History_Load(object sender, EventArgs e)
        {

        }
    }
}
