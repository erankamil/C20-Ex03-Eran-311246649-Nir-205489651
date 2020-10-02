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
    public delegate void CoverPhotoChanged(String i_PhotoURL);

    public partial class ChangeCoverPictureForm : Form
    {
        public event CoverPhotoChanged CoverPhotoChangedNotifier;

        public string PhotoURL { get; set; }

        public ChangeCoverPictureForm()
        {
            InitializeComponent();
            this.buttonRandPhoto.Click += ButtonRandPhoto_Click;
            this.buttonSetPhoto.Click += ButtonSetPhoto_Click;
        }

        private void ButtonSetPhoto_Click(object sender, EventArgs e)
        {
            notifyAll();
        }

        private void ButtonRandPhoto_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int indexAlbum = rand.Next(0, AppManager.Instance.LoggedInUser.Albums.Count - 1);
            string chosenPhotoURL = AppManager.Instance.LoggedInUser.Albums[indexAlbum].PictureThumbURL;
            pictureBox1.LoadAsync(chosenPhotoURL);
            PhotoURL = chosenPhotoURL;
        }

        private void notifyAll()
        {
            CoverPhotoChangedNotifier.Invoke(PhotoURL);
        }
    }
}
