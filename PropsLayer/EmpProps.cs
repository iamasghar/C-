using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropsLayer
{
    public class EmpProps
    {
        private String e_id;
        private String e_name;
        private String e_cell;
        private String e_address;
        private String e_email;
        private String e_password;

        public string E_id
        {
            get
            {
                return e_id;
            }

            set
            {
                e_id = value;
            }
        }

        public string E_name
        {
            get
            {
                return e_name;
            }

            set
            {
                e_name = value;
            }
        }

        public string E_cell
        {
            get
            {
                return e_cell;
            }

            set
            {
                e_cell = value;
            }
        }

        public string E_address
        {
            get
            {
                return e_address;
            }

            set
            {
                e_address = value;
            }
        }

        public string E_email
        {
            get
            {
                return e_email;
            }

            set
            {
                e_email = value;
            }
        }

        public string E_password
        {
            get
            {
                return e_password;
            }

            set
            {
                e_password = value;
            }
        }
    }
}
