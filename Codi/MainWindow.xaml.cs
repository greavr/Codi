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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            codi newCodi = new codi();

            lblCount.Content = newCodi.infoCount();

            TabItem aTab = BuildTab();

            tcPages.Items.Add(aTab);
            tcPages.SelectedIndex = tcPages.Items.Count -1;

        }

        private void txtSearch_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtSearch.Text == "Search...")
            {
                txtSearch.Foreground = Brushes.Black;
                txtSearch.Text = "";
            }
        }

        private void txtSearch_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search...";
                var bc = new BrushConverter();
                txtSearch.Foreground = (Brush)bc.ConvertFrom("#C5000000"); ;
            }
        }

        public TabItem BuildTab()
        {
            //Set tab values
            TabItem newTab = new TabItem();
            newTab.Header = "Sample Page";
            newTab.Name = "SamplePage";
            newTab.FontSize = 11;

            //Build Controls
            Grid MasterGrid = new Grid();
            Grid LeftPanelGrid = new Grid();
            GridSplitter lrDivide = new GridSplitter();
            Button btnExpand = new Button();
            Label lblTitle = new Label();
            ComboBox cbStatus = new ComboBox();
            TextBox txtCode = new TextBox();
            Button btnLock = new Button();
                        

            //MasterGrid
            //Create three Columns
            //0 = Left panel
            //1 = GridSpliiter Controler
            //2 = Right Panel
            ColumnDefinition mgOne = new ColumnDefinition();
            ColumnDefinition mgTwo = new ColumnDefinition();
            ColumnDefinition mgThree = new ColumnDefinition();

            mgOne.Width = new GridLength(1, GridUnitType.Star);
            mgTwo.Width = new GridLength(0, GridUnitType.Auto);
            mgThree.Width = new GridLength(200, GridUnitType.Pixel);
            mgThree.MaxWidth = (double)200;
                        
            MasterGrid.ColumnDefinitions.Add(mgOne);
            MasterGrid.ColumnDefinitions.Add(mgTwo);
            MasterGrid.ColumnDefinitions.Add(mgThree);

            MasterGrid.Children.Add(LeftPanelGrid);
            MasterGrid.Children.Add(lrDivide);


            //LeftPanelGrid
            //Two Columns,Three Rows
            ColumnDefinition lpOne = new ColumnDefinition();
            ColumnDefinition lpTwo = new ColumnDefinition();
            RowDefinition lpRowOne = new RowDefinition();
            RowDefinition lpRowTwo = new RowDefinition();
            RowDefinition lpRowThree = new RowDefinition();

            lpOne.Width = new GridLength(1, GridUnitType.Star);
            lpTwo.Width = new GridLength(150, GridUnitType.Pixel);
            LeftPanelGrid.ColumnDefinitions.Add(lpOne);
            LeftPanelGrid.ColumnDefinitions.Add(lpTwo);

            lpRowOne.Height = new GridLength(40, GridUnitType.Pixel);
            lpRowTwo.Height = new GridLength(1, GridUnitType.Star);
            lpRowThree.Height = new GridLength(30, GridUnitType.Pixel);
            LeftPanelGrid.RowDefinitions.Add(lpRowOne);
            LeftPanelGrid.RowDefinitions.Add(lpRowTwo);
            LeftPanelGrid.RowDefinitions.Add(lpRowThree);

            //lblTitle
            lblTitle.Content = "Sampler";
            lblTitle.FontSize = 25;
            lblTitle.HorizontalAlignment = HorizontalAlignment.Left;
            lblTitle.Margin = new Thickness(10, 0, 0, 0);
            Grid.SetColumn(lblTitle, 0);
            Grid.SetRow(lblTitle, 0);
            LeftPanelGrid.Children.Add(lblTitle);

            //cbStatus
            cbStatus.VerticalAlignment = VerticalAlignment.Center;
            Grid.SetColumn(cbStatus, 1);
            Grid.SetRow(cbStatus, 0);
            LeftPanelGrid.Children.Add(cbStatus);

            //txtCode
            txtCode.AcceptsReturn = true;
            txtCode.AcceptsTab = true;
            Grid.SetColumn(txtCode, 0);
            Grid.SetRow(txtCode, 1);
            Grid.SetColumnSpan(txtCode, 2);
            LeftPanelGrid.Children.Add(txtCode);

            //btnLock
            btnLock.Content = "Lock / Unlock";
            btnLock.Width = 100;
            btnLock.Height = 25;
            btnLock.Margin = new Thickness(20, 0, 0, 0);
            btnLock.HorizontalAlignment = HorizontalAlignment.Left;
                ImageBrush btnLockBrush = new ImageBrush();
                btnLockBrush.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/Codi;component/Images/lock.png"));
                btnLockBrush.AlignmentX = AlignmentX.Left;
                btnLockBrush.AlignmentY = AlignmentY.Top;
                btnLockBrush.Stretch = Stretch.None;
            btnLock.Background = btnLockBrush;

            Grid.SetColumn(btnLock, 0);
            Grid.SetRow(btnLock, 2);
            LeftPanelGrid.Children.Add(btnLock);
            LeftPanelGrid.Margin = new Thickness(0, 0, 5, 0);
            LeftPanelGrid.VerticalAlignment = VerticalAlignment.Stretch;
            LeftPanelGrid.HorizontalAlignment = HorizontalAlignment.Stretch;
            Grid.SetColumn(LeftPanelGrid, 0);
            Grid.SetRow(LeftPanelGrid, 0);
            
            //lrDivide
            lrDivide.HorizontalAlignment = HorizontalAlignment.Right;
            lrDivide.VerticalAlignment = VerticalAlignment.Stretch;
            lrDivide.ResizeBehavior = GridResizeBehavior.PreviousAndNext;
            lrDivide.Width = 2;
            lrDivide.Background = new SolidColorBrush(Colors.Black);
            lrDivide.MinWidth = (double)2;
            Grid.SetColumn(lrDivide,1);
            Grid.SetRow(lrDivide, 0);

            //Add Controls
            newTab.Content = MasterGrid;

            return newTab;
        }

        private void btnExpand_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            Settings frmSetting = new Settings();
            frmSetting.ShowDialog();
        }
    }
}
