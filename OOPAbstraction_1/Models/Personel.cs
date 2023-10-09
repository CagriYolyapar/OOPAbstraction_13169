using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAbstraction_1.Models
{
    //Class burada Abstraction prensibine girmiştir...Bu Personel class'ından instance alınamayacaktır...
    public abstract class Personel
    {
        public Personel()
        {

        }
      
        public Personel(string isim,string soyIsim, string tCKNo)
        {
            Isim = isim;
            SoyIsim = soyIsim;
            TCKNo = tCKNo;
        }

        public string Isim { get; set; }
        public string SoyIsim { get; set; }
        public string TCKNo { get; set; }

        public abstract void GorevYap();
       
        

        

    }
}
