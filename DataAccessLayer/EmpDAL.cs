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
    public class EmpDAL
    {
        dbcon db = new dbcon();

        public bool insertEmpDAL(EmpProps p)
        {
            string query = "INSERT INTO employee VALUES('" + p.E_id + "','" + p.E_name + "','" + p.E_cell + "','" + p.E_address + "','" + p.E_email + "','" + p.E_password + "')";
            return db.query_iud(query);
        }

        public bool deleteEmpDAL(EmpProps p)
        {
            string query = "delete from employee where emp_id ='" + p.E_id + "'";
            return db.query_iud(query);
        }

        public bool updateEmpDAL(EmpProps p)
        {
            string query = "update employee set name = '" + p.E_name + "',cell = '" + p.E_cell + "',address = '" + p.E_address + "', email = '" + p.E_email + "', password = '" + p.E_password + "' where emp_id = '" + p.E_id + "'; ";
            return db.query_iud(query);
        }

        public DataTable searchEmpDAL(EmpProps p)
        {
            string query = "select * from employee where emp_id ='" + p.E_id + "'";
            return db.search(query);
        }

        public DataTable AllEmpDAL()
        {
            string query = "select * from employee ";
            return db.search(query);
        }
    }

}
