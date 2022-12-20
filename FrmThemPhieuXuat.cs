using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho_Tuan1
{
    public partial class FrmThemPhieuXuat : Form
    {
        private DataTable chiTietPhieuXuats;
        public FrmThemPhieuXuat()
        {
            InitializeComponent();
            chiTietPhieuXuats = new DataTable();
            dgv_chiTietPhieuXuat.AutoGenerateColumns = false;
            chiTietPhieuXuats.Columns.Add("MaHangHoa");
            chiTietPhieuXuats.Columns.Add("TenHangHoa");
            chiTietPhieuXuats.Columns.Add("MaDonViTinh");
            chiTietPhieuXuats.Columns.Add("TenDonViTinh");
            chiTietPhieuXuats.Columns.Add("SoLuong");
            chiTietPhieuXuats.Columns.Add("DonGia");
            chiTietPhieuXuats.Columns.Add("ChietKhau");
            loadKho();
            loadLoaiHang();
            but_xoa.Enabled = dgv_chiTietPhieuXuat.Rows.Count > 0;
        }
        private void loadKho()
        {
            cbb_maKho.DataSource = Database.Query("select * from Kho", new Dictionary<string, object>());
        }
        private void loadLoaiHang()
        {
            cbb_loaiHang.DataSource = Database.Query("select * from LoaiHang", new Dictionary<string, object>());
        }
        private void cbb_loaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_loaiHang.Text != "")
            {
                string strCommand = "select * from dbo.ufLayHangHoaTheoMaLoaiHang(@maLoaiHang)";
                Dictionary<string, object> parameter = new Dictionary<string, object>();
                parameter.Add("@maLoaiHang", cbb_loaiHang.SelectedValue);
                cbb_maHangHoa.DataSource = Database.Query(strCommand, parameter);
            }
        }
        private void cbb_maHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_maHangHoa.Text != "")
            {
                string strCommand = "select * from dbo.ufLayDonViTinhCuaHangHoa(@maHangHoa)";
                Dictionary<string, object> parameter = new Dictionary<string, object>();
                parameter.Add("@maHangHoa", cbb_maHangHoa.SelectedValue);
                cbb_maDonViTinh.DataSource = Database.Query(strCommand, parameter);
            }
        }
        private bool checkPhieuXuat()
        {
            bool result = true;
            erroMes.Clear();
            string noiNhan = txt_noiNhan.Text.Trim();
            string nguoiNhanHang = txt_nguoiNhanHang.Text.Trim();
            if(noiNhan == "" || noiNhan.Length > 100)
            {
                erroMes.SetError(txt_noiNhan, "Loi dinh dang noi nhan");
                result = false;
            }
            if(nguoiNhanHang.Length > 50 || nguoiNhanHang == "")
            {
                erroMes.SetError(txt_nguoiNhanHang, "Loi dinh dang nguoi nhan hang");
                result = false;
            }
            status.Text = "Status: Loi cap nhap du lieu";
            return result;
        }

        private bool checkChiTietPhieuXuat()
        {
            bool result = true;
            erroMes.Clear();
            if (String.IsNullOrEmpty(cbb_maHangHoa.Text))
            {
                erroMes.SetError(cbb_maHangHoa, "Thieu ma hang hoa");
                result = false;
            }
            if (String.IsNullOrEmpty(cbb_maDonViTinh.Text))
            {
                erroMes.SetError(cbb_maDonViTinh, "Thieu don vi tinh");
                result = false;
            }
            if (String.IsNullOrEmpty(txt_soLuong.Text))
            {
                erroMes.SetError(txt_soLuong, "Thieu so luong");
                result = false;
            }
            if (String.IsNullOrEmpty(txt_donGia.Text))
            {
                erroMes.SetError(txt_donGia, "Thieu don gia");
                result = false;
            }
            if (String.IsNullOrEmpty(txt_chietKhau.Text))
            {
                erroMes.SetError(txt_chietKhau, "Thieu chiet khau");
                result = false;
            }
            status.Text = "Status: Loi cap nhap du lieu";
            return result;
        }

        private void but_them_Click(object sender, EventArgs e)
        {
            if (this.checkChiTietPhieuXuat() == false)
                return;
            for (int i = 0; i < dgv_chiTietPhieuXuat.Rows.Count; i++)
            {
                if (cbb_maHangHoa.SelectedValue.ToString() == chiTietPhieuXuats.Rows[i]["MaHangHoa"].ToString() && cbb_maDonViTinh.SelectedValue.ToString() == chiTietPhieuXuats.Rows[i]["MaDonViTinh"].ToString())
                    return;
            }
            DataRow chiTietPhieuXuat = chiTietPhieuXuats.NewRow();
            chiTietPhieuXuat["MaHangHoa"] = cbb_maHangHoa.SelectedValue;
            chiTietPhieuXuat["TenHangHoa"] = cbb_maHangHoa.Text;
            chiTietPhieuXuat["MaDonViTinh"] = cbb_maDonViTinh.SelectedValue;
            chiTietPhieuXuat["TenDonViTinh"] = cbb_maDonViTinh.Text;
            chiTietPhieuXuat["SoLuong"] = Convert.ToDouble(txt_soLuong.Text);
            chiTietPhieuXuat["DonGia"] = Convert.ToDouble(txt_donGia.Text);
            chiTietPhieuXuat["ChietKhau"] = Convert.ToDouble(txt_chietKhau.Text);
            chiTietPhieuXuats.Rows.Add(chiTietPhieuXuat);
            dgv_chiTietPhieuXuat.DataSource = chiTietPhieuXuats;
            but_xoa.Enabled = dgv_chiTietPhieuXuat.Rows.Count > 0;
            status.Text = "Status: Cap nhap du lieu thanh cong";
        }

        private void but_luu_Click(object sender, EventArgs e)
        {
            if (this.checkPhieuXuat() == false || dgv_chiTietPhieuXuat.Rows.Count < 1)
                return;
            //Them phieu xuat               
            string strCommand = "exec spThemPhieuXuat @ngayXuat,@nguoiNhanHang,@noiNhan,@maKho,@thuKho,@ghiChu";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            string strQuery = "select ThuKho from Kho where MaKho=@maKho";
            parameter.Add("@maKho", cbb_maKho.SelectedValue);
            string thuKho = Database.Query(strQuery, parameter).Rows[0][0].ToString();
            parameter.Add("@ngayXuat", dtp_ngayXuat.Value);
            parameter.Add("@nguoiNhanHang", txt_nguoiNhanHang.Text);
            parameter.Add("@noiNhan", txt_noiNhan.Text);
            parameter.Add("@thuKho", thuKho);
            parameter.Add("@ghiChu", txt_ghiChu.Text);
            Database.Execute(strCommand, parameter);
            //Them n chi tiet phieu xuat
            strCommand = "exec spThemChiTietPhieuXuat @maHangHoa,@maDonViTinh,@soLuong,@donGia,@chietKhau";
            for(int i = 0; i < chiTietPhieuXuats.Rows.Count; i++)
            {
                parameter.Clear();
                parameter.Add("@maHangHoa", chiTietPhieuXuats.Rows[i]["MaHangHoa"]);
                parameter.Add("@maDonViTinh", chiTietPhieuXuats.Rows[i]["MaDonViTinh"]);
                parameter.Add("@soLuong", Convert.ToDouble(chiTietPhieuXuats.Rows[i]["SoLuong"]));
                parameter.Add("@donGia", Convert.ToDouble(chiTietPhieuXuats.Rows[i]["DonGia"]));
                parameter.Add("@chietKhau", Convert.ToDouble(chiTietPhieuXuats.Rows[i]["ChietKhau"]));
                Database.Execute(strCommand, parameter);
            }
            this.Close();
        }

        private void but_xoa_Click(object sender, EventArgs e)
        {
            int index = dgv_chiTietPhieuXuat.CurrentRow.Index;
            chiTietPhieuXuats.Rows.RemoveAt(index);
            dgv_chiTietPhieuXuat.DataSource = chiTietPhieuXuats;
            but_xoa.Enabled = dgv_chiTietPhieuXuat.Rows.Count > 0;
        }

        private void txt_donGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_chietKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_soLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void but_loaiHang_Click(object sender, EventArgs e)
        {
            FrmQuanLyLoaiHang form = new FrmQuanLyLoaiHang();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void but_hangHoa_Click(object sender, EventArgs e)
        {
            FrmQuanLyHangHoa form = new FrmQuanLyHangHoa();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void but_donViTinh_Click(object sender, EventArgs e)
        {
            FrmQuanLyDonViTinh form = new FrmQuanLyDonViTinh();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }
    }
}
