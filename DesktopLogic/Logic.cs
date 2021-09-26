using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace DesktopLogic
{
    public class Logic : IFacade
    {
        private static Logic s_Instance;
        private static object s_NewInstanceLock = new object();

        internal IGet m_GetInfo { get; set; }

        private Logic()
        {
            m_GetInfo = GetInfo.Instanse;
            m_GetInfo.Login();
        }

        public static Logic Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_NewInstanceLock)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new Logic();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public void Login()
        {
            m_GetInfo.Login();
        }

        public string GetFullName()
        {
            return m_GetInfo.GetFullName();
        }

        public string GetBirthdayDate()
        {
            return m_GetInfo.GetBirthdayDate();
        }

        public string GetEmail()
        {
            return m_GetInfo.GetEmail();
        }

        public string GetGender()
        {
            return m_GetInfo.GetGender();
        }

        public string GetUsersProfileUrl()
        {
            return m_GetInfo.GetUsersProfileUrl();
        }

        public string GetPhotoUrl(Photo i_RandomPhoto)
        {
            return m_GetInfo.GetPhotoUrl(i_RandomPhoto);
        }

        public string GetPhotoDate(Photo i_PhotoUrl)
        {
            return m_GetInfo.GetPhotoDate(i_PhotoUrl);
        }

        public Photo GetRandomUserPhoto()
        {
            return m_GetInfo.GetRandomUserPhoto();
        }

        public IList<Post> GetUserPosts()
        {
            return m_GetInfo.GetUserPosts();
        }

        public IList<Album> GetUserAlbums()
        {
            return m_GetInfo.GetUserAlbums();
        }

        public IList<User> GetUserFriends()
        {
            return m_GetInfo.GetUserFriends();
        }

        public IList<string> FindMostPopularPhotos(IEnumerable<Album> i_UserAlbums)
        {
            return m_GetInfo.FindMostPopularPhotos(i_UserAlbums);
        }

        public LoginResult GetLoginResult()
        {
            return m_GetInfo.GetLoginResult();
        }
    }
}
