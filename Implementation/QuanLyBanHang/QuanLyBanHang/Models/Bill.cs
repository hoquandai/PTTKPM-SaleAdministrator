using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Models
{
    public class Bill
    {
        public int ID;
        public string salerName;
        public int customerID;
        public List<Item> listSP;

        /// <summary>
        /// Constructor with params
        /// </summary>
        /// <param name="id">The bill's ID</param>
        /// <param name="salerName">The bill's saler name</param>
        /// <param name="customerID">Customer of bill</param>
        public Bill(int id, string salerName, int customerID, List<Item> products)
        {
            this.ID = id;
            this.salerName = salerName;
            this.customerID = customerID;
            this.listSP = products;
        }
    }
}
