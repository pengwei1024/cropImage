using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CropImage
{
    public partial class Main : BaseForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void imageSelectBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "PNG文件(*.png)|*.png|JPG文件(*.jpg)|*.jpg";
            if(fd.ShowDialog() == DialogResult.OK)
            {
                new showImage(fd.FileName).Show();
                this.Hide();
            }
        }
    }
}
