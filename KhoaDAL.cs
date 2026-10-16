using Microsoft.EntityFrameworkCore;
using QuanLySV.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySV.DAL
{
    public class KhoaDAL
    {
        public List<Khoa> LayDanhSachKhoa()
        {
            using (var db = new QuanLySinhVienDbContext())
            {
                return db.Khoas
                    .AsNoTracking()
                    .OrderBy(k => k.TenKhoa)
                    .ToList();
            }
        }
    }
}
