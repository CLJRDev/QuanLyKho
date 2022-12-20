using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuanLyKho_Tuan1
{
    public partial class FrmQuanLyLoaiHang : Form
    {
        public FrmQuanLyLoaiHang()
        {
            InitializeComponent();
            Load_dgv_LoaiHang();
        }    
        private bool check()
        {
            bool result = true;
            //errorProvider;
            errorMes.Clear();
            if(txt_maLoaiHang.Text == "")
            {
                errorMes.SetError(txt_maLoaiHang,"Ma loai hang khong duoc de trong");
                result = false;
            }
            if (txt_tenLoaiHang.Text == "")
            {
                errorMes.SetError(txt_tenLoaiHang, "Ten loai hang khong duoc de trong");
                result = false;
            }
            labMes.Text = "Thong bao: loi cap nhap du lieu";
            return result;
        }

        private void Load_dgv_LoaiHang()
        {
            if(ck_timKiem.Checked == false)
            {
                string strQuery = "SELECT * FROM LoaiHang";
                dgv_LoaiHang.DataSource = Database.Query(strQuery, new Dictionary<string, object>());
            }
            else
            {
                string strQuery = "SELECT * FROM dbo.ufTimKiemLoaiHang(@maLoaiHang,@tenLoaiHang)";
                Dictionary<string, object> parameter = new Dictionary<string, object>();
                if (ck_maLoaiHang.Checked)
                {
                    parameter.Add("@maLoaiHang", txt_maLoaiHang.Text);
                }
                else
                {
                    parameter.Add("@maLoaiHang", "");
                }
                if (ck_tenLoaiHang.Checked)
                {
                    parameter.Add("@tenLoaiHang", txt_tenLoaiHang.Text);
                }
                else
                {
                    parameter.Add("@tenLoaiHang", "");
                }
                dgv_LoaiHang.DataSource = Database.Query(strQuery, parameter);
            }
            but_sua.Enabled = but_xoa.Enabled = dgv_LoaiHang.Rows.Count > 0;
        }
        private void but_them_Click(object sender, EventArgs e)
        {
            if (this.check() == false)
                return;
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            string strCommand = "exec spThemLoaiHang @maLoaiHang, @tenLoaiHang";
            parameter.Add("@maLoaiHang", txt_maLoaiHang.Text);
            parameter.Add("@tenLoaiHang", txt_tenLoaiHang.Text);
            errorMes.Clear();
            try
            {
                Database.Execute(strCommand, parameter);
                Load_dgv_LoaiHang();
                labMes.Text = "Thong bao: them du lieu thanh cong";
            }
            catch(Exception ex)
            {
                if(ex.Message == "Trùng mã loại hàng")
                {
                    errorMes.SetError(txt_maLoaiHang, ex.Message);
                }
                if(ex.Message == "Trùng tên loại hàng")
                {
                    errorMes.SetError(txt_tenLoaiHang, ex.Message);
                }
                labMes.Text = "Status: Lỗi trùng lặp dữ liệu";
            }
        }

        private void but_sua_Click(object sender, EventArgs e)
        {
            if (this.check() == false)
                return;
            errorMes.Clear();
            string strQuery = "exec spSuaLoaiHang @maLoaiHang,@tenLoaiHang";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maLoaiHang", dgv_LoaiHang.CurrentRow.Cells["MaLoaiHang"].Value.ToString());
            parameter.Add("@tenLoaiHang", txt_tenLoaiHang.Text);
            try
            {
                Database.Execute(strQuery, parameter);
                Load_dgv_LoaiHang();
                labMes.Text = "Thong bao: sua du lieu thanh cong";
            }
            catch (Exception ex)
            {
                errorMes.SetError(txt_tenLoaiHang, ex.Message);
                labMes.Text = "Status: Lỗi sửa dữ liệu";
            }
        }

        private void but_xoa_Click(object sender, EventArgs e)
        {
            string deleteCommand = "exec spXoaLoaiHang @maLoaiHang";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maLoaiHang", dgv_LoaiHang.CurrentRow.Cells["MaLoaiHang"].Value.ToString());
            try
            {
                Database.Execute(deleteCommand, parameter);
                Load_dgv_LoaiHang();
                labMes.Text = "Status: Xoá dữ liệu thành công";
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labMes.Text = "Satus: Xoá dữ liệu thất bại";
            }
        }
        private void ck_timKiem_CheckedChanged(object sender, EventArgs e)
        {
            but_timKiem.Enabled = ck_timKiem.Checked;
            Load_dgv_LoaiHang();
        }

        private void but_timKiem_Click(object sender, EventArgs e)
        {
            Load_dgv_LoaiHang();
        }

        private void dgv_LoaiHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txt_maLoaiHang.Text = dgv_LoaiHang.Rows[e.RowIndex].Cells["MaLoaiHang"].Value.ToString();
                txt_tenLoaiHang.Text = dgv_LoaiHang.Rows[e.RowIndex].Cells["TenLoaiHang"].Value.ToString();
                //Lấy danh sách hàng hoá theo mã loại hàng
                string strQuery = "select * from dbo.ufLayDanhSachHangHoaTheoLoaiHang(@maLoaiHang)";
                Dictionary<string, object> parameter = new Dictionary<string, object>();
                parameter.Add("@maLoaiHang", txt_maLoaiHang.Text);
                DataTable hangHoas = Database.Query(strQuery, parameter);
                //Đẩy danh sách lấy được lên tree view
                tv_hangHoa.Nodes.Clear();
                TreeNode node = new TreeNode("Danh sách hàng hoá:");
                for(int i = 0; i < hangHoas.Rows.Count; i++)
                {
                    node.Nodes.Add(hangHoas.Rows[i]["TenHangHoa"].ToString());
                }
                node.Expand();
                tv_hangHoa.Nodes.Add(node);
            }
        }
    }
}
