using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guest_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.U))
        {
            
            if (gameObject.GetComponent<Animator>().GetBool("Handsup") == true)
            {
                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[5].SetColor("_Color", new Vector4(0, 0, 0, 0));
                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[6].SetColor("_Color", new Vector4(0, 0, 0, 1));

                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[2].SetColor("_Color", new Vector4(0, 0, 0, 0));
                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[3].SetColor("_Color", new Vector4(0, 0, 0, 1));


                gameObject.GetComponent<Animator>().SetBool("Handsup", false);
            }

            else if (gameObject.GetComponent<Animator>().GetBool("Handsup") == false)
            {



                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[6].SetColor("_Color", new Vector4(0, 0, 0, 0));
                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[5].SetColor("_Color", new Vector4(0, 0, 0, 1));

                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[3].SetColor("_Color", new Vector4(0, 0, 0, 0));
                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[2].SetColor("_Color", new Vector4(0, 0, 0, 1));


                gameObject.GetComponent<Animator>().SetBool("Handsup", true);

            }
        }

        if (Input.GetKeyDown(KeyCode.I))
        {

            if (gameObject.GetComponent<Animator>().GetBool("Happy") == true)
            {

                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[5].SetColor("_Color", new Vector4(0, 0, 0, 0));
                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[6].SetColor("_Color", new Vector4(0, 0, 0, 1));

                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[0].SetColor("_Color", new Vector4(0, 0, 0, 0));
                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[3].SetColor("_Color", new Vector4(0, 0, 0, 1));


                gameObject.GetComponent<Animator>().SetBool("Happy", false);
            }

            else if (gameObject.GetComponent<Animator>().GetBool("Happy") == false)
            {

                gameObject.GetComponent<Animator>().SetBool("Happy", true);


                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[6].SetColor("_Color", new Vector4(0, 0, 0, 0));
                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[5].SetColor("_Color", new Vector4(0, 0, 0, 1));

                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[3].SetColor("_Color", new Vector4(0, 0, 0, 0));
                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[0].SetColor("_Color", new Vector4(0, 0, 0, 1));

            }
        }

        if (Input.GetKeyDown(KeyCode.O))
        {

            if (gameObject.GetComponent<Animator>().GetBool("Sad") == true)
            {
                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[4].SetColor("_Color", new Vector4(0, 0, 0, 0));
                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[6].SetColor("_Color", new Vector4(0, 0, 0, 1));

                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[1].SetColor("_Color", new Vector4(0, 0, 0, 0));
                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[3].SetColor("_Color", new Vector4(0, 0, 0, 1));


                gameObject.GetComponent<Animator>().SetBool("Sad", false);
            }

            else if (gameObject.GetComponent<Animator>().GetBool("Sad") == false)
            {
                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[6].SetColor("_Color", new Vector4(0, 0, 0, 0));
                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[4].SetColor("_Color", new Vector4(0, 0, 0, 1));

                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[3].SetColor("_Color", new Vector4(0, 0, 0, 0));
                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[1].SetColor("_Color", new Vector4(0, 0, 0, 1));


                gameObject.GetComponent<Animator>().SetBool("Sad", true);
            }
        }

        if (Input.GetKeyDown(KeyCode.P))
        {

            if (gameObject.GetComponent<Animator>().GetBool("Walk") == true)
            {
                gameObject.GetComponent<Animator>().SetBool("Walk", false);
            }

            else if (gameObject.GetComponent<Animator>().GetBool("Walk") == false)
            {

                gameObject.GetComponent<Animator>().SetBool("Walk", true);
            }
        }



    }
}
