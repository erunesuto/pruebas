using UnityEngine;

public class ScrollCopia : MonoBehaviour
{

    public bool IniciarEnMovimiento = false;
    public float velocidad = 0f;
    private bool enMovimiento = false;
    //private float tiempoInicio = 0f;
    public int limiteAumentoVelocidad = 5;
    private float posicion=0;

    // Use this for initialization
    void Start()
    {
        NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeEmpiezaACorrer");
        NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");
        //simula que el pj esta en movimiento para que empiece el scroll suave y no con un movimiento brusco
        if (IniciarEnMovimiento)
        {
            PersonajeEmpiezaACorrer();
        }
    }

    void PersonajeHaMuerto()
    {
        enMovimiento = false;
    }

    void PersonajeEmpiezaACorrer()
    {
        enMovimiento = true;
        //tiempoInicio es el tiempo actual, en el que el pj empieza a moverse
        //tiempoInicio = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        
        

        if (enMovimiento)
        {
            //deltaTime The time in seconds it took to complete the last frame (Read Only).
            aumentoVelocidadScroll();
            posicion += velocidad * Time.deltaTime;
            //modificamos directamente el offset de la textura(posicion/desplazamiento)
            GetComponent<Renderer>().material.mainTextureOffset = new Vector2(posicion, 0);
        }
    }

 
    //aumenta la velocidad del scroll al aumentar la puntuacion.
    void aumentoVelocidadScroll()
    {
        for (; PuntuacionTiempo.puntuacionTiempo >= limiteAumentoVelocidad; velocidad += +0.025f)
        {
            limiteAumentoVelocidad += 5;
        }
    }
}
