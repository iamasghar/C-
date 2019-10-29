using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PropsLayer;

namespace DataAccessLayer
{
    public class UserDAL
    {
        dbcon db = new dbcon();

        public bool insertUserDAL(UserProps p)
        {
            string query = string.Format("INSERT INTO users VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", p.U_id, p.U_name, p.U_email, p.U_cell, p.U_cnic, p.U_password, p.U_address, p.U_access_level);
            return db.query_iud(query);
        }

        public bool deleteUserDAL(UserProps p)
        {
            string query = string.Format("delete from users where u_id ='{0}'", p.U_id);
            return db.query_iud(query);
        }

        public bool updateUserDAL(UserProps p)
        {
            string query = string.Format("update users set name = '{0}',cnic = '{1}',cell = '{2}',address = '{3}',email = '{4}',password = '{5}',access_level = '{6}' where u_id = '{7}'; ", p.U_name, p.U_cnic, p.U_cell, p.U_email, p.U_password, p.U_address, p.U_access_level, p.U_id);
            return db.query_iud(query);
        }

        public bool updateUPassDAL(UserProps p)
        {
            string query = string.Format("update users set password = '{0}' where u_id = '{1}'; ", p.U_password, p.U_id);
            return db.query_iud(query);
        }

        public DataTable searchUserDAL(UserProps p)
        {
            string query = string.Format("select * from users where u_id ='{0}'", p.U_id);
            return db.search(query);
        }

        public DataTable ALevelUserDAL(UserProps p)
        {
            string query = string.Format("select * from users where access_level ='{0}'", p.U_access_level);
            return db.search(query);
        }

        public DataTable AllUserDAL()
        {
            string query = "select * from user";
            return db.search(query);
        }

        public DataTable LoginUserDAL(UserProps p)
        {
            string query = string.Format("select * from users where email = '{0}' and password = '{1}'", p.U_email, p.U_password);
            return db.search(query);
        }
    }
}
