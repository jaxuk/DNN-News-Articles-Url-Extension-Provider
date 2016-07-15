using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DNN.Modules.NewsArticles.ModuleFriendlyUrlProvider.Entities
{
    internal class NewsArticleOptions
    {
        //('TitleReplacementType','SEOShorternID','SEOUrlMode','AlwaysShowPageID')
        internal string TitleReplacement;
        internal string SeoShortenId;
        internal string SeoUrlMode;
        internal bool AlwaysShowPageId;
    }
}
