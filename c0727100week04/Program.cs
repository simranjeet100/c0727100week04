using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0727100week04
{
    class Program
       
    {
        static void Main(string[] args)
        {

        }
 
        countryside c = new countryside();
    }
    class village
    {
        public bool isAstrilde;
        public village nextVillage;
        public  string villageName;
    }
    class countryside
    {
        village Toronto, Maple, Ajax;
        public void run()
        {
            Maple = new village();
            Maple.villageName = "Toronto";
            Maple.nextVillage = Toronto;
        }
    }
}
