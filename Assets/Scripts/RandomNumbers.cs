using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class RandomNumbers : MonoBehaviour
{
    // sayilarin saklanacagi array
    public static int[] Array25;
    public static int sum = 0;
    public static bool sorunsuz=false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Rasgele25()
    {
        // 1-25 arasinda sayi uretir
        // Dizi25'e aktarir.
        // dizi elemanlar?n?n toplami 325 de?ilse
        // cift sayiyi siler, eksik sayiyi ekler (tekrarlar)
        for (int i = 0; i < 25; i++)
        {
            Array25[i] = UnityEngine.Random.Range(1, 100000)%25;
            sorunsuz = Kontrol(Array25);
        }
        
    }

    bool Kontrol(int[] Array)
    {
        DiziTopla(Array);
        if (sum == 25*26/2)
        {
            sorunsuz = true;
        }
        else
        {

        }
    }
    void DiziTopla(int[] Array)
    {
        sum = 0;
        for (int i = 0; i < 24; i++)
        {
            sum = sum + Array[i];
        }

    }
