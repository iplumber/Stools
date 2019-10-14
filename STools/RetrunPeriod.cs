using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STools
{
    public partial class RetrunPeriod : Form
    {
        public RetrunPeriod()
        {
            InitializeComponent();
            pictureBoxRetrunPeriod.Image = Image.FromFile(@"D:\code\WindowsFormsApplication1\GB50014-2006(2016)3.2.3.png");
            pictureBoxRetrunPeriod.SizeMode = PictureBoxSizeMode.Zoom;
        }
        
    }
}
