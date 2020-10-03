using System.Drawing;
using FacebookWrapper.ObjectModel;
using FaceBookAppLogic;

namespace FaceBookAppLogic
{
    public class LocationStrategy : IAddFriendStrategy
    {
        public string Gender { get; set; }

        public string Country { get; set; }

        public bool ShouldAdd(User i_Friend)
        {
            string friendGender = i_Friend.Gender.ToString().ToLower();
            return i_Friend.Location.Name == Country && (Gender == friendGender || friendGender == "both");
        }
    }
}