using System;

namespace Breakout
{
    partial class frmBreakout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBreakout));
            this.ctlBreakout = new ctlBreakoutLib.ctlBreakout();
            this.SuspendLayout();
            // 
            // ctlBreakout
            // 
            this.ctlBreakout.Backbuffer = ((System.Drawing.Bitmap)(resources.GetObject("ctlBreakout.Backbuffer")));
            this.ctlBreakout.Location = new System.Drawing.Point(2, 3);
            this.ctlBreakout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ctlBreakout.Name = "ctlBreakout";
            this.ctlBreakout.PlayGround = new System.Drawing.Size(500, 500);
            this.ctlBreakout.Resizing = false;
            this.ctlBreakout.Size = new System.Drawing.Size(580, 505);
            this.ctlBreakout.TabIndex = 0;
            // 
            // frmBreakout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 518);
            this.Controls.Add(this.ctlBreakout);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmBreakout";
            this.Text = "Breakout";
            this.ResumeLayout(false);

        }

        #endregion

        private ctlBreakoutLib.ctlBreakout ctlBreakout;
    }
}

