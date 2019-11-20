using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Player : NetworkBehaviour
{
    public Material[] skin;

    // Start is called before the first frame update
    void Start()
    {
        int n = Random.Range(0, skin.Length);
        this.gameObject.GetComponent<Renderer>().material = skin[n];
    }

    // Update is called once per frame
    void Update()
    {
        if (isLocalPlayer)
        {
            if (Input.GetAxis("Vertical") > 0)
            {
                transform.Translate(Vector3.forward * 0.05f);
            }

            if (Input.GetAxis("Vertical") < 0)
            {
                transform.Translate(Vector3.back * 0.05f);
            }

            if (Input.GetAxis("Horizontal") > 0)
            {
                transform.Rotate(Vector3.up * 0.5f);
            }

            if (Input.GetAxis("Horizontal") < 0)
            {
                transform.Rotate(Vector3.up * -0.5f);
            }





        }
    }
}
