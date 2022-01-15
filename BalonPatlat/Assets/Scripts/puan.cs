using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puan : MonoBehaviour
{
    public UnityEngine.UI.Text balontext;
    int patlayanbalon = 0;


    void Start()
    {
        balontext.text = "Patlayan Balon: " + patlayanbalon;


    }
    public void BalonEkle()
    {
        patlayanbalon += 1;
        balontext.text = "Patlayan Balon: " + patlayanbalon;



    }

}
