using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSale
{
    public class Class1
    {
        public static int Discount(int count, int AllCost)
        {
            float cena = 0;
            if (count >= 3 && count < 5)
            {
                cena /= AllCost * 0.95F;
            }
            else if (count >= 5 && count < 10)
            {
                cena /= AllCost * 0.90F;
            }
            else if (count >= 10 && count < 5)
            {
                cena /= AllCost * 0.85F;
            }
            int cenahDis = (int)Math.Floor(cena);
            return cenahDis;
        }
    }
}
