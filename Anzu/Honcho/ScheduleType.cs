using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honcho
{
    internal enum ScheduleType
    {
        Daily,
        EveryNumberOfDays,
        OnCertainDaysOfTheWeek,
    }

    internal static class ScheduleTypeExtensions
    {
        public static string GetFriendlyName(this ScheduleType scheduleType)
        {
            switch (scheduleType)
            {
                case ScheduleType.Daily:
                    return Properties.Resources.BreakScheduleDailyText;

                case ScheduleType.EveryNumberOfDays:
                    return Properties.Resources.BreakScheduleEveryNumberOfDaysText;

                case ScheduleType.OnCertainDaysOfTheWeek:
                    return Properties.Resources.BreakScheduleOnCertainDaysOfTheWeekText;

                default:
                    Debug.Fail(String.Format("Received unknown schedule type: {0}", scheduleType.ToString()));
                    return scheduleType.ToString();
            }
        }
    }
}
