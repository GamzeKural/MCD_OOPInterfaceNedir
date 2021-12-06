using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPInterfaceNedir
{
    public interface IMusteri
    {
        //interface içinde ctor kullanılmaz.
        //field kullanılmaz.

        int Id { get; set; }
        string Isim { get; set; }
        string Soyisim { get; set; }

        //metot
        int YeniKayit(string Isim, string Soyisim);
        int KayitDüzenle(int Id, string Isim, string Soyisim);
        int KayitSil(int Id);
    }
}
