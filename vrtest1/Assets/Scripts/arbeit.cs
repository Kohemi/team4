using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arbeit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.H))
        {

            if (gameObject.GetComponent<Animator>().GetBool("dance") == true)
            {
                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[5].SetColor("_Color", new Vector4(0, 0, 0, 0));
                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[6].SetColor("_Color", new Vector4(0, 0, 0, 1));

                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[2].SetColor("_Color", new Vector4(0, 0, 0, 0));
                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[3].SetColor("_Color", new Vector4(0, 0, 0, 1));


                gameObject.GetComponent<Animator>().SetBool("dance", false);
            }

            else if (gameObject.GetComponent<Animator>().GetBool("dance") == false)
            {



                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[6].SetColor("_Color", new Vector4(0, 0, 0, 0));
                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[5].SetColor("_Color", new Vector4(0, 0, 0, 1));

                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[3].SetColor("_Color", new Vector4(0, 0, 0, 0));
                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[2].SetColor("_Color", new Vector4(0, 0, 0, 1));


                gameObject.GetComponent<Animator>().SetBool("dance", true);

            }
        }

        if (Input.GetKeyDown(KeyCode.J))
        {

            if (gameObject.GetComponent<Animator>().GetBool("happy") == true)
            {

                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[5].SetColor("_Color", new Vector4(0, 0, 0, 0));
                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[6].SetColor("_Color", new Vector4(0, 0, 0, 1));

                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[0].SetColor("_Color", new Vector4(0, 0, 0, 0));
                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[3].SetColor("_Color", new Vector4(0, 0, 0, 1));


                gameObject.GetComponent<Animator>().SetBool("happy", false);
            }

            else if (gameObject.GetComponent<Animator>().GetBool("happy") == false)
            {

                gameObject.GetComponent<Animator>().SetBool("happy", true);


                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[6].SetColor("_Color", new Vector4(0, 0, 0, 0));
                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[5].SetColor("_Color", new Vector4(0, 0, 0, 1));

                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[3].SetColor("_Color", new Vector4(0, 0, 0, 0));
                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[0].SetColor("_Color", new Vector4(0, 0, 0, 1));

            }
        }

        if (Input.GetKeyDown(KeyCode.K))
        {

            if (gameObject.GetComponent<Animator>().GetBool("sad") == true)
            {
                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[4].SetColor("_Color", new Vector4(0, 0, 0, 0));
                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[6].SetColor("_Color", new Vector4(0, 0, 0, 1));

                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[1].SetColor("_Color", new Vector4(0, 0, 0, 0));
                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[3].SetColor("_Color", new Vector4(0, 0, 0, 1));


                gameObject.GetComponent<Animator>().SetBool("sad", false);
            }

            else if (gameObject.GetComponent<Animator>().GetBool("sad") == false)
            {
                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[6].SetColor("_Color", new Vector4(0, 0, 0, 0));
                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[4].SetColor("_Color", new Vector4(0, 0, 0, 1));

                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[3].SetColor("_Color", new Vector4(0, 0, 0, 0));
                transform.GetChild(0).GetChild(1).GetChild(3).GetComponent<SkinnedMeshRenderer>().materials[1].SetColor("_Color", new Vector4(0, 0, 0, 1));


                gameObject.GetComponent<Animator>().SetBool("sad", true);
            }
        }

        if (Input.GetKeyDown(KeyCode.L))
        {

            if (gameObject.GetComponent<Animator>().GetBool("dance2") == true)
            {
                gameObject.GetComponent<Animator>().SetBool("dance2", false);
            }

            else if (gameObject.GetComponent<Animator>().GetBool("dance2") == false)
            {

                gameObject.GetComponent<Animator>().SetBool("dance2", true);
            }
        }



    }
}
