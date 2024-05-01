using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPC_Testing
{
    public class SKU
    {
        //Properties to read and write to form
        public string SKUitem { get; set; }
        public string caseType { get; set; }
        public string mobo { get; set; }
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string GPU { get; set; }
        public string HDD { get; set; }
        public string SSD { get; set; }
        public int ID { get; set; }
        public string windows { get; set; }

        //Reading all properties and converting to string to represent the SKU
        public string Info
        {
            get 
            {
                return $"{SKUitem} ";//{caseType} {mobo} {CPU} {RAM} {GPU} {HDD} {SSD} ({ID}) ({windows})";
            }
        }

       
    }
}
