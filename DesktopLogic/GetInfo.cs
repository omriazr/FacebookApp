using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace DesktopLogic
{
    internal class GetInfo : IGet
    {
        public static GetInfo Instanse
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_NewInstanceLock)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new GetInfo();
                        }
                    }
                }

                return s_Instance;
            }
        }

        private static GetInfo s_Instance;
        public User m_LoggedInUser;

        public LoginResult m_LoginResult { get; set; }

        private IList<Album> m_UserAlbums;
        private IList<User> m_UserFriends;
        private static object s_NewInstanceLock = new object();

        private GetInfo()
        {
        }

        public void Login()
        {
            loginAndInit();
        }

        private void loginAndInit()
        {
            m_LoginResult = FacebookService.Login(
            "136569274538355",
            "public_profile",
            "email",
            "user_birthday",
            "user_age_range",
            "user_gender",
            "user_link",
            "user_tagged_places",
            "user_videos",
            "user_friends",
            "user_events",
            "user_likes",
            "user_location",
            "user_photos",
            "user_posts",
            "user_hometown");

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
            }
            else
            {
                throw new Exception("Login Error!");
            }
        }

        public string GetFullName()
        {
            return m_LoggedInUser.Name;
        }

        public string GetBirthdayDate()
        {
            return m_LoggedInUser.Birthday;
        }

        public string GetEmail()
        {
            return m_LoggedInUser.Email;
        }

        public string GetGender()
        {
            return m_LoggedInUser.Gender.ToString();
        }

        public string GetUsersProfileUrl()
        {
            return m_LoggedInUser.PictureNormalURL;
        }

        public IList<Post> GetUserPosts()
        {
            IList<Post> posts = m_LoggedInUser.Posts;
            if (posts.Count > 0)
            {
                return posts;
            }
            else
            {
                throw new Exception("No posts to show");
            }
        }

        public IList<Album> UserAlbums
        {
            get
            {
                if (m_UserAlbums == null)
                {
                    m_UserAlbums = GetUserAlbums();
                }

                return m_UserAlbums;
            }
        }

        public IList<Album> GetUserAlbums()
        {
            IList<Album> albums = m_LoggedInUser.Albums;
            if (albums.Count > 0)
            {
                return albums;
            }
            else
            {
                throw new Exception("No albums to show");
            }
        }

        public IList<User> GetUserFriends()
        {
            m_UserFriends = m_LoggedInUser.Friends;
            if (m_UserFriends.Count != 0)
            {
                return m_UserFriends;
            }
            else
            {
                throw new Exception("No Friends to show");
            }
        }

        public Photo GetRandomUserPhoto()
        {
            return GetRandom(m_LoggedInUser.PhotosTaggedIn);
        }

        public string GetPhotoUrl(Photo i_RandomPhoto)
        {
            return i_RandomPhoto.PictureNormalURL;
        }

        public string GetPhotoDate(Photo i_PhotoUrl)
        {
            return i_PhotoUrl.CreatedTime.Value.Date.ToString();
        }

        public IList<string> FindMostPopularPhotos(IEnumerable<Album> i_UserAlbums)
        {
            List<string> UrlPhotosAndLikes = new List<string>();
            int firstNumberOfMostLikes = 0;
            int secondNumberOfMostLikes = 0;
            int thirdNumberOfMostLikes = 0;
            string urlFirstPhoto = string.Empty;
            string urlSecondPhoto = string.Empty;
            string urlThirdPhoto = string.Empty;
            SearchPhotosIterator photosIterator = new SearchPhotosIterator(i_UserAlbums);
            var userPhotos = photosIterator.GetEnumerator();

            if (userPhotos == null)
            {
                throw new Exception($"User didn't upload any photo");
            }
            else
            {
                    while (userPhotos.MoveNext())
                    {
                    Photo currentPhoto = userPhotos.Current;
                        if (currentPhoto.LikedBy.Count > firstNumberOfMostLikes)
                        {
                            firstNumberOfMostLikes = currentPhoto.LikedBy.Count;
                            urlFirstPhoto = GetPhotoUrl(currentPhoto);
                        }
                        else if (currentPhoto.LikedBy.Count >= firstNumberOfMostLikes)
                        {
                            secondNumberOfMostLikes = currentPhoto.LikedBy.Count;
                            urlSecondPhoto = GetPhotoUrl(currentPhoto);
                        }
                        else if (currentPhoto.LikedBy.Count >= thirdNumberOfMostLikes)
                        {
                            thirdNumberOfMostLikes = currentPhoto.LikedBy.Count;
                            urlThirdPhoto = GetPhotoUrl(currentPhoto);
                        }
                    }
                
                UrlPhotosAndLikes.Add(urlFirstPhoto);
                UrlPhotosAndLikes.Add(urlSecondPhoto);
                UrlPhotosAndLikes.Add(urlThirdPhoto);
                UrlPhotosAndLikes.Add(firstNumberOfMostLikes.ToString());
                UrlPhotosAndLikes.Add(secondNumberOfMostLikes.ToString());
                UrlPhotosAndLikes.Add(thirdNumberOfMostLikes.ToString());
            }

            return UrlPhotosAndLikes;
        }

        public T GetRandom<T>(FacebookObjectCollection<T> i_FacebookColleciton)
        {
            Random randomItem = new Random();
            if (i_FacebookColleciton.Count <= 0)
            {
                throw new Exception($"no items");
            }

            return i_FacebookColleciton[randomItem.Next(i_FacebookColleciton.Count - 1)];
        }

        public LoginResult GetLoginResult()
        {
            return m_LoginResult;
        }
    }
}
