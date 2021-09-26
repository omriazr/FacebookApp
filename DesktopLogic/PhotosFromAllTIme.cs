using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace DesktopLogic
{
    public class PhotosFromAllTime : ICommand
    {
        public IEnumerable<Album> Execute()
        {
            IEnumerable<Album> allTimeAlbums = Logic.Instance.GetUserAlbums().Where(f => f.CreatedTime.ToString().Contains("20"));
            return allTimeAlbums;
        }
    }
}
