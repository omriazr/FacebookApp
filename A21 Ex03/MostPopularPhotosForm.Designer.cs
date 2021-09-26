namespace A21_Ex03
{
    public partial class MostPopularPhotosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostPopularPhotosForm));
            this.panelMostPopularPictures = new System.Windows.Forms.Panel();
            this.buttonMostPopularPhotos = new System.Windows.Forms.Button();
            this.textBoxNextTime = new System.Windows.Forms.TextBox();
            this.checkBoxPhotosFromAllTime = new System.Windows.Forms.CheckBox();
            this.checkBoxPhotosFromThisYear = new System.Windows.Forms.CheckBox();
            this.panelThirdPhotoAndLikes = new A21_Ex03_Omri_313586190_Vardi_206010951.PanelPhotoAndLikes();
            this.panelSecondPhotoAndLikes = new A21_Ex03_Omri_313586190_Vardi_206010951.PanelPhotoAndLikes();
            this.panelFirstPhotoAndLikes = new A21_Ex03_Omri_313586190_Vardi_206010951.PanelPhotoAndLikes();
            this.panelMostPopularPictures.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMostPopularPictures
            // 
            this.panelMostPopularPictures.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMostPopularPictures.BackgroundImage")));
            this.panelMostPopularPictures.Controls.Add(this.panelThirdPhotoAndLikes);
            this.panelMostPopularPictures.Controls.Add(this.buttonMostPopularPhotos);
            this.panelMostPopularPictures.Controls.Add(this.panelSecondPhotoAndLikes);
            this.panelMostPopularPictures.Controls.Add(this.panelFirstPhotoAndLikes);
            this.panelMostPopularPictures.Location = new System.Drawing.Point(12, 42);
            this.panelMostPopularPictures.Name = "panelMostPopularPictures";
            this.panelMostPopularPictures.Size = new System.Drawing.Size(266, 623);
            this.panelMostPopularPictures.TabIndex = 83;
            // 
            // buttonMostPopularPhotos
            // 
            this.buttonMostPopularPhotos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMostPopularPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonMostPopularPhotos.Location = new System.Drawing.Point(24, 2);
            this.buttonMostPopularPhotos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMostPopularPhotos.Name = "buttonMostPopularPhotos";
            this.buttonMostPopularPhotos.Size = new System.Drawing.Size(219, 54);
            this.buttonMostPopularPhotos.TabIndex = 65;
            this.buttonMostPopularPhotos.Text = "Click and Get your most popular photos :)";
            this.buttonMostPopularPhotos.UseVisualStyleBackColor = true;
            this.buttonMostPopularPhotos.Click += new System.EventHandler(this.buttonMostPopularPhotos_Click);
            // 
            // textBoxNextTime
            // 
            this.textBoxNextTime.Location = new System.Drawing.Point(12, 673);
            this.textBoxNextTime.Name = "textBoxNextTime";
            this.textBoxNextTime.ReadOnly = true;
            this.textBoxNextTime.Size = new System.Drawing.Size(266, 22);
            this.textBoxNextTime.TabIndex = 85;
            this.textBoxNextTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBoxPhotosFromAllTime
            // 
            this.checkBoxPhotosFromAllTime.AutoSize = true;
            this.checkBoxPhotosFromAllTime.Location = new System.Drawing.Point(56, 12);
            this.checkBoxPhotosFromAllTime.Name = "checkBoxPhotosFromAllTime";
            this.checkBoxPhotosFromAllTime.Size = new System.Drawing.Size(80, 21);
            this.checkBoxPhotosFromAllTime.TabIndex = 86;
            this.checkBoxPhotosFromAllTime.Text = "All Time";
            this.checkBoxPhotosFromAllTime.UseVisualStyleBackColor = true;
            this.checkBoxPhotosFromAllTime.CheckedChanged += new System.EventHandler(this.checkBoxPhotosFromAllTime_CheckedChanged);
            // 
            // checkBoxPhotosFromThisYear
            // 
            this.checkBoxPhotosFromThisYear.AutoSize = true;
            this.checkBoxPhotosFromThisYear.Location = new System.Drawing.Point(162, 12);
            this.checkBoxPhotosFromThisYear.Name = "checkBoxPhotosFromThisYear";
            this.checkBoxPhotosFromThisYear.Size = new System.Drawing.Size(91, 21);
            this.checkBoxPhotosFromThisYear.TabIndex = 87;
            this.checkBoxPhotosFromThisYear.Text = "This Year";
            this.checkBoxPhotosFromThisYear.UseVisualStyleBackColor = true;
            this.checkBoxPhotosFromThisYear.CheckedChanged += new System.EventHandler(this.checkBoxPhotosFromThisYear_CheckedChanged);
            // 
            // panelThirdPhotoAndLikes
            // 
            this.panelThirdPhotoAndLikes.Location = new System.Drawing.Point(56, 434);
            this.panelThirdPhotoAndLikes.Name = "panelThirdPhotoAndLikes";
            this.panelThirdPhotoAndLikes.Size = new System.Drawing.Size(160, 186);
            this.panelThirdPhotoAndLikes.TabIndex = 88;
            // 
            // panelSecondPhotoAndLikes
            // 
            this.panelSecondPhotoAndLikes.Location = new System.Drawing.Point(56, 246);
            this.panelSecondPhotoAndLikes.Name = "panelSecondPhotoAndLikes";
            this.panelSecondPhotoAndLikes.Size = new System.Drawing.Size(160, 186);
            this.panelSecondPhotoAndLikes.TabIndex = 87;
            // 
            // panelFirstPhotoAndLikes
            // 
            this.panelFirstPhotoAndLikes.Location = new System.Drawing.Point(56, 57);
            this.panelFirstPhotoAndLikes.Name = "panelFirstPhotoAndLikes";
            this.panelFirstPhotoAndLikes.Size = new System.Drawing.Size(160, 186);
            this.panelFirstPhotoAndLikes.TabIndex = 86;
            // 
            // MostPopularPhotosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 703);
            this.Controls.Add(this.checkBoxPhotosFromThisYear);
            this.Controls.Add(this.checkBoxPhotosFromAllTime);
            this.Controls.Add(this.textBoxNextTime);
            this.Controls.Add(this.panelMostPopularPictures);
            this.Name = "MostPopularPhotosForm";
            this.Text = "FormPopularPhotos";
            this.Load += new System.EventHandler(this.formMostPopularPhotos_Load);
            this.panelMostPopularPictures.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMostPopularPictures;
        private System.Windows.Forms.Button buttonMostPopularPhotos;
        private System.Windows.Forms.TextBox textBoxNextTime;
        private PanelPhotoAndLikes panelFirstPhotoAndLikes;
        private PanelPhotoAndLikes panelSecondPhotoAndLikes;
        private PanelPhotoAndLikes panelThirdPhotoAndLikes;
        private System.Windows.Forms.CheckBox checkBoxPhotosFromAllTime;
        private System.Windows.Forms.CheckBox checkBoxPhotosFromThisYear;
    }
}