using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Honcho
{
    [Serializable]
    public class AnzuTaskData
    {
        private readonly static Type AnzuTaskDataType = typeof(AnzuTaskData);
        private readonly static Version AnzuTaskDataVersion = Assembly.GetAssembly(AnzuTaskDataType).GetName().Version;
        private readonly static Guid AnzuTaskDataGuid = AnzuTaskDataType.GUID;

        public Version AnzuVersion { get; private set; }
        public Guid AnzuGuid { get; private set; }
        public String FriendlyName { get; set; }

        public AnzuTaskData(string friendlyName)
        {
            AnzuVersion = AnzuTaskDataVersion;
            AnzuGuid = AnzuTaskDataGuid;
            FriendlyName = friendlyName;
        }

        public string Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static AnzuTaskData Deserialize(string serializedData)
        {
            return JsonConvert.DeserializeObject<AnzuTaskData>(serializedData);
        }
    }
}
