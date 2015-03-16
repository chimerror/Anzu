using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honcho
{
    internal enum StartingType
    {
        SpecificTime,
        AfterTheHour,
        Now,
    }

    internal static class StartingTypeExtensions
    {
        public static string GetFriendlyName(this StartingType startingType)
        {
            switch (startingType)
            {
                case StartingType.SpecificTime:
                    return Properties.Resources.StartingTimeSpecificTimeText;

                case StartingType.AfterTheHour:
                    return Properties.Resources.StartingTimeAfterTheHourText;
                
                case StartingType.Now:
                    return Properties.Resources.StartingTimeNowText;

                default:
                    Debug.Fail(String.Format("Received unknown starting type: {0}", startingType.ToString()));
                    return startingType.ToString();
            }
        }
    }
}
