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
    public class SellBLL
    {
        public DataTable getProdBLL(ProdProps p)
        {
            SellDAL obj = new SellDAL();
            return obj.getProdDAL(p);
        }

        public DataTable getSellBLL()
        {
            SellDAL obj = new SellDAL();
            return obj.getSellDAL();
        }

        public bool sellBLL(SellProps p)
        {
            SellDAL obj = new SellDAL();
            return obj.sellDAL(p);
        }
    }
}
