﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MongoSharp.Protocol.SystemMessages.Responses
{
    public class BuildInfoResponse
    {
        public string Version { get; set; }
        public string GitVersion { get; set; }
        public string SysInfo { get; set; }
        public int? bits { get; set; }
        public double? OK { get; set; }
    }
}
