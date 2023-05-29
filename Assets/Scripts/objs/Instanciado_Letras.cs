using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciado_Letras : MonoBehaviour
{
    public Transform pos;
    public GameObject[] LetrastoInstantiate;
    int obj;
    float x;
    private float _timer;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        InstanciarLetras();
    }
    private void InstanciarLetras()
    {
        _timer += Time.deltaTime;
        if (_timer >=1.3f)
        {


            obj = Random.Range(0, LetrastoInstantiate.Length);
            x = Random.Range(-8.3f, 8.3f);
            Instantiate(LetrastoInstantiate[obj], new Vector3((float)x, 7, 0), LetrastoInstantiate[obj].transform.rotation);
            _timer = 0;
        }
    }
}
