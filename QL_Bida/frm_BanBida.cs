using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace QL_Bida
{
	public partial class frm_BanBida : Form
	{
		DBConnect db = new DBConnect();
		public DataTable dt_DsDvOrdered = new DataTable();
		int indexSelectedRow; //Lưu số dòng được chọn trong ds các dịch vụ
		public int maLoaiBan; // Lưu mã loại bàn được click vào
		public static List<PictureBox> lst; // Danh sách các bàn
		public static string selectedBan; //Lưu bàn được chọn
		public event EventHandler DoiMauNenThanhXanh; //Sự kiện đổi màu nền của bàn lại thành màu xanh
		public frm_BanBida()
		{
			InitializeComponent();
			dt_DsDvOrdered.Columns.Add("MaDV");
			dt_DsDvOrdered.Columns.Add("TenDichVu");
			dt_DsDvOrdered.Columns.Add("SoLuong");
			dt_DsDvOrdered.Columns.Add("DonGia");
			dtgv_dsDVOrdered.DataSource = dt_DsDvOrdered;

		}
		#region Hàm xử lý sự kiện
		private void dtgv_DSDV_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				indexSelectedRow = e.RowIndex;
				DataGridViewRow dgr = dtgv_DSDV.Rows[indexSelectedRow];
				txt_DonGia.Text = dgr.Cells["Gia"].Value.ToString(); // Load đơn giá của dịch vụ được chọn

				btn_AddMon.Enabled = IsEnableAddMon();
			}

		}

		private void frm_BanBida_FormClosing(object sender, FormClosingEventArgs e)
		{
			//Lưu lại trạng thái của form khi chưa thanh toán
			if (string.IsNullOrEmpty(lb_ThanhToan.Text))
			{
				TrangThaiForm t = new TrangThaiForm();
				t.khachLe = ck_KhachLe.Checked;
				t.LoaiBan = txt_LoaiBan.Text;
				t.startTime = txt_StartTime.Text;
				t.ngayChoi = lb_NgayVaoChoi.Text;
				t.loaiKhach = txt_Loaikhach.Text;
				t.giaGioChoi = txt_Gia1GioChoi.Text;
				t.phiDV = txt_TienDV.Text;
				t.dsDV_Ordered = (DataTable)dtgv_dsDVOrdered.DataSource;
				if (ck_KhachLe.Checked == true)
				{
					t.giamGia = "0";
					t.maKhachHang = "";
				}
				else
				{
					t.giamGia = txt_GiamGia.Text;
					t.maKhachHang = cmb_dsKH.SelectedValue.ToString();
				}

				if (frmDSBanBida.dsTrangThaiBan.ContainsKey(selectedBan) == true)
				{
					frmDSBanBida.dsTrangThaiBan[selectedBan] = t;
				}
				else
					frmDSBanBida.dsTrangThaiBan.Add(selectedBan, t);
			}
			else
			{
				return;
			}

		}
		private void frm_BanBida_Load(object sender, EventArgs e)
		{
			//Hiện cảnh báo bàn được đặt hay không
			CanhBaoBanDuocDat();

			//Load dữ liệu khách hàng
			DataTable dtkh = db.getDataTable("select * from KHACHHANG");
			if (dtkh.Rows.Count > 0)
			{
				cmb_dsKH.DataSource = dtkh;
				cmb_dsKH.DisplayMember = "TenKH";
				cmb_dsKH.ValueMember = "MaKH";
			}
			else
				MessageBox.Show("Lỗi không load được dữ liệu khách hàng");


			//Load dữ liệu đơn giá 1h chơi dựa theo loại bàn và khung giờ
			string chuoiTime = txt_StartTime.Text;
			string query =
				"select GIA from DONGIA WHERE MALOAIBAN = " + maLoaiBan + " AND '" + chuoiTime + "' between KHUNGGIOBATDAU and KHUNGGIOKETTHUC";
			DataTable dt_DonGia = db.getDataTable(query);
			txt_Gia1GioChoi.Text = dt_DonGia.Rows[0]["GIA"].ToString();

			//Load dữ liệu các dịch vụ
			DataTable dt_dv = db.getDataTable("select MaDV, TenDV, Gia from DichVu");
			if (dt_dv.Rows.Count > 0)
			{
				dtgv_DSDV.DataSource = dt_dv;
				dtgv_DSDV.ClearSelection();
			}
			else
				MessageBox.Show("Lỗi không load được dữ liệu các dịch vụ");

			btn_TinhGioChoi.Enabled = false;
			btn_AddMon.Enabled = false;
			btn_HienTienThanhToan.Enabled = false;
			txt_TienDV.Text = "0";

			//Load lại trạng thái trước đó của bàn nếu bàn đó đang được thuê (có màu salmon)
			foreach (PictureBox pic in lst)
			{
				if (string.Compare(pic.Name.Substring(1), selectedBan) == 0)
				{
					if (pic.BackColor == Color.Salmon)
					{
						foreach (var item in frmDSBanBida.dsTrangThaiBan)
						{
							if (item.Key == selectedBan)// Tìm thấy được bàn trong dictionary
							{
								ck_KhachLe.Checked = item.Value.khachLe;
								txt_LoaiBan.Text = item.Value.LoaiBan;
								txt_StartTime.Text = item.Value.startTime;
								lb_NgayVaoChoi.Text = item.Value.ngayChoi;
								txt_Loaikhach.Text = item.Value.loaiKhach;
								txt_Gia1GioChoi.Text = item.Value.giaGioChoi;
								txt_TienDV.Text = item.Value.phiDV;

								dt_DsDvOrdered = item.Value.dsDV_Ordered;
								dtgv_dsDVOrdered.DataSource = dt_DsDvOrdered;
								txt_GiamGia.Text = item.Value.giamGia;

								if (item.Value.khachLe == true) // Nếu là khách lẻ
								{
									txt_GiamGia.Text = "0";
									cmb_dsKH.Enabled = false;
								}
								else
								{
									cmb_dsKH.Enabled = true;
									cmb_dsKH.SelectedValue = item.Value.maKhachHang;
									DataRow dr = dtkh.NewRow();
									foreach (DataRow d in dtkh.Rows)
									{
										if (d["MaKH"].ToString() == item.Value.maKhachHang)
										{
											dr = d;
											break;
										}
									}
									if (dr != null)
										cmb_dsKH.SelectedItem = dr;
									else
										MessageBox.Show("Lỗi load lại thông tin khách hàng");
								}

								break;
							}
						}
					}
				}
			}
		}

		//Load giảm giá dựa theo nhóm khách hàng
		private void cmb_dsKH_SelectionChangeCommitted(object sender, EventArgs e)
		{
			string makh = cmb_dsKH.SelectedValue.ToString();
			//Lấy ra tên loại khách hàng theo mã khách hàng
			string query = "select LOAIKH.MALOAI, TenLoaiKh from LOAIKH join KHACHHANG k on LOAIKH.MALOAI = k.MALOAI where MaKH = '" + makh + "'";
			DataTable dt = db.getDataTable(query);

			txt_Loaikhach.Text = dt.Rows[0]["TenLoaiKh"].ToString();

			if (string.Compare("TV", dt.Rows[0]["MALOAI"].ToString().Trim()) == 0)
				txt_GiamGia.Text = "3%";
			if (string.Compare("TT", dt.Rows[0]["MALOAI"].ToString().Trim()) == 0)
				txt_GiamGia.Text = "5%";
			if (string.Compare("VIP", dt.Rows[0]["MALOAI"].ToString().Trim()) == 0)
				txt_GiamGia.Text = "10%";

		}

		//Lọc dịch vụ theo đồ ăn
		private void btn_DoAn_Click(object sender, EventArgs e)
		{
			LocTheoLoaiDV(1);
		}

		//Lọc dịch vụ theo nước uống
		private void btn_NuocUong_Click(object sender, EventArgs e)
		{
			LocTheoLoaiDV(2);
		}

		//Thêm giờ kết thúc chơi
		private void btn_ThemEndTime_Click(object sender, EventArgs e)
		{
			txt_EndTime.Text = DateTime.Now.ToString("T");
			btn_TinhGioChoi.Enabled = true;
		}

		//Thêm các dịch vụ vào trong ds dịch vụ đã được ordered
		private void btn_AddMon_Click(object sender, EventArgs e)
		{
			DataTable dt = (DataTable)dtgv_DSDV.DataSource;
			DataRow dr = dt_DsDvOrdered.NewRow();

			if (dt_DsDvOrdered.Rows.Count > 0)
			{
				foreach (DataGridViewRow row in dtgv_dsDVOrdered.Rows)
				{
					if (string.Compare(row.Cells["TenDichVu"].FormattedValue.ToString().Trim(), dt.Rows[indexSelectedRow]["TenDV"].ToString().Trim()) == 0)
					{
						row.Cells["SoLuong"].Value = txt_SoLuong.Text;
						return;
					}
				}

			}
			dr["MaDV"] = dt.Rows[indexSelectedRow]["MaDV"].ToString();
			dr["TenDichVu"] = dt.Rows[indexSelectedRow]["TenDV"].ToString();
			dr["SoLuong"] = txt_SoLuong.Text;
			dr["DonGia"] = dt.Rows[indexSelectedRow]["Gia"].ToString();

			dt_DsDvOrdered.Rows.Add(dr);

		}

		//Tính tiền dịch vụ
		private void dtgv_dsDVOrdered_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			txt_TienDV.Text = tinhPhiDV().ToString();
		}

		private void dtgv_dsDVOrdered_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			txt_TienDV.Text = tinhPhiDV().ToString();
		}

		//Tính giờ chơi
		private void btn_TinhGioChoi_Click(object sender, EventArgs e)
		{
			DateTime startTime = Convert.ToDateTime(txt_StartTime.Text);
			DateTime endTime = Convert.ToDateTime(txt_EndTime.Text);

			string chuoiTime = (endTime - startTime).ToString();
			txt_GioChoi.Text = ChuyenSangSoGio(chuoiTime).ToString("F3");
			txt_TongTien.Text = tinhTienTheoGioChoi().ToString("F0");

			btn_HienTienThanhToan.Enabled = IsEnableThanhToan();
		}

		//Hiện tiền thanh toán và lưu hóa đơn vào csdl
		private void btn_HienTienThanhToan_Click(object sender, EventArgs e)
		{
			//Hiện tiền thanh toán cần trả
			string maHD = TaoMaHD();
			double tongtien = double.Parse(txt_TongTien.Text) + double.Parse(txt_TienDV.Text);
			string tienGiamGia = txt_GiamGia.Text;

			if (tienGiamGia.Length == 2)
				tienGiamGia = tienGiamGia.Substring(0, 1);
			else if (tienGiamGia.Length == 3)
				tienGiamGia = tienGiamGia.Substring(0, 2);

			double thucTra = tongtien - tongtien * (double.Parse(tienGiamGia) / 100);//Tính tiền thực trả
			lb_ThanhToan.Text = thucTra.ToString();

			string maKH = "";
			string ngayTaoHD = lb_NgayVaoChoi.Text; //Ngày tạo hóa đơn

			string queryHD = "";
			string queryUpdateDiemThuong = "";
			int soDiemThuong = Convert.ToInt32((double.Parse(txt_GioChoi.Text) * 10) + (double.Parse(txt_TienDV.Text) / 10000)); //số điểm thưởng của khách

			//Lưu vào csdl
			if (cmb_dsKH.Enabled == true)
			{
				maKH = cmb_dsKH.SelectedValue.ToString();
				queryHD = "insert into HOADON values('" + maHD + "', '" + maKH + "', '" + ngayTaoHD + "', " + double.Parse(tienGiamGia) + ", '"+frmMain.maNV+"',GETDATE())";
				queryUpdateDiemThuong = "exec UPDATEDIEMTHUONG " + soDiemThuong + ", '" + maKH + "'";
			}
			else
			{
				maKH = "NULL";
				queryHD = "insert into HOADON values('" + maHD + "', " + maKH + ", '" + ngayTaoHD + "', " + double.Parse(tienGiamGia) + ", '" + frmMain.maNV + "',GETDATE())";
			}

			//Thêm 1 dòng vào bảng HOADON
			int r = db.getNonquery(queryHD);
			if (r == 1)
			{//Thêm nhiều dòng vào bảng chi tiết hóa đơn              
				string gioBD = txt_StartTime.Text;
				string gioKT = txt_EndTime.Text;

				string maBan = "";
				if (maLoaiBan == 1)
					maBan = "C" + lb_SoBan.Text.Split(' ')[1];
				else
					maBan = "B" + lb_SoBan.Text.Split(' ')[1];
				string queryCTHD =
					"insert into ChiTietHoaDon values('" + maHD + "', '" + maBan + "', '" + gioBD + "', '" + gioKT + "')";
				int k = db.getNonquery(queryCTHD);
				if (k == 0)
				{
					MessageBox.Show("Thêm không thành công");
					return;
				}

				//Thêm vào bảng chi tiết dịch vụ
				DataTable dt = db.getDataTable("select IDCTHD from ChiTietHoaDon Order by IDCTHD desc");
				int idCTHD = int.Parse(dt.Rows[0]["IDCTHD"].ToString());

				foreach (DataRow dr in dt_DsDvOrdered.Rows)
				{
					int maDV = int.Parse(dr["MaDV"].ToString());
					int sl = int.Parse(dr["SoLuong"].ToString());
					string queryCTDV =
						"insert into ChiTietDichVu values(" + idCTHD + ", " + maDV + ", " + sl + ")";
					int kq = db.getNonquery(queryCTDV);
					if (kq == 0)
					{
						MessageBox.Show("Không lưu được hóa đơn", "Lỗi");
						return;
					}
				}
				MessageBox.Show("Lưu hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				int g = -1;

				if ( queryUpdateDiemThuong != "NULL")
					g = db.getNonquery(queryUpdateDiemThuong); //Update số điểm thưởng cho khách

				if (g != 1)
					MessageBox.Show("Cập nhật số điểm thưởng cho khách thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

				frmDSBanBida.dsTrangThaiBan.Remove(selectedBan);//Xóa các trạng thái đã lưu
				DoiMauNenThanhXanh?.Invoke(this, new EventArgs()); //Đổi màu nền lại thành màu xanh

				//Lấy ra thông tin đặt bàn của khách hàng đang chơi bàn này vào ngày hiện tại
				DataTable dtdsBookedTableToday = LayBanDatCuaKhachToday(maKH, maBan);
				if (dtdsBookedTableToday != null && dtdsBookedTableToday.Rows.Count != 0) //Nếu có
				{
					foreach (DataRow item in dtdsBookedTableToday.Rows)
					{
						int n;
						//Kiểm tra xem khách đang sử dụng bàn này có phải là khách đã đặt bàn nay hay không
						if (item["MaKH"].ToString() == maKH && item["MaBan"].ToString().Trim() == maBan) //Nếu có
						{
							//Xóa thông tin đặt bàn của khách hàng đó
							n = db.getNonquery("delete from DATBAN where MAKH = '" + maKH + "' and MABAN = '" + maBan + "'");
							if (n == 1)
							{
								MessageBox.Show("Thông tin đặt bàn của khách đã được xóa");
								break;
							}
							else
							{
								MessageBox.Show("Lỗi khi xóa thông tin đặt bàn");
								break;
							}
						}
					}
				}
			}
			else
				MessageBox.Show("Không lưu được hóa đơn", "Lỗi");

		}

		//Thêm khách hàng mới
		private void btn_AddKH_Click(object sender, EventArgs e)
		{
			frmThemKH frm = new frmThemKH();
			frm.ShowDialog();
		}
		#endregion

		#region Hàm tự định nghĩa
		private void LocTheoLoaiDV(int MaLoaiDV)
		{
			string query = "select MaDV, TenDV, Gia from DichVu where MALOAIDVU = " + MaLoaiDV.ToString();
			DataTable dt = db.getDataTable(query);
			dtgv_DSDV.DataSource = dt;
			dtgv_DSDV.Refresh();
		}

		//Kiểm tra nút thêm món
		private bool IsEnableAddMon()
		{
			if (string.IsNullOrEmpty(txt_SoLuong.Text))
				return false;
			if (dtgv_DSDV.SelectedCells.Count <= 0)
				return false;
			return true;
		}

		//Kiểm tra nút thanh toán
		private bool IsEnableThanhToan()
		{
			List<TextBox> lst = grb_ThanhToan.Controls.OfType<TextBox>().ToList();
			foreach (TextBox tb in lst)
			{
				if (string.IsNullOrEmpty(tb.Text))
					return false;
			}
			return true;
		}

		//Tính tổng tiền dịch vụ
		private double tinhPhiDV()
		{
			double tong = 0;
			if (dt_DsDvOrdered.Rows.Count > 0)
			{
				foreach (DataRow dr in dt_DsDvOrdered.Rows)
				{
					tong += double.Parse(dr["SoLuong"].ToString()) * double.Parse(dr["DonGia"].ToString());
				}
			}
			return tong;
		}

		//Chuyển sang số giờ chơi
		private double ChuyenSangSoGio(string chuoiTime)
		{
			string[] s = chuoiTime.Split(':');
			int hour = int.Parse(s[0]);
			int minutes = int.Parse(s[1]);
			int seconds = int.Parse(s[2]);

			return (double)hour + (double)minutes / 60 + (double)seconds / 3600;
		}

		//Tính ra tiền theo số giờ đã chơi
		private double tinhTienTheoGioChoi()
		{
			return double.Parse(txt_GioChoi.Text) * double.Parse(txt_Gia1GioChoi.Text);
		}

		//Tạo mã hóa đơn cho 1 hóa đơn
		private string TaoMaHD()
		{
			string maHD = "HD";
			maHD += DateTime.Now.ToString("ddMMyyyy");
			string query = "select MAHD from HOADON where MAHD like '" + maHD + "%' order by MAHD desc";
			DataTable dt = db.getDataTable(query);
			if (dt.Rows.Count == 0) //Nhập cho ngày mới;
			{
				maHD += "001";
			}
			else
			{
				int stt = int.Parse(dt.Rows[0][0].ToString().Substring(12));
				stt++;
				if (stt.ToString().Length == 1)
				{
					maHD += "00" + stt.ToString();
				}
				else if (stt.ToString().Length == 2)
					maHD += "0" + stt.ToString();
				else
					maHD += stt.ToString();
			}
			return maHD;
		}

		private void CanhBaoBanDuocDat()
		{
			//Hiện cảnh báo bàn được đặt
			DateTime ngayHT = DateTime.Now; //Lấy ra ngày hiện tại
			DateTime ngayTT = ngayHT.AddDays(1); //Lấy ra ngày tiếp theo của ngày hiện tại
			string ban = "";
			if (maLoaiBan == 1)
				ban = "C" + selectedBan;
			else
				ban = "B" + selectedBan;

			string queryBan =
				"select * from DATBAN where NGAYDATBAN between '" + ngayHT.ToString("yyyy-MM-dd") + "' and '" + ngayTT.ToString("yyyy-MM-dd") + "' and DATEDIFF(HOUR, GETDATE(), NgayDatBan) < 2";
			DataTable dtDSBanDat = db.getDataTable(queryBan);
			if (dtDSBanDat != null && dtDSBanDat.Rows.Count != 0)
			{
				foreach (DataRow item in dtDSBanDat.Rows)
				{
					string tgDat = item["NgayDatBan"].ToString().Split(' ')[1];

					if (string.Compare(item["MaBan"].ToString().Trim(), ban) == 0)
					{
						MessageBox.Show("Bàn đã có người đặt vào lúc " + tgDat, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}
			}
		}

		//Lấy ra bàn được đặt của 1 khách cụ thể trong ngày hiện tại
		private DataTable LayBanDatCuaKhachToday(string makh, string maban)
		{
			DateTime ngayHT = DateTime.Now; //Lấy ra ngày hiện tại
			DateTime ngayTT = ngayHT.AddDays(1); //Lấy ra ngày tiếp theo của ngày hiện tại

			string query =
				"select * from DatBan where NgayDatBan Between '" + ngayHT.ToString("yyyy-MM-dd") + "' and '" + ngayTT.ToString("yyyy-MM-dd") + "' and MaKH = '" + makh + "' and MaBan = '" + maban + "'";
			DataTable dt = db.getDataTable(query);
			return dt;
		}
		#endregion

		#region Ràng buộc dữ liệu
		private void txt_SoLuong_TextChanged(object sender, EventArgs e)
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
			btn_AddMon.Enabled = IsEnableAddMon();
		}

		private void txt_SoLuong_Leave(object sender, EventArgs e)
		{
			TextBox txt = (TextBox)sender;
			if (string.IsNullOrEmpty(txt.Text))
			{
				errorProvider1.SetError(txt, "Không được bỏ trống!");
			}
			else
			{
				errorProvider1.Clear();
			}

			btn_AddMon.Enabled = IsEnableAddMon();
		}

		private void ck_KhachLe_CheckedChanged(object sender, EventArgs e)
		{
			if (ck_KhachLe.Checked == true)
			{
				txt_GiamGia.Text = "0";
				txt_Loaikhach.Text = "Khách lẻ";
				cmb_dsKH.Enabled = false;
			}
			else
			{
				cmb_dsKH.Enabled = true;
			}
		}


		#endregion


	}
}
