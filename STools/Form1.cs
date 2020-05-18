using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using Microsoft.Win32;

namespace STools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReadSettingFromRegister();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            rainfallControl1.SaveSettingToRegister();
            spongeControl1.SaveSettingToRegister();
            SaveSettingToRegister();

        }

        private void ReadSettingFromRegister()
        {
            RegistryKey sToolsKey = Registry.CurrentUser;
            RegistryKey sToolsSubkeySoftware = sToolsKey.OpenSubKey("SOFTWARE", true);
            RegistryKey sTools = sToolsSubkeySoftware.CreateSubKey("SToolsTabpage");

            if (sTools.GetValue("tabpage") == null)
            {
                tabControl1.SelectedIndex = 0;
            }
            else
            {
                tabControl1.SelectedIndex = Convert.ToInt32(sTools.GetValue("tabpage").ToString());
            }
        }

        public void SaveSettingToRegister()
        {
            RegistryKey sToolsKey = Registry.CurrentUser;
            RegistryKey sToolsSubkeySoftware = sToolsKey.OpenSubKey("SOFTWARE", true);
            RegistryKey sTools = sToolsSubkeySoftware.CreateSubKey("SToolsTabpage");

            sTools.SetValue("tabpage", tabControl1.SelectedIndex.ToString());
        }
    }


}
