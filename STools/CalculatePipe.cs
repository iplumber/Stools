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
    public partial class CalculatePipe : Form
    {
        public CalculatePipe()
        {
            InitializeComponent();

            listBoxPipeMaterial.SelectedIndex = 0;
            listBoxRoughness.SelectedItem = 0;

            listBoxDiameter.SelectedIndex = 0;
            listBoxVelocity.SelectedIndex = 9;
            listBoxSlope.SelectedIndex = 2;

            listBoxDiameter.Enabled = false;
            textBoxInputDiameter.Enabled = false;

            listBoxVelocity.Enabled = false;
            textBoxInputVelocity.Enabled = false;

            listBoxSlope.Enabled = false;
            textBoxInputSlope.Enabled = false;
        }
        public RainfallControl ParentDialog;

        public string material;
        public double roughness;
        public double velocity;
        public double slope;
        public double diameter;

        public double designRunoffFlow;
        public double conveyanceFlow;

        public void SetDesignRunoffFlow(string flow)
        {
           textBoxDesignRunoffFlow.Text = flow;
        }

        private void listBoxDiameter_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxInputDiameter.Text = listBoxDiameter.SelectedItem.ToString();
        }

        private void listBoxVelocity_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxInputVelocity.Text = listBoxVelocity.SelectedItem.ToString();
        }

        private void listBoxSlope_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxInputSlope.Text = listBoxSlope.SelectedItem.ToString();
        }

        private void radioButtonDiameter_CheckedChanged(object sender, EventArgs e)
        {
            listBoxDiameter.Enabled = radioButtonDiameter.Checked;
            textBoxInputDiameter.Enabled = radioButtonDiameter.Checked;
        }

        private void radioButtonVelocity_CheckedChanged(object sender, EventArgs e)
        {
            listBoxVelocity.Enabled = radioButtonVelocity.Checked;
            textBoxInputVelocity.Enabled = radioButtonVelocity.Checked;
        }

        private void radioButtonSlope_CheckedChanged(object sender, EventArgs e)
        {
            listBoxSlope.Enabled = radioButtonSlope.Checked;
            textBoxInputSlope.Enabled = radioButtonSlope.Checked;
        }

        private void listBoxPipeMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxRoughness.SelectedItem = 0;
        }

        private void listBoxRoughness_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxInputRoughness.Text = listBoxRoughness.SelectedItem.ToString();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalculatePipe_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void CalculateDiameterAndVelocityAndSlope()
        {
            CalculatePipe pipe = new CalculatePipe();
            textBoxPipeMaterial.Text = listBoxPipeMaterial.SelectedItem.ToString();
            pipe.diameter = Convert.ToDouble(textBoxInputDiameter.Text) / 1000;
            pipe.designRunoffFlow = Convert.ToDouble(text)
            if (radioButtonDiameter.Enabled)
            {
                pipe.velocity = 4 * pipe.designRunoffFlow / Math.PI / pipe.diameter / pipe.diameter;
                textBoxVelocity.Text = pipe.velocity.ToString();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            CalculateDiameterAndVelocityAndSlope();
        }
    }
}
