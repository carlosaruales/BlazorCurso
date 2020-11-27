using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class InOutEntity
    {
        [Key]
        [StringLength(50)]
        public string InOutId { get; set; }

        [Required]
        public int InOutDate { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public int IsInput { get; set; }

        public string StorageId { get; set; }

        public StorageEntity Storage { get; set; }
    }
}
