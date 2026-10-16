using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuanLySV.DAL.Models
{
    public class SinhVien
    {
        [Key]
        [Required]
        public string MaSV { get; set; } = string.Empty;

        [Required]
        public string HoTen { get; set; } = string.Empty;

        public DateTime? NgaySinh { get; set; }

        public string? GioiTinh { get; set; }

        public int KhoaId { get; set; }

        public decimal DiemTB { get; set; }

        // Khoa mà sinh viên đang theo học
        public Khoa? Khoa { get; set; }
    }
}
