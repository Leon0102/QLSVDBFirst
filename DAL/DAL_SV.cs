using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5.DTO
{
    public class DAL_SV
    {
        private static DAL_SV _Instance;
        public static DAL_SV Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_SV();
                }
                return _Instance;
            }
            private set { }
        }
        private DAL_SV()
        {
        }
        QLSVEntities db = new QLSVEntities();
        public List<SV> GetListSV_DAL()
        {
            List<SV> lsv = new List<SV>();
                var l0 = from p in db.SVs
                         select p;
                lsv = l0.ToList();
                return lsv;
        }
        public List<LopSH> GetListLSH()
        {
            List<LopSH> lsh = new List<LopSH>();
            var b = db.LopSHes.Select(s => s);
            lsh = b.ToList();
            return lsh;
        }
        public SV GetSVbyID(string mssv)
        {
            SV s = db.SVs.Find(mssv);
            return s;
        }
        public List<SV> GetListSVbyID(int ID_Lop)
        {
            List<SV> dt = new List<SV>();
            var l1 = db.SVs.Select(p => p).Where(p => p.ID_Lop == ID_Lop);
            dt = l1.ToList();
            return dt;
        }
        public void DelSV(SV s)
        {
                SV del = db.SVs.Where(p => p.MSSV.Equals(s.MSSV)).Select(p=>p).SingleOrDefault();
                db.SVs.Remove(del);
                db.SaveChanges();
        }
        public bool SaveSV(SV s)
        {
            bool result = false;
            SV _s = db.SVs.Where(x => x.MSSV == s.MSSV).Select(x => x).SingleOrDefault();
            if (_s != null)
            {
                // UPDATE
                _s.NameSV = s.NameSV;
                _s.ID_Lop = s.ID_Lop;
                _s.NS = s.NS;
                _s.Gender = s.Gender;
            }
            else
            {
                // ADD
                db.SVs.Add(s);
            }
            db.SaveChanges();
            result = true;
            return result;
        }
        public List<SV> SortMSSVUp()
        {
            List<SV> lsv = new List<SV>();
            var l0 = from p in db.SVs
                     orderby p.MSSV ascending
                     select p;
            lsv = l0.ToList();
            return lsv;
        }
        public List<SV> SortMSSVDown()
        {
            List<SV> lsv = new List<SV>();
            var l0 = from p in db.SVs
                     orderby p.MSSV descending
                     select p;
            lsv = l0.ToList();
            return lsv;
        }
        public List<SV> SortNameUp()
        {
            List<SV> lsv = new List<SV>();
            var l0 = from p in db.SVs
                     orderby p.NameSV descending
                     select p;
            lsv = l0.ToList();
            return lsv;
        }
        public List<SV> SortNameDown()
        {
            List<SV> lsv = new List<SV>();
            var l0 = from p in db.SVs
                     orderby p.NameSV ascending
                     select p;
            lsv = l0.ToList();
            return lsv;
        }
        public List<SV> Search(string s)
        {
            var l = from p in db.SVs
                    where p.MSSV == s
                    select p;
            return l.ToList();
        }
        
    }
}
