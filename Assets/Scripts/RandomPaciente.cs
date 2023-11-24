using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomPaciente : MonoBehaviour
{
    GameObject escolhido;
    public GameObject posicao1;
    public GameObject posicao2;
    public GameObject posicao3;
    public GameObject posicao4;
    public GameObject posicao5;
    public GameObject entrega;

    public GameObject guia;

    bool pacienteUp = true;
    public float potencia = 1;
    public int maxPacientes = 10;
    int random, qtdPacientes = -1;
    void Start()
    {
        escolhido = entrega;
    }

    // Update is called once per frame
    void Update()
    {
        guia.transform.position = escolhido.transform.position;
        if (qtdPacientes >= maxPacientes)
        {
            //SceneManager.LoadScene("Fim de Jogo");
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "PacientePick" && pacienteUp == false)
        {
            VerificarPick(collider.gameObject);
        }
        else if(collider.gameObject.tag == "Entrega" && pacienteUp == true)
        {
            pacienteUp = false;
            StartCoroutine(RandomizarLocal());
        }
        else if(collider.gameObject.tag == "Gasolina")
        {
            gameObject.GetComponent<Ambulancia>().gasolina = 100;
        }
    }

    IEnumerator RandomizarLocal()
    {
        yield return new WaitForSeconds(0.1f);
        qtdPacientes++;
        random = Random.Range(1, 6);
        
        switch(random)
        {
            case 1:
                escolhido = posicao1;
                yield break;
            case 2:
                escolhido = posicao2;
                yield break;
            case 3:
                escolhido = posicao3;
                yield break;
            case 4:
                escolhido = posicao4;
                yield break;
            case 5:
                escolhido = posicao5;
                yield break;
        }
    }

    void VerificarPick(GameObject col)
    {
        if (escolhido.name == col.name)
        {
            pacienteUp = true;
            escolhido = entrega;
        }
    }
}
