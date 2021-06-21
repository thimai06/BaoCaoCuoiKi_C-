using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelEF.Model;
using PagedList;
namespace ModelEF.DAO
{
    public class SanPhamDAO
    {
        private NguyenThiMaiContext db;

        public SanPhamDAO()
        {
            db = new NguyenThiMaiContext();
        }
        public List<SanPham> ListAll()
        {
            var product = from s in db.SanPhams
                          orderby s.SoLuong ascending, s.DonGia descending
                          select s;
            return product.ToList();
        }
        public List<SanPham> ListNewProduct(int status)
        {
            return db.SanPhams.OrderByDescending(x => x.DonGia).Take(status).ToList();
        }
        
        public bool Detele(String id)
        {
            try
            {
                var user = db.SanPhams.Find(id);
                db.SanPhams.Remove(user);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex) { return false; }
        }
        public IEnumerable<SanPham> LisWheretAll(string keysearch, int page, int pagesize)
        {
            IQueryable<SanPham> model = db.SanPhams;
            if (!string.IsNullOrEmpty(keysearch))
            {
                model = model.Where(x => x.TenSP.Contains(keysearch));
            }
            return model.OrderBy(x => x.TenSP).ToPagedList(page, pagesize);
        }
        public List<SanPham> ListWhereAll(String keysearch)
        {
            return db.SanPhams.Where(x => x.TenSP.Contains(keysearch)).ToList();
        }
        public SanPham ViewDetail(String id)
        {
            return db.SanPhams.Find(id);
        }        
       
        public SanPham Find(string id)
        {
            return db.SanPhams.Find(id);
        }
    }
}
