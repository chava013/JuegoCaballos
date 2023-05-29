using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Corral : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] jugador;
    public GameObject hacks;
    int indexJugador;
    float grandex, grandey;
    [SerializeField] TextMeshProUGUI txtmanzanas;

    void Start()
    {
        indexJugador = GameManager.Instance.personajes.Count;
        txtmanzanas.text = PlayerPrefs.GetInt("CantidadManzanas").ToString();
        // indexJugador = PlayerPrefs.GetInt("JugadorIndex");
        for(int i=0; i<indexJugador; i++)
        {
            grandex = GameManager.Instance.personajes[i].grandex;
            grandey = GameManager.Instance.personajes[i].grandey;
            jugador[i].transform.localScale = new Vector2(grandex, grandey);
        }
       
    }
    private void Update()
    {
        if(Input.GetKey(KeyCode.Tab))
        {
            hacks.SetActive(true);
        }
        if (Input.GetKey(KeyCode.Backspace))
        {
            hacks.SetActive(false);
        }

    }

    // Update is called once per frame

}
