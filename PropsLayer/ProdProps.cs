using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropsLayer
{
    public class ProdProps
    {
        private String prd_id;
        private String prd_title;
        private String prd_price;
        private String prd_stock;
        private String prd_expiry;
        private String prd_manufact;
        private String prd_image;

        public ProdProps()
        {

        }

        public ProdProps(String prd_id, String prd_title, String prd_price, String prd_stock, String prd_expiry, String prd_manufact)
        {
            this.prd_id = prd_id;
            this.Prd_title = prd_title;
            this.Prd_price = prd_price;
            this.Prd_stock = prd_stock;
            this.Prd_expiry = prd_expiry;
            this.Prd_manufact = Prd_manufact;
        }
        public string Prd_id
        {
            get
            {
                return prd_id;
            }

            set
            {
                prd_id = value;
            }
        }

        public string Prd_title
        {
            get
            {
                return prd_title;
            }

            set
            {
                prd_title = value;
            }
        }

        public string Prd_price
        {
            get
            {
                return prd_price;
            }

            set
            {
                prd_price = value;
            }
        }

        public string Prd_stock
        {
            get
            {
                return prd_stock;
            }

            set
            {
                prd_stock = value;
            }
        }

        public string Prd_expiry
        {
            get
            {
                return prd_expiry;
            }

            set
            {
                prd_expiry = value;
            }
        }

        public string Prd_manufact
        {
            get
            {
                return prd_manufact;
            }

            set
            {
                prd_manufact = value;
            }
        }

        public string Prd_image
        {
            get
            {
                return prd_image;
            }

            set
            {
                prd_image = value;
            }
        }
    }
}
