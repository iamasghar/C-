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
    public class SupBLL
    {
        public bool insertSupBLL(SupProps p)
        {
            SupDAL obj = new SupDAL();
            return obj.insertSupDAL(p);
        }

        public bool deleteSupBLL(SupProps p)
        {
            SupDAL obj = new SupDAL();
            return obj.deleteSupDAL(p);
        }

        public bool updateSupBLL(SupProps p)
        {
            SupDAL obj = new SupDAL();
            return obj.updateSupDAL(p);
        }

        public DataTable AllSupBLL()
        {
            SupDAL obj = new SupDAL();
            return obj.AllSupDAL();
        }
        public DataTable searchSupBLL(SupProps p)
        {
            SupDAL obj = new SupDAL();
            return obj.searchSupDAL(p);
        }
    }
}
