
namespace QuanLyKho_Tuan1
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mstQuanLyKho = new System.Windows.Forms.MenuStrip();
            this.mstQuanLyHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mniQuanLyNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.mstQuanLyDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_LoaiHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_DonViTinh = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_quanLyHangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_quanLyKho = new System.Windows.Forms.ToolStripMenuItem();
            this.mstQuanLyPhieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_quanLyPhieuNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_quanLyPhieuXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mstQuanLyKho.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstQuanLyKho
            // 
            this.mstQuanLyKho.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mstQuanLyKho.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstQuanLyHeThong,
            this.mstQuanLyDanhMuc,
            this.mstQuanLyPhieu});
            this.mstQuanLyKho.Location = new System.Drawing.Point(0, 0);
            this.mstQuanLyKho.Name = "mstQuanLyKho";
            this.mstQuanLyKho.Size = new System.Drawing.Size(944, 24);
            this.mstQuanLyKho.TabIndex = 1;
            this.mstQuanLyKho.Text = "menuStrip1";
            // 
            // mstQuanLyHeThong
            // 
            this.mstQuanLyHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniQuanLyNguoiDung});
            this.mstQuanLyHeThong.Name = "mstQuanLyHeThong";
            this.mstQuanLyHeThong.Size = new System.Drawing.Size(69, 20);
            this.mstQuanLyHeThong.Text = "Hệ thống";
            // 
            // mniQuanLyNguoiDung
            // 
            this.mniQuanLyNguoiDung.Name = "mniQuanLyNguoiDung";
            this.mniQuanLyNguoiDung.Size = new System.Drawing.Size(180, 22);
            this.mniQuanLyNguoiDung.Text = "Quản lý người dùng";
            this.mniQuanLyNguoiDung.Click += new System.EventHandler(this.mniQuanLyNguoiDung_Click);
            // 
            // mstQuanLyDanhMuc
            // 
            this.mstQuanLyDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_LoaiHang,
            this.mni_DonViTinh,
            this.mni_quanLyHangHoa,
            this.mni_quanLyKho});
            this.mstQuanLyDanhMuc.Name = "mstQuanLyDanhMuc";
            this.mstQuanLyDanhMuc.Size = new System.Drawing.Size(74, 20);
            this.mstQuanLyDanhMuc.Text = "Danh mục";
            // 
            // mni_LoaiHang
            // 
            this.mni_LoaiHang.Name = "mni_LoaiHang";
            this.mni_LoaiHang.Size = new System.Drawing.Size(185, 22);
            this.mni_LoaiHang.Text = "Cập nhập loại hàng";
            this.mni_LoaiHang.Click += new System.EventHandler(this.mni_LoaiHang_Click);
            // 
            // mni_DonViTinh
            // 
            this.mni_DonViTinh.Name = "mni_DonViTinh";
            this.mni_DonViTinh.Size = new System.Drawing.Size(185, 22);
            this.mni_DonViTinh.Text = "Cập nhập đơn vị tính";
            this.mni_DonViTinh.Click += new System.EventHandler(this.mni_DonViTinh_Click);
            // 
            // mni_quanLyHangHoa
            // 
            this.mni_quanLyHangHoa.Name = "mni_quanLyHangHoa";
            this.mni_quanLyHangHoa.Size = new System.Drawing.Size(185, 22);
            this.mni_quanLyHangHoa.Text = "Cập nhập hàng hoá";
            this.mni_quanLyHangHoa.Click += new System.EventHandler(this.mni_quanLyHangHoa_Click);
            // 
            // mni_quanLyKho
            // 
            this.mni_quanLyKho.Name = "mni_quanLyKho";
            this.mni_quanLyKho.Size = new System.Drawing.Size(185, 22);
            this.mni_quanLyKho.Text = "Quản lý kho";
            this.mni_quanLyKho.Click += new System.EventHandler(this.mit_quanLyKho_Click);
            // 
            // mstQuanLyPhieu
            // 
            this.mstQuanLyPhieu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_quanLyPhieuNhap,
            this.mni_quanLyPhieuXuat});
            this.mstQuanLyPhieu.Name = "mstQuanLyPhieu";
            this.mstQuanLyPhieu.Size = new System.Drawing.Size(93, 20);
            this.mstQuanLyPhieu.Text = "Quản lý phiếu";
            // 
            // mni_quanLyPhieuNhap
            // 
            this.mni_quanLyPhieuNhap.Name = "mni_quanLyPhieuNhap";
            this.mni_quanLyPhieuNhap.Size = new System.Drawing.Size(178, 22);
            this.mni_quanLyPhieuNhap.Text = "Quản lý phiếu nhập";
            this.mni_quanLyPhieuNhap.Click += new System.EventHandler(this.mni_quanLyPhieuNhap_Click);
            // 
            // mni_quanLyPhieuXuat
            // 
            this.mni_quanLyPhieuXuat.Name = "mni_quanLyPhieuXuat";
            this.mni_quanLyPhieuXuat.Size = new System.Drawing.Size(178, 22);
            this.mni_quanLyPhieuXuat.Text = "Quản lý phiếu xuất";
            this.mni_quanLyPhieuXuat.Click += new System.EventHandler(this.mni_quanLyPhieuXuat_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.mstQuanLyKho);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mstQuanLyKho;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ KHO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.mstQuanLyKho.ResumeLayout(false);
            this.mstQuanLyKho.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstQuanLyKho;
        private System.Windows.Forms.ToolStripMenuItem mstQuanLyHeThong;
        private System.Windows.Forms.ToolStripMenuItem mstQuanLyDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mni_LoaiHang;
        private System.Windows.Forms.ToolStripMenuItem mni_DonViTinh;
        private System.Windows.Forms.ToolStripMenuItem mni_quanLyKho;
        private System.Windows.Forms.ToolStripMenuItem mstQuanLyPhieu;
        private System.Windows.Forms.ToolStripMenuItem mni_quanLyPhieuNhap;
        private System.Windows.Forms.ToolStripMenuItem mni_quanLyPhieuXuat;
        private System.Windows.Forms.ToolStripMenuItem mniQuanLyNguoiDung;
        private System.Windows.Forms.ToolStripMenuItem mni_quanLyHangHoa;
    }
}