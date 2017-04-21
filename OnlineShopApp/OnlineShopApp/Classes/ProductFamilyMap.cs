using FluentNHibernate.Mapping;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace SalesDatabaseProject
{
    class ProductFamilyMap : ClassMap<ProductFamily>
    {
        public ProductFamilyMap() {
            Table("ProductFamily");
            Map(x => x.Name).Column("Name");
            Map(x => x.Description).Column("Description");
        }
    }
}
