using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    
    public float moveSpeed = 5f, jumpSpeed = 3f, danio = 0;
    
    public bool isGrounded = false;
    public TextMeshProUGUI contTEXT;
    int conta = 0;
    Rigidbody2D rbd;
    public Slider VidaSlider;
    public bool LETNUM=false;
    public GameObject gameover;
    public GameObject win;
    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
        contTEXT.text = "20/0";
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("d")|| Input.GetKey("right") )
        {
            rbd.velocity = new Vector2(moveSpeed, rbd.velocity.y);
        }else if (Input.GetKey("a") || Input.GetKey("left") )
        {
            rbd.velocity = new Vector2(-moveSpeed, rbd.velocity.y);
        }
        else
        {
            rbd.velocity = new Vector2(0, rbd.velocity.y);
        }
        if (Input.GetKey("space") && CheckGround.isGrounded)
        {
            rbd.velocity = new Vector2(rbd.velocity.x, jumpSpeed);
        }

        if (VidaSlider.value <= 0)
        {
            gameover.SetActive(true);
            Time.timeScale = 0f;
            Destroy(gameObject);
            
        }
        if (conta == 20)
        {
            win.SetActive(true);
            Time.timeScale = 0f;
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (LETNUM==false)
        {
            if (collision.collider.tag == "NUMERO")
            {
                conta++;
                contTEXT.text = "20/"+conta.ToString();

            }
            else
            {
                if (collision.collider.tag == "LETRA")
                {
                    VidaSlider.value -= danio;
                }
            }
        }
        else
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
        }
        
    }
}
