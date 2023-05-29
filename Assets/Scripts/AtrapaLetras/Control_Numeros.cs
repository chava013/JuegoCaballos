using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_Numeros : MonoBehaviour

{
    public InicioAtrapar Modjuego;
    bool modo;
    // Start is called before the first frame update
    void Start()
    {
        
        
        Modjuego = FindObjectOfType<InicioAtrapar>();
        modo = Modjuego.LETNUM;
       // Debug.Log(modo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        

                if (collision.collider.tag == "Player" )
                {
                    Modjuego.VidaSlider.value -= .05f;
                    Destroy(gameObject);
                }
                else
                {
                    if (collision.collider.tag == "Ground")
                    {

                        Destroy(gameObject);
                        //Modjuego.VidaSlider.value -= .05f;
                    }
                }
            
           
        


        
        
        
    }
}
