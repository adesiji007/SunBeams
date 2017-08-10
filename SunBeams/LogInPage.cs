using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace SunBeams
{
    public partial class LogInPage : Form
    {
        public LogInPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard ss = new Dashboard();
            ss.Show();

            /**
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\adesiji\Documents\data1.mdf;Integrated Security=True;Connect Timeout=30; User Instance=True;");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*)From Table where username = '" + textBox1.Text + "' and password= '" + textBox2.Text + "'", conn);
            DataTable dt = new DataTable();
            //conn.Open();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1" && dt.Rows[0][0].ToString() == "2")
            {
                this.Hide();
                Dashboard ss = new Dashboard();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Please check your Username and Password! or Register as a new users!");
            }**/

        }


        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewUser ss = new NewUser();
            ss.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forget_Password ss = new Forget_Password();
            ss.Show();
        }

        private void LogInPage_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

