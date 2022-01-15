using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class buton : MonoBehaviour
{
    public UnityEngine.UI.Text puan;
   
    void Start()
    {
        int sayi = PlayerPrefs.GetInt("balonsayisi");
        puan.text = "Patlayan Balon: " + sayi;
       

    }
    

  

    public void DigerSahne()
    {
        SceneManager.LoadScene("oyun");
    }
}
