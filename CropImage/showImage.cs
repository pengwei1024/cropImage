using CropImage.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CropImage
{
    public partial class showImage : BaseForm
    {

        private String path;
        public showImage()
        {
            InitializeComponent();
            tip.Text = "请输入需要转化的分辨率并用';'分离,如96*96;128*128";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isEmpty(path))
            {
                String text = inputBox.Text;
                string[] c = text.Split(new char[] { ';' });
                if (!isEmpty(text) && c.Length > 0)
                {
                    Regex reg = new Regex("\\d+\\*\\d+");
                    bool success = false;
                    foreach (String str in c)
                    {
                        if (reg.IsMatch(str))
                        {
                            string[] sizes = str.Split(new char[] { '*' });
                            int width = int.Parse(sizes[0]);
                            int height = int.Parse(sizes[1]);
                            //showBox(width + "*" + height);
                            ImageUtil.ResizePic(path, width, height);
                            success = true;
                        }
                    }
                    if (success)
                    {
                        showBox("转化成功");
                    }
                    else
                    {
                        showBox("转化出现异常");
                    }

                }
                else
                {
                    showBox("请输入分辨率");
                    inputBox.Focus();
                }
            }else
            {
                showBox("请先选择图片");
            }
        }

        /// <summary>
        /// 选择图片文件打开
        /// </summary>
        private void openImageFile()
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "图像文件 (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                path = fd.FileName;
                Image pic = Image.FromFile(path);
                pictureBox.Image = pic;
                paramTip.Text = "W:"+pic.Width+"px\nH:"+pic.Height+"px\n";
            }
        }

        private void 打开ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openImageFile();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.apkfuns.com?source=cropImage");
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            openImageFile();
        }
    }
}
