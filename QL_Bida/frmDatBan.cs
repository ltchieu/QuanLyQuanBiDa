using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Bida
{
	public partial class frmDatBan : Form
	{
		DBConnect db = new DBConnect();
		int selectedLoai = 0; //Ktr thử combobox loại bàn đã được chọn chưa
		int selectedRow = -1; //Dòng được chọn trong datagridview
		public frmDatBan()
		{
			this.KeyPreview = true; //Đảm bảo form nhận sự kiện KeyDown
			InitializeComponent();
		}

		private void frmDatBan_Load(object sender, EventArgs e)
		{
			//Load dữ liệu các loại bàn
			cmb_LoaiBan.DataSource = db.getDataTable("select * from LoaiBan");
			cmb_LoaiBan.DisplayMember = "TenLoaiBan";
			cmb_LoaiBan.ValueMember = "MaLoaiBan";

			//Load ds các bàn bida
			cmb_maBan.DataSource = db.getDataTable("select * from BanBida");
			cmb_maBan.DisplayMember = "MaBan";
			cmb_maBan.ValueMember = "MaBan";

			//Load danh sách đặt bàn
			HienThiDSDatBan();

			selectedLoai = 1;
		}

		//Thêm một thông tin đặt bàn
		private void btn_DatBan_Click(object sender, EventArgs e)
		{
			string sdt = txt_sdtKH.Text;
			string query = "select MaKH from KhachHang where SDT = '" + sdt + "'";
			DataTable dt = db.getDataTable(query);
			if (dt == null || dt.Rows.Count == 0)
			{
				MessageBox.Show("Khách hàng chưa có tài khoản \n Không thể đặt bàn");
				return;
			}
			string maKH = dt.Rows[0]["MaKh"].ToString(); //Lấy ra mã khách hàng từ số điện thoại

			string ngayDat = dtp_ngayDat.Text + " " + txt_gioDat.Text + ":00";

			string maBan = cmb_maBan.SelectedValue.ToString();

			//Thêm một đặt bàn
			string queryInsert = "insert into DATBAN values('" + maKH.Trim() + "', '" + maBan + "', '" + ngayDat + "')";
			int k = db.getNonquery(queryInsert);
			if (k == 1)
			{
				MessageBox.Show("Đặt bàn thành công");
				HienThiDSDatBan();
			}
			else
				MessageBox.Show("Có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		//Load lại combobox ds các bàn dựa trên loại bàn được chọn
		private void cmb_LoaiBan_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (selectedLoai != 0)
			{
				string maloaiBan = cmb_LoaiBan.SelectedValue.ToString();
				string query = "select * from BanBida where MALOAIBAN = " + maloaiBan;
				DataTable dt = db.getDataTable(query);
				cmb_maBan.DataSource = dt;
				cmb_maBan.DisplayMember = "MaBan";
				cmb_maBan.ValueMember = "MaBan";
			}
		}

		//Ràng buộc chỉ chứa các ký tự số
		private void txt_gioDat_TextChanged(object sender, EventArgs e)
		{
			TextBox txt = (TextBox)sender;
			if (txt.Text.Length > 0 && txt.Text.All(char.IsDigit) == false)
			{
				errorProvider1.SetError(txt, "Chỉ chứa các kí tự số");
			}
			else
			{
				errorProvider1.Clear();
			}
		}

		//Xóa placeholder
		private void txt_gioDat_Enter(object sender, EventArgs e)
		{
			txt_gioDat.Clear();
			txt_gioDat.ForeColor = SystemColors.ControlText;
		}

		private void dtp_ngayDat_ValueChanged(object sender, EventArgs e)
		{
			if (dtp_ngayDat.Value < DateTime.Now)
			{
				MessageBox.Show("Ngày đặt bàn không được nhỏ hơn hoặc bằng ngày hiện tại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				dtp_ngayDat.Value = DateTime.Now;
			}
		}

		private void HienThiDSDatBan()
		{
			string query = "select d.MaKH, TenKH, SDT, MaBan, NgayDatBan from DatBan d join KhachHang k on k.MaKH = d.MaKH";
			DataTable dt = db.getDataTable(query);
			dtgv_dsDatBan.DataSource = dt;
		}

		//Tìm thông tin đặt bàn theo số điện thoại khách hàng
		private void btn_TimKH_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txt_sdtKH.Text))
			{
				MessageBox.Show("Cần nhập số điện thoại của khách hàng trước");
				return;
			}
			else
			{
				string query = "select TenKH, SDT, MaBan, NgayDatBan from DatBan d join KhachHang k on k.MaKH = d.MaKH where SDT = '" + txt_sdtKH.Text + "'";
				DataTable dt = db.getDataTable(query);
				dtgv_dsDatBan.DataSource = dt;
			}
		}

		private void dtgv_dsDatBan_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			selectedRow = e.RowIndex;
		}


		//Xóa 1 thông tin đặt bàn
		private void btn_Xoa_Click(object sender, EventArgs e)
		{
			DataTable dt = (DataTable)dtgv_dsDatBan.DataSource;
			string makh = dt.Rows[selectedRow]["MaKH"].ToString();
			string maban = dt.Rows[selectedRow]["MaBan"].ToString();

			string query = "delete from DATBAN where MAKH = '" + makh + "' and MABAN = '" + maban + "'";
			int k = db.getNonquery(query);
			if (k == 1)
			{
				MessageBox.Show("Thông tin đặt bàn của khách đã được xóa");
				HienThiDSDatBan();
			}
			else
			{
				MessageBox.Show("Lỗi khi xóa thông tin đặt bàn");
			}

		}

		private void dtgv_dsDatBan_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F5)
			{
				HienThiDSDatBan();
			}
		}
	}
}
