using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perdedor : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        int manzanas = PlayerPrefs.GetInt("CantidadManzanas") + 2;
        PlayerPrefs.SetInt("CantidadManzanas", manzanas);
    }


}
