using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchBaked : MonoBehaviour
{
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
            GameObject.Find("dough").GetComponent<Dough>().baked_sc = true;


        }
    }
}
