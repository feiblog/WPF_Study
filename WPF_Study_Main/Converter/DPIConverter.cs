#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 版权所有 (c) 2022  NJRN 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：PAN-FEI-1996
 * 公司名称：
 * 命名空间：WPF_Study_Main.Converter
 * 唯一标识：81d87598-10ab-475f-9dd7-82953acae773
 * 文件名：DPIConverter
 * 当前用户域：PAN-FEI-1996
 * 
 * 创建者：pfei
 * 电子邮箱：PFEI1214@163.com
 * 创建时间：2022/10/21 14:05:53
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
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WPF_Study_Main.Converter
{
    /// <summary>
    /// DPIConverter 的摘要说明
    /// </summary>
    /// 
    [ValueConversion(typeof(object), typeof(object))]
    public class DPIConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double dpiXRatio = GlobalHelper.GetDpiScaling();
            if (targetType == typeof(GridLength))
            {
                double data = double.Parse(parameter.ToString());
                GridLength gridLength = new GridLength(data / dpiXRatio, GridUnitType.Pixel);
                return gridLength;
            }
            if (targetType == typeof(Thickness))
            {
                Thickness margin = (Thickness)parameter;
                if (margin != null)
                {
                    margin.Top = margin.Top / dpiXRatio;
                    margin.Left = margin.Left / dpiXRatio;
                    margin.Right = margin.Right / dpiXRatio;
                    margin.Bottom = margin.Bottom / dpiXRatio;
                    return margin;
                }
            }
            if (targetType == typeof(double))
            {
                double fontSize = double.Parse(parameter.ToString());
                return fontSize / dpiXRatio;
            }

            if (targetType == typeof(System.Windows.Point))
            {
                System.Windows.Point point = (System.Windows.Point)parameter;
                point.X = point.X / dpiXRatio;
                point.Y = point.Y / dpiXRatio;
                return point;
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
