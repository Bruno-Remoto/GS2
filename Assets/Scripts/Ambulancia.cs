using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ambulancia : MonoBehaviour
{
    public float speed = 6;
    float potencia;
    float gasolina, gasolinaMax = 100;
    Rigidbody rig;
    void Start()
    {
        StartCoroutine(GastarGasosa());
        gasolina = 100;
        rig = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gasolina <= 0)
        {
            speed = 0;
        }
        potencia = gameObject.GetComponent<RandomPaciente>().potencia;

        float f = Input.GetAxis("Vertical") * Time.deltaTime * speed * potencia;
        float rot = Input.GetAxis("Horizontal") * 0.7f;

        transform.Translate(0, 0, f);

        //Rotar Dependendo da Direção que o Carro está indo, frente ou trás
        if(Input.GetAxisRaw("Vertical") > 0 && speed != 0)
        {
            transform.Rotate(0, rot, 0);
            speed = 100;
        }
            
        if(Input.GetAxisRaw("Vertical") < 0 && speed != 0)
        {
            transform.Rotate(0, -rot, 0);
            speed = 30;
        }


    }

    IEnumerator GastarGasosa()
    {
        yield return new WaitForSeconds(2);
        gasolina -= 2 * potencia;
        print(gasolina);
        if (gasolina >= 0)
            StartCoroutine(GastarGasosa());
    }
}