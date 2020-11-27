using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using System.Linq;

namespace Business
{
    public class B_Category: ICrud<CategoryEntity>
    {
        public void CreateEntity(CategoryEntity Item)
        {
            using var db = new InventaryContext();
            db.Categories.Add(Item);
            db.SaveChanges();
        }

        public List<CategoryEntity> ItemList()
        {
            using var db = new InventaryContext();
            return db.Categories.ToList();
        }

        public void UpdateItem(CategoryEntity Item)
        {
            using var db = new InventaryContext();
            db.Categories.Update(Item);
            db.SaveChanges();
        }
    }
}
