using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using FaceBookAppLogic;

namespace C20_Ex01_Eran__311246649_Nir_205489651
{
    public partial class FormAccount : Form
    {
        private DesignedPanel m_PanelSpecialFeatures;
        private DesignedPanel m_PanelShowDetails;

        public FormAccount()
        {
            InitializeComponent();
            InitializeCommandPanels();
        }
        private void InitializeCommandPanels()
        {
            m_PanelSpecialFeatures = new DesignedPanel();
            m_PanelSpecialFeatures.BackColor = Color.DarkBlue;
            m_PanelSpecialFeatures.BringToFront();
            m_PanelSpecialFeatures.Enabled = false;
            m_PanelSpecialFeatures.Location = new System.Drawing.Point(420, 195);
            m_PanelSpecialFeatures.Name = "PanelSpecialFeatures";
            m_PanelSpecialFeatures.Size = new System.Drawing.Size(130, 210);
            m_PanelSpecialFeatures.Add(new DesignedButton() { CommandDelegate = ShowFaceLoveFeature, Text = "FaceLove", BackColor = Color.LightPink });
            m_PanelSpecialFeatures.Add(new DesignedButton() { CommandDelegate = ShowDislikeFeature, Text = "Dislike", BackColor = Color.Red });

            m_PanelShowDetails = new DesignedPanel();
            m_PanelShowDetails.BackColor = Color.SteelBlue;
            m_PanelShowDetails.BringToFront();
            m_PanelShowDetails.Enabled = false;
            m_PanelShowDetails.Location = new System.Drawing.Point(220, 195);
            m_PanelShowDetails.Name = "PanelShowDetails";
            m_PanelShowDetails.Size = new System.Drawing.Size(130, 210);
            m_PanelShowDetails.Add(new DesignedButton() { CommandDelegate = ShowFriends, Text = "Show Friends", BackColor = Color.Gray });
            m_PanelShowDetails.Add(new DesignedButton() { CommandDelegate = ShowPosts, Text = "Show Posts", BackColor = Color.Gray });
            m_PanelShowDetails.Add(new DesignedButton() { CommandDelegate = ShowCheckins, Text = "Show Check-ins", BackColor = Color.Gray });

            this.Controls.Add(m_PanelSpecialFeatures);
            this.Controls.Add(m_PanelShowDetails);
        }


        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = !buttonLogin.Enabled;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                AppManager.Instance.Login();
                new Thread(fetchUserData).Start();
                changeButtonsState();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void changeButtonsState()
        {
            this.buttonLogin.Enabled = !this.buttonLogin.Enabled;
            this.buttonLogout.Enabled = !this.buttonLogout.Enabled;
            this.buttonPostStatus.Enabled = !this.buttonPostStatus.Enabled;
            this.buttonFriends.Enabled = !this.buttonFriends.Enabled;
            this.buttonPosts.Enabled = !this.buttonPosts.Enabled;
            this.buttonCheckIns.Enabled = !this.buttonCheckIns.Enabled;
            m_PanelSpecialFeatures.Enabled = !m_PanelSpecialFeatures.Enabled;
            m_PanelShowDetails.Enabled = !m_PanelShowDetails.Enabled;
        }

        private void fetchUserData()
        {
            User loggedInUser = AppManager.Instance.LoggedInUser;
            this.Invoke(new Action(() => this.Text = $"Logged in as {loggedInUser.Name}"));
            this.Invoke(new Action(() => this.pictureBoxProfilePicture.LoadAsync(loggedInUser.PictureNormalURL)));
            this.Invoke(new Action(() => this.labelGender.Text = loggedInUser.Gender.ToString()));
            this.Invoke(new Action(() => this.labelLocation.Text = loggedInUser.Location.Name));
            this.Invoke(new Action(() => this.labelEmail.Text = loggedInUser.Email.ToString()));
            this.Invoke(new Action(() => this.labelBirthday.Text = loggedInUser.Birthday.ToString()));
            this.Invoke(new Action(() => this.labelProfileID.Text = loggedInUser.Id.ToString()));
            new Thread(getUserCoverPhoto).Start();
        }

        private void getUserCoverPhoto()
        {
            foreach (Album album in AppManager.Instance.LoggedInUser.Albums)
            {
                if (album.Name == "Cover Photos")
                {
                    this.Invoke(new Action(() => this.pictureBoxCoverPhoto.LoadAsync(album.PictureThumbURL)));
                }
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            AppManager.Instance.Logout();
            logoutActions();
        }

        private void logoutActions()
        {
            changeButtonsState();
            this.pictureBoxProfilePicture.Image = null;
            this.pictureBoxCoverPhoto.Image = null;
            this.Text = string.Empty;
            this.labelGender.Text = string.Empty;
            this.labelLocation.Text = string.Empty;
            this.labelEmail.Text = string.Empty;
            this.labelProfileID.Text = string.Empty;
            this.labelBirthday.Text = string.Empty;

            this.textBoxPostStatus.Clear();
        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            postStatus(textBoxPostStatus.Text);
        }

        private void postStatus(string i_StatusToPost)
        {
            if (!string.IsNullOrEmpty(i_StatusToPost))
            {
                try
                {
                    AppManager.Instance.LoggedInUser.PostStatus(i_StatusToPost);
                }
                catch (Exception ex)
                {
                    AppManager.Instance.MethodToCatchExeptionsFromFacebookThatWeCantAvoid(ex);
                }
                finally
                {
                    textBoxPostStatus.Clear();
                    MessageBox.Show(this, "Posted!");
                }
            }
            else
            {
                MessageBox.Show("cannot post an empty status!");
            }
        }
        private void ShowFaceLoveFeature()
        {
            FormFaceLoveFeature formFaceLove = new FormFaceLoveFeature(AppManager.Instance.LoggedInUser);
            formFaceLove.ShowDialog();
        }

        private void ShowDislikeFeature()
        {
            FormDislikeFeature formDislike = new FormDislikeFeature();
            formDislike.ShowDialog();
        }

        private void ShowFriends()
        {
            FormFriendsDetails formFriendsDetails = new FormFriendsDetails();
            formFriendsDetails.ShowDialog();
        }

        private void ShowPosts()
        {
            FormPostDetails formPostDetails = new FormPostDetails();
            formPostDetails.ShowDialog();
        }

        private void ShowCheckins()
        {
            FormCheckInsDetails formCheckInsDetails = new FormCheckInsDetails();
            formCheckInsDetails.ShowDialog();
        }
    }
}
