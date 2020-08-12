using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShrimp : MonoBehaviour
{
    public Transform RightSpawnpoint;
    public Transform LeftSpawnpoint;
    public GameObject Prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(Prefab, RightSpawnpoint.position, RightSpawnpoint.rotation);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "dough")
            GameObject.Find("dough").GetComponent<Dough>().shrimp_sc = true;
        
        
    }
}
