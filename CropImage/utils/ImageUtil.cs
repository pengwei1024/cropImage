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
        public static bool ResizePic(String imagePath, int width, int height)
        {
            Image image = Image.FromFile(imagePath);
            Image thumnailImg = image.GetThumbnailImage(width, height, null, IntPtr.Zero);
            ImageCodecInfo imgCodeInfo = GetImageCodeInfo("image/jpeg");
            if (imgCodeInfo != null)
            {
                EncoderParameters encodeParameters = new EncoderParameters(1);
                encodeParameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, (long)100);
                Bitmap bmp = new Bitmap(thumnailImg);
                encodeParameters.Dispose();
                encodeParameters = null;
                String newFileName = imagePath.Substring(0, imagePath.LastIndexOf('\\') + 1);
                newFileName += System.IO.Path.GetFileNameWithoutExtension(imagePath)+"_"+width+"_"+height+".png";
                bmp.Save(newFileName, imgCodeInfo, encodeParameters);
                return true;
            }
            return false;
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
