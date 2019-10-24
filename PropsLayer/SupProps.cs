using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropsLayer
{
    public class SupProps
    {
        private String s_id;
        private String s_name;
        private String s_cell;
        private String s_address;

        public string S_id
        {
            get
            {
                return s_id;
            }

            set
            {
                s_id = value;
            }
        }

        public string S_name
        {
            get
            {
                return s_name;
            }

            set
            {
                s_name = value;
            }
        }

        public string S_cell
        {
            get
            {
                return s_cell;
            }

            set
            {
                s_cell = value;
            }
        }

        public string S_address
        {
            get
            {
                return s_address;
            }

            set
            {
                s_address = value;
            }
        }
    }
}
