using System;

namespace WhatTheHell
{
    public class Item : BaseDataObject
    {
        public Item() : base()
        {
        }

        /// <summary>
        /// Private backing field to hold the text
        /// </summary>
        string text = string.Empty;

        /// <summary>
        /// Public property to set and get the text of the item
        /// </summary>
        public string Title
        {
            get { return text; }
            set { SetProperty(ref text, value); }
        }

        string description = string.Empty;
        public string Description
        {
            get { return description; }
            set { SetProperty(ref description, value); }
        }

        /// <summary>
        /// urlToImage
        /// </summary>
        public string UrlToImage { get; set; }

        /// <summary>
        /// urlToImage
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Author
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Author
        /// </summary>
        public DateTimeOffset PublishedAt { get; set; }

    }
}
