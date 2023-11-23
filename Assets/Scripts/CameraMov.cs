using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMov : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Mouse X") > 0)
        {
            transform.Rotate(0, Time.deltaTime * 0.5f, 0);
        }
        if (Input.GetAxis("Mouse X") < 0)
        {
            transform.Rotate(0, -(Time.deltaTime * 0.5f), 0);
        }
        if (Input.GetAxis("Mouse Y") > 0)
        {
            transform.Rotate(0, 0, Time.deltaTime * 0.5f);
        }
        if (Input.GetAxis("Mouse Y") < 0)
        {
            transform.Rotate(0, 0, -(Time.deltaTime * 0.5f));
        }
    }
}
