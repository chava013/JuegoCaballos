using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuPausa : MonoBehaviour
{
    
    public GameObject botonPause;
    public GameObject menuPausa;
    public GameObject menuInicio;
    private void Start()
    {
       // Time.timeScale = 0f;
       // botonPause.SetActive(false);
       // menuPausa.SetActive(false);
       // menuInicio.SetActive(true);
    }
    public void Pausa()
    {
        Time.timeScale = 0f;
        botonPause.SetActive(false);
        menuPausa.SetActive(true);
    }
    public void Reanudar()
    {
        Time.timeScale = 1f;
        botonPause.SetActive(true);
        menuPausa.SetActive(false);
    }
    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
    public void Salir()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Corral");

    }
    public void Inicio()
    {
        Time.timeScale = 1f;
        botonPause.SetActive(true);
        //menuPausa.SetActive(false);
        menuInicio.SetActive(false);
    }
}
