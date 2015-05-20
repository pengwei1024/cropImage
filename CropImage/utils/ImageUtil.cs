using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CropImage.utils
{
    class ImageUtil
    {
        /// <summary>
        /// 设置图片尺寸
        /// </summary>
        /// <param name="imagePath"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public static void ResizePic(String imagePath, int width, int height)
        {
            Image image = Image.FromFile(imagePath);
            Bitmap bmp = new Bitmap(width, height);
            //从Bitmap创建一个System.Drawing.Graphics 
            System.Drawing.Graphics gr = System.Drawing.Graphics.FromImage(bmp);
            //设置  
            gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //下面这个也设成高质量 
            gr.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            //下面这个设成High 
            gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            //把原始图像绘制成上面所设置宽高的缩小图 
            System.Drawing.Rectangle rectDestination = new System.Drawing.Rectangle(0, 0, width, height);
            gr.DrawImage(image, rectDestination, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel);
            String newFileName = imagePath.Substring(0, imagePath.LastIndexOf('\\') + 1);
            newFileName += System.IO.Path.GetFileNameWithoutExtension(imagePath) + "_" + width + "_" + height + ".png";
            bmp.Save(newFileName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mimeType"></param>
        /// <returns></returns>
        private static ImageCodecInfo GetImageCodeInfo(string mimeType)
        {
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (int i = 0; i < encoders.Length; i++)
            {
                if (encoders[i].MimeType == mimeType)
                    return encoders[i];
            }
            return null;
        }
    }
}
