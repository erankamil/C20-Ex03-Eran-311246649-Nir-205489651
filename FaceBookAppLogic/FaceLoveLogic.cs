using System.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FaceBookAppLogic
{
    public static class FaceLoveLogic
    {
        public static IAddFriendStrategy AddFriendStrategy { get; set; }

        public static List<User> GetOptionalFriendsForDating(string i_Gender, string i_AgeRange, User i_LoggedInUser)
        {
            List<User> optionalFriends = new List<User>();
            try
            {
                foreach (User Currentfriend in i_LoggedInUser.Friends)
                {
                    if(AddFriendStrategy.ShouldAdd(Currentfriend) == true)
                    {
                        optionalFriends.Add(Currentfriend);
                    }
                }
            }
            catch (Exception ex)
            {
                AppManager.Instance.MethodToCatchExeptionsFromFacebookThatWeCantAvoid(ex);
            }

            return optionalFriends;
        }

        public static Point GetAgeRange(string i_AgeRange)
        {
            StringBuilder LowestBound = new StringBuilder();
            StringBuilder HighestBound = new StringBuilder();
            int indexLow = 0, indexHigh = 0, plusIndex = 2, lowBountIndexes = 1, higheBoundIndexes = 5;
            foreach (char currentChar in i_AgeRange)
            {
                if (indexLow <= lowBountIndexes)
                {
                    LowestBound.Append(currentChar);
                }
                else if (indexLow == plusIndex && currentChar == '+')
                {
                    HighestBound.Append("120");
                }
                else if (indexLow >= higheBoundIndexes)
                {
                    HighestBound.Append(currentChar);
                    indexHigh++;
                }

                indexLow++;
            }

            return new Point(int.Parse(LowestBound.ToString()), int.Parse(HighestBound.ToString()));
        }
    }
}

public enum eGender
{
    Male = 1,
    Female = 2,
    Both = 3
}