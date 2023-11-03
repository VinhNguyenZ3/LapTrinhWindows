using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi07_01
{
    internal class KhoaDAO
    {
        QLSVDbContext db = new QLSVDbContext();
        //trả về danh sách
        public List<Khoa> getList()
        {
            List<Khoa> List = db.Khoas.ToList();
            return List;
        }
        public Khoa getRow(int makh)
        {
            Khoa Khoa = db.Khoas.Where(khoa => khoa.MaKhoa == makh).First();
            return Khoa;
        }
        public int getCount()
        {
            return db.Khoas.Count();
        }

        public void Insert(Khoa kh)
        {
            db.Khoas.Add(kh);
            db.SaveChanges();
        }
        public void Update(Khoa kh)
        {
            db.Entry(kh).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(Khoa kh)
        {
            db.Khoas.Remove(kh);
            db.SaveChanges();
        }
    }
}
