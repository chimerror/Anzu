using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honcho
{
    internal enum BadgererWindowType
    {
        Overlay,
        Maximized,
        Unmaximized,
    }

    internal static class BadgererWindowTypeExtensions
    {
        public static string GetFriendlyName(this BadgererWindowType badgererWindowType)
        {
            switch (badgererWindowType)
            {
                case BadgererWindowType.Overlay:
                    return Properties.Resources.BadgererWindowOverlayText;

                case BadgererWindowType.Maximized:
                    return Properties.Resources.BadgererWindowMaximizedText;

                case BadgererWindowType.Unmaximized:
                    return Properties.Resources.BadgererWindowUnmaximizedText;

                default:
                    Debug.Fail(String.Format("Received unknown Badgerer window type: {0}", badgererWindowType.ToString()));
                    return badgererWindowType.ToString();
            }
        }
    }
}
