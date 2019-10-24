using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropsLayer;
using DataAccessLayer;

namespace BusinessLayer
{
    public class PurBLL
    {
        public DataTable getProdBLL(ProdProps p)
        {
            PurDAL obj = new PurDAL();
            return obj.getProdDAL(p);
        }

        public DataTable getPurBLL()
        {
            PurDAL obj = new PurDAL();
            return obj.getPurDAL();
        }

        public bool PurcBLL(PurProps p)
        {
            PurDAL obj = new PurDAL();
            return obj.PurcDAL(p);
        }
    }
}
