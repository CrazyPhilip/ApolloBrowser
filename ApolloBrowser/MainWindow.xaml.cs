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
    }
}
