using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace DesktopLogic
{
    public class SearchPhotosIterator
    {
        private IEnumerable<Album> m_UserAlbums;

        public SearchPhotosIterator(IEnumerable<Album> i_UserAlbums)
        {
            this.m_UserAlbums = i_UserAlbums;
        }

        public IEnumerator<Photo> GetEnumerator()
        {
            foreach (Album album in this.m_UserAlbums)
            {
                foreach (Photo photo in album.Photos)
                {
                    yield return photo;
                }
            }
        }
    }
}
