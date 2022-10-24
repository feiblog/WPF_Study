using System.Drawing;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;
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
            this.Loaded += MainWin_Loaded;

        }

        private void MainWin_Loaded(object sender, RoutedEventArgs e)
        {
            Header.Close += Header_Close;
            //PresentationSource source = PresentationSource.FromVisual(this);
            //if (source != null)
            //{
            //    GlobalHelper.DPIxRatio = 96.0 * source.CompositionTarget.TransformToDevice.M11 / 96;
            //    GlobalHelper.DPIyRatio = 96.0 * source.CompositionTarget.TransformToDevice.M22 / 96;
            //}
        }

        private void Header_Close(object sender, RoutedEventArgs e)
        {

            MessageBoxResult result = HandyControl.Controls.MessageBox.Show("确定关闭系统","提示",MessageBoxButton.OKCancel,MessageBoxImage.Information);
            if(result == MessageBoxResult.OK)
            {
                this.Close();
            }
        }

        private void GotoPages(object sender, GotoPagesEventArgs e)
        {
            switch (e.PageUrl)
            {
                case "SystemSetting":
                    bodyFrame.Navigate(GlobalVariable.AllViews["SystemSetting"]);
                    break;
                case "PictureProcessing":
                    bodyFrame.Navigate(GlobalVariable.AllViews["PictureProcessing"]);
                    break;
                default:
                    bodyFrame.Navigate(GlobalVariable.AllViews["Home"]);
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
