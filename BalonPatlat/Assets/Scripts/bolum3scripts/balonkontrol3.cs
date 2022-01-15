using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balonkontrol3 : MonoBehaviour
{
    public AudioClip balonpatlama;
    public GameObject patlama;
    oyunkontrol3 oyunkontrolscripti;
    void Start()
    {
        oyunkontrolscripti = GameObject.Find("Scripts").GetComponent<oyunkontrol3>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject go = Instantiate(patlama, transform.position, transform.rotation) as GameObject;
        AudioSource.PlayClipAtPoint(balonpatlama, transform.position);

        Destroy(this.gameObject);
        Destroy(go, 0.284f);
        oyunkontrolscripti.BalonEkle();
    }
}
