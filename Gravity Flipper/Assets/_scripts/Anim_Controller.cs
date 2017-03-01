using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim_Controller : MonoBehaviour {

    public Animator anim;
    public float InpH;

    // Use this for initialization
    void Start ()
    {
        anim = GetComponent<Animator>();
	}

    // Update is called once per frame

    void Update ()
    {

        /*
        if (Input.GetAxis("Horizontal") != 0)
        {
            anim.Play("RUN00_F");
        }
        
        if (Input.GetKeyDown("1"))
        {
            anim.Play("REFLESH00");
        }
        */

        InpH = Input.GetAxis("Horizontal");
        anim.SetFloat("inputtH", InpH);

    }
}
