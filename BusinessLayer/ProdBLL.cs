using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropsLayer;
using DataAccessLayer;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLayer
{
    public class ProdBLL
    {
        public bool insertProdBLL(ProdProps p)
        {
            ProdDAL obj = new ProdDAL();
            return obj.insertProdDAL(p);
        }

        public bool deleteProdBLL(ProdProps p)
        {
            ProdDAL obj = new ProdDAL();
            return obj.deleteProdDAL(p);
        }

        public bool updateProdBLL(ProdProps p)
        {
            ProdDAL obj = new ProdDAL();
            return obj.updateProdDAL(p);
        }

        public bool updatePImgBLL(ProdProps p)
        {
            ProdDAL obj = new ProdDAL();
            return obj.updatePImgDAL(p);
        }
        public DataTable AllProdBLL()
        {
            ProdDAL obj = new ProdDAL();
            return obj.allProdDAL();
        }

        public DataTable searchProdBLL(ProdProps p)
        {
            ProdDAL obj = new ProdDAL();
            return obj.searchProdDAL(p);
        }

    }
}
