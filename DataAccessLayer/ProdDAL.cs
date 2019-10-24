using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropsLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class ProdDAL
    {
        dbcon db = new dbcon();
        public bool insertProdDAL(ProdProps p)
        {
            string query = "INSERT INTO products VALUES('" + p.Prd_id + "','" + p.Prd_title + "','" + p.Prd_price + "','" + p.Prd_stock + "','" + p.Prd_expiry + "','" + p.Prd_manufact + "','" + p.Prd_image + "')";
            return db.query_iud(query);
        }


        public bool deleteProdDAL(ProdProps p)
        {
            string query = "delete from products where Prd_id ='" + p.Prd_id + "'";
            return db.query_iud(query);
        }

        public bool updateProdDAL(ProdProps p)
        {
            string query = "update products set prd_title = '" + p.Prd_title + "',prd_price = '" + p.Prd_price + "',prd_stock = '" + p.Prd_stock + "',prd_manufacturer = '" + p.Prd_manufact + "',prd_expiry = '" + p.Prd_expiry + "' where Prd_id = '" + p.Prd_id + "'; ";
            return db.query_iud(query);
        }

        public bool updatePImgDAL(ProdProps p)
        {
            string query = string.Format("update products set img = '{0}' where Prd_id = '{1}'; ", p.Prd_image, p.Prd_id);
            return db.query_iud(query);
        }


        public DataTable allProdDAL()
        {
            string query = "select * from products";
            return db.search(query);
        }

        public DataTable searchProdDAL(ProdProps p)
        {
            string query = "select * from products where Prd_id ='" + p.Prd_id + "'";
            return db.search(query);
        }


    }
}
