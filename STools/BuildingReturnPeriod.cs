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
    public partial class BuildingReturnPeriod : UserControl
    {
        public BuildingReturnPeriod()
        {
            InitializeComponent();
        }

        private void radioButtonZone_CheckedChanged(object sender, EventArgs e)
        {
            textBoxZone.ReadOnly = !radioButtonZone.Checked;
        }

        private void radioButtonStation_CheckedChanged(object sender, EventArgs e)
        {
            textBoxStation.ReadOnly = !radioButtonStation.Checked;
        }

        private void radioButtonSunkenSquare_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSunkenSquare.ReadOnly = !radioButtonSunkenSquare.Checked;
        }

        private void radioButtonCommonRoof_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCommonRoof.ReadOnly = !radioButtonCommonRoof.Checked;
        }

        private void radioButtonImportantRoof_CheckedChanged(object sender, EventArgs e)
        {
            textBoxImportantRoof.ReadOnly = !radioButtonImportantRoof.Checked;
        }

        public int GetReturnPeriodData()
        {
            int buildingReturnPeriod = 0;
            if (radioButtonZone.Checked) int.TryParse(textBoxZone.Text, out buildingReturnPeriod);
            if (radioButtonStation.Checked) int.TryParse(textBoxStation.Text, out buildingReturnPeriod);
            if (radioButtonSunkenSquare.Checked) int.TryParse(textBoxSunkenSquare.Text, out buildingReturnPeriod);
            if (radioButtonCommonRoof.Checked) int.TryParse(textBoxCommonRoof.Text, out buildingReturnPeriod);
            if (radioButtonImportantRoof.Checked) int.TryParse(textBoxImportantRoof.Text, out buildingReturnPeriod);

            return buildingReturnPeriod;
        }
    }
}
