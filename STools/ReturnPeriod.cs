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
    public partial class formReturnPeriod : Form
    {
        public formReturnPeriod()
        {
            InitializeComponent();
            //pictureBoxRetrunPeriod.Image = Image.FromFile(@"D:\code\WindowsFormsApplication1\GB50014-2006(2016)3.2.3.png");
            //pictureBoxRetrunPeriod.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public RainfallControl ParentDialog;
        public double returnPeriod;

        private void ReturnPeriod_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if(tabControlReturnPeriod.SelectedTab.Name == "tabPageBuilding")
            {
                int period = buildingReturnPeriod.GetReturnPeriodData();
                ParentDialog.SetReturnPeriod(period);
            }
            else if(tabControlReturnPeriod.SelectedTab.Name == "tabPageMunicipalPipe")
            {
                int period = municipalPipeReturnPeriod.GetReturnPeriodData();
                ParentDialog.SetReturnPeriod(period);
            }
            else if(tabControlReturnPeriod.SelectedTab.Name == "tabPageUrbanFlood")
            {
                int period = urbanFloodReturnPeriod.GetReturnPeriodData();
                ParentDialog.SetReturnPeriod(period);
            }
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
