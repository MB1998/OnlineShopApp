using FluentNHibernate.Mapping;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace SalesDatabaseProject
{
    class OrderMap : ClassMap<Order> 
    {
        public OrderMap() {
            Table("Order");
            Map(x => x.Id).Column("Id");
            Map(x => x.CustomerId).Column("CustomerId");
        }
    }
}
