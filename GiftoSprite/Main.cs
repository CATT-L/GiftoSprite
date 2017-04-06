using System;
using System.Drawing;
using System.Windows.Forms;

namespace GiftoSprite
{
    public partial class GiftoSprite : Form
    {

        string imgPath;
        string imgName;
        string outPath;
        int imgWidth;
        int imgHeight;
        int imgCount;

        int outRow;
        int outCol;


        public GiftoSprite()
        {
            InitializeComponent();
            init();
        }

        // 初始化设定
        void init()
        {
            // 属性
            imgPath = "";
            imgName = "";
            outPath = "";
            imgWidth = 0;
            imgHeight = 0;
            imgCount = 0;
            outRow = 0;
            outCol = 0;

            // 界面
            labelGifPath.Text = "Gif 路径";
            labelImgSize.Text = "尺寸:";
            labelImgCount.Text = "帧数:";
            labelImgOut.Text = "输出路径:";
            txtRCInfo.Text = "";
            radioCol.Checked = false;
            radioRow.Checked = false;
            radioCus.Checked = false;

            export.Enabled = false;
            export.Text = "导出";
        }

        // 导入GIF
        private void import_Click(object sender, EventArgs e)
        { 
            init();
            OpenFileDialog fd = new OpenFileDialog();
            try
            {
                fd.Filter = "(*.gif)|*.gif";
                fd.Multiselect = false;
                if (DialogResult.OK == fd.ShowDialog())
                {
                    imgPath = fd.FileName;
                    imgName = System.IO.Path.GetFileNameWithoutExtension(imgPath);
                    outPath = System.IO.Path.GetDirectoryName(imgPath);

                    // 获取宽高
                    Image gif = Image.FromFile(imgPath, true);
                    imgWidth = gif.Width;
                    imgHeight = gif.Height;

                    // 获取帧数
                    System.Drawing.Imaging.FrameDimension fd2 = new System.Drawing.Imaging.FrameDimension(gif.FrameDimensionsList[0]);
                    imgCount = gif.GetFrameCount(fd2);

                    if(imgCount <= 8)
                    {
                        radioRow.Checked = true;
                        outRow = 1;
                        outCol = imgCount;
                    } else
                    {
                        radioCus.Checked = true;
                    }

                    // 显示
                    txtRCInfo.Text = outRow + " 行 " + outCol + " 列";
                    labelGifPath.Text = imgPath;
                    labelImgSize.Text = "尺寸: " + imgWidth + "px  " + imgHeight + "px";
                    labelImgCount.Text = "帧数: " + imgCount;
                    labelImgOut.Text = outPath + "\\" + imgName + "-" + imgWidth + "x" + imgHeight + ".png";

                    export.Enabled = true;

                    // 释放Gif
                    gif.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 导出PNG
        private void export_Click(object sender, EventArgs e)
        {
            // 禁用按钮
            export.Enabled = false;
            export.Text = "正在生成";
            import.Enabled = false;

            Image gif = Image.FromFile(imgPath, true);
            System.Drawing.Imaging.FrameDimension fd = new System.Drawing.Imaging.FrameDimension(gif.FrameDimensionsList[0]);

            Bitmap target = new Bitmap(imgWidth * outCol, imgHeight * outRow);
            Graphics g = Graphics.FromImage(target);

            int now = 0;
            for(int i = 0; i < outRow; i++)
            {
                for(int j = 0; j < outCol; j++)
                {
                    gif.SelectActiveFrame(fd, now);
                    g.DrawImage(gif, j * imgWidth, i * imgHeight, imgWidth, imgHeight);
                    now++;
                    // 画布填不满
                    if (now >= imgCount)
                    {
                        // 释放
                        g.Dispose();
                        gif.Dispose();

                        // 保存
                        target.Save(outPath + "\\" + imgName + "-" + imgWidth + "x" + imgHeight + ".png");
                        export.Text = "完成";
                        import.Enabled = true;

                        // 用默认图片查看器打开
                        System.Diagnostics.Process process = new System.Diagnostics.Process();
                        process.StartInfo.FileName = outPath + "\\" + imgName + "-" + imgWidth + "x" + imgHeight + ".png";
                        process.StartInfo.Arguments = "rundl132.exe C://WINDOWS//system32//shimgvw.dll,ImageView_Fullscreen";
                        process.StartInfo.UseShellExecute = true;
                        process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        process.Start();
                        process.Close();
                        init();
                        return;
                    }

                }
            }

        }

        // 自定义宽高
        private void radioCus_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCus.Checked)
            {
                // 计算合理行列数量
                int x = (int)Math.Sqrt(imgCount);
                int y = x;
                while (x * y < imgCount)
                {
                    x++;
                }

                outCol = x;
                outRow = y;
                txtRCInfo.Text = outRow + " 行 " + outCol + " 列";
            }
        }

        // 单行
        private void radioRow_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRow.Checked)
            {
                outRow = 1;
                outCol = imgCount;
                txtRCInfo.Text = outRow + " 行 " + outCol + " 列";
            }
        }

        // 单列
        private void radioCol_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCol.Checked)
            {
                outRow = imgCount;
                outCol = 1;
                txtRCInfo.Text = outRow + " 行 " + outCol + " 列";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://catt-l.com");
        }
    }
}
