﻿namespace STools
{
    partial class CalculatePipe
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxPipeMaterial = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonSlope = new System.Windows.Forms.RadioButton();
            this.radioButtonVelocity = new System.Windows.Forms.RadioButton();
            this.radioButtonDiameter = new System.Windows.Forms.RadioButton();
            this.textBoxInputSlope = new System.Windows.Forms.TextBox();
            this.textBoxInputVelocity = new System.Windows.Forms.TextBox();
            this.textBoxInputDiameter = new System.Windows.Forms.TextBox();
            this.listBoxSlope = new System.Windows.Forms.ListBox();
            this.listBoxVelocity = new System.Windows.Forms.ListBox();
            this.listBoxDiameter = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxRoughness = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSlope = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxVelocity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDiameter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxConveyanceCapactiy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPipeMaterial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDesignTotalRunoffFlow = new System.Windows.Forms.TextBox();
            this.labelTotalRunoffFlow = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxInputRoughness = new System.Windows.Forms.TextBox();
            this.listBoxRoughness = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxPipeMaterial);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "管道材料";
            // 
            // listBoxPipeMaterial
            // 
            this.listBoxPipeMaterial.FormattingEnabled = true;
            this.listBoxPipeMaterial.ItemHeight = 15;
            this.listBoxPipeMaterial.Items.AddRange(new object[] {
            "球磨铸铁管",
            "混凝土管",
            "PE双壁波纹管",
            "UPVC双壁波纹管",
            "UPVC加筋管"});
            this.listBoxPipeMaterial.Location = new System.Drawing.Point(12, 28);
            this.listBoxPipeMaterial.Name = "listBoxPipeMaterial";
            this.listBoxPipeMaterial.Size = new System.Drawing.Size(130, 124);
            this.listBoxPipeMaterial.TabIndex = 1;
            this.listBoxPipeMaterial.SelectedIndexChanged += new System.EventHandler(this.listBoxPipeMaterial_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonSlope);
            this.groupBox2.Controls.Add(this.radioButtonVelocity);
            this.groupBox2.Controls.Add(this.radioButtonDiameter);
            this.groupBox2.Controls.Add(this.textBoxInputSlope);
            this.groupBox2.Controls.Add(this.textBoxInputVelocity);
            this.groupBox2.Controls.Add(this.textBoxInputDiameter);
            this.groupBox2.Controls.Add(this.listBoxSlope);
            this.groupBox2.Controls.Add(this.listBoxVelocity);
            this.groupBox2.Controls.Add(this.listBoxDiameter);
            this.groupBox2.Location = new System.Drawing.Point(177, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 341);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设计管段参数";
            // 
            // radioButtonSlope
            // 
            this.radioButtonSlope.AutoSize = true;
            this.radioButtonSlope.Location = new System.Drawing.Point(262, 24);
            this.radioButtonSlope.Name = "radioButtonSlope";
            this.radioButtonSlope.Size = new System.Drawing.Size(89, 19);
            this.radioButtonSlope.TabIndex = 11;
            this.radioButtonSlope.TabStop = true;
            this.radioButtonSlope.Text = "坡度(‰)";
            this.radioButtonSlope.UseVisualStyleBackColor = true;
            this.radioButtonSlope.CheckedChanged += new System.EventHandler(this.radioButtonSlope_CheckedChanged);
            // 
            // radioButtonVelocity
            // 
            this.radioButtonVelocity.AutoSize = true;
            this.radioButtonVelocity.Location = new System.Drawing.Point(133, 24);
            this.radioButtonVelocity.Name = "radioButtonVelocity";
            this.radioButtonVelocity.Size = new System.Drawing.Size(98, 19);
            this.radioButtonVelocity.TabIndex = 10;
            this.radioButtonVelocity.TabStop = true;
            this.radioButtonVelocity.Text = "流速(m/s)";
            this.radioButtonVelocity.UseVisualStyleBackColor = true;
            this.radioButtonVelocity.CheckedChanged += new System.EventHandler(this.radioButtonVelocity_CheckedChanged);
            // 
            // radioButtonDiameter
            // 
            this.radioButtonDiameter.AutoSize = true;
            this.radioButtonDiameter.Location = new System.Drawing.Point(10, 25);
            this.radioButtonDiameter.Name = "radioButtonDiameter";
            this.radioButtonDiameter.Size = new System.Drawing.Size(90, 19);
            this.radioButtonDiameter.TabIndex = 9;
            this.radioButtonDiameter.TabStop = true;
            this.radioButtonDiameter.Text = "管径(mm)";
            this.radioButtonDiameter.UseVisualStyleBackColor = true;
            this.radioButtonDiameter.CheckedChanged += new System.EventHandler(this.radioButtonDiameter_CheckedChanged);
            // 
            // textBoxInputSlope
            // 
            this.textBoxInputSlope.Location = new System.Drawing.Point(262, 300);
            this.textBoxInputSlope.Name = "textBoxInputSlope";
            this.textBoxInputSlope.Size = new System.Drawing.Size(100, 25);
            this.textBoxInputSlope.TabIndex = 8;
            // 
            // textBoxInputVelocity
            // 
            this.textBoxInputVelocity.Location = new System.Drawing.Point(133, 300);
            this.textBoxInputVelocity.Name = "textBoxInputVelocity";
            this.textBoxInputVelocity.Size = new System.Drawing.Size(100, 25);
            this.textBoxInputVelocity.TabIndex = 7;
            // 
            // textBoxInputDiameter
            // 
            this.textBoxInputDiameter.Location = new System.Drawing.Point(10, 300);
            this.textBoxInputDiameter.Name = "textBoxInputDiameter";
            this.textBoxInputDiameter.Size = new System.Drawing.Size(100, 25);
            this.textBoxInputDiameter.TabIndex = 6;
            // 
            // listBoxSlope
            // 
            this.listBoxSlope.FormattingEnabled = true;
            this.listBoxSlope.ItemHeight = 15;
            this.listBoxSlope.Items.AddRange(new object[] {
            "1.0",
            "2.0",
            "3.0",
            "4.0",
            "5.0",
            "6.0",
            "7.0",
            "8.0",
            "9.0",
            "10.0",
            "15.0",
            "20.0",
            "25.0",
            "30.0",
            "35.0",
            "40.0",
            "45.0",
            "50.0",
            "60.0",
            "70.0",
            "80.0",
            "90.0",
            "100.0"});
            this.listBoxSlope.Location = new System.Drawing.Point(262, 56);
            this.listBoxSlope.Name = "listBoxSlope";
            this.listBoxSlope.Size = new System.Drawing.Size(100, 229);
            this.listBoxSlope.TabIndex = 5;
            this.listBoxSlope.SelectedIndexChanged += new System.EventHandler(this.listBoxSlope_SelectedIndexChanged);
            // 
            // listBoxVelocity
            // 
            this.listBoxVelocity.FormattingEnabled = true;
            this.listBoxVelocity.ItemHeight = 15;
            this.listBoxVelocity.Items.AddRange(new object[] {
            "0.1",
            "0.2",
            "0.3",
            "0.4",
            "0.5",
            "0.6",
            "0.7",
            "0.8",
            "0.9",
            "1.0",
            "1.1",
            "1.2",
            "1.3",
            "1.4",
            "1.5",
            "1.6",
            "1.7",
            "1.8",
            "1.9",
            "2.0"});
            this.listBoxVelocity.Location = new System.Drawing.Point(133, 56);
            this.listBoxVelocity.Name = "listBoxVelocity";
            this.listBoxVelocity.Size = new System.Drawing.Size(100, 229);
            this.listBoxVelocity.TabIndex = 4;
            this.listBoxVelocity.SelectedIndexChanged += new System.EventHandler(this.listBoxVelocity_SelectedIndexChanged);
            // 
            // listBoxDiameter
            // 
            this.listBoxDiameter.FormattingEnabled = true;
            this.listBoxDiameter.ItemHeight = 15;
            this.listBoxDiameter.Items.AddRange(new object[] {
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000",
            "1200",
            "1400",
            "1500",
            "1600",
            "1800",
            "2000"});
            this.listBoxDiameter.Location = new System.Drawing.Point(10, 56);
            this.listBoxDiameter.Name = "listBoxDiameter";
            this.listBoxDiameter.Size = new System.Drawing.Size(100, 229);
            this.listBoxDiameter.TabIndex = 3;
            this.listBoxDiameter.SelectedIndexChanged += new System.EventHandler(this.listBoxDiameter_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxRoughness);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBoxSlope);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBoxVelocity);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxDiameter);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBoxConveyanceCapactiy);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBoxPipeMaterial);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBoxDesignTotalRunoffFlow);
            this.groupBox3.Controls.Add(this.labelTotalRunoffFlow);
            this.groupBox3.Location = new System.Drawing.Point(13, 363);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(537, 141);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "计算结果";
            // 
            // textBoxRoughness
            // 
            this.textBoxRoughness.Location = new System.Drawing.Point(443, 101);
            this.textBoxRoughness.Name = "textBoxRoughness";
            this.textBoxRoughness.Size = new System.Drawing.Size(80, 25);
            this.textBoxRoughness.TabIndex = 13;
            this.textBoxRoughness.TextChanged += new System.EventHandler(this.textBoxRoughness_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(443, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "粗糙系数";
            // 
            // textBoxSlope
            // 
            this.textBoxSlope.Location = new System.Drawing.Point(352, 101);
            this.textBoxSlope.Name = "textBoxSlope";
            this.textBoxSlope.Size = new System.Drawing.Size(80, 25);
            this.textBoxSlope.TabIndex = 11;
            this.textBoxSlope.TextChanged += new System.EventHandler(this.textBoxSlope_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "坡度(‰)";
            // 
            // textBoxVelocity
            // 
            this.textBoxVelocity.Location = new System.Drawing.Point(261, 101);
            this.textBoxVelocity.Name = "textBoxVelocity";
            this.textBoxVelocity.Size = new System.Drawing.Size(80, 25);
            this.textBoxVelocity.TabIndex = 9;
            this.textBoxVelocity.TextChanged += new System.EventHandler(this.textBoxVelocity_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "流速(m/s)";
            // 
            // textBoxDiameter
            // 
            this.textBoxDiameter.Location = new System.Drawing.Point(171, 101);
            this.textBoxDiameter.Name = "textBoxDiameter";
            this.textBoxDiameter.Size = new System.Drawing.Size(80, 25);
            this.textBoxDiameter.TabIndex = 7;
            this.textBoxDiameter.TextChanged += new System.EventHandler(this.textBoxDiameter_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "管径(mm)";
            // 
            // textBoxConveyanceCapactiy
            // 
            this.textBoxConveyanceCapactiy.Location = new System.Drawing.Point(9, 101);
            this.textBoxConveyanceCapactiy.Name = "textBoxConveyanceCapactiy";
            this.textBoxConveyanceCapactiy.ReadOnly = true;
            this.textBoxConveyanceCapactiy.Size = new System.Drawing.Size(146, 25);
            this.textBoxConveyanceCapactiy.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "管道过流能力(m^3/s)";
            // 
            // textBoxPipeMaterial
            // 
            this.textBoxPipeMaterial.Location = new System.Drawing.Point(171, 40);
            this.textBoxPipeMaterial.Name = "textBoxPipeMaterial";
            this.textBoxPipeMaterial.ReadOnly = true;
            this.textBoxPipeMaterial.Size = new System.Drawing.Size(352, 25);
            this.textBoxPipeMaterial.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "管道材料";
            // 
            // textBoxDesignTotalRunoffFlow
            // 
            this.textBoxDesignTotalRunoffFlow.Location = new System.Drawing.Point(9, 40);
            this.textBoxDesignTotalRunoffFlow.Name = "textBoxDesignTotalRunoffFlow";
            this.textBoxDesignTotalRunoffFlow.ReadOnly = true;
            this.textBoxDesignTotalRunoffFlow.Size = new System.Drawing.Size(146, 25);
            this.textBoxDesignTotalRunoffFlow.TabIndex = 1;
            // 
            // labelTotalRunoffFlow
            // 
            this.labelTotalRunoffFlow.AutoSize = true;
            this.labelTotalRunoffFlow.Location = new System.Drawing.Point(9, 21);
            this.labelTotalRunoffFlow.Name = "labelTotalRunoffFlow";
            this.labelTotalRunoffFlow.Size = new System.Drawing.Size(97, 15);
            this.labelTotalRunoffFlow.TabIndex = 0;
            this.labelTotalRunoffFlow.Text = "设计总径流量";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "查看规范";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(319, 514);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 30);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "确认";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(450, 514);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 30);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxInputRoughness);
            this.groupBox4.Controls.Add(this.listBoxRoughness);
            this.groupBox4.Location = new System.Drawing.Point(13, 194);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(155, 160);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "粗糙系数";
            // 
            // textBoxInputRoughness
            // 
            this.textBoxInputRoughness.Location = new System.Drawing.Point(12, 119);
            this.textBoxInputRoughness.Name = "textBoxInputRoughness";
            this.textBoxInputRoughness.Size = new System.Drawing.Size(130, 25);
            this.textBoxInputRoughness.TabIndex = 1;
            // 
            // listBoxRoughness
            // 
            this.listBoxRoughness.FormattingEnabled = true;
            this.listBoxRoughness.ItemHeight = 15;
            this.listBoxRoughness.Items.AddRange(new object[] {
            "0.013"});
            this.listBoxRoughness.Location = new System.Drawing.Point(12, 25);
            this.listBoxRoughness.Name = "listBoxRoughness";
            this.listBoxRoughness.Size = new System.Drawing.Size(130, 79);
            this.listBoxRoughness.TabIndex = 0;
            this.listBoxRoughness.SelectedIndexChanged += new System.EventHandler(this.listBoxRoughness_SelectedIndexChanged);
            // 
            // CalculatePipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 553);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CalculatePipe";
            this.Text = "管段设计参数";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CalculatePipe_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxPipeMaterial;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxDiameter;
        private System.Windows.Forms.ListBox listBoxSlope;
        private System.Windows.Forms.ListBox listBoxVelocity;
        private System.Windows.Forms.TextBox textBoxInputSlope;
        private System.Windows.Forms.TextBox textBoxInputVelocity;
        private System.Windows.Forms.TextBox textBoxInputDiameter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDesignTotalRunoffFlow;
        private System.Windows.Forms.Label labelTotalRunoffFlow;
        private System.Windows.Forms.TextBox textBoxConveyanceCapactiy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPipeMaterial;
        private System.Windows.Forms.TextBox textBoxDiameter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSlope;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxVelocity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxRoughness;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxInputRoughness;
        private System.Windows.Forms.ListBox listBoxRoughness;
        private System.Windows.Forms.RadioButton radioButtonDiameter;
        private System.Windows.Forms.RadioButton radioButtonVelocity;
        private System.Windows.Forms.RadioButton radioButtonSlope;
    }
}