        // METOT 2
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetotKonusu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //isimSoyisim("Turgay", "Kara");      // (2.1)
        //isimSoyisim("Tydot", "Games");      // (2.2) Bir metot birden fazla kez calistirilabilir.
    }

    //void isimSoyisim(string isim, string soyisim)	// (2.3)
    //{
        //print(isim+" " + soyisim);			// (2.4)
    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}



        // METOT 1
/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetotKonusu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        cikar(topla(5, 6));     // (1.1)
    }


    int topla(int x, int y)     // (1.2)
    {
        return x+y;             // (1.3)       Bu islem sadece int icin degil, str icin de yapilabilir.
    }

    void cikar(int sayi)        // (1.4)
    {
        print(sayi-5);          // (1.5) Yukarida olusturdugumuz icice fonksiyonun ciktisi sayi olarak tanimlandi ve bu sayidan 5 cikartmasini istedik.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
*/