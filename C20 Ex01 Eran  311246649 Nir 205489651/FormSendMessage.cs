using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using FaceBookAppLogic;

namespace C20_Ex01_Eran__311246649_Nir_205489651
{
    public partial class FormSendMessage : Form
    {
        private User m_FriendToSend;

        public FormSendMessage(User i_FriendToSend)
        {
            m_FriendToSend = i_FriendToSend;
            InitializeComponent();
            this.buttonSend.Click += ButtonSend_Click;
            this.labelEnterMessage.Text = $"Please enter you message to {m_FriendToSend.Name}:";
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
           if(!string.IsNullOrEmpty(richTextBoxMessage.Text))
            {
                AppManager.Instance.SendMessageToFriend(m_FriendToSend);
                string msg = $"Message was sent successfully To {m_FriendToSend.Name}!";
                MessageBox.Show(msg, "FaceLove notification");
                this.Close();
            }
           else
            {
                string error = "Can not send empty message";
                MessageBox.Show(error, "Invalid input");
            }
        }
    }
}
