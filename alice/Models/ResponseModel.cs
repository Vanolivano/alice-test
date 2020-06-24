﻿using Newtonsoft.Json;

namespace alice.Models
{
    public class ResponseModel
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("tts")]
        public string Tts { get; set; }

        [JsonProperty("end_session")]
        public bool EndSession { get; set; }

        [JsonProperty("buttons")]
        public ButtonModel[] Buttons { get; set; }
    }
}
