using System.Drawing;
using FacebookWrapper.ObjectModel;
using FaceBookAppLogic;

namespace FaceBookAppLogic
{
    public interface IAddFriendStrategy
    {
        bool ShouldAdd(User i_Friend);
    }

    public class AgeStrategy : IAddFriendStrategy
    {
        public Point AgeRange { get; set; }

        public string Gender { get; set; }

        public bool ShouldAdd(User i_Friend)
        {
            int friendAge = AppManager.Instance.GetFriendAge(i_Friend.Birthday);
            string friendGender = i_Friend.Gender.ToString().ToLower();
            return (friendAge >= AgeRange.X && friendAge <= AgeRange.Y) && (friendGender == Gender || Gender == "both");
        }
    }
}
