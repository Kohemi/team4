using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidEnabled : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //강체 활성화
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "MainCharacterHand" && (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch) || OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger, OVRInput.Controller.LTouch)))
        {
            gameObject.GetComponent<MeshCollider>().enabled = true;
            gameObject.GetComponent<Rigidbody>().useGravity = true;


        }
    }
}
