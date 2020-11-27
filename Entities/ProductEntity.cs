using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class ProductEntity
    {
        [Key]
        [StringLength(10)]
        public string ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }

        [StringLength(600)]
        public string ProductDescription { get; set; }


        public int TotalQuantity { get; set; }


        public string CategoryId { get; set; }

        public CategoryEntity CategoryEntity { get; set; }

        public ICollection<StorageEntity> StorageEntities { get; set; }
    }
}
