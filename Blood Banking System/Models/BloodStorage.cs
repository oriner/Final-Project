using System.ComponentModel.DataAnnotations;

namespace BloodBankingSystem.Models
{
    public class BloodStorage
    {
        [Key]
        public int BloodId { get; set; }

        // Other properties of BloodStorage
        public required string Type { get; set; }
        public int Quantity { get; set; }
    }
}
