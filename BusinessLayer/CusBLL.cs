using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropsLayer;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLayer
{
    public class CusBLL
    {
        public bool insertCusBLL(CusProps p)
        {
            CusDAL obj = new CusDAL();
            return obj.insertCusDAL(p);
        }

        public bool deleteCusBLL(CusProps p)
        {
            CusDAL obj = new CusDAL();
            return obj.deleteCusDAL(p);
        }

        public bool updateCusBLL(CusProps p)
        {
            CusDAL obj = new CusDAL();
            return obj.updateCusDAL(p);
        }

        public DataTable searchCusBLL(CusProps p)
        {
            CusDAL obj = new CusDAL();
            return obj.searchCusDAL(p);
        }
        public DataTable AllCusBLL()
        {
            CusDAL obj = new CusDAL();
            return obj.AllCusDAL();
        }
    }
}
