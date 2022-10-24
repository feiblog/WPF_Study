using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WPF_Study_Main.Control.Navigation
{
    /// <summary>
    /// HeaderNavControl.xaml 的交互逻辑
    /// </summary>
    public partial class HeaderControl : UserControl
    {
        public HeaderControl()
        {
            InitializeComponent();
        }

        #region <首页>

        #endregion <首页>

        #region <关闭>
        public static readonly RoutedEvent CloseEvent = EventManager.RegisterRoutedEvent
            ("Close", RoutingStrategy.Bubble, typeof(RoutedPropertyChangedEventArgs<object>), typeof(HeaderControl));
        public event RoutedEventHandler Close
        {
            add { AddHandler(CloseEvent, value); }
            remove { RemoveHandler(CloseEvent, value); }
        }
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            RoutedEventArgs args = new RoutedEventArgs(CloseEvent, this);
            RaiseEvent(args);
        }
        #endregion <关闭>


    }
}
