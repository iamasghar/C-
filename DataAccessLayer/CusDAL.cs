using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropsLayer;
using System.Data.SqlClient;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class CusDAL
    {
        dbcon db = new dbcon();

        public bool insertCusDAL(CusProps p)
        {
            string query = "INSERT INTO customer VALUES('" + p.C_id + "','" + p.C_name + "','" + p.C_cnic + "','" + p.C_cell + "','" + p.C_address + "')";
            return db.query_iud(query);
        }

        public bool deleteCusDAL(CusProps p)
        {
            string query = "delete from customer where cus_id ='" + p.C_id + "'";
            return db.query_iud(query);
        }

        public bool updateCusDAL(CusProps p)
        {
            string query = "update customer set name = '" + p.C_name + "',cnic = '" + p.C_cnic + "',cell = '" + p.C_cell + "',address = '" + p.C_address + "' where cus_id = '" + p.C_id + "'; ";
            return db.query_iud(query);
        }

        public DataTable searchCusDAL(CusProps p)
        {
            string query = "select * from customer where cus_id ='" + p.C_id + "'";
            return db.search(query);
        }

        public DataTable AllCusDAL()
        {
            string query = "select * from customer";
            return db.search(query);
        }
    }
}
