﻿using Newtonsoft.Json;

namespace Utility.Models
{
    public class Team
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("alternate_name")]
        public object? AlternateName { get; set; }

        [JsonProperty("fifa_code")]
        public string? FifaCode { get; set; }

        [JsonProperty("group_id")]
        public long GroupId { get; set; }

        [JsonProperty("group_letter")]
        public string? GroupLetter { get; set; }

        [JsonProperty("code")]
        public string? Code { get; set; }

        [JsonProperty("goals")]
        public long Goals { get; set; }

        [JsonProperty("penalties")]
        public long Penalties { get; set; }
        
        public override string ToString()
            => $"{Country} ({FifaCode})";
    }
}