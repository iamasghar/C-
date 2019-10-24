using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropsLayer
{
    public class CusProps
    {
        private String c_id;
        private String c_name;
        private String c_cnic;
        private String c_cell;
        private String c_address;

        public string C_id
        {
            get
            {
                return c_id;
            }

            set
            {
                c_id = value;
            }
        }

        public string C_name
        {
            get
            {
                return c_name;
            }

            set
            {
                c_name = value;
            }
        }

        public string C_cnic
        {
            get
            {
                return c_cnic;
            }

            set
            {
                c_cnic = value;
            }
        }

        public string C_cell
        {
            get
            {
                return c_cell;
            }

            set
            {
                c_cell = value;
            }
        }

        public string C_address
        {
            get
            {
                return c_address;
            }

            set
            {
                c_address = value;
            }
        }
    }
}
