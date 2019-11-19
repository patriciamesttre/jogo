using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Vertical")> 0)
        {
            transform.Translate(Vector3.forward * 0.5f);
        }

        if (Input.GetAxis("Vertical") > 0)
        {
            transform.Translate(Vector3.back * 0.5f);
        }

        if (Input.GetAxis("horizontal") > 0)
        {
            transform.Rotate(Vector3.up * 0.5f);
        }

        if (Input.GetAxis("horizontal") > 0)
        {
            transform.Rotate(Vector3.up * -0.5f);
        }


    }
}
