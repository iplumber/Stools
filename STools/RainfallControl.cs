using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Xml;
using Microsoft.Win32;

namespace STools
{
    public partial class RainfallControl : UserControl
    {
        public RainfallControl()
        {
            InitializeComponent();

            comboBoxProvince.Items.Clear();
            try
            {
                string queryText = string.Format("//ProvinceName/text()");
                string[] lines = getList(queryText);

                foreach (string line in lines)
                {
                    comboBoxProvince.Items.Add(line);
                }
                comboBoxProvince.SelectedIndex = 0;
                ReadSettingFromRegister();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        private void ReadSettingFromRegister()
        {
            RegistryKey sToolsKey = Registry.CurrentUser;
            RegistryKey sToolsSubkeySoftware = sToolsKey.OpenSubKey("SOFTWARE", true);
            RegistryKey sTools = sToolsSubkeySoftware.CreateSubKey("STools");

            if (sTools.GetValue("region") == null)
            {
                comboBoxProvince.SelectedIndex = 0;
                listBoxCity.SelectedIndex = 0;
                listBoxRegion.SelectedIndex = 0;
            }
            else
            {
                comboBoxProvince.SelectedIndex = Convert.ToInt32(sTools.GetValue("province").ToString());
                listBoxCity.SelectedIndex = Convert.ToInt32(sTools.GetValue("city").ToString());
                listBoxRegion.SelectedIndex = Convert.ToInt32(sTools.GetValue("region").ToString());
            }
        }

        public void SaveSettingToRegister()
        {
            RegistryKey sToolsKey = Registry.CurrentUser;
            RegistryKey sToolsSubkeySoftware = sToolsKey.OpenSubKey("SOFTWARE", true);
            RegistryKey sTools = sToolsSubkeySoftware.CreateSubKey("STools");

            sTools.SetValue("province", comboBoxProvince.SelectedIndex.ToString());
            sTools.SetValue("city", listBoxCity.SelectedIndex.ToString());
            sTools.SetValue("region", listBoxRegion.SelectedIndex.ToString());
        }

        private void comboBoxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxCity.Items.Clear();
            listBoxRegion.Items.Clear();
            try
            {
                string provinceName = comboBoxProvince.SelectedItem.ToString();
                string queryText = string.Format("Province[ProvinceName='{0}']//CityName/text()", provinceName);
                string[] lines = getList(queryText);

                foreach (string line in lines)
                {
                    listBoxCity.Items.Add(line);
                }
                listBoxCity.SelectedIndex = 0;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void listBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxRegion.Items.Clear();
            try
            {
                string cityName = listBoxCity.SelectedItem.ToString();
                string queryText = string.Format("//City[CityName='{0}']//RegionName/text()", cityName);
                string[] lines = getList(queryText);

                foreach (string line in lines)
                {
                    listBoxRegion.Items.Add(line);
                }
                listBoxRegion.SelectedIndex = 0;

                queryText = string.Format("//City[CityName='{0}']//document/text()", cityName);
                textBoxDocument.Clear();
                textBoxDocument.Text = getList(queryText)[0];
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void listBoxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                string regionName = listBoxRegion.SelectedItem.ToString();
                string queryText = "";

                //以下代码如何优化？
                queryText = string.Format("//Region[RegionName='{0}']//A/text()", regionName);
                string A = getList(queryText)[0];

                queryText = string.Format("//Region[RegionName='{0}']//c/text()", regionName);
                string c = getList(queryText)[0];

                queryText = string.Format("//Region[RegionName='{0}']//b/text()", regionName);
                string b = getList(queryText)[0];

                queryText = string.Format("//Region[RegionName='{0}']//n/text()", regionName);
                string n = getList(queryText)[0];

                queryText = string.Format("//Region[RegionName='{0}']//unit/text()", regionName);
                string unit = getList(queryText)[0];

                queryText = string.Format("//Region[RegionName='{0}']//type/text()", regionName);
                string type = getList(queryText)[0];

                //是否需要转为全局的变量？ 后来好像已经转为类的成员变量了。
                //formulaParameter selectedRegion = new formulaParameter();  

                selectedRegion.A = Convert.ToDouble(A);
                selectedRegion.c = Convert.ToDouble(c);
                selectedRegion.b = Convert.ToDouble(b);
                selectedRegion.n = Convert.ToDouble(n);
                selectedRegion.unit = unit;
                selectedRegion.type = type;

                calculateDesignStormDensity();
                //以上代码如何优化？
                textBoxReturnPeriod.Text = selectedRegion.P.ToString();
                textBoxRainRoutingTime.Text = selectedRegion.t.ToString();
            }
            catch (Exception err)
            {
                textBoxRainRoutingTime.Focus();
                MessageBox.Show(err.Message);
            }
        }

        //是否需要转为全局的变量？
        formulaParameter selectedRegion = new formulaParameter();

        private string[] getList(string queryText)
        {
            ParseXmlFile xmlFile = new ParseXmlFile();
            XmlNodeList nodes = xmlFile.document.DocumentElement.SelectNodes(queryText);
            string nodeText = xmlFile.Update(nodes);

            //本段切分字符串的代码未掌握。***
            string[] textArray = nodeText.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            string[] lines = nodeText.Split(
                new[] { Environment.NewLine },
                StringSplitOptions.RemoveEmptyEntries
                );
            //textBoxTestXml.Text = nodeText;
            return lines;
        }

        private void calculateDesignStormDensity()
        {
            double designStormDensity = -1;   //如何用try catch 设定为null 捕捉错误。
            if (selectedRegion.type == "A*(1+clgP)")
            {
                designStormDensity = this.selectedRegion.getDesignStormDensity(selectedRegion.type);

                label_q_i.Text = "q =";
                labelTop.Text = selectedRegion.A.ToString() + "×(1+ " + selectedRegion.c.ToString() + "×lg" + selectedRegion.P.ToString() + ")";
                labelBottom.Text = "(" + selectedRegion.t.ToString() + "+ " + selectedRegion.b.ToString() + ")";
                labelExponent.Text = selectedRegion.n.ToString();
            }
            if (selectedRegion.type == "A+clgP")
            {
                designStormDensity = this.selectedRegion.getDesignStormDensity(selectedRegion.type);

                label_q_i.Text = "i =";
                labelTop.Text = selectedRegion.A.ToString() + " + " + selectedRegion.c.ToString() + "×lg" + selectedRegion.P.ToString();
                labelBottom.Text = "(" + selectedRegion.t.ToString() + "+ " + selectedRegion.b.ToString() + ")";
                labelExponent.Text = selectedRegion.n.ToString();
            }

            double designTotalRunoffFlow = -1;       //如何用try catch 设定为null 捕捉错误。
            designTotalRunoffFlow = designStormDensity * Convert.ToDouble(textBoxWeightedRunoffCoefficient.Text)
                                                       * Convert.ToDouble(textBoxTotalArea.Text);
            if (selectedRegion.unit == "mm/min")
            {
                labelDesignStormDensity.Text =  "(mm/min)";
                textBoxDesignStormDensity.Text = Convert.ToString(Math.Round(designStormDensity, 3));
                double designTotalRunoffFlow_M3PerSecond = designTotalRunoffFlow / 60 / 1000;
                
                if (designTotalRunoffFlow_M3PerSecond <= 1.0)
                {
                    double designTotalRunoffFlow_LPerSecond = designTotalRunoffFlow_M3PerSecond * 1000;
                    labelDesignRunoffFlow.Text = "(L/s)";
                    label_Q.Text = "Q = qψF = " + Convert.ToString(Math.Round(designStormDensity, 3)) + " × "
                                                + textBoxWeightedRunoffCoefficient.Text + " × "
                                                + textBoxTotalArea.Text + " / 60 =";
                    textBoxDesignTotalRunoffFlow.Text = Convert.ToString(Math.Round(designTotalRunoffFlow_LPerSecond, 2));
                }
                else
                {
                    labelDesignRunoffFlow.Text = "(m^3/s)";
                    label_Q.Text = "Q = qψF = " + Convert.ToString(Math.Round(designStormDensity, 3)) + " × "
                                                + textBoxWeightedRunoffCoefficient.Text + " × "
                                                + textBoxTotalArea.Text + " /60/1000=";
                    textBoxDesignTotalRunoffFlow.Text = Convert.ToString(Math.Round(designTotalRunoffFlow_M3PerSecond, 2));
                }
            }
            else if (selectedRegion.unit == "mm/h")
            {
                labelDesignStormDensity.Text = "(mm/h)";
                textBoxDesignStormDensity.Text = Convert.ToString(Math.Round(designStormDensity, 3));
                double designTotalRunoffFlow_M3PerSecond = designTotalRunoffFlow / 3600 / 1000;

                if (designTotalRunoffFlow_M3PerSecond <= 1.0)
                {
                    double designTotalRunoffFlow_LPerSecond = designTotalRunoffFlow_M3PerSecond * 1000;
                    labelDesignRunoffFlow.Text = "(L/s)";
                    label_Q.Text = "Q = qψF = " + Convert.ToString(Math.Round(designStormDensity, 3)) + " × "
                                                + textBoxWeightedRunoffCoefficient.Text + " × "
                                                + textBoxTotalArea.Text + " / 3600 =";
                    textBoxDesignTotalRunoffFlow.Text = Convert.ToString(Math.Round(designTotalRunoffFlow_LPerSecond, 2));
                }
                else
                {
                    labelDesignRunoffFlow.Text = "(m^3/s)";
                    label_Q.Text = "Q = qψF = " + Convert.ToString(Math.Round(designStormDensity, 3)) + " × "
                                                + textBoxWeightedRunoffCoefficient.Text + " × "
                                                + textBoxTotalArea.Text + " /3600/1000=";
                    textBoxDesignTotalRunoffFlow.Text = Convert.ToString(Math.Round(designTotalRunoffFlow_M3PerSecond, 2));
                }
            }
            else if (selectedRegion.unit == "L/S_Ha")
            {
                labelDesignStormDensity.Text = "(L/s·ha)";
                textBoxDesignStormDensity.Text = Convert.ToString(Math.Round(designStormDensity, 2));
                double designTotalRunoffFlow_M3PerSecond = designTotalRunoffFlow / 10000 / 1000;

                if (designTotalRunoffFlow_M3PerSecond <= 1.0)
                {
                    double designTotalRunoffFlow_LPerSecond = designTotalRunoffFlow_M3PerSecond * 1000;
                    labelDesignRunoffFlow.Text = "(L/s)";
                    labelTotalFlow.Text = "设计总流量(L/s)";
                    labelConveyanceCapactiy.Text = "管道过流能力(L/s)";
                    label_Q.Text = "Q = qψF = " + Convert.ToString(Math.Round(designStormDensity, 3)) + " × "
                                                + textBoxWeightedRunoffCoefficient.Text + " × "
                                                + textBoxTotalArea.Text + " / 10000 =";
                    textBoxDesignTotalRunoffFlow.Text = Convert.ToString(Math.Round(designTotalRunoffFlow_LPerSecond, 2));
                }
                else
                {
                    labelDesignRunoffFlow.Text = "(m^3/s)";
                    labelTotalFlow.Text = "设计总流量(m^3/s)";
                    labelConveyanceCapactiy.Text = "管道过流能力(m^3/s)";
                    label_Q.Text = "Q = qψF = " + Convert.ToString(Math.Round(designStormDensity, 3)) + " × "
                                                + textBoxWeightedRunoffCoefficient.Text + " × "
                                                + textBoxTotalArea.Text + " /10000/1000=";
                    textBoxDesignTotalRunoffFlow.Text = Convert.ToString(Math.Round(designTotalRunoffFlow_M3PerSecond, 2));
                }
                //labelDesignRunoffFlow.Font = new Font(labelDesignRunoffFlow.Font.Name, 10, FontStyle.Bold);
            }
            else
            {
                MessageBox.Show("暴雨强度公式单位有误。");
            }
        }

        private void buttonCalculateDesignStormIntensity_Click(object sender, EventArgs e)
        {
            try
            {
                int retrunPeriod = Convert.ToInt16(textBoxReturnPeriod.Text);
                if (retrunPeriod > 0 && retrunPeriod <= 200)                     //超过这个范围目前没错误信息提示
                {
                    selectedRegion.P = retrunPeriod;
                    calculateDesignStormDensity();
                }
                else
                {
                    MessageBox.Show("重现期请输入1~200的整数。");
                }

                int routingTime = Convert.ToInt16(textBoxRainRoutingTime.Text);
                if (routingTime >= 0 && routingTime <= 120)                     //超过这个范围目前没错误信息提示
                {
                    selectedRegion.t = routingTime;
                    calculateDesignStormDensity();
                }
                else
                {
                    MessageBox.Show("地面流行时间请输入0~120的整数。");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);  //目前这个错误信息未显示是否地面流行时间还是重现期，也没给出输入数据的范围。
            }
        }

        formReturnPeriod formReturnPeriod = new formReturnPeriod();
        private void buttonShowReturnPeriodValue_Click(object sender, EventArgs e)
        {
            formReturnPeriod.ParentDialog = this;
            formReturnPeriod.Show();
            //bool isOpened = false;
            //RetrunPeriod formReturnPeriod = new RetrunPeriod();
            //foreach (Form _form in Application.OpenForms)
            //{
            //    if (_form.Name == "RetrunPeriod")
            //    {
            //        isOpened = true;
            //    }
            //}
            //if (!isOpened)
            //{
            //    formReturnPeriod.Show();
            //}
        }

        public void SetTotalArea(double _boxTotalArea)
        {
            textBoxTotalArea.Text = _boxTotalArea.ToString();
        }

        public void SetWeightedRunoffCoefficient(double _weightedRunoffCoefficient)
        {
            textBoxWeightedRunoffCoefficient.Text = Math.Round(_weightedRunoffCoefficient, 3).ToString();
        }

        public void SetPipe(Pipe _pipe)
        {
            textBoxTotalFlow.Text = textBoxDesignTotalRunoffFlow.Text;
            textBoxConveyanceCapactiy.Text = _pipe.conveyanceCapactiy.ToString();
            textBoxDiameter.Text = _pipe.diameter.ToString();
            textBoxVelocity.Text = _pipe.velocity.ToString();
            textBoxSlope.Text = _pipe.slope.ToString();
            textBoxRoughness.Text = _pipe.roughness.ToString();
            textBoxPipeMaterial.Text = _pipe.material;
        }

        public void SetReturnPeriod(double _period)
        {
            textBoxReturnPeriod.Text = _period.ToString();
        }
        
        RunoffCoefficient formRunoffCoefficient;
        private void buttonCalWeightedRunoffCoefficient_Click(object sender, EventArgs e)
        {
            if (formRunoffCoefficient == null)   formRunoffCoefficient = new RunoffCoefficient();
            formRunoffCoefficient.ParentDialog = this;
            formRunoffCoefficient.Show();

            //bool isOpened = false;
            //textBoxWeightedRunoffCoefficient.Text = Math.Round(formRunoffCoefficient.weightedRunoffCoefficient, 3).ToString();
            //textBoxTotalArea.Text = formRunoffCoefficient.totalArea.ToString();

            //sRetrunPeriod formReturnPeriod = new RetrunPeriod();
            //foreach (Form _form in Application.OpenForms)
            //{
            //    if (_form.Name == "径流系数表")
            //    {
            //        isOpened = true;
            //    }
            //}
            //if (!isOpened)
            //{
            //    formRunoffCoefficient.Show();
            //}
        }

        CalculatePipe formCalculatePipe;
        private void buttonCalculatePipe_Click(object sender, EventArgs e)
        {
            if(formCalculatePipe == null)    formCalculatePipe = new CalculatePipe();
            formCalculatePipe.ParentDialog = this;
            formCalculatePipe.SetDesignRunoffFlowAndUnit(textBoxDesignTotalRunoffFlow.Text, labelDesignRunoffFlow.Text);
            formCalculatePipe.TheFirstTimeCalculateDiameterAndSlope();
            formCalculatePipe.Show();
        }
    }

    public class formulaParameter
    {
        public formulaParameter ()
        {
            // 默认的暴雨重现期为1年，地面流行时间为10min，后期界面提供输入和修改；
            P = 1;
            t = 10;
        }

        // 城市名和地方参数A、c、b、n，用户不能修改；
        public double A;
        public double c;
        public double b;
        public double n;

        // 重现期 P 和 地面流行时间 t，根据城市地形和规模及规范规定，给定P和t的初值，用户可以修改。
        public double P;
        public double t;

        // 暴雨强度公式的单位和类型
        public string unit;
        public string type;

        public double getDesignStormDensity(string _type)
        {
            double designStormIntensity = -1;
            if (_type == "A+clgP")
            {
                designStormIntensity = (A + c * Math.Log10(P)) / Math.Pow((t + b), n);
            }
            if (_type == "A*(1+clgP)")
            {
                designStormIntensity = A * (1 + c * Math.Log10(P)) / Math.Pow((t + b), n);
            }
            return designStormIntensity;
        }
    }

}
