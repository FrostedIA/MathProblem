using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Problema1 : MonoBehaviour
{
    public Text Resposta;
    public int a;
    public int b;
    public int M3;
    public int M31;
    public int M5;
    public int M51;
    public int c;
   
    public int M15;
    public int M151;
    


    public int STotal;




    void Update()
    {

       

        Resposta.text = STotal.ToString();


           if (a < 999)
             {
           
            a += 3;
                M3 =+ a;
                M31 += M3;

             }
       

        if (b <= 990)
        {

            b += 5;
            M5 =+ b;
            M51 += M5;

        }
        if (c <= 985)
        {

            c += 15;
            M15 = +c;
            M151 += M15;

        }
        STotal =  M31+M51-M151;


    }






}
