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
    public partial class RunoffCoefficient : Form
    {
        public RunoffCoefficient()
        {
            InitializeComponent();
        }

        public RainfallControl ParentDialog;

        public double totalArea;
        public double weightedRunoffCoefficient;

        private void buttonApply_Click(object sender, EventArgs e)
        {
            calTatalArea();
            textBoxTotalArea.Text = totalArea.ToString();

            calWeightedRunoffCoefficient();
            textBoxWeightedRunoffCoefficient.Text = Math.Round(weightedRunoffCoefficient, 3).ToString();

            ParentDialog.SetTotalArea(totalArea);
            ParentDialog.SetWeightedRunoffCoefficient(weightedRunoffCoefficient);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            calTatalArea();
            textBoxTotalArea.Text = totalArea.ToString();

            calWeightedRunoffCoefficient();
            textBoxWeightedRunoffCoefficient.Text = Math.Round(weightedRunoffCoefficient, 3).ToString();

            ParentDialog.SetTotalArea(totalArea);
            ParentDialog.SetWeightedRunoffCoefficient(weightedRunoffCoefficient);

            this.Close();
        }

        private void calTatalArea()
        {
            try
            {
                totalArea = Convert.ToDouble(textBoxRoofArea.Text)
                           + Convert.ToDouble(textBoxConcreteOrAsphaltPavedArea.Text)
                           + Convert.ToDouble(textBoxBlockStonePavedArea.Text)
                           + Convert.ToDouble(textBoxGradationStonePavedArea.Text)
                           + Convert.ToDouble(textBoxGravelPavedArea.Text)
                           + Convert.ToDouble(textBoxNonPavedArea.Text)
                           + Convert.ToDouble(textBoxParkArea.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void calWeightedRunoffCoefficient()
        {
            try
            {
                weightedRunoffCoefficient =
                    (Convert.ToDouble(textBoxRoofCoeff.Text) * Convert.ToDouble(textBoxRoofArea.Text)
                    + Convert.ToDouble(textBoxConcreteOrAsphaltPavedCoeff.Text) * Convert.ToDouble(textBoxConcreteOrAsphaltPavedArea.Text)
                    + Convert.ToDouble(textBoxBlockStonePavedCoeff.Text) * Convert.ToDouble(textBoxBlockStonePavedArea.Text)
                    + Convert.ToDouble(textBoxGradationStonePavedCoeff.Text) * Convert.ToDouble(textBoxGradationStonePavedArea.Text)
                    + Convert.ToDouble(textBoxGravelPavedCoeff.Text) * Convert.ToDouble(textBoxGravelPavedArea.Text)
                    + Convert.ToDouble(textBoxNonPavedCoeff.Text) * Convert.ToDouble(textBoxNonPavedArea.Text)
                    + Convert.ToDouble(textBoxParkCoeff.Text) * Convert.ToDouble(textBoxParkArea.Text)
                    ) / Convert.ToDouble(textBoxTotalArea.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RunoffCoefficient_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
