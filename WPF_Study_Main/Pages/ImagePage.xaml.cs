using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
//using System.Windows.Shapes;
using Image = System.Drawing.Image;
using PixelFormat = System.Drawing.Imaging.PixelFormat;
using Rectangle = System.Drawing.Rectangle;

namespace WPF_Study_Main.Pages
{
    /// <summary>
    /// ImagePage.xaml 的交互逻辑
    /// </summary>
    public partial class ImagePage : Page
    {
        public ImagePage()
        {
            InitializeComponent();
        }

        private void BtnOpen_Click(object sender, RoutedEventArgs e)
        {
            Bitmap bitmap = LoadImageClip(@"C:\Users\pfei1\Desktop\20220521_143232\Images\0_0_0.tif");
            WriteableBitmap image = DrawImage(bitmap);
            imageIconL.Source = image;
            imageIconR.Source = image;
            //BitmapImage bmp = new BitmapImage(new Uri(@"C:\Users\pfei1\Desktop\20220521_143232\Images\0_0_0.tif"));
            //imageIconL.Source = bmp;
            //imageIconR.Source = bmp;
        }
        public WriteableBitmap DrawImage(Bitmap bit)
        {
            WriteableBitmap wb = new WriteableBitmap(1824, 1824, 96, 96, PixelFormats.Pbgra32, null);  // SET DPI
            wb.Lock();
            using (Bitmap backBitmap = new Bitmap((int)wb.Width, (int)wb.Height,
                wb.BackBufferStride, PixelFormat.Format32bppPArgb,
                wb.BackBuffer))
            {
                backBitmap.SetResolution(96, 96);
                using (Graphics graphics = Graphics.FromImage(backBitmap))
                {
                    RectangleF rec = new RectangleF(0, 0, 1824, 1824);

                    if (bit.PixelFormat != PixelFormat.Format24bppRgb)
                        bit = bit.Clone(new Rectangle(0, 0, bit.Width, bit.Height), PixelFormat.Format24bppRgb);
                    BitmapData img_src_data = bit.LockBits(new Rectangle(0, 0, bit.Width, bit.Height), ImageLockMode.ReadWrite, bit.PixelFormat);
                    //IntPtr img_dst_data = img_src_data.Scan0;
                    //CalculateHelper.ImageRemoveNoise(img_dst_data, img_src_data.Height, img_src_data.Stride);  // 去噪点
                    bit.UnlockBits(img_src_data);

                    graphics.DrawImage(bit, rec);
                    graphics.Flush();
                    wb.AddDirtyRect(new System.Windows.Int32Rect(0, 0, (int)wb.Width, (int)wb.Height));
                    graphics.Dispose();
                    //Marshal.Release(img_dst_data);
                }
                bit.Dispose();
                wb.Unlock();
                backBitmap.Dispose();
                //WriteableBitmap wBitmap = new WriteableBitmap(GetMapSource(bit));
            }


            return wb;
        }

        public static Bitmap LoadImageClip(string filename)
        {
            Bitmap Bit = new Bitmap(1824, 1824);  // SET DPI
            Bit.SetResolution(96, 96);
            Image ima = Image.FromFile(filename);
            using (Graphics graphics = Graphics.FromImage(Bit))
            {
                int clipWidth = (ima.Width - 1824) / 2;//裁剪位置
                graphics.DrawImage(ima, 0, 0, new Rectangle(clipWidth, 0, 1824, 1824), GraphicsUnit.Pixel);
                graphics.Dispose();
                ima.Dispose();
            }
            return Bit;
        }
    }
}
