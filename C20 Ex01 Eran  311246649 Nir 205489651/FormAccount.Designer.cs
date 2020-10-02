namespace C20_Ex01_Eran__311246649_Nir_205489651
{
    public partial class FormAccount
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccount));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelProfileID = new System.Windows.Forms.Label();
            this.buttonFriends = new System.Windows.Forms.Button();
            this.buttonCheckIns = new System.Windows.Forms.Button();
            this.buttonPosts = new System.Windows.Forms.Button();
            this.pictureBoxID = new System.Windows.Forms.PictureBox();
            this.pictureBoxBirthday = new System.Windows.Forms.PictureBox();
            this.pictureBoxEmail = new System.Windows.Forms.PictureBox();
            this.pictureBoxGender = new System.Windows.Forms.PictureBox();
            this.pictureBoxLocation = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoverPhoto = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxPostStatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBirthday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Lavender;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(12, 123);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(77, 30);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Lavender;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(95, 123);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 30);
            this.buttonLogout.TabIndex = 6;
            this.buttonLogout.Text = "Log out";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.BackColor = System.Drawing.Color.Lavender;
            this.buttonPostStatus.Enabled = false;
            this.buttonPostStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPostStatus.Location = new System.Drawing.Point(221, 119);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(140, 44);
            this.buttonPostStatus.TabIndex = 9;
            this.buttonPostStatus.Text = "Post status";
            this.buttonPostStatus.UseVisualStyleBackColor = false;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_Click);
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.Location = new System.Drawing.Point(58, 227);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(0, 17);
            this.labelLocation.TabIndex = 20;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(58, 176);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(0, 17);
            this.labelGender.TabIndex = 21;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(58, 276);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(0, 17);
            this.labelEmail.TabIndex = 25;
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthday.Location = new System.Drawing.Point(58, 323);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(0, 17);
            this.labelBirthday.TabIndex = 26;
            // 
            // labelProfileID
            // 
            this.labelProfileID.AutoSize = true;
            this.labelProfileID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfileID.Location = new System.Drawing.Point(62, 377);
            this.labelProfileID.Name = "labelProfileID";
            this.labelProfileID.Size = new System.Drawing.Size(0, 17);
            this.labelProfileID.TabIndex = 27;
            // 
            // buttonFriends
            // 
            this.buttonFriends.Location = new System.Drawing.Point(0, 0);
            this.buttonFriends.Name = "buttonFriends";
            this.buttonFriends.Size = new System.Drawing.Size(75, 23);
            this.buttonFriends.TabIndex = 0;
            // 
            // buttonCheckIns
            // 
            this.buttonCheckIns.Location = new System.Drawing.Point(0, 0);
            this.buttonCheckIns.Name = "buttonCheckIns";
            this.buttonCheckIns.Size = new System.Drawing.Size(75, 23);
            this.buttonCheckIns.TabIndex = 0;
            // 
            // buttonPosts
            // 
            this.buttonPosts.Location = new System.Drawing.Point(0, 0);
            this.buttonPosts.Name = "buttonPosts";
            this.buttonPosts.Size = new System.Drawing.Size(75, 23);
            this.buttonPosts.TabIndex = 0;
            // 
            // pictureBoxID
            // 
            this.pictureBoxID.BackgroundImage = global::C20_Ex01_Eran__311246649_Nir_205489651.Properties.Resources.name;
            this.pictureBoxID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxID.Location = new System.Drawing.Point(13, 371);
            this.pictureBoxID.Name = "pictureBoxID";
            this.pictureBoxID.Size = new System.Drawing.Size(39, 33);
            this.pictureBoxID.TabIndex = 33;
            this.pictureBoxID.TabStop = false;
            // 
            // pictureBoxBirthday
            // 
            this.pictureBoxBirthday.BackgroundImage = global::C20_Ex01_Eran__311246649_Nir_205489651.Properties.Resources.party;
            this.pictureBoxBirthday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBirthday.Location = new System.Drawing.Point(13, 319);
            this.pictureBoxBirthday.Name = "pictureBoxBirthday";
            this.pictureBoxBirthday.Size = new System.Drawing.Size(39, 33);
            this.pictureBoxBirthday.TabIndex = 32;
            this.pictureBoxBirthday.TabStop = false;
            // 
            // pictureBoxEmail
            // 
            this.pictureBoxEmail.BackgroundImage = global::C20_Ex01_Eran__311246649_Nir_205489651.Properties.Resources.mail;
            this.pictureBoxEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxEmail.Location = new System.Drawing.Point(13, 270);
            this.pictureBoxEmail.Name = "pictureBoxEmail";
            this.pictureBoxEmail.Size = new System.Drawing.Size(39, 33);
            this.pictureBoxEmail.TabIndex = 31;
            this.pictureBoxEmail.TabStop = false;
            // 
            // pictureBoxGender
            // 
            this.pictureBoxGender.BackgroundImage = global::C20_Ex01_Eran__311246649_Nir_205489651.Properties.Resources.gender;
            this.pictureBoxGender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxGender.Location = new System.Drawing.Point(13, 168);
            this.pictureBoxGender.Name = "pictureBoxGender";
            this.pictureBoxGender.Size = new System.Drawing.Size(39, 33);
            this.pictureBoxGender.TabIndex = 30;
            this.pictureBoxGender.TabStop = false;
            // 
            // pictureBoxLocation
            // 
            this.pictureBoxLocation.BackgroundImage = global::C20_Ex01_Eran__311246649_Nir_205489651.Properties.Resources.location_pin;
            this.pictureBoxLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLocation.Location = new System.Drawing.Point(13, 221);
            this.pictureBoxLocation.Name = "pictureBoxLocation";
            this.pictureBoxLocation.Size = new System.Drawing.Size(39, 33);
            this.pictureBoxLocation.TabIndex = 29;
            this.pictureBoxLocation.TabStop = false;
            // 
            // pictureBoxCoverPhoto
            // 
            this.pictureBoxCoverPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCoverPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCoverPhoto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBoxCoverPhoto.Location = new System.Drawing.Point(221, 12);
            this.pictureBoxCoverPhoto.Name = "pictureBoxCoverPhoto";
            this.pictureBoxCoverPhoto.Size = new System.Drawing.Size(348, 99);
            this.pictureBoxCoverPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoverPhoto.TabIndex = 28;
            this.pictureBoxCoverPhoto.TabStop = false;
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(23, 12);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(125, 105);
            this.pictureBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfilePicture.TabIndex = 3;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // textBoxPostStatus
            // 
            this.textBoxPostStatus.Location = new System.Drawing.Point(368, 119);
            this.textBoxPostStatus.Multiline = true;
            this.textBoxPostStatus.Name = "textBoxPostStatus";
            this.textBoxPostStatus.Size = new System.Drawing.Size(202, 44);
            this.textBoxPostStatus.TabIndex = 22;
            // 
            // FormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(586, 423);
            this.Controls.Add(this.pictureBoxID);
            this.Controls.Add(this.pictureBoxBirthday);
            this.Controls.Add(this.pictureBoxEmail);
            this.Controls.Add(this.textBoxPostStatus);
            this.Controls.Add(this.pictureBoxGender);
            this.Controls.Add(this.buttonPostStatus);
            this.Controls.Add(this.pictureBoxLocation);
            this.Controls.Add(this.pictureBoxCoverPhoto);
            this.Controls.Add(this.labelProfileID);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.pictureBoxProfilePicture);
            this.Controls.Add(this.buttonLogin);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook Desktop App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBirthday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelProfileID;
        private System.Windows.Forms.PictureBox pictureBoxCoverPhoto;
        private System.Windows.Forms.PictureBox pictureBoxLocation;
        private System.Windows.Forms.PictureBox pictureBoxGender;
        private System.Windows.Forms.PictureBox pictureBoxEmail;
        private System.Windows.Forms.PictureBox pictureBoxBirthday;
        private System.Windows.Forms.PictureBox pictureBoxID;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.Button buttonFriends;
        private System.Windows.Forms.Button buttonCheckIns;
        private System.Windows.Forms.Button buttonPosts;
        private System.Windows.Forms.TextBox textBoxPostStatus;
    }
}