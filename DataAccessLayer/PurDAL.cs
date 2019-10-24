using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropsLayer;

namespace DataAccessLayer
{
    public class PurDAL
    {

        dbcon db = new dbcon();
        public DataTable getProdDAL(ProdProps p)
        {
            string query = "select * from products where Prd_title ='" + p.Prd_title + "'";
            return db.search(query);
        }

        public DataTable getPurDAL()
        {
            string query = "select * from purchases";
            return db.search(query);
        }

        public bool PurcDAL(PurProps s)
        {
            bool check = false;
            String query1 = "update products set prd_stock = prd_stock+" + Convert.ToInt32(s.P_quantity) +" where prd_title = '"+s.P_title+"';";
            if(db.query_iud(query1))
            {
                String query2 = "insert into purchases values ('"+s.Trx_id+"','"+s.P_title+"','"+s.P_price+"','"+s.P_quantity+"','"+s.P_date+"','"+s.P_pur_by+ "','" + s.P_supplyer + "'); ";
                if (db.query_iud(query2))
                    {
                        check = true;
                    }
                    else
                    {
                        check = false;
                    }
            }
            else
            {
                check = false;
            }
            return check;
        }
    }
}
