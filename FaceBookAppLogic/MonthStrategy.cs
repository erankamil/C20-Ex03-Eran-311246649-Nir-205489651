using FacebookWrapper.ObjectModel;
using FaceBookAppLogic;
using System;

namespace FaceBookAppLogic
{
    class MonthStrategy : IAddFriendStrategy
    {
        public string Gender { get; set; }

        public DateTime Birthdate { get; set; }

        public bool ShouldAdd(User i_Friend)
        {
            string friendGender = i_Friend.Gender.ToString().ToLower();
            DateAdapter dateAdapter = new DateAdapter();
            DateTime friendBirthdate = dateAdapter.DateParse(i_Friend.Birthday);
            return friendBirthdate.Month == Birthdate.Month && (Gender == friendGender || friendGender == "both");
        }
    }
}
