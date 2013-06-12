using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Codi
{
    class CodePage
    {
        //Class variables
        private string PageName;
        private string PageCode;
        private string PageStatus;
        private bool hasChanged;
        private DateTime PageUpdate;
        private int PageID;
        private int ChapterID;
        private List<string> PageKeywords;

        #region Constructors
        public CodePage(int pageID)
        {
            PageID = pageID;
            LookupPage();
        }

        public CodePage()
        {
            hasChanged = true;
        }
        #endregion

        #region Get/Set
        public bool _hasChanged
        {
            get { return(hasChanged); }
        }

        public string _pageName
        {
            get { return (PageName); }
            set { PageName = value; hasChanged = true; }
        }

        public string _pageCode
        {
            get { return (PageCode); }
            set { PageCode = value; hasChanged = true; }
        }

        public string _pageStatus
        {
            get { return (PageStatus); }
            set { PageStatus = value; hasChanged = true; }
        }

        public DateTime _pageUpdate
        {
            get { return (PageUpdate); }
        }

        public int _pageID
        {
            get { return (PageID); }
        }

        public int _chapterID
        {
            get { return (ChapterID); }
            set { ChapterID = value; hasChanged = true; }
        }

        public List<string> _pageKeywords
        {
            get { return (PageKeywords); }
            set { PageKeywords = value; hasChanged = true; }
        }
        #endregion 

        #region Public Functions
        public TabItem BuildTab()
        {
            TabItem newTab = new TabItem();
            newTab.Header = PageName;
            newTab.Name = PageName;
            newTab.FontSize = 14;
            newTab.FontWeight = FontWeights.Bold;



            return newTab;
        }
        #endregion

        #region Private Functions
        private void LookupPage()
        {

        }
        #endregion
    }

    class CodeChapter
    {
        //Class Variable
        private int ChapterID;
        private string ChapterName;
        private int BookID;
    }

    class CodeBook
    {
        //Class Variables
        private int BookID;
        private string BookName;
    }
}
