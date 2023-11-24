using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    public GameObject creditos;
    public GameObject pause;
    public bool pausado;

    public void Jogar()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Sair()
    {
        Application.Quit();
    }

    public void Creditos()
    {
        creditos.SetActive(true);
    }

    public void VoltarCreditos()
    {
        creditos.SetActive(false);
    }

    public void VoltarPause()
    {
        pause.SetActive(false);
        pausado = false;
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(pausado == true)
            {
                pause.SetActive(false);
                pausado = false;
                Time.timeScale = 1;
            }
            else 
            {
                pause.SetActive(true);
                pausado = true;
                Time.timeScale = 0;
            }
            
        }
    }
}
