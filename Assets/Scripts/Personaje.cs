using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NuevoPersonaje", menuName = "Personaje")]
public class Personaje : ScriptableObject
{
    public GameObject personajeJugable;
    public Sprite imagen;
    public Sprite real;


    public string nombre;
    public string origen;
    public string desc;


    public int exp;
    public int exp_max;

    public float grandex;
    public float grandey;


    public int vel;

    

}
