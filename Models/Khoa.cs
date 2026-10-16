using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuanLySV.DAL.Models
{
    public class Khoa
    {
         [Key]
        public int KhoaId { get; set; }

        [Required]
        public string TenKhoa { get; set; } = string.Empty;

        // Một khoa có nhiều sinh viên
        public ICollection<SinhVien> SinhViens { get; set; }
            = new List<SinhVien>();
    }
}
