using QuanLyKinhDoanhNhaSach.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKinhDoanhNhaThuoc
{
    public partial class HeThong : Form
    {
        DatabaseConection databaseConection = new DatabaseConection();
        public HeThong()
        {
            InitializeComponent();
            databaseConection.Connection();
        }

       

        private void danhThuocToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhSachThuocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

       

        private void heThongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void HeThong_Load(object sender, EventArgs e)
        {
           
          
        }

        private void danhSachDuocSiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.Show();
            this.Hide();
        }
    }
}
