using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsCreateObject
{
    class classInheritance
    {
        public void InheritanceMethod()
        {
            Console.WriteLine("\nThe base Inheritance Method is called");
        }
    }
    class InheritanceDerived:classInheritance
    {
        public void   InheritanceMethod2()
        {
            Console.WriteLine("\nthis is derived inheritance class called");
        }
    }

    ///<summary>
    ///Few Online Products Available
    /// </summary>

    class ElectronicsInheritance {
        public string Mobiles;
        public string Desktops;
        public string Watches;
        public string earBuds;
        public string neckBand;
        public string Mouses;
        public void ElectronicsProducts()
        {
            Console.WriteLine($"\nThe Local Shops  Eectronics products more sells in Mobile: {Mobiles}, Desktop: {Desktops}, Watches: {Watches}");
        }
      
    }
    class ElectronicCommers : ElectronicsInheritance
    {
        
        public void ECommersPurches()
        {
            Console.WriteLine($"\nthe Ecommers more  Purches ietms are {earBuds}, {neckBand} ,{Mouses}");
        }
    }



}
