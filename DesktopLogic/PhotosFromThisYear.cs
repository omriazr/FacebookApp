using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using static FacebookWrapper.ObjectModel.Album;

namespace DesktopLogic
{
    public class PhotosFromThisYear : ICommand
    {
        public IEnumerable<Album> Execute()
        {
            IEnumerable<Album> thisYearAlbums = Logic.Instance.GetUserAlbums().Where(f => f.CreatedTime.ToString().Contains("2021"));
            return thisYearAlbums;
        }
    }
}
