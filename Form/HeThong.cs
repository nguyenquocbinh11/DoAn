using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKinhDoanhNhaSach
{
    public partial class HeThong : Form
    {
        public HeThong()
        {
            InitializeComponent();
        }

        private void danhThuocToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhSachThuocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thuoc thuoc = new thuoc();  
            thuoc.Show();
            thuoc.Focus();
            this.Hide();
        }

        private void An_Hien_Menu(Boolean hien)
        {
            mnDanhmuc.Visible = hien;
            mnThuoc.Visible = hien;
        }

        private void HeThong_Load(object sender, EventArgs e)
        {
          
        }
    }
}
