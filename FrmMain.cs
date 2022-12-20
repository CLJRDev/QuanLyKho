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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void mit_quanLyKho_Click(object sender, EventArgs e)
        {
            FrmQuanLyKho form = new FrmQuanLyKho();
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Text == form.Text)
                {
                    this.MdiChildren[i].Activate();
                    return;
                }
            }
            form.MdiParent = this;
            form.Show();
        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmDangNhap form = new FrmDangNhap();
            form.ShowDialog();
            if(form.getAuthentication == false)
            {
                Application.Exit();
            }
            else
            {
                string strQuery = "select * from dbo.ufLayPhanQuyen(@tenDangNhap)";
                Dictionary<string, object> parameter = new Dictionary<string, object>();
                parameter.Add("@tenDangNhap", Program.TenDangNhap);
                DataTable chucNangs = Database.Query(strQuery, parameter);
                List<string> listChucNangs = new List<string>();
                for(int i = 0; i < chucNangs.Rows.Count; i++)
                {
                    listChucNangs.Add(chucNangs.Rows[i]["TenChucNang"].ToString());
                }
                mni_DonViTinh.Enabled = listChucNangs.Contains("QuanLyDonViTinh");
                mni_LoaiHang.Enabled = listChucNangs.Contains("QuanLyLoaiHang");
                mni_quanLyPhieuNhap.Enabled = listChucNangs.Contains("QuanLyPhieuNhap");
                mni_quanLyPhieuXuat.Enabled = listChucNangs.Contains("QuanLyPhieuXuat");
                mni_quanLyKho.Enabled = listChucNangs.Contains("QuanLyKho");
                mniQuanLyNguoiDung.Enabled = listChucNangs.Contains("QuanLyNguoiDung");
                mni_quanLyHangHoa.Enabled = listChucNangs.Contains("QuanLyHangHoa");
            }
        }

        private void mni_quanLyPhieuXuat_Click(object sender, EventArgs e)
        {
            FrmQuanLyPhieuXuat form = new FrmQuanLyPhieuXuat();
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Text == form.Text)
                {
                    this.MdiChildren[i].Activate();
                    return;
                }
            }
            form.MdiParent = this;
            form.Show();
        }

        private void mni_quanLyPhieuNhap_Click(object sender, EventArgs e)
        {
            FrmQuanLyPhieuNhap form = new FrmQuanLyPhieuNhap();
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Text == form.Text)
                {
                    this.MdiChildren[i].Activate();
                    return;
                }
            }
            form.MdiParent = this;
            form.Show();
        }

        private void mni_DonViTinh_Click(object sender, EventArgs e)
        {
            FrmQuanLyDonViTinh form = new FrmQuanLyDonViTinh();
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Text == form.Text)
                {
                    this.MdiChildren[i].Activate();
                    return;
                }
            }
            form.MdiParent = this;
            form.Show();
        }

        private void mni_LoaiHang_Click(object sender, EventArgs e)
        {
            FrmQuanLyLoaiHang form = new FrmQuanLyLoaiHang();
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Text == form.Text)
                {
                    this.MdiChildren[i].Activate();
                    return;
                }
            }
            form.MdiParent = this;
            form.Show();
        }

        private void mni_quanLyHangHoa_Click(object sender, EventArgs e)
        {
            FrmQuanLyHangHoa form = new FrmQuanLyHangHoa();
            for(int i = 0; i < this.MdiChildren.Length; i++)
            {
                if(form.Text == this.MdiChildren[i].Text)
                {
                    this.MdiChildren[i].Activate();
                    return;
                }
            }
            form.MdiParent = this;
            form.Show();
        }

        private void mniQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            FrmQuanLyNguoiDung form = new FrmQuanLyNguoiDung();
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (form.Text == this.MdiChildren[i].Text)
                {
                    this.MdiChildren[i].Activate();
                    return;
                }
            }
            form.MdiParent = this;
            form.Show();
        }
    }
}
