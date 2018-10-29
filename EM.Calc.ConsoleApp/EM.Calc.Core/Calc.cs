using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Calc.Core
{
    public class Calc
    {
        public int Sum(int[] args)
        {
            return args.Sum();
        }
        public int Raz(int[] args)
        {
            int i;
            i = args[0];
            for (int ii = 1; ii < args.Length; ii++)
            {
                i-=args[ii];
            }                              
            return i ;
        }
        public int Stp(int[] args)
        {
            Double x;
            x = args [0];
            for (int ii = 1; ii < args.Length; ii++)
            {
                x = Math.Pow (x,args [ii]);
            }
            return (int)x;
        }
    }

}
