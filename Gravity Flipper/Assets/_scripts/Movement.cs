using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed = 10f;
    public GameObject Proj;
    public Transform ts1, ts2;
    Rigidbody rb;
    public bool gravityReversed = false;


    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        //transform.Translate(1f * Time.deltaTime * speed, 0, 0, Space.World);
        //print(Input.GetAxis("Horizontal"));
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gravityReversed = !gravityReversed;
        }
        
        float hAxis = Input.GetAxis("Horizontal");
        rb.transform.Translate((hAxis * Time.fixedDeltaTime * speed), 0, 0, Space.World);
        Vector3 movement = new Vector3(hAxis, 0f, 0f);
        if (movement != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(movement);
        }
        
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
           
            GameObject go1 = (GameObject)Instantiate(Proj, ts1.position, ts1.rotation);
            GameObject go2 = (GameObject)Instantiate(Proj, ts2.position, ts2.rotation);

        }
    }



    void FixedUpdate()
    {
        if (gravityReversed)
        {
            rb.AddForce(Vector3.up);
            /* if (!isFlipped)
            {

                GameObject.Find("Empty").transform.Rotate(180, 0, 0);
                isFlipped = true;
            } */
        }
        else {
            rb.AddForce(-Vector3.up);
            /* if (isFlipped)
            {
                GameObject.Find("Empty").transform.Rotate(180, 0, 0);
                isFlipped = false;
            } */
        }
    }
}
