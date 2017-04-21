using FluentNHibernate.Mapping;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace SalesDatabaseProject
{
    class OrderDetailMap : ClassMap<OrderDetail>
    {
        public OrderDetailMap() {
            Table("OrderDetail");
            Map(x => x.Id).Column("Id");
            Map(x => x.ProductId).Column("ProductId");
            Map(x => x.OrderId).Column("OrderId");
        }
    }
}
