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
    public partial class UrbanFloodReturnPeriod : UserControl
    {
        public UrbanFloodReturnPeriod()
        {
            InitializeComponent();
            radioButtonMegacity.Checked = true;
        }

        private void radioButtonMegacity_CheckedChanged(object sender, EventArgs e)
        {
            textBoxMegacity.ReadOnly = !radioButtonMegacity.Checked;
        }

        private void radioButtonSupercity_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSupercity.ReadOnly = !radioButtonSupercity.Checked;
        }

        private void radioButtonBigcity_CheckedChanged(object sender, EventArgs e)
        {
            textBoxBigcity.ReadOnly = !radioButtonBigcity.Checked;
        }

        private void radioButtonMediumAndSmallcity_CheckedChanged(object sender, EventArgs e)
        {
            textBoxMediumAndSmallcity.ReadOnly = !radioButtonMediumAndSmallcity.Checked;
        }

        public int GetReturnPeriodData()
        {
            int urbanFloodPeriod = 0;
            if (radioButtonMegacity.Checked) int.TryParse(textBoxMegacity.Text, out urbanFloodPeriod);
            if (radioButtonSupercity.Checked) int.TryParse(textBoxSupercity.Text, out urbanFloodPeriod);
            if (radioButtonBigcity.Checked) int.TryParse(textBoxBigcity.Text, out urbanFloodPeriod);
            if (radioButtonMediumAndSmallcity.Checked) int.TryParse(textBoxMediumAndSmallcity.Text, out urbanFloodPeriod);
            return urbanFloodPeriod;
        }
    }
}
