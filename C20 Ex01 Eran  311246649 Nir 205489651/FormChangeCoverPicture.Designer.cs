namespace C20_Ex01_Eran__311246649_Nir_205489651
{
    public partial class FormChangeCoverPicture
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonRandPhoto = new System.Windows.Forms.Button();
            this.buttonSetPhoto = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(61, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonRandPhoto
            // 
            this.buttonRandPhoto.Location = new System.Drawing.Point(126, 166);
            this.buttonRandPhoto.Name = "buttonRandPhoto";
            this.buttonRandPhoto.Size = new System.Drawing.Size(121, 41);
            this.buttonRandPhoto.TabIndex = 1;
            this.buttonRandPhoto.Text = "Random Photo!";
            this.buttonRandPhoto.UseVisualStyleBackColor = true;
            // 
            // buttonSetPhoto
            // 
            this.buttonSetPhoto.Location = new System.Drawing.Point(52, 223);
            this.buttonSetPhoto.Name = "buttonSetPhoto";
            this.buttonSetPhoto.Size = new System.Drawing.Size(121, 41);
            this.buttonSetPhoto.TabIndex = 2;
            this.buttonSetPhoto.Text = "Set as Cover Photo";
            this.buttonSetPhoto.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(205, 223);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(121, 41);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormChangeCoverPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(387, 291);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSetPhoto);
            this.Controls.Add(this.buttonRandPhoto);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormChangeCoverPicture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Cover Picture";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonRandPhoto;
        private System.Windows.Forms.Button buttonSetPhoto;
        private System.Windows.Forms.Button buttonCancel;
    }
}