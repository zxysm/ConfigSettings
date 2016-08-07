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
    }
}
