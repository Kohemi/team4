﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("dough").GetComponent<Dough>().rolled_sc == true)
        {
            transform.GetComponent<Animator>().SetBool("Handsup", true);
        }
        
    }
}
