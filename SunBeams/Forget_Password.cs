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
    public partial class Forget_Password : Form
    {
        public Forget_Password()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInPage ss = new LogInPage();
            ss.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInPage ss = new LogInPage();
            ss.Show();
        }

        private void Forget_Password_Load(object sender, EventArgs e)
        {

        }
    }
}
