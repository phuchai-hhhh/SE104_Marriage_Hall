using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QL_TiecCuoi
{
    public partial class NhanVien : Form
    {
        private string connectionString = "Data Source=DESKTOP-1BTJ3G2\\SQLEXPRESS;Initial Catalog=Marriage_Hall;Integrated Security=True";

        public NhanVien()
        {
            InitializeComponent();
            Show_ComboboxLoaiSanh();
            Show_ComboboxChucVu();
            Show_ComboboxCa();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Menu();
            frm.ShowDialog();
        }

        public void Show_ComboboxLoaiSanh()
        {
            string query = "SELECT * FROM ThongTinSanh";
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                comboBoxSanh.DataSource = dt;
                comboBoxSanh.DisplayMember = "LoaiSanh";
                comboBoxSanh.ValueMember = "id";
            }
        }

        public void Show_ComboboxChucVu()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ChucVu", typeof(string));
            dt.Rows.Add("Phục Vụ");
            dt.Rows.Add("Giám Sát");
            dt.Rows.Add("Quản Lý");

            comboBoxChucVu.DataSource = dt;
            comboBoxChucVu.DisplayMember = "ChucVu";
            comboBoxChucVu.ValueMember = "ChucVu";
        }

        public void Show_ComboboxCa()
        {
            string query = "SELECT DISTINCT Ca FROM Tiec";
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                comboBoxCa.DataSource = dt;
                comboBoxCa.DisplayMember = "Ca";
                comboBoxCa.ValueMember = "Ca";
            }
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            Show_ComboboxLoaiSanh();
            Show_ComboboxChucVu();
            Show_ComboboxCa();
            LoadNhanVienData();
        }

        private void LoadNhanVienData()
        {
            string query = "SELECT * FROM NhanVien";
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewDSNhanVien.DataSource = dt;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxTenNhanVien.Text != "" && textBoxSoDienThoai.Text != "" && textBoxDiaChi.Text != "")
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "INSERT INTO NhanVien (HoTen, DienThoai, DiaChi, ChucVu, CaLam) " +
                                       "VALUES (@HoTen, @DienThoai, @DiaChi, @ChucVu, @CaLam)";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@HoTen", textBoxTenNhanVien.Text);
                            cmd.Parameters.AddWithValue("@DienThoai", textBoxSoDienThoai.Text);
                            cmd.Parameters.AddWithValue("@DiaChi", textBoxDiaChi.Text);
                            cmd.Parameters.AddWithValue("@ChucVu", comboBoxChucVu.SelectedValue);
                            cmd.Parameters.AddWithValue("@CaLam", comboBoxCa.SelectedValue);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Bạn đã thêm thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                    LoadNhanVienData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, không thêm được: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int CurrentIndex = dataGridViewDSNhanVien.CurrentCell.RowIndex;
                string id = dataGridViewDSNhanVien.Rows[CurrentIndex].Cells["id"].Value.ToString();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "DELETE FROM NhanVien WHERE id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Bạn đã xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                LoadNhanVienData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi, không xóa được: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int CurrentIndex = dataGridViewDSNhanVien.CurrentCell.RowIndex;
                string id = dataGridViewDSNhanVien.Rows[CurrentIndex].Cells["id"].Value.ToString();
                string hoTen = dataGridViewDSNhanVien.Rows[CurrentIndex].Cells["HoTen"].Value.ToString();
                string dienThoai = dataGridViewDSNhanVien.Rows[CurrentIndex].Cells["DienThoai"].Value.ToString();
                string diaChi = dataGridViewDSNhanVien.Rows[CurrentIndex].Cells["DiaChi"].Value.ToString();
                string chucVu = dataGridViewDSNhanVien.Rows[CurrentIndex].Cells["ChucVu"].Value.ToString();
                string caLam = dataGridViewDSNhanVien.Rows[CurrentIndex].Cells["CaLam"].Value.ToString();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "UPDATE NhanVien SET HoTen = @HoTen, DienThoai = @DienThoai, DiaChi = @DiaChi, " +
                                   "ChucVu = @ChucVu, CaLam = @CaLam WHERE id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@HoTen", hoTen);
                        cmd.Parameters.AddWithValue("@DienThoai", dienThoai);
                        cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                        cmd.Parameters.AddWithValue("@ChucVu", chucVu);
                        cmd.Parameters.AddWithValue("@CaLam", caLam);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Bạn đã sửa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                LoadNhanVienData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi, không sửa được: " + ex.Message);
            }
        }

        private void textBoxTenNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^0-9^+^\!^\#^\$^\%^\&^\'^\(^\)^\*^\,^\-^\.^\/^\:^\;^\<^\=^\>^\?^\@^\[^\\^\]^\^_^\`^\{^\|^\}^\~]"))
            {
                e.Handled = true;
            }
        }

        private void textBoxSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadNhanVienData();
        }

        // Add the missing method here
        private void textBoxTenNhanVien_TextChanged(object sender, EventArgs e)
        {
            // Add any necessary code to handle the event here
        }
    }
}
