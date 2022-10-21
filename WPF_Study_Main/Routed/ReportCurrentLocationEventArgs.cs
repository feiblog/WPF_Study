#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 版权所有 (c) 2022  NJRN 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：PAN-FEI-1996
 * 公司名称：
 * 命名空间：WPF_Study_Main.Routed
 * 唯一标识：c57aca4e-8501-44c9-875a-3e0dec7197cd
 * 文件名：ReportCurrentLocationEventArgs
 * 当前用户域：PAN-FEI-1996
 * 
 * 创建者：pfei
 * 电子邮箱：PFEI1214@163.com
 * 创建时间：2022/10/20 16:15:33
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_Study_Main.Routed
{
    /// <summary>
    /// ReportCurrentLocationEventArgs 的摘要说明
    /// </summary>
    public class ReportCurrentLocationEventArgs:RoutedEventArgs
    {
        public ReportCurrentLocationEventArgs(RoutedEvent routedEvent,object source)
            :base(routedEvent,source)
        {

        }

        /// <summary>
        /// 按钮点击时间
        /// </summary>
        public DateTime ClickTime { get; set; }

        /// <summary>
        /// 到达当前位置
        /// </summary>
        public string CurrentLocation { get; set; }
    }
}
