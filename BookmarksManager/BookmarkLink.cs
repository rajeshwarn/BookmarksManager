﻿#region

using System;
using System.Collections.Generic;

#endregion

namespace BookmarksManager
{
    public class BookmarkLink : IBookmarkItem
    {
        public string Title { get; set; }
        public string Url { get; set; }

        /// <summary>
        ///     favicon URL
        /// </summary>
        public string IconUrl { get; set; }

        /// <summary>
        ///     favicon content if it's embeded icon
        /// </summary>
        public byte[] IconData { get; set; }

        /// <summary>
        ///     favicon content type if it's embeded icon
        /// </summary>
        public string IconContentType { get; set; }


        public DateTime? LastVisit { get; set; }
        public DateTime? LastModified { get; set; }
        public DateTime? Added { get; set; }
        public string Description { get; set; }

        public IDictionary<string, string> Attributes = new Dictionary<string, string>();

        public BookmarkLink(string url = null, string title = null)
        {
            Url = url;
            Title = title;
        }

        public BookmarkLink(Uri url, string title = null)
        {
            if (url == null)
                throw new ArgumentNullException("url");
            Url = url.AbsoluteUri;
            Title = title;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", Title, Url);
        }
    }
}