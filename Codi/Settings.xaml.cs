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
using System.Windows.Shapes;

namespace Codi
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadDetails();
        }

        private void LoadDetails()
        {
            txtSQLServer.Text = Codi.Properties.Settings.Default.SQLDB;
            txtSQLuser.Text = Codi.Properties.Settings.Default.SQLUser;
            txtSQLPwd.Password = Codi.Properties.Settings.Default.SQLPWD;
            lblLastTest.Content = Codi.Properties.Settings.Default.LastSQLTest;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Codi.Properties.Settings.Default.SQLDB = txtSQLServer.Text;
            Codi.Properties.Settings.Default.SQLUser = txtSQLuser.Text;
            Codi.Properties.Settings.Default.SQLDB = txtSQLPwd.Password;
            Properties.Settings.Default.Save();
        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            DataConnection newDC = new DataConnection();
            bool testresult = newDC.TestConnection(txtSQLuser.Text, txtSQLPwd.Password.ToString(), txtSQLServer.Text);

            string Result = "";

            if (testresult)
            {
                Result = "Sucess -  ";
            }
            else
            {
                Result = "Failure - ";
            }

            Result += DateTime.Now.ToString();

            //Dispose of Connection
            newDC = null;

            //Save Result
            Properties.Settings.Default.LastSQLTest = Result;
            Properties.Settings.Default.Save();

            //Refresh Info
            LoadDetails();
        }
    }
}
