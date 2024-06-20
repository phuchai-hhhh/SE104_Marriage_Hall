using QL_TiecCuoi.DAO;
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


namespace QL_TiecCuoi
{
    public partial class DangNhap : Form
    {
        string str = "Data Source=DESKTOP-1BTJ3G2\\SQLEXPRESS;Initial Catalog=Marriage_Hall;Integrated Security=True";
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public DangNhap()
        {
            InitializeComponent();
           
        }
        public static class GlobalVariables
        {
            public static string TaiKhoan { get; set; }
          
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
           
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxTenDangNhap.Text == "" || textBoxMatKhau.Text == "")
            {
                MessageBox.Show("Dữ liệu không hợp lệ!");
                return;
            }

            string TenDangNhap = textBoxTenDangNhap.Text;
            string MatKhau = textBoxMatKhau.Text;
            using (SqlConnection connection = new SqlConnection(str))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
                        cmd.Parameters.AddWithValue("@MatKhau", MatKhau);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            this.Hide();
                            Form frm = new Menu();
                            frm.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn đóng ứng dụng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void labelDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
