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
            this.textBoxDesignRunoffFlow = new System.Windows.Forms.TextBox();
            this.groupBoxDesignRainfallDensity = new System.Windows.Forms.GroupBox();
            this.textBoxDesignStormDensity = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.comboBoxProvince.Location = new System.Drawing.Point(44, 113);
            this.comboBoxProvince.Name = "comboBoxProvince";
            this.comboBoxProvince.Size = new System.Drawing.Size(274, 28);
            this.comboBoxProvince.TabIndex = 0;
            this.comboBoxProvince.SelectedIndexChanged += new System.EventHandler(this.comboBoxProvince_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "选择省份：";
            // 
            // listBoxCity
            // 
            this.listBoxCity.FormattingEnabled = true;
            this.listBoxCity.ItemHeight = 20;
            this.listBoxCity.Location = new System.Drawing.Point(44, 203);
            this.listBoxCity.Name = "listBoxCity";
            this.listBoxCity.Size = new System.Drawing.Size(120, 224);
            this.listBoxCity.TabIndex = 1;
            this.listBoxCity.SelectedIndexChanged += new System.EventHandler(this.listBoxCity_SelectedIndexChanged);
            // 
            // listBoxRegion
            // 
            this.listBoxRegion.FormattingEnabled = true;
            this.listBoxRegion.ItemHeight = 20;
            this.listBoxRegion.Location = new System.Drawing.Point(199, 203);
            this.listBoxRegion.Name = "listBoxRegion";
            this.listBoxRegion.Size = new System.Drawing.Size(120, 224);
            this.listBoxRegion.TabIndex = 2;
            this.listBoxRegion.SelectedIndexChanged += new System.EventHandler(this.listBoxRegion_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "选择城市：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "选择地区：";
            // 
            // listBoxDocument
            // 
            this.listBoxDocument.FormattingEnabled = true;
            this.listBoxDocument.ItemHeight = 20;
            this.listBoxDocument.Location = new System.Drawing.Point(25, 446);
            this.listBoxDocument.Name = "listBoxDocument";
            this.listBoxDocument.Size = new System.Drawing.Size(273, 124);
            this.listBoxDocument.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "选择公式来源：";
            // 
            // label_q_i
            // 
            this.label_q_i.AutoSize = true;
            this.label_q_i.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_q_i.Location = new System.Drawing.Point(20, 67);
            this.label_q_i.Name = "label_q_i";
            this.label_q_i.Size = new System.Drawing.Size(32, 20);
            this.label_q_i.TabIndex = 6;
            this.label_q_i.Text = "q =";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(55, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 1);
            this.label6.TabIndex = 7;
            // 
            // labelTop
            // 
            this.labelTop.AutoSize = true;
            this.labelTop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTop.Location = new System.Drawing.Point(77, 53);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(130, 20);
            this.labelTop.TabIndex = 6;
            this.labelTop.Text = "A ( 1 + C × lg P ）";
            this.labelTop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBottom
            // 
            this.labelBottom.AutoSize = true;
            this.labelBottom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBottom.Location = new System.Drawing.Point(99, 86);
            this.labelBottom.Name = "labelBottom";
            this.labelBottom.Size = new System.Drawing.Size(70, 20);
            this.labelBottom.TabIndex = 6;
            this.labelBottom.Text = "( t + b ）";
            this.labelBottom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(282, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 19);
            this.label9.TabIndex = 6;
            this.label9.Text = "=";
            // 
            // labelDesignStormDensity
            // 
            this.labelDesignStormDensity.AutoSize = true;
            this.labelDesignStormDensity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDesignStormDensity.Location = new System.Drawing.Point(415, 68);
            this.labelDesignStormDensity.Name = "labelDesignStormDensity";
            this.labelDesignStormDensity.Size = new System.Drawing.Size(68, 20);
            this.labelDesignStormDensity.TabIndex = 6;
            this.labelDesignStormDensity.Text = "（L/s·ha)";
            // 
            // labelExponent
            // 
            this.labelExponent.AutoSize = true;
            this.labelExponent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelExponent.Location = new System.Drawing.Point(196, 77);
            this.labelExponent.Name = "labelExponent";
            this.labelExponent.Size = new System.Drawing.Size(17, 20);
            this.labelExponent.TabIndex = 6;
            this.labelExponent.Text = "n";
            // 
            // textBoxRainRoutingTime
            // 
            this.textBoxRainRoutingTime.Location = new System.Drawing.Point(312, 53);
            this.textBoxRainRoutingTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxRainRoutingTime.Name = "textBoxRainRoutingTime";
            this.textBoxRainRoutingTime.Size = new System.Drawing.Size(150, 27);
            this.textBoxRainRoutingTime.TabIndex = 4;
            this.textBoxRainRoutingTime.Text = "10";
            this.textBoxRainRoutingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxReturnPeriod
            // 
            this.textBoxReturnPeriod.Location = new System.Drawing.Point(312, 105);
            this.textBoxReturnPeriod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxReturnPeriod.Name = "textBoxReturnPeriod";
            this.textBoxReturnPeriod.Size = new System.Drawing.Size(150, 27);
            this.textBoxReturnPeriod.TabIndex = 6;
            this.textBoxReturnPeriod.Text = "3";
            this.textBoxReturnPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonCalculateDesignStormIntensity
            // 
            this.buttonCalculateDesignStormIntensity.Location = new System.Drawing.Point(360, 594);
            this.buttonCalculateDesignStormIntensity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCalculateDesignStormIntensity.Name = "buttonCalculateDesignStormIntensity";
            this.buttonCalculateDesignStormIntensity.Size = new System.Drawing.Size(513, 47);
            this.buttonCalculateDesignStormIntensity.TabIndex = 16;
            this.buttonCalculateDesignStormIntensity.Text = "计  算";
            this.buttonCalculateDesignStormIntensity.UseVisualStyleBackColor = true;
            this.buttonCalculateDesignStormIntensity.Click += new System.EventHandler(this.buttonCalculateDesignStormIntensity_Click);
            // 
            // buttonShowReturnPeriodValue
            // 
            this.buttonShowReturnPeriodValue.Location = new System.Drawing.Point(52, 105);
            this.buttonShowReturnPeriodValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonShowReturnPeriodValue.Name = "buttonShowReturnPeriodValue";
            this.buttonShowReturnPeriodValue.Size = new System.Drawing.Size(200, 33);
            this.buttonShowReturnPeriodValue.TabIndex = 14;
            this.buttonShowReturnPeriodValue.Text = "重现期 P（年）";
            this.buttonShowReturnPeriodValue.UseVisualStyleBackColor = true;
            this.buttonShowReturnPeriodValue.Click += new System.EventHandler(this.buttonShowReturnPeriodValue_Click);
            // 
            // buttonCalWeightedRunoffCoefficient
            // 
            this.buttonCalWeightedRunoffCoefficient.Location = new System.Drawing.Point(51, 209);
            this.buttonCalWeightedRunoffCoefficient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCalWeightedRunoffCoefficient.Name = "buttonCalWeightedRunoffCoefficient";
            this.buttonCalWeightedRunoffCoefficient.Size = new System.Drawing.Size(200, 33);
            this.buttonCalWeightedRunoffCoefficient.TabIndex = 15;
            this.buttonCalWeightedRunoffCoefficient.Text = "综合径流系数ψ";
            this.buttonCalWeightedRunoffCoefficient.UseVisualStyleBackColor = true;
            this.buttonCalWeightedRunoffCoefficient.Click += new System.EventHandler(this.buttonCalWeightedRunoffCoefficient_Click);
            // 
            // textBoxWeightedRunoffCoefficient
            // 
            this.textBoxWeightedRunoffCoefficient.Location = new System.Drawing.Point(311, 209);
            this.textBoxWeightedRunoffCoefficient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxWeightedRunoffCoefficient.Name = "textBoxWeightedRunoffCoefficient";
            this.textBoxWeightedRunoffCoefficient.Size = new System.Drawing.Size(150, 27);
            this.textBoxWeightedRunoffCoefficient.TabIndex = 9;
            this.textBoxWeightedRunoffCoefficient.Text = "0.65";
            this.textBoxWeightedRunoffCoefficient.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTotalArea
            // 
            this.textBoxTotalArea.Location = new System.Drawing.Point(312, 157);
            this.textBoxTotalArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTotalArea.Name = "textBoxTotalArea";
            this.textBoxTotalArea.Size = new System.Drawing.Size(150, 27);
            this.textBoxTotalArea.TabIndex = 8;
            this.textBoxTotalArea.Text = "10000";
            this.textBoxTotalArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_Q
            // 
            this.label_Q.AutoSize = true;
            this.label_Q.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Q.Location = new System.Drawing.Point(15, 41);
            this.label_Q.Name = "label_Q";
            this.label_Q.Size = new System.Drawing.Size(83, 20);
            this.label_Q.TabIndex = 20;
            this.label_Q.Text = "Q = qψF = ";
            // 
            // labelDesignRunoffFlow
            // 
            this.labelDesignRunoffFlow.AutoSize = true;
            this.labelDesignRunoffFlow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDesignRunoffFlow.Location = new System.Drawing.Point(771, 516);
            this.labelDesignRunoffFlow.Name = "labelDesignRunoffFlow";
            this.labelDesignRunoffFlow.Size = new System.Drawing.Size(68, 20);
            this.labelDesignRunoffFlow.TabIndex = 20;
            this.labelDesignRunoffFlow.Text = "（L/s·ha)";
            // 
            // groupBoxDesignFlow
            // 
            this.groupBoxDesignFlow.Controls.Add(this.textBoxDesignRunoffFlow);
            this.groupBoxDesignFlow.Controls.Add(this.label_Q);
            this.groupBoxDesignFlow.Location = new System.Drawing.Point(360, 477);
            this.groupBoxDesignFlow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxDesignFlow.Name = "groupBoxDesignFlow";
            this.groupBoxDesignFlow.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxDesignFlow.Size = new System.Drawing.Size(512, 91);
            this.groupBoxDesignFlow.TabIndex = 17;
            this.groupBoxDesignFlow.TabStop = false;
            this.groupBoxDesignFlow.Text = "设计总流量（L/s）";
            // 
            // textBoxDesignRunoffFlow
            // 
            this.textBoxDesignRunoffFlow.Location = new System.Drawing.Point(309, 34);
            this.textBoxDesignRunoffFlow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDesignRunoffFlow.Name = "textBoxDesignRunoffFlow";
            this.textBoxDesignRunoffFlow.ReadOnly = true;
            this.textBoxDesignRunoffFlow.Size = new System.Drawing.Size(100, 27);
            this.textBoxDesignRunoffFlow.TabIndex = 20;
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
            this.groupBoxDesignRainfallDensity.Location = new System.Drawing.Point(360, 331);
            this.groupBoxDesignRainfallDensity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxDesignRainfallDensity.Name = "groupBoxDesignRainfallDensity";
            this.groupBoxDesignRainfallDensity.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxDesignRainfallDensity.Size = new System.Drawing.Size(512, 128);
            this.groupBoxDesignRainfallDensity.TabIndex = 18;
            this.groupBoxDesignRainfallDensity.TabStop = false;
            this.groupBoxDesignRainfallDensity.Text = "设计暴雨强度（L/s）";
            // 
            // textBoxDesignStormDensity
            // 
            this.textBoxDesignStormDensity.Location = new System.Drawing.Point(309, 62);
            this.textBoxDesignStormDensity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDesignStormDensity.Name = "textBoxDesignStormDensity";
            this.textBoxDesignStormDensity.ReadOnly = true;
            this.textBoxDesignStormDensity.Size = new System.Drawing.Size(100, 27);
            this.textBoxDesignStormDensity.TabIndex = 8;
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
            this.groupBox1.Location = new System.Drawing.Point(361, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(512, 280);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设计参数";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(51, 157);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 33);
            this.button3.TabIndex = 22;
            this.button3.Text = "汇水面积 F（平方米）";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 53);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 33);
            this.button1.TabIndex = 20;
            this.button1.Text = "雨水流行时间 t（min）";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.listBoxDocument);
            this.groupBox2.Location = new System.Drawing.Point(19, 33);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(326, 608);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "暴雨强度公式";
            // 
            // RainfallControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxDesignRainfallDensity);
            this.Controls.Add(this.buttonCalculateDesignStormIntensity);
            this.Controls.Add(this.labelDesignRunoffFlow);
            this.Controls.Add(this.listBoxRegion);
            this.Controls.Add(this.listBoxCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxProvince);
            this.Controls.Add(this.groupBoxDesignFlow);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "RainfallControl";
            this.Size = new System.Drawing.Size(909, 678);
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
        private System.Windows.Forms.Label label_Q;
        private System.Windows.Forms.Label labelDesignRunoffFlow;
        private System.Windows.Forms.GroupBox groupBoxDesignFlow;
        private System.Windows.Forms.GroupBox groupBoxDesignRainfallDensity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxDesignStormDensity;
        private System.Windows.Forms.TextBox textBoxDesignRunoffFlow;
    }
}
