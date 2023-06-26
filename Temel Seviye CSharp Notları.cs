using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSharpTemelleri : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        	// C# Rehberi


        //Integer: 2, 10, 101, ...
        //Float: 3.14, 5.14, ...
        //String: Turgay, ...



            // Degisken Degistirme:
        //string isim = "Turgay Kaya";
        //print(isim);

        //int x = 56;
        //print(x);

        //float y = 3.14f;
        //print(y);



	        // VAR	#-> int mi, string mi, float mi oldugunu anlar.
        //var a = 15;
        //var b = 3.14f;
        //var c = "Tydot Games";

        //print(a)
        //print(b)
        //print(c)



	        // Temel Matematik Operatorleri
        //print(1+1);
        //print(34/2);
        //...



            // Boolean
        //bool x = true;
        //bool y = false;
        //print(x);

        //var x  = 1;
        //var y = 2;
        //print(x+y);

        //var a = "Turgay";
        //var b = " Kara";
        //print(a+b);

        //var a = "Tydot Games";
        //var b = 10;
        //var c = 3.14f;
        //print(a+ " " +b+" "+c);

        //a = "Turgay Kara";
        //b = 12;
        //c = 5.31f;
        //print(a+ " " +b+" "+c);



           // Karsilastirma Operatorleri
        //> -> Buyuktur.
        //== -> Esittir.
        //>= -> Buyuktur veya Esittir.
        //print(5>6);   #False: 5, 6'dan buyuk degildir.



            // Kosullu Durumlar -> if, else, else if
        //var a = 5;
        //var b = 6;
        //if(a==b)       // a==b degil ise diger kosullar gerceklesecektir.
            //print("a, b'ye esittir.");
        
        //else
        //{
            //print("a, b'ye esit degildir.");
        //}


            // While Dongusu
        //var x = 0;
        //while(x<5)
        //{
            //x = x+1;    // x, 1'den 5'e kadar yazdirilmaya devam edecektir.
            //print(x);
        //}



            // Do-while Dongusu
        
        //var x = 0;
        //do
        //{
            //x = x+1;
            //print(x);
            
        //}while(x<5);



            // Switch-Case Yapisi    -> Sadece 1 tane case dogru olmalidir.
        //var x = 1;
        //switch(x)
        //{
            //case 1: print("x'in degeri 1'dir.");
                //break;
            //case 2: print("x'in degeri 2'dir.");
                //break;
        //}



            // for Dongusu
        //int x;
            //Tanimlama;  Sart; Yapilacak
        //for(x = 0; x < 5; x += 1)      //-> for 3 tane durum ister: x'i 0 olarak gor, x<5 oldugu surece bu kod blogunu islet, x'i 1 arttirarak ilerle.
        //{
            //print(x);
        //}



            // Listeler
        /*
        List<string> gunler = new List<string>();

        gunler.Add("Pazartesi");
        gunler.Add("Sali");
        gunler.Add("Carsamba");
        gunler.Add("Persembe");
        gunler.Add("Cuma");
        gunler.Add("Cumartesi");
        gunler.Add("Pazar");

        print(gunler); //-> Bu kod calismaz cunku gunler "Iterable Obje"dir. 
                            //-> Iterable Obje: Kendi icinde birden fazla degisken(string) barindiriabilen objelere denir.
        */

        /*
            // foreach Dongusu
        //foreach (var item in gunler)    //Gecici obje(item) olusturur ve gunler icinde bulunan elemanlara sirasiyla erisir.
        //{
            //print(item);
        //}
        //var x = 5;
        //var y = "Turgay ";
        */


            // Array    -> str, int'lerin vs. toplu halde bulunduklari bir obje.
        /*
        string  isim = "Turgay";
        string[] gunler = {"Pazartesi", "Sali", "Carsamba"};
        
        foreach (var item in gunler)
        {
            print(item);
        }
        */
            //print(gunler[0]);   //Seklinde gunler listesinin ilk elemanini yazdirir.



            // ArrayList    -> Arraydan farki icerisine int, str, float degerler ekleyebilmemizdir.
        /*
        ArrayList karisik = new ArrayList();
        karisik.Add(2);
        karisik.Add("Turgay");
        karisik.Add(3.14f);

        foreach(var item in karisik)
        {
            print(item);
        }
        */
            //print(karisik[1]);   //Seklinde karisik listesinin 2. elemanini yazdirir.
    }
     //Update is called once per frame
    void Update()
    {
        
    }
}