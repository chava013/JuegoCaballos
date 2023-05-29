using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractuarOpciones : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject desplegado;
    private void OnMouseDown()
    {
        desplegado.SetActive(true);
       
    }

   
}
