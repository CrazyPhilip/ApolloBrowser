using SourceChord.FluentWPF;
using System;
using System.Windows;

namespace ApolloBrowser
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : AcrylicWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += new RoutedEventHandler(MainWindow_Loaded);
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Viewer.DocumentText = "Hello World!";
        }

        private void MetroWindow_Closed(object sender, EventArgs e)
        {
            
        }

        private void ConfirmBtn_Click(object sender, RoutedEventArgs e)
        {
            string url = "https://" + UriInput.Text + "/";
            Console.WriteLine(url);
            Viewer.Navigate(url);
        }

        private void MoreBtn_Initialized(object sender, EventArgs e)
        {
            this.MoreBtn.ContextMenu = null;
        }

        private void MoreBtn_Click(object sender, RoutedEventArgs e)
        {
            //目标
            this.MoreContextMenu.PlacementTarget = this.MoreBtn;

            //位置
            this.MoreContextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;

            //显示菜单
            this.MoreContextMenu.IsOpen = true;
        }
    }
}
