using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dough : MonoBehaviour
{
    public bool rolled_sc;
    public bool tomato_sc;
    public bool cheese_sc;
    public bool brocolli_sc;
    public bool mushroom_sc;
    public bool shrimp_sc;
    public bool baked_sc;
    public bool perfect_sc;
    public bool perfect_baked_sc;
    public bool handin_sc;
    public bool reset_sc;


    MeshRenderer mesh;
    Material mat;
    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "DoughBat")
        mat.color = new Color(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {



        if (GetComponent<Dough>().rolled_sc == true &&
            GetComponent<Dough>().tomato_sc == true &&
            GetComponent<Dough>().cheese_sc == true &&
            GetComponent<Dough>().brocolli_sc == true &&
            GetComponent<Dough>().mushroom_sc == true &&
            GetComponent<Dough>().shrimp_sc == true
            )
        {
            GetComponent<Dough>().perfect_sc = true;
        }
        else
        {
            GetComponent<Dough>().perfect_sc = false;
        }

        if (
        GetComponent<Dough>().perfect_sc == true &&
        GetComponent<Dough>().baked_sc == true
        )
        
        {
            GetComponent<Dough>().perfect_baked_sc = true;
        }
        else
        {
            GetComponent<Dough>().perfect_baked_sc = false;
        }




        if (GetComponent<Dough>().rolled_sc == true)
        {

                gameObject.GetComponent<Animator>().SetBool("rolled", true);

        }
        else if (GetComponent<Dough>().rolled_sc == false)

        {

                gameObject.GetComponent<Animator>().SetBool("rolled", false);

        }


        if (GetComponent<Dough>().baked_sc == true)
        {
    
                gameObject.GetComponent<Animator>().SetBool("baked", true);

            if (GetComponent<Dough>().perfect_sc == true)
            {
                transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials[6].SetColor("_Color", new Vector4(1, 1, 1, 1));
            }

            else if (GetComponent<Dough>().perfect_sc == false)
            {
                if (GetComponent<Dough>().shrimp_sc == true && GetComponent<Dough>().baked_sc == true)
                {
                    transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials[5].SetColor("_Color", new Vector4(0.8f, 0.8f, 0.8f, 1));
                }
                else if (GetComponent<Dough>().shrimp_sc == false)
                {
                    transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials[5].SetColor("_Color", new Vector4(0.8f, 0.8f, 0.8f, 0));
                }

                if (GetComponent<Dough>().mushroom_sc == true && GetComponent<Dough>().baked_sc == true)
                {
                    transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials[4].SetColor("_Color", new Vector4(0.8f, 0.8f, 0.8f, 1));
                }
                else if (GetComponent<Dough>().mushroom_sc == false)
                {
                    transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials[4].SetColor("_Color", new Vector4(0.8f, 0.8f, 0.8f, 0));
                }

                if (GetComponent<Dough>().brocolli_sc == true && GetComponent<Dough>().baked_sc == true)
                {
                    transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials[3].SetColor("_Color", new Vector4(0.8f, 0.8f, 0.8f, 1));
                }
                else if (GetComponent<Dough>().brocolli_sc == false)
                {
                    transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials[3].SetColor("_Color", new Vector4(0.8f, 0.8f, 0.8f, 0));
                }

                if (GetComponent<Dough>().cheese_sc == true && GetComponent<Dough>().baked_sc == true)
                {
                    transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials[2].SetColor("_Color", new Vector4(0.8f, 0.8f, 0.8f, 1));
                }
                else if (GetComponent<Dough>().cheese_sc == false)
                {
                    transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials[2].SetColor("_Color", new Vector4(0.8f, 0.8f, 0.8f, 0));
                }

                if (GetComponent<Dough>().tomato_sc == true && GetComponent<Dough>().baked_sc == true)
                {
                    transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials[1].SetColor("_Color", new Vector4(0.8f, 0.8f, 0.8f, 1));
                }
                else if (GetComponent<Dough>().tomato_sc == false)
                {
                    transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials[1].SetColor("_Color", new Vector4(0.8f, 0.8f, 0.8f, 0));
                }
                transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials[0].SetColor("_Color", new Vector4(0.8f, 0.8f, 0.8f, 1));
                transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials[6].SetColor("_Color", new Vector4(1, 1, 1, 0));

            }
        }

        else if (GetComponent<Dough>().baked_sc == false)

        {
            gameObject.GetComponent<Animator>().SetBool("baked", false);
            transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials[6].SetColor("_Color", new Vector4(1, 1, 1, 0));

            if (GetComponent<Dough>().shrimp_sc == true)
            {
                transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials[5].SetColor("_Color", new Vector4(1, 1, 1, 1));
            }
            else if (GetComponent<Dough>().shrimp_sc == false)
            {
                transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials[5].SetColor("_Color", new Vector4(0.8f, 0.8f, 0.8f, 0));
            }

            if (GetComponent<Dough>().mushroom_sc == true)
            {
                transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials[4].SetColor("_Color", new Vector4(1, 1, 1, 1));
            }
            else if (GetComponent<Dough>().mushroom_sc == false)
            {
                transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials[4].SetColor("_Color", new Vector4(0.8f, 0.8f, 0.8f, 0));
            }

            if (GetComponent<Dough>().brocolli_sc == true)
            {
                transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials[3].SetColor("_Color", new Vector4(1, 1, 1, 1));
            }
            else if (GetComponent<Dough>().brocolli_sc == false)
            {
                transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials[3].SetColor("_Color", new Vector4(0.8f, 0.8f, 0.8f, 0));
            }

            if (GetComponent<Dough>().cheese_sc == true)
            {
                transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials[2].SetColor("_Color", new Vector4(1, 1, 1, 1));
            }
            else if (GetComponent<Dough>().cheese_sc == false)
            {
                transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials[2].SetColor("_Color", new Vector4(0.8f, 0.8f, 0.8f, 0));
            }

            if (GetComponent<Dough>().tomato_sc == true)
            {
                transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials[1].SetColor("_Color", new Vector4(1, 1, 1, 1));
            }
            else if (GetComponent<Dough>().tomato_sc == false)
            {
                transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().materials[1].SetColor("_Color", new Vector4(0.8f, 0.8f, 0.8f, 0));
            }



        }

    }

}
