using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Buoi07_01
{
    internal class ThanhVienDAO
    {
        
        QLSVDbContext db = new QLSVDbContext();
        //trả về danh sách
        public List<ThanhVien> getList()
        {
            List<ThanhVien> List = db.ThanhViens.ToList();
            return List;
        }
        public ThanhVien getRow(string username)
        {
            ThanhVien User = db.ThanhViens.Where(tv => tv.TenDangNhap == username).First();
            return User;
        }
        //public ThanhVien getRow(int matv)
        //{
        //    ThanhVien User = db.ThanhViens.Where(tv => tv.TenDangNhap == username).First();
        //    return User;
        //}
        public int getCount()
        {
            return db.ThanhViens.Count();
        }
        
        public void Insert(ThanhVien tv)
        {
            db.ThanhViens.Add(tv);
            db.SaveChanges();
        }
        public void Update(ThanhVien tv)
        {
            db.Entry(tv).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(ThanhVien tv)
        {
            db.ThanhViens.Remove(tv);
            db.SaveChanges();
        }

       
    }
}
