﻿
namespace QuanLyKho_Tuan1
{
    partial class FrmSuaKho
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSuaKho));
            this.labMes = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorMess = new System.Windows.Forms.ErrorProvider(this.components);
            this.but_luu = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tenKho = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_maKho = new System.Windows.Forms.TextBox();
            this.txt_thuKho = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_kho = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MaKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThuKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorMess)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kho)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labMes
            // 
            this.labMes.Name = "labMes";
            this.labMes.Size = new System.Drawing.Size(67, 17);
            this.labMes.Text = "Thông báo:";
            // 
            // errorMess
            // 
            this.errorMess.ContainerControl = this;
            // 
            // but_luu
            // 
            this.but_luu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.but_luu.Image = ((System.Drawing.Image)(resources.GetObject("but_luu.Image")));
            this.but_luu.Location = new System.Drawing.Point(426, 501);
            this.but_luu.Name = "but_luu";
            this.but_luu.Size = new System.Drawing.Size(100, 35);
            this.but_luu.TabIndex = 21;
            this.but_luu.UseVisualStyleBackColor = true;
            this.but_luu.Click += new System.EventHandler(this.but_luu_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labMes});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(944, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_diaChi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_tenKho);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_maKho);
            this.groupBox1.Controls.Add(this.txt_thuKho);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(921, 99);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin kho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã kho";
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_diaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_diaChi.Location = new System.Drawing.Point(381, 66);
            this.txt_diaChi.MaxLength = 100;
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(521, 25);
            this.txt_diaChi.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Địa chỉ";
            // 
            // txt_tenKho
            // 
            this.txt_tenKho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tenKho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tenKho.Location = new System.Drawing.Point(381, 28);
            this.txt_tenKho.MaxLength = 30;
            this.txt_tenKho.Name = "txt_tenKho";
            this.txt_tenKho.Size = new System.Drawing.Size(521, 25);
            this.txt_tenKho.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên kho";
            // 
            // txt_maKho
            // 
            this.txt_maKho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_maKho.Location = new System.Drawing.Point(68, 28);
            this.txt_maKho.MaxLength = 3;
            this.txt_maKho.Name = "txt_maKho";
            this.txt_maKho.ReadOnly = true;
            this.txt_maKho.Size = new System.Drawing.Size(234, 25);
            this.txt_maKho.TabIndex = 2;
            // 
            // txt_thuKho
            // 
            this.txt_thuKho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_thuKho.Location = new System.Drawing.Point(68, 66);
            this.txt_thuKho.MaxLength = 30;
            this.txt_thuKho.Name = "txt_thuKho";
            this.txt_thuKho.Size = new System.Drawing.Size(234, 25);
            this.txt_thuKho.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Thủ kho";
            // 
            // dgv_kho
            // 
            this.dgv_kho.AllowUserToAddRows = false;
            this.dgv_kho.AllowUserToDeleteRows = false;
            this.dgv_kho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_kho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKho,
            this.TenKho,
            this.ThuKho,
            this.DiaChi});
            this.dgv_kho.Location = new System.Drawing.Point(6, 24);
            this.dgv_kho.Name = "dgv_kho";
            this.dgv_kho.ReadOnly = true;
            this.dgv_kho.RowHeadersWidth = 51;
            this.dgv_kho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_kho.Size = new System.Drawing.Size(909, 322);
            this.dgv_kho.TabIndex = 4;
            this.dgv_kho.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_kho_RowEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgv_kho);
            this.groupBox2.Location = new System.Drawing.Point(12, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(921, 352);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin các kho";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "SỬA KHO";
            // 
            // MaKho
            // 
            this.MaKho.DataPropertyName = "MaKho";
            this.MaKho.HeaderText = "Mã kho";
            this.MaKho.MinimumWidth = 6;
            this.MaKho.Name = "MaKho";
            this.MaKho.ReadOnly = true;
            // 
            // TenKho
            // 
            this.TenKho.DataPropertyName = "TenKho";
            this.TenKho.HeaderText = "Tên kho";
            this.TenKho.Name = "TenKho";
            this.TenKho.ReadOnly = true;
            this.TenKho.Width = 200;
            // 
            // ThuKho
            // 
            this.ThuKho.DataPropertyName = "ThuKho";
            this.ThuKho.HeaderText = "Thủ kho";
            this.ThuKho.MinimumWidth = 6;
            this.ThuKho.Name = "ThuKho";
            this.ThuKho.ReadOnly = true;
            this.ThuKho.Width = 200;
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // FrmSuaKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.but_luu);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSuaKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SỬA KHO";
            ((System.ComponentModel.ISupportInitialize)(this.errorMess)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kho)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel labMes;
        private System.Windows.Forms.ErrorProvider errorMess;
        private System.Windows.Forms.Button but_luu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tenKho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_maKho;
        private System.Windows.Forms.TextBox txt_thuKho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_kho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThuKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
    }
}