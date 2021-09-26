using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using DesktopLogic;

namespace A21_Ex03
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            m_DesktopFacebook = Logic.Instance;
        }

        internal Logic m_DesktopFacebook;
        internal ISort m_Sorter;
        internal LoginResult m_LoginResult;

        private void buttonLogin_Clicked(object sender, EventArgs e)
        {
            try
            {
                m_DesktopFacebook.Login();
                new Thread(fetchLoggedInUserInfo).Start();
                m_LoginResult = m_DesktopFacebook.GetLoginResult();
                setRememberUser(m_LoginResult.AccessToken);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void setRememberUser(string i_AccessToken)
        {
            if (i_AccessToken != null && checkBoxRememberMe.Checked)
            {
                AppSettings.Instance.IfRememberUser = true;
                AppSettings.Instance.LastAccessToken = i_AccessToken;
            }
        }
        
        private void fetchLoggedInUserInfo()
        {
            string profilePictureUrl;
            textBoxFullName.Invoke(new Action(() =>
                    textBoxFullName.Text = m_DesktopFacebook.GetFullName()));
            textBoxEmail.Invoke(new Action(() =>
                    textBoxEmail.Text = m_DesktopFacebook.GetEmail()));
            textBoxBirthday.Invoke(new Action(() =>
                    textBoxBirthday.Text = m_DesktopFacebook.GetBirthdayDate()));
            textBoxGender.Invoke(new Action(() =>
                    textBoxGender.Text = m_DesktopFacebook.GetGender()));
            profilePictureUrl = m_DesktopFacebook.GetUsersProfileUrl();
            pictureBoxProfilePicture.LoadAsync(profilePictureUrl);
        }

        private void fetchUserPosts()
        {
            listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Clear()));   
            listBoxPosts.Invoke(new Action(() => listBoxPosts.DisplayMember = "Message"));
            try
            {
                IList<Post> posts = m_DesktopFacebook.GetUserPosts();
                foreach (Post post in posts)
                {
                    if (post.Message != null)
                    {
                        listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Message)));
                    }
                }
            }
            catch (Exception ex)
            {
            MessageBox.Show(ex.Message);
            } 
        }

        private void getPostsButton_Clicked(object sender, EventArgs e)
        {
            new Thread(fetchUserPosts).Start();
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxComments.DisplayMember = "Message";
            Post selectedPost = m_DesktopFacebook.GetUserPosts()[listBoxPosts.SelectedIndex];
            listBoxComments.DataSource = selectedPost.Comments;
        }

        private void fetchUserAlbums()
        {
            listBoxUserAlbums.Invoke(new Action(() => listBoxUserAlbums.Items.Clear()));
            listBoxUserAlbums.Invoke(new Action(() => listBoxUserAlbums.DisplayMember = "Name"));
            foreach (Album album in m_DesktopFacebook.GetUserAlbums())
            {
                listBoxUserAlbums.Invoke(new Action(() => listBoxUserAlbums.Items.Add(album)));
            }

            if (listBoxUserAlbums.Items.Count == 0)
            {
                MessageBox.Show("No Albums to retrieve :(");
            }
        }

        private void getAlbumsButton_Clicked(object sender, EventArgs e)
        {
            new Thread(fetchUserAlbums).Start();
        }

        private void listBoxUserAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxAlbumDescription.Invoke(new Action(() =>
            {
                Album selectedUserAlbum = m_DesktopFacebook.GetUserAlbums()[listBoxUserAlbums.SelectedIndex];
                if (string.IsNullOrEmpty(selectedUserAlbum.Description))
                {
                    textBoxAlbumDescription.Text = "No Description";
                }
                else
                {
                    textBoxAlbumDescription.Text = selectedUserAlbum.Description;
                }
            }));
        }

        private void fetchUserFriends()
        {
            listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Clear()));
            listBoxFriends.Invoke(new Action(() => listBoxFriends.DisplayMember = "Name"));
            try
            {
            IList<User> friends = m_DesktopFacebook.GetUserFriends();
                foreach (User user in friends)
                {
                    listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add(user.Name)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getFriendsButton_Clicked(object sender, EventArgs e)
        {
            new Thread(fetchUserFriends).Start();
        }

        private void getRandomPictureButton_Clicked(object sender, EventArgs e)
        {
           if (m_LoginResult != null)
           {
                new Thread(fetchUserRandomPhoto).Start();
           }
        }

        private void fetchUserRandomPhoto()
        {
            Photo randomPhoto = new Photo();
            try
            {
                pictureBoxRandomPicture.Invoke(new Action(() => randomPhoto = m_DesktopFacebook.GetRandomUserPhoto()));
                string randomPhotoUrl = m_DesktopFacebook.GetPhotoUrl(randomPhoto);
                string randomPhotoDate = m_DesktopFacebook.GetPhotoDate(randomPhoto);
                pictureBoxRandomPicture.LoadAsync(randomPhotoUrl);
                textBoxPhotoDate.Invoke(new Action(() => textBoxPhotoDate.Text = randomPhotoDate));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getButtonMostPopularPhotos_Clicked(object sender, EventArgs e)
        {
            if (m_LoginResult != null)
            {
                MostPopularPhotosForm mostPopularPhotosForm = new MostPopularPhotosForm(m_DesktopFacebook);
                mostPopularPhotosForm.Show();
            }
        }

        private void textBoxAlbumDescription_Leave(object sender, EventArgs e)
        {
            //(listBoxUserAlbums.SelectedItem as Album).Description = textBoxAlbumDescription.Text;
        }

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!textBoxEmail.Text.Contains("@") || !textBoxEmail.Text.Contains("."))
            {
                e.Cancel = true;
            }
        }

        private void buttonSortByTime_Click(object sender, EventArgs e)
        {
            m_Sorter = new SortByTime();
            sortUserAlbums();
        }

        private void buttonSortByName_Click(object sender, EventArgs e)
        {
            m_Sorter = new SortByName();
            sortUserAlbums();
        }

        private void sortUserAlbums()
        {
            IEnumerable<Album> userAlbums = m_DesktopFacebook.GetUserAlbums();
            IList<Album> sortAlbums = m_Sorter.Sort(userAlbums).ToList();
            listBoxUserAlbums.Items.Clear();
            foreach (Album album in sortAlbums)
            {
                listBoxUserAlbums.Items.Add(album);
            }
        }
    }
}
