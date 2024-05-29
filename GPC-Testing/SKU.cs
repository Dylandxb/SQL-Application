using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPC_Testing
{
    public class SKUParent
    {
        //Properties to read and write to form
        public string SKU { get; set; }
        public string PCCASE{ get; set; }
        public string MOBO { get; set; }
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string GPU { get; set; }
        public string HDD { get; set; }
        public string SSD { get; set; }
        public int IDnum { get; set; }
        public string WindowsVersion { get; set; }

        public int orderID { get; set; }

        //Reading all properties and converting to string to represent the SKU. Encapulates all the SKU data
        public string SKU_Info
        {
            get 
            {
                //C4+i73770+16504G+B75+1TB+512GB 1034 @WIN10
                return $"{SKU} | {PCCASE} | {MOBO} |  {CPU} {RAM} {GPU} {HDD} {SSD} {IDnum} {WindowsVersion} {orderID}";
            }
        }

       
    }
}
