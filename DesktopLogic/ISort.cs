using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace DesktopLogic
{
     public interface ISort
    {
        IEnumerable<Album> Sort(IEnumerable<Album> i_UserSortedAlbums);
    }
}
