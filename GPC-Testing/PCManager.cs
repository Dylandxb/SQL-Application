using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPC_Testing
{
    class PCManager
    {
        public int ID;
        public int orderID;
        public string SKU;
        public int quantity;
        public string channel;
        public string date;
        public bool isTested;
        public string testedBy;
        public string testStatus;
    }


    class Gaming : PCManager
    {

    }

    class Laptops : PCManager
    {

    }
}
