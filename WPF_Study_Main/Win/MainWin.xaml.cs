using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPF_Study_Main.Routed;

namespace WPF_Study_Main.Win
{
    /// <summary>
    /// MainWin.xaml 的交互逻辑
    /// </summary>
    public partial class MainWin : Window
    {
        //private Dictionary<string, Uri> allViews = new Dictionary<string, Uri>();   //包含所有页面
        public MainWin()
        {
            InitializeComponent();
            //添加页面的Uri地址，采用相对路径，根路径是项目名,实现allViews的初始化
            //allViews.Add("page1", new Uri("pages/TestPages/Page1.xaml", UriKind.Relative));
            //allViews.Add("page2", new Uri("pages/TestPages/Page2.xaml", UriKind.Relative));
            //this.Aside.ReportCurrentLocation += GotoPages;
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
