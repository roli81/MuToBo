﻿using System.Collections.Generic;
using Dit.Umb.ToolBox.Models.Interfaces;
using Dit.Umb.ToolBox.Models.PoCo;
using Umbraco.Core.Models.PublishedContent;

namespace Dit.Umb.ToolBox.Models.PageModels
{
    public class SearchResultModel : BasePage, ISearchResultsModel
    {
        public string Term { get; set; }
        public string Page { get; set; }
        public IEnumerable<SearchResult> Results { get; set; }


        public SearchResultModel(IPublishedContent content) : base(content)
        {
        }
    }
}
