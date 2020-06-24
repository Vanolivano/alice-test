﻿using Newtonsoft.Json;

namespace alice.Models
{
    public class AliceResponse
    {
        [JsonProperty("response")]
        public ResponseModel Response { get; set; }

        [JsonProperty("session")]
        public SessionModel Session { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; } = "1.0";
    }
}
