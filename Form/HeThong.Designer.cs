namespace QuanLyKinhDoanhNhaThuoc
{
    partial class HeThong
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnHethong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSachDuocSiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnHethong,
            this.mnDanhmuc});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnHethong
            // 
            this.mnHethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.mnHethong.Name = "mnHethong";
            this.mnHethong.Size = new System.Drawing.Size(106, 29);
            this.mnHethong.Text = "He Thong";
            this.mnHethong.Click += new System.EventHandler(this.heThongToolStripMenuItem_Click);
            // 
            // mnDanhmuc
            // 
            this.mnDanhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnThuoc,
            this.danhSachDuocSiToolStripMenuItem});
            this.mnDanhmuc.Name = "mnDanhmuc";
            this.mnDanhmuc.Size = new System.Drawing.Size(109, 29);
            this.mnDanhmuc.Text = "Danh muc";
            // 
            // mnThuoc
            // 
            this.mnThuoc.Name = "mnThuoc";
            this.mnThuoc.Size = new System.Drawing.Size(270, 34);
            this.mnThuoc.Text = "Danh sach thuoc";
            this.mnThuoc.Click += new System.EventHandler(this.danhSachThuocToolStripMenuItem_Click);
            // 
            // danhSachDuocSiToolStripMenuItem
            // 
            this.danhSachDuocSiToolStripMenuItem.Name = "danhSachDuocSiToolStripMenuItem";
            this.danhSachDuocSiToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.danhSachDuocSiToolStripMenuItem.Text = "Danh sach duoc si";
            this.danhSachDuocSiToolStripMenuItem.Click += new System.EventHandler(this.danhSachDuocSiToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // HeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "HeThong";
            this.Text = "HeThong";
            this.Load += new System.EventHandler(this.HeThong_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnDanhmuc;
        private System.Windows.Forms.ToolStripMenuItem mnThuoc;
        private System.Windows.Forms.ToolStripMenuItem mnHethong;
        private System.Windows.Forms.ToolStripMenuItem danhSachDuocSiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
    }
}