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
        float v = Input.GetAxis("Mouse X") * 100 * Time.deltaTime;
        float h = Input.GetAxis("Mouse Y") * 100 * Time.deltaTime;
        transform.Rotate(-h, v, 0);
        if (Input.GetButtonDown("Jump"))
        {
            transform.Rotate(0, 180, 0);
        }
        else if (Input.GetButtonUp("Jump"))
        {;
            transform.Rotate(0, 180, 0);
        }
        if (Input.GetButtonDown("Fire1"))
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
/*if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKey(KeyCode.UpArrow))
{
    transform.Rotate(-100*Time.deltaTime, 0, 0);
}
if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKey(KeyCode.DownArrow))
{
    transform.Rotate(100 * Time.deltaTime, 0, 0);
}
if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKey(KeyCode.RightArrow))
{
    transform.Rotate(0, 100 * Time.deltaTime, 0);
}
if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKey(KeyCode.LeftArrow))
{
    transform.Rotate(0, -100 * Time.deltaTime, 0);
}*/
    }
}
