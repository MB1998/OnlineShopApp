using FluentNHibernate.Mapping;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace SalesDatabaseProject
{
    class CustomerMap : ClassMap<Customer>
    {
        public CustomerMap() {
            Table("Customer");
            Map(x => x.Id).Column("Id");
            Map(x => x.FirstName).Column("FirstName");
            Map(x => x.LastName).Column("LastName");
            Map(x => x.Sex).Column("Sex");
            Map(x => x.Email).Column("Email");
            Map(x => x.PhoneNumber).Column("PhoneNumber");
            Map(x => x.BirthdayDate).Column("BirthdayDate");
            Map(x => x.RegistrationDate).Column("RegistrationDate");
        }
    }
}
