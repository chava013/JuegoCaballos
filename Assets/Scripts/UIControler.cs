using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIControler : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject informacion;
    public GameObject alimentar;
   
        
    public void Jugar()
    {
        SceneManager.LoadScene("EscogerPersonaje");
    }
    public void Corral()
    {
        SceneManager.LoadScene("Corral");
    }
    public void Juego()
    {
        SceneManager.LoadScene("Juego");
    }

    public void EscogerAlimentar()
    {
        SceneManager.LoadScene("EscogerAlimentar");
    }

    public void EscogerAtrapar()
    {
        SceneManager.LoadScene("EscogerAtrapa");
    }
    public void Atrapar()
    {
        SceneManager.LoadScene("AtrapaLetras");
    }

    public void CanvasAlimentar()
    {
        alimentar.SetActive(true);
        informacion.SetActive(false);
    }
    public void CanvasInfo()
    {
        alimentar.SetActive(false);
        informacion.SetActive(true);
    }
    public void Minijuegos()
    {
        SceneManager.LoadScene("Minijuegos");
    }
}
