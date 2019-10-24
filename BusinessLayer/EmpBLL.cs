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
    public class EmpBLL
    {
        public bool insertEmpBLL(EmpProps p)
        {
            EmpDAL obj = new EmpDAL();
            return obj.insertEmpDAL(p);
        }

        public bool deleteEmpBLL(EmpProps p)
        {
            EmpDAL obj = new EmpDAL();
            return obj.deleteEmpDAL(p);
        }

        public bool updateEmpBLL(EmpProps p)
        {
            EmpDAL obj = new EmpDAL();
            return obj.updateEmpDAL(p);
        }

        public DataTable searchEmpBLL(EmpProps p)
        {
            EmpDAL obj = new EmpDAL();
            return obj.searchEmpDAL(p);
        }

        public DataTable AllEmpBLL()
        {
            EmpDAL obj = new EmpDAL();
            return obj.AllEmpDAL();
        }
    }

}
