using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi07_01
{
    internal class SinhVienDAO
    {
        QLSVDbContext db = new QLSVDbContext();
        //trả về danh sách
        public List<SinhVien> getList()
        {
            List<SinhVien> List = db.SinhViens.ToList();
            return List;
        }
        public SinhVien getRow(string masv)
        {
            SinhVien sinhvien = db.SinhViens.Where(tv => tv.MaSV == masv).First();
            return sinhvien;
        }
        public int getCount()
        {
            return db.SinhViens.Count();
        }

        public void Insert(SinhVien sv)
        {
            db.SinhViens.Add(sv);
            db.SaveChanges();
        }
        public void Update(SinhVien sv)
        {
            db.Entry(sv).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(SinhVien sv)
        {
            db.SinhViens.Remove(sv);
            db.SaveChanges();
        }
    }
}
