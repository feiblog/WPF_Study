#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 版权所有 (c) 2022  NJRN 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：PAN-FEI-1996
 * 公司名称：
 * 命名空间：WPF_Study_Main.Styles.BaseControl
 * 唯一标识：7511c682-8e7e-4f13-8362-4164b46659fa
 * 文件名：BaseButton
 * 当前用户域：PAN-FEI-1996
 * 
 * 创建者：pfei
 * 电子邮箱：PFEI1214@163.com
 * 创建时间：2022/10/24 15:52:57
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
using System.Windows.Controls;
using System.Windows.Media;

namespace WPF_Study_Main.Styles.BaseControl
{
    /// <summary>
    /// BaseButton 的摘要说明
    /// </summary>
    public class BaseButton:Button
    {
        #region <图标>
        public static readonly DependencyProperty IconProperty = DependencyProperty.Register
            ("Icon", typeof(ImageSource), typeof(BaseButton), new PropertyMetadata(null, new PropertyChangedCallback((obj, args) => { })));
        /// <summary>
        /// 图标
        /// </summary>
        public ImageSource Icon
        {
            get { return (ImageSource)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }
        #endregion <图标>

        #region <文字>
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register
            ("Text", typeof(string), typeof(BaseButton), new PropertyMetadata(null, new PropertyChangedCallback((obj, args) => { })));
        /// <summary>
        /// 文字
        /// </summary>
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
        #endregion <文字>

        #region <提示文字>

        #endregion
    }
}
