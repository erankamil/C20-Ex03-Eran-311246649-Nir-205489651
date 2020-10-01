using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FaceBookAppLogic
{
    public static class DislikeLogic
    {
        internal static void DeleteLikesFromPhotos(User i_LoggedInUser, User i_DisLikedFriend)
        {
            try
            {
                foreach (Album album in i_DisLikedFriend.Albums)
                {
                    foreach (Photo photo in album.Photos)
                    {
                        foreach (User Liker in photo.LikedBy)
                        {
                            if (Liker.Id == i_LoggedInUser.Id)
                            {
                                photo.Unlike();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AppManager.Instance.MethodToCatchExeptionsFromFacebookThatWeCantAvoid(ex);
            }
        }

        public static void DeleteLikesFromPosts(User i_LoggedInUser, User i_DisLikedFriend)
        {
            try
            {
                foreach (Post post in i_DisLikedFriend.Posts)
                {
                    foreach (User Liker in post.LikedBy)
                    {
                        if (Liker.Id == i_LoggedInUser.Id)
                        {
                            post.Unlike();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AppManager.Instance.MethodToCatchExeptionsFromFacebookThatWeCantAvoid(ex);
            }
        }

        public static void DeleteCommentsFromPhotos(User i_LoggedInUser, User i_DisLikedFriend)
        {
            try
            {
                foreach (Album album in i_DisLikedFriend.Albums)
                {
                    foreach (Photo photo in album.Photos)
                    {
                        foreach (Comment comment in photo.Comments)
                        {
                            if (comment.From.Id == i_LoggedInUser.Id)
                            {
                                photo.Comments.Remove(comment);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AppManager.Instance.MethodToCatchExeptionsFromFacebookThatWeCantAvoid(ex);
            }
        }

        public static void DeleteCommentsFromPosts(User i_LoggedInUser, User i_DisLikedFriend)
        {
            try
            {
                foreach (Post post in i_DisLikedFriend.Posts)
                {
                    foreach (Comment comment in post.Comments)
                    {
                        if (comment.From.Id == i_LoggedInUser.Id)
                        {
                            post.Comments.Remove(comment);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AppManager.Instance.MethodToCatchExeptionsFromFacebookThatWeCantAvoid(ex);
            }
        }

        public static void DeleteTagsFromCommonPhotos(User i_LoggedInUser, User i_DisLikedFriend)
        {
            try
            {
                foreach (Album album in i_DisLikedFriend.Albums)
                {
                    foreach (Photo photo in album.Photos)
                    {
                        foreach (PhotoTag tag in photo.Tags)
                        {
                            if (tag.User.Id == i_LoggedInUser.Id)
                            {
                                photo.Tags.Remove(tag);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AppManager.Instance.MethodToCatchExeptionsFromFacebookThatWeCantAvoid(ex);
            }
        }

        public static void DeleteTagsFromCommonPosts(User i_LoggedInUser, User i_DisLikedFriend)
        {
            try
            {
                foreach (Post post in i_DisLikedFriend.Posts)
                {
                    foreach (User user in post.TaggedUsers)
                    {
                        if (user.Id == i_LoggedInUser.Id)
                        {
                            post.TaggedUsers.Remove(user);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AppManager.Instance.MethodToCatchExeptionsFromFacebookThatWeCantAvoid(ex);
            }
        }
    }
}
