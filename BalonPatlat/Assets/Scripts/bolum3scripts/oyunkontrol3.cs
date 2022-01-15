using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oyunkontrol3 : MonoBehaviour
{
    
    public UnityEngine.UI.Text zamantext, balontext1;
    public float zamansayaci = 60;
    public int patlayanbalon1 = 0;
    public GameObject patlama;

    void Start()
    {

        balontext1.text = "Patlayan Balon: " + patlayanbalon1;



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
        patlayanbalon1 += 1;
        balontext1.text = "Patlayan Balon: " + patlayanbalon1;
        PlayerPrefs.SetInt("balonsayisi", patlayanbalon1);

    }
}
