﻿namespace QuanLyBanHang.Views
{
    partial class SanPhamImport
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbOrder = new System.Windows.Forms.ComboBox();
            this.listSanPham = new System.Windows.Forms.ListView();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbMinimum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập hàng";
            // 
            // cbOrder
            // 
            this.cbOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrder.FormattingEnabled = true;
            this.cbOrder.Location = new System.Drawing.Point(16, 33);
            this.cbOrder.Name = "cbOrder";
            this.cbOrder.Size = new System.Drawing.Size(505, 21);
            this.cbOrder.TabIndex = 1;
            // 
            // listSanPham
            // 
            this.listSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cbID,
            this.cbName,
            this.cbAmount,
            this.cbMinimum});
            this.listSanPham.HideSelection = false;
            this.listSanPham.Location = new System.Drawing.Point(16, 61);
            this.listSanPham.Name = "listSanPham";
            this.listSanPham.Size = new System.Drawing.Size(505, 317);
            this.listSanPham.TabIndex = 2;
            this.listSanPham.UseCompatibleStateImageBehavior = false;
            this.listSanPham.View = System.Windows.Forms.View.Details;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(13, 384);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(110, 54);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "Hoàn Thành";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(129, 384);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 54);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Huỷ đơn";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(411, 384);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 54);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // cbID
            // 
            this.cbID.Text = "ID";
            // 
            // cbName
            // 
            this.cbName.Text = "Tên sản phẩm";
            // 
            // cbAmount
            // 
            this.cbAmount.Text = "Số lượng";
            // 
            // cbMinimum
            // 
            this.cbMinimum.Text = "Số lượng quy định";
            // 
            // SanPhamImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.listSanPham);
            this.Controls.Add(this.cbOrder);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SanPhamImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SanPhamImport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOrder;
        private System.Windows.Forms.ListView listSanPham;
        private System.Windows.Forms.ColumnHeader cbID;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ColumnHeader cbName;
        private System.Windows.Forms.ColumnHeader cbAmount;
        private System.Windows.Forms.ColumnHeader cbMinimum;
    }
}