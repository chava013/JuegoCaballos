using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador_Numeros : MonoBehaviour
{
    //public Transform pos;
    public GameObject[] NumberstoInstantiate;
    int obj;
    float x;
    private float _timer;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        InstanciarNumeros();
    }
    private void InstanciarNumeros()
    {
        _timer += Time.deltaTime;
        if (_timer >= 1.3f)
        {


            obj = Random.Range(0, NumberstoInstantiate.Length);
            x = Random.Range(-8.3f, 8.3f);
            Instantiate(NumberstoInstantiate[obj], new Vector3((float)x, 7, 0), NumberstoInstantiate[obj].transform.rotation);
            _timer = 0;
        }
    }
}
