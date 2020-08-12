using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arbeit : MonoBehaviour
{


    public bool arbeit_handup;
    public bool arbeit_happy;
    public bool arbeit_sad;
    public bool arbeit_walk;

    // Start is called before the first frame update
    void Start()
    {
        
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
            GetComponent<arbeit>().arbeit_handup = false;

        }
        else
        {
            GetComponent<arbeit>().arbeit_handup = true;

        }


        if (GameObject.Find("dough").GetComponent<Dough>().baked_sc == true)
        {
            if (GameObject.Find("dough").GetComponent<Dough>().perfect_sc == true
)
            {

                GetComponent<arbeit>().arbeit_happy = true;
            }
            else if (GameObject.Find("dough").GetComponent<Dough>().perfect_sc == false)
            {

                GetComponent<arbeit>().arbeit_sad = true;

            }

        }

        if (GameObject.Find("dough").GetComponent<Dough>().baked_sc == false)
        {

            GetComponent<arbeit>().arbeit_sad = false;
            GetComponent<arbeit>().arbeit_happy = false;

        }




        if (GetComponent<arbeit>().arbeit_handup == true)
        {


            transform.GetComponent<Animator>().SetBool("dance", true);
            transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<Animator>().SetBool("ae_cheer", false);
        }

        else
        {
            transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<Animator>().SetBool("ae_cheer", true);
            gameObject.GetComponent<Animator>().SetBool("dance", false);

        }

        if (GetComponent<arbeit>().arbeit_happy == true)
        {



            transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<Animator>().SetBool("ae_happy", true);
            transform.GetComponent<Animator>().SetBool("happy", true);
        }

        else
        {

            transform.GetComponent<Animator>().SetBool("happy", false);
            transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<Animator>().SetBool("ae_happy", false);

        }

        if (GetComponent<arbeit>().arbeit_sad == true)
        {


            transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<Animator>().SetBool("ae_sad", true);
            transform.GetComponent<Animator>().SetBool("sad", true);
        }

        else
        {

            transform.GetComponent<Animator>().SetBool("sad", false);
            transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<Animator>().SetBool("ae_sad", false);

        }

    }
}
