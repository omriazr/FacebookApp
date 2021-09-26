using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace A21_Ex03_Omri_313586190_Vardi_206010951
{
    public class PanelPhotoAndLikes : Panel
    {
        public PictureBox PictureBoxPhoto { get; set; }

        public Label LabelLikes { get; set; }

        public TextBox TextBoxNumberOfLikes { get; set; }

        public PanelPhotoAndLikes()
        {
            InitializePanelPhotoAndLikes();
        }

        private void InitializePanelPhotoAndLikes()
        {
            PictureBoxPhoto = new PictureBox();
            PictureBoxPhoto.Size = new Size(160, 155);
            PictureBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(PictureBoxPhoto);
            LabelLikes = new Label();
            Controls.Add(LabelLikes);
            TextBoxNumberOfLikes = new TextBox();
            Controls.Add(TextBoxNumberOfLikes);

            PictureBoxPhoto.Width = 160;
            PictureBoxPhoto.Height = 155;
            PictureBoxPhoto.Location = new Point(0, 0);

            LabelLikes.Width = 43;
            LabelLikes.Height = 17;
            LabelLikes.Text = "likes:";
            LabelLikes.Location = new Point(10, 162);

            TextBoxNumberOfLikes.Width = 82;
            TextBoxNumberOfLikes.Height = 22;
            TextBoxNumberOfLikes.Location = new Point(56, 160);
        }
    }
}
