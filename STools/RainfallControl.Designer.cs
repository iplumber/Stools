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
            this.labelResult = new System.Windows.Forms.Label();
            this.labelExponent = new System.Windows.Forms.Label();
            this.textBoxTestXml = new System.Windows.Forms.TextBox();
            this.buttonXml = new System.Windows.Forms.Button();
            this.textBoxRainRoutingTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxReturnPeriod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonCalculateDesignStormIntensity = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonShowReturnPeriodValue = new System.Windows.Forms.Button();
            this.buttonCalWeightedRunoffCoefficient = new System.Windows.Forms.Button();
            this.textBoxWeightedRunoffCoefficient = new System.Windows.Forms.TextBox();
            this.textBoxTotalArea = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelDesignRunoffFlow = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxProvince
            // 
            this.comboBoxProvince.FormattingEnabled = true;
            this.comboBoxProvince.Location = new System.Drawing.Point(88, 65);
            this.comboBoxProvince.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxProvince.Name = "comboBoxProvince";
            this.comboBoxProvince.Size = new System.Drawing.Size(274, 23);
            this.comboBoxProvince.TabIndex = 2;
            this.comboBoxProvince.SelectedIndexChanged += new System.EventHandler(this.comboBoxProvince_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "选择省份：";
            // 
            // listBoxCity
            // 
            this.listBoxCity.FormattingEnabled = true;
            this.listBoxCity.ItemHeight = 15;
            this.listBoxCity.Location = new System.Drawing.Point(88, 132);
            this.listBoxCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxCity.Name = "listBoxCity";
            this.listBoxCity.Size = new System.Drawing.Size(120, 184);
            this.listBoxCity.TabIndex = 4;
            this.listBoxCity.Click += new System.EventHandler(this.listBoxCity_Click);
            // 
            // listBoxRegion
            // 
            this.listBoxRegion.FormattingEnabled = true;
            this.listBoxRegion.ItemHeight = 15;
            this.listBoxRegion.Location = new System.Drawing.Point(243, 132);
            this.listBoxRegion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxRegion.Name = "listBoxRegion";
            this.listBoxRegion.Size = new System.Drawing.Size(120, 184);
            this.listBoxRegion.TabIndex = 4;
            this.listBoxRegion.Click += new System.EventHandler(this.listBoxRegion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "选择城市：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "选择地区：";
            // 
            // listBoxDocument
            // 
            this.listBoxDocument.FormattingEnabled = true;
            this.listBoxDocument.ItemHeight = 15;
            this.listBoxDocument.Location = new System.Drawing.Point(88, 367);
            this.listBoxDocument.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxDocument.Name = "listBoxDocument";
            this.listBoxDocument.Size = new System.Drawing.Size(273, 79);
            this.listBoxDocument.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "选择公式来源：";
            // 
            // label_q_i
            // 
            this.label_q_i.AutoSize = true;
            this.label_q_i.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_q_i.Location = new System.Drawing.Point(413, 139);
            this.label_q_i.Name = "label_q_i";
            this.label_q_i.Size = new System.Drawing.Size(31, 15);
            this.label_q_i.TabIndex = 6;
            this.label_q_i.Text = "q =";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(455, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 2);
            this.label6.TabIndex = 7;
            // 
            // labelTop
            // 
            this.labelTop.AutoSize = true;
            this.labelTop.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTop.Location = new System.Drawing.Point(489, 123);
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
            this.labelBottom.Location = new System.Drawing.Point(511, 158);
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
            this.label9.Location = new System.Drawing.Point(732, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 19);
            this.label9.TabIndex = 6;
            this.label9.Text = "=";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelResult.Location = new System.Drawing.Point(783, 139);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(85, 15);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "（L/s·ha)";
            // 
            // labelExponent
            // 
            this.labelExponent.AutoSize = true;
            this.labelExponent.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelExponent.Location = new System.Drawing.Point(618, 151);
            this.labelExponent.Name = "labelExponent";
            this.labelExponent.Size = new System.Drawing.Size(15, 15);
            this.labelExponent.TabIndex = 6;
            this.labelExponent.Text = "n";
            // 
            // textBoxTestXml
            // 
            this.textBoxTestXml.Location = new System.Drawing.Point(88, 462);
            this.textBoxTestXml.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTestXml.Multiline = true;
            this.textBoxTestXml.Name = "textBoxTestXml";
            this.textBoxTestXml.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxTestXml.Size = new System.Drawing.Size(275, 167);
            this.textBoxTestXml.TabIndex = 8;
            // 
            // buttonXml
            // 
            this.buttonXml.Location = new System.Drawing.Point(412, 46);
            this.buttonXml.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonXml.Name = "buttonXml";
            this.buttonXml.Size = new System.Drawing.Size(270, 58);
            this.buttonXml.TabIndex = 9;
            this.buttonXml.Text = "OK";
            this.buttonXml.UseVisualStyleBackColor = true;
            this.buttonXml.Click += new System.EventHandler(this.buttonXml_Click);
            // 
            // textBoxRainRoutingTime
            // 
            this.textBoxRainRoutingTime.Location = new System.Drawing.Point(416, 241);
            this.textBoxRainRoutingTime.Name = "textBoxRainRoutingTime";
            this.textBoxRainRoutingTime.Size = new System.Drawing.Size(151, 25);
            this.textBoxRainRoutingTime.TabIndex = 10;
            this.textBoxRainRoutingTime.Text = "10";
            this.textBoxRainRoutingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "雨水流行时间 t（min）";
            // 
            // textBoxReturnPeriod
            // 
            this.textBoxReturnPeriod.Location = new System.Drawing.Point(600, 241);
            this.textBoxReturnPeriod.Name = "textBoxReturnPeriod";
            this.textBoxReturnPeriod.Size = new System.Drawing.Size(151, 25);
            this.textBoxReturnPeriod.TabIndex = 10;
            this.textBoxReturnPeriod.Text = "3";
            this.textBoxReturnPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(600, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "重现期 P（年）";
            // 
            // buttonCalculateDesignStormIntensity
            // 
            this.buttonCalculateDesignStormIntensity.Location = new System.Drawing.Point(736, 46);
            this.buttonCalculateDesignStormIntensity.Name = "buttonCalculateDesignStormIntensity";
            this.buttonCalculateDesignStormIntensity.Size = new System.Drawing.Size(192, 58);
            this.buttonCalculateDesignStormIntensity.TabIndex = 12;
            this.buttonCalculateDesignStormIntensity.Text = "计算";
            this.buttonCalculateDesignStormIntensity.UseVisualStyleBackColor = true;
            this.buttonCalculateDesignStormIntensity.Click += new System.EventHandler(this.buttonCalculateDesignStormIntensity_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 554);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 75);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonShowReturnPeriodValue
            // 
            this.buttonShowReturnPeriodValue.Location = new System.Drawing.Point(780, 241);
            this.buttonShowReturnPeriodValue.Name = "buttonShowReturnPeriodValue";
            this.buttonShowReturnPeriodValue.Size = new System.Drawing.Size(148, 25);
            this.buttonShowReturnPeriodValue.TabIndex = 14;
            this.buttonShowReturnPeriodValue.Text = "查看规范取值范围";
            this.buttonShowReturnPeriodValue.UseVisualStyleBackColor = true;
            this.buttonShowReturnPeriodValue.Click += new System.EventHandler(this.buttonShowReturnPeriodValue_Click);
            // 
            // buttonCalWeightedRunoffCoefficient
            // 
            this.buttonCalWeightedRunoffCoefficient.Location = new System.Drawing.Point(780, 318);
            this.buttonCalWeightedRunoffCoefficient.Name = "buttonCalWeightedRunoffCoefficient";
            this.buttonCalWeightedRunoffCoefficient.Size = new System.Drawing.Size(148, 26);
            this.buttonCalWeightedRunoffCoefficient.TabIndex = 15;
            this.buttonCalWeightedRunoffCoefficient.Text = "计算综合径流系数";
            this.buttonCalWeightedRunoffCoefficient.UseVisualStyleBackColor = true;
            this.buttonCalWeightedRunoffCoefficient.Click += new System.EventHandler(this.buttonCalWeightedRunoffCoefficient_Click);
            // 
            // textBoxWeightedRunoffCoefficient
            // 
            this.textBoxWeightedRunoffCoefficient.Location = new System.Drawing.Point(416, 318);
            this.textBoxWeightedRunoffCoefficient.Name = "textBoxWeightedRunoffCoefficient";
            this.textBoxWeightedRunoffCoefficient.Size = new System.Drawing.Size(151, 25);
            this.textBoxWeightedRunoffCoefficient.TabIndex = 16;
            this.textBoxWeightedRunoffCoefficient.Text = "0.65";
            this.textBoxWeightedRunoffCoefficient.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTotalArea
            // 
            this.textBoxTotalArea.Location = new System.Drawing.Point(600, 318);
            this.textBoxTotalArea.Name = "textBoxTotalArea";
            this.textBoxTotalArea.Size = new System.Drawing.Size(151, 25);
            this.textBoxTotalArea.TabIndex = 16;
            this.textBoxTotalArea.Text = "500";
            this.textBoxTotalArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(600, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "汇水面积 F（平方米）";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(416, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "综合径流系数ψ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(417, 407);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "Q = qψF = ";
            // 
            // labelDesignRunoffFlow
            // 
            this.labelDesignRunoffFlow.AutoSize = true;
            this.labelDesignRunoffFlow.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDesignRunoffFlow.Location = new System.Drawing.Point(521, 407);
            this.labelDesignRunoffFlow.Name = "labelDesignRunoffFlow";
            this.labelDesignRunoffFlow.Size = new System.Drawing.Size(85, 15);
            this.labelDesignRunoffFlow.TabIndex = 6;
            this.labelDesignRunoffFlow.Text = "（L/s·ha)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(416, 376);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(199, 15);
            this.label18.TabIndex = 11;
            this.label18.Text = "设计雨水流量 Q （L/s·ha)";
            // 
            // RainfallControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxTotalArea);
            this.Controls.Add(this.textBoxWeightedRunoffCoefficient);
            this.Controls.Add(this.buttonCalWeightedRunoffCoefficient);
            this.Controls.Add(this.buttonShowReturnPeriodValue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCalculateDesignStormIntensity);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxReturnPeriod);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxRainRoutingTime);
            this.Controls.Add(this.buttonXml);
            this.Controls.Add(this.textBoxTestXml);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelExponent);
            this.Controls.Add(this.labelBottom);
            this.Controls.Add(this.labelDesignRunoffFlow);
            this.Controls.Add(this.labelTop);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_q_i);
            this.Controls.Add(this.listBoxDocument);
            this.Controls.Add(this.listBoxRegion);
            this.Controls.Add(this.listBoxCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxProvince);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RainfallControl";
            this.Size = new System.Drawing.Size(1057, 670);
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
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelExponent;
        private System.Windows.Forms.TextBox textBoxTestXml;
        private System.Windows.Forms.Button buttonXml;
        private System.Windows.Forms.ListBox listBoxCity;
        private System.Windows.Forms.TextBox textBoxRainRoutingTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxReturnPeriod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonCalculateDesignStormIntensity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonShowReturnPeriodValue;
        private System.Windows.Forms.Button buttonCalWeightedRunoffCoefficient;
        private System.Windows.Forms.TextBox textBoxWeightedRunoffCoefficient;
        private System.Windows.Forms.TextBox textBoxTotalArea;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelDesignRunoffFlow;
        private System.Windows.Forms.Label label18;
    }
}
