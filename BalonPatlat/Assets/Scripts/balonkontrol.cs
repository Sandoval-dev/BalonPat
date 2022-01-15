using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balonkontrol : MonoBehaviour
{
    public AudioClip balonpatlama;
    public GameObject patlama;
    oyunkontrol oyunkontrolscripti;

    public void Start()
    {
        oyunkontrolscripti = GameObject.Find("Scripts").GetComponent<oyunkontrol>();


    }
    public  void OnMouseDown()
    {
        GameObject go = Instantiate(patlama, transform.position, transform.rotation) as GameObject;
        AudioSource.PlayClipAtPoint(balonpatlama, transform.position);

        Destroy(this.gameObject);
        Destroy(go, 0.284f);
        oyunkontrolscripti.BalonEkle();



    }
}
