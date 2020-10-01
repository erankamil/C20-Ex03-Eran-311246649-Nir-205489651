using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using FaceBookAppLogic;

namespace C20_Ex01_Eran__311246649_Nir_205489651
{

    public partial class FormFaceLoveFeature : Form
    {
        private List<User> m_OptionalFriends;
        private int m_CurrentFriendIndex;

        public FormFaceLoveFeature(User i_LoggedInUser)
        { 
            InitializeComponent();
            buttonFind.Click += ButtonFind_Click;
            initializeGenderComberBox();
            m_CurrentFriendIndex = 0;
        }

        private void initializeGenderComberBox()
        {
            string[] genderTypes = AppManager.Instance.GetGenderTypes();
            foreach (string gender in genderTypes)
            {
                this.comboBoxGenders.Items.Add(gender);
            }
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            string selectedGender = this.comboBoxGenders.Text;
            if (!string.IsNullOrEmpty(selectedGender) && checkedListBoxRange.CheckedItems.Count == 1)
            {
                try
                {
                    faceLoveFeatureActions(selectedGender, checkedListBoxRange.SelectedItem.ToString());
                }
                catch (FormatException ec)
                {
                    string title = "Invalid Input";
                    MessageBox.Show(ec.Message, title);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(selectedGender))
                {
                    string message = "gender field is empty";
                    string title = "Invalid Input";
                    MessageBox.Show(message, title);
                }
                else if (this.checkedListBoxRange.CheckedItems.Count == 0)
                {
                    string message = "Please choose age range";
                    string title = "Invalid Input";
                    MessageBox.Show(message, title);
                }
                else
                {
                    string message = "Please choose one age range only";
                    string title = "Invalid Input";
                    MessageBox.Show(message, title);
                }
            }
        }

        private void faceLoveFeatureActions(string i_SelectedGender, string i_SelectedAgeRange)
        {
            if (AppManager.Instance.CheckValidGender(ref i_SelectedGender))
            {
                FaceLoveLogic.AddFriendStrategy = new AgeAndGenderStrategy { Gender = i_SelectedGender.ToLower(), AgeRange = FaceLoveLogic.GetAgeRange(i_SelectedAgeRange) };

                m_OptionalFriends = AppManager.Instance.GetOptionalFriendsForDating(i_SelectedGender, i_SelectedAgeRange);
                if (m_OptionalFriends.Count > 0)
                {
                    changeFormDisplay();
                    User currentSingleFriend = getCurrnetSingleFriend();
                    getCurrentSingleFriendDetails(currentSingleFriend);
                }
                else
                {
                    string message = "Sorry, there are no results for you search..";
                    string title = "app notification";
                    MessageBox.Show(message, title);
                }
            }
        }

        private void getCurrentSingleFriendDetails(User i_CurrentSingleFriend)
        {
            try
            {
                this.pictureBoxFriendProfile.LoadAsync(i_CurrentSingleFriend.PictureNormalURL);
                this.pictureBoxFriendProfile.BackgroundImageLayout = ImageLayout.Stretch;
                this.pictureBoxFriendProfile.SizeMode = PictureBoxSizeMode.StretchImage;
                this.pictureBoxFriendProfile.Visible = true;
                this.pictureBoxFriendProfile.Enabled = true;
                this.labelFriendName.Text = $"Name: {i_CurrentSingleFriend.FirstName}";
                this.labelFriendAge.Text = $"Age: {AppManager.Instance.GetFriendAge(i_CurrentSingleFriend.Birthday)}";   
                this.labelUserResidence.Text = $"Location: {i_CurrentSingleFriend.Location.Name}";
                m_CurrentFriendIndex++;
            }
            catch(Exception ex)
            {
                AppManager.Instance.MethodToCatchExeptionsFromFacebookThatWeCantAvoid(ex);
            }
        }

        private User getCurrnetSingleFriend()
        {
            User currentSingleFriend = null;
            try
            {
                if (m_CurrentFriendIndex + 1 > m_OptionalFriends.Count)
                {
                    string message = "There are no more single friends..";
                    string title = "App notification";
                    MessageBox.Show(message, title);
                    this.Close();
                }
                else
                {
                    currentSingleFriend = m_OptionalFriends.ElementAt(m_CurrentFriendIndex);
                }
            }
            catch(Exception ex)
            {
                AppManager.Instance.MethodToCatchExeptionsFromFacebookThatWeCantAvoid(ex);
            }

            return currentSingleFriend;
        }

        private void changeFormDisplay()
        {
            comboBoxGenders.Visible = false;
            comboBoxGenders.Enabled = false;
            labelChooseGender.Visible = false;
            labelChooseGender.Enabled = false;
            labelChooseAgeRange.Enabled = false;
            labelChooseAgeRange.Visible = false;
            checkedListBoxRange.Visible = false;
            checkedListBoxRange.Enabled = false;
            pictureBoxSmily.Visible = false;
            labelPressLikeIfIntrested.Enabled = true;
            labelPressLikeIfIntrested.Visible = true;
            pictureBoxDislike.Visible = true;
            pictureBoxDislike.Enabled = true;
            pictureBoxLike.Enabled = true;
            pictureBoxLike.Visible = true;
            buttonLike.Visible = true;
            buttonLike.Enabled = true;
            buttonPass.Visible = true;
            buttonPass.Enabled = true;
            labelUserResidence.Enabled = true;
            labelUserResidence.Visible = true;
            labelFriendName.Enabled = true;
            labelFriendName.Visible = true;
            labelFriendAge.Enabled = true;
            labelFriendAge.Visible = true;
            pictureBoxFriendProfile.Enabled = true;
            pictureBoxFriendProfile.Visible = true;
            this.buttonLike.Click += ButtonLike_Click;
            this.buttonPass.Click += ButtonPass_Click;
        }

        private void ButtonPass_Click(object sender, EventArgs e)
        {
            User ulikedFriend = m_OptionalFriends[m_CurrentFriendIndex - 1];
            string msg = string.Format(@"Are you sure you want to pass {0}?", ulikedFriend.FirstName);
            if (MessageBox.Show(msg, "App assistant", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                User currentSingleFriend = getCurrnetSingleFriend();
                if (currentSingleFriend != null)
                {
                    getCurrentSingleFriendDetails(currentSingleFriend);
                }
            }
        }

        private void ButtonLike_Click(object sender, EventArgs e)
        {
            User likedFriend = m_OptionalFriends[m_CurrentFriendIndex - 1];
            string msg = string.Format(
                @"Would you like to send {0} a message?
(Notice: People say it improves your chances!)",
likedFriend.FirstName);

            if (MessageBox.Show(msg, "App assistant", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                FormSendMessage formSendMessage = new FormSendMessage(likedFriend);
                formSendMessage.ShowDialog();
            }

            User currentSingleFriend = getCurrnetSingleFriend();
            if (currentSingleFriend != null)
            {
                getCurrentSingleFriendDetails(currentSingleFriend);
            }
        }
    }
}
