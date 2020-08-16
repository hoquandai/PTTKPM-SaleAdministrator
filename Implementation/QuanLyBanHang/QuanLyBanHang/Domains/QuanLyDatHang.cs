using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Windows.Forms;

namespace QuanLyBanHang.Domains
{
    /// <summary>
    /// Domain layer for feature "QuanLyDatHang"
    /// </summary>
    public class QuanLyDatHangDomain
    {
        public List<Models.Item> listSanPham = new List<Models.Item>();

        /// <summary>
        /// Constructor
        /// </summary>
        public QuanLyDatHangDomain()
        {

        }

        /// <summary>
        /// Load data of SanPham from Database
        /// </summary>
        public void LoadSanPham(Repository.Repository repository)
        {
            this.listSanPham = new List<Models.Item>();

            string queryString = "select * from Item where isDeleted = false";
            repository.cmd.CommandText = queryString;

            using (DbDataReader reader = repository.cmd.ExecuteReader())
            {
                if (!reader.HasRows)
                {
                    MessageBox.Show(
                        "Data chưa có dữ liệu",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    while (reader.Read())
                    {
                        Models.Item temp = new Models.Item(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetInt64(3),
                            reader.GetInt64(4),
                            reader.GetString(5),
                            reader.GetBoolean(6));
                        this.listSanPham.Add(temp);
                    }

                }
            }
        }


        public Models.Item GetItemByID(Repository.Repository repository, int id)
        {
            string queryString = "select* from Item where id=" + id;
            repository.cmd.CommandText = queryString;

            using (DbDataReader reader = repository.cmd.ExecuteReader())
            {
                if (!reader.HasRows)
                {
                    return new Models.Item();
                }
                else
                {
                    Models.Item temp = new Models.Item();
                    while (reader.Read())
                    {
                        temp = new Models.Item(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetInt64(3),
                            reader.GetInt64(4),
                            reader.GetString(5),
                            reader.GetBoolean(6));
                        break;
                    }
                    return temp;
                }
            }
        }

        /// <summary>
        /// Add new Bill to Database
        /// </summary>
        /// <param name="sp"></param>
        public void AddBill(Repository.Repository repository, Models.Bill bill)
        {
            string queryString = "insert into Bill(saler_name, customer_id) " +
                "values('" + bill.salerName +
                "', '" + bill.customerID + ")";
            repository.cmd.CommandText = queryString;
            try
            {
                repository.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Có lỗi xảy ra trong quá trình thêm dữ liệu, vui lòng thử lại!\nChi tiết: " + ex.StackTrace,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            queryString = "select * from Bill order by id desc limit 1";
            repository.cmd.CommandText = queryString;
            using (DbDataReader reader = repository.cmd.ExecuteReader())
            {
                if (!reader.HasRows)
                {
                    MessageBox.Show(
                        "Data chưa có dữ liệu",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    while (reader.Read())
                    {
                        Models.Bill temp = new Models.Bill(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetInt32(2),
                            this.listSanPham
                            );
                        foreach (Models.Item sp in this.listSanPham)
                        {
                            string q = "insert into CT_DH_SP(bill_id, product_id, amount, is_error) " +
                                "values('" + temp.ID +
                                "', '" + sp.ID +
                                "', '" + 1 +
                                "', '" + false+ ")";

                            repository.cmd.CommandText = q;
                            try
                            {
                                repository.cmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(
                                    "Có lỗi xảy ra trong quá trình thêm dữ liệu, vui lòng thử lại!\nChi tiết: " + ex.StackTrace,
                                    "Lỗi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Build string id from list SanPham
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string BuildListIDString(List<Models.Item> data)
        {
            string temp = "";
            for (int i = 0; i < data.Count; i++)
            {
                temp += data[i].ID + " ";
            }
            return temp;
        }
    }
}
