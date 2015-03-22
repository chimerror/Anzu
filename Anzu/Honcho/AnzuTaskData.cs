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

        [Obsolete("To only be used for serialization")]
        public Version AnzuVersion { get; set; }

        [Obsolete("To only be used for serialization")]
        public Guid AnzuGuid { get; set; }

        public String FriendlyName { get; set; }

        [Obsolete("To only be used for serialization")]
        [JsonConstructor]
        public AnzuTaskData()
        {
        }

        public AnzuTaskData(string friendlyName)
        {
#pragma warning disable 618
            AnzuVersion = AnzuTaskDataVersion;
            AnzuGuid = AnzuTaskDataGuid;
#pragma warning restore 618
            FriendlyName = friendlyName;
        }

        public string Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static AnzuTaskData Deserialize(string serializedData)
        {
            var newAnzuTaskData = JsonConvert.DeserializeObject<AnzuTaskData>(serializedData);

#pragma warning disable 618
            if (newAnzuTaskData.AnzuGuid != AnzuTaskDataGuid)
            {
                throw new JsonSerializationException("Data did not come from Anzu.");
            }
#pragma warning restore 618

            return newAnzuTaskData;
        }

        public static bool TryDeserialize(string serializedData, out AnzuTaskData newAnzuTaskData)
        {
            bool success = false;
            try
            {
                newAnzuTaskData = Deserialize(serializedData);
                success = true;
            }
            catch (JsonSerializationException)
            {
                newAnzuTaskData = null;
            }

            return success;
        }
    }
}
