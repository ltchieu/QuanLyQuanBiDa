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
    public partial class frmThemKH : Form
    {
        DBConnect db = new DBConnect();
        public frmThemKH()
        {
            InitializeComponent();
        }
        
        //Tạo mã khách hàng
        private void btn_TaoMaKH_Click(object sender, EventArgs e)
        {
            string makh = "KH";
            string query = "select MAKH from KHACHHANG order by MAKH desc";
            DataTable dt = db.getDataTable(query);
            int stt = int.Parse(dt.Rows[0][0].ToString().Substring(2));
            stt++;
            if (stt.ToString().Length == 1)
                makh += "00" + stt;
            else if (stt.ToString().Length == 2)
                makh += "0" + stt;
            else
                makh += stt.ToString();

            txt_MaKH.Text = makh;
            btn_ThemKH.Enabled = IsEnable();
        }

        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            string query =
                "insert into KHACHHANG values('" + txt_MaKH.Text + "', '" + txt_TenKH.Text + "' , 'TV', '" + txt_SDT.Text + "' , 0, '" + txt_DiaChi.Text + "')";
            int k = db.getNonquery(query);
            if(k == 1)
                MessageBox.Show("Thêm mới một khách hàng thành công");
            else
                MessageBox.Show("Thêm không thành công");

        }

        private void frmThemKH_Load(object sender, EventArgs e)
        {
            btn_ThemKH.Enabled = false;
        }

        private void txt_DiaChi_TextChanged(object sender, EventArgs e)
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
            btn_ThemKH.Enabled = IsEnable();
        }

        private void txt_TenKH_Leave(object sender, EventArgs e)
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

            btn_ThemKH.Enabled = IsEnable();
        }


        private bool IsEnable()
        {
            List<TextBox> lst = this.Controls.OfType<TextBox>().ToList();
            foreach (TextBox tb in lst)
            {
                if (string.IsNullOrEmpty(tb.Text))
                    return false;
            }
            
            return true;
        }


    }
}
