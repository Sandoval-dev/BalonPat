using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using GoogleMobileAds.Api;


public class buton1 : MonoBehaviour
{
    public UnityEngine.UI.Text puan;
    admobmanager admobmanager1;



    void Start()
    {
        int sayi = PlayerPrefs.GetInt("balonsayisi");
        puan.text = "Patlayan Balon: " + sayi;
        admobmanager1 = FindObjectOfType<admobmanager>();

    }
   
    public void DigerSahne()
    { 
        
        SceneManager.LoadScene("bolum2");
    }
}
