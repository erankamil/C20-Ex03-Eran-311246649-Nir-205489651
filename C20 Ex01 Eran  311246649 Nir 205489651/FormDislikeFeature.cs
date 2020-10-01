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
    public partial class FormDislikeFeature : Form
    {
        private User m_ChosenFriendUser;

        public FormDislikeFeature()
        {
            m_ChosenFriendUser = null;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            resetForm();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if(checkCheckboxsFieldsValidation())
            {
                m_ChosenFriendUser = this.comboBoxFriends.SelectedItem as User;
                using (FormPleaseWait formPleaseWait = new FormPleaseWait(
                    executeFunctionsAccordingToCheckBoxes))
                {
                    formPleaseWait.ShowDialog();
                }

                this.resetForm();
            }
            else
            {
                MessageBox.Show("You Must Fill 'Friend', 'Remove' and 'From'!");
            }
        }

        private bool checkCheckboxsFieldsValidation()
        {
            return !string.IsNullOrEmpty(comboBoxFriends.Text) &&
                checkedListBoxFrom.CheckedItems.Count > 0 &&
                checkedListBoxRemovable.CheckedItems.Count > 0;
        }

        private void executeFunctionsAccordingToCheckBoxes()
        {
            List<string> removableStringArr = new List<string>();
            List<string> fromStringArr = new List<string>();
            string friendFullName = m_ChosenFriendUser.Name;

            foreach (string RemovableListBoxString in checkedListBoxRemovable.CheckedItems)
            {
                removableStringArr.Add(RemovableListBoxString);
            }

            foreach (string FromListBoxString in checkedListBoxFrom.CheckedItems)
            {
                fromStringArr.Add(FromListBoxString);
            }

            AppManager.Instance.DislikeFeatureRemoveFrom(removableStringArr, fromStringArr, m_ChosenFriendUser);

            if (radioButtonUnfriend.Checked)
            {
                string txt = string.Format("Are You Sure That You Wanna Unfriend {0}?", friendFullName);
                if (MessageBox.Show(txt, string.Empty, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    AppManager.Instance.LoggedInUser.Friends.Remove(m_ChosenFriendUser);
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetForm()
        {
            comboBoxFriends.Text = string.Empty;
            comboBoxFriends.Items.Clear();
            foreach (User friend in AppManager.Instance.LoggedInUser.Friends)
            {
                this.comboBoxFriends.Items.Add(friend);
            }

            foreach (int i in checkedListBoxRemovable.CheckedIndices)
            {
                checkedListBoxRemovable.SetItemCheckState(i, CheckState.Unchecked);
            }

            foreach (int i in checkedListBoxFrom.CheckedIndices)
            {
                checkedListBoxFrom.SetItemCheckState(i, CheckState.Unchecked);
            }

            radioButtonUnfriend.Checked = false;
        }
    }
}
