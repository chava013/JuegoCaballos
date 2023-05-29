using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovAleatorio : MonoBehaviour
{
    // Start is called before the first frame update
    int direccion, vel = 1;
    private bool mirandoDerecha = false;
    private Animator animator;
    public GameObject desplegado;
    public MovAleatorio[] movimientoAleatorio;
    float grandex, grandey;
    int indexJugador;
    


    private void OnMouseDown()
    {
        desplegado.SetActive(true);
        if(movimientoAleatorio.Length>0)
        {
            for(int i=0; i<movimientoAleatorio.Length; i++)
            {
                movimientoAleatorio[i].enabled = false;
               
            }
        }

    }

    void Start()
    {
        
        direccion = Random.Range(1, 6);
        animator = GetComponent<Animator>();
        InvokeRepeating("CambiarDireccion", 5, 5);
       
    }

    public void CambiarDireccion()
    {
        direccion = Random.Range(1, 6);
    }

    // Update is called once per frame

    
    private void FixedUpdate()
    {
       

        switch (direccion)
        {
            case 1:
                transform.position += Vector3.left * Time.deltaTime * vel;
                if (mirandoDerecha)
                {
                    mirandoDerecha = !mirandoDerecha;
                    transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
                    animator.SetBool("isGoingUp", false);
                    animator.SetBool("isGoingDown", false);
                }
               
                break;
            case 2:
                transform.position += Vector3.up * Time.deltaTime * vel;
                animator.SetBool("isGoingUp", true);
                animator.SetBool("isGoingDown", false);
                break;
            case 3:
                transform.position += Vector3.down * Time.deltaTime * vel;
                animator.SetBool("isGoingDown", true);
                animator.SetBool("isGoingUp", false);
                break;
            case 4:
                transform.position += Vector3.right * Time.deltaTime * vel;
                if (!mirandoDerecha)
                {
                    mirandoDerecha = !mirandoDerecha;
                    transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
                    animator.SetBool("isGoingUp", false);
                    animator.SetBool("isGoingDown", false);
                }
              
                break;
            case 5:
                transform.position += Vector3.zero;
                break;

        }
      
       
    }
    
  
}
