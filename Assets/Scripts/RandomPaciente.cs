using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPaciente : MonoBehaviour
{
    GameObject escolhido;
    public GameObject posicao1;
    public GameObject posicao2;
    public GameObject posicao3;
    public GameObject posicao4;
    public GameObject posicao5;

    public GameObject guia;

    bool pacienteUp = true;
    int random;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "PacientePick" && pacienteUp == false)
        {
            pacienteUp = true;
            VerificarPick(collider.gameObject);
        }
        else if(collider.gameObject.tag == "Entrega" && pacienteUp == true)
        {
            pacienteUp = false;
            StartCoroutine(RandomizarLocal());
        }
    }

    IEnumerator RandomizarLocal()
    {
        yield return new WaitForSeconds(0.1f);
        random = Random.Range(1, 6);
        
        switch(random)
        {
            case 1:
                escolhido = posicao1;
                print("1");
                yield break;
            case 2:
                escolhido = posicao2;
                print("2");
                yield break;
            case 3:
                escolhido = posicao3;
                print("3");
                yield break;
            case 4:
                escolhido = posicao4;
                print("4");
                yield break;
            case 5:
                escolhido = posicao5;
                print("5");
                yield break;
        }
    }

    void VerificarPick(GameObject col)
    {
        if(escolhido.name == col.name)
        {
            pacienteUp = true;
        }
    }
}
