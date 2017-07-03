using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WhatTheHell.Models
{
    public class DataResponse
    {
        public DataResponse()
        {
        }

        /// <summary>
        /// Id for item
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Id for item
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        /// <summary>
        /// Id for item
        /// </summary>
        [JsonProperty(PropertyName = "sortBy")]
        public string SortBy { get; set; }

        /// <summary>
        /// Id for item
        /// </summary>
        [JsonProperty(PropertyName = "articles")]
        public List<Item> Articles { get; set; }
    }
}
