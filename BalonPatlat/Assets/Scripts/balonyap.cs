using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class balonyap : MonoBehaviour
{
    
    public GameObject[] balon;
    float balonyapmasuresi = 1f;
    public float zamansayaci = 0f;
    oyunkontrol1 okscripti;
    // Start is called before the first frame update
    void Start()
    {
        okscripti = this.gameObject.GetComponent<oyunkontrol1>();
    }

    // Update is called once per frame
    void Update()
    {
        zamansayaci -= Time.deltaTime;
        int katsayi1 = (int)(okscripti.zamansayaci / 10) - 6;
        katsayi1 *= -1;
        if (zamansayaci < 0 && okscripti.zamansayaci > 0)
        { 
            GameObject go = Instantiate(balon[Random.Range(0, 6)], new Vector3(Random.Range(-2.29f, 2.29f), -5.76f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(70f * katsayi1, 100f * katsayi1), 0));
            zamansayaci = balonyapmasuresi;
            


        }

        if (zamansayaci <= 0)
        {
            SceneManager.LoadScene("oyunbitti");
        }
    }


}
