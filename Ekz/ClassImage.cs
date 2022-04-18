using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekz
{
   public partial class TableEkz
    {
        public string img
        {
            get
            {
                if (Art != null)
                {
                    return Art;
                }
                else
                {
                    return "Img/no-image.png";
                }
            }
        }
    }
}
