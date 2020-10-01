namespace C20_Ex01_Eran__311246649_Nir_205489651
{
    public partial class FormDislikeFeature
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelSearchLogo = new System.Windows.Forms.Label();
            this.labelFriend = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelRemove = new System.Windows.Forms.Label();
            this.checkedListBoxRemovable = new System.Windows.Forms.CheckedListBox();
            this.labelFrom = new System.Windows.Forms.Label();
            this.checkedListBoxFrom = new System.Windows.Forms.CheckedListBox();
            this.comboBoxFriends = new System.Windows.Forms.ComboBox();
            this.radioButtonUnfriend = new System.Windows.Forms.RadioButton();
            this.labelAdditionalOptions = new System.Windows.Forms.Label();
            this.pictureBoxDislike2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDislike1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDislike2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDislike1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelHeader.ForeColor = System.Drawing.Color.Maroon;
            this.labelHeader.Location = new System.Drawing.Point(119, 24);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(159, 34);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "Dislike ";
            // 
            // labelSearchLogo
            // 
            this.labelSearchLogo.AutoSize = true;
            this.labelSearchLogo.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Bold);
            this.labelSearchLogo.Location = new System.Drawing.Point(337, 100);
            this.labelSearchLogo.Name = "labelSearchLogo";
            this.labelSearchLogo.Size = new System.Drawing.Size(31, 24);
            this.labelSearchLogo.TabIndex = 2;
            this.labelSearchLogo.Text = "L";
            // 
            // labelFriend
            // 
            this.labelFriend.AutoSize = true;
            this.labelFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriend.Location = new System.Drawing.Point(12, 104);
            this.labelFriend.Name = "labelFriend";
            this.labelFriend.Size = new System.Drawing.Size(74, 20);
            this.labelFriend.TabIndex = 3;
            this.labelFriend.Text = "Friend: ";
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(208, 394);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 28);
            this.buttonApply.TabIndex = 4;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(289, 394);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 28);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelRemove
            // 
            this.labelRemove.AutoSize = true;
            this.labelRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelRemove.Location = new System.Drawing.Point(12, 169);
            this.labelRemove.Name = "labelRemove";
            this.labelRemove.Size = new System.Drawing.Size(88, 20);
            this.labelRemove.TabIndex = 6;
            this.labelRemove.Text = "Remove: ";
            // 
            // checkedListBoxRemovable
            // 
            this.checkedListBoxRemovable.BackColor = System.Drawing.SystemColors.HotTrack;
            this.checkedListBoxRemovable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxRemovable.FormattingEnabled = true;
            this.checkedListBoxRemovable.Items.AddRange(new object[] {
            "Likes",
            "Comments",
            "Tags"});
            this.checkedListBoxRemovable.Location = new System.Drawing.Point(106, 169);
            this.checkedListBoxRemovable.Name = "checkedListBoxRemovable";
            this.checkedListBoxRemovable.Size = new System.Drawing.Size(225, 85);
            this.checkedListBoxRemovable.TabIndex = 7;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFrom.Location = new System.Drawing.Point(12, 258);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(64, 20);
            this.labelFrom.TabIndex = 8;
            this.labelFrom.Text = "From: ";
            // 
            // checkedListBoxFrom
            // 
            this.checkedListBoxFrom.BackColor = System.Drawing.SystemColors.HotTrack;
            this.checkedListBoxFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxFrom.FormattingEnabled = true;
            this.checkedListBoxFrom.Items.AddRange(new object[] {
            "Photos",
            "Posts"});
            this.checkedListBoxFrom.Location = new System.Drawing.Point(106, 258);
            this.checkedListBoxFrom.Name = "checkedListBoxFrom";
            this.checkedListBoxFrom.Size = new System.Drawing.Size(225, 68);
            this.checkedListBoxFrom.TabIndex = 9;
            // 
            // comboBoxFriends
            // 
            this.comboBoxFriends.FormattingEnabled = true;
            this.comboBoxFriends.Location = new System.Drawing.Point(106, 100);
            this.comboBoxFriends.Name = "comboBoxFriends";
            this.comboBoxFriends.Size = new System.Drawing.Size(225, 24);
            this.comboBoxFriends.TabIndex = 10;
            this.comboBoxFriends.DisplayMember = "Name";
            // 
            // radioButtonUnfriend
            // 
            this.radioButtonUnfriend.AutoSize = true;
            this.radioButtonUnfriend.Location = new System.Drawing.Point(190, 335);
            this.radioButtonUnfriend.Name = "radioButtonUnfriend";
            this.radioButtonUnfriend.Size = new System.Drawing.Size(83, 21);
            this.radioButtonUnfriend.TabIndex = 11;
            this.radioButtonUnfriend.TabStop = true;
            this.radioButtonUnfriend.Text = "Unfriend";
            this.radioButtonUnfriend.UseVisualStyleBackColor = true;
            // 
            // labelAdditionalOptions
            // 
            this.labelAdditionalOptions.AutoSize = true;
            this.labelAdditionalOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAdditionalOptions.Location = new System.Drawing.Point(9, 335);
            this.labelAdditionalOptions.Name = "labelAdditionalOptions";
            this.labelAdditionalOptions.Size = new System.Drawing.Size(175, 20);
            this.labelAdditionalOptions.TabIndex = 13;
            this.labelAdditionalOptions.Text = "Additional Options: ";
            // 
            // pictureBoxDislike2
            // 
            this.pictureBoxDislike2.Image = global::C20_Ex01_Eran__311246649_Nir_205489651.Properties.Resources.dislike;
            this.pictureBoxDislike2.Location = new System.Drawing.Point(309, 12);
            this.pictureBoxDislike2.Name = "pictureBoxDislike2";
            this.pictureBoxDislike2.Size = new System.Drawing.Size(55, 55);
            this.pictureBoxDislike2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDislike2.TabIndex = 14;
            this.pictureBoxDislike2.TabStop = false;
            // 
            // pictureBoxDislike1
            // 
            this.pictureBoxDislike1.Image = global::C20_Ex01_Eran__311246649_Nir_205489651.Properties.Resources.dislike;
            this.pictureBoxDislike1.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxDislike1.Name = "pictureBoxDislike1";
            this.pictureBoxDislike1.Size = new System.Drawing.Size(55, 55);
            this.pictureBoxDislike1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDislike1.TabIndex = 15;
            this.pictureBoxDislike1.TabStop = false;
            // 
            // FormDislikeFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(377, 433);
            this.Controls.Add(this.pictureBoxDislike1);
            this.Controls.Add(this.pictureBoxDislike2);
            this.Controls.Add(this.labelAdditionalOptions);
            this.Controls.Add(this.radioButtonUnfriend);
            this.Controls.Add(this.comboBoxFriends);
            this.Controls.Add(this.checkedListBoxFrom);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.checkedListBoxRemovable);
            this.Controls.Add(this.labelRemove);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.labelFriend);
            this.Controls.Add(this.labelSearchLogo);
            this.Controls.Add(this.labelHeader);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDislikeFeature";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormDislikeFeature";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDislike2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDislike1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelSearchLogo;
        private System.Windows.Forms.Label labelFriend;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelRemove;
        private System.Windows.Forms.CheckedListBox checkedListBoxRemovable;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.CheckedListBox checkedListBoxFrom;
        private System.Windows.Forms.ComboBox comboBoxFriends;
        private System.Windows.Forms.RadioButton radioButtonUnfriend;
        private System.Windows.Forms.Label labelAdditionalOptions;
        private System.Windows.Forms.PictureBox pictureBoxDislike2;
        private System.Windows.Forms.PictureBox pictureBoxDislike1;
    }
}