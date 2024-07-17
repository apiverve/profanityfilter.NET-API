using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("isProfane")]
    public bool isProfane { get; set; }

    [JsonProperty("filteredText")]
    public string filteredText { get; set; }

    [JsonProperty("mask")]
    public string mask { get; set; }

    [JsonProperty("trimmed")]
    public bool trimmed { get; set; }

    [JsonProperty("profaneWords")]
    public int profaneWords { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
