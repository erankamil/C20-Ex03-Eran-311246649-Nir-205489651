using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FaceBookAppLogic
{
    public class FBbirthdate
    {
        public DateTime ParseDate(int i_DayNumeric, int i_MonthNumeric, int i_YearNumeric)
        {
            return new DateTime(i_YearNumeric, i_MonthNumeric, i_DayNumeric);
        }
    }
}
