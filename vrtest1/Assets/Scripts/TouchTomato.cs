using OVR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTomato : MonoBehaviour
{
    public GameObject source;
    // Start is called before the first frame update
    void Start()
    {
    }


    // Update is called once per frame
    void Update()
    {
        
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            Debug.Log("Trigger");
        }
    }
    
    //도우에 트리거 닿았을 시와 오큘러스의 트리거 버튼을 눌렀을 때 
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "dough")
        {
            Debug.Log("Colli");
            if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
            {
                Debug.Log("Stay and input");
                GameObject.Find("dough").GetComponent<Dough>().tomato_sc = true;
            }
            
        }
    }
}
