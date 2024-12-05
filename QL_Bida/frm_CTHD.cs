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
    public partial class frm_CTHD : Form
    {
        public static string maHD;
        DBConnect db = new DBConnect();
        public frm_CTHD()
        {
            InitializeComponent();
        }

        private void frm_CTHD_Load(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(maHD))
            {
                MessageBox.Show("Mã hóa đơn rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = "exec XEMCTHD '" + maHD + "'";
                DataTable dt = db.getDataTable(query);
                dtgv_cthd.DataSource = dt;
            }    
        }
    }
}
