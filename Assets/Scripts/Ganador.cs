using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ganador : MonoBehaviour
{
    // Start is called before the first frame update



    // Update is called once per frame
    private void Start()
    {
        int manzanas = PlayerPrefs.GetInt("CantidadManzanas") + 10;
        PlayerPrefs.SetInt("CantidadManzanas", manzanas);
    }
}
