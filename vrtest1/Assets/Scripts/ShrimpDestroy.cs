using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrimpDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   

    //도우랑 충돌 시 사라지고 새우가 칠해짐
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "dough")
        {
            GameObject.Find("dough").GetComponent<Dough>().shrimp_sc = true;
            Destroy(gameObject, 1f);
        }
    }
}
