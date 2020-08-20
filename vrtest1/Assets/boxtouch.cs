using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxtouch : MonoBehaviour
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
        if (other.transform.tag == "MainCharacterHand")
        {

            GameObject.Find("dough").GetComponent<Dough>().baked_sc = false ;
            GameObject.Find("dough").GetComponent<Dough>().shrimp_sc = false;
            GameObject.Find("dough").GetComponent<Dough>().mushroom_sc = false;
            GameObject.Find("dough").GetComponent<Dough>().brocolli_sc = false;
            GameObject.Find("dough").GetComponent<Dough>().cheese_sc = false;
            GameObject.Find("dough").GetComponent<Dough>().tomato_sc = false;
            GameObject.Find("dough").GetComponent<Dough>().rolled_sc = false;
            GameObject.Find("dough").GetComponent<Animator>().SetTrigger("dough_reset");

            GameObject.Find("Character_rig").GetComponent<guest_script_2>().guest_happy = false;
            GameObject.Find("Character_rig").GetComponent<guest_script_2>().guest_sad = false;
            GameObject.Find("Character_rig").GetComponent<guest_script_2>().guest_handup = true;
            GameObject.Find("Character_rig").GetComponent<Animator>().SetTrigger("reset_guest");
            GameObject.FindGameObjectWithTag("guest_emo").GetComponent<Animator>().SetTrigger("g_emo_reset");

            GameObject.Find("arbeit_rig").GetComponent<arbeit>().arbeit_happy = false;
            GameObject.Find("arbeit_rig").GetComponent<arbeit>().arbeit_sad = false;
            GameObject.Find("arbeit_rig").GetComponent<arbeit>().arbeit_handup = true;
            GameObject.Find("arbeit_rig").GetComponent<Animator>().SetTrigger("reset_arbeit");
            GameObject.FindGameObjectWithTag("arbeit_emo").GetComponent<Animator>().SetTrigger("ae_reset");

            

        }
}


}
