﻿using System.Collections.Generic;
using System.Linq;
using Dit.Umb.MKulturProzent.Classics.Models.Pages;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace Dit.Umb.ToolBox.Models.PageModels
{
    public class BlogPage : ArticlePage
    {
        public IEnumerable<ContentPage> BlogEntries => Content.Children<IPublishedContent>()
            .Select(c => new ContentPage(c));

        public BlogPage(IPublishedContent content) : base(content)
        {
        }
    }
}
