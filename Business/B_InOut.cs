using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Business
{
    public class B_InOut : ICrud<InOutEntity>
    {
        public void CreateEntity(InOutEntity Item)
        {
            using var db = new InventaryContext();
            db.InOuts.Add(Item);
            db.SaveChanges();
        }

        public List<InOutEntity> ItemList()
        {
            using var db = new InventaryContext();
            return db.InOuts.ToList();
        }

        public void UpdateItem(InOutEntity Item)
        {
            using var db = new InventaryContext();
            db.InOuts.Update(Item);
            db.SaveChanges();
        }
    }
}
