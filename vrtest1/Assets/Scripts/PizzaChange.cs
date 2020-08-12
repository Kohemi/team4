using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PizzaChange : MonoBehaviour
{
    public bool rolled;
    public bool tomato;
    public bool cheese;
    public bool shrimp;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        rolled = gameObject.GetComponent<Dough>().rolled_sc;
        tomato = gameObject.GetComponent<Dough>().tomato_sc;
        cheese = gameObject.GetComponent<Dough>().cheese_sc;
        shrimp = gameObject.GetComponent<Dough>().shrimp_sc;

        if (rolled == true && tomato == true && cheese == true && shrimp == true)
        {
            gameObject.GetComponent<BoxCollider>().isTrigger = false;
            gameObject.GetComponent<Rigidbody>().useGravity = true; 
        }
        
    }
}
