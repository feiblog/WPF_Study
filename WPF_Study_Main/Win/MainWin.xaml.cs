using System.Windows;
using System.Windows.Input;
using WPF_Study_Main.Routed;

namespace WPF_Study_Main.Win
{
    /// <summary>
    /// MainWin.xaml 的交互逻辑
    /// </summary>
    public partial class MainWin : Window
    {
        public MainWin()
        {
            InitializeComponent();
           
        }

        private void GotoPages(object sender, GotoPagesEventArgs e)
        {
            switch (e.PageUrl)
            {
                case "1":
                    bodyFrame.Navigate(GlobalVariable.AllViews["page1"]);
                    break;
                case "2":
                    bodyFrame.Navigate(GlobalVariable.AllViews["page2"]);
                    break;
                default:
                    bodyFrame.Navigate(GlobalVariable.AllViews["page1"]);
                    break;
            }
        }
        private void Header_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // 按下拖动
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }

            // 双击放大
            if (e.ClickCount == 2 && e.ChangedButton == MouseButton.Left)
            {
                this.WindowState = this.WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
            }
        }
    }
}
