using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPJ : MonoBehaviour {

    public float velocidad = 10f;
    public float velocidadMaxima = 5f;
    public bool enSuelo;
    public bool ataqueBasico;
    public float fuerzaSalto = 5f;

    private Rigidbody2D rigidbody2D;
    private Animator anim;

    // Use this for initialization
    void Start() {

        // la variable rigidbody2D hace referencia al rigidbody del componente asociado al script(inspector)
        rigidbody2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
       

        //Mathf.abs coge el valor absoluto para que no cuente negativo cuando se mueva a la izaquierda
        anim.SetFloat("Velocidad", Mathf.Abs(rigidbody2D.velocity.x));
        anim.SetBool("EnSuelo", enSuelo);//El primer EnSuelo es de la animacion el segundo es del script
        anim.SetBool("AtaqueBasico", ataqueBasico);
        }

    private void FixedUpdate()
    {
        //hay que documentarlo, me da pereza
        //no se el porque de horizontal
        float horizontal = Input.GetAxis("Horizontal");

        rigidbody2D.AddForce(Vector2.right * velocidad * horizontal);

        //Clamp nos limita por encima y por debajo los valores de la velocidad del eje X del rigidbody
        float velocidadLimite = Mathf.Clamp(rigidbody2D.velocity.x, -velocidadMaxima, velocidadMaxima);
        rigidbody2D.velocity = new Vector2(velocidadLimite, rigidbody2D.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ataqueBasico = true;
        }
        else ataqueBasico = false;

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (enSuelo == true)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, fuerzaSalto);
            }
        }
        



        Debug.Log(rigidbody2D.velocity.x);
        }

    }

