using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balonkontrol1 : MonoBehaviour
{
    public AudioClip balonpatlama;
    public GameObject patlama;
    oyunkontrol1 oyunkontrolscripti1;

    void Start()
    {
        oyunkontrolscripti1 = GameObject.Find("Scripts").GetComponent<oyunkontrol1>();
        

    }
    void OnMouseDown()
    {
        GameObject go = Instantiate(patlama, transform.position, transform.rotation) as GameObject;
        AudioSource.PlayClipAtPoint(balonpatlama, transform.position);

        Destroy(this.gameObject);
        Destroy(go, 0.284f);
        oyunkontrolscripti1.BalonEkle();
    }
}
