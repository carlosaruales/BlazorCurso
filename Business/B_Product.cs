using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Product : ICrud<ProductEntity>
    {
        public void CreateEntity(ProductEntity Item)
        {
            using var db = new InventaryContext();
            db.Products.Add(Item);
            db.SaveChanges();
        }

        public List<ProductEntity> ItemList()
        {
            using var db = new InventaryContext();
            return db.Products.ToList();
        }

        public void UpdateItem(ProductEntity Item)
        {
            using var db = new InventaryContext();
            db.Products.Update(Item);
            db.SaveChanges();
        }
    }
}
