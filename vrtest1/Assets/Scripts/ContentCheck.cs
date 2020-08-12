using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentCheck : MonoBehaviour
{
    public GameObject Prefab;
    public Transform Spawnpoint;

    public bool isTouched;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //콘텐츠 체크 후 
    private void OnTriggerEnter(Collision collision)
    {
        collision.gameObject.tag = "MainCharacterHand";
        
        if(OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
        }
      
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.tag = "MainCharacterHand";
        isTouched = true;
        Debug.Log(isTouched);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "MainCharacterHand")
        {
            Debug.Log("Colli");
            if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch) || OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger, OVRInput.Controller.LTouch))
            {
                Debug.Log("Stay and input");
                Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
            }

        }
    }
}
