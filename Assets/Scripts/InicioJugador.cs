using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioJugador : MonoBehaviour
{
    // Start is called before the first frame update

   

    GameObject jugador;
    public GameObject rival;
    GameObject rival2;
    int vel;

    int indexJugador;
    float grandex, grandey;
    // Update is called once per frame
    
    void Start()
    {
        indexJugador = PlayerPrefs.GetInt("JugadorIndex");
        jugador = Instantiate(GameManager.Instance.personajes[indexJugador].personajeJugable, transform.position, Quaternion.identity);
        vel = GameManager.Instance.personajes[indexJugador].vel;
        grandex=GameManager.Instance.personajes[indexJugador].grandex;
        grandey=GameManager.Instance.personajes[indexJugador].grandey;
        jugador.transform.localScale = new Vector2(grandex, grandey);
       rival2= Instantiate(rival, new Vector3(rival.transform.position.x, (float) 1.8, 0), Quaternion.identity);
        
       
    }
    void Update()
    {
        if (jugador.transform.position.x < -11)
        {
            SceneManager.LoadScene("Ganar");
        }
        if (rival.transform.position.x < -11 || rival2.transform.position.x < -11)
        {
            SceneManager.LoadScene("Perder");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {

            jugador.transform.position += Vector3.left * Time.deltaTime * (vel*3);
        }
        if(jugador.transform.position.y < -10)
        {
            SceneManager.LoadScene("Perder");
        }
       
    }
    public void Destruir()
    {
        Destroy(jugador);
        Destroy(rival);
    }

   
}
