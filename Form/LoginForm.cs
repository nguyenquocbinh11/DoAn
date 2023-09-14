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

namespace QuanLyKinhDoanhNhaSach
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            try
            {
                databaseConection.Connection();
            }
            catch { MessageBox.Show("Loi ket noi!"); }
        }

        DatabaseConection databaseConection = new DatabaseConection();
        public static string taikhoan, matkhau;

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

        public bool checkDangNhap()
        {
            if(string.IsNullOrEmpty(txtTaikhoan.Text) || string.IsNullOrEmpty(txtMatkhau.Text))
            {
                 MessageBox.Show("Vui long dien day du thong tin");
            }
            return true;
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Load(databaseConection.DataReader(@"Select tai_khoan, mat_khau from TAI_KHOAN where tai_khoan= '" + txtTaikhoan.Text +"' and mat_khau='"+txtMatkhau.Text+"'"));
           
           
            if(dataTable.Rows.Count>0)
            {
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
    }
}
