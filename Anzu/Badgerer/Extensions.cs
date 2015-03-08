using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badgerer
{
    public static class Extensions
    {
        public static TimeSpan TrimMilliseconds(this TimeSpan input)
        {
            return TimeSpan.FromSeconds((long)input.TotalSeconds);
        }
    }
}
