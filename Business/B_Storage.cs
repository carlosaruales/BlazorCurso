using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Storage : ICrud<StorageEntity>
    {
        public void CreateEntity(StorageEntity Item)
        {
            using var db = new InventaryContext();
            db.Storages.Add(Item);
            db.SaveChanges();
        }

        public List<StorageEntity> ItemList()
        {
            using var db = new InventaryContext();
            return db.Storages.ToList();
        }

        public void UpdateItem(StorageEntity Item)
        {
            using var db = new InventaryContext();
            db.Storages.Update(Item);
            db.SaveChanges();
        }
    }
}
