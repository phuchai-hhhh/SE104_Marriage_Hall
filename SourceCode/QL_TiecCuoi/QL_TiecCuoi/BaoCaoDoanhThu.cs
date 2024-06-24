using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QL_TiecCuoi
{
    public partial class BaoCaoDoanhThu : Form
    {
        private string connectionString = "Data Source=DESKTOP-1BTJ3G2\\SQLEXPRESS;Initial Catalog=Marriage_Hall;Integrated Security=True";

        public BaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Menu();
            frm.ShowDialog();
        }

        private void BaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            LoadBaoCaoDoanhThu();
        }

        private void LoadBaoCaoDoanhThu()
        {
            string query = "SELECT id, MaBaoCao, NgayLap, TenNguoiLap, Thang, SoLuongTiec, DoanhThu FROM LapBaoCao";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewDSBaoCao.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading report data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxThang.Text) && !string.IsNullOrEmpty(textBoxTongDoanhThu.Text))
            {
                string query = "INSERT INTO BaoCaoDoanhThu (Thang, TongDoanhThu) VALUES (@Thang, @TongDoanhThu)";
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Thang", textBoxThang.Text);
                    cmd.Parameters.AddWithValue("@TongDoanhThu", textBoxTongDoanhThu.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Bạn đã lưu thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadTongDoanhThu();
        }

        private void LoadTongDoanhThu()
        {
            string query = "SELECT * FROM BaoCaoDoanhThu";
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewTongDoanhThu.DataSource = dt;
            }
        }
    }
}
