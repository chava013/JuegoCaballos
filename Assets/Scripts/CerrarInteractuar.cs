using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerrarInteractuar : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    public GameObject desplegado;
    public MovAleatorio []movimientoAleatorio;
    

    public void Cerrar()
    {
        desplegado.SetActive(false);
        if (movimientoAleatorio.Length > 0 )
        {
            for (int i = 0; i < movimientoAleatorio.Length; i++)
            {
                movimientoAleatorio[i].enabled = true;
              
            }
        }
    }
    
}
