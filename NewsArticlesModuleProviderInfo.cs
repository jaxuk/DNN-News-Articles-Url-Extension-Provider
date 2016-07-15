//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using DotNetNuke.Entities.Urls;
//using DNN.Modules.NewsArticles.ModuleFriendlyUrlProvider.Entities;

//namespace DNN.Modules.NewsArticles.ModuleFriendlyUrlProvider
//{
//    internal class NewsArticlesModuleProviderInfo : ExtensionUrlProviderInfo
//    {
//        internal string _ignoreRedirectRegex;
//        //internal int _noDnnPagePathTabId = -1; //- used to specify if the  module is on a page where the page path should not be included in the url.
//        //internal string _urlPath;//- specifies the url path to use for a NewsArticles Url
//        //internal bool _redirectUrls; //- whether or not to redirect old-style Urls to the new ones
//        //internal int _startingArticleId; //- article Id to start changes from
//        //internal string _articleUrlStyle;
//        //internal string _articleUrlSource;
//        //internal string _pageUrlStyle;
//        //internal string _authorUrlStyle;
//        //internal string _categoryUrlStyle;
//        //internal bool _isDebug;
//        //internal bool _isValid;
//        ////private Dictionary<int, TabUrlOptions> _tabUrlOptions;
//        //internal int NoDnnPagePathTabId
//        //{
//        //    get { return _noDnnPagePathTabId; }
//        //    set { _noDnnPagePathTabId = value; }
//        //}

//        //internal string UrlPath
//        //{
//        //    get { return _urlPath; }
//        //    set { _urlPath = value; }
//        //}

//        //internal int StartingArticleId
//        //{
//        //    get
//        //    {
//        //        return _startingArticleId;
//        //    }
//        //    set
//        //    {
//        //        _startingArticleId = value;
//        //    }
//        //}
//        //internal new string EnsureLeadingChar(string p, string path)
//        //{
//        //    return base.EnsureLeadingChar(p, path);
//        //}

//        //internal TabUrlOptions GetTabUrlOptions(int tabId)
//        //{
//        //    TabUrlOptions result = null;
//        //    if (_tabUrlOptions != null)
//        //        if (_tabUrlOptions.ContainsKey(tabId))
//        //            result = _tabUrlOptions[tabId];
//        //        else
//        //            if (tabId == -1 && _noDnnPagePathTabId > 0)
//        //        {
//        //            if (_tabUrlOptions.ContainsKey(_noDnnPagePathTabId))
//        //                result = _tabUrlOptions[_noDnnPagePathTabId];
//        //            else
//        //                if (_tabUrlOptions.ContainsKey(-1))
//        //                result = _tabUrlOptions[-1];
//        //        }
//        //        else
//        //                //929 : default option if no tab Id specified settings
//        //                if (_tabUrlOptions.ContainsKey(-1))
//        //            result = _tabUrlOptions[-1];
//        //    return result;
//        //}
//        //internal string ArticleUrlStyle { set { _articleUrlStyle = value; } }
//        //internal string ArticleUrlSource { set { _articleUrlSource = value; } }
//        //internal string PageUrlStyle { set { _pageUrlStyle = value; } }
//        //internal string AuthorUrlStyle { set { _authorUrlStyle = value; } }
//        //internal string CategoryUrlStyle { set { _categoryUrlStyle = value; } }
//        //internal bool RedirectUrls { get { return _redirectUrls; } set { _redirectUrls = value; } }
//        ////private Dictionary<int, TabUrlOptions> _tabUrlOptions;
//        //internal NewsArticlesModuleProviderInfo()
//        //{
//        //    if (this.Settings != null && this.Settings.ContainsKey("ignoreRedirectRegex"))
//        //        _ignoreRedirectRegex = this.Settings["ignoreRedirectRegex"];
//        //    if (_urlPath != null && _urlPath != "")
//        //        Settings.Add("urlPath", _urlPath);
//        //    else
//        //        Settings.Add("urlPath", null);//remove the null values

//        //    if (_noDnnPagePathTabId > 0)
//        //        Settings.Add("noDnnPagePathTabId", _noDnnPagePathTabId.ToString());
//        //    else
//        //        Settings.Add("noDnnPagePathTabId", null);

//        //    Settings.Add("redirectUrls", _redirectUrls.ToString());
//        //    Settings.Add("startingArticleId", _startingArticleId.ToString());
//        //    Settings.Add("articleUrlStyle", _articleUrlStyle);
//        //    Settings.Add("articleUrlSource", _articleUrlSource);
//        //    Settings.Add("pageUrlStyle", _pageUrlStyle);
//        //    Settings.Add("authorUrlStyle", _authorUrlStyle);
//        //    Settings.Add("categoryUrlStyle", _categoryUrlStyle);
//        //    //return settings;
//        //}
//    }
//}
