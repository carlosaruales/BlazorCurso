using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class InventaryContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }

        public DbSet<CategoryEntity> Categories {get; set;}

        public DbSet<InOutEntity> InOuts { get; set; }

        public DbSet<WareHouseEntity> WareHouses { get; set; }

        public DbSet<StorageEntity> Storages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=LAPTOP-VBAR4VHV\\SQLEXPRESS; Database=InventoryDb; Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId= "ASH", CategoryName ="Aseo hogar"},
                new CategoryEntity { CategoryId = "HGR", CategoryName = "Hogar" },
                new CategoryEntity { CategoryId = "PRF", CategoryName = "Permufería" },
                new CategoryEntity { CategoryId = "VDJ", CategoryName = "Video juegos" }
            );

            modelBuilder.Entity<WareHouseEntity>().HasData(
                new WareHouseEntity { WareHouseId= Guid.NewGuid().ToString(), WareHouseName="Bodega central", WareHouseAddress ="Avenida siempre viva"},
                new WareHouseEntity { WareHouseId = Guid.NewGuid().ToString(), WareHouseName = "Bodega sur", WareHouseAddress = "Avenida siempre viva sur" },
                new WareHouseEntity { WareHouseId = Guid.NewGuid().ToString(), WareHouseName = "Bodega norte", WareHouseAddress = "Avenida siempre viva norte" }
            );
        }
    }
}
