#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 版权所有 (c) 2022  NJRN 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：PAN-FEI-1996
 * 公司名称：
 * 命名空间：WPF_Study_Main
 * 唯一标识：fb3a58da-d569-4043-a0e4-14d82c4096d2
 * 文件名：GlobalVariable
 * 当前用户域：PAN-FEI-1996
 * 
 * 创建者：pfei
 * 电子邮箱：PFEI1214@163.com
 * 创建时间：2022/10/21 10:22:27
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

namespace WPF_Study_Main
{
    /// <summary>
    /// GlobalVariable 的摘要说明
    /// </summary>
    public class GlobalVariable
    {
        /// <summary>
        /// 所有页面
        // 添加页面的Uri地址，采用相对路径，根路径是项目名,实现allViews的初始化
        /// </summary>
        public static Dictionary<string, Uri> AllViews = new Dictionary<string, Uri>()
        {
            { "Home", new Uri("Pages/HomePage.xaml", UriKind.Relative)},
            { "SystemSetting", new Uri("Pages/SystemSettingPage.xaml", UriKind.Relative)},
            { "PictureProcessing", new Uri("Pages/ImagePage.xaml", UriKind.Relative)}
        };
    }
}
