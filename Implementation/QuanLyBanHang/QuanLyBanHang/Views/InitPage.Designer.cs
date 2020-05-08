﻿namespace QuanLyBanHang
{
    partial class InitPage
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Bo mạch chủ",
            "Linh kiện điện tử",
            "15",
            "10"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "08/05/2020",
            "Tổng giám đốc"}, -1);
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSanPham = new System.Windows.Forms.TabPage();
            this.tabComment = new System.Windows.Forms.TabPage();
            this.tabQuangCao = new System.Windows.Forms.TabPage();
            this.tabDatHang = new System.Windows.Forms.TabPage();
            this.tabThanhToan = new System.Windows.Forms.TabPage();
            this.btnLogin = new System.Windows.Forms.Button();
            this.listSanPham = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMinNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listComment = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.colCommentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCommentSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCommentOwner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCommentStat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCommentDetail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCommentSubmit = new System.Windows.Forms.Button();
            this.btnCommentSave = new System.Windows.Forms.Button();
            this.btnCommentViewClassify = new System.Windows.Forms.Button();
            this.btnCommentViewStatistic = new System.Windows.Forms.Button();
            this.listCommentRep = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.colCommentRepDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCommentRepOwner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl.SuspendLayout();
            this.tabSanPham.SuspendLayout();
            this.tabComment.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quan Ly ban hang v1.0";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1111, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Location = new System.Drawing.Point(1080, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 23);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabSanPham);
            this.tabControl.Controls.Add(this.tabComment);
            this.tabControl.Controls.Add(this.tabQuangCao);
            this.tabControl.Controls.Add(this.tabDatHang);
            this.tabControl.Controls.Add(this.tabThanhToan);
            this.tabControl.Location = new System.Drawing.Point(12, 39);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1126, 583);
            this.tabControl.TabIndex = 3;
            // 
            // tabSanPham
            // 
            this.tabSanPham.Controls.Add(this.panel1);
            this.tabSanPham.Controls.Add(this.listSanPham);
            this.tabSanPham.Location = new System.Drawing.Point(4, 22);
            this.tabSanPham.Name = "tabSanPham";
            this.tabSanPham.Padding = new System.Windows.Forms.Padding(3);
            this.tabSanPham.Size = new System.Drawing.Size(1118, 557);
            this.tabSanPham.TabIndex = 0;
            this.tabSanPham.Text = "SAN PHAM";
            this.tabSanPham.UseVisualStyleBackColor = true;
            // 
            // tabComment
            // 
            this.tabComment.Controls.Add(this.label2);
            this.tabComment.Controls.Add(this.listCommentRep);
            this.tabComment.Controls.Add(this.panel2);
            this.tabComment.Controls.Add(this.listComment);
            this.tabComment.Location = new System.Drawing.Point(4, 22);
            this.tabComment.Name = "tabComment";
            this.tabComment.Padding = new System.Windows.Forms.Padding(3);
            this.tabComment.Size = new System.Drawing.Size(1118, 557);
            this.tabComment.TabIndex = 1;
            this.tabComment.Text = "COMMENT";
            this.tabComment.UseVisualStyleBackColor = true;
            // 
            // tabQuangCao
            // 
            this.tabQuangCao.Location = new System.Drawing.Point(4, 22);
            this.tabQuangCao.Name = "tabQuangCao";
            this.tabQuangCao.Size = new System.Drawing.Size(1118, 557);
            this.tabQuangCao.TabIndex = 2;
            this.tabQuangCao.Text = "QUANG CAO";
            this.tabQuangCao.UseVisualStyleBackColor = true;
            // 
            // tabDatHang
            // 
            this.tabDatHang.Location = new System.Drawing.Point(4, 22);
            this.tabDatHang.Name = "tabDatHang";
            this.tabDatHang.Size = new System.Drawing.Size(1118, 557);
            this.tabDatHang.TabIndex = 3;
            this.tabDatHang.Text = "DAT HANG";
            this.tabDatHang.UseVisualStyleBackColor = true;
            // 
            // tabThanhToan
            // 
            this.tabThanhToan.Location = new System.Drawing.Point(4, 22);
            this.tabThanhToan.Name = "tabThanhToan";
            this.tabThanhToan.Size = new System.Drawing.Size(1118, 557);
            this.tabThanhToan.TabIndex = 4;
            this.tabThanhToan.Text = "THANH TOAN";
            this.tabThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(850, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(224, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // listSanPham
            // 
            this.listSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colName,
            this.colType,
            this.colNum,
            this.colMinNum});
            this.listSanPham.FullRowSelect = true;
            this.listSanPham.HideSelection = false;
            this.listSanPham.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listSanPham.Location = new System.Drawing.Point(6, 6);
            this.listSanPham.Name = "listSanPham";
            this.listSanPham.Size = new System.Drawing.Size(836, 545);
            this.listSanPham.TabIndex = 0;
            this.listSanPham.UseCompatibleStateImageBehavior = false;
            this.listSanPham.View = System.Windows.Forms.View.Details;
            this.listSanPham.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ListSanPham_ColumnWidthChanging);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(849, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 544);
            this.panel1.TabIndex = 1;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            // 
            // colName
            // 
            this.colName.Text = "Tên mặt hàng";
            // 
            // colType
            // 
            this.colType.Text = "Loại hàng";
            // 
            // colNum
            // 
            this.colNum.Text = "Số lượng còn lại";
            // 
            // colMinNum
            // 
            this.colMinNum.Text = "Số lượng quy định";
            // 
            // listComment
            // 
            this.listComment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCommentID,
            this.colCommentSP,
            this.colCommentOwner,
            this.colCommentStat,
            this.colCommentDetail});
            this.listComment.FullRowSelect = true;
            this.listComment.HideSelection = false;
            this.listComment.Location = new System.Drawing.Point(7, 7);
            this.listComment.Name = "listComment";
            this.listComment.Size = new System.Drawing.Size(886, 550);
            this.listComment.TabIndex = 0;
            this.listComment.UseCompatibleStateImageBehavior = false;
            this.listComment.View = System.Windows.Forms.View.Details;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCommentViewStatistic);
            this.panel2.Controls.Add(this.btnCommentViewClassify);
            this.panel2.Controls.Add(this.btnCommentSave);
            this.panel2.Controls.Add(this.btnCommentSubmit);
            this.panel2.Location = new System.Drawing.Point(900, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 269);
            this.panel2.TabIndex = 1;
            // 
            // colCommentID
            // 
            this.colCommentID.Text = "ID";
            // 
            // colCommentSP
            // 
            this.colCommentSP.Text = "Sản phẩm";
            // 
            // colCommentOwner
            // 
            this.colCommentOwner.Text = "Tên khách hàng";
            // 
            // colCommentStat
            // 
            this.colCommentStat.Text = "Trạng thái";
            // 
            // colCommentDetail
            // 
            this.colCommentDetail.Text = "Chi tiết";
            // 
            // btnCommentSubmit
            // 
            this.btnCommentSubmit.Location = new System.Drawing.Point(3, 201);
            this.btnCommentSubmit.Name = "btnCommentSubmit";
            this.btnCommentSubmit.Size = new System.Drawing.Size(204, 60);
            this.btnCommentSubmit.TabIndex = 0;
            this.btnCommentSubmit.Text = "Lập bản thống kê";
            this.btnCommentSubmit.UseVisualStyleBackColor = true;
            // 
            // btnCommentSave
            // 
            this.btnCommentSave.Location = new System.Drawing.Point(3, 135);
            this.btnCommentSave.Name = "btnCommentSave";
            this.btnCommentSave.Size = new System.Drawing.Size(204, 60);
            this.btnCommentSave.TabIndex = 1;
            this.btnCommentSave.Text = "Xác nhận lưu phân loại";
            this.btnCommentSave.UseVisualStyleBackColor = true;
            // 
            // btnCommentViewClassify
            // 
            this.btnCommentViewClassify.Location = new System.Drawing.Point(3, 69);
            this.btnCommentViewClassify.Name = "btnCommentViewClassify";
            this.btnCommentViewClassify.Size = new System.Drawing.Size(204, 60);
            this.btnCommentViewClassify.TabIndex = 2;
            this.btnCommentViewClassify.Text = "Xem phân loại đã lưu";
            this.btnCommentViewClassify.UseVisualStyleBackColor = true;
            // 
            // btnCommentViewStatistic
            // 
            this.btnCommentViewStatistic.Location = new System.Drawing.Point(3, 3);
            this.btnCommentViewStatistic.Name = "btnCommentViewStatistic";
            this.btnCommentViewStatistic.Size = new System.Drawing.Size(204, 60);
            this.btnCommentViewStatistic.TabIndex = 3;
            this.btnCommentViewStatistic.Text = "Xem thống kê đã lưu";
            this.btnCommentViewStatistic.UseVisualStyleBackColor = true;
            // 
            // listCommentRep
            // 
            this.listCommentRep.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCommentRepDate,
            this.colCommentRepOwner});
            this.listCommentRep.FullRowSelect = true;
            this.listCommentRep.HideSelection = false;
            this.listCommentRep.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listCommentRep.Location = new System.Drawing.Point(900, 30);
            this.listCommentRep.Name = "listCommentRep";
            this.listCommentRep.Size = new System.Drawing.Size(208, 249);
            this.listCommentRep.TabIndex = 2;
            this.listCommentRep.UseCompatibleStateImageBehavior = false;
            this.listCommentRep.View = System.Windows.Forms.View.Details;
            this.listCommentRep.SelectedIndexChanged += new System.EventHandler(this.ListCommentRep_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(900, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Báo cáo phân loại";
            // 
            // colCommentRepDate
            // 
            this.colCommentRepDate.Text = "Ngày";
            // 
            // colCommentRepOwner
            // 
            this.colCommentRepOwner.Text = "Người gửi";
            // 
            // InitPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 634);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InitPage";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabSanPham.ResumeLayout(false);
            this.tabComment.ResumeLayout(false);
            this.tabComment.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSanPham;
        private System.Windows.Forms.TabPage tabComment;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TabPage tabQuangCao;
        private System.Windows.Forms.TabPage tabDatHang;
        private System.Windows.Forms.TabPage tabThanhToan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listSanPham;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colNum;
        private System.Windows.Forms.ColumnHeader colMinNum;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listComment;
        private System.Windows.Forms.ColumnHeader colCommentID;
        private System.Windows.Forms.ColumnHeader colCommentSP;
        private System.Windows.Forms.ColumnHeader colCommentOwner;
        private System.Windows.Forms.ColumnHeader colCommentStat;
        private System.Windows.Forms.ColumnHeader colCommentDetail;
        private System.Windows.Forms.Button btnCommentSave;
        private System.Windows.Forms.Button btnCommentSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listCommentRep;
        private System.Windows.Forms.ColumnHeader colCommentRepDate;
        private System.Windows.Forms.ColumnHeader colCommentRepOwner;
        private System.Windows.Forms.Button btnCommentViewStatistic;
        private System.Windows.Forms.Button btnCommentViewClassify;
    }
}

