using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace QL_Bida
{
    public class DBConnect
    {
        public string connString = @"Data Source=DESKTOP-66E7O53\SQLEXPRESS;Initial Catalog=QLBIDA;Integrated Security=True";
        public SqlConnection conn = new SqlConnection();
        public DBConnect()
        {
            conn = new SqlConnection(connString);
        }

        public void Open()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        public void Close()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public int getNonquery(string strQuery)
        {
            Open();
            SqlCommand cmd = new SqlCommand(strQuery, conn);
            int kq = cmd.ExecuteNonQuery();
            Close();

            return kq;
        }

        public DataTable getDataTable(string strQuery)
        {
            DataSet dt = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(strQuery, conn);
            da.Fill(dt);
            return dt.Tables[0];
        }

        public int getScalar(string strQuery)
        {
            Open();
            SqlCommand cmd = new SqlCommand(strQuery, conn);
            int kq = (int)cmd.ExecuteScalar();
            Close();

            return kq;
        }

        public int updateTable(string query, DataTable dtNew)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            int kq = da.Update(dtNew);
            if (kq == 0)
                System.Windows.Forms.MessageBox.Show("k = 0");
            return kq;
        }

        public string GenerateMaHoaDon()
        {
            string query = "SELECT MAX(CAST(SUBSTRING(MANV, 3, LEN(MANV) - 2) AS INT)) FROM NHANVIEN";
            int maxNumber = 0;

            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                var result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    maxNumber = (int)result;
                }
            }

            int nextNumber = maxNumber + 1;
            return "NV" + nextNumber.ToString("D3");  // HD000n
        }

        public string TaoMAPN() {

            string maPN = string.Empty;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand("TaoMAPN", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm tham số OUTPUT
                SqlParameter outputParam = new SqlParameter("@MaPN", SqlDbType.NVarChar, 5)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputParam);

                try
                {
                    // Mở kết nối và thực thi stored procedure
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    // Lấy giá trị trả về từ tham số OUTPUT
                    maPN = outputParam.Value.ToString();
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu có
                    Console.WriteLine("Lỗi khi gọi stored procedure: " + ex.Message);
                }
            }

            return maPN;
        }
        public string TaoMAPX()
        {

            string maPN = string.Empty;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand("TaoMAPX", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm tham số OUTPUT
                SqlParameter outputParam = new SqlParameter("@MaPN", SqlDbType.NVarChar, 5)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputParam);

                try
                {
                    // Mở kết nối và thực thi stored procedure
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    // Lấy giá trị trả về từ tham số OUTPUT
                    maPN = outputParam.Value.ToString();
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu có
                    Console.WriteLine("Lỗi khi gọi stored procedure: " + ex.Message);
                }
            }

            return maPN;
        }
    }
}
