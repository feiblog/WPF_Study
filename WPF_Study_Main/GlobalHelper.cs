#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 版权所有 (c) 2022  NJRN 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：PAN-FEI-1996
 * 公司名称：
 * 命名空间：WPF_Study_Main
 * 唯一标识：8f9de967-68ef-48bc-aae2-34e611ca9102
 * 文件名：GlobalHelper
 * 当前用户域：PAN-FEI-1996
 * 
 * 创建者：pfei
 * 电子邮箱：PFEI1214@163.com
 * 创建时间：2022/10/21 13:41:23
 * 版本：V1.0.0
 * 描述：
 *
 * ----------------------------------------------------------------
 * 修改人：
 * 时间：
 * 修改说明：
 *
 * 版本：V1.0.1
 *----------------------------------------------------------------*/
#endregion << 版 本 注 释 >>
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interop;

namespace WPF_Study_Main
{
    /// <summary>
    /// GlobalHelper 的摘要说明
    /// </summary>
    class GlobalHelper
    {
        #region <常量>
        public static double DPIxRatio = 1;
        public static double DPIyRatio = 1;
        #endregion <常量>

        #region <变量>
        #endregion <变量>

        #region <属性>
        #endregion <属性>

        #region <构造方法和析构方法>
        #endregion <构造方法和析构方法>

        #region <方法>
        /// <summary>
        /// 获取DPI放大的倍数
        /// </summary>
        public static double GetDpiScaling()
        {
            // 方法1 WPF窗体获取dpi
            //WindowInteropHelper winHelper = new WindowInteropHelper((MainWin)App.Current.MainWindow);
            //Graphics currentGraphics = Graphics.FromHwnd(winHelper.Handle);
            //double dpiXRatio = currentGraphics.DpiX / 96;
            //double dpiYRatio = currentGraphics.DpiY / 96;

            //var dpiXProperty = typeof(SystemParameters).GetProperty("DpiX", BindingFlags.NonPublic | BindingFlags.Static);
            //var dpiYProperty = typeof(SystemParameters).GetProperty("Dpi", BindingFlags.NonPublic | BindingFlags.Static);
            //var dpiX = (int)dpiXProperty.GetValue(null, null);
            //var dpiY = (int)dpiYProperty.GetValue(null, null);
            //var dpixRatio = dpiX / 96;
            //var dpiyRatio = dpiY / 96;

            return (int)typeof(SystemParameters).GetProperty("Dpi", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static).GetValue(null, null) / 96.0;
        }
        #endregion <方法>

        #region <事件>
        #endregion <事件>
    }
}
