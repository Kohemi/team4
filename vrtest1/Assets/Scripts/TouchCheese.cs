using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchCheese : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "dough")
        {
            Debug.Log("Colli");
            if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
            {
                Debug.Log("Stay and input");
                GameObject.Find("dough").GetComponent<Dough>().cheese_sc = true;
            }

        }
    }
}
