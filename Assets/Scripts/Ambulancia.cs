using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ambulancia : MonoBehaviour
{
    public float speed = 6;
    float potencia;
    public float gasolina;
    float gasolinaMax = 100;
    Rigidbody rig;

    // HUDs do combustível
    public GameObject cem;
    public GameObject noventa;
    public GameObject oitenta;
    public GameObject setenta;
    public GameObject sessenta;
    public GameObject cinqueta;
    public GameObject quarenta;
    public GameObject trinta;
    public GameObject vinte;
    public GameObject dez;
    public GameObject zero;

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
        float rot = Input.GetAxis("Horizontal") * 0.4f;

        /*if(Input.GetAxis("Vertical") > 0)
        {
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(transform.rotation.x -100, 0, 0);
        }
        else if(Input.GetAxis("Vertical") < 0)
        {
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(30, 0, 0);
        }*/

        gameObject.GetComponent<Rigidbody>().velocity = transform.forward * f * 60;
        //transform.Translate(0, 0, f);

        //Rotar Dependendo da Direção que o Carro está indo, frente ou trás
        if(Input.GetAxisRaw("Vertical") > 0 && speed != 0)
        {
            transform.Rotate(0, rot, 0);
            speed = 75;
        }
            
        if(Input.GetAxisRaw("Vertical") < 0 && speed != 0)
        {
            transform.Rotate(0, -rot, 0);
            speed = 30;
        }

        if (gasolina == 100)
        {
            cem.SetActive(true);
            noventa.SetActive(false);
            oitenta.SetActive(false);
            setenta.SetActive(false);
            sessenta.SetActive(false);
            cinqueta.SetActive(false);
            quarenta.SetActive(false);
            trinta.SetActive(false);
            vinte.SetActive(false);
            dez.SetActive(false);
            zero.SetActive(false);
        }

        if (gasolina == 90)
        {
            cem.SetActive(false);
            noventa.SetActive(true);
            oitenta.SetActive(false);
            setenta.SetActive(false);
            sessenta.SetActive(false);
            cinqueta.SetActive(false);
            quarenta.SetActive(false);
            trinta.SetActive(false);
            vinte.SetActive(false);
            dez.SetActive(false);
            zero.SetActive(false);
        }

        if (gasolina == 80)
        {
            cem.SetActive(false);
            noventa.SetActive(false);
            oitenta.SetActive(true);
            setenta.SetActive(false);
            sessenta.SetActive(false);
            cinqueta.SetActive(false);
            quarenta.SetActive(false);
            trinta.SetActive(false);
            vinte.SetActive(false);
            dez.SetActive(false);
            zero.SetActive(false);
        }

        if (gasolina == 70)
        {
            cem.SetActive(false);
            noventa.SetActive(false);
            oitenta.SetActive(false);
            setenta.SetActive(true);
            sessenta.SetActive(false);
            cinqueta.SetActive(false);
            quarenta.SetActive(false);
            trinta.SetActive(false);
            vinte.SetActive(false);
            dez.SetActive(false);
            zero.SetActive(false);
        }

        if (gasolina == 60)
        {
            cem.SetActive(false);
            noventa.SetActive(false);
            oitenta.SetActive(false);
            setenta.SetActive(false);
            sessenta.SetActive(true);
            cinqueta.SetActive(false);
            quarenta.SetActive(false);
            trinta.SetActive(false);
            vinte.SetActive(false);
            dez.SetActive(false);
            zero.SetActive(false);
        }

        if (gasolina == 50)
        {
            cem.SetActive(false);
            noventa.SetActive(false);
            oitenta.SetActive(false);
            setenta.SetActive(false);
            sessenta.SetActive(false);
            cinqueta.SetActive(true);
            quarenta.SetActive(false);
            trinta.SetActive(false);
            vinte.SetActive(false);
            dez.SetActive(false);
            zero.SetActive(false);
        }

        if (gasolina == 40)
        {
            cem.SetActive(false);
            noventa.SetActive(false);
            oitenta.SetActive(false);
            setenta.SetActive(false);
            sessenta.SetActive(false);
            cinqueta.SetActive(false);
            quarenta.SetActive(true);
            trinta.SetActive(false);
            vinte.SetActive(false);
            dez.SetActive(false);
            zero.SetActive(false);
        }

        if (gasolina == 30)
        {
            cem.SetActive(false);
            noventa.SetActive(false);
            oitenta.SetActive(false);
            setenta.SetActive(false);
            sessenta.SetActive(false);
            cinqueta.SetActive(false);
            quarenta.SetActive(false);
            trinta.SetActive(true);
            vinte.SetActive(false);
            dez.SetActive(false);
            zero.SetActive(false);
        }

        if (gasolina == 20)
        {
            cem.SetActive(false);
            noventa.SetActive(false);
            oitenta.SetActive(false);
            setenta.SetActive(false);
            sessenta.SetActive(false);
            cinqueta.SetActive(false);
            quarenta.SetActive(false);
            trinta.SetActive(false);
            vinte.SetActive(true);
            dez.SetActive(false);
            zero.SetActive(false);
        }

        if (gasolina == 10)
        {
            cem.SetActive(false);
            noventa.SetActive(false);
            oitenta.SetActive(false);
            setenta.SetActive(false);
            sessenta.SetActive(false);
            cinqueta.SetActive(false);
            quarenta.SetActive(false);
            trinta.SetActive(false);
            vinte.SetActive(false);
            dez.SetActive(true);
            zero.SetActive(false);
        }

        if (gasolina == 0)
        {
            cem.SetActive(false);
            noventa.SetActive(false);
            oitenta.SetActive(false);
            setenta.SetActive(false);
            sessenta.SetActive(false);
            cinqueta.SetActive(false);
            quarenta.SetActive(false);
            trinta.SetActive(false);
            vinte.SetActive(false);
            dez.SetActive(false);
            zero.SetActive(true);
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