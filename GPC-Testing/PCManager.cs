using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPC_Testing
{
    class PCManager
    {
        public int ID { get; set; }
        public int orderID { get; set; }
        public string SKU { get; set; }
        public int quantity { get; set; }
        public string channel { get; set; }
        public string date { get; set; }
        public bool isTested { get; set; }
        public string testedBy { get; set; }
        public string testStatus { get; set; }
    }


    class Gaming : PCManager
    {

    }

    class Laptops : PCManager
    {

    }
}
