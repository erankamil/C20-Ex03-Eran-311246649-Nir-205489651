using System.Reflection;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Threading;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FaceBookAppLogic
{
    public static class Singleton<T> where T : class
    {
        private static T s_Instance;

        private static object s_LockObj = new object();

        static Singleton()
        {
        }

        public static T Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_LockObj)
                    {
                        if (s_Instance == null)
                        {
                            Type typeOfT = typeof(T);
                            try
                            {
                                ConstructorInfo constructor = typeof(T).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[0], null);
                                s_Instance = constructor.Invoke(null) as T;
                            }
                            catch (Exception exception)
                            {
                                throw new Exception(null, exception);
                            }
                        }
                    }
                }

                return s_Instance;
            }
        }
    }

    public sealed class AppManager
    {
        public static AppManager Instance { get { return Singleton<AppManager>.Instance; } }

        private const string k_AppID = "2134287490048880";

        public LoginResult LoginResult { get; private set; }

        private AppManager()
        {
        }

        public User LoggedInUser
        {
            get { return LoginResult.LoggedInUser; }
        }

        public void Login()
        {
            LoginResult = FacebookWrapper.FacebookService.Login(
                                                          k_AppID,
                                                         "user_posts",
                                                        "user_friends",
                                                        "user_events",
                                                        "user_likes",
                                                        "user_tagged_places",
                                                        "public_profile",
                                                        "email",
                                                        "publish_to_groups",
                                                        "user_birthday",
                                                        "user_age_range",
                                                        "user_gender",
                                                        "user_link",
                                                        "user_videos",
                                                        "groups_access_member_info",
                                                        "user_location",
                                                        "user_photos",
                                                        "user_hometown",
                                                        "publish_to_groups",
                                                        "pages_read_engagement",
                                                        "pages_manage_posts");

            if (LoginResult == null)
            {
                throw new Exception("Login Faliled");
            }
        }

        public void Logout()
        {
            FacebookWrapper.FacebookService.Logout(null);
        }

        public void MethodToCatchExeptionsFromFacebookThatWeCantAvoid(Exception i_Ex)
        {
            return;
        }

        public void DislikeFeatureRemoveFrom(List<string> i_removableArr, List<string> i_fromArr, User i_dislikedFriend)
        {
            User loggedinUser = AppManager.Instance.LoginResult.LoggedInUser;
            foreach (string removableItem in i_removableArr)
            {
                foreach (string fromItem in i_fromArr)
                {
                    if (removableItem == "Likes")
                    {
                        if (fromItem == "Photos")
                        {
                            DislikeLogic.DeleteLikesFromPhotos(loggedinUser, i_dislikedFriend);
                        }

                        if (fromItem == "Posts")
                        {
                            DislikeLogic.DeleteLikesFromPosts(loggedinUser, i_dislikedFriend);
                        }
                    }

                    if (removableItem == "Comments")
                    {
                        if (fromItem == "Photos")
                        {
                            DislikeLogic.DeleteCommentsFromPhotos(loggedinUser, i_dislikedFriend);
                        }

                        if (fromItem == "Posts")
                        {
                            DislikeLogic.DeleteCommentsFromPosts(loggedinUser, i_dislikedFriend);
                        }
                    }

                    if (removableItem == "Tags")
                    {
                        if (fromItem == "Photos")
                        {
                            DislikeLogic.DeleteTagsFromCommonPhotos(loggedinUser, i_dislikedFriend);
                        }

                        if (fromItem == "Posts")
                        {
                            DislikeLogic.DeleteTagsFromCommonPosts(loggedinUser, i_dislikedFriend);
                        }
                    }
                }
            }
        }

        public List<User> GetOptionalFriendsForDating(string i_Gender, string i_AgeRange)
        {
            return FaceLoveLogic.GetOptionalFriendsForDating(i_Gender, i_AgeRange, LoggedInUser);
        }

        public void SendMessageToFriend(User i_FriendToSend)
        {
            // sending message to i_FriendToSend throw facebook API
        }

        public string[] GetGenderTypes()
        {
            return Enum.GetNames(typeof(eGender));
        }
        public int GetFriendAge(string i_FriendBirthdateStr)
        {
            DateAdapter dateAdapter = new DateAdapter();
            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            DateTime friendBirthdateNumeric = dateAdapter.DateParse(i_FriendBirthdateStr);

            return (now - int.Parse(friendBirthdateNumeric.ToString("yyyyMMdd"))) / 10000;
        }

        public bool CheckValidGender(ref string i_SelectedGender)
        {
            bool isValid = true;
            if (!Enum.TryParse(i_SelectedGender, out eGender res))
            {
                isValid = false;
                throw new FormatException("invalid gender type");
            }

            return isValid;
        }
    }
}