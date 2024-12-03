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
using System.Windows.Forms.DataVisualization.Charting;


namespace QL_Bida
{
	public partial class frm_ThongKe : Form
	{
		DBConnect db = new DBConnect();
		public frm_ThongKe()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string thang = cbThang?.SelectedItem.ToString();
			string nam = cbNam?.SelectedItem.ToString();
			// Kiểm tra nếu chưa chọn tháng hoặc năm
			if (string.IsNullOrEmpty(thang) && string.IsNullOrEmpty(nam))
			{
				MessageBox.Show("Vui lòng chọn tháng và năm trước khi lọc!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return; // Ngừng xử lý nếu không có giá trị
			}
			DataTable dt = LayDuLieuThongKe(thang, nam);
			VeBieuDoDoanhThu(dt);
		}

		private void VeBieuDoDoanhThu(DataTable dt)
		{
			cThongke.Series.Clear();
			cThongke.Titles.Clear();
			cThongke.ChartAreas[0].AxisY.Minimum = 0; // Đặt giới hạn trục Y tối thiểu
			cThongke.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount; // Tự động điều chỉnh khoảng chia trục Y
			cThongke.ChartAreas[0].AxisX.Interval = 1; // Hiển thị từng tháng trên trục X
			cThongke.ChartAreas[0].AxisX.MajorGrid.Enabled = false; // Tắt đường lưới dọc trên trục X
			cThongke.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray; // Tùy chỉnh màu lưới ngang

			// Thêm tiêu đề biểu đồ
			cThongke.Titles.Add("Thống Kê Doanh Thu Cửa Hàng");

			// Tạo Series "Doanh Thu"
			Series seriesDoanhThu = new Series("Tổng Doanh Thu")
			{
				ChartType = SeriesChartType.Column,
				XValueType = ChartValueType.String,
				IsValueShownAsLabel = true, // Hiển thị giá trị trên cột
				BorderWidth = 1 // Độ dày viền cột
			};

			foreach (DataRow row in dt.Rows)
			{
				string thang = row["Thang"].ToString();
				double doanhThu = row["TongDoanhThu"] != DBNull.Value ? Convert.ToDouble(row["TongDoanhThu"]) : 0.0;
				seriesDoanhThu.Points.AddXY(thang, doanhThu);
			}

			// Thêm Series vào biểu đồ
			cThongke.Series.Add(seriesDoanhThu);

			// Cấu hình thêm (nếu cần)
			cThongke.Legends[0].Docking = Docking.Top; // Đặt chú thích lên trên biểu đồ
			cThongke.Legends[0].Font = new Font("Arial", 10, FontStyle.Regular); // Tùy chỉnh font của chú thích
		}


		private DataTable LayDuLieuThongKe(string thang, string nam)
		{
			string query = @"
SELECT 
    FORMAT(HD.NgayLap, 'MM-yyyy') AS Thang,
    SUM(
        DATEDIFF(MINUTE, CTHD.GIOBATDAU, CTHD.GIOKETTHUC) / 60.0 * ISNULL(DG.GIA, 0)
        * CASE 
            WHEN HD.MaHD = 'HD001' THEN 0.5  -- Chia đôi chỉ cho mã HD001
            ELSE 1
        END
    ) AS TienGio,
    SUM(ISNULL(CTDV.SoLuong, 0) * ISNULL(DV.Gia, 0)) AS TienDichVu,
    SUM(DATEDIFF(MINUTE, CTHD.GIOBATDAU, CTHD.GIOKETTHUC) / 60.0 * ISNULL(DG.GIA, 0)
        * CASE 
            WHEN HD.MaHD = 'HD001' THEN 0.5  -- Chia đôi chỉ cho mã HD001
            ELSE 1
        END
    ) + SUM(ISNULL(CTDV.SoLuong, 0) * ISNULL(DV.Gia, 0))  AS TongDoanhThu
FROM 
    HoaDon HD
LEFT JOIN (
    SELECT DISTINCT MaHD, MABAN, GIOBATDAU, GIOKETTHUC, IDCTHD  
    FROM ChiTietHoaDon
) CTHD ON HD.MaHD = CTHD.MaHD
LEFT JOIN BanBida BB ON CTHD.MABAN = BB.MaBan 
LEFT JOIN DONGIA DG ON BB.MALOAIBAN = DG.MALOAIBAN 
    AND CTHD.GIOBATDAU >= DG.KHUNGGIOBATDAU 
    AND CTHD.GIOKETTHUC <= DG.KHUNGGIOKETTHUC 
LEFT JOIN CHITIETDICHVU CTDV ON CTHD.IDCTHD = CTDV.IDCTHD 
LEFT JOIN DichVu DV ON CTDV.MaDV = DV.MaDV
WHERE 
    (@Thang IS NULL OR FORMAT(HD.NgayLap, 'MM') = @Thang) AND 
    (@Nam IS NULL OR FORMAT(HD.NgayLap, 'yyyy') = @Nam)
GROUP BY 
    FORMAT(HD.NgayLap, 'MM-yyyy') 
ORDER BY 
    FORMAT(HD.NgayLap, 'MM-yyyy');";

			DataTable dt = new DataTable();
			using (SqlConnection conn = new SqlConnection(db.connString))
			{
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					cmd.Parameters.AddWithValue("@Thang", string.IsNullOrEmpty(thang) ? (object)DBNull.Value : thang);
					cmd.Parameters.AddWithValue("@Nam", string.IsNullOrEmpty(nam) ? (object)DBNull.Value : nam);

					SqlDataAdapter da = new SqlDataAdapter(cmd);
					da.Fill(dt);
				}
			}

			return dt;
		}

		private void frm_ThongKe_Load(object sender, EventArgs e)
		{
			// Thêm danh sách tháng
			cbThang.Items.Add(""); // Không chọn tháng
			for (int i = 1; i <= 12; i++)
			{
				cbThang.Items.Add(i.ToString("D2"));
			}

			// Thêm danh sách năm
			cbNam.Items.Add(""); // Không chọn năm
			for (int i = 2000; i <= DateTime.Now.Year; i++)
			{
				cbNam.Items.Add(i.ToString());
			}

			for (int i = 1; i <= 12; i++)
			{
				comboBox1.Items.Add(i);
			}

			// Đặt giá trị mặc định là tháng hiện tại
			comboBox1.SelectedIndex = DateTime.Now.Month - 1;
		}
		private void LoadPieChart(int month)
		{
			DataTable data = db.GetTableData(month);

			chart1.Series.Clear();
			Series series = new Series("Loại bàn")
			{
				ChartType = SeriesChartType.Pie
			};

			chart1.Series.Add(series);

			foreach (DataRow row in data.Rows)
			{
				series.Points.AddXY(row["TENLOAIBAN"], row["SoLanChon"]);
			}

			chart1.Titles.Clear();
            //chart1.Titles.Add($"Tỷ lệ chọn loại bàn tháng {month}");
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox1.SelectedItem != null)
			{
				int selectedMonth = int.Parse(comboBox1.SelectedItem.ToString());
				LoadPieChart(selectedMonth); // Hàm vẽ biểu đồ tròn
			}
		}
	}
}
