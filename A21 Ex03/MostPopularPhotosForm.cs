using System;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DesktopLogic;
using FacebookWrapper.ObjectModel;

namespace A21_Ex03
{
    public partial class MostPopularPhotosForm : Form
    {
        public MostPopularPhotosForm(Logic i_DesktopFacebookLogic)
        {
            m_DesktopFacebook = i_DesktopFacebookLogic;
            InitializeComponent();
        }

        private Logic m_DesktopFacebook;
        private ICommand m_PhotosByYearCommand;

        private void formMostPopularPhotos_Load(object sender, EventArgs e)
        {
        }

        private void buttonMostPopularPhotos_Click(object sender, EventArgs e)
        {
            if (checkBoxPhotosFromThisYear.Checked || checkBoxPhotosFromAllTime.Checked)
            {
                new Thread(mostPopularUserPhotos).Start();
            }
        }

        private void mostPopularUserPhotos()
        {
            IList<string> theMostLikedPhotos = null;
            try
            {
                if (checkBoxPhotosFromThisYear.Checked)
                {
                    m_PhotosByYearCommand = new PhotosFromThisYear();
                    IEnumerable<Album> photosFromThisYear = m_PhotosByYearCommand.Execute();
                    theMostLikedPhotos = m_DesktopFacebook.FindMostPopularPhotos(photosFromThisYear);
                }
               else
                {
                    m_PhotosByYearCommand = new PhotosFromAllTime();
                    IEnumerable<Album> photosFromAllTime = m_PhotosByYearCommand.Execute();
                    theMostLikedPhotos = m_DesktopFacebook.FindMostPopularPhotos(photosFromAllTime);
                }

                panelFirstPhotoAndLikes.PictureBoxPhoto.LoadAsync(theMostLikedPhotos[0]);
                panelSecondPhotoAndLikes.PictureBoxPhoto.LoadAsync(theMostLikedPhotos[1]);
                panelThirdPhotoAndLikes.PictureBoxPhoto.LoadAsync(theMostLikedPhotos[2]);
                panelFirstPhotoAndLikes.Invoke(new Action(() =>
                   panelFirstPhotoAndLikes.TextBoxNumberOfLikes.Text = theMostLikedPhotos[3]));
                panelSecondPhotoAndLikes.Invoke(new Action(() =>
                   panelSecondPhotoAndLikes.TextBoxNumberOfLikes.Text = theMostLikedPhotos[4]));
                panelThirdPhotoAndLikes.Invoke(new Action(() =>
                   panelThirdPhotoAndLikes.TextBoxNumberOfLikes.Text = theMostLikedPhotos[5]));
                textBoxNextTime.Invoke(new Action(() =>
                   textBoxNextTime.Text = "Next time try to get more likes"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBoxPhotosFromAllTime_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxPhotosFromThisYear.Enabled = checkBoxPhotosFromAllTime.Checked == false ? true : false;
        }

        private void checkBoxPhotosFromThisYear_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxPhotosFromAllTime.Enabled = checkBoxPhotosFromThisYear.Checked == false ? true : false;
        }
    }
}
