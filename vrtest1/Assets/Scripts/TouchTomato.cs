using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTomato : MonoBehaviour
{
    public GameObject source;
    private bool tomato = GameObject.Find("dough").GetComponent<Dough>().tomato_sc;
    private bool cheese = GameObject.Find("dough").GetComponent<Dough>().cheese_sc;
    private bool brocoli = GameObject.Find("dough").GetComponent<Dough>().brocolli_sc;
    private bool shrimp = GameObject.Find("dough").GetComponent<Dough>().shrimp_sc;
    private bool mushroom = GameObject.Find("dough").GetComponent<Dough>().mushroom_sc;
    // Start is called before the first frame update
    void Start()
    {
      
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "MainCharacterHand")
        {
            Debug.Log("Collision");
            GameObject.Find("dough").GetComponent<Dough>().tomato_sc = true;
           

        }
            
    }
}
