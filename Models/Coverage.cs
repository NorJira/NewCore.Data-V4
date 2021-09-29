using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NewCore.Data.Models
{
    public partial class Coverage
    {
        [Key]
        public int CvgRef { get; set; }
        [Required]
        [StringLength(15)]
        public string PolId { get; set; }
        [Required]
        [StringLength(3)]
        public string CvgNo { get; set; }
        [Required]
        [StringLength(5)]
        public string CvgStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CvgCommDt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CvgExpryDate { get; set; }
        [Required]
        [StringLength(15)]
        public string CustomerId { get; set; }
        [Required]
        [StringLength(15)]
        public string PlanId { get; set; }
        [Column(TypeName = "decimal(14, 2)")]
        public decimal CvgFaceAmt { get; set; }
        [Column(TypeName = "decimal(14, 2)")]
        public decimal CvgPremAmt { get; set; }
    }
}
