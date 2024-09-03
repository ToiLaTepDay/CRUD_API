﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppWebApi.Models
{
    [Table("HangHoa")]
    public class HangHoa 
    {
        [Key]
        public Guid MaHangHoa  { get; set; }
        [Required]
        [MaxLength(255)]
        public string TenHangHoa { get; set; }
        public string MoTa {  get; set; }
        [Range(0, double.MaxValue)]
        public double DonGia { get; set; } 
    }
}
