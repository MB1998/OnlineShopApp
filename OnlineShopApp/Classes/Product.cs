using System;
using System.Collections.Generic;
using System.Text;

namespace SalesDatabaseProject
{
    class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int QuantityInStock { get; set; }
        public float Rating { get; set; }
        public int ProductFamilyId { get; set; }
        public ProductFamily Family { get; set; }

        public static Product GetProduct(string columnName, string value) {
            var sqlQuery = "SELECT * FROM Customer WHERE " + columnName + " = '" + value + "' LIMIT 1;";
            Product record = new Product();
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
