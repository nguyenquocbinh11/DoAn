using QuanLyKinhDoanhNhaSach.Database;
using QuanLyKinhDoanhNhaThuoc.Database;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKinhDoanhNhaThuoc
{
    public partial class LoginForm : Form
    {
        DatabaseConection databaseConection = new DatabaseConection();
        public LoginForm()
        {
            InitializeComponent();
           
            try
            {
                databaseConection.Connection();
            }
            catch { MessageBox.Show("Loi ket noi!"); }
        }

        private static string quyenHan;

        private void txtTaikhoan_TextChanged(object sender, EventArgs e)
        {
           
        }

       
        

        private void txtMatkhau_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát !?", "Thong Bao", MessageBoxButtons.YesNo);
            if(dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

       

        public void checkDangNhap()
        {
            if(string.IsNullOrEmpty(txtTaikhoan.Text) || string.IsNullOrEmpty(txtMatkhau.Text))
            {
                MessageBox.Show("Vui long dien du thong tin");
            }
           
          
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Load(databaseConection.DataReader(@"Select ma_taikhoan, tai_khoan, mat_khau, QuyenHan from TAI_KHOAN where tai_khoan= '" + txtTaikhoan.Text +"' and mat_khau='" + txtMatkhau.Text + "'"));  
            if(dt.Rows.Count>0)
            {
                quyenHan = dt.Rows[0]["QuyenHan"].ToString();
                MessageBox.Show("Thanh cong");
                HeThong heThong = new HeThong();
                heThong.Show();
                this.Hide();

            }
            else
            {
                pnThongbao.Visible = true;
                txtMatkhau.Clear();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pnLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDangnhap_Click(object sender, EventArgs e, string v)
        {
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
