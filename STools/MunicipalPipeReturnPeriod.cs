using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STools
{
    public partial class MunicipalPipeReturnPeriod : UserControl
    {
        public MunicipalPipeReturnPeriod()
        {
            InitializeComponent();
        }

        public string[] periodArray;

        private void listBoxTypeOfCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            periodArray = new string[4];
            switch (listBoxTypeOfCity.SelectedIndex)
            {
                case 0:
                    periodArray[0] = "3~5";
                    periodArray[1] = "2~3";
                    periodArray[2] = "5~10";
                    periodArray[3] = "30~50";
                    break;
                case 1:
                    periodArray[0] = "2~5";
                    periodArray[1] = "2~3";
                    periodArray[2] = "5~10";
                    periodArray[3] = "20~30";
                    break;
                case 2:
                    periodArray[0] = "2~3";
                    periodArray[1] = "2~3";
                    periodArray[2] = "3~5";
                    periodArray[3] = "10~20";
                    break;
            }
            UpdatePeriod();
        }

        private void listBoxTypeOfRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePeriod();
        }

        private void UpdatePeriod()
        {
            if (listBoxTypeOfRegion.SelectedIndex >= 0 && listBoxTypeOfCity.SelectedIndex >= 0)
            {
                textBoxRecommendReturnPeriod.Text = periodArray[listBoxTypeOfRegion.SelectedIndex];
            }
        }

        public int GetReturnPeriodData()
        {
            int municipalReturnPeriod = 0;
            int.TryParse(textBoxDesignReturnPeriod.Text, out municipalReturnPeriod);
            return municipalReturnPeriod;
        }
    }
}
