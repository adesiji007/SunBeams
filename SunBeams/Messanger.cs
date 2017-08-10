using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using WhatsAppApi.Account;
//using WhatsAppApi;

namespace SunBeams
{
    /**
    public partial class Messanger : Form
    {
       // WhatsApp wa;
       // WhatsUser user;


        public Messanger()
        {
            InitializeComponent();
        }

        private delegate void UpdateTextBox(TextBox textbox, string value);
        
        public void UpdateDataTextbox(TextBox textbox, string value)
        {
            textbox.Text += value;
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMessage.Text))
                return;
            if (wa != null)
            {
                if(wa.ConnectionStatus == ApiBase.CONNECTION_STATUS.LOGGEDIN)
                {
                    wa.SendMessage(txtName.Text, txtMessage.Text);
                    txtStatus.Text += string.Format("\r\n{0} : {1}", user.Nickname, txtMessage.Text);
                    txtMessage.Clear();
                    txtMessage.Focus();
                }
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            WhatsUserManager messanger = new WhatsUserManager();
            user = messanger.CreateUser(txtPhone.Text, txtName.Text);
            var thread = new Thread(t =>
            {
                UpdateTextBox textBox = UpdateDataTextbox;
                wa = new WhatsApp(txtPhone.Text, txtPassword.Text, txtName.Text, true);
                wa.OnConnectSuccess += () =>
                    {
                        if (txtStatus.InvokeRequired)
                            Invoke(textBox, txtStatus, "Connected.......");
                        wa.OnLoginSuccess += (phone, data) =>
                            {
                                if(txtStatus.InvokeRequired)
                                    Invoke(textBox, txtStatus, "\r\nLogin success !");
                                while (wa != null)
                        {
                            wa.PollMessages();
                               // Thread.Sleep(200);
                                continue;
                        }
                            };
                        wa.OnGetMessage += (node, form, id, name, message, receipt_sent) =>
                            {
                                if(txtStatus.InvokeRequired)
                                    Invoke(textBox, string.Format("\r\n{0}:{1}", name, message));

                            
                            };
                        wa.OnLoginFailed+=(data) =>
                            {
                                if(txtStatus.InvokeRequired)
                                    Invoke(textBox, txtStatus, string.Format("\r\nLogin failed : {0}", data));
                            
                            };
                        wa.Login();
                    };
                wa.OnConnectFailed += (ex) =>
                    {
                        if(txtStatus.InvokeRequired)
                            Invoke(textBox, txtStatus, string.Format("\r\nConnect failed: {0}", ex.StackTrace));
                    };
                wa.Connect();
            
            }) (IsAccessible = true); //  or use this:   (IsBackground = true);
            thread.Start();
              
        }
    }**/
}
