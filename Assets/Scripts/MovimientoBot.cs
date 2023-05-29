using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBot : MonoBehaviour
{
    // Start is called before the first frame update
    int vel;
    
    void Start()
    {
        vel = Random.Range(1, 3);
        transform.position += Vector3.left * Time.deltaTime * vel;
      //  InvokeRepeating("Velocidad", 5, 3);
    }

    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("Velocidad", 0, 4);
    }
    public void Velocidad()
    {
        if (transform.position.x > -11)
        {
            vel = Random.Range(1, 3);
        }
        else
        {
            vel = 0;

        }

        transform.position += Vector3.left * Time.deltaTime * vel;


    
}
}
