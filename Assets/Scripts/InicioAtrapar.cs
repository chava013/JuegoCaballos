using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InicioAtrapar : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject jugador;
    int vel;

    int indexJugador;
    float grandex, grandey;

    public float moveSpeed = 5f, jumpSpeed = 3f, danio = 0;

    public bool isGrounded = false;
    public TextMeshProUGUI contTEXT;
    Rigidbody2D rbd;
    public Slider VidaSlider;
    public bool LETNUM = false;
    public GameObject gameover;
    public GameObject win;

    private bool mirandoDerecha = false;
    // Update is called once per frame

    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
        contTEXT.text = "20/0";
        indexJugador = PlayerPrefs.GetInt("JugadorIndex");
        jugador = Instantiate(GameManager.Instance.personajes[indexJugador].personajeJugable, transform.position, Quaternion.identity);
        vel = GameManager.Instance.personajes[indexJugador].vel;
        grandex = GameManager.Instance.personajes[indexJugador].grandex;
        grandey = GameManager.Instance.personajes[indexJugador].grandey;
        jugador.transform.localScale = new Vector2(grandex, grandey);
        jugador.transform.position = new Vector2(-1, -2);
        jugador.tag = "Player";
       


    }
    void Orientacion(float inputMovimiento)
    {
        if ((mirandoDerecha == true && inputMovimiento < 0) || (mirandoDerecha == false && inputMovimiento > 0))
        {
            mirandoDerecha = !mirandoDerecha;
            jugador.transform.localScale = new Vector2(-jugador.transform.localScale.x, jugador.transform.localScale.y);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float inputMovimiento = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.RightArrow))
        {
            jugador.transform.position += Vector3.right * Time.deltaTime * vel;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            jugador.transform.position += Vector3.left * Time.deltaTime * vel;
        }
        Orientacion(inputMovimiento);

        if (VidaSlider.value <= 0)
        {
            SceneManager.LoadScene("PerderAtrapar");

        }
        string cant = contTEXT.text.Substring(3);
        int.TryParse(cant, out int conta);
        if (conta == 20)
        {
            SceneManager.LoadScene("GanarAtrapar");
        }
    }

   /* private void OnCollisionEnter2D(Collision2D collision)
    {
       
       
            if (collision.collider.tag == "LETRA")
            {
                conta++;
                contTEXT.text = "20/" + conta.ToString();
               

            }
            else
            {
                if (collision.collider.tag == "NUMERO")
                {
                    VidaSlider.value -= danio;
                   
                }
            }
        

    }*/
}
