using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Hacks : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject hacks;
    [SerializeField] TextMeshProUGUI txtmanzanas;

    public void Veinte()
    {
        
        PlayerPrefs.SetInt("CantidadManzanas", 20);
        txtmanzanas.text = "20";
    }
    public void Mil()
    {
        PlayerPrefs.SetInt("CantidadManzanas", 1000);
        txtmanzanas.text = "1000";
    }
    public void Recuperar()
    {
        int manzanas = PlayerPrefs.GetInt("NormalManzanas");
        PlayerPrefs.SetInt("CantidadManzanas", manzanas);
        txtmanzanas.text = manzanas.ToString();
    }
    public void Guardar()
    {
        int manzanas = PlayerPrefs.GetInt("CantidadManzanas");
        PlayerPrefs.SetInt("NormalManzanas", manzanas);
        txtmanzanas.text = manzanas.ToString();
    }

}
