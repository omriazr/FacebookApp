using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace DesktopLogic
{
    public class SortByName : ISort
    {
        public IEnumerable<Album> Sort(IEnumerable<Album> i_UserAlbums)
        {
            return i_UserAlbums.OrderBy(album => album.Name);
        }
    }
}
