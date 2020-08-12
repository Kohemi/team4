using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Playables;

public class guest_script_test : MonoBehaviour
{
    public bool guest_handup;
    public bool guest_happy;
    public bool guest_sad;
    public bool guest_walk;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<guest_script_test>().guest_handup = true;

    }

    // Update is called once per frame
    void Update()
    {




        if (
        GameObject.Find("dough").GetComponent<Dough>().rolled_sc == true ||
        GameObject.Find("dough").GetComponent<Dough>().tomato_sc == true ||
        GameObject.Find("dough").GetComponent<Dough>().cheese_sc == true ||
        GameObject.Find("dough").GetComponent<Dough>().brocolli_sc == true ||
        GameObject.Find("dough").GetComponent<Dough>().mushroom_sc == true ||
        GameObject.Find("dough").GetComponent<Dough>().shrimp_sc == true ||
        GameObject.Find("dough").GetComponent<Dough>().baked_sc == true
        )
        {
            GetComponent<guest_script_test>().guest_handup = false;
        }
        else
        {
            GetComponent<guest_script_test>().guest_handup = true;

        }


        if (GameObject.Find("dough").GetComponent<Dough>().baked_sc == true)
        {
            if (GameObject.Find("dough").GetComponent<Dough>().perfect_sc == true
)
            {

                Debug.Log("dough_input");
                GetComponent<guest_script_test>().guest_happy = true;
            }
            else if (GameObject.Find("dough").GetComponent<Dough>().perfect_sc == false)
            {

                GetComponent<guest_script_test>().guest_sad = true;

            }

        }








        if (GetComponent<guest_script_test>().guest_handup == true)
        {

            Debug.Log("handsup_input");

            transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[6].SetColor("_Color", new Vector4(0, 0, 0, 0));
            transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[5].SetColor("_Color", new Vector4(0, 0, 0, 1));
            transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[3].SetColor("_Color", new Vector4(0, 0, 0, 0));
            transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[2].SetColor("_Color", new Vector4(0, 0, 0, 1));


                transform.GetComponent<Animator>().SetBool("Handsup", true);
            }

            else
            {

                gameObject.GetComponent<Animator>().SetBool("Handsup", false);
                Debug.Log("handsup_output");
            transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[5].SetColor("_Color", new Vector4(0, 0, 0, 0));
            transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[6].SetColor("_Color", new Vector4(0, 0, 0, 1));

            transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[2].SetColor("_Color", new Vector4(0, 0, 0, 0));
            transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[3].SetColor("_Color", new Vector4(0, 0, 0, 1));
        }

        if (GetComponent<guest_script_test>().guest_happy == true)
        {


            transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[6].SetColor("_Color", new Vector4(0, 0, 0, 0));
            
            transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[5].SetColor("_Color", new Vector4(0, 0, 0, 1));
            transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[3].SetColor("_Color", new Vector4(0, 0, 0, 0));
            transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[0].SetColor("_Color", new Vector4(0, 0, 0, 1));


            transform.GetComponent<Animator>().SetBool("Happy", true);
        }

        else
        {

            transform.GetComponent<Animator>().SetBool("Happy", false);
            transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[5].SetColor("_Color", new Vector4(0, 0, 0, 0));
            transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[6].SetColor("_Color", new Vector4(0, 0, 0, 1));
            transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[0].SetColor("_Color", new Vector4(0, 0, 0, 0));
            transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[3].SetColor("_Color", new Vector4(0, 0, 0, 1));
        }

        if (GetComponent<guest_script_test>().guest_sad == true)
        {


            transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[6].SetColor("_Color", new Vector4(0, 0, 0, 0));
            transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[4].SetColor("_Color", new Vector4(0, 0, 0, 1));
            transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[3].SetColor("_Color", new Vector4(0, 0, 0, 0));
            transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[1].SetColor("_Color", new Vector4(0, 0, 0, 1));


            transform.GetComponent<Animator>().SetBool("Sad", true);
        }

        else
        {

            transform.GetComponent<Animator>().SetBool("Sad", false);
            transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[4].SetColor("_Color", new Vector4(0, 0, 0, 0));
            transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[6].SetColor("_Color", new Vector4(0, 0, 0, 1));

            transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[1].SetColor("_Color", new Vector4(0, 0, 0, 0));
            transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[3].SetColor("_Color", new Vector4(0, 0, 0, 1));
        }



    }


    
}