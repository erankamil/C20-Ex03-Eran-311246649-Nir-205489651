namespace C20_Ex01_Eran__311246649_Nir_205489651
{
    public partial class FormPleaseWait
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPleaseWait));
            this.labelCanTakeFewSeconds = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCanTakeFewSeconds
            // 
            this.labelCanTakeFewSeconds.AutoSize = true;
            this.labelCanTakeFewSeconds.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCanTakeFewSeconds.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCanTakeFewSeconds.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelCanTakeFewSeconds.Location = new System.Drawing.Point(14, 17);
            this.labelCanTakeFewSeconds.Name = "labelCanTakeFewSeconds";
            this.labelCanTakeFewSeconds.Size = new System.Drawing.Size(347, 25);
            this.labelCanTakeFewSeconds.TabIndex = 2;
            this.labelCanTakeFewSeconds.Text = "The opperation may take few seconds";
            // 
            // FormPleaseWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(373, 51);
            this.Controls.Add(this.labelCanTakeFewSeconds);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPleaseWait";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Please Wait...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCanTakeFewSeconds;
    }
}