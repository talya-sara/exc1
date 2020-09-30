using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excrsize2
{
    class shap : ICircleable, ICubeable
    {
        public int Rad { get; set; }
        public int Gov { get; set; }
        public int Roch { get; set; }
        void ICircleable.area()
        {
            Console.WriteLine("shetach circle:"+Rad*Rad*3.14);
        }

         void ICubeable.area()
        {
            Console.WriteLine("shetach cube:" + Roch*Gov);
        }
    }
}
