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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_Study_Main.Routed;

namespace WPF_Study_Main.Control.Navigation
{
    /// <summary>
    /// AsideControl.xaml 的交互逻辑
    /// </summary>
    public partial class AsideControl : UserControl
    {
        public AsideControl()
        {
            InitializeComponent();
        }

        #region 页面跳转

        /// <summary>
        /// 声明并注册路由事件
        /// </summary>
        public static readonly RoutedEvent GotoPageEvent = EventManager.RegisterRoutedEvent(
           "GotoPage", RoutingStrategy.Bubble, typeof(EventHandler<GotoPagesEventArgs>), typeof(AsideControl));

        /// <summary>
        /// 利用CLR事件包装路由事件（封装路由事件）
        /// </summary>
        public event RoutedEventHandler GotoPage
        {
            add { this.AddHandler(GotoPageEvent, value); }
            remove { this.RemoveHandler(GotoPageEvent, value); }
        }
        /// <summary>
        /// 创建可以激发路由事件的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void page1Button(object sender, RoutedEventArgs e)
        {
            GotoPagesEventArgs args = new GotoPagesEventArgs(GotoPageEvent, this);
            args.ClickTime = DateTime.Now;
            args.PageUrl = "1";
            this.RaiseEvent(args);
        }

        #endregion

        private void page2Button(object sender, RoutedEventArgs e)
        {
            GotoPagesEventArgs args = new GotoPagesEventArgs(GotoPageEvent, this);
            args.ClickTime = DateTime.Now;
            args.PageUrl = "2";
            this.RaiseEvent(args);
        }
    }
}
