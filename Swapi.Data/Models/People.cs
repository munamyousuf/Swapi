﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Swapi.Data.Models
{
    public class People
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("mass")]
        public int Mass { get; set; }

        [JsonProperty("hair_color")]
        public string HairColor { get; set; }

        [JsonProperty("skin_color")]
        public string SkinColor { get; set; }

        [JsonProperty("eye_color")]
        public string EyeColor { get; set; }

        [JsonProperty("birth_year")]
        public string BirthYear { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("homeworld")]
        public string Homeworld { get; set; }

        [JsonProperty("films")]
        public List<string> Films { get; set; }

        [JsonProperty("species")]
        public List<string> Species { get; set; }

        [JsonProperty("vehicles")]
        public List<string> Vehicles { get; set; }

        [JsonProperty("starships")]
        public List<string> Starships { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("edited")]
        public DateTime Edited { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
