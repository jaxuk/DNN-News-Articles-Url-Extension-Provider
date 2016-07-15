//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Text;
//using System.Web;
//using System.Linq;
//using System.Web.UI.WebControls;

//using DotNetNuke.Entities.Tabs;
//using DotNetNuke.Entities.Urls;
//using DNN.Modules.NewsArticles.ModuleFriendlyUrlProvider.Entities;
//using DotNetNuke.Entities.Modules;

//namespace DNN.Modules.NewsArticles.ModuleFriendlyUrlProvider
//{
//    /// <summary>
//    /// This is the code-behind for the Settings.ascx control.  This inherits from the standard .NET UserControl, but also implements the ModuleProvider specific IProviderSettings.
//    /// This control will be loaded by the Portal Urls page.  It is optional for module providers, but allows users to control module settings via the interface, rather than 
//    /// having to set options via web.config settings.  The writing / reading of the items from the configuration file is handled by the Url Master module, and doesn't need to 
//    /// be implemented.
//    /// </summary>
//    public partial class Settings : System.Web.UI.UserControl, IExtensionUrlProviderSettingsControl
//    {
//        private int _portalId;
//        private NewsArticlesModuleProvider _provider;
//        #region controls
//        protected Label lblHeader;
//        protected Label lblSettings;
//        protected TextBox txtStartingArticleId;
//        protected CheckBox chkRedirectOldUrls;
//        protected Repeater rptTabs;

//        protected Dictionary<string, string> _providerSettings;

//        protected string _articleUrlStyleText;
//        protected string _articleUrlSourceText;
//        protected string _categoryUrlStyleText;
//        protected string _pageUrlStyleText;
//        protected string _authorUrlStyleText;
//        protected string _noDnnPagePathText;
//        protected int _noDnnPagePathTabId;
//        protected string _needTabSpecifiedText;

//        #endregion
//        #region Web Form Designer Generated Code
//        //[System.Diagnostics.DebuggerStepThrough]
//        override protected void OnInit(EventArgs e)
//        {
//            InitializeComponent();
//            base.OnInit(e);
//        }

//        /// <summary>
//        ///		Required method for Designer support - do not modify
//        ///		the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.Load += new System.EventHandler(this.Page_Load);
//            if (_provider == null) {
//                //Find the provider and load it... Fucking DNN.
//                //_provider = (NewsArticlesModuleProviderInfo)ExtensionUrlProviderController.GetProviders(this.PortalId).Where(p => p.ExtensionUrlProviderId == Int16.Parse(Request.QueryString["ProviderId"])).SingleOrDefault();
//            }
//            rptTabs.ItemDataBound += new RepeaterItemEventHandler(rptTabs_ItemDataBound);
//        }

//        private void rptTabs_ItemDataBound(object sender, RepeaterItemEventArgs e)
//        {
//            TabToScreen(e.Item);
//        }

//        #endregion
//        #region events code
//        protected void Page_Load(object sender, EventArgs e)
//        {
//            try
//            {
//                //note page load runs after LoadSettings(); because of dynamic control loading

//                //now get the javascript in
//                //ScriptController.InjectjQueryLibary(this.Page, true, true);
//                //module-specific jquery code
//                //ScriptController.InjectJsLibrary(this.Page, "nap", this.ControlPath + "/js/nap.js", true, ScriptController.ScriptInjectOrder.e_Default);
//                //and get the css file in
//                //ScriptController.InjectCssReference(this.Page, "nap_css", this.ControlPath + "/newsarticlesprovider.css", true, ScriptController.CssInjectOrder.f_Last);
//                //and put in a pre-dnn 6 ui script plus the jquery tabs library
//                //string preDnn6CssFile = this.ControlPath + "/ui-tabs.css";
//                //ScriptController.InjectjQueryTabsCss(this.Page, preDnn6CssFile, null);
//            }
//            catch (Exception ex)
//            {
//                DotNetNuke.Services.Exceptions.Exceptions.ProcessModuleLoadException(this, ex);
//            }
//        }

//        protected void ddlSelTab_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }
//        private string GetResourceString(string LocalResourceFile, string key, string defaultIfEmpty) {
//            string ret = "";
//            ret = DotNetNuke.Services.Localization.Localization.GetString(key, LocalResourceFile);
//            if (String.IsNullOrEmpty(ret)) {
//                ret = defaultIfEmpty;
//            }
//            return ret;
//        }
//        #endregion
//        #region content methods
//        private void LocalizeControls()
//        {
//            try
//            {
//                lblHeader.Text = GetResourceString(LocalResourceFile, "Header.Text", "News Article Friendly Url Provider Settings");
//                _articleUrlSourceText = GetResourceString(LocalResourceFile, "ArticleUrlSource.Text", "Source of Article Url");
//                _articleUrlStyleText = GetResourceString(LocalResourceFile, "ArticleUrlStyle.Text", "Style of Article Url");
//                _categoryUrlStyleText = GetResourceString(LocalResourceFile, "CategoryUrlStyle.Text", "Style of Category Url");
//                _authorUrlStyleText = GetResourceString(LocalResourceFile, "AuthorUrlStyle.Text", "Style of Author Url");
//                _pageUrlStyleText = GetResourceString(LocalResourceFile, "PageUrlStyle.Text", "Style of Page Url");
//                _noDnnPagePathText = GetResourceString(LocalResourceFile, "NoDnnPagePath.Text", "Don't show Page name for Urls on this page");
//                _needTabSpecifiedText = GetResourceString(LocalResourceFile, "NeedTabSpecified.Text", "Cannot set 'No Path' value for All Tabs");
//            }
//            catch (Exception)
//            {

//                //suppress exception to let page load
//            }

//        }
//        #endregion
//        #region IProviderSettings Members
//        void IExtensionUrlProviderSettingsControl.LoadSettings()
//        {
//            LoadSettings();
//        }
//        //ExtensionUrlProviderInfo IExtensionUrlProviderSettingsControl.Provider
//        //{
//        //    get
//        //    {
//        //        return (ExtensionUrlProviderInfo)_provider;
//        //    }
//        //    set
//        //    {
//        //        if (value.GetType() == typeof(NewsArticlesModuleProviderInfo))
//        //        {
//        //            _provider = (NewsArticlesModuleProviderInfo)value;
//        //        }
//        //    }
//        //}
//        //ExtensionUrlProviderInfo IExtensionUrlProviderSettingsControl.Provider
//        //{
//        //    get
//        //    {
//        //        if (_provider == null) {
//        //            _provider = new NewsArticlesModuleProviderInfo();
//        //        }
//        //        return (NewsArticlesModuleProviderInfo)_provider;
//        //    }
//        //    set
//        //    {
//        //        if (value.GetType() == typeof(NewsArticlesModuleProviderInfo))
//        //        {
//        //            _provider = (NewsArticlesModuleProviderInfo)value;
//        //        }
//        //    }
//        //}

//        Dictionary<string, string> IExtensionUrlProviderSettingsControl.SaveSettings()
//        {
//            return UpdateSettings();
//        }
//        /// <summary>
//        /// LoadSettings is called when the module control is first loaded onto the page
//        /// </summary>
//        /// <remarks>
//        /// This method shoudl read all the custom properties of the provider and set the controls
//        /// of the page to reflect the current settings of the provider.
//        /// </remarks>
//        /// <param name="provider"></param>
//        public void LoadSettings()
//        {
//            //build list of controls
//            if (!IsPostBack)
//                LocalizeControls();
//            //if (_provider == null){
//            //    _provider = new NewsArticlesModuleProviderInfo();
//            //}
//            if (_provider != null && !IsPostBack) {
//                //take all the values from the provider and show on page
//                //check type safety before cast
//                if (_provider.GetType() == typeof(NewsArticlesModuleProvider))
//                {
//                    NewsArticlesModuleProvider moduleProvider = (NewsArticlesModuleProvider)_provider;

//                    _providerSettings = _provider.Settings;
//                    _noDnnPagePathTabId = moduleProvider.NoDnnPagePathTabId;

//                    List<int> tabIds = new List<int>();
//                    if (_provider.TabIds.Count > 0)
//                    {
//                        tabIds.AddRange(_provider.TabIds);
//                    }
//                    else
//                        if (_provider.AllTabs)
//                        tabIds.Add(-1);
//                    //bind to tab repeater
//                    rptTabs.DataSource = tabIds;
//                    rptTabs.DataBind();
//                    //Starting article id
//                    //txtStartingArticleId.Text = moduleProvider.StartingArticleId.ToString();
//                    //chkRedirectOldUrls.Checked = moduleProvider.RedirectUrls;

//                }
//            }
            
//        }

//        private void TabToScreen(RepeaterItem item)
//        {
//            TabController tc = new TabController();
//            int tabId = (int)item.DataItem;
//            string tabName = "";
//            if (tabId > -1)
//            {
//                TabInfo tab = tc.GetTab(tabId);
//                tabName = tab.TabName;
//            }
//            else
//            {
//                tabName = GetResourceString(this.LocalResourceFile, "AllTabsName.Text", "All Tabs");
//            }
//            Label lblPageName = (Label)item.FindControl("lblPageName");
//            lblPageName.Text = tabName;

//            //now get the individual settings
//            Hashtable articleUrlStyles = TabUrlOptions.GetHashTableFromSetting(_providerSettings["articleUrlStyle"]);
//            Hashtable articleUrlSource = TabUrlOptions.GetHashTableFromSetting(_providerSettings["articleUrlSource"]);
//            Hashtable pageUrlStyles = TabUrlOptions.GetHashTableFromSetting(_providerSettings["pageUrlStyle"]);
//            Hashtable authorUrlStyles = TabUrlOptions.GetHashTableFromSetting(_providerSettings["authorUrlStyle"]);
//            Hashtable categoryUrlStyles = TabUrlOptions.GetHashTableFromSetting(_providerSettings["categoryUrlStyle"]);
//            //build options from lists
//            TabUrlOptions tabOptions = new TabUrlOptions(tabId, -1, articleUrlStyles, articleUrlSource, pageUrlStyles, authorUrlStyles, categoryUrlStyles);
//            //now get controls
//            HiddenField hdnTabId = (HiddenField)item.FindControl("hdnTabId");
//            hdnTabId.Value = tabId.ToString();
//            DropDownList ddlArticleUrlStyle = (DropDownList)item.FindControl("ddlArticleUrlStyle");
//            DropDownList ddlArticleUrlSource = (DropDownList)item.FindControl("ddlArticleUrlSource");
//            DropDownList ddlCategoryUrlStyle = (DropDownList)item.FindControl("ddlCategoryUrlStyle");
//            DropDownList ddlAuthorUrlStyle = (DropDownList)item.FindControl("ddlAuthorUrlStyle");
//            DropDownList ddlPageUrlStyle = (DropDownList)item.FindControl("ddlPageUrlStyle");
//            CheckBox chkNoDnnPagePath = (CheckBox)item.FindControl("chkNoDnnPagePath");
//            BuildDropDownList(ddlArticleUrlStyle, tabOptions.ArticleStyle, typeof(ArticleUrlStyle));
//            BuildDropDownList(ddlArticleUrlSource, tabOptions.ArticleSource, typeof(ArticleUrlSource));
//            BuildDropDownList(ddlCategoryUrlStyle, tabOptions.CategoryStyle, typeof(CategoryUrlStyle));
//            BuildDropDownList(ddlAuthorUrlStyle, tabOptions.AuthorStyle, typeof(AuthorUrlStyle));
//            BuildDropDownList(ddlPageUrlStyle, tabOptions.PageStyle, typeof(PageUrlStyle));
//            Label lblArticleUrlStyle = (Label)item.FindControl("lblArticleUrlStyle");
//            Label lblArticleUrlSource = (Label)item.FindControl("lblArticleUrlSource");
//            Label lblCategoryUrlStyle = (Label)item.FindControl("lblCategoryUrlStyle");
//            Label lblAuthorUrlStyle = (Label)item.FindControl("lblAuthorUrlStyle");
//            Label lblPageUrlStyle = (Label)item.FindControl("lblPageUrlStyle");
//            Label lblNoDnnPagePath = (Label)item.FindControl("lblNoDnnPagePath");
//            if (tabId > -1)
//            {
//                chkNoDnnPagePath.Checked = (_noDnnPagePathTabId == tabId);
//                lblNoDnnPagePath.Text = _noDnnPagePathText;
//            }
//            else
//            {
//                chkNoDnnPagePath.Visible = false;
//                lblNoDnnPagePath.Text = _needTabSpecifiedText;
//            }
//            lblArticleUrlStyle.Text = _articleUrlStyleText;
//            lblArticleUrlSource.Text = _articleUrlSourceText;
//            lblCategoryUrlStyle.Text = _categoryUrlStyleText;
//            lblAuthorUrlStyle.Text = _authorUrlStyleText;
//            lblPageUrlStyle.Text = _pageUrlStyleText;
//        }

//        private void BuildDropDownList(DropDownList ddlList, Enum setValue, Type enumType)
//        {
//            //loop iteration and build drop down list
//            foreach (string name in Enum.GetNames(enumType))
//            {
//                string fullName = DotNetNuke.Services.Localization.Localization.GetString(LocalResourceFile, name + ".Text", name);
//                ListItem item = new ListItem(fullName, name);
//                if (name == setValue.ToString())
//                    item.Selected = true;
//                ddlList.Items.Add(item);
//            }
//        }


//        /// <summary>
//        /// UpdateSettings is called when the 'update' button is clicked on the interface.
//        /// This should take any values from the page, and set the individual properties on the 
//        /// instance of the module provider.
//        /// </summary>
//        /// <param name="provider"></param>
//        public Dictionary<string, string> UpdateSettings()
//        {
//            //check type safety before cast
//            if (_provider.GetType() == typeof(NewsArticlesModuleProvider))
//            {
//                //take values from the page and set values on provider    
//                NewsArticlesModuleProvider moduleProvider = (NewsArticlesModuleProvider)_provider;
//                _providerSettings = _provider.Settings;

//                //starting articleId
//                int startingArticleId = -1;
//                if (int.TryParse(txtStartingArticleId.Text, out startingArticleId))
//                {
//                    //if (startingArticleId > -1)
//                        //moduleProvider.StartingArticleId = startingArticleId;
//                }
//               // moduleProvider.RedirectUrls = chkRedirectOldUrls.Checked;

//                //now get the individual settings from the provider, as they are now
//                Hashtable articleUrlStyles = TabUrlOptions.GetHashTableFromSetting(_providerSettings["articleUrlStyle"]);
//                Hashtable articleUrlSource = TabUrlOptions.GetHashTableFromSetting(_providerSettings["articleUrlSource"]);
//                Hashtable pageUrlStyles = TabUrlOptions.GetHashTableFromSetting(_providerSettings["pageUrlStyle"]);
//                Hashtable authorUrlStyles = TabUrlOptions.GetHashTableFromSetting(_providerSettings["authorUrlStyle"]);
//                Hashtable categoryUrlStyles = TabUrlOptions.GetHashTableFromSetting(_providerSettings["categoryUrlStyle"]);

//                //build a super-list of hashtables, where there is an entry for each setting
//                Hashtable allHashtables = new Hashtable();
//                allHashtables.Add("articleUrlStyle", articleUrlStyles);
//                allHashtables.Add("articleUrlSource", articleUrlSource);
//                allHashtables.Add("pageUrlStyle", pageUrlStyles);
//                allHashtables.Add("authorUrlStyle", authorUrlStyles);
//                allHashtables.Add("categoryUrlStyle", categoryUrlStyles);
//                //in case there is any leftover settings from tabs that have been removed.
//                RemoveInactiveTabIds(_provider.TabIds, _provider.AllTabs, allHashtables);
//                //934 : reset the noDnnPagePath 
//               // moduleProvider.NoDnnPagePathTabId = -1; //will be set in 'TabFromScreen' if still set
//                //get the valeus for each tab
//                foreach (RepeaterItem item in rptTabs.Items)
//                {
//                    TabFromScreen(moduleProvider, item, allHashtables);
//                }

//                //now feed back the hashtables back into the actual attributes for the provider
//                SetProviderProperty(moduleProvider, allHashtables, "ArticleUrlStyle", "articleUrlStyle");
//                SetProviderProperty(moduleProvider, allHashtables, "ArticleUrlSource", "articleUrlSource");
//                SetProviderProperty(moduleProvider, allHashtables, "PageUrlStyle", "pageUrlStyle");
//                SetProviderProperty(moduleProvider, allHashtables, "CategoryUrlStyle", "categoryUrlStyle");
//                SetProviderProperty(moduleProvider, allHashtables, "AuthorUrlStyle", "authorUrlStyle");

//            }
//            return _provider.Settings;
//        }

//        private void RemoveInactiveTabIds(List<int> activeTabIds, bool allTabs, Hashtable allHashtables)
//        {
//            foreach (string settingName in allHashtables.Keys)
//            {
//                //get the setting hashtable
//                Hashtable settingTable = (Hashtable)allHashtables[settingName];
//                List<string> inactiveTabs = new List<string>();
//                //walk through the list of tabs in the settings, and see if they are in the active list
//                foreach (string tabIdRaw in settingTable.Keys)
//                {
//                    int tabId = 0;
//                    if (int.TryParse(tabIdRaw, out tabId))
//                    {
//                        if (activeTabIds.Contains(tabId) == false)//this tab isn't in the list of active tabs
//                            inactiveTabs.Add(tabIdRaw);
//                    }
//                }
//                //now remove the entries
//                foreach (string inactiveTabId in inactiveTabs)
//                {
//                    settingTable.Remove(inactiveTabId);
//                }
//            }

//        }

//        private void SetProviderProperty(NewsArticlesModuleProvider moduleProvider, Hashtable allHashtables, string providerPropertyName, string attributeName)
//        {
//            //use reflection to get the property
//            System.Reflection.PropertyInfo settingProperty = moduleProvider.GetType().GetProperty(providerPropertyName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
//            if (settingProperty != null && settingProperty.CanWrite)
//            {
//                //get hash table from list of all hashtables for all settings
//                Hashtable settingHashTable = (Hashtable)allHashtables[attributeName];
//                //get delimited string of all contents of setting hash table
//                string settingValue = GetDelimitedString(settingHashTable, ",", ";");
//                //set provider property with hashtable values
//                settingProperty.SetValue(moduleProvider, settingValue, null);
//            }
//        }

//        private string GetDelimitedString(Hashtable settingHashTable, string colDelim, string rowDelim)
//        {
//            string result = "";
//            if (settingHashTable != null)
//            {
//                foreach (object key in settingHashTable.Keys)
//                {
//                    object value = settingHashTable[key];
//                    result += key.ToString() + colDelim + value.ToString() + rowDelim;
//                }
//            }
//            return result;
//        }

//        private void TabFromScreen(NewsArticlesModuleProvider provider, RepeaterItem item, Hashtable allHashTables)
//        {
//            if (item != null)
//            {
//                HiddenField hdnTabid = (HiddenField)item.FindControl("hdnTabId");
//                if (hdnTabid != null)
//                {
//                    string tabIdStr = hdnTabid.Value;
//                    //get the values from the drop downs
//                    SetHashTableFromDropDownValue(tabIdStr, item, allHashTables, "articleUrlStyle", "ddlArticleUrlStyle");
//                    SetHashTableFromDropDownValue(tabIdStr, item, allHashTables, "articleUrlSource", "ddlArticleUrlSource");
//                    SetHashTableFromDropDownValue(tabIdStr, item, allHashTables, "categoryUrlStyle", "ddlCategoryUrlStyle");
//                    SetHashTableFromDropDownValue(tabIdStr, item, allHashTables, "authorUrlStyle", "ddlAuthorUrlStyle");
//                    SetHashTableFromDropDownValue(tabIdStr, item, allHashTables, "pageUrlStyle", "ddlPageUrlStyle");
//                    int tabIdInt = -1;
//                    if (int.TryParse(tabIdStr, out tabIdInt))
//                    {
//                        if (tabIdInt > -1)
//                        {
//                            //check if tabis marked as the noDnnPagePath
//                            CheckBox chkNoDnnPagePath = (CheckBox)item.FindControl("chkNoDnnPagePath");
//                            //if (chkNoDnnPagePath != null && chkNoDnnPagePath.Checked)
//                                //provider.NoDnnPagePathTabId = tabIdInt;
//                        }
//                    }
//                }
//            }
//        }

//        private void SetHashTableFromDropDownValue(string tabId, RepeaterItem item, Hashtable allHashTables, string attributeName, string ddlId)
//        {
//            Hashtable tabsSetting = (Hashtable)allHashTables[attributeName];
//            DropDownList dropDownList = (DropDownList)item.FindControl(ddlId);
//            if (dropDownList.SelectedIndex > -1 && tabsSetting != null)
//            {
//                if (tabsSetting.ContainsKey(tabId))
//                    tabsSetting[tabId] = dropDownList.SelectedValue;
//                else
//                    tabsSetting.Add(tabId, dropDownList.SelectedValue);
//            }
//        }

//        public System.Web.UI.Control Control
//        {
//            get { return this; }
//        }

//        public string ControlPath
//        {
//            get { return base.TemplateSourceDirectory; }
//        }

//        public string ControlName
//        {
//            get { return "ProviderSettings"; }
//        }

//        public string LocalResourceFile
//        {
//            get { return "DesktopModules/Dnn.NewsArticlesFriendlyUrlProvider/App_LocalResources/Settings.ascx.resx"; }
//        }
//        public int PortalId
//        {
//            get { return _portalId; }
//            set { _portalId = value; }
//        }

//        #endregion

//    }
//}
