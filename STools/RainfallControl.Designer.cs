namespace STools
{
    partial class RainfallControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxProvince = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxCity = new System.Windows.Forms.ListBox();
            this.listBoxRegion = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxDocument = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_q_i = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTop = new System.Windows.Forms.Label();
            this.labelBottom = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelDesignStormDensity = new System.Windows.Forms.Label();
            this.labelExponent = new System.Windows.Forms.Label();
            this.textBoxRainRoutingTime = new System.Windows.Forms.TextBox();
            this.textBoxReturnPeriod = new System.Windows.Forms.TextBox();
            this.buttonCalculateDesignStormIntensity = new System.Windows.Forms.Button();
            this.buttonShowReturnPeriodValue = new System.Windows.Forms.Button();
            this.buttonCalWeightedRunoffCoefficient = new System.Windows.Forms.Button();
            this.textBoxWeightedRunoffCoefficient = new System.Windows.Forms.TextBox();
            this.textBoxTotalArea = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.labelDesignRunoffFlow = new System.Windows.Forms.Label();
            this.groupBoxDesignFlow = new System.Windows.Forms.GroupBox();
            this.textBoxDesignRunoffFlow = new System.Windows.Forms.TextBox();
            this.groupBoxDesignRainfallDensity = new System.Windows.Forms.GroupBox();
            this.textBoxDesignStormDensity = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxDesignFlow.SuspendLayout();
            this.groupBoxDesignRainfallDensity.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxProvince
            // 
            this.comboBoxProvince.FormattingEnabled = true;
            this.comboBoxProvince.Location = new System.Drawing.Point(44, 85);
            this.comboBoxProvince.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxProvince.Name = "comboBoxProvince";
            this.comboBoxProvince.Size = new System.Drawing.Size(274, 23);
            this.comboBoxProvince.TabIndex = 2;
            this.comboBoxProvince.SelectedIndexChanged += new System.EventHandler(this.comboBoxProvince_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "选择省份：";
            // 
            // listBoxCity
            // 
            this.listBoxCity.FormattingEnabled = true;
            this.listBoxCity.ItemHeight = 15;
            this.listBoxCity.Location = new System.Drawing.Point(44, 152);
            this.listBoxCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxCity.Name = "listBoxCity";
            this.listBoxCity.Size = new System.Drawing.Size(120, 214);
            this.listBoxCity.TabIndex = 4;
            this.listBoxCity.Click += new System.EventHandler(this.listBoxCity_Click);
            // 
            // listBoxRegion
            // 
            this.listBoxRegion.FormattingEnabled = true;
            this.listBoxRegion.ItemHeight = 15;
            this.listBoxRegion.Location = new System.Drawing.Point(199, 152);
            this.listBoxRegion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxRegion.Name = "listBoxRegion";
            this.listBoxRegion.Size = new System.Drawing.Size(120, 214);
            this.listBoxRegion.TabIndex = 4;
            this.listBoxRegion.Click += new System.EventHandler(this.listBoxRegion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "选择城市：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "选择地区：";
            // 
            // listBoxDocument
            // 
            this.listBoxDocument.FormattingEnabled = true;
            this.listBoxDocument.ItemHeight = 15;
            this.listBoxDocument.Location = new System.Drawing.Point(25, 398);
            this.listBoxDocument.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxDocument.Name = "listBoxDocument";
            this.listBoxDocument.Size = new System.Drawing.Size(273, 94);
            this.listBoxDocument.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "选择公式来源：";
            // 
            // label_q_i
            // 
            this.label_q_i.AutoSize = true;
            this.label_q_i.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_q_i.Location = new System.Drawing.Point(20, 51);
            this.label_q_i.Name = "label_q_i";
            this.label_q_i.Size = new System.Drawing.Size(31, 15);
            this.label_q_i.TabIndex = 6;
            this.label_q_i.Text = "q =";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(62, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 2);
            this.label6.TabIndex = 7;
            // 
            // labelTop
            // 
            this.labelTop.AutoSize = true;
            this.labelTop.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTop.Location = new System.Drawing.Point(84, 35);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(165, 15);
            this.labelTop.TabIndex = 6;
            this.labelTop.Text = "A ( 1 + C × lg P ）";
            this.labelTop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBottom
            // 
            this.labelBottom.AutoSize = true;
            this.labelBottom.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBottom.Location = new System.Drawing.Point(106, 70);
            this.labelBottom.Name = "labelBottom";
            this.labelBottom.Size = new System.Drawing.Size(86, 15);
            this.labelBottom.TabIndex = 6;
            this.labelBottom.Text = "( t + b ）";
            this.labelBottom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(296, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 19);
            this.label9.TabIndex = 6;
            this.label9.Text = "=";
            // 
            // labelDesignStormDensity
            // 
            this.labelDesignStormDensity.AutoSize = true;
            this.labelDesignStormDensity.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDesignStormDensity.Location = new System.Drawing.Point(429, 51);
            this.labelDesignStormDensity.Name = "labelDesignStormDensity";
            this.labelDesignStormDensity.Size = new System.Drawing.Size(85, 15);
            this.labelDesignStormDensity.TabIndex = 6;
            this.labelDesignStormDensity.Text = "（L/s·ha)";
            // 
            // labelExponent
            // 
            this.labelExponent.AutoSize = true;
            this.labelExponent.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelExponent.Location = new System.Drawing.Point(213, 63);
            this.labelExponent.Name = "labelExponent";
            this.labelExponent.Size = new System.Drawing.Size(15, 15);
            this.labelExponent.TabIndex = 6;
            this.labelExponent.Text = "n";
            // 
            // textBoxRainRoutingTime
            // 
            this.textBoxRainRoutingTime.Location = new System.Drawing.Point(312, 40);
            this.textBoxRainRoutingTime.Name = "textBoxRainRoutingTime";
            this.textBoxRainRoutingTime.Size = new System.Drawing.Size(150, 25);
            this.textBoxRainRoutingTime.TabIndex = 10;
            this.textBoxRainRoutingTime.Text = "10";
            this.textBoxRainRoutingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxReturnPeriod
            // 
            this.textBoxReturnPeriod.Location = new System.Drawing.Point(312, 79);
            this.textBoxReturnPeriod.Name = "textBoxReturnPeriod";
            this.textBoxReturnPeriod.Size = new System.Drawing.Size(150, 25);
            this.textBoxReturnPeriod.TabIndex = 10;
            this.textBoxReturnPeriod.Text = "3";
            this.textBoxReturnPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonCalculateDesignStormIntensity
            // 
            this.buttonCalculateDesignStormIntensity.Location = new System.Drawing.Point(360, 511);
            this.buttonCalculateDesignStormIntensity.Name = "buttonCalculateDesignStormIntensity";
            this.buttonCalculateDesignStormIntensity.Size = new System.Drawing.Size(532, 35);
            this.buttonCalculateDesignStormIntensity.TabIndex = 12;
            this.buttonCalculateDesignStormIntensity.Text = "计算";
            this.buttonCalculateDesignStormIntensity.UseVisualStyleBackColor = true;
            this.buttonCalculateDesignStormIntensity.Click += new System.EventHandler(this.buttonCalculateDesignStormIntensity_Click);
            // 
            // buttonShowReturnPeriodValue
            // 
            this.buttonShowReturnPeriodValue.Location = new System.Drawing.Point(52, 79);
            this.buttonShowReturnPeriodValue.Name = "buttonShowReturnPeriodValue";
            this.buttonShowReturnPeriodValue.Size = new System.Drawing.Size(200, 25);
            this.buttonShowReturnPeriodValue.TabIndex = 14;
            this.buttonShowReturnPeriodValue.Text = "重现期 P（年）";
            this.buttonShowReturnPeriodValue.UseVisualStyleBackColor = true;
            this.buttonShowReturnPeriodValue.Click += new System.EventHandler(this.buttonShowReturnPeriodValue_Click);
            // 
            // buttonCalWeightedRunoffCoefficient
            // 
            this.buttonCalWeightedRunoffCoefficient.Location = new System.Drawing.Point(52, 196);
            this.buttonCalWeightedRunoffCoefficient.Name = "buttonCalWeightedRunoffCoefficient";
            this.buttonCalWeightedRunoffCoefficient.Size = new System.Drawing.Size(200, 25);
            this.buttonCalWeightedRunoffCoefficient.TabIndex = 15;
            this.buttonCalWeightedRunoffCoefficient.Text = "综合径流系数ψ";
            this.buttonCalWeightedRunoffCoefficient.UseVisualStyleBackColor = true;
            this.buttonCalWeightedRunoffCoefficient.Click += new System.EventHandler(this.buttonCalWeightedRunoffCoefficient_Click);
            // 
            // textBoxWeightedRunoffCoefficient
            // 
            this.textBoxWeightedRunoffCoefficient.Location = new System.Drawing.Point(312, 196);
            this.textBoxWeightedRunoffCoefficient.Name = "textBoxWeightedRunoffCoefficient";
            this.textBoxWeightedRunoffCoefficient.Size = new System.Drawing.Size(150, 25);
            this.textBoxWeightedRunoffCoefficient.TabIndex = 16;
            this.textBoxWeightedRunoffCoefficient.Text = "0.65";
            this.textBoxWeightedRunoffCoefficient.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTotalArea
            // 
            this.textBoxTotalArea.Location = new System.Drawing.Point(313, 157);
            this.textBoxTotalArea.Name = "textBoxTotalArea";
            this.textBoxTotalArea.Size = new System.Drawing.Size(150, 25);
            this.textBoxTotalArea.TabIndex = 16;
            this.textBoxTotalArea.Text = "500";
            this.textBoxTotalArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(432, 444);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "Q = qψF = ";
            // 
            // labelDesignRunoffFlow
            // 
            this.labelDesignRunoffFlow.AutoSize = true;
            this.labelDesignRunoffFlow.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDesignRunoffFlow.Location = new System.Drawing.Point(670, 444);
            this.labelDesignRunoffFlow.Name = "labelDesignRunoffFlow";
            this.labelDesignRunoffFlow.Size = new System.Drawing.Size(85, 15);
            this.labelDesignRunoffFlow.TabIndex = 6;
            this.labelDesignRunoffFlow.Text = "（L/s·ha)";
            // 
            // groupBoxDesignFlow
            // 
            this.groupBoxDesignFlow.Controls.Add(this.textBoxDesignRunoffFlow);
            this.groupBoxDesignFlow.Location = new System.Drawing.Point(360, 415);
            this.groupBoxDesignFlow.Name = "groupBoxDesignFlow";
            this.groupBoxDesignFlow.Size = new System.Drawing.Size(532, 68);
            this.groupBoxDesignFlow.TabIndex = 17;
            this.groupBoxDesignFlow.TabStop = false;
            this.groupBoxDesignFlow.Text = "设计总流量（L/s）";
            // 
            // textBoxDesignRunoffFlow
            // 
            this.textBoxDesignRunoffFlow.Location = new System.Drawing.Point(192, 24);
            this.textBoxDesignRunoffFlow.Name = "textBoxDesignRunoffFlow";
            this.textBoxDesignRunoffFlow.ReadOnly = true;
            this.textBoxDesignRunoffFlow.Size = new System.Drawing.Size(112, 25);
            this.textBoxDesignRunoffFlow.TabIndex = 0;
            this.textBoxDesignRunoffFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxDesignRainfallDensity
            // 
            this.groupBoxDesignRainfallDensity.Controls.Add(this.textBoxDesignStormDensity);
            this.groupBoxDesignRainfallDensity.Controls.Add(this.labelTop);
            this.groupBoxDesignRainfallDensity.Controls.Add(this.label_q_i);
            this.groupBoxDesignRainfallDensity.Controls.Add(this.label9);
            this.groupBoxDesignRainfallDensity.Controls.Add(this.labelDesignStormDensity);
            this.groupBoxDesignRainfallDensity.Controls.Add(this.labelBottom);
            this.groupBoxDesignRainfallDensity.Controls.Add(this.labelExponent);
            this.groupBoxDesignRainfallDensity.Controls.Add(this.label6);
            this.groupBoxDesignRainfallDensity.Location = new System.Drawing.Point(360, 287);
            this.groupBoxDesignRainfallDensity.Name = "groupBoxDesignRainfallDensity";
            this.groupBoxDesignRainfallDensity.Size = new System.Drawing.Size(532, 96);
            this.groupBoxDesignRainfallDensity.TabIndex = 18;
            this.groupBoxDesignRainfallDensity.TabStop = false;
            this.groupBoxDesignRainfallDensity.Text = "设计暴雨强度（L/s）";
            // 
            // textBoxDesignStormDensity
            // 
            this.textBoxDesignStormDensity.Location = new System.Drawing.Point(323, 45);
            this.textBoxDesignStormDensity.Name = "textBoxDesignStormDensity";
            this.textBoxDesignStormDensity.ReadOnly = true;
            this.textBoxDesignStormDensity.Size = new System.Drawing.Size(100, 25);
            this.textBoxDesignStormDensity.TabIndex = 8;
            this.textBoxDesignStormDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonShowReturnPeriodValue);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.buttonCalWeightedRunoffCoefficient);
            this.groupBox1.Controls.Add(this.textBoxRainRoutingTime);
            this.groupBox1.Controls.Add(this.textBoxTotalArea);
            this.groupBox1.Controls.Add(this.textBoxWeightedRunoffCoefficient);
            this.groupBox1.Controls.Add(this.textBoxReturnPeriod);
            this.groupBox1.Location = new System.Drawing.Point(361, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 247);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设计参数";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(52, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 25);
            this.button3.TabIndex = 22;
            this.button3.Text = "汇水面积 F（平方米）";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 25);
            this.button2.TabIndex = 21;
            this.button2.Text = "流量折减系数 m";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 25);
            this.button1.TabIndex = 20;
            this.button1.Text = "雨水流行时间 t（min）";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(312, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 25);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "1.0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.listBoxDocument);
            this.groupBox2.Location = new System.Drawing.Point(19, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 521);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "暴雨强度公式";
            // 
            // RainfallControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxDesignRainfallDensity);
            this.Controls.Add(this.buttonCalculateDesignStormIntensity);
            this.Controls.Add(this.labelDesignRunoffFlow);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listBoxRegion);
            this.Controls.Add(this.listBoxCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxProvince);
            this.Controls.Add(this.groupBoxDesignFlow);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RainfallControl";
            this.Size = new System.Drawing.Size(978, 586);
            this.groupBoxDesignFlow.ResumeLayout(false);
            this.groupBoxDesignFlow.PerformLayout();
            this.groupBoxDesignRainfallDensity.ResumeLayout(false);
            this.groupBoxDesignRainfallDensity.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxProvince;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxRegion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxDocument;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_q_i;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.Label labelBottom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelDesignStormDensity;
        private System.Windows.Forms.Label labelExponent;
        private System.Windows.Forms.ListBox listBoxCity;
        private System.Windows.Forms.TextBox textBoxRainRoutingTime;
        private System.Windows.Forms.TextBox textBoxReturnPeriod;
        private System.Windows.Forms.Button buttonCalculateDesignStormIntensity;
        private System.Windows.Forms.Button buttonShowReturnPeriodValue;
        private System.Windows.Forms.Button buttonCalWeightedRunoffCoefficient;
        private System.Windows.Forms.TextBox textBoxWeightedRunoffCoefficient;
        private System.Windows.Forms.TextBox textBoxTotalArea;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelDesignRunoffFlow;
        private System.Windows.Forms.GroupBox groupBoxDesignFlow;
        private System.Windows.Forms.GroupBox groupBoxDesignRainfallDensity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxDesignStormDensity;
        private System.Windows.Forms.TextBox textBoxDesignRunoffFlow;
    }
}
