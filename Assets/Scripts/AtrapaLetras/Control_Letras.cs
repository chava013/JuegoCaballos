using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Control_Letras : MonoBehaviour
{
    public InicioAtrapar Modjuego;
    bool modo;
   
    // Start is called before the first frame update
    void Start()
    {


        Modjuego = FindObjectOfType<InicioAtrapar>();
        

      //  Debug.Log(modo);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {


            if (collision.collider.tag == "Player")
            {
                
                string cant = Modjuego.contTEXT.text.Substring(3);
                int.TryParse(cant, out int conta);
                Modjuego.contTEXT.text = "20/" + (conta+1).ToString();
                Destroy(gameObject);
            }
            else
            {
                if (collision.collider.tag == "Ground")
                {

                    Destroy(gameObject);
                    Modjuego.VidaSlider.value -= .05f;
                }
            }
        
       





    }
}
