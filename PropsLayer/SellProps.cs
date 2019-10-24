using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropsLayer
{
    public class SellProps
    {
        private String trx_id;
        private String p_title;
        private String p_price;
        private String p_quantity;
        private String p_date;
        private String p_sold_by;

        public string Trx_id
        {
            get
            {
                return trx_id;
            }

            set
            {
                trx_id = value;
            }
        }

        public string P_title
        {
            get
            {
                return p_title;
            }

            set
            {
                p_title = value;
            }
        }

        public string P_price
        {
            get
            {
                return p_price;
            }

            set
            {
                p_price = value;
            }
        }

        public string P_quantity
        {
            get
            {
                return p_quantity;
            }

            set
            {
                p_quantity = value;
            }
        }

        public string P_date
        {
            get
            {
                return p_date;
            }

            set
            {
                p_date = value;
            }
        }

        public string P_sold_by
        {
            get
            {
                return p_sold_by;
            }

            set
            {
                p_sold_by = value;
            }
        }
    }
}
