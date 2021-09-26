using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace DesktopLogic
{
    public interface IFacade
    {
        void Login();

        string GetFullName();

        string GetBirthdayDate();

        string GetEmail();

        string GetGender();

        string GetUsersProfileUrl();

        string GetPhotoUrl(Photo i_RandomPhoto);

        string GetPhotoDate(Photo i_PhotoUrl);

        Photo GetRandomUserPhoto();

        IList<Post> GetUserPosts();

        IList<Album> GetUserAlbums();

        IList<User> GetUserFriends();

        IList<string> FindMostPopularPhotos(IEnumerable<Album> i_UserAlbums);

        LoginResult GetLoginResult();
    }
}
