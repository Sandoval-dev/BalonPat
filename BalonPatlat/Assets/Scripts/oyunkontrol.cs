using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oyunkontrol : MonoBehaviour
{
    public AudioClip balonpatlama;
    public UnityEngine.UI.Text zamantext, balontext;
    public float zamansayaci = 60;
    public int patlayanbalon = 0;
    public GameObject patlama;
    admobmanager admobmanager;



    void Start()
    {
        
        balontext.text = "Patlayan Balon: " + patlayanbalon;
        admobmanager = Object.FindObjectOfType<admobmanager>();
        admobmanager.ShowBanner();

    }

    // Update is called once per frame
    void Update()
    {
        
        if (zamansayaci > 0)
        {
            zamansayaci -= Time.deltaTime;
            zamantext.text = " Süre: " + (int)zamansayaci;
        }


        else 
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("balon");
            for (int i = 0; i < go.Length; i++)
            {
                Instantiate(patlama, go[i].transform.position, go[i].transform.rotation);
                Destroy(go[i]);
            }
        }

    }

    public void BalonEkle()
    {
        patlayanbalon += 1;
        balontext.text = "Patlayan Balon: " + patlayanbalon;
        PlayerPrefs.SetInt("balonsayisi", patlayanbalon);

    }
}
