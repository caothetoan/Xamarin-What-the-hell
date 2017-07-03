using System;
using Newtonsoft.Json;

namespace WhatTheHell.Models
{
    public class Article
    {
        public Article()
        {
        }

        /// <summary>
        /// Id for item
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Description for item
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// urlToImage
        /// </summary>
        [JsonProperty(PropertyName = "urlToImage")]
        public string UrlToImage { get; set; }

        /// <summary>
        /// urlToImage
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
    }
}
