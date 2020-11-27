using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class StorageEntity
    {
        [Key]
        [StringLength(50)]
        public int StorageId { get; set; }

        [Required]
        public DateTime LastUpdate { get; set; }

        [Required]
        public int PartialQuantity { get; set; }

        public string ProductId { get; set; }

        public ProductEntity ProductEntity { get; set; }

        public string WareHouseId { get; set; }

        public WareHouseEntity WareHouseEntity { get; set; }

        public ICollection<InOutEntity> InOutEntity { get; set; }
    }
}
