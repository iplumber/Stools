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
            this.label_Q = new System.Windows.Forms.Label();
            this.labelDesignRunoffFlow = new System.Windows.Forms.Label();
            this.groupBoxDesignFlow = new System.Windows.Forms.GroupBox();
            this.textBoxDesignTotalRunoffFlow = new System.Windows.Forms.TextBox();
            this.groupBoxDesignRainfallDensity = new System.Windows.Forms.GroupBox();
            this.textBoxDesignStormDensity = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxRoughness = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxPipeMaterial = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSlope = new System.Windows.Forms.TextBox();
            this.textBoxVelocity = new System.Windows.Forms.TextBox();
            this.textBoxDiameter = new System.Windows.Forms.TextBox();
            this.textBoxConveyanceCapactiy = new System.Windows.Forms.TextBox();
            this.textBoxTotalFlow = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelConveyanceCapactiy = new System.Windows.Forms.Label();
            this.labelTotalFlow = new System.Windows.Forms.Label();
            this.buttonCalculatePipe = new System.Windows.Forms.Button();
            this.groupBoxDesignFlow.SuspendLayout();
            this.groupBoxDesignRainfallDensity.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxProvince
            // 
            this.comboBoxProvince.FormattingEnabled = true;
            this.comboBoxProvince.Location = new System.Drawing.Point(13, 52);
            this.comboBoxProvince.Name = "comboBoxProvince";
            this.comboBoxProvince.Size = new System.Drawing.Size(251, 28);
            this.comboBoxProvince.TabIndex = 1;
            this.comboBoxProvince.SelectedIndexChanged += new System.EventHandler(this.comboBoxProvince_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "选择省份：";
            // 
            // listBoxCity
            // 
            this.listBoxCity.FormattingEnabled = true;
            this.listBoxCity.ItemHeight = 20;
            this.listBoxCity.Location = new System.Drawing.Point(13, 110);
            this.listBoxCity.Name = "listBoxCity";
            this.listBoxCity.Size = new System.Drawing.Size(120, 164);
            this.listBoxCity.TabIndex = 2;
            this.listBoxCity.SelectedIndexChanged += new System.EventHandler(this.listBoxCity_SelectedIndexChanged);
            // 
            // listBoxRegion
            // 
            this.listBoxRegion.FormattingEnabled = true;
            this.listBoxRegion.ItemHeight = 20;
            this.listBoxRegion.Location = new System.Drawing.Point(144, 110);
            this.listBoxRegion.Name = "listBoxRegion";
            this.listBoxRegion.Size = new System.Drawing.Size(120, 164);
            this.listBoxRegion.TabIndex = 3;
            this.listBoxRegion.SelectedIndexChanged += new System.EventHandler(this.listBoxRegion_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "选择城市：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "选择地区：";
            // 
            // listBoxDocument
            // 
            this.listBoxDocument.FormattingEnabled = true;
            this.listBoxDocument.ItemHeight = 20;
            this.listBoxDocument.Location = new System.Drawing.Point(13, 312);
            this.listBoxDocument.Name = "listBoxDocument";
            this.listBoxDocument.Size = new System.Drawing.Size(251, 64);
            this.listBoxDocument.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "选择公式来源：";
            // 
            // label_q_i
            // 
            this.label_q_i.AutoSize = true;
            this.label_q_i.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_q_i.Location = new System.Drawing.Point(9, 39);
            this.label_q_i.Name = "label_q_i";
            this.label_q_i.Size = new System.Drawing.Size(32, 20);
            this.label_q_i.TabIndex = 41;
            this.label_q_i.Text = "q =";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(44, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 1);
            this.label6.TabIndex = 7;
            // 
            // labelTop
            // 
            this.labelTop.AutoSize = true;
            this.labelTop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTop.Location = new System.Drawing.Point(55, 27);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(130, 20);
            this.labelTop.TabIndex = 42;
            this.labelTop.Text = "A ( 1 + C × lg P ）";
            this.labelTop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBottom
            // 
            this.labelBottom.AutoSize = true;
            this.labelBottom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBottom.Location = new System.Drawing.Point(59, 52);
            this.labelBottom.Name = "labelBottom";
            this.labelBottom.Size = new System.Drawing.Size(70, 20);
            this.labelBottom.TabIndex = 43;
            this.labelBottom.Text = "( t + b ）";
            this.labelBottom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(234, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 19);
            this.label9.TabIndex = 45;
            this.label9.Text = "=";
            // 
            // labelDesignStormDensity
            // 
            this.labelDesignStormDensity.AutoSize = true;
            this.labelDesignStormDensity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDesignStormDensity.Location = new System.Drawing.Point(365, 39);
            this.labelDesignStormDensity.Name = "labelDesignStormDensity";
            this.labelDesignStormDensity.Size = new System.Drawing.Size(57, 20);
            this.labelDesignStormDensity.TabIndex = 46;
            this.labelDesignStormDensity.Text = "(L/s·ha)";
            // 
            // labelExponent
            // 
            this.labelExponent.AutoSize = true;
            this.labelExponent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelExponent.Location = new System.Drawing.Point(140, 49);
            this.labelExponent.Name = "labelExponent";
            this.labelExponent.Size = new System.Drawing.Size(17, 20);
            this.labelExponent.TabIndex = 44;
            this.labelExponent.Text = "n";
            // 
            // textBoxRainRoutingTime
            // 
            this.textBoxRainRoutingTime.Location = new System.Drawing.Point(250, 41);
            this.textBoxRainRoutingTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxRainRoutingTime.Name = "textBoxRainRoutingTime";
            this.textBoxRainRoutingTime.Size = new System.Drawing.Size(162, 27);
            this.textBoxRainRoutingTime.TabIndex = 11;
            this.textBoxRainRoutingTime.Text = "10";
            this.textBoxRainRoutingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxReturnPeriod
            // 
            this.textBoxReturnPeriod.Location = new System.Drawing.Point(250, 81);
            this.textBoxReturnPeriod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxReturnPeriod.Name = "textBoxReturnPeriod";
            this.textBoxReturnPeriod.Size = new System.Drawing.Size(162, 27);
            this.textBoxReturnPeriod.TabIndex = 12;
            this.textBoxReturnPeriod.Text = "3";
            this.textBoxReturnPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonCalculateDesignStormIntensity
            // 
            this.buttonCalculateDesignStormIntensity.Location = new System.Drawing.Point(566, 416);
            this.buttonCalculateDesignStormIntensity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCalculateDesignStormIntensity.Name = "buttonCalculateDesignStormIntensity";
            this.buttonCalculateDesignStormIntensity.Size = new System.Drawing.Size(167, 65);
            this.buttonCalculateDesignStormIntensity.TabIndex = 34;
            this.buttonCalculateDesignStormIntensity.Text = "计算总流量";
            this.buttonCalculateDesignStormIntensity.UseVisualStyleBackColor = true;
            this.buttonCalculateDesignStormIntensity.Click += new System.EventHandler(this.buttonCalculateDesignStormIntensity_Click);
            // 
            // buttonShowReturnPeriodValue
            // 
            this.buttonShowReturnPeriodValue.Location = new System.Drawing.Point(24, 78);
            this.buttonShowReturnPeriodValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonShowReturnPeriodValue.Name = "buttonShowReturnPeriodValue";
            this.buttonShowReturnPeriodValue.Size = new System.Drawing.Size(200, 30);
            this.buttonShowReturnPeriodValue.TabIndex = 17;
            this.buttonShowReturnPeriodValue.Text = "重现期 P（年）";
            this.buttonShowReturnPeriodValue.UseVisualStyleBackColor = true;
            this.buttonShowReturnPeriodValue.Click += new System.EventHandler(this.buttonShowReturnPeriodValue_Click);
            // 
            // buttonCalWeightedRunoffCoefficient
            // 
            this.buttonCalWeightedRunoffCoefficient.Location = new System.Drawing.Point(23, 158);
            this.buttonCalWeightedRunoffCoefficient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCalWeightedRunoffCoefficient.Name = "buttonCalWeightedRunoffCoefficient";
            this.buttonCalWeightedRunoffCoefficient.Size = new System.Drawing.Size(200, 30);
            this.buttonCalWeightedRunoffCoefficient.TabIndex = 19;
            this.buttonCalWeightedRunoffCoefficient.Text = "综合径流系数ψ";
            this.buttonCalWeightedRunoffCoefficient.UseVisualStyleBackColor = true;
            this.buttonCalWeightedRunoffCoefficient.Click += new System.EventHandler(this.buttonCalWeightedRunoffCoefficient_Click);
            // 
            // textBoxWeightedRunoffCoefficient
            // 
            this.textBoxWeightedRunoffCoefficient.Location = new System.Drawing.Point(250, 161);
            this.textBoxWeightedRunoffCoefficient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxWeightedRunoffCoefficient.Name = "textBoxWeightedRunoffCoefficient";
            this.textBoxWeightedRunoffCoefficient.Size = new System.Drawing.Size(162, 27);
            this.textBoxWeightedRunoffCoefficient.TabIndex = 14;
            this.textBoxWeightedRunoffCoefficient.Text = "0.65";
            this.textBoxWeightedRunoffCoefficient.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTotalArea
            // 
            this.textBoxTotalArea.Location = new System.Drawing.Point(250, 121);
            this.textBoxTotalArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTotalArea.Name = "textBoxTotalArea";
            this.textBoxTotalArea.Size = new System.Drawing.Size(162, 27);
            this.textBoxTotalArea.TabIndex = 13;
            this.textBoxTotalArea.Text = "100000";
            this.textBoxTotalArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_Q
            // 
            this.label_Q.AutoSize = true;
            this.label_Q.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Q.Location = new System.Drawing.Point(9, 37);
            this.label_Q.Name = "label_Q";
            this.label_Q.Size = new System.Drawing.Size(83, 20);
            this.label_Q.TabIndex = 31;
            this.label_Q.Text = "Q = qψF = ";
            // 
            // labelDesignRunoffFlow
            // 
            this.labelDesignRunoffFlow.AutoSize = true;
            this.labelDesignRunoffFlow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDesignRunoffFlow.Location = new System.Drawing.Point(366, 37);
            this.labelDesignRunoffFlow.Name = "labelDesignRunoffFlow";
            this.labelDesignRunoffFlow.Size = new System.Drawing.Size(62, 20);
            this.labelDesignRunoffFlow.TabIndex = 33;
            this.labelDesignRunoffFlow.Text = "(m^3/s)";
            // 
            // groupBoxDesignFlow
            // 
            this.groupBoxDesignFlow.Controls.Add(this.textBoxDesignTotalRunoffFlow);
            this.groupBoxDesignFlow.Controls.Add(this.label_Q);
            this.groupBoxDesignFlow.Controls.Add(this.labelDesignRunoffFlow);
            this.groupBoxDesignFlow.Location = new System.Drawing.Point(300, 318);
            this.groupBoxDesignFlow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxDesignFlow.Name = "groupBoxDesignFlow";
            this.groupBoxDesignFlow.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxDesignFlow.Size = new System.Drawing.Size(433, 81);
            this.groupBoxDesignFlow.TabIndex = 30;
            this.groupBoxDesignFlow.TabStop = false;
            this.groupBoxDesignFlow.Text = "设计总径流量";
            // 
            // textBoxDesignTotalRunoffFlow
            // 
            this.textBoxDesignTotalRunoffFlow.Location = new System.Drawing.Point(284, 34);
            this.textBoxDesignTotalRunoffFlow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDesignTotalRunoffFlow.Name = "textBoxDesignTotalRunoffFlow";
            this.textBoxDesignTotalRunoffFlow.ReadOnly = true;
            this.textBoxDesignTotalRunoffFlow.Size = new System.Drawing.Size(74, 27);
            this.textBoxDesignTotalRunoffFlow.TabIndex = 32;
            this.textBoxDesignTotalRunoffFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.groupBoxDesignRainfallDensity.Location = new System.Drawing.Point(300, 229);
            this.groupBoxDesignRainfallDensity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxDesignRainfallDensity.Name = "groupBoxDesignRainfallDensity";
            this.groupBoxDesignRainfallDensity.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxDesignRainfallDensity.Size = new System.Drawing.Size(433, 88);
            this.groupBoxDesignRainfallDensity.TabIndex = 21;
            this.groupBoxDesignRainfallDensity.TabStop = false;
            this.groupBoxDesignRainfallDensity.Text = "设计暴雨强度";
            // 
            // textBoxDesignStormDensity
            // 
            this.textBoxDesignStormDensity.Location = new System.Drawing.Point(284, 36);
            this.textBoxDesignStormDensity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDesignStormDensity.Name = "textBoxDesignStormDensity";
            this.textBoxDesignStormDensity.ReadOnly = true;
            this.textBoxDesignStormDensity.Size = new System.Drawing.Size(74, 27);
            this.textBoxDesignStormDensity.TabIndex = 22;
            this.textBoxDesignStormDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonShowReturnPeriodValue);
            this.groupBox1.Controls.Add(this.buttonCalWeightedRunoffCoefficient);
            this.groupBox1.Controls.Add(this.textBoxRainRoutingTime);
            this.groupBox1.Controls.Add(this.textBoxTotalArea);
            this.groupBox1.Controls.Add(this.textBoxWeightedRunoffCoefficient);
            this.groupBox1.Controls.Add(this.textBoxReturnPeriod);
            this.groupBox1.Location = new System.Drawing.Point(301, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(432, 214);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设计参数";
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(23, 118);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 30);
            this.button3.TabIndex = 18;
            this.button3.Text = "汇水面积 F（平方米）";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(24, 38);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "雨水流行时间 t（min）";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.listBoxDocument);
            this.groupBox2.Controls.Add(this.listBoxRegion);
            this.groupBox2.Controls.Add(this.comboBoxProvince);
            this.groupBox2.Controls.Add(this.listBoxCity);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(11, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(277, 388);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "暴雨强度公式";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxRoughness);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textBoxPipeMaterial);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.textBoxSlope);
            this.groupBox3.Controls.Add(this.textBoxVelocity);
            this.groupBox3.Controls.Add(this.textBoxDiameter);
            this.groupBox3.Controls.Add(this.textBoxConveyanceCapactiy);
            this.groupBox3.Controls.Add(this.textBoxTotalFlow);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.labelConveyanceCapactiy);
            this.groupBox3.Controls.Add(this.labelTotalFlow);
            this.groupBox3.Location = new System.Drawing.Point(11, 406);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(542, 159);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "设计管段结果";
            // 
            // textBoxRoughness
            // 
            this.textBoxRoughness.Location = new System.Drawing.Point(448, 116);
            this.textBoxRoughness.Name = "textBoxRoughness";
            this.textBoxRoughness.ReadOnly = true;
            this.textBoxRoughness.Size = new System.Drawing.Size(73, 27);
            this.textBoxRoughness.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(448, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "粗糙系数";
            // 
            // textBoxPipeMaterial
            // 
            this.textBoxPipeMaterial.Location = new System.Drawing.Point(166, 51);
            this.textBoxPipeMaterial.Name = "textBoxPipeMaterial";
            this.textBoxPipeMaterial.ReadOnly = true;
            this.textBoxPipeMaterial.Size = new System.Drawing.Size(355, 27);
            this.textBoxPipeMaterial.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(166, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "管道材料";
            // 
            // textBoxSlope
            // 
            this.textBoxSlope.Location = new System.Drawing.Point(354, 117);
            this.textBoxSlope.Name = "textBoxSlope";
            this.textBoxSlope.ReadOnly = true;
            this.textBoxSlope.Size = new System.Drawing.Size(73, 27);
            this.textBoxSlope.TabIndex = 9;
            // 
            // textBoxVelocity
            // 
            this.textBoxVelocity.Location = new System.Drawing.Point(260, 117);
            this.textBoxVelocity.Name = "textBoxVelocity";
            this.textBoxVelocity.ReadOnly = true;
            this.textBoxVelocity.Size = new System.Drawing.Size(73, 27);
            this.textBoxVelocity.TabIndex = 8;
            // 
            // textBoxDiameter
            // 
            this.textBoxDiameter.Location = new System.Drawing.Point(166, 117);
            this.textBoxDiameter.Name = "textBoxDiameter";
            this.textBoxDiameter.ReadOnly = true;
            this.textBoxDiameter.Size = new System.Drawing.Size(73, 27);
            this.textBoxDiameter.TabIndex = 7;
            // 
            // textBoxConveyanceCapactiy
            // 
            this.textBoxConveyanceCapactiy.Location = new System.Drawing.Point(9, 117);
            this.textBoxConveyanceCapactiy.Name = "textBoxConveyanceCapactiy";
            this.textBoxConveyanceCapactiy.ReadOnly = true;
            this.textBoxConveyanceCapactiy.Size = new System.Drawing.Size(130, 27);
            this.textBoxConveyanceCapactiy.TabIndex = 6;
            // 
            // textBoxTotalFlow
            // 
            this.textBoxTotalFlow.Location = new System.Drawing.Point(9, 51);
            this.textBoxTotalFlow.Name = "textBoxTotalFlow";
            this.textBoxTotalFlow.ReadOnly = true;
            this.textBoxTotalFlow.Size = new System.Drawing.Size(130, 27);
            this.textBoxTotalFlow.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(354, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "坡度(‰)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(260, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "流速(m/s)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(166, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "管径(mm)";
            // 
            // labelConveyanceCapactiy
            // 
            this.labelConveyanceCapactiy.AutoSize = true;
            this.labelConveyanceCapactiy.Location = new System.Drawing.Point(9, 93);
            this.labelConveyanceCapactiy.Name = "labelConveyanceCapactiy";
            this.labelConveyanceCapactiy.Size = new System.Drawing.Size(134, 20);
            this.labelConveyanceCapactiy.TabIndex = 1;
            this.labelConveyanceCapactiy.Text = "管道过流能力(L/s)";
            // 
            // labelTotalFlow
            // 
            this.labelTotalFlow.AutoSize = true;
            this.labelTotalFlow.Location = new System.Drawing.Point(9, 27);
            this.labelTotalFlow.Name = "labelTotalFlow";
            this.labelTotalFlow.Size = new System.Drawing.Size(118, 20);
            this.labelTotalFlow.TabIndex = 0;
            this.labelTotalFlow.Text = "设计总流量(L/s)";
            // 
            // buttonCalculatePipe
            // 
            this.buttonCalculatePipe.Location = new System.Drawing.Point(566, 499);
            this.buttonCalculatePipe.Name = "buttonCalculatePipe";
            this.buttonCalculatePipe.Size = new System.Drawing.Size(165, 66);
            this.buttonCalculatePipe.TabIndex = 36;
            this.buttonCalculatePipe.Text = "计算管段参数";
            this.buttonCalculatePipe.UseVisualStyleBackColor = true;
            this.buttonCalculatePipe.Click += new System.EventHandler(this.buttonCalculatePipe_Click);
            // 
            // RainfallControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCalculatePipe);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxDesignRainfallDensity);
            this.Controls.Add(this.buttonCalculateDesignStormIntensity);
            this.Controls.Add(this.groupBoxDesignFlow);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "RainfallControl";
            this.Size = new System.Drawing.Size(750, 577);
            this.groupBoxDesignFlow.ResumeLayout(false);
            this.groupBoxDesignFlow.PerformLayout();
            this.groupBoxDesignRainfallDensity.ResumeLayout(false);
            this.groupBoxDesignRainfallDensity.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label_Q;
        private System.Windows.Forms.Label labelDesignRunoffFlow;
        private System.Windows.Forms.GroupBox groupBoxDesignFlow;
        private System.Windows.Forms.GroupBox groupBoxDesignRainfallDensity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxDesignStormDensity;
        private System.Windows.Forms.TextBox textBoxDesignTotalRunoffFlow;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelConveyanceCapactiy;
        private System.Windows.Forms.Label labelTotalFlow;
        private System.Windows.Forms.TextBox textBoxSlope;
        private System.Windows.Forms.TextBox textBoxVelocity;
        private System.Windows.Forms.TextBox textBoxDiameter;
        private System.Windows.Forms.TextBox textBoxConveyanceCapactiy;
        private System.Windows.Forms.TextBox textBoxTotalFlow;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPipeMaterial;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonCalculatePipe;
        private System.Windows.Forms.TextBox textBoxRoughness;
        private System.Windows.Forms.Label label13;
    }
}
