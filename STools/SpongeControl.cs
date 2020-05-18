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
using System.Reflection;
using Microsoft.Win32;

namespace STools
{
    public partial class SpongeControl : UserControl
    {
        STJson _jsonConfig;
        public List<double> rates;
        public List<double> values;

        public SpongeControl()
        {
            InitializeComponent();

            try
            {
                _jsonConfig = STJson.parseFile(@"D:\91 STools\10 code\STools\径流总量控制率.json");
                comboBoxProvince.Items.Clear();
                foreach (KeyValuePair<String, STJson> pair in _jsonConfig.asJsonMap())
                {
                    comboBoxProvince.Items.Add(pair.Key);
                }
                comboBoxProvince.SelectedIndex = 0;
                ReadSettingFromRegister();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void checkBoxTemporaryProject_CheckedChanged(object sender, EventArgs e)
        {
            bool isTemporaryProject = checkBoxTemporaryProject.Checked;
            comboBoxProvince.Enabled = isTemporaryProject;
            comboBoxCity.Enabled = isTemporaryProject;
            comboBoxCounty.Enabled = isTemporaryProject;
        }

        private void comboBoxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCity.Items.Clear();
            String name = comboBoxProvince.SelectedItem.ToString();
            if (String.IsNullOrWhiteSpace(name))
                return;
            STJson jsonSub1 = _jsonConfig.getJson(name);
            foreach (KeyValuePair<String, STJson> pair in jsonSub1.asJsonMap())
            {
                comboBoxCity.Items.Add(pair.Key);
            }
            comboBoxCity.SelectedIndex = 0;
        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCounty.Items.Clear();
            String nameCity = comboBoxCity.SelectedItem.ToString();
            String nameProvince = comboBoxProvince.SelectedItem.ToString();
            if (String.IsNullOrWhiteSpace(nameCity) || String.IsNullOrWhiteSpace(nameProvince))
                return;
            STJson jsonSub1 = _jsonConfig.getJson(nameProvince).getJson(nameCity);
            foreach (KeyValuePair<String, STJson> pair in jsonSub1.asJsonMap())
            {
                comboBoxCounty.Items.Add(pair.Key);
            }
            comboBoxCounty.SelectedIndex = 0;
        }

        private void comboBoxCounty_SelectedIndexChanged(object sender, EventArgs e)
        {
            String nameCity = comboBoxCity.SelectedItem.ToString();
            String nameProvince = comboBoxProvince.SelectedItem.ToString();
            String nameBoxCounty = comboBoxCounty.SelectedItem.ToString();
            if (String.IsNullOrWhiteSpace(nameCity) || String.IsNullOrWhiteSpace(nameProvince) || String.IsNullOrWhiteSpace(nameBoxCounty))
                return;
            STJson jsonSub1 = _jsonConfig.getJson(nameProvince).getJson(nameCity).getJson(nameBoxCounty);

            rates = new List<double>();
            comboBoxControlRate.Items.Clear();
            foreach (STJson jsonRate in jsonSub1.getJson("rate").asJsonList())
            {
                rates.Add(jsonRate.asNumber());
                comboBoxControlRate.Items.Add(jsonRate.asNumber().ToString() + "%");
            }
            values = new List<double>();
            foreach (STJson jsonValue in jsonSub1.getJson("value").asJsonList())
            {
                values.Add(jsonValue.asNumber());
            }

            comboBoxControlRate.SelectedIndex = 13;
        }

        private void comboBoxControlRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (values.Count != 0)
            {
                int indexRate = comboBoxControlRate.SelectedIndex;
                textBoxPrecipitation.Text = values[indexRate].ToString() + "mm";
            }
            else
            {
                textBoxPrecipitation.Text = "没有降雨数据";
            }
        }

        private void ReadSettingFromRegister()
        {
            RegistryKey sToolsKey = Registry.CurrentUser;
            RegistryKey sToolsSubkeySoftware = sToolsKey.OpenSubKey("SOFTWARE", true);
            RegistryKey sTools = sToolsSubkeySoftware.CreateSubKey("SToolsSponge");

            if (sTools.GetValue("county") == null)
            {
                comboBoxProvince.SelectedIndex = 0;
                comboBoxCity.SelectedIndex = 0;
                comboBoxCounty.SelectedIndex = 0;
            }
            else
            {
                comboBoxProvince.SelectedIndex = Convert.ToInt32(sTools.GetValue("province").ToString());
                comboBoxCity.SelectedIndex = Convert.ToInt32(sTools.GetValue("city").ToString());
                comboBoxCounty.SelectedIndex = Convert.ToInt32(sTools.GetValue("county").ToString());
            }
        }

        public void SaveSettingToRegister()
        {
            RegistryKey sToolsKey = Registry.CurrentUser;
            RegistryKey sToolsSubkeySoftware = sToolsKey.OpenSubKey("SOFTWARE", true);
            RegistryKey sTools = sToolsSubkeySoftware.CreateSubKey("SToolsSponge");

            sTools.SetValue("province", comboBoxProvince.SelectedIndex.ToString());
            sTools.SetValue("city", comboBoxCity.SelectedIndex.ToString());
            sTools.SetValue("county", comboBoxCounty.SelectedIndex.ToString());
        }
    }
}
