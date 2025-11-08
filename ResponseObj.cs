using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("isProfane")]
        public bool IsProfane { get; set; }

        [JsonProperty("filteredText")]
        public string FilteredText { get; set; }

        [JsonProperty("mask")]
        public string Mask { get; set; }

        [JsonProperty("trimmed")]
        public bool Trimmed { get; set; }

        [JsonProperty("profaneWords")]
        public int ProfaneWords { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
