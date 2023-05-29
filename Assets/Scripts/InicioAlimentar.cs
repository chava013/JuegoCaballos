using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class InicioAlimentar : MonoBehaviour
{
    // Start is called before the first frame update

   
    
    GameObject jugador;
    [SerializeField] TextMeshProUGUI txtexp;
    [SerializeField] TextMeshProUGUI txtexpreq;
    [SerializeField] TextMeshProUGUI txtvel;
    [SerializeField] TextMeshProUGUI txtmanzanas;
    [SerializeField] TextMeshProUGUI txtnombre;
    [SerializeField] TextMeshProUGUI txtorigen;
    [SerializeField] TextMeshProUGUI txtdesc;
    [SerializeField] Image imgreal;
    [SerializeField] Button info;

    int indexJugador;
    int manzanas;
    // Update is called once per frame
    
    void Start()
    {
      
        indexJugador = PlayerPrefs.GetInt("JugadorIndex");
        manzanas = PlayerPrefs.GetInt("CantidadManzanas");
        jugador = Instantiate(GameManager.Instance.personajes[indexJugador].personajeJugable, transform.position, Quaternion.identity);
        jugador.transform.localScale = new Vector2(GameManager.Instance.personajes[indexJugador].grandex, GameManager.Instance.personajes[indexJugador].grandey);
        Info();
        Mostrar();
        
       
    }
   
   

    public void Subir_Exp()
    {
        if (GameManager.Instance.personajes[indexJugador].vel < 20)
        {

            manzanas -= 1;

            if(manzanas>=0)
            {
                PlayerPrefs.SetInt("CantidadManzanas", manzanas);
                GameManager.Instance.personajes[indexJugador].exp += 10;


                if (GameManager.Instance.personajes[indexJugador].exp >= GameManager.Instance.personajes[indexJugador].exp_max)
                {
                    GameManager.Instance.personajes[indexJugador].vel++;

                    GameManager.Instance.personajes[indexJugador].exp_max = Mathf.RoundToInt(GameManager.Instance.personajes[indexJugador].exp_max * 1.3f);
                    GameManager.Instance.personajes[indexJugador].grandex += 0.1f;
                    GameManager.Instance.personajes[indexJugador].grandey += 0.1f;
                    jugador.transform.localScale = new Vector2(GameManager.Instance.personajes[indexJugador].grandex, GameManager.Instance.personajes[indexJugador].grandey);

                }
                Mostrar();
            }
        }

        Info();
           
       
    }
    public void Info()
    {
        if (GameManager.Instance.personajes[indexJugador].vel > 14)
        {
            info.enabled = true;
        }
        else
            info.enabled = false;
    }
    private void Update()
    {

        if (GameManager.Instance.personajes[indexJugador].vel == 20)
            txtexpreq.text = "0";
    }
    public void Mostrar()
    {
        txtexp.text = GameManager.Instance.personajes[indexJugador].exp.ToString();
        txtvel.text = GameManager.Instance.personajes[indexJugador].vel.ToString();
        txtexpreq.text = GameManager.Instance.personajes[indexJugador].exp_max.ToString();
        txtmanzanas.text = manzanas.ToString();
        txtdesc.text = GameManager.Instance.personajes[indexJugador].desc;
        txtnombre.text = GameManager.Instance.personajes[indexJugador].nombre;
        txtorigen.text = GameManager.Instance.personajes[indexJugador].origen;
        imgreal.sprite = GameManager.Instance.personajes[indexJugador].real;
    }

}
