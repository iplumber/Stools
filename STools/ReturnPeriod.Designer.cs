namespace STools
{
    partial class formReturnPeriod
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
            this.tabControlReturnPeriod = new System.Windows.Forms.TabControl();
            this.tabPageBuilding = new System.Windows.Forms.TabPage();
            this.tabPageMunicipalPipe = new System.Windows.Forms.TabPage();
            this.tabPageUrbanFlood = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buildingReturnPeriod = new STools.BuildingReturnPeriod();
            this.municipalPipeReturnPeriod = new STools.MunicipalPipeReturnPeriod();
            this.urbanFloodReturnPeriod = new STools.UrbanFloodReturnPeriod();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRetrunPeriod)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControlReturnPeriod.SuspendLayout();
            this.tabPageBuilding.SuspendLayout();
            this.tabPageMunicipalPipe.SuspendLayout();
            this.tabPageUrbanFlood.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.tabControlReturnPeriod, 0, 0);
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
            // tabControlReturnPeriod
            // 
            this.tabControlReturnPeriod.Controls.Add(this.tabPageBuilding);
            this.tabControlReturnPeriod.Controls.Add(this.tabPageMunicipalPipe);
            this.tabControlReturnPeriod.Controls.Add(this.tabPageUrbanFlood);
            this.tabControlReturnPeriod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlReturnPeriod.Location = new System.Drawing.Point(3, 3);
            this.tabControlReturnPeriod.Name = "tabControlReturnPeriod";
            this.tabControlReturnPeriod.SelectedIndex = 0;
            this.tabControlReturnPeriod.Size = new System.Drawing.Size(506, 424);
            this.tabControlReturnPeriod.TabIndex = 0;
            // 
            // tabPageBuilding
            // 
            this.tabPageBuilding.Controls.Add(this.buildingReturnPeriod);
            this.tabPageBuilding.Location = new System.Drawing.Point(4, 25);
            this.tabPageBuilding.Name = "tabPageBuilding";
            this.tabPageBuilding.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuilding.Size = new System.Drawing.Size(498, 395);
            this.tabPageBuilding.TabIndex = 0;
            this.tabPageBuilding.Text = "建筑小区";
            this.tabPageBuilding.UseVisualStyleBackColor = true;
            // 
            // tabPageMunicipalPipe
            // 
            this.tabPageMunicipalPipe.Controls.Add(this.municipalPipeReturnPeriod);
            this.tabPageMunicipalPipe.Location = new System.Drawing.Point(4, 25);
            this.tabPageMunicipalPipe.Name = "tabPageMunicipalPipe";
            this.tabPageMunicipalPipe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMunicipalPipe.Size = new System.Drawing.Size(498, 395);
            this.tabPageMunicipalPipe.TabIndex = 1;
            this.tabPageMunicipalPipe.Text = "雨水管渠";
            this.tabPageMunicipalPipe.UseVisualStyleBackColor = true;
            // 
            // tabPageUrbanFlood
            // 
            this.tabPageUrbanFlood.Controls.Add(this.urbanFloodReturnPeriod);
            this.tabPageUrbanFlood.Location = new System.Drawing.Point(4, 25);
            this.tabPageUrbanFlood.Name = "tabPageUrbanFlood";
            this.tabPageUrbanFlood.Size = new System.Drawing.Size(498, 395);
            this.tabPageUrbanFlood.TabIndex = 2;
            this.tabPageUrbanFlood.Text = "内涝防治";
            this.tabPageUrbanFlood.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonCancel, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonOK, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 433);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(506, 57);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "查看规范";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(392, 13);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 30);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOK.Location = new System.Drawing.Point(265, 13);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 30);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "确认";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buildingReturnPeriod
            // 
            this.buildingReturnPeriod.BackColor = System.Drawing.Color.Transparent;
            this.buildingReturnPeriod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buildingReturnPeriod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingReturnPeriod.Location = new System.Drawing.Point(3, 3);
            this.buildingReturnPeriod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buildingReturnPeriod.Name = "buildingReturnPeriod";
            this.buildingReturnPeriod.Size = new System.Drawing.Size(492, 389);
            this.buildingReturnPeriod.TabIndex = 0;
            // 
            // municipalPipeReturnPeriod
            // 
            this.municipalPipeReturnPeriod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.municipalPipeReturnPeriod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.municipalPipeReturnPeriod.Location = new System.Drawing.Point(3, 3);
            this.municipalPipeReturnPeriod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.municipalPipeReturnPeriod.Name = "municipalPipeReturnPeriod";
            this.municipalPipeReturnPeriod.Size = new System.Drawing.Size(492, 389);
            this.municipalPipeReturnPeriod.TabIndex = 0;
            // 
            // urbanFloodReturnPeriod
            // 
            this.urbanFloodReturnPeriod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urbanFloodReturnPeriod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urbanFloodReturnPeriod.Location = new System.Drawing.Point(0, 0);
            this.urbanFloodReturnPeriod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.urbanFloodReturnPeriod.Name = "urbanFloodReturnPeriod";
            this.urbanFloodReturnPeriod.Size = new System.Drawing.Size(498, 395);
            this.urbanFloodReturnPeriod.TabIndex = 0;
            // 
            // formReturnPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(512, 493);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBoxRetrunPeriod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "formReturnPeriod";
            this.Text = "重现期";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReturnPeriod_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRetrunPeriod)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControlReturnPeriod.ResumeLayout(false);
            this.tabPageBuilding.ResumeLayout(false);
            this.tabPageMunicipalPipe.ResumeLayout(false);
            this.tabPageUrbanFlood.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxRetrunPeriod;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControlReturnPeriod;
        private System.Windows.Forms.TabPage tabPageBuilding;
        private BuildingReturnPeriod buildingReturnPeriod;
        private System.Windows.Forms.TabPage tabPageMunicipalPipe;
        private MunicipalPipeReturnPeriod municipalPipeReturnPeriod;
        private System.Windows.Forms.TabPage tabPageUrbanFlood;
        private UrbanFloodReturnPeriod urbanFloodReturnPeriod;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button button1;
    }
}