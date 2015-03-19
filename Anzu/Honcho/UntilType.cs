using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honcho
{
    internal enum UntilType
    {
        Idefinitely,
        SpecificTime,
        SpecificDuration,
    }

    internal static class UntilTypeExtensions
    {
        public static string GetFriendlyName(this UntilType untilType)
        {
            switch (untilType)
            {
                case UntilType.Idefinitely:
                    return Properties.Resources.BreakUntilIndefinitelyText;

                case UntilType.SpecificTime:
                    return Properties.Resources.BreakUntilSpecificTimeText;

                case UntilType.SpecificDuration:
                    return Properties.Resources.BreakUntilSpecificDurationText;

                default:
                    Debug.Fail(String.Format("Received unknown schedule until type: {0}", untilType.ToString()));
                    return untilType.ToString();
            }
        }
    }
}
