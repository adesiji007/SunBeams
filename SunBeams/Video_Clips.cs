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
    public partial class Video_Clips : Form
    {
        public Video_Clips()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dab = new Dashboard();
            dab.Show();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = textBox1_path.Text;
            axWindowsMediaPlayer2.Ctlcontrols.play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = textBox1_path.Text;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer3.URL = textBox1_path.Text;
            axWindowsMediaPlayer3.Ctlcontrols.play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer4.URL = textBox1_path.Text;
            axWindowsMediaPlayer4.Ctlcontrols.play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fitness_Training_Video dab = new Fitness_Training_Video();
            dab.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            this.Hide();
            Fitness_Training_Video dab = new Fitness_Training_Video();
            dab.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fitness_Training_Video dab = new Fitness_Training_Video();
            dab.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fitness_Training_Video dab = new Fitness_Training_Video();
            dab.Show();
        }

        private void Choose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textBox1_path.Text = openFileDialog1.FileName;
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.stop();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.previous();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.next();
        }
        
    }
}
