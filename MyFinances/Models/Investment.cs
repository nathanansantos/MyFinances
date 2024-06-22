using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace MyFinances.Models
{
    public class Investment
    {
        [Key]
        public int ItemId { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Investment")]
        public string ItemName { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Value { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime InvestmentDate { get; set; } = DateTime.Now;

        [Required]
        [StringLength(100)]
        public string Category { get; set; }

    }
}
