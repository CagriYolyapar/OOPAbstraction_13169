using OOPAbstraction_1.Models;
using OOPAbstraction_1.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPAbstraction_1
{
    public partial class Form1 : Form
    {
        /*
         
         
                ---Abstraction Prensibi
        Abstraction prensibini de inheritance yoksa uygulayamazsınız...

         Bizim bazı sınıflarımız kendilerinden instance alındıgı zaman Ram üzerinde anlamsız veri modelleri(nesneleri) olusturabilir...Mesela GeometrikSekil isimli bir sınıf özellikle bir nesne üretmek icin tasarlanmamıstır...Cünkü cok genel bir tanımdır...Bu sınıfın tek görevi daha spesifik olan class'lara miras vermektir...Biz eger GeometrikSekil sınıfınan instance alıp nesne üretirsek Ram'de bu nesne cok genel ve anlamsız bir tanım olup bos yere yer kaplayacaktır(Aynı zamanda Phantom Object sorunu karsımıza gelecektir...) Bunu engellemek adına sınıftan bir instance alınmasının önüne gecilmesi gereklidir...Yani sınıf soyut bir model olarak sadece miras vermekle yükümlü olacaktır...


        Abstract sınıfların tek görevi miras vermektir...


        Bir sınıfın neden abstract class olması gerektigini sadece o class miras vermekle görevlendirilecek ise anlarsınız(instance'i alınmayacaksa)


         Abstract class:
        1 . Adım => Classı olustur
        2.  Adım => Class'ı Abstract olarak işaretle
         
         --------------------------------------------------------------------

        Abstract Members(Ogeler)

        !!! Abstract ogeler sadece Abstract Class'lar icerisinde olusturulabilir...
         
         Bizim bazı senaryolar karsısında metodun veya property'nin varsayılan görevini tanımlamak istemedigimiz veya bilmedigimiz durumlar olabilir...Bu ogelerin görevlerini sadece miras verilecek sınıflarda tanımlamak isteyebiliriz...Böylece biz de o ogenin baslangıc metodu/Property'si aracılıgı ile istedigimiz görevi tanımlayalım diye bu sefer ilgili ögeye abstract keyword'u koyarız... Abstract ogeler ilk olusturuldukları yerde bir yasam alanına sahip olamaz...Sadece görevlerinin belirtilecegi yerde yasam alanlarının acılıp o sekilde yazılmaları gerekir...Görevi belli olmayan bir yapının görevlerinin miras verildigi yerde belirtilmesine implement etmek denir...Görevleri belli olmayan yapıların görevleri miras verildikleri yer Abstract bir class degilse kesinlikle belirtilmelidir...Yoksa syntax hatası alırsınız...Cünkü Abstract ogeler sadece Abstract class'lar icerisinde barındırılabilir...

        Field'ler abstract keyword'u alamazlar...
         
         
         
         
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //List<Personel> personeller = new List<Personel>
            //{
            //    new Egitmen(), new Mudur()
            //};

            //foreach (Personel item in personeller)
            //{
            //    item.GorevYap();
            //}
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {


            Mudur m = new Mudur();



            Product p = new Product(txtIsim.Text,Convert.ToDecimal(txtFiyat.Text));
            lstSonuc.Items.Add(p);

            //int a = 0;

            //if (p != null)
            //{
            //    a = 1;

            //}
            //else
            //{
            //    a = 0;
            //}

            //Ternary if
            //int a = p != null ? 1 : 0;

            //$"{p!=null?"evli":"bekar"}";


        }
    }
}
