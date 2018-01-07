namespace UseBook
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理座位ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出人名电话对应ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存导出文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.调换座位ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开座位图文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开电话号码表文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开关系文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.管理座位ToolStripMenuItem,
            this.导出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(877, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开座位图文件ToolStripMenuItem,
            this.打开电话号码表文件ToolStripMenuItem,
            this.打开关系文件ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 管理座位ToolStripMenuItem
            // 
            this.管理座位ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.调换座位ToolStripMenuItem});
            this.管理座位ToolStripMenuItem.Name = "管理座位ToolStripMenuItem";
            this.管理座位ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.管理座位ToolStripMenuItem.Text = "管理座位";
            // 
            // 导出ToolStripMenuItem
            // 
            this.导出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导出人名电话对应ToolStripMenuItem,
            this.保存导出文件ToolStripMenuItem});
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.导出ToolStripMenuItem.Text = "导出";
            this.导出ToolStripMenuItem.Click += new System.EventHandler(this.导出ToolStripMenuItem_Click);
            // 
            // 导出人名电话对应ToolStripMenuItem
            // 
            this.导出人名电话对应ToolStripMenuItem.Name = "导出人名电话对应ToolStripMenuItem";
            this.导出人名电话对应ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.导出人名电话对应ToolStripMenuItem.Text = "导出人名电话对应";
            // 
            // 保存导出文件ToolStripMenuItem
            // 
            this.保存导出文件ToolStripMenuItem.Name = "保存导出文件ToolStripMenuItem";
            this.保存导出文件ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.保存导出文件ToolStripMenuItem.Text = "保存导出文件";
            // 
            // 调换座位ToolStripMenuItem
            // 
            this.调换座位ToolStripMenuItem.Name = "调换座位ToolStripMenuItem";
            this.调换座位ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.调换座位ToolStripMenuItem.Text = "调换座位";
            // 
            // 打开座位图文件ToolStripMenuItem
            // 
            this.打开座位图文件ToolStripMenuItem.Name = "打开座位图文件ToolStripMenuItem";
            this.打开座位图文件ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.打开座位图文件ToolStripMenuItem.Text = "打开座位图文件";
            // 
            // 打开电话号码表文件ToolStripMenuItem
            // 
            this.打开电话号码表文件ToolStripMenuItem.Name = "打开电话号码表文件ToolStripMenuItem";
            this.打开电话号码表文件ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.打开电话号码表文件ToolStripMenuItem.Text = "打开电话号码表文件";
            // 
            // 打开关系文件ToolStripMenuItem
            // 
            this.打开关系文件ToolStripMenuItem.Name = "打开关系文件ToolStripMenuItem";
            this.打开关系文件ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.打开关系文件ToolStripMenuItem.Text = "打开关系文件";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(877, 563);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 588);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "座位图管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理座位ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开座位图文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开电话号码表文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开关系文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 调换座位ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出人名电话对应ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存导出文件ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

