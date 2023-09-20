using QuanLyKinhDoanhNhaSach.Database;
using QuanLyKinhDoanhNhaThuoc.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKinhDoanhNhaThuoc
{
    public partial class NhanVien : Form
    {
        DatabaseConection databaseConection = new DatabaseConection();
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            databaseConection.Connection();
            //dt.Load(databaseConection.DataReader("Select * from NHAN_VIEN"));

            LoadDuLieu();           
            
                
            
        }

        public void LoadDuLieu()
        {
            listView1.View = View.Details;
         
            listView1.Items.Clear();

            DataTable dt = new DataTable();
            dt.Load(databaseConection.DataReader("select * from NHAN_VIEN"));
            if(dt!=null)
            {
                for(int i=0; i<dt.Columns.Count; i++)
                {
                    ColumnHeader columnHeader = new ColumnHeader();
                    columnHeader.Text = dt.Columns[i].ColumnName;
                    columnHeader.Width = 95;
                    
                    listView1.Columns.Add(columnHeader);
                }
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = dr["ma_nhanvien"].ToString();
                    item.SubItems.Add(dr["hodem"].ToString());
                    item.SubItems.Add(dr["ten"].ToString());
                    item.SubItems.Add(dr["nam_sinh"].ToString() );
                    item.SubItems.Add(dr["sodienthoai"].ToString());
                    item.SubItems.Add(dr["diachi"].ToString());
                    listView1.Items.Add(item);
                }

                // Doi ten cac cot
                string[] name = new string[] { "Ma nhan vien", "Ho dem", "Ten", "Nam sinh", "So dien thoai", "Dia chi" };
                int x = 0;
                foreach(ColumnHeader clh in listView1.Columns)
                {
                    clh.Text = name[x];
                    x++;
                }
            }
            
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                // Biet tac dung nhung chua biet code        
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            thuoc themNhanVien = new thuoc();
            themNhanVien.Show();
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }
    }
}
