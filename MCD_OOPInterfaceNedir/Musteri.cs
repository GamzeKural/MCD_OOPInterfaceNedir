using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPInterfaceNedir
{
    public class Musteri : IMusteri
    {

        int _id;
        string _isim;
        string _soyisim;



        int IMusteri.Id
        { 
            get { return _id; }
            set { _id = value; }
        }
        string IMusteri.Isim
        {
            get { return _isim; }
            set { _isim = value; }
        }
        string IMusteri.Soyisim
        {
            get { return _soyisim; }
            set { _soyisim = value; }
        }



        int IMusteri.KayitDüzenle(int Id, string Isim, string Soyisim)
        {
            Console.WriteLine("Kayıt düzenlendi...");
            return 1;
        }

        int IMusteri.KayitSil(int Id)
        {
            Console.WriteLine("Kayıt silindi...");
            return 1;
        }

        int IMusteri.YeniKayit(string Isim, string Soyisim)
        {
            Console.WriteLine("Yeni kayıt eklendi...");
            return 1;
        }
    }
}
