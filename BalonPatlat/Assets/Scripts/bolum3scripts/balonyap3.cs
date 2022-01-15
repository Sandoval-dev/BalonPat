using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class balonyap3 : MonoBehaviour
{
    public GameObject[] balon;
    float balonyapmasuresi = 1f;
    public float zamansayaci = 0f;
    oyunkontrol3 okscripti;
    // Start is called before the first frame update
    void Start()
    {
        okscripti = this.gameObject.GetComponent<oyunkontrol3>();
    }

    // Update is called once per frame
    void Update()
    {
        zamansayaci -= Time.deltaTime;
        int katsayi = (int)(okscripti.zamansayaci / 10) - 6;
        katsayi *= -1;
        if (zamansayaci < 0 && okscripti.zamansayaci > 0)
        {
            GameObject go = Instantiate(balon[Random.Range(0, 9)], new Vector3(Random.Range(-2.29f, 2.29f), -5.76f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(50f * katsayi, 80f * katsayi), 0));
            zamansayaci = balonyapmasuresi;



        }

        if (zamansayaci <= 0)
        {
            SceneManager.LoadScene("digerbolumegecis");
        }
    }
}
