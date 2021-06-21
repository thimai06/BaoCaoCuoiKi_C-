using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelEF.Model;
using PagedList;
using ModelEF.DAO;
namespace ModelEF.DAO
{
    public class UserDAO
    {
        private NguyenThiMaiContext db;

        public UserDAO()
        {
            db = new NguyenThiMaiContext();
        }

        public List<TaiKhoanNguoiDung> ListAll()
        {
            return db.TaiKhoanNguoiDungs.ToList();
        }
       
        public bool Detele(String id)
        {
         
            try
            {
                var user = db.TaiKhoanNguoiDungs.Find(id);
                if (user.Trangthai == "block")
                {
                    db.TaiKhoanNguoiDungs.Remove(user);
                    db.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex) { return false; }
        }
        public IEnumerable<TaiKhoanNguoiDung> LisWheretAll(string keysearch, int page, int pagesize)
        {
            IQueryable<TaiKhoanNguoiDung> model = db.TaiKhoanNguoiDungs;
            if (!string.IsNullOrEmpty(keysearch))
            {
                model = model.Where(x => x.Ten.Contains(keysearch));
            }
            return model.OrderBy(x => x.Ten).ToPagedList(page, pagesize);
        }
        public List<TaiKhoanNguoiDung> ListWhereAll(String keysearch)
        {
            return db.TaiKhoanNguoiDungs.Where(x => x.Ten.Contains(keysearch)).ToList();
        }
        public LoaiSP Find(string ma)
        {
            return db.LoaiSPs.Find(ma);
        }
        

        
        public int login(string user, string pass)
        {
            var result = db.TaiKhoanNguoiDungs.SingleOrDefault(x => x.Ma.Equals(user) && x.MatKhau.Equals(pass));
            if (result == null)
            {
                return 0;
            }
            else
            {
                return 1;
            }

        }
    }
}
