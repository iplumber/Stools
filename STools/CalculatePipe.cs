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

            SuspendLayout();
            inputDiameter = 300;
            inputVelocity = 1.0;
            inputSlope = 0.003;
            inputRoughness = 0.013;
            inputMaterial = "球磨铸铁管";

            radioButtonDiameter.Checked = true;
            listBoxRoughness.SelectedIndex = 0;
            listBoxPipeMaterial.SelectedIndex = 0;

            listBoxDiameter.SelectedIndex = 0;
            listBoxVelocity.SelectedIndex = 9;
            listBoxSlope.SelectedIndex = 2;

            //listBoxDiameter.Enabled = false;
            listBoxVelocity.Enabled = false;
            listBoxSlope.Enabled = false;

            ResumeLayout();
            //CalculateDiameterAndVelocityAndSlope();
        }
        public RainfallControl ParentDialog;
        public string totalFlowUnit;
        public double totalFlow;

        public double inputDiameter;
        public double inputVelocity;
        public double inputSlope;
        public double inputRoughness;
        public string inputMaterial;

        public void SetDesignRunoffFlowAndUnit(string flow, string _flowUnit)
        {
            textBoxDesignTotalRunoffFlow.Text = flow;
            labelTotalRunoffFlow.Text = "设计总径流量" + _flowUnit;

            totalFlow = Convert.ToDouble(flow);
            totalFlowUnit = _flowUnit;
        }

        public double GetDesignRunoffFlow()
        {
            return totalFlow;
        }

        public string GetDesignRunoffFlowUnit()
        {
            return totalFlowUnit;
        }

        private void listBoxDiameter_SelectedIndexChanged(object sender, EventArgs e)
        {
            inputDiameter = Convert.ToDouble(listBoxDiameter.SelectedItem.ToString());
            CalculateDiameterAndVelocityAndSlope();
        }

        private void listBoxVelocity_SelectedIndexChanged(object sender, EventArgs e)
        {
            inputVelocity = Convert.ToDouble(listBoxVelocity.SelectedItem.ToString());
            CalculateDiameterAndVelocityAndSlope();
        }

        private void listBoxSlope_SelectedIndexChanged(object sender, EventArgs e)
        {
            inputSlope = Convert.ToDouble(listBoxSlope.SelectedItem.ToString());
            CalculateDiameterAndVelocityAndSlope();
        }

        private void listBoxPipeMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxRoughness.SelectedItem = 0;
            CalculateDiameterAndVelocityAndSlope();
        }

        private void listBoxRoughness_SelectedIndexChanged(object sender, EventArgs e)
        {
            inputRoughness = Convert.ToDouble(listBoxRoughness.SelectedItem.ToString());
            CalculateDiameterAndVelocityAndSlope();
        }

        private void radioButtonDiameter_CheckedChanged(object sender, EventArgs e)
        {
            listBoxDiameter.Enabled = radioButtonDiameter.Checked;
        }

        private void radioButtonVelocity_CheckedChanged(object sender, EventArgs e)
        {
            listBoxVelocity.Enabled = radioButtonVelocity.Checked;
        }

        private void radioButtonSlope_CheckedChanged(object sender, EventArgs e)
        {
            listBoxSlope.Enabled = radioButtonSlope.Checked;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
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

        public void CalculateDiameterAndVelocityAndSlope()
        {
            Pipe pipe = new Pipe();
            textBoxPipeMaterial.Text = inputMaterial;
            pipe.roughness = inputRoughness;
            pipe.designTotalRunoffFlow_M3PerSecond = totalFlow;

            if (totalFlowUnit == "(L/s)")
            {
                pipe.designTotalRunoffFlow_M3PerSecond = totalFlow / 1000;
            }
            if (radioButtonDiameter.Checked)
            {
                pipe.diameter = inputDiameter / 1000;
                pipe.velocity = 4 * pipe.designTotalRunoffFlow_M3PerSecond / Math.PI / pipe.diameter / pipe.diameter;
                pipe.slope = Math.Pow(pipe.velocity * pipe.roughness / Math.Pow(0.25 * pipe.diameter, 2.0 / 3),2);
            }
            else if (radioButtonVelocity.Checked)
            {
                pipe.velocity = inputVelocity;
                pipe.diameter = Math.Sqrt(4 * pipe.designTotalRunoffFlow_M3PerSecond / Math.PI / pipe.velocity);
                pipe.diameter = CeilingDiameter(pipe.diameter);
                pipe.slope = Math.Pow(pipe.velocity * pipe.roughness / Math.Pow(0.25 * pipe.diameter, 2.0 / 3), 2);
            }
            else if (radioButtonSlope.Checked)
            {
                pipe.slope = inputSlope / 1000;
                pipe.diameter = Math.Pow(4 * pipe.roughness * pipe.designTotalRunoffFlow_M3PerSecond / 
                                         Math.Pow(0.25,2.0/3.0) / Math.Sqrt(pipe.slope) / Math.PI, 3.0/8.0);
                pipe.diameter = CeilingDiameter(pipe.diameter);
                pipe.velocity = 1.0 / pipe.roughness * Math.Pow(0.25 * pipe.diameter, 2.0 / 3.0) * Math.Sqrt(pipe.slope);
            }
            textBoxVelocity.Text = Convert.ToString(Math.Round(pipe.velocity, 2));
            textBoxSlope.Text = Convert.ToString(MathCeiling(pipe.slope * 1000, 1));
            textBoxDiameter.Text = Convert.ToString(Math.Round(pipe.diameter * 1000, 2));
            textBoxRoughness.Text = inputRoughness.ToString();
            textBoxConveyanceCapactiy.Text = Convert.ToString(Math.Round(CalculateConveryanceCapacity(pipe),2));
        }

        public void theFirstTimeCalculateDiameterAndSlope()
        {
            Pipe pipe = new Pipe();
            textBoxPipeMaterial.Text = inputMaterial;
            pipe.roughness = inputRoughness;
            pipe.designTotalRunoffFlow_M3PerSecond = totalFlow;

            if (totalFlowUnit == "(L/s)")
            {
                pipe.designTotalRunoffFlow_M3PerSecond = totalFlow / 1000;
            }
            pipe.velocity = 1.0;
            pipe.diameter = Math.Sqrt(4 * pipe.designTotalRunoffFlow_M3PerSecond / Math.PI / pipe.velocity);
            pipe.diameter = CeilingDiameter(pipe.diameter);
            pipe.velocity = 4 * pipe.designTotalRunoffFlow_M3PerSecond / Math.PI / pipe.diameter / pipe.diameter;
            pipe.slope = Math.Pow(pipe.velocity * pipe.roughness / Math.Pow(0.25 * pipe.diameter, 2.0 / 3), 2);

            textBoxVelocity.Text = Convert.ToString(Math.Round(pipe.velocity, 2));
            textBoxSlope.Text = Convert.ToString(MathCeiling(pipe.slope * 1000, 1));
            textBoxDiameter.Text = Convert.ToString(Math.Round(pipe.diameter * 1000, 2));
            textBoxRoughness.Text = inputRoughness.ToString();
            textBoxConveyanceCapactiy.Text = Convert.ToString(Math.Round(CalculateConveryanceCapacity(pipe), 2));
        }

        private double CeilingDiameter(double diameter)
        {
            if (diameter <= 0) return diameter;
            int diameterIndex = 0;
            while (diameter > Convert.ToDouble(listBoxDiameter.Items[diameterIndex].ToString()) / 1000)
            {
                diameterIndex++;
            }
            listBoxDiameter.SelectedIndex = diameterIndex;
            diameter = Convert.ToDouble(listBoxDiameter.Items[diameterIndex].ToString()) / 1000;
            return diameter;
        }

        public double MathCeiling(double data,int numberOfDecimalPlace)
        {
            if (numberOfDecimalPlace <= 0) return data;
            data = Math.Ceiling(data * Math.Pow(10, numberOfDecimalPlace));
            data = data / Math.Pow(10, numberOfDecimalPlace);
            return data;
        }

        public double CalculateConveryanceCapacity(Pipe _pipe)
        {
            double _roughness = Convert.ToDouble(textBoxRoughness.Text);
            double _diameter = Convert.ToDouble(textBoxDiameter.Text) / 1000;
            double _slope = Convert.ToDouble(textBoxSlope.Text) / 1000;
            _pipe.conveyanceCapactiy = 1.0 / _roughness * Math.Pow(0.25 * _diameter, 2.0 / 3) * Math.Sqrt(_slope) * 0.25 * Math.PI * _diameter * _diameter;
            return _pipe.conveyanceCapactiy;
        }

        private void textBoxDiameter_TextChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(textBoxDiameter.Text)) return;
            //try
            //{
            //    Pipe pipe = new Pipe();
            //    inputDiameter = Convert.ToDouble(textBoxDiameter.Text) / 1000;
            //    pipe.diameter = inputDiameter;
            //    pipe.velocity = Convert.ToDouble(textBoxVelocity.Text);
            //    pipe.slope = Convert.ToDouble(textBoxSlope.Text) / 1000;
            //    pipe.roughness = Convert.ToDouble(textBoxRoughness.Text);
            //    if (inputDiameter < 0)
            //    {
            //        MessageBox.Show("请输入正确的管径。");
            //    }
            //    textBoxConveyanceCapactiy.Text = Convert.ToString(Math.Round(CalculateConveryanceCapacity(pipe), 2));
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show(err.Message);  //目前这个错误信息未显示是否地面流行时间还是重现期，也没给出输入数据的范围。
            //}
        }

        private void textBoxVelocity_TextChanged(object sender, EventArgs e)
        {
            //Pipe pipe = new Pipe();
            //pipe.diameter = Convert.ToDouble(textBoxDiameter.Text) / 1000;
            //pipe.velocity = Convert.ToDouble(textBoxVelocity.Text);
            //pipe.slope = Convert.ToDouble(textBoxSlope.Text) / 1000;
            //pipe.roughness = Convert.ToDouble(textBoxRoughness.Text);
            //if (pipe.velocity < 0)
            //{
            //    MessageBox.Show("请输入正确的管径。");
            //}
            //textBoxConveyanceCapactiy.Text = Convert.ToString(Math.Round(CalculateConveryanceCapacity(pipe), 2));
        }

        private void textBoxSlope_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRoughness_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class Pipe
    {
        public double designTotalRunoffFlow_M3PerSecond;
        public double conveyanceCapactiy;
        public double diameter;
        public double velocity;
        public double slope;
        public double roughness;
        public string material;
    }
}
