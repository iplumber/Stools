namespace STools
{
    partial class ReturnPeriod
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
            this.pictureBoxRetrunPeriod = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buildingReturnPeriod1 = new STools.BuildingReturnPeriod();
            this.municipalPipeReturnPeriod1 = new STools.MunicipalPipeReturnPeriod();
            this.urbanFloodReturnPeriod1 = new STools.UrbanFloodReturnPeriod();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRetrunPeriod)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxRetrunPeriod
            // 
            this.pictureBoxRetrunPeriod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxRetrunPeriod.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxRetrunPeriod.Name = "pictureBoxRetrunPeriod";
            this.pictureBoxRetrunPeriod.Size = new System.Drawing.Size(512, 493);
            this.pictureBoxRetrunPeriod.TabIndex = 0;
            this.pictureBoxRetrunPeriod.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.22109F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.7789F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(512, 493);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(506, 424);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buildingReturnPeriod1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(498, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "建筑小区";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.municipalPipeReturnPeriod1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(498, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "雨水管渠";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.urbanFloodReturnPeriod1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(498, 394);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "内涝防治";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 433);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(506, 57);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(266, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "确认";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(392, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "取消";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(76, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "查看规范";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buildingReturnPeriod1
            // 
            this.buildingReturnPeriod1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buildingReturnPeriod1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingReturnPeriod1.Location = new System.Drawing.Point(3, 3);
            this.buildingReturnPeriod1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buildingReturnPeriod1.Name = "buildingReturnPeriod1";
            this.buildingReturnPeriod1.Size = new System.Drawing.Size(492, 389);
            this.buildingReturnPeriod1.TabIndex = 0;
            // 
            // municipalPipeReturnPeriod1
            // 
            this.municipalPipeReturnPeriod1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.municipalPipeReturnPeriod1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.municipalPipeReturnPeriod1.Location = new System.Drawing.Point(3, 3);
            this.municipalPipeReturnPeriod1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.municipalPipeReturnPeriod1.Name = "municipalPipeReturnPeriod1";
            this.municipalPipeReturnPeriod1.Size = new System.Drawing.Size(492, 388);
            this.municipalPipeReturnPeriod1.TabIndex = 0;
            // 
            // urbanFloodReturnPeriod1
            // 
            this.urbanFloodReturnPeriod1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urbanFloodReturnPeriod1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urbanFloodReturnPeriod1.Location = new System.Drawing.Point(0, 0);
            this.urbanFloodReturnPeriod1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.urbanFloodReturnPeriod1.Name = "urbanFloodReturnPeriod1";
            this.urbanFloodReturnPeriod1.Size = new System.Drawing.Size(498, 394);
            this.urbanFloodReturnPeriod1.TabIndex = 0;
            // 
            // ReturnPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 493);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBoxRetrunPeriod);
            this.Name = "ReturnPeriod";
            this.Text = "RetrunPeriod";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReturnPeriod_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRetrunPeriod)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxRetrunPeriod;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private BuildingReturnPeriod buildingReturnPeriod1;
        private System.Windows.Forms.TabPage tabPage2;
        private MunicipalPipeReturnPeriod municipalPipeReturnPeriod1;
        private System.Windows.Forms.TabPage tabPage3;
        private UrbanFloodReturnPeriod urbanFloodReturnPeriod1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}