using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ambulancia : MonoBehaviour
{
    public float speed = 6;
    Rigidbody rig;
    void Start()
    {
        rig = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float f = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        float rot = Input.GetAxis("Horizontal") * 0.5f;

        transform.Translate(0, 0, f);

        //Rotar Dependendo da Direção que o Carro está indo, frente ou trás
        if(Input.GetAxisRaw("Vertical") > 0)
            transform.Rotate(0, rot, 0);
        if(Input.GetAxisRaw("Vertical") < 0)
            transform.Rotate(0, -rot, 0);


    }
}