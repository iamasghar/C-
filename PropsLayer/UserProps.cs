using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropsLayer
{
    public class UserProps
    {
        private String u_id;
        private String u_name;
        private String u_email;
        private String u_cnic;
        private String u_cell;
        private String u_password;
        private String u_address;
        private String u_access_level;

        public string U_id
        {
            get
            {
                return u_id;
            }

            set
            {
                u_id = value;
            }
        }

        public string U_name
        {
            get
            {
                return u_name;
            }

            set
            {
                u_name = value;
            }
        }

        public string U_email
        {
            get
            {
                return u_email;
            }

            set
            {
                u_email = value;
            }
        }

        public string U_cnic
        {
            get
            {
                return u_cnic;
            }

            set
            {
                u_cnic = value;
            }
        }

        public string U_cell
        {
            get
            {
                return u_cell;
            }

            set
            {
                u_cell = value;
            }
        }

        public string U_password
        {
            get
            {
                return u_password;
            }

            set
            {
                u_password = value;
            }
        }

        public string U_address
        {
            get
            {
                return u_address;
            }

            set
            {
                u_address = value;
            }
        }

        public string U_access_level
        {
            get
            {
                return u_access_level;
            }

            set
            {
                u_access_level = value;
            }
        }

        public String show()
        {
            return u_id + " - " + u_name + " - " + u_email + " - " + u_password + " - " + u_access_level + " - " + U_cnic;
        }
    }
}
