using System;
using System.Collections.Generic;
using System.Text;

namespace SalesDatabaseProject
{
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthdayDate { get; set; }
        public DateTime RegistrationDate { get; set; }

        public static Customer GetCustomer(string columnName, string value) {
            var sqlQuery = "SELECT * FROM Customer WHERE " + columnName + " = '" + value + "' LIMIT 1;";
            Customer record = new Customer();
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
