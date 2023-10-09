using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAbstraction_1.Models
{
    public class Egitmen : Personel
    {
        public override void GorevYap()
        {
            System.Windows.Forms.MessageBox.Show("Odev ver");
        }
    }
}
