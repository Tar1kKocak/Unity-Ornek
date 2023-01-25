using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AklindanBirSayiTut : MonoBehaviour
{
    int minsayi = 1;
    int maxsayi = 100;
    int tahmin;
    bool oyunbasladi = false;
    bool oyunbitti = false;
    // Start is called before the first frame update
    void Start()
    {
        print("Benimle Oyun Oynamak ister misin? (E/H)");
    }

    // Update is called once per frame
    void Update()
    {
        if (oyunbasladi == false)
        {


            //----------Baslangic
            if (Input.GetKeyDown(KeyCode.E))
            {
                print("Harika! Aklindan 1-100 arasinda bir sayi tut ve enter tusuna bas");
            }
            else if (Input.GetKeyDown(KeyCode.H))
            {
                print("Sen bilirsin");
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Kontrol();
                oyunbasladi= true;
            }
            //----------Baslangic
        }
        else if(oyunbitti== false) 
        {


            //----------Oyun
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                minsayi = tahmin;
                Kontrol();

            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                maxsayi = tahmin;
                Kontrol();
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                print("Yasasin, aklindaki sayiyi buldum.");
                oyunbitti= true;
            }
            //--------Bitis
        }

    }
    void Kontrol()
    {
        tahmin = (minsayi + maxsayi) / 2;
        print("Aklindan tuttugun sayi :" + tahmin + "mi? Daha buyuk ise yukari, daha kucuk ise asagi yon tusuna bas! Dogruysa bosluk tusuna bas");
    }
}
