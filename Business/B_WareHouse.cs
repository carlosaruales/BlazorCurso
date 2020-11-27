using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_WareHouse : ICrud<WareHouseEntity>
    {
        public void CreateEntity(WareHouseEntity Item)
        {
            using var db = new InventaryContext();
            db.WareHouses.Add(Item);
            db.SaveChanges();
        }

        public List<WareHouseEntity> ItemList()
        {
            using var db = new InventaryContext();
            return db.WareHouses.ToList();
        }

        public void UpdateItem(WareHouseEntity Item)
        {
            using var db = new InventaryContext();
            db.WareHouses.Update(Item);
            db.SaveChanges();
        }
    }
}
