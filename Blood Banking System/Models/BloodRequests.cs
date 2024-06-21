using System;
using System.ComponentModel.DataAnnotations;

namespace BloodBankingSystem.Models
{
    public class BloodRequest
    {
        public int Id { get; set; }
        public required string RequestorName { get; set; }
        public required string BloodType { get; set; }
        public int Quantity { get; set; }
    }
}
