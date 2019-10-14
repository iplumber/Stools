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

namespace STools
{
    public partial class RainfallControl : UserControl
    {
        public RainfallControl()
        {
            InitializeComponent();
        }

        private void buttonXml_Click(object sender, EventArgs e)
        {
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
            }
            catch (Exception err)
            {
                textBoxTestXml.Text = err.Message;
            }
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
            }
            catch(Exception err)
            {
                textBoxTestXml.Text = err.Message;
            }
        }
        private void listBoxCity_Click(object sender, EventArgs e)
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

                queryText = string.Format("//City[CityName='{0}']//document/text()", cityName);
                listBoxDocument.Items.Clear();
                listBoxDocument.Items.Add(getList(queryText)[0]);
            }
            catch (Exception err)
            {
                textBoxTestXml.Text = err.Message;
            }
        }

        private void listBoxRegion_Click(object sender, EventArgs e)
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

                textBoxTestXml.Text = A + "\r\n" + c + "\r\n" + b + "\r\n" + n;
                
                //是否需要转为全局的变量？
                //formulaParameter selectedRegion = new formulaParameter();  

                selectedRegion.A = Convert.ToDouble(A);
                selectedRegion.c = Convert.ToDouble(c);
                selectedRegion.b = Convert.ToDouble(b);
                selectedRegion.n = Convert.ToDouble(n);
                selectedRegion.unit = unit;
                selectedRegion.type = type;

                calculateDesignStormIntensity();
                //以上代码如何优化？
                textBoxReturnPeriod.Text = selectedRegion.P.ToString();
                textBoxRainRoutingTime.Text = selectedRegion.t.ToString();
            }
            catch (Exception err)
            {
                textBoxTestXml.Text = err.Message;
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
            textBoxTestXml.Text = nodeText;
            return lines;
        }

        private void calculateDesignStormIntensity()
        {
            double designStormIntensity = -1;   //如何用try catch 设定为null 捕捉错误。
            double designRunoffFlow = -1;       //如何用try catch 设定为null 捕捉错误。
            if (selectedRegion.type == "A_Multiply_one_clgP")
            {
                designStormIntensity = this.selectedRegion.getDesignStormIntensity(selectedRegion.type);

                label_q_i.Text = "q =";
                labelTop.Text = selectedRegion.A.ToString() + "(1+ " + selectedRegion.c.ToString() + "×lg" + selectedRegion.P.ToString() + ")";
                labelBottom.Text = "(" + selectedRegion.t.ToString() + "+ " + selectedRegion.b.ToString() + ")";
                labelExponent.Text = selectedRegion.n.ToString();
                designRunoffFlow = designStormIntensity * Convert.ToDouble(textBoxTotalArea.Text) * Convert.ToDouble(textBoxTotalArea.Text);
                labelDesignRunoffFlow.Text = Convert.ToString(Math.Round(designRunoffFlow, 2)) + "（L/s·ha)";
                labelDesignRunoffFlow.Font = new Font(labelDesignRunoffFlow.Font.Name, 10, FontStyle.Bold);
            }
            if (selectedRegion.type == "A_Plus_clgP")
            {
                designStormIntensity = this.selectedRegion.getDesignStormIntensity(selectedRegion.type);

                label_q_i.Text = "i =";
                labelTop.Text = selectedRegion.A.ToString() + " + " + selectedRegion.c.ToString() + "×lg" + selectedRegion.P.ToString();
                labelBottom.Text = "(" + selectedRegion.t.ToString() + "+ " + selectedRegion.b.ToString() + ")";
                labelExponent.Text = selectedRegion.n.ToString();
            }

            if (selectedRegion.unit == "mmPerMin")
            {
                labelResult.Text = Convert.ToString(Math.Round(designStormIntensity, 2)) + "(mm/min)";
            }
            else if (selectedRegion.unit == "mmPerHour")
            {
                labelResult.Text = Convert.ToString(Math.Round(designStormIntensity, 2)) + "(mm/h)";
            }
            else if (selectedRegion.unit == "LPerSecHa")
            {
                labelResult.Text = Convert.ToString(Math.Round(designStormIntensity, 2)) + "(L/s·ha)";
            }
            else
            {
                textBoxTestXml.Text = "暴雨强度公式单位有误。";
            }
        }

        private void buttonCalculateDesignStormIntensity_Click(object sender, EventArgs e)
        {
            
            try
            {
                int retrunPeriod = Convert.ToInt16(textBoxReturnPeriod.Text);
                if (retrunPeriod > 0 && retrunPeriod < 200)                     //超过这个范围目前没错误信息提示
                {
                    selectedRegion.P = retrunPeriod;
                    calculateDesignStormIntensity();
                }
                else
                {
                    MessageBox.Show("重现期请输入0~200的整数。");
                }

                int routingTime = Convert.ToInt16(textBoxRainRoutingTime.Text);
                if (routingTime > 0 && routingTime < 120)                     //超过这个范围目前没错误信息提示
                {
                    selectedRegion.t = routingTime;
                    calculateDesignStormIntensity();
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

        private void buttonShowReturnPeriodValue_Click(object sender, EventArgs e)
        {
            bool isOpened = false;
            RetrunPeriod formReturnPeriod = new RetrunPeriod();
            foreach (Form _form in Application.OpenForms)
            {
                if (_form.Name == "RetrunPeriod")
                {
                    isOpened = true;
                }
            }
            if (!isOpened)
            {
                formReturnPeriod.Show();
            }
        }

        private void buttonCalWeightedRunoffCoefficient_Click(object sender, EventArgs e)
        {
            //bool isOpened = false;
            RunoffCoefficient formRunoffCoefficient = new RunoffCoefficient();
            formRunoffCoefficient.ShowDialog();
            textBoxWeightedRunoffCoefficient.Text = Math.Round(formRunoffCoefficient.weightedRunoffCoefficient, 3).ToString();
            textBoxTotalArea.Text = formRunoffCoefficient.totalArea.ToString();

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

        public double getDesignStormIntensity(string _type)
        {
            double designStormIntensity = -1;
            if (_type == "A_Plus_clgP")
            {
                designStormIntensity = (A + c * Math.Log10(P)) / Math.Pow((t + b), n);
            }
            if (_type == "A_Multiply_one_clgP")
            {
                designStormIntensity = A * (1 + c * Math.Log10(P)) / Math.Pow((t + b), n);
            }
            return designStormIntensity;
        }
    }

}
