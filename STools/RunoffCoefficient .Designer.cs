namespace STools
{
    partial class RunoffCoefficient
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
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRoofCoeff = new System.Windows.Forms.TextBox();
            this.textBoxRoofArea = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxConcreteOrAsphaltPavedCoeff = new System.Windows.Forms.TextBox();
            this.textBoxConcreteOrAsphaltPavedArea = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBlockStonePavedCoeff = new System.Windows.Forms.TextBox();
            this.textBoxBlockStonePavedArea = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxGradationStonePavedCoeff = new System.Windows.Forms.TextBox();
            this.textBoxGradationStonePavedArea = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxGravelPavedCoeff = new System.Windows.Forms.TextBox();
            this.textBoxGravelPavedArea = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNonPavedCoeff = new System.Windows.Forms.TextBox();
            this.textBoxNonPavedArea = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxParkCoeff = new System.Windows.Forms.TextBox();
            this.textBoxParkArea = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxTotalArea = new System.Windows.Forms.TextBox();
            this.textBoxWeightedRunoffCoefficient = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(107, 456);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(100, 30);
            this.buttonApply.TabIndex = 25;
            this.buttonApply.Text = "应用";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(242, 456);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 30);
            this.buttonOK.TabIndex = 26;
            this.buttonOK.Text = "确认";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(372, 456);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 30);
            this.buttonCancel.TabIndex = 27;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "下垫面类型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "径流系数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "面积（平方米）";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "屋面";
            // 
            // textBoxRoofCoeff
            // 
            this.textBoxRoofCoeff.Location = new System.Drawing.Point(199, 76);
            this.textBoxRoofCoeff.Name = "textBoxRoofCoeff";
            this.textBoxRoofCoeff.Size = new System.Drawing.Size(87, 25);
            this.textBoxRoofCoeff.TabIndex = 1;
            this.textBoxRoofCoeff.Text = "1.00";
            this.textBoxRoofCoeff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxRoofArea
            // 
            this.textBoxRoofArea.Location = new System.Drawing.Point(330, 76);
            this.textBoxRoofArea.Name = "textBoxRoofArea";
            this.textBoxRoofArea.Size = new System.Drawing.Size(91, 25);
            this.textBoxRoofArea.TabIndex = 8;
            this.textBoxRoofArea.Text = "0";
            this.textBoxRoofArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "混凝土及沥青路面";
            // 
            // textBoxConcreteOrAsphaltPavedCoeff
            // 
            this.textBoxConcreteOrAsphaltPavedCoeff.Location = new System.Drawing.Point(199, 116);
            this.textBoxConcreteOrAsphaltPavedCoeff.Name = "textBoxConcreteOrAsphaltPavedCoeff";
            this.textBoxConcreteOrAsphaltPavedCoeff.Size = new System.Drawing.Size(87, 25);
            this.textBoxConcreteOrAsphaltPavedCoeff.TabIndex = 2;
            this.textBoxConcreteOrAsphaltPavedCoeff.Text = "0.90";
            this.textBoxConcreteOrAsphaltPavedCoeff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxConcreteOrAsphaltPavedArea
            // 
            this.textBoxConcreteOrAsphaltPavedArea.Location = new System.Drawing.Point(330, 115);
            this.textBoxConcreteOrAsphaltPavedArea.Name = "textBoxConcreteOrAsphaltPavedArea";
            this.textBoxConcreteOrAsphaltPavedArea.Size = new System.Drawing.Size(91, 25);
            this.textBoxConcreteOrAsphaltPavedArea.TabIndex = 9;
            this.textBoxConcreteOrAsphaltPavedArea.Text = "0";
            this.textBoxConcreteOrAsphaltPavedArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "块石路面";
            // 
            // textBoxBlockStonePavedCoeff
            // 
            this.textBoxBlockStonePavedCoeff.Location = new System.Drawing.Point(199, 159);
            this.textBoxBlockStonePavedCoeff.Name = "textBoxBlockStonePavedCoeff";
            this.textBoxBlockStonePavedCoeff.Size = new System.Drawing.Size(87, 25);
            this.textBoxBlockStonePavedCoeff.TabIndex = 3;
            this.textBoxBlockStonePavedCoeff.Text = "0.60";
            this.textBoxBlockStonePavedCoeff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxBlockStonePavedArea
            // 
            this.textBoxBlockStonePavedArea.Location = new System.Drawing.Point(330, 158);
            this.textBoxBlockStonePavedArea.Name = "textBoxBlockStonePavedArea";
            this.textBoxBlockStonePavedArea.Size = new System.Drawing.Size(91, 25);
            this.textBoxBlockStonePavedArea.TabIndex = 10;
            this.textBoxBlockStonePavedArea.Text = "0";
            this.textBoxBlockStonePavedArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 34;
            this.label7.Text = "级配碎石路面";
            // 
            // textBoxGradationStonePavedCoeff
            // 
            this.textBoxGradationStonePavedCoeff.Location = new System.Drawing.Point(199, 199);
            this.textBoxGradationStonePavedCoeff.Name = "textBoxGradationStonePavedCoeff";
            this.textBoxGradationStonePavedCoeff.Size = new System.Drawing.Size(87, 25);
            this.textBoxGradationStonePavedCoeff.TabIndex = 4;
            this.textBoxGradationStonePavedCoeff.Text = "0.45";
            this.textBoxGradationStonePavedCoeff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxGradationStonePavedArea
            // 
            this.textBoxGradationStonePavedArea.Location = new System.Drawing.Point(330, 198);
            this.textBoxGradationStonePavedArea.Name = "textBoxGradationStonePavedArea";
            this.textBoxGradationStonePavedArea.Size = new System.Drawing.Size(91, 25);
            this.textBoxGradationStonePavedArea.TabIndex = 11;
            this.textBoxGradationStonePavedArea.Text = "0";
            this.textBoxGradationStonePavedArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 15);
            this.label8.TabIndex = 35;
            this.label8.Text = "干砖及碎石路面";
            // 
            // textBoxGravelPavedCoeff
            // 
            this.textBoxGravelPavedCoeff.Location = new System.Drawing.Point(199, 239);
            this.textBoxGravelPavedCoeff.Name = "textBoxGravelPavedCoeff";
            this.textBoxGravelPavedCoeff.Size = new System.Drawing.Size(87, 25);
            this.textBoxGravelPavedCoeff.TabIndex = 5;
            this.textBoxGravelPavedCoeff.Text = "0.40";
            this.textBoxGravelPavedCoeff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxGravelPavedArea
            // 
            this.textBoxGravelPavedArea.Location = new System.Drawing.Point(330, 238);
            this.textBoxGravelPavedArea.Name = "textBoxGravelPavedArea";
            this.textBoxGravelPavedArea.Size = new System.Drawing.Size(91, 25);
            this.textBoxGravelPavedArea.TabIndex = 12;
            this.textBoxGravelPavedArea.Text = "0";
            this.textBoxGravelPavedArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 36;
            this.label9.Text = "非铺砌地面";
            // 
            // textBoxNonPavedCoeff
            // 
            this.textBoxNonPavedCoeff.Location = new System.Drawing.Point(199, 281);
            this.textBoxNonPavedCoeff.Name = "textBoxNonPavedCoeff";
            this.textBoxNonPavedCoeff.Size = new System.Drawing.Size(87, 25);
            this.textBoxNonPavedCoeff.TabIndex = 6;
            this.textBoxNonPavedCoeff.Text = "0.30";
            this.textBoxNonPavedCoeff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxNonPavedArea
            // 
            this.textBoxNonPavedArea.Location = new System.Drawing.Point(330, 280);
            this.textBoxNonPavedArea.Name = "textBoxNonPavedArea";
            this.textBoxNonPavedArea.Size = new System.Drawing.Size(91, 25);
            this.textBoxNonPavedArea.TabIndex = 13;
            this.textBoxNonPavedArea.Text = "0";
            this.textBoxNonPavedArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 37;
            this.label10.Text = "公园绿地";
            // 
            // textBoxParkCoeff
            // 
            this.textBoxParkCoeff.Location = new System.Drawing.Point(199, 324);
            this.textBoxParkCoeff.Name = "textBoxParkCoeff";
            this.textBoxParkCoeff.Size = new System.Drawing.Size(87, 25);
            this.textBoxParkCoeff.TabIndex = 7;
            this.textBoxParkCoeff.Text = "0.15";
            this.textBoxParkCoeff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxParkArea
            // 
            this.textBoxParkArea.Location = new System.Drawing.Point(330, 323);
            this.textBoxParkArea.Name = "textBoxParkArea";
            this.textBoxParkArea.Size = new System.Drawing.Size(91, 25);
            this.textBoxParkArea.TabIndex = 14;
            this.textBoxParkArea.Text = "0";
            this.textBoxParkArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 346);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "径流系数";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxTotalArea);
            this.groupBox2.Controls.Add(this.textBoxWeightedRunoffCoefficient);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(14, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 73);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "综合径流系数";
            // 
            // textBoxTotalArea
            // 
            this.textBoxTotalArea.Location = new System.Drawing.Point(316, 28);
            this.textBoxTotalArea.Name = "textBoxTotalArea";
            this.textBoxTotalArea.Size = new System.Drawing.Size(91, 25);
            this.textBoxTotalArea.TabIndex = 23;
            this.textBoxTotalArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxWeightedRunoffCoefficient
            // 
            this.textBoxWeightedRunoffCoefficient.Location = new System.Drawing.Point(185, 29);
            this.textBoxWeightedRunoffCoefficient.Name = "textBoxWeightedRunoffCoefficient";
            this.textBoxWeightedRunoffCoefficient.Size = new System.Drawing.Size(87, 25);
            this.textBoxWeightedRunoffCoefficient.TabIndex = 22;
            this.textBoxWeightedRunoffCoefficient.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "综合地块";
            // 
            // RunoffCoefficient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 503);
            this.Controls.Add(this.textBoxParkArea);
            this.Controls.Add(this.textBoxNonPavedArea);
            this.Controls.Add(this.textBoxGravelPavedArea);
            this.Controls.Add(this.textBoxGradationStonePavedArea);
            this.Controls.Add(this.textBoxBlockStonePavedArea);
            this.Controls.Add(this.textBoxConcreteOrAsphaltPavedArea);
            this.Controls.Add(this.textBoxRoofArea);
            this.Controls.Add(this.textBoxParkCoeff);
            this.Controls.Add(this.textBoxNonPavedCoeff);
            this.Controls.Add(this.textBoxGravelPavedCoeff);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxGradationStonePavedCoeff);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxBlockStonePavedCoeff);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxConcreteOrAsphaltPavedCoeff);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxRoofCoeff);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "RunoffCoefficient";
            this.Text = "径流系数表";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RunoffCoefficient_FormClosing);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRoofCoeff;
        private System.Windows.Forms.TextBox textBoxRoofArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxConcreteOrAsphaltPavedCoeff;
        private System.Windows.Forms.TextBox textBoxConcreteOrAsphaltPavedArea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxBlockStonePavedCoeff;
        private System.Windows.Forms.TextBox textBoxBlockStonePavedArea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxGradationStonePavedCoeff;
        private System.Windows.Forms.TextBox textBoxGradationStonePavedArea;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxGravelPavedCoeff;
        private System.Windows.Forms.TextBox textBoxGravelPavedArea;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNonPavedCoeff;
        private System.Windows.Forms.TextBox textBoxNonPavedArea;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxParkCoeff;
        private System.Windows.Forms.TextBox textBoxParkArea;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxTotalArea;
        private System.Windows.Forms.TextBox textBoxWeightedRunoffCoefficient;
        private System.Windows.Forms.Label label11;
    }
}