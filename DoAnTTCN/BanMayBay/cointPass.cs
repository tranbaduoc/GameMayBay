using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanMayBay
{
    public class cointPass
    {
        private static  int coint;
        private static int pass;

        public int Pass
        {
            get
            {
                return pass;
            }

            set
            {
                pass = value;
            }
        }

        public int Coint
        {
            get
            {
                return coint;
            }

            set
            {
                coint = value;
            }
        }
        public override string ToString()
        {
            return  coint+pass+"";
        }
    }
}
