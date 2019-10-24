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
    public class SupDAL
    {
        dbcon db = new dbcon();

        public bool insertSupDAL(SupProps p)
        {
            string query = "INSERT INTO supplyers VALUES('" + p.S_id + "','" + p.S_name + "','" + p.S_cell + "','" + p.S_address + "')";
            return db.query_iud(query);
        }

        public bool deleteSupDAL(SupProps p)
        {
            string query = "delete from supplyers where sup_id ='" + p.S_id + "'";
            return db.query_iud(query);
        }

        public bool updateSupDAL(SupProps p)
        {
            string query = "update supplyers set name = '" + p.S_name + "',cell = '" + p.S_cell + "',address = '" + p.S_address + "' where sup_id = '" + p.S_id + "'; ";
            return db.query_iud(query);
        }

        public DataTable searchSupDAL(SupProps p)
        {
            string query = "select * from supplyers where sup_id ='" + p.S_id + "'";
            return db.search(query);
        }

        public DataTable AllSupDAL()
        {
            string query = "select * from supplyers";
            return db.search(query);
        }
    }
}
