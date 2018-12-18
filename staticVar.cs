using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mainstream_Anime_Emporium
{
    public class staticVar
    {
        private static frmLogin login;

        public struct _item
        {
            private int id;
            private int quantity;
            
            public int ID
            {
                get { return id; }
                set { id = value; }
            }

            public int Quantity
            {
                get { return quantity; }
                set { quantity = value; }
            }
        }

        private static List<_item> _cart = new List<_item>();

        public static List<_item> Cart
        {
            set { _cart = value; }
            get { return _cart; }
        }
        public static frmLogin Login
        {
            set { login = value; }
            get { return login; }
        }

        public void checkCart(int ID, int quantity)
        {
            bool newItem = true;

            for(int i = 0; i < Cart.Count; i++)
            {
                if (ID == Cart[i].ID)
                {
                    int tQ = Cart[i].Quantity + quantity;
                    _item replace = new _item();
                    replace.ID = ID;
                    replace.Quantity = tQ;
                    Cart[i] = replace;
                    newItem = false;
                    break;
                }
            }

            if (newItem)
            {

            }
        }
    }
}
