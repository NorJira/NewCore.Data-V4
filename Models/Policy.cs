using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NewCore.Data.Models
{
    [Table("Policy")]
    public partial class Policy
    {
        public int Id { get; set; }
        [Required]
        [StringLength(15)]
        public string PolId { get; set; }
        [Required]
        [StringLength(5)]
        public string PolStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime PolCommDt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime PolExpryDate { get; set; }
        [Key]
        public int CustomerId { get; set; }
        [Required]
        [StringLength(15)]
        public string PlanId { get; set; }
        [Column(TypeName = "decimal(14, 2)")]
        public decimal PolFaceAmt { get; set; }
        [Column(TypeName = "decimal(14, 2)")]
        public decimal PolPremAmt { get; set; }
    }
}
