using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows;
using System.ComponentModel;

namespace Codi
{
    class codi
    {
        public Dictionary<int, string> BookList()
        {
            //Gets a full list of books
            Dictionary<int, string> result = new Dictionary<int, string>();

            

            return result;
        }

        public Dictionary<int, string> ChapterList(int BookID)
        {
            //Gets list of Chapters based upon BookID
            Dictionary<int, string> result = new Dictionary<int, string>();

            return result;
        }

        public string infoCount()
        {
            //Counts number of books, chapters and pages
            
            int BookNum = 0;
            int ChapterNum = 0;
            int PageNum = 0;


            string result = BookNum.ToString() + " Books | " + ChapterNum.ToString() + " Chapters | " + PageNum.ToString() + " Pages";
            return result;
        }
    }
    
    class Page
    {
        //Class Variables
        private string PageName;
        private string Code;
        private int PID;
        private int CID;
        private string Status;
        private DateTime Created;
        private DateTime Modified;
        private List<string> Requirements;
        private string[,] Notes;
        private string[] AttachmentList;

        #region Get/Set
        public string _PageName
        {
            get { return (PageName); }
            set { PageName = value; }
        }

        public string _Code
        {
            get { return (Code); }
            set { Code = value; }
        }

        public int _PID
        {
            get { return (PID); }
        }

        public int _CID
        {
            get { return (CID); }
            set { CID = value; }
        }

        public string _Status
        {
            get { return (Status); }
            set { Status = value; }
        }

        public List<string> _Requirements
        {
            get { return (Requirements); }
            set { Requirements = value; }
        }

        public string[,] _Notes
        {
            get { return (Notes); }
        }

        public DateTime _Created
        {
            get { return (Created); }
        }

        public DateTime _Modified
        {
            get { return (Modified); }
        }
        #endregion  

        #region Contructors
        public Page()
        {
            Created = DateTime.Now;
        }

        public Page(int findPID)
        {
            LookupPID(findPID);
        }
        #endregion

        #region Public Functions
        public void SaveInfo()
        {

        }

        public void AddNote(string NoteText)
        {
            //Add new note

            //Rebuild list
            BuildNoteList();
        }

        public void DeleteNote(int NoteID)
        {
            //Delete Note

            //Rebuild list
            BuildNoteList();
        }
        public void AddRequirement(string NewRequirement)
        {
            //Add new requirement

            //Refresh List
            BuildRequirementList();
        }

        public void deleteRequirement(int RequirementID)
        {
            //Delete Requirement

            //Refresh List
            BuildRequirementList();
        }

        public void UpdateRequirement(int RequirementID, string RequirementText)
        {
            //Update Requirement

            //Refresh requirement list
            BuildRequirementList();
        }
        #endregion

        #region Private Functions
        private void LookupPID(int findPID)
        {

            //Build PID Info
            BuildRequirementList();
        }

        private void BuildRequirementList()
        {

        }

        private void BuildNoteList()
        {
           
        }
       #endregion
    }

    class Chapter
    {
        //Class Variables
        private int CID;
        private int BID;
        private string ChapterName;

        #region Get/Set

        public int _CID
        {
            get { return (CID); }
        }

        public int _BID
        {
            get { return (BID); }
            set { BID = value; }
        }

        public string _ChapterName
        {
            get { return (ChapterName); }
            set { ChapterName = value; }
        }

        #endregion

        #region Private Functions

        #endregion
        
        #region Public Functions
        public void SaveChapter()
        {

        }

        public Dictionary<int, string> GetPageList()
        {
            Dictionary<int, String> result = new Dictionary<int, string>();

            return (result);
        }
        #endregion
    }

    class Book
    {
        //Class Variables
        private int BID;
        private string BookName;

        #region Get/Set
        public int _BID
        {
            get { return (BID); }
        }

        public string _BookName
        {
            get { return (BookName); }
            set { BookName = value; }
        }

        #endregion

        #region Private Functions
        
        #endregion

        #region Public Functions
        public void SaveBook()
        {

        }

        public Dictionary<int, string> GetChapterList()
        {
            Dictionary<int, string> Result = new Dictionary<int, string>();

            return Result;
        }
        #endregion
    }

    class DataConnection
    {
        public SqlConnection aConn;

        #region Constructor

        public DataConnection()
        {
            try
            {
                aConn = new SqlConnection(@"Data Source=" + Properties.Settings.Default.SQLDB + ";Initial Catalog=Codex;Persist Security Info=True;User ID=" + Properties.Settings.Default.SQLUser + ";Password=" + Properties.Settings.Default.SQLPWD + ";");
            }
            catch { }
        }

        #endregion

        #region public functions
        public bool TestConnection(string strUser, string strPwd, string strDB)
        {
            //Test the connection string, return error message on failure
            bool result = false;
            try
            {
                SqlConnection NewConnection = new SqlConnection(@"Data Source=" + strDB + ";Initial Catalog=Codex;Persist Security Info=True;User ID=" + strUser + ";Password=" + strPwd + ";");
                NewConnection.Open();
                result = true;
            }
            catch
            {
                result = false;
                MessageBox.Show("Unable to connect to server: \r\n" + Properties.Settings.Default.SQLDB + "\r\nWith user: \r\n" + Properties.Settings.Default.SQLUser, "Error connecting to SQL");
            }

            return result;
        }
        #endregion
    }
}
