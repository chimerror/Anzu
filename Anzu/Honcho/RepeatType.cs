using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honcho
{
    internal enum RepeatType
    {
        Indefinitely,
        UntilSpecificTime,
        UntilCertainDuration,
        Once,
        CertainNumberOfTimes,
    }

    internal static class RepeatTypeExtensions
    {
        public static string GetFriendlyName(this RepeatType repeatType)
        {
            switch (repeatType)
            {
                case RepeatType.Indefinitely:
                    return Properties.Resources.RepeatAmountIndefinitelyText;

                case RepeatType.UntilSpecificTime:
                    return Properties.Resources.RepeatAmountUntilSpecificTimeText;

                case RepeatType.UntilCertainDuration:
                    return Properties.Resources.RepeatAmountUntilCertainDurationText;

                case RepeatType.Once:
                    return Properties.Resources.RepeatAmountOnceText;

                case RepeatType.CertainNumberOfTimes:
                    return Properties.Resources.RepeatAmountCertainNumberOfTimesText;

                default:
                    Debug.Fail(String.Format("Received unknown starting type: {0}", repeatType.ToString()));
                    return repeatType.ToString();
            }
        }
    }
}
