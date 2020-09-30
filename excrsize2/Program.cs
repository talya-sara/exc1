using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excrsize2
{
    class Program
    {
        static void Main(string[] args)
        {
            shap s1 = new shap();
            s1.Gov = 5;
            s1.Rad = 8;
            s1.Roch = 6;
            ((ICircleable)s1).area();
            ((ICubeable)s1).area();
            Console.ReadLine();
        }
    }
}
