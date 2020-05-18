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
    public partial class WaterSupplyControl : UserControl
    {
        public WaterSupplyControl()
        {
            InitializeComponent();

            testc();
        }


        public void testc()
        {
            List<int> data = new List<int>();

            for (int i = 0; i < 25; i++)
            {
                data.Add(i + 1);
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[1].Value = i;
            }

            //dataGridView1.Columns. = data;
        }
    }
}
