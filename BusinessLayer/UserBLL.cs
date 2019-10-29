using PropsLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class UserBLL
    {
        public bool insertUserBLL(UserProps p)
        {
            UserDAL obj = new UserDAL();
            return obj.insertUserDAL(p);
        }

        public bool deleteUserBLL(UserProps p)
        {
            UserDAL obj = new UserDAL();
            return obj.deleteUserDAL(p);
        }

        public bool updateUserBLL(UserProps p)
        {
            UserDAL obj = new UserDAL();
            return obj.updateUserDAL(p);
        }

        public bool updateUPassBLL(UserProps p)
        {
            UserDAL obj = new UserDAL();
            return obj.updateUPassDAL(p);
        }

        public DataTable searchUserBLL(UserProps p)
        {
            UserDAL obj = new UserDAL();
            return obj.searchUserDAL(p);
        }
        public DataTable ALevelUserBLL(UserProps p)
        {
            UserDAL obj = new UserDAL();
            return obj.ALevelUserDAL(p);
        }
        public DataTable AllUserBLL()
        {
            UserDAL obj = new UserDAL();
            return obj.AllUserDAL();
        }

        public DataTable LoginUserBLL(UserProps p)
        {
            UserDAL obj = new UserDAL();
            return obj.LoginUserDAL(p);
        }
    }
}
