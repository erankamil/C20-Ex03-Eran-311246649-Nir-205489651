namespace C20_Ex01_Eran__311246649_Nir_205489651
{
    public partial class FormCheckInsDetails
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label nameLabel2;
            System.Windows.Forms.Label messageLabel;
            System.Windows.Forms.Label websiteLabel;
            this.checkinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createdTimeLabel1 = new System.Windows.Forms.Label();
            this.descriptionLabel1 = new System.Windows.Forms.Label();
            this.nameLabel3 = new System.Windows.Forms.Label();
            this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxCheckIns = new System.Windows.Forms.ListBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.websiteLabel1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            createdTimeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            nameLabel2 = new System.Windows.Forms.Label();
            messageLabel = new System.Windows.Forms.Label();
            websiteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.checkinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            createdTimeLabel.Location = new System.Drawing.Point(274, 21);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(73, 13);
            createdTimeLabel.TabIndex = 1;
            createdTimeLabel.Text = "Created Time:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            descriptionLabel.Location = new System.Drawing.Point(274, 44);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Description:";
            // 
            // nameLabel2
            // 
            nameLabel2.AutoSize = true;
            nameLabel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            nameLabel2.Location = new System.Drawing.Point(274, 67);
            nameLabel2.Name = "nameLabel2";
            nameLabel2.Size = new System.Drawing.Size(51, 13);
            nameLabel2.TabIndex = 9;
            nameLabel2.Text = "Location:";
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            messageLabel.Location = new System.Drawing.Point(273, 119);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(53, 13);
            messageLabel.TabIndex = 14;
            messageLabel.Text = "Message:";
            // 
            // websiteLabel
            // 
            websiteLabel.AutoSize = true;
            websiteLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            websiteLabel.Location = new System.Drawing.Point(274, 90);
            websiteLabel.Name = "websiteLabel";
            websiteLabel.Size = new System.Drawing.Size(49, 13);
            websiteLabel.TabIndex = 15;
            websiteLabel.Text = "Website:";
            // 
            // checkinBindingSource
            // 
            this.checkinBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Checkin);
            // 
            // createdTimeLabel1
            // 
            this.createdTimeLabel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.createdTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.checkinBindingSource, "CreatedTime", true));
            this.createdTimeLabel1.Location = new System.Drawing.Point(353, 21);
            this.createdTimeLabel1.Name = "createdTimeLabel1";
            this.createdTimeLabel1.Size = new System.Drawing.Size(100, 23);
            this.createdTimeLabel1.TabIndex = 2;
            this.createdTimeLabel1.Text = "label1";
            // 
            // descriptionLabel1
            // 
            this.descriptionLabel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.descriptionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.checkinBindingSource, "Description", true));
            this.descriptionLabel1.Location = new System.Drawing.Point(353, 44);
            this.descriptionLabel1.Name = "descriptionLabel1";
            this.descriptionLabel1.Size = new System.Drawing.Size(100, 23);
            this.descriptionLabel1.TabIndex = 4;
            this.descriptionLabel1.Text = "label1";
            // 
            // nameLabel3
            // 
            this.nameLabel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nameLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.checkinBindingSource, "Place.Name", true));
            this.nameLabel3.Location = new System.Drawing.Point(329, 67);
            this.nameLabel3.Name = "nameLabel3";
            this.nameLabel3.Size = new System.Drawing.Size(100, 23);
            this.nameLabel3.TabIndex = 10;
            this.nameLabel3.Text = "label1";
            // 
            // commentsBindingSource
            // 
            this.commentsBindingSource.DataMember = "Comments";
            this.commentsBindingSource.DataSource = this.checkinBindingSource;
            // 
            // listBoxCheckIns
            // 
            this.listBoxCheckIns.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBoxCheckIns.DataSource = this.checkinBindingSource;
            this.listBoxCheckIns.DisplayMember = "Message";
            this.listBoxCheckIns.FormattingEnabled = true;
            this.listBoxCheckIns.Location = new System.Drawing.Point(23, 21);
            this.listBoxCheckIns.Name = "listBoxCheckIns";
            this.listBoxCheckIns.Size = new System.Drawing.Size(212, 212);
            this.listBoxCheckIns.TabIndex = 14;
            // 
            // messageTextBox
            // 
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.checkinBindingSource, "Message", true));
            this.messageTextBox.Location = new System.Drawing.Point(332, 116);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(156, 73);
            this.messageTextBox.TabIndex = 15;
            // 
            // websiteLabel1
            // 
            this.websiteLabel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.websiteLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.checkinBindingSource, "Place.Website", true));
            this.websiteLabel1.Location = new System.Drawing.Point(329, 90);
            this.websiteLabel1.Name = "websiteLabel1";
            this.websiteLabel1.Size = new System.Drawing.Size(100, 23);
            this.websiteLabel1.TabIndex = 16;
            this.websiteLabel1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(260, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 213);
            this.panel1.TabIndex = 17;
            // 
            // FormCheckInsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(517, 269);
            this.Controls.Add(websiteLabel);
            this.Controls.Add(this.websiteLabel1);
            this.Controls.Add(messageLabel);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.listBoxCheckIns);
            this.Controls.Add(nameLabel2);
            this.Controls.Add(this.nameLabel3);
            this.Controls.Add(createdTimeLabel);
            this.Controls.Add(this.createdTimeLabel1);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionLabel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormCheckInsDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCheckInsDetails";
            ((System.ComponentModel.ISupportInitialize)(this.checkinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource checkinBindingSource;
        private System.Windows.Forms.Label createdTimeLabel1;
        private System.Windows.Forms.Label descriptionLabel1;
        private System.Windows.Forms.Label nameLabel3;
        private System.Windows.Forms.BindingSource commentsBindingSource;
        private System.Windows.Forms.ListBox listBoxCheckIns;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label websiteLabel1;
        private System.Windows.Forms.Panel panel1;
    }
}