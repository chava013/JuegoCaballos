using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class InicioCrecer : MonoBehaviour
{
    // Start is called before the first frame update

   
    
    GameObject jugador;
    [SerializeField] TextMeshProUGUI txtexp;
    [SerializeField] TextMeshProUGUI txtexpreq;
    [SerializeField] TextMeshProUGUI txtvel;


    int indexJugador;
    // Update is called once per frame
    
    void Start()
    {
        indexJugador = PlayerPrefs.GetInt("JugadorIndex");
        jugador = Instantiate(GameManager.Instance.personajes[indexJugador].personajeJugable, transform.position, Quaternion.identity);
        jugador.transform.localScale = new Vector2(GameManager.Instance.personajes[indexJugador].grandex, GameManager.Instance.personajes[indexJugador].grandey);
       
    }
   
   

    public void Subir_Exp()
    {

          
            GameManager.Instance.personajes[indexJugador].exp+=10; 

        
        if(GameManager.Instance.personajes[indexJugador].exp >= GameManager.Instance.personajes[indexJugador].exp_max )
        {
            GameManager.Instance.personajes[indexJugador].vel++;

            GameManager.Instance.personajes[indexJugador].exp_max = Mathf.RoundToInt(GameManager.Instance.personajes[indexJugador].exp_max * 1.3f);
        }
        Mostrar();
    }
    public void Mostrar()
    {
        txtexp.text = GameManager.Instance.personajes[indexJugador].exp.ToString();
        txtvel.text = GameManager.Instance.personajes[indexJugador].vel.ToString();
        txtexpreq.text = GameManager.Instance.personajes[indexJugador].exp_max.ToString();
    }

}
