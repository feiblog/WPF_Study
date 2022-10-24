using System;
using System.Windows;
using System.Windows.Controls;
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
        public static readonly RoutedEvent GotoPageEvent = EventManager.RegisterRoutedEvent
            ("GotoPage", RoutingStrategy.Bubble, typeof(EventHandler<GotoPagesEventArgs>), typeof(AsideControl));

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
        private void BtnGotoPage(object sender,RoutedEventArgs e)
        {
            RadioButton obj = (RadioButton)sender;
            GotoPagesEventArgs args = new GotoPagesEventArgs(GotoPageEvent, this);
            args.TriggeringTime = DateTime.Now;
            args.PageUrl = obj.Tag.ToString();
            this.RaiseEvent(args);
        }

        #endregion
    }
}
