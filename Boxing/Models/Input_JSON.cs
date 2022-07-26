﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Boxing.Models
{
    class Input_JSON
    {
        [Newtonsoft.Json.JsonProperty("cargo_space")]
        public Cargo_Space Cargo_space { get; set; }
        [Newtonsoft.Json.JsonProperty("cargo_groups")]
        public Cargo_Groups[] Cargo_groups { get; set; }
    }

    public class Cargo_Space
    {
        [Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; }
        [Newtonsoft.Json.JsonProperty("mass")]
        public int Mass { get; set; }
        [Newtonsoft.Json.JsonProperty("size")]
        public float[] Size { get; set; }

    }

    public class Cargo_Groups
    {
        [Newtonsoft.Json.JsonProperty("id")]
        public string Id { get; set; }
        [Newtonsoft.Json.JsonProperty("mass")]
        public int Mass { get; set; }
        [Newtonsoft.Json.JsonProperty("size")]
        public float[] Size { get; set; }
        [Newtonsoft.Json.JsonProperty("sort")]
        public int Sort { get; set; }
        [Newtonsoft.Json.JsonProperty("count")]
        public int Count { get; set; }
        [Newtonsoft.Json.JsonProperty("group_id")]
        public string Group_id { get; set; }

     
    }

}
