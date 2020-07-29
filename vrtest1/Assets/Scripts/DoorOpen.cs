using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "MainCharacterHand")
        {
            Debug.Log("Collision");
            transform.GetComponent<Animator>().SetBool("isOpen", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "MainCharacterHand")
        {
            Debug.Log("NoCollision");
            transform.GetComponent<Animator>().SetBool("isOpen", false);
        }
    }
}
