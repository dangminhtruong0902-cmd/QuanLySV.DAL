using Microsoft.EntityFrameworkCore;
using QuanLySV.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySV.DAL
{
    public class SinhVienDAL
    {
        public List<SinhVien> LayDanhSachSinhVien()
        {
            using (var db = new QuanLySinhVienDbContext())
            {
                return db.SinhViens
                    .Include(sv => sv.Khoa)
                    .AsNoTracking()
                    .ToList();
            }
        }
    }
}
