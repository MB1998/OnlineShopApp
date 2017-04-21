using System;
using System.Collections.Generic;
using System.Text;

namespace SalesDatabaseProject
{
    class ProductFamily
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public static ProductFamily GetProductFamily(string columnName, string value) {
            var sqlQuery = "SELECT * FROM Customer WHERE " + columnName + " = '" + value + "' LIMIT 1;";
            ProductFamily record = new ProductFamily();
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
