using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ConfigSettings
{
    class Auth
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public enum Authentication
        {
            google,
            ptc
        }
        public Authentication AuthType { get; set; }
        public string GoogleUsername { get; set; }
        public string GooglePassword { get; set; }
        public string PtcUsername { get; set; }
        public string PtcPassword { get; set; }
        public bool UseProxy { get; set; }
        public string UseProxyHost { get; set; }
        public string UseProxyPort { get; set; }
        public bool UseProxyAuthentication { get; set; }
        public string UseProxyUsername { get; set; }
        public string UseProxyPassword { get; set; }
        public string DeviceId { get; set; }
        public string AndroidBoardName { get; set; }
        public string AndroidBootloader { get; set; }
        public string DeviceBrand { get; set; }
        public string DeviceModel { get; set; }
        public string DeviceModelIdentifier { get; set; }
        public string DeviceModelBoot { get; set; }
        public string HardwareManufacturer { get; set; }
        public string HardwareModel { get; set; }
        public string FirmwareBrand { get; set; }
        public string FirmwareTags { get; set; }
        public string FirmwareType { get; set; }
        public string FirmwareFingerprint { get; set; }
    }
}
