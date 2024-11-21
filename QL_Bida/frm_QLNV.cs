using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Bida
{
    public partial class frm_QLNV : Form
    {
		DBConnect db = new DBConnect();
		public frm_QLNV()
		{
			InitializeComponent();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtManv.Text))
			{
				MessageBox.Show("Vui lòng chọn nhân viên để xóa.");
				return;
			}

			// Hiển thị thông báo xác nhận xóa
			DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				// Chuẩn bị câu lệnh DELETE
				string query = "DELETE FROM NHANVIEN WHERE MANV = '" + txtManv.Text + "'";

				// Thực hiện câu lệnh xóa
				int k = db.getNonquery(query);

				if (k != 0)
				{
					MessageBox.Show("Xóa nhân viên thành công!");

					// Cập nhật lại DataGridView
					CapNhatDataGridView();

					txtManv.Clear();
					txtTennv.Clear();
					cb_Chucvu.SelectedIndex = -1; // Đặt ComboBox về trạng thái chưa chọn
					txtSDT.Clear();
					txtDiaChi.Clear();
					txtTenDN.Clear();
					txtMatKhau1.Clear();
					dateTimePicker1.Value = DateTime.Today; // Đặt DateTimePicker về ngày hiện tại


				}
				else
				{
					MessageBox.Show("Xóa nhân viên thất bại!");
				}
			}

		}
		private bool KiemTraTrungMaNV(string maNV)
		{

			string query = "SELECT COUNT(*) FROM NHANVIEN WHERE MANV = '" + maNV + "'";
			DataTable dt = db.getDataTable(query);

			if (dt.Rows.Count > 0 && int.Parse(dt.Rows[0][0].ToString()) > 0)
			{
				return true; // Mã khách hàng đã tồn tại
			}
			return false; // Mã khách hàng chưa tồn tại
		}

		private void frm_QLNV_Load(object sender, EventArgs e)
		{
			dgv_NhanVien.Font = new Font("Arial", 12, FontStyle.Regular);
			string sqlquery = "select * from CHUCVU";
			DataTable dt = db.getDataTable(sqlquery);
			cb_Chucvu.DataSource = dt;
			cb_Chucvu.DisplayMember = "TENCHUCVU";
			cb_Chucvu.ValueMember = "MACV";
			string query = @"
        SELECT 
            NV.MANV, 
            NV.TENNV, 
            NV.LOAINV, 
			CV.TENCHUCVU,
			CV.MACV,
			NV.MANHOM,
            NV.NGAYVAOLAM, 
			NV.SoDienThoai,
			NV.DIACHI,
			NV.TENDANGNHAP,
			NV.MATKHAU
        FROM 
            NHANVIEN NV
        JOIN 
            CHUCVU CV ON NV.MACV = CV.MACV";
			DataTable dt2 = db.getDataTable(query);
			dgv_NhanVien.DataSource = dt2;
			dgv_NhanVien.RowHeadersVisible = false;
			txtManv.Enabled = false;
			dgv_NhanVien.Columns["MACV"].Visible = false;
			dgv_NhanVien.Columns["MANHOM"].Visible = false;
		}
		private void CapNhatDataGridView()
		{

			string query = @"
        SELECT 
            NV.MANV, 
            NV.TENNV, 
            NV.LOAINV, 
			CV.TENCHUCVU,
			CV.MACV,
			NV.MANHOM,
            NV.NGAYVAOLAM, 
			NV.SoDienThoai,
			NV.DIACHI,
			NV.TENDANGNHAP,
			NV.MATKHAU
        FROM 
            NHANVIEN NV
        JOIN 
            CHUCVU CV ON NV.MACV = CV.MACV";
			DataTable dt = db.getDataTable(query);

			dgv_NhanVien.DataSource = dt;
		}
		private void btnThemNV_Click(object sender, EventArgs e)
		{
			if (KiemTraTrungMaNV(txtManv.Text))
			{
				MessageBox.Show("Mã nhân viên đã tồn tại. Vui lòng nhập mã khác.");
				return; // Thoát nếu mã nhân viên đã tồn tại
			}
			else
			{
				string MaNV = db.GenerateMaHoaDon();
				string Ngay = dateTimePicker1.Value.ToString("dd-MM-yyyy");

				// Kiểm tra loại nhân viên dựa vào checkbox
				string loaiNV;
				if (checkBox1.Checked && !checkBox2.Checked)
				{
					loaiNV = checkBox1.Text;
				}
				else if (!checkBox1.Checked && checkBox2.Checked)
				{
					loaiNV = checkBox2.Text;
				}
				else
				{
					MessageBox.Show("Vui lòng chọn chỉ một loại nhân viên (Full-time hoặc Part-time).");
					return;
				}

				string query = "insert into NHANVIEN values('" + MaNV + "','" + txtTennv.Text + "','" + cb_Chucvu.SelectedValue + "','" + loaiNV + "','" + Ngay + "','" + txtSDT.Text + "','" + txtDiaChi.Text + "','" + txtTenDN.Text + "','" + txtMatKhau1.Text + "','" + txtMaNhom.Text + "')";

				int k = db.getNonquery(query);
				if (k != 0)
				{
					MessageBox.Show("Thêm thành công");
					CapNhatDataGridView();
				}
				else
				{
					MessageBox.Show("Thêm nhân viên thất bại!");
				}
			}
		}


		private void cb_Chucvu_SelectedIndexChanged(object sender, EventArgs e)
		{
			string h = cb_Chucvu.Text;
			if (h == "Nhân viên pha chế" || h == "Nhân viên phục vụ")
			{
				txtTenDN.Enabled = false;
				txtMatKhau1.Enabled = false;
				txtMaNhom.Text = "NV";
			}
			else if (h == "Nhân viên thu ngân")
			{
				txtTenDN.Enabled = true;
				txtMatKhau1.Enabled = true;
				txtMaNhom.Text = "NV";
			}
			else if (h == "Nhân viên kho")
			{
				txtTenDN.Enabled = true;
				txtMatKhau1.Enabled = true;
				txtMaNhom.Text = "QLK";
			}
			else
			{
				txtTenDN.Enabled = true;
				txtMatKhau1.Enabled = true;
				txtMaNhom.Text = "QL";
			}
		}

		private void btn_TIemKiem_Click(object sender, EventArgs e)
		{
			string query = "select * from NHANVIEN where TENNV like N'%" + txtSearch.Text + "%'";
			int k = db.getNonquery(query);

			if (k != 0)
			{
				DataTable dt = db.getDataTable(query);

				dgv_NhanVien.DataSource = dt;

			}
			else
			{
				MessageBox.Show("Không có khách hàng.");
			}
		}

		private void dgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
		{

			if (e.RowIndex >= 0) // Đảm bảo hàng được chọn là hợp lệ
			{
				DataGridViewRow row = dgv_NhanVien.Rows[e.RowIndex];
				txtManv.Text = row.Cells["MANV"].Value.ToString();
				txtTennv.Text = row.Cells["TENNV"].Value.ToString();
				txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
				txtDiaChi.Text = row.Cells["DIACHI"].Value.ToString();
				cb_Chucvu.SelectedValue = row.Cells["MACV"].Value;
				txtTenDN.Text = row.Cells["TENDANGNHAP"].Value.ToString();
				txtMatKhau1.Text = row.Cells["MATKHAU"].Value.ToString();
				txtMaNhom.Text = row.Cells["MANHOM"].Value.ToString();
				DateTime date = DateTime.Parse(row.Cells["NGAYVAOLAM"].Value.ToString().Trim());
				dateTimePicker1.Value = date;
			}
		}

		private void btnSuaNV_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtTennv.Text) || string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtTenDN.Text))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
				return; // Thoát nếu chưa nhập đủ thông tin
			}

			DataTable dt = (DataTable)dgv_NhanVien.DataSource;


			SqlConnection con = db.conn; // Lấy SqlConnection từ lớp DBConnect

			// Đăng ký sự kiện InfoMessage để nhận thông báo từ lệnh PRINT
			string Ngay = dateTimePicker1.Value.ToString("dd-MM-yyyy");
			string loaiNV;
			if (checkBox1.Checked && !checkBox2.Checked)
			{
				loaiNV = checkBox1.Text;
			}
			else if (!checkBox1.Checked && checkBox2.Checked)
			{
				loaiNV = checkBox2.Text;
			}
			else
			{
				MessageBox.Show("Vui lòng chọn chỉ một loại nhân viên (Full-time hoặc Part-time).");
				return;
			}
			string query = "update NHANVIEN set TENNV =N'" + txtTennv.Text + "', " +
						   "MACV = N'" + cb_Chucvu.SelectedValue + "', " +
						   "LOAINV = '" + loaiNV + "', " +
						   "NGAYVAOLAM = '" + Ngay + "', " +
						   "SoDienThoai = '" + txtSDT.Text + "', " +
						   "DIACHI = N'" + txtDiaChi.Text + "', " +
						   "TENDANGNHAP = '" + txtTenDN.Text + "', " +
						   "MATKHAU = '" + txtMatKhau1.Text + "', " +
						   "MANHOM = '" + txtMaNhom.Text + "' where MANV ='" + txtManv.Text + "'";

			int k = db.getNonquery(query);

			if (k != 0)
			{
				// Cập nhật lại DataGridView
				CapNhatDataGridView();

				txtManv.Clear();
				txtTennv.Clear();
				cb_Chucvu.SelectedIndex = -1; // Đặt ComboBox về trạng thái chưa chọn
				txtSDT.Clear();
				txtDiaChi.Clear();
				txtTenDN.Clear();
				txtMatKhau1.Clear();
				dateTimePicker1.Value = DateTime.Today; // Đặt DateTimePicker về ngày hiện tại

			}
			else
			{
				MessageBox.Show("Cập nhật khách hàng thất bại!");
			}

		}
		private bool IsValidPhoneNumber(string phoneNumber)
		{
			string pattern = @"^(03|05|07|08|09)\d{8}$";
			return Regex.IsMatch(phoneNumber, pattern);
		}

		private void txtSDT_Leave(object sender, EventArgs e)
		{
			if (!IsValidPhoneNumber(txtSDT.Text))
			{
				MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng nhập số điện thoại theo định dạng Việt Nam.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

	}

}
