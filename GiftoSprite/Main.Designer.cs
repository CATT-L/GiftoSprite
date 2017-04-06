namespace GiftoSprite
{
    partial class GiftoSprite
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.export = new System.Windows.Forms.Button();
            this.labelGifPath = new System.Windows.Forms.Label();
            this.import = new System.Windows.Forms.Button();
            this.radioRow = new System.Windows.Forms.RadioButton();
            this.radioCol = new System.Windows.Forms.RadioButton();
            this.radioCus = new System.Windows.Forms.RadioButton();
            this.txtRCInfo = new System.Windows.Forms.Label();
            this.labelImgSize = new System.Windows.Forms.Label();
            this.labelImgCount = new System.Windows.Forms.Label();
            this.labelImgOut = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(246, 81);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(75, 23);
            this.export.TabIndex = 1;
            this.export.Text = "导出";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // labelGifPath
            // 
            this.labelGifPath.Location = new System.Drawing.Point(93, 17);
            this.labelGifPath.Name = "labelGifPath";
            this.labelGifPath.Size = new System.Drawing.Size(242, 15);
            this.labelGifPath.TabIndex = 0;
            this.labelGifPath.Text = "Gif 路径";
            // 
            // import
            // 
            this.import.Location = new System.Drawing.Point(12, 12);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(75, 23);
            this.import.TabIndex = 2;
            this.import.Text = "导入";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // radioRow
            // 
            this.radioRow.AutoSize = true;
            this.radioRow.Location = new System.Drawing.Point(70, 42);
            this.radioRow.Name = "radioRow";
            this.radioRow.Size = new System.Drawing.Size(49, 17);
            this.radioRow.TabIndex = 3;
            this.radioRow.Text = "单行";
            this.radioRow.UseVisualStyleBackColor = true;
            this.radioRow.CheckedChanged += new System.EventHandler(this.radioRow_CheckedChanged);
            // 
            // radioCol
            // 
            this.radioCol.AutoSize = true;
            this.radioCol.Location = new System.Drawing.Point(12, 42);
            this.radioCol.Name = "radioCol";
            this.radioCol.Size = new System.Drawing.Size(52, 17);
            this.radioCol.TabIndex = 4;
            this.radioCol.Text = " 单列";
            this.radioCol.UseVisualStyleBackColor = true;
            this.radioCol.CheckedChanged += new System.EventHandler(this.radioCol_CheckedChanged);
            // 
            // radioCus
            // 
            this.radioCus.AutoSize = true;
            this.radioCus.Location = new System.Drawing.Point(125, 42);
            this.radioCus.Name = "radioCus";
            this.radioCus.Size = new System.Drawing.Size(73, 17);
            this.radioCus.TabIndex = 5;
            this.radioCus.Text = "多行多列";
            this.radioCus.UseVisualStyleBackColor = true;
            this.radioCus.CheckedChanged += new System.EventHandler(this.radioCus_CheckedChanged);
            // 
            // txtRCInfo
            // 
            this.txtRCInfo.AutoSize = true;
            this.txtRCInfo.Location = new System.Drawing.Point(216, 46);
            this.txtRCInfo.Name = "txtRCInfo";
            this.txtRCInfo.Size = new System.Drawing.Size(0, 13);
            this.txtRCInfo.TabIndex = 7;
            // 
            // labelImgSize
            // 
            this.labelImgSize.AutoSize = true;
            this.labelImgSize.Location = new System.Drawing.Point(13, 66);
            this.labelImgSize.Name = "labelImgSize";
            this.labelImgSize.Size = new System.Drawing.Size(43, 13);
            this.labelImgSize.TabIndex = 10;
            this.labelImgSize.Text = "尺寸：";
            // 
            // labelImgCount
            // 
            this.labelImgCount.AutoSize = true;
            this.labelImgCount.Location = new System.Drawing.Point(125, 66);
            this.labelImgCount.Name = "labelImgCount";
            this.labelImgCount.Size = new System.Drawing.Size(43, 13);
            this.labelImgCount.TabIndex = 11;
            this.labelImgCount.Text = "帧数：";
            // 
            // labelImgOut
            // 
            this.labelImgOut.Location = new System.Drawing.Point(12, 86);
            this.labelImgOut.Name = "labelImgOut";
            this.labelImgOut.Size = new System.Drawing.Size(227, 15);
            this.labelImgOut.TabIndex = 12;
            this.labelImgOut.Text = "输出路径：";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(11, 106);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(113, 13);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ver 1.0    CATT-L.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // GiftoSprite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 122);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.import);
            this.Controls.Add(this.export);
            this.Controls.Add(this.labelImgCount);
            this.Controls.Add(this.labelImgSize);
            this.Controls.Add(this.txtRCInfo);
            this.Controls.Add(this.radioCus);
            this.Controls.Add(this.radioCol);
            this.Controls.Add(this.radioRow);
            this.Controls.Add(this.labelGifPath);
            this.Controls.Add(this.labelImgOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 160);
            this.MinimumSize = new System.Drawing.Size(350, 160);
            this.Name = "GiftoSprite";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "如何将GIF转换静态Sprite？";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.Label labelGifPath;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.RadioButton radioRow;
        private System.Windows.Forms.RadioButton radioCol;
        private System.Windows.Forms.RadioButton radioCus;
        private System.Windows.Forms.Label txtRCInfo;
        private System.Windows.Forms.Label labelImgSize;
        private System.Windows.Forms.Label labelImgCount;
        private System.Windows.Forms.Label labelImgOut;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

