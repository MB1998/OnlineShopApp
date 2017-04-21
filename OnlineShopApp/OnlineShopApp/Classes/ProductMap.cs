using FluentNHibernate.Mapping;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace SalesDatabaseProject 
{
    class ProductMap : ClassMap<Product>
    {
        public ProductMap() {
            Table("Product");
            Map(x => x.Id).Column("Id");
            Map(x => x.Title).Column("Title");
            Map(x => x.Description).Column("Description");
            Map(x => x.Price).Column("Price");
            Map(x => x.Brand).Column("Brand");
            Map(x => x.Model).Column("Model");
            Map(x => x.QuantityInStock).Column("QuantityInStock");
            Map(x => x.Rating).Column("Rating");
            Map(x => x.ProductFamilyId).Column("ProductFamilyId");
        }
    }
}
