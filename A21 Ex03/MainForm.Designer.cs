using System.Windows.Forms;

namespace A21_Ex03
{
    public partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.listBoxUserAlbums = new System.Windows.Forms.ListBox();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.labelBirthdayDate = new System.Windows.Forms.Label();
            this.textBoxBirthday = new System.Windows.Forms.TextBox();
            this.buttonFetchAlbums = new System.Windows.Forms.Button();
            this.textBoxAlbumDescription = new System.Windows.Forms.TextBox();
            this.buttonFetchPosts = new System.Windows.Forms.Button();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.buttonFetchFriends = new System.Windows.Forms.Button();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.labelAlbumDescription = new System.Windows.Forms.Label();
            this.buttonRandomPicture = new System.Windows.Forms.Button();
            this.pictureBoxRandomPicture = new System.Windows.Forms.PictureBox();
            this.textBoxPhotoDate = new System.Windows.Forms.TextBox();
            this.buttonMostPopularPhotosFeature = new System.Windows.Forms.Button();
            this.labelPhotoDate = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.panelphotoAndName = new System.Windows.Forms.Panel();
            this.panelFetch = new System.Windows.Forms.Panel();
            this.buttonSortByName = new System.Windows.Forms.Button();
            this.buttonSortByTime = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxComments = new System.Windows.Forms.ListBox();
            this.labelCommentsPosts = new System.Windows.Forms.Label();
            this.panelRandomMemory = new System.Windows.Forms.Panel();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRandomPicture)).BeginInit();
            this.panelUserInfo.SuspendLayout();
            this.panelphotoAndName.SuspendLayout();
            this.panelFetch.SuspendLayout();
            this.panelRandomMemory.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogin.Image")));
            this.buttonLogin.Location = new System.Drawing.Point(12, 11);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(382, 60);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Clicked);
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(54, 48);
            this.pictureBoxProfilePicture.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(177, 160);
            this.pictureBoxProfilePicture.TabIndex = 3;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // listBoxUserAlbums
            // 
            this.listBoxUserAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxUserAlbums.DisplayMember = "name";
            this.listBoxUserAlbums.FormattingEnabled = true;
            this.listBoxUserAlbums.ItemHeight = 16;
            this.listBoxUserAlbums.Location = new System.Drawing.Point(265, 68);
            this.listBoxUserAlbums.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxUserAlbums.Name = "listBoxUserAlbums";
            this.listBoxUserAlbums.Size = new System.Drawing.Size(180, 260);
            this.listBoxUserAlbums.TabIndex = 52;
            this.listBoxUserAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxUserAlbums_SelectedIndexChanged);
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFullName.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFullName.Location = new System.Drawing.Point(28, 16);
            this.textBoxFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.ReadOnly = true;
            this.textBoxFullName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxFullName.Size = new System.Drawing.Size(177, 28);
            this.textBoxFullName.TabIndex = 40;
            this.textBoxFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelBirthdayDate
            // 
            this.labelBirthdayDate.AutoSize = true;
            this.labelBirthdayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelBirthdayDate.Location = new System.Drawing.Point(2, 10);
            this.labelBirthdayDate.Name = "labelBirthdayDate";
            this.labelBirthdayDate.Size = new System.Drawing.Size(73, 17);
            this.labelBirthdayDate.TabIndex = 45;
            this.labelBirthdayDate.Text = "Birthday:";
            // 
            // textBoxBirthday
            // 
            this.textBoxBirthday.Location = new System.Drawing.Point(82, 10);
            this.textBoxBirthday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBirthday.Name = "textBoxBirthday";
            this.textBoxBirthday.ReadOnly = true;
            this.textBoxBirthday.Size = new System.Drawing.Size(164, 22);
            this.textBoxBirthday.TabIndex = 46;
            // 
            // buttonFetchAlbums
            // 
            this.buttonFetchAlbums.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFetchAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFetchAlbums.Location = new System.Drawing.Point(280, 27);
            this.buttonFetchAlbums.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFetchAlbums.Name = "buttonFetchAlbums";
            this.buttonFetchAlbums.Size = new System.Drawing.Size(150, 34);
            this.buttonFetchAlbums.TabIndex = 53;
            this.buttonFetchAlbums.Text = "Fetch Albums";
            this.buttonFetchAlbums.UseVisualStyleBackColor = true;
            this.buttonFetchAlbums.Click += new System.EventHandler(this.getAlbumsButton_Clicked);
            // 
            // textBoxAlbumDescription
            // 
            this.textBoxAlbumDescription.Location = new System.Drawing.Point(177, 408);
            this.textBoxAlbumDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAlbumDescription.Multiline = true;
            this.textBoxAlbumDescription.Name = "textBoxAlbumDescription";
            this.textBoxAlbumDescription.Size = new System.Drawing.Size(471, 22);
            this.textBoxAlbumDescription.TabIndex = 54;
            this.textBoxAlbumDescription.Leave += new System.EventHandler(this.textBoxAlbumDescription_Leave);
            // 
            // buttonFetchPosts
            // 
            this.buttonFetchPosts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFetchPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFetchPosts.Location = new System.Drawing.Point(65, 27);
            this.buttonFetchPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFetchPosts.Name = "buttonFetchPosts";
            this.buttonFetchPosts.Size = new System.Drawing.Size(150, 34);
            this.buttonFetchPosts.TabIndex = 56;
            this.buttonFetchPosts.Text = "Fetch Posts";
            this.buttonFetchPosts.UseVisualStyleBackColor = true;
            this.buttonFetchPosts.Click += new System.EventHandler(this.getPostsButton_Clicked);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPosts.DisplayMember = "name";
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.HorizontalScrollbar = true;
            this.listBoxPosts.ItemHeight = 16;
            this.listBoxPosts.Location = new System.Drawing.Point(50, 68);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(180, 260);
            this.listBoxPosts.TabIndex = 57;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // buttonFetchFriends
            // 
            this.buttonFetchFriends.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFetchFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFetchFriends.Location = new System.Drawing.Point(496, 27);
            this.buttonFetchFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFetchFriends.Name = "buttonFetchFriends";
            this.buttonFetchFriends.Size = new System.Drawing.Size(150, 34);
            this.buttonFetchFriends.TabIndex = 58;
            this.buttonFetchFriends.Text = "Fetch Friends";
            this.buttonFetchFriends.UseVisualStyleBackColor = true;
            this.buttonFetchFriends.Click += new System.EventHandler(this.getFriendsButton_Clicked);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFriends.DisplayMember = "name";
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(480, 68);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(180, 260);
            this.listBoxFriends.TabIndex = 59;
            // 
            // labelAlbumDescription
            // 
            this.labelAlbumDescription.AutoSize = true;
            this.labelAlbumDescription.Location = new System.Drawing.Point(48, 408);
            this.labelAlbumDescription.Name = "labelAlbumDescription";
            this.labelAlbumDescription.Size = new System.Drawing.Size(123, 17);
            this.labelAlbumDescription.TabIndex = 61;
            this.labelAlbumDescription.Text = "album description:";
            // 
            // buttonRandomPicture
            // 
            this.buttonRandomPicture.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRandomPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRandomPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonRandomPicture.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonRandomPicture.Location = new System.Drawing.Point(20, 7);
            this.buttonRandomPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRandomPicture.Name = "buttonRandomPicture";
            this.buttonRandomPicture.Size = new System.Drawing.Size(170, 58);
            this.buttonRandomPicture.TabIndex = 1;
            this.buttonRandomPicture.Text = "Click and Get a sweet memory";
            this.buttonRandomPicture.UseVisualStyleBackColor = false;
            this.buttonRandomPicture.Click += new System.EventHandler(this.getRandomPictureButton_Clicked);
            // 
            // pictureBoxRandomPicture
            // 
            this.pictureBoxRandomPicture.Location = new System.Drawing.Point(20, 99);
            this.pictureBoxRandomPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxRandomPicture.Name = "pictureBoxRandomPicture";
            this.pictureBoxRandomPicture.Size = new System.Drawing.Size(162, 147);
            this.pictureBoxRandomPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRandomPicture.TabIndex = 0;
            this.pictureBoxRandomPicture.TabStop = false;
            // 
            // textBoxPhotoDate
            // 
            this.textBoxPhotoDate.Location = new System.Drawing.Point(99, 70);
            this.textBoxPhotoDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPhotoDate.Name = "textBoxPhotoDate";
            this.textBoxPhotoDate.ReadOnly = true;
            this.textBoxPhotoDate.Size = new System.Drawing.Size(83, 22);
            this.textBoxPhotoDate.TabIndex = 63;
            // 
            // buttonMostPopularPhotosFeature
            // 
            this.buttonMostPopularPhotosFeature.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMostPopularPhotosFeature.BackgroundImage")));
            this.buttonMostPopularPhotosFeature.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMostPopularPhotosFeature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonMostPopularPhotosFeature.Location = new System.Drawing.Point(252, 180);
            this.buttonMostPopularPhotosFeature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMostPopularPhotosFeature.Name = "buttonMostPopularPhotosFeature";
            this.buttonMostPopularPhotosFeature.Size = new System.Drawing.Size(258, 81);
            this.buttonMostPopularPhotosFeature.TabIndex = 65;
            this.buttonMostPopularPhotosFeature.Text = "Your popular photos";
            this.buttonMostPopularPhotosFeature.UseVisualStyleBackColor = false;
            this.buttonMostPopularPhotosFeature.Click += new System.EventHandler(this.getButtonMostPopularPhotos_Clicked);
            // 
            // labelPhotoDate
            // 
            this.labelPhotoDate.AutoSize = true;
            this.labelPhotoDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPhotoDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPhotoDate.Location = new System.Drawing.Point(46, 73);
            this.labelPhotoDate.Name = "labelPhotoDate";
            this.labelPhotoDate.Size = new System.Drawing.Size(47, 17);
            this.labelPhotoDate.TabIndex = 67;
            this.labelPhotoDate.Text = "Date:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(82, 35);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(164, 22);
            this.textBoxEmail.TabIndex = 68;
            this.textBoxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmail_Validating);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelEmail.Location = new System.Drawing.Point(2, 38);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(52, 17);
            this.labelEmail.TabIndex = 69;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxGender
            // 
            this.textBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxGender.Location = new System.Drawing.Point(82, 62);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.ReadOnly = true;
            this.textBoxGender.Size = new System.Drawing.Size(164, 22);
            this.textBoxGender.TabIndex = 70;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGender.Location = new System.Drawing.Point(2, 66);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(67, 17);
            this.labelGender.TabIndex = 71;
            this.labelGender.Text = "Gender:";
            this.labelGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelUserInfo.Controls.Add(this.textBoxBirthday);
            this.panelUserInfo.Controls.Add(this.labelGender);
            this.panelUserInfo.Controls.Add(this.labelBirthdayDate);
            this.panelUserInfo.Controls.Add(this.textBoxGender);
            this.panelUserInfo.Controls.Add(this.textBoxEmail);
            this.panelUserInfo.Controls.Add(this.labelEmail);
            this.panelUserInfo.Location = new System.Drawing.Point(253, 80);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Size = new System.Drawing.Size(258, 95);
            this.panelUserInfo.TabIndex = 72;
            // 
            // panelphotoAndName
            // 
            this.panelphotoAndName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelphotoAndName.Controls.Add(this.textBoxFullName);
            this.panelphotoAndName.Controls.Add(this.pictureBoxProfilePicture);
            this.panelphotoAndName.Location = new System.Drawing.Point(15, 80);
            this.panelphotoAndName.Name = "panelphotoAndName";
            this.panelphotoAndName.Size = new System.Drawing.Size(231, 181);
            this.panelphotoAndName.TabIndex = 73;
            // 
            // panelFetch
            // 
            this.panelFetch.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelFetch.Controls.Add(this.buttonSortByName);
            this.panelFetch.Controls.Add(this.buttonSortByTime);
            this.panelFetch.Controls.Add(this.label2);
            this.panelFetch.Controls.Add(this.label1);
            this.panelFetch.Controls.Add(this.listBoxComments);
            this.panelFetch.Controls.Add(this.labelCommentsPosts);
            this.panelFetch.Controls.Add(this.buttonFetchAlbums);
            this.panelFetch.Controls.Add(this.listBoxUserAlbums);
            this.panelFetch.Controls.Add(this.textBoxAlbumDescription);
            this.panelFetch.Controls.Add(this.buttonFetchPosts);
            this.panelFetch.Controls.Add(this.listBoxPosts);
            this.panelFetch.Controls.Add(this.buttonFetchFriends);
            this.panelFetch.Controls.Add(this.labelAlbumDescription);
            this.panelFetch.Controls.Add(this.listBoxFriends);
            this.panelFetch.Location = new System.Drawing.Point(12, 267);
            this.panelFetch.Name = "panelFetch";
            this.panelFetch.Size = new System.Drawing.Size(716, 589);
            this.panelFetch.TabIndex = 74;
            // 
            // buttonSortByName
            // 
            this.buttonSortByName.Location = new System.Drawing.Point(303, 366);
            this.buttonSortByName.Name = "buttonSortByName";
            this.buttonSortByName.Size = new System.Drawing.Size(106, 30);
            this.buttonSortByName.TabIndex = 67;
            this.buttonSortByName.Text = "Sort by name";
            this.buttonSortByName.UseVisualStyleBackColor = true;
            this.buttonSortByName.Click += new System.EventHandler(this.buttonSortByName_Click);
            // 
            // buttonSortByTime
            // 
            this.buttonSortByTime.Location = new System.Drawing.Point(303, 335);
            this.buttonSortByTime.Name = "buttonSortByTime";
            this.buttonSortByTime.Size = new System.Drawing.Size(106, 30);
            this.buttonSortByTime.TabIndex = 66;
            this.buttonSortByTime.Text = "Sort by time";
            this.buttonSortByTime.UseVisualStyleBackColor = true;
            this.buttonSortByTime.Click += new System.EventHandler(this.buttonSortByTime_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 64;
            // 
            // listBoxComments
            // 
            this.listBoxComments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxComments.DisplayMember = "name";
            this.listBoxComments.FormattingEnabled = true;
            this.listBoxComments.ItemHeight = 16;
            this.listBoxComments.Location = new System.Drawing.Point(177, 446);
            this.listBoxComments.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxComments.Name = "listBoxComments";
            this.listBoxComments.Size = new System.Drawing.Size(471, 132);
            this.listBoxComments.TabIndex = 63;
            // 
            // labelCommentsPosts
            // 
            this.labelCommentsPosts.AutoSize = true;
            this.labelCommentsPosts.Location = new System.Drawing.Point(48, 446);
            this.labelCommentsPosts.Name = "labelCommentsPosts";
            this.labelCommentsPosts.Size = new System.Drawing.Size(76, 17);
            this.labelCommentsPosts.TabIndex = 62;
            this.labelCommentsPosts.Text = "comments:";
            // 
            // panelRandomMemory
            // 
            this.panelRandomMemory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelRandomMemory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelRandomMemory.BackgroundImage")));
            this.panelRandomMemory.Controls.Add(this.buttonRandomPicture);
            this.panelRandomMemory.Controls.Add(this.pictureBoxRandomPicture);
            this.panelRandomMemory.Controls.Add(this.textBoxPhotoDate);
            this.panelRandomMemory.Controls.Add(this.labelPhotoDate);
            this.panelRandomMemory.Location = new System.Drawing.Point(517, 6);
            this.panelRandomMemory.Name = "panelRandomMemory";
            this.panelRandomMemory.Size = new System.Drawing.Size(211, 255);
            this.panelRandomMemory.TabIndex = 75;
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(395, 34);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(118, 21);
            this.checkBoxRememberMe.TabIndex = 76;
            this.checkBoxRememberMe.Text = "RememberMe";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 868);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.panelRandomMemory);
            this.Controls.Add(this.panelFetch);
            this.Controls.Add(this.buttonMostPopularPhotosFeature);
            this.Controls.Add(this.panelphotoAndName);
            this.Controls.Add(this.panelUserInfo);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Desktop Facebook";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRandomPicture)).EndInit();
            this.panelUserInfo.ResumeLayout(false);
            this.panelUserInfo.PerformLayout();
            this.panelphotoAndName.ResumeLayout(false);
            this.panelphotoAndName.PerformLayout();
            this.panelFetch.ResumeLayout(false);
            this.panelFetch.PerformLayout();
            this.panelRandomMemory.ResumeLayout(false);
            this.panelRandomMemory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.ListBox listBoxUserAlbums;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label labelBirthdayDate;
        private System.Windows.Forms.TextBox textBoxBirthday;
        private Button buttonFetchAlbums;
        private TextBox textBoxAlbumDescription;
        private Button buttonFetchPosts;
        private ListBox listBoxPosts;
        private Button buttonFetchFriends;
        private ListBox listBoxFriends;
        private Label labelAlbumDescription;
        private Button buttonRandomPicture;
        private PictureBox pictureBoxRandomPicture;
        private TextBox textBoxPhotoDate;
        private Button buttonMostPopularPhotosFeature;
        private Label labelPhotoDate;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private TextBox textBoxGender;
        private Label labelGender;
        private Panel panelUserInfo;
        private Panel panelphotoAndName;
        private Panel panelFetch;
        private Panel panelRandomMemory;
        private ListBox listBoxComments;
        private Label labelCommentsPosts;
        private CheckBox checkBoxRememberMe;
        private Label label1;
        private Label label2;
        private Button buttonSortByName;
        private Button buttonSortByTime;
    }
}
