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
            //inputDiameter = 300;
            //inputVelocity = 1.0;
            //inputSlope = 0.003;
            //inputRoughness = 0.013;
            //inputMaterial = "球磨铸铁管";

            radioButtonDiameter.Checked = true;
            listBoxPipeMaterial.SelectedIndex = 4;
            listBoxRoughness.SelectedIndex = 4;

            listBoxDiameter.SelectedIndex = 6;
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
            inputMaterial = listBoxPipeMaterial.SelectedItem.ToString();
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
            if (radioButtonDiameter.Checked || radioButtonVelocity.Checked || radioButtonSlope.Checked)
                checkBoxUserDefine.Checked = false;
        }

        private void radioButtonVelocity_CheckedChanged(object sender, EventArgs e)
        {
            listBoxVelocity.Enabled = radioButtonVelocity.Checked;
            if (radioButtonDiameter.Checked || radioButtonVelocity.Checked || radioButtonSlope.Checked)
                checkBoxUserDefine.Checked = false;
        }

        private void radioButtonSlope_CheckedChanged(object sender, EventArgs e)
        {
            listBoxSlope.Enabled = radioButtonSlope.Checked;
            if (radioButtonDiameter.Checked || radioButtonVelocity.Checked || radioButtonSlope.Checked)
                checkBoxUserDefine.Checked = false;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            Pipe pipe = new Pipe();

            pipe.conveyanceCapactiy = Convert.ToDouble(textBoxConveyanceCapactiy.Text);
            pipe.diameter = Convert.ToDouble(textBoxDiameter.Text);
            pipe.velocity = Convert.ToDouble(textBoxVelocity.Text);
            pipe.slope = Convert.ToDouble(textBoxSlope.Text);
            pipe.roughness = Convert.ToDouble(textBoxRoughness.Text);
            pipe.material = textBoxPipeMaterial.Text;

            ParentDialog.SetPipe(pipe);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Pipe pipe = new Pipe();

            pipe.conveyanceCapactiy = Convert.ToDouble(textBoxConveyanceCapactiy.Text);
            pipe.diameter = Convert.ToDouble(textBoxDiameter.Text);
            pipe.velocity = Convert.ToDouble(textBoxVelocity.Text);
            pipe.slope = Convert.ToDouble(textBoxSlope.Text);
            pipe.roughness = Convert.ToDouble(textBoxRoughness.Text);
            pipe.material = textBoxPipeMaterial.Text;

            ParentDialog.SetPipe(pipe);
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
                pipe.velocity = Calculate_v_By_Q_D(pipe.designTotalRunoffFlow_M3PerSecond, pipe.diameter);
                pipe.slope = Calculate_i_By_n_v_D(pipe.roughness, pipe.velocity, pipe.diameter);
            }
            else if (radioButtonVelocity.Checked)
            {
                pipe.velocity = inputVelocity;
                pipe.diameter = Calculate_D_By_Q_v(pipe.designTotalRunoffFlow_M3PerSecond, pipe.velocity);
                pipe.diameter = CeilingDiameter(pipe.diameter);
                pipe.slope = Calculate_i_By_n_v_D(pipe.roughness, pipe.velocity, pipe.diameter);
            }
            else if (radioButtonSlope.Checked)
            {
                pipe.slope = inputSlope / 1000;
                pipe.diameter = Calculate_D_By_n_Q_i(pipe.roughness, pipe.designTotalRunoffFlow_M3PerSecond, pipe.slope);
                pipe.diameter = CeilingDiameter(pipe.diameter);
                pipe.velocity = Calculate_v_By_n_D_i(pipe.roughness, pipe.diameter, pipe.slope);
            }

            if (checkBoxUserDefine.Checked == true)
            {
                double.TryParse(textBoxUserDefineDiameter.Text, out pipe.diameter);
                pipe.diameter = pipe.diameter / 1000.0;
                //double.TryParse(textBoxUserDefineVelocity.Text, out pipe.velocity);
                double.TryParse(textBoxUserDefineSlope.Text, out pipe.slope);
                pipe.slope = pipe.slope / 1000.0;
                double.TryParse(textBoxUserDefineRoughness.Text, out pipe.roughness);
                pipe.velocity = Calculate_v_By_n_D_i(pipe.roughness, pipe.diameter, pipe.slope);
                textBoxUserDefineVelocity.Text = Convert.ToString(Math.Round(pipe.velocity, 2));
            }

            textBoxRoughness.Text = pipe.roughness.ToString();
            textBoxVelocity.Text = Convert.ToString(Math.Round(pipe.velocity, 2));
            textBoxSlope.Text = Convert.ToString(MathCeiling(pipe.slope * 1000, 1));
            textBoxDiameter.Text = Convert.ToString(Math.Round(pipe.diameter * 1000, 2));
            textBoxPipeMaterial.Text = inputMaterial;
            double converyanceCapacity = CalculateConveryanceCapacity(pipe);
            if (converyanceCapacity >= 1.0)
            {
                labelConveyanceCapactiy.Text = "管道过流能力" + "(m^3/s)";
            }
            else
            {
                labelConveyanceCapactiy.Text = "管道过流能力" + "(L/s)";
                converyanceCapacity = converyanceCapacity * 1000;
            }
            textBoxConveyanceCapactiy.Text = Convert.ToString(Math.Round(converyanceCapacity, 2));
        }

        public double Calculate_v_By_Q_D(double flow, double diameter)
        {
            double velocity = 4 * flow / Math.PI / diameter / diameter; 
            return velocity;
        }
        public double Calculate_v_By_n_D_i(double roughness, double diameter, double slope)
        {
            double velocity = 1.0 / roughness * Math.Pow(0.25 * diameter, 2.0 / 3.0) * Math.Sqrt(slope);
            return velocity;
        }

        public double Calculate_D_By_Q_v(double flow, double velocity)
        {
            double diameter = Math.Sqrt(4 * flow / Math.PI / velocity); ;
            return diameter;
        }

        public double Calculate_D_By_n_Q_i(double roughness, double flow, double slope)
        {
            double diameter = Math.Pow(4 * roughness * flow / Math.Pow(0.25, 2.0 / 3.0) / Math.Sqrt(slope) / Math.PI, 3.0 / 8.0);
            return diameter;
        }

        public double Calculate_i_By_n_v_D(double roughness, double velocity, double diameter)
        {
            double slope = Math.Pow(velocity * roughness / Math.Pow(0.25 * diameter, 2.0 / 3), 2);
            return slope;
        }

        public void TheFirstTimeCalculateDiameterAndSlope()
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
            pipe.diameter = Calculate_D_By_Q_v(pipe.designTotalRunoffFlow_M3PerSecond, pipe.velocity);
            pipe.diameter = CeilingDiameter(pipe.diameter);
            pipe.velocity = Calculate_v_By_Q_D(pipe.designTotalRunoffFlow_M3PerSecond, pipe.diameter);
            pipe.slope = Calculate_i_By_n_v_D(pipe.roughness, pipe.velocity, pipe.diameter);

            textBoxRoughness.Text = pipe.roughness.ToString();
            textBoxVelocity.Text = Convert.ToString(Math.Round(pipe.velocity, 2));
            textBoxSlope.Text = Convert.ToString(MathCeiling(pipe.slope * 1000, 1));
            textBoxDiameter.Text = Convert.ToString(Math.Round(pipe.diameter * 1000, 2));

            double converyanceCapacity = CalculateConveryanceCapacity(pipe);
            if (converyanceCapacity >= 1.0)
            {
                labelConveyanceCapactiy.Text = "管道过流能力" + "(m^3/s)";
            }
            else
            {
                labelConveyanceCapactiy.Text = "管道过流能力" + "(L/s)";
                converyanceCapacity = converyanceCapacity * 1000;
            }
            textBoxConveyanceCapactiy.Text = Convert.ToString(Math.Round(converyanceCapacity, 2));
        }

        private double CeilingDiameter(double diameter)
        {
            if (diameter <= 0) return diameter;
            int diameterIndex = 0;
            double diameterCeiling = Convert.ToDouble(listBoxDiameter.Items[diameterIndex].ToString()) / 1000;
            while ((diameter > diameterCeiling)
                   && (diameterIndex < listBoxDiameter.Items.Count - 1 ))
            {
                diameterIndex++;
                diameterCeiling = Convert.ToDouble(listBoxDiameter.Items[diameterIndex].ToString()) / 1000;
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
            //    pipe.diameter = Convert.ToDouble(textBoxDiameter.Text) / 1000;
            //    //pipe.velocity = Convert.ToDouble(textBoxVelocity.Text);
            //    pipe.slope = Convert.ToDouble(textBoxSlope.Text) / 1000;
            //    pipe.roughness = Convert.ToDouble(textBoxRoughness.Text);
            //    if (pipe.diameter < 0)
            //    {
            //        MessageBox.Show("请输入正确的管径。");
            //    }
            //    pipe.velocity = 4 * pipe.designTotalRunoffFlow_M3PerSecond / Math.PI / pipe.diameter / pipe.diameter;
            //    //textBoxVelocity.Text = pipe.velocity.ToString();
            //    textBoxConveyanceCapactiy.Text = Convert.ToString(Math.Round(CalculateConveryanceCapacity(pipe), 2));
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show(err.Message);  //目前这个错误信息未显示是否地面流行时间还是重现期，也没给出输入数据的范围。
            //}
        }

        private void textBoxVelocity_TextChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(textBoxVelocity.Text)) return;
            //try
            //{
            //    Pipe pipe = new Pipe();
            //    pipe.diameter = Convert.ToDouble(textBoxDiameter.Text) / 1000;
            //    pipe.velocity = Convert.ToDouble(textBoxVelocity.Text);
            //    pipe.slope = Convert.ToDouble(textBoxSlope.Text) / 1000;
            //    pipe.roughness = Convert.ToDouble(textBoxRoughness.Text);
            //    if (pipe.velocity < 0)
            //    {
            //        MessageBox.Show("请输入正确的流速。");
            //    }
            //    textBoxConveyanceCapactiy.Text = Convert.ToString(Math.Round(CalculateConveryanceCapacity(pipe), 2));
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show(err.Message);  //目前这个错误信息未显示是否地面流行时间还是重现期，也没给出输入数据的范围。
            //}
        }

        private void textBoxSlope_TextChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(textBoxVelocity.Text)) return;
            //try
            //{
            //    Pipe pipe = new Pipe();
            //    pipe.diameter = Convert.ToDouble(textBoxDiameter.Text) / 1000;
            //    pipe.velocity = Convert.ToDouble(textBoxVelocity.Text);
            //    pipe.slope = Convert.ToDouble(textBoxSlope.Text) / 1000;
            //    pipe.roughness = Convert.ToDouble(textBoxRoughness.Text);
            //    if (pipe.velocity < 0)
            //    {
            //        MessageBox.Show("请输入正确的流速。");
            //    }
            //    textBoxConveyanceCapactiy.Text = Convert.ToString(Math.Round(CalculateConveryanceCapacity(pipe), 2));
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show(err.Message);  //目前这个错误信息未显示是否地面流行时间还是重现期，也没给出输入数据的范围。
            //}
        }

        private void textBoxRoughness_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxUserDefine_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUserDefine.Checked == true)
            {
                radioButtonDiameter.Checked = false;
                listBoxDiameter.Enabled = false;
                radioButtonVelocity.Checked = false;
                listBoxVelocity.Enabled = false;
                radioButtonSlope.Checked = false;
                listBoxSlope.Enabled = false;
                listBoxRoughness.Enabled = false;

                textBoxUserDefineDiameter.Enabled = true;
                textBoxUserDefineVelocity.Enabled = true;
                textBoxUserDefineSlope.Enabled = true;
                textBoxUserDefineRoughness.Enabled = true;

                textBoxUserDefineDiameter.TextChanged -= textBoxUserDefineDiameter_TextChanged;
                textBoxUserDefineSlope.TextChanged -= textBoxUserDefineSlope_TextChanged;
                textBoxUserDefineRoughness.TextChanged -= textBoxUserDefineRoughness_TextChanged;
                textBoxUserDefineDiameter.Text = textBoxDiameter.Text;
                textBoxUserDefineVelocity.Text = textBoxVelocity.Text;
                textBoxUserDefineSlope.Text = textBoxSlope.Text;
                textBoxUserDefineRoughness.Text = textBoxRoughness.Text;
                textBoxUserDefineDiameter.TextChanged += textBoxUserDefineDiameter_TextChanged;
                textBoxUserDefineSlope.TextChanged += textBoxUserDefineSlope_TextChanged;
                textBoxUserDefineRoughness.TextChanged += textBoxUserDefineRoughness_TextChanged;
            }
            else if (checkBoxUserDefine.Checked == false)
            {
                textBoxUserDefineDiameter.Enabled = false;
                textBoxUserDefineVelocity.Enabled = false;
                textBoxUserDefineSlope.Enabled = false;
                textBoxUserDefineRoughness.Enabled = false;

                listBoxRoughness.Enabled = true;
            }
        }

        private void textBoxUserDefineDiameter_TextChanged(object sender, EventArgs e)
        {
            CalculateDiameterAndVelocityAndSlope();
        }

        private void textBoxUserDefineSlope_TextChanged(object sender, EventArgs e)
        {
            CalculateDiameterAndVelocityAndSlope();
        }

        private void textBoxUserDefineRoughness_TextChanged(object sender, EventArgs e)
        {
            CalculateDiameterAndVelocityAndSlope();
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
