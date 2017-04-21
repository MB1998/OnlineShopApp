using System;
using System.Collections.Generic;
using System.Text;

namespace SalesDatabaseProject
{
    class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Buyer { get; set; }

        public static Order GetOrder(string columnName, string value) {
            var sqlQuery = "SELECT * FROM Customer WHERE " + columnName + " = '" + value + "' LIMIT 1;";
            Order record = new Order();
            return record;
        }

        public bool Create() {
            //var sql = "INSERT INTO Address VALUES ('" + Address1 + "', '" + Address2 + "');";
            // if create success then return true , else false;
            return true;
        }

        public bool Update() {
            //write code to update current address record
            // if update success then return true , else false;
            return true;
        }

        public bool Delete() {
            //write code to delete current address record
            // if delete success then return true , else false;
            return true;
        }
    }
}
