using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beacon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 7 * 7 * Time.deltaTime, 0);
    }
}
