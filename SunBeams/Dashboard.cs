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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewUser ss = new NewUser();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActivityRecord dab = new ActivityRecord();
            dab.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trainee_Information dab = new Trainee_Information();
            dab.Show();
        }

        private void admissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trainee_Information dab = new Trainee_Information();
            dab.Show();
            
        }

        private void butReffered_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reffered_Form dab = new Reffered_Form();
            dab.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void butTrainingHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            Training_History dab = new Training_History();
            dab.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trainee_Information dab = new Trainee_Information();
            dab.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ActivityRecord dab = new ActivityRecord();
            dab.Show();
        }

        private void staffInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewUser nu = new NewUser();
            nu.Show();
        }

        private void generalReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActivityRecord nu = new ActivityRecord();
            nu.Show();
        }

        private void firstAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActivityRecord nu = new ActivityRecord();
            nu.Show();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trainee_Information dab = new Trainee_Information();
            dab.Show();
        }

        private void firstAppointmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Training_History dab = new Training_History();
            dab.Show();
        }

        private void secondAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Training_History dab = new Training_History();
            dab.Show();
        }

        private void thirdAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Training_History dab = new Training_History();
            dab.Show();
        }

        private void otherAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Training_History dab = new Training_History();
            dab.Show();
        }

        private void butCaseLoad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Training_Week dab = new Training_Week();
            dab.Show();
        }

        private void butInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Injury_History ih = new Injury_History();
            ih.Show();
        }

        private void butCaseLoadManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Static_Postural_Assessment ih = new Static_Postural_Assessment();
            ih.Show();
        }

        private void nextAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActivityRecord dab = new ActivityRecord();
            dab.Show();
        }

        private void referalFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reffered_Form dab = new Reffered_Form();
            dab.Show();
        }

        private void lettersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reffered_Form dab = new Reffered_Form();
            dab.Show();
        }

        private void caseNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
        }

        private void diagnosisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Static_Postural_Assessment ih = new Static_Postural_Assessment();
            ih.Show();
        }

        private void referalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reffered_Form dab = new Reffered_Form();
            dab.Show();
        }

        private void crucialInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Injury_History dab = new Injury_History();
            dab.Show();
        }

        private void serviceUserInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Static_Postural_Assessment dab = new Static_Postural_Assessment();
            dab.Show();
        }

        private void progressReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Training_Week dab = new Training_Week();
            dab.Show();
        }

        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reffered_Form dab = new Reffered_Form();
            dab.Show();
        }

        private void butCentral_Index_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dynamic_Movement_Screen dab = new Dynamic_Movement_Screen();
            dab.Show();
        }

        private void butCaseNotes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dynamic_Movement_Screen dab = new Dynamic_Movement_Screen();
            dab.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Video_Clips dab = new Video_Clips();
            dab.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Help dab = new Help();
            dab.Show();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Help dab = new Help();
            dab.Show();
        }

        private void absentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
