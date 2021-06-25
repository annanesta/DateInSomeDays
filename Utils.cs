using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateInSomeDays
{
    static class Utils
    {
        static public string GetNameOfTheMonth(int n)
        {
            string month ="";
            switch (n)
            {
                case 1:
                    month = "January";
                    break;
                case 2:
                    month = "Fabruary";
                    break;
                case 3:
                    month = "March";
                    break;
                case 4:
                    month = "April";
                    break;
                case 5:
                    month = "May";
                    break;
                case 6:
                    month = "June";
                    break;
                case 7:
                    month = "July";
                    break;
                case 8:
                    month = "August";
                    break;
                case 9:
                    month = "September";
                    break;
                case 10:
                    month = "October";
                    break;
                case 11:
                    month = "November";
                    break;
                case 12:
                    month = "December";
                    break;
            }
            return month;
        }
        static public bool IsAny (Stack<StoryStruct> items)
        {
            if (items.Count > 0)
                return true;
            else
                return false;
        }

    }
}
