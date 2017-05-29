using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP.Api.Models.ModelAll
{
    public class GeneralFunction
    {
        public static DateTime ConvertToTime(string time)
        {
            string[] timesplit = time.Split('/');
            return new DateTime(Convert.ToInt32(timesplit[2]), Convert.ToInt32(timesplit[1]), Convert.ToInt32(timesplit[0]));
        }

        public static String DateTimeToString(DateTime date)
        {
            return date.Day.ToString() + "/" + date.Month.ToString() + "/" + date.Year.ToString();
        }
    }
}