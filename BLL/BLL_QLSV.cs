using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp5.DTO;

namespace WindowsFormsApp5.BLL
{
    public class BLL_QLSV
    {
        public delegate bool MyCompare(SV b1, SV b2);
        private static BLL_QLSV _Instance;
        public static BLL_QLSV Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLSV();
                }
                return _Instance;
            }
            private set { }
        }
        public BLL_QLSV()
        {

        }
        public List<SV> GetListSV_BLL()
        {
            return DAL_SV.Instance.GetListSV_DAL();
        }
        public List<LopSH> GetListLSH_BLL()
        {
            return DAL_SV.Instance.GetListLSH();
        }
        public SV GetSVbyID_BLL(string MSSV)
        {
            return DAL_SV.Instance.GetSVbyID(MSSV);
        }
        public List<SV> GetListSVbyID_BLL(int id)
        {
            return DAL_SV.Instance.GetListSVbyID(id);
        }
        public bool SaveSV_BLL(SV b)
        {
            return DAL_SV.Instance.SaveSV(b);
        }
        public void DelSVBLL(SV s)
        {
            DAL_SV.Instance.DelSV(s);
        }
        public List<SV> Search_BLL(string s)
        {
            return DAL_SV.Instance.Search(s);
        }
        public List<SV> SortMSSVUp_BLL()
        {
            return DAL_SV.Instance.SortMSSVUp();
        }
        public List<SV> SortMSSVDown_BLL()
        {
            return DAL_SV.Instance.SortMSSVDown();
        }
        public List<SV> SortNameUp_BLL()
        {
            return DAL_SV.Instance.SortNameUp();
        }
        public List<SV> SortNameDown_BLL()
        {
            return DAL_SV.Instance.SortNameDown();
        }
    }
}
