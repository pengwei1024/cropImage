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
    public class BaseForm : Form
    {

        /// <summary>
        /// 弹出框
        /// </summary>
        /// <param name="value"></param>
        protected void showBox(Object value)
        {
            MessageBox.Show(value.ToString());
        }

        /// <summary>
        /// 是否为空
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        protected bool isEmpty(String value)
        {
            return value == null || value.Trim().Length <= 0;
        }

    }

    
}
