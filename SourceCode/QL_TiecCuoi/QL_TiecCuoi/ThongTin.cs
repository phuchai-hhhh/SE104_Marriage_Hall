using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QL_TiecCuoi
{
    public partial class ThongTin : Form
    {
        private string connectionString = "Data Source=DESKTOP-1BTJ3G2\\SQLEXPRESS;Initial Catalog=Marriage_Hall;Integrated Security=True";

        public ThongTin()
        {
            InitializeComponent();
            Show_ComboboxThucDon();
            Show_ComboboxDichVu();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Menu();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new ThemSanhMoi();
            frm.ShowDialog();
        }

        public void Show_ComboboxThucDon()
        {
            string query = "SELECT * FROM ThucDon";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable thucDonTable = new DataTable();
                        adapter.Fill(thucDonTable);

                        comboBoxThucDon.DataSource = thucDonTable;
                        comboBoxThucDon.DisplayMember = "MaThucDon";
                        comboBoxThucDon.ValueMember = "MaThucDon";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                }
            }
        }

        public void Show_ComboboxDichVu()
        {
            string query = "SELECT * FROM DichVu";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dichVuTable = new DataTable();
                        adapter.Fill(dichVuTable);

                        comboBoxDichVu.DataSource = dichVuTable;
                        comboBoxDichVu.DisplayMember = "MaDichVu";
                        comboBoxDichVu.ValueMember = "MaDichVu";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                }
            }
        }

        private void ThongTin_Load(object sender, EventArgs e)
        {
            Show_ComboboxThucDon();
            Show_ComboboxDichVu();
            string query = "SELECT * FROM ThongTinSanh";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable sanhTable = new DataTable();
                        adapter.Fill(sanhTable);

                        dataGridViewDS_Sanh.DataSource = sanhTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int CurrentIndex = dataGridViewDS_Sanh.CurrentCell.RowIndex;
                string a = dataGridViewDS_Sanh.Rows[CurrentIndex].Cells[0].Value.ToString();
                string deletedStr = "DELETE FROM ThongTinSanh WHERE id=@Id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(deletedStr, connection))
                    {
                        command.Parameters.AddWithValue("@Id", a);
                        command.ExecuteNonQuery();
                    }
                }

                string query = "SELECT * FROM ThongTinSanh";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable sanhTable = new DataTable();
                        adapter.Fill(sanhTable);

                        dataGridViewDS_Sanh.DataSource = sanhTable;
                    }
                }

                MessageBox.Show("Bạn đã xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi, không xóa được: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int CurrentIndex = dataGridViewDS_Sanh.CurrentCell.RowIndex;
                string ID = dataGridViewDS_Sanh.Rows[CurrentIndex].Cells[0].Value.ToString();
                string tensanh = dataGridViewDS_Sanh.Rows[CurrentIndex].Cells[2].Value.ToString();
                string soluongbantoida = dataGridViewDS_Sanh.Rows[CurrentIndex].Cells[3].Value.ToString();
                string dongiatoithieu = dataGridViewDS_Sanh.Rows[CurrentIndex].Cells[4].Value.ToString();
                string ghichu = dataGridViewDS_Sanh.Rows[CurrentIndex].Cells[5].Value.ToString();

                string updateStr = "UPDATE ThongTinSanh SET TenSanh=@TenSanh, SoLuongBanToiDa=@SoLuongBanToiDa, DonGiaToiThieu=@DonGiaToiThieu, GhiChu=@GhiChu WHERE id=@Id";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(updateStr, connection))
                    {
                        command.Parameters.AddWithValue("@TenSanh", tensanh);
                        command.Parameters.AddWithValue("@SoLuongBanToiDa", soluongbantoida);
                        command.Parameters.AddWithValue("@DonGiaToiThieu", dongiatoithieu);
                        command.Parameters.AddWithValue("@GhiChu", ghichu);
                        command.Parameters.AddWithValue("@Id", ID);
                        command.ExecuteNonQuery();
                    }
                }

                string query = "SELECT * FROM ThongTinSanh";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable sanhTable = new DataTable();
                        adapter.Fill(sanhTable);

                        dataGridViewDS_Sanh.DataSource = sanhTable;
                    }
                }

                MessageBox.Show("Bạn đã sửa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi, không sửa được: " + ex.Message);
            }
        }

        private void comboBoxThucDon_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedValue = comboBoxThucDon.SelectedValue.ToString();
            if (selectedValue != "System.Data.DataRowView")
            {
                string query = "SELECT * FROM ThucDon WHERE MaThucDon=@MaThucDon";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@MaThucDon", selectedValue);
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable thucDon = new DataTable();
                            adapter.Fill(thucDon);

                            if (thucDon.Rows.Count > 0)
                            {
                                textBoxMonKhaiVi.Text = thucDon.Rows[0]["MonKhaiVi"].ToString();
                                textBoxMonChinh1.Text = thucDon.Rows[0]["MonChinh1"].ToString();
                                textBoxMonChinh2.Text = thucDon.Rows[0]["MonChinh2"].ToString();
                                textBoxMonChinh3.Text = thucDon.Rows[0]["MonChinh3"].ToString();
                                textBoxLau.Text = thucDon.Rows[0]["Lau"].ToString();
                                textBoxTrangMieng.Text = thucDon.Rows[0]["TrangMieng"].ToString();
                                textBoxBia.Text = thucDon.Rows[0]["Bia"].ToString();
                                textBoxNuocNgot.Text = thucDon.Rows[0]["NuocNgot"].ToString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                    }
                }
            }
        }

        private void comboBoxDichVu_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedValue = comboBoxDichVu.SelectedValue.ToString();
            if (selectedValue != "System.Data.DataRowView")
            {
                string query = "SELECT * FROM DichVu WHERE MaDichVu=@MaDichVu";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@MaDichVu", selectedValue);
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable dichVu = new DataTable();
                            adapter.Fill(dichVu);

                            if (dichVu.Rows.Count > 0)
                            {
                                textBoxRuou.Text = dichVu.Rows[0]["Ruou"].ToString();
                                textBoxBanhKem.Text = dichVu.Rows[0]["BanhKem"].ToString();
                                textBoxMC.Text = dichVu.Rows[0]["Mc"].ToString();
                                textBoxBanNhac.Text = dichVu.Rows[0]["BanNhac"].ToString();
                                textBoxCaSi.Text = dichVu.Rows[0]["CaSi"].ToString();
                                textBoxDJ.Text = dichVu.Rows[0]["Dj"].ToString();

                                // Assuming you want to set checkboxes based on some criteria
                                // Set the checkboxes based on some logic if needed
                                checkBox1.Checked = true;
                                checkBox2.Checked = true;
                                checkBox3.Checked = true;
                                checkBox4.Checked = true;
                                checkBox5.Checked = true;
                                checkBox6.Checked = true;
                                checkBox7.Checked = true;
                                checkBox8.Checked = true;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new LapHopDong();
            frm.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
