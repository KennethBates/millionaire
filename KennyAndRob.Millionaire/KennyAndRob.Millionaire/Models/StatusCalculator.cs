using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KennyAndRob.Millionaire.Models
{
    public class StatusCalculator
    {
        public static string HowRichAmI(int netWorth)
        {
            var status = "You are poor";

            if (netWorth > 10000000)
            {
                status = "You are crazy rich!!!";
            }
            else if (netWorth > 1000000)
            {
                status = "You are filthy rich!";
            }

            return status;
        }
    }
}