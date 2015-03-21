using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honcho
{
    [Serializable]
    public class AnzuTaskData
    {
        [Obsolete("Only to be used by serializers")]
        public Version AnuzVersion { get; set; }

        public String FriendlyName { get; set; }

    }
}
