namespace STools
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageManagement = new System.Windows.Forms.TabPage();
            this.tabPageHotWater = new System.Windows.Forms.TabPage();
            this.tabPageFireWater = new System.Windows.Forms.TabPage();
            this.tabPageWasteWater = new System.Windows.Forms.TabPage();
            this.tabPageRainfall = new System.Windows.Forms.TabPage();
            this.rainfallControl1 = new STools.RainfallControl();
            this.tabPageSponge = new System.Windows.Forms.TabPage();
            this.spongeControl1 = new STools.SpongeControl();
            this.tabPageCriterion = new System.Windows.Forms.TabPage();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.tabPageWaterSupply = new System.Windows.Forms.TabPage();
            this.waterSupplyControl1 = new STools.WaterSupplyControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageRainfall.SuspendLayout();
            this.tabPageSponge.SuspendLayout();
            this.tabPageWaterSupply.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(758, 709);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageManagement);
            this.tabControl1.Controls.Add(this.tabPageWaterSupply);
            this.tabControl1.Controls.Add(this.tabPageHotWater);
            this.tabControl1.Controls.Add(this.tabPageFireWater);
            this.tabControl1.Controls.Add(this.tabPageWasteWater);
            this.tabControl1.Controls.Add(this.tabPageRainfall);
            this.tabControl1.Controls.Add(this.tabPageSponge);
            this.tabControl1.Controls.Add(this.tabPageCriterion);
            this.tabControl1.Controls.Add(this.tabPageAbout);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(752, 703);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPageManagement
            // 
            this.tabPageManagement.Location = new System.Drawing.Point(4, 29);
            this.tabPageManagement.Name = "tabPageManagement";
            this.tabPageManagement.Size = new System.Drawing.Size(744, 670);
            this.tabPageManagement.TabIndex = 1;
            this.tabPageManagement.Text = "项目管理";
            this.tabPageManagement.UseVisualStyleBackColor = true;
            // 
            // tabPageHotWater
            // 
            this.tabPageHotWater.Location = new System.Drawing.Point(4, 29);
            this.tabPageHotWater.Name = "tabPageHotWater";
            this.tabPageHotWater.Size = new System.Drawing.Size(744, 670);
            this.tabPageHotWater.TabIndex = 3;
            this.tabPageHotWater.Text = "热水";
            this.tabPageHotWater.UseVisualStyleBackColor = true;
            // 
            // tabPageFireWater
            // 
            this.tabPageFireWater.Location = new System.Drawing.Point(4, 29);
            this.tabPageFireWater.Name = "tabPageFireWater";
            this.tabPageFireWater.Size = new System.Drawing.Size(744, 670);
            this.tabPageFireWater.TabIndex = 4;
            this.tabPageFireWater.Text = "消防";
            this.tabPageFireWater.UseVisualStyleBackColor = true;
            // 
            // tabPageWasteWater
            // 
            this.tabPageWasteWater.Location = new System.Drawing.Point(4, 29);
            this.tabPageWasteWater.Name = "tabPageWasteWater";
            this.tabPageWasteWater.Size = new System.Drawing.Size(744, 670);
            this.tabPageWasteWater.TabIndex = 5;
            this.tabPageWasteWater.Text = "污废水";
            this.tabPageWasteWater.UseVisualStyleBackColor = true;
            // 
            // tabPageRainfall
            // 
            this.tabPageRainfall.Controls.Add(this.rainfallControl1);
            this.tabPageRainfall.Location = new System.Drawing.Point(4, 29);
            this.tabPageRainfall.Name = "tabPageRainfall";
            this.tabPageRainfall.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRainfall.Size = new System.Drawing.Size(744, 670);
            this.tabPageRainfall.TabIndex = 0;
            this.tabPageRainfall.Text = "雨水";
            this.tabPageRainfall.UseVisualStyleBackColor = true;
            // 
            // rainfallControl1
            // 
            this.rainfallControl1.AutoScroll = true;
            this.rainfallControl1.AutoSize = true;
            this.rainfallControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rainfallControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rainfallControl1.Location = new System.Drawing.Point(3, 3);
            this.rainfallControl1.Margin = new System.Windows.Forms.Padding(0);
            this.rainfallControl1.Name = "rainfallControl1";
            this.rainfallControl1.Size = new System.Drawing.Size(738, 664);
            this.rainfallControl1.TabIndex = 0;
            // 
            // tabPageSponge
            // 
            this.tabPageSponge.Controls.Add(this.spongeControl1);
            this.tabPageSponge.Location = new System.Drawing.Point(4, 29);
            this.tabPageSponge.Name = "tabPageSponge";
            this.tabPageSponge.Size = new System.Drawing.Size(744, 670);
            this.tabPageSponge.TabIndex = 6;
            this.tabPageSponge.Text = "海绵";
            this.tabPageSponge.UseVisualStyleBackColor = true;
            // 
            // spongeControl1
            // 
            this.spongeControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spongeControl1.Location = new System.Drawing.Point(0, 4);
            this.spongeControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spongeControl1.Name = "spongeControl1";
            this.spongeControl1.Size = new System.Drawing.Size(750, 678);
            this.spongeControl1.TabIndex = 0;
            // 
            // tabPageCriterion
            // 
            this.tabPageCriterion.Location = new System.Drawing.Point(4, 29);
            this.tabPageCriterion.Name = "tabPageCriterion";
            this.tabPageCriterion.Size = new System.Drawing.Size(744, 670);
            this.tabPageCriterion.TabIndex = 7;
            this.tabPageCriterion.Text = "规范";
            this.tabPageCriterion.UseVisualStyleBackColor = true;
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Location = new System.Drawing.Point(4, 29);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Size = new System.Drawing.Size(744, 670);
            this.tabPageAbout.TabIndex = 8;
            this.tabPageAbout.Text = "关于";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // tabPageWaterSupply
            // 
            this.tabPageWaterSupply.Controls.Add(this.waterSupplyControl1);
            this.tabPageWaterSupply.Location = new System.Drawing.Point(4, 29);
            this.tabPageWaterSupply.Name = "tabPageWaterSupply";
            this.tabPageWaterSupply.Size = new System.Drawing.Size(744, 670);
            this.tabPageWaterSupply.TabIndex = 2;
            this.tabPageWaterSupply.Text = "给水";
            this.tabPageWaterSupply.UseVisualStyleBackColor = true;
            // 
            // waterSupplyControl1
            // 
            this.waterSupplyControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waterSupplyControl1.Location = new System.Drawing.Point(6, 4);
            this.waterSupplyControl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.waterSupplyControl1.Name = "waterSupplyControl1";
            this.waterSupplyControl1.Size = new System.Drawing.Size(750, 678);
            this.waterSupplyControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 709);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "给排水工具STools";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageRainfall.ResumeLayout(false);
            this.tabPageRainfall.PerformLayout();
            this.tabPageSponge.ResumeLayout(false);
            this.tabPageWaterSupply.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRainfall;
        private RainfallControl rainfallControl1;
        private System.Windows.Forms.TabPage tabPageManagement;
        private System.Windows.Forms.TabPage tabPageHotWater;
        private System.Windows.Forms.TabPage tabPageFireWater;
        private System.Windows.Forms.TabPage tabPageWasteWater;
        private System.Windows.Forms.TabPage tabPageSponge;
        private System.Windows.Forms.TabPage tabPageCriterion;
        private System.Windows.Forms.TabPage tabPageAbout;
        private SpongeControl spongeControl1;
        private System.Windows.Forms.TabPage tabPageWaterSupply;
        private WaterSupplyControl waterSupplyControl1;
    }
}

