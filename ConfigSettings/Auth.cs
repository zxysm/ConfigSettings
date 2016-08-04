﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigSettings
{
    class Auth
    {
        public enum Authentication
        {
            google,
            ptc
        }
        public Authentication AuthType { get; set; }
        public string GoogleUserName { get; set; }
        public string GooglePassword { get; set; }
        public string PtcPassword { get; set; }
        public string PtcUsername { get; set; }
    }
}
