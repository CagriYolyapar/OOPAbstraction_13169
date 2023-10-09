using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAbstraction_1.Models
{
    public class Mudur : Personel
    {
        public Mudur()
        {

        }
       
        public Mudur(string isim,string soyIsim,string TCKNo):base(isim,soyIsim,TCKNo)
        {
         
        }
        public override void GorevYap()
        {
            throw new NotImplementedException();
        }
    }
}
