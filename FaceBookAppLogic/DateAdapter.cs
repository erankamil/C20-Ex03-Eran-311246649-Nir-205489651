using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FaceBookAppLogic
{
    public interface IDate
    {
        DateTime DateParse(string i_StringDate);
    }

    public class DateAdapter : IDate
    {
        public DateAdapter()
        {
            FBbirthdate = new FBbirthdate();
        }

        public FBbirthdate FBbirthdate { get; set; }

        public DateTime DateParse(string i_StringDate)
        {
            StringBuilder dayStr, monthStr, yearStr;
            dayStr = new StringBuilder();
            monthStr = new StringBuilder();
            yearStr = new StringBuilder();
            DateTime date;

            if (i_StringDate.Length >= 10)
            {
                int size = i_StringDate.Length - 1, yearIndexes = 3, monthIndexes = 1, dayIndexes = size - 6;
                for (int i = size - yearIndexes; i <= size; i++)
                {
                    dayStr.Append(i_StringDate[i]);
                }

                for (int i = 0; i <= monthIndexes; i++)
                {
                    monthStr.Append(i_StringDate[i]);
                }

                for (int i = dayIndexes; i <= dayIndexes + 1; i++)
                {
                    yearStr.Append(i_StringDate[i]);
                }

                date = FBbirthdate.ParseDate(int.Parse(yearStr.ToString()), int.Parse(monthStr.ToString()), int.Parse(dayStr.ToString()));
            }
            else
            {
                date = DateTime.Now;
            }

            return date;
        }
    }
}
