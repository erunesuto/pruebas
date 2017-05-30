using UnityEngine;

public class Generador : MonoBehaviour {

    //En el array obj guardamos diferentes objetos(prefabs de triangulo,cuadrado,etc... para luego instanciarlos/generarlos
    public GameObject[] obj;
    public float tiempoMin = 2f;
    public float tiempoMax = 4f;
    float tiempoReducido = 0.05f;
    public int limiteReduccionGeneracion=0;
    private bool fin = false;


    

    // Use this for initialization
    void Start () {
        //esta observando la notificacion "PersonajeEmpiezaACorrer",cuando es true entonces activa la notificacion
        NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeEmpiezaACorrer");
        NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");


        //TESTEO BORRAR LUEGO
        tiempoMax = 3.6f;
    }

    void PersonajeHaMuerto()
    {
        fin = true;
    }

    // Update is called once per frame
    void Update () {

        reducirTiempoGeneracion();
        reducirTiempoGeneracionTiempo();


    }
    //cuando la notificacion de que el pj esta corriendo se activa se entra en el metodo/funcion y se empiezan a generar items
    void PersonajeEmpiezaACorrer(Notification notificacion)
    {
        Generar();
    }

    void Generar()
    {
        if (!fin)
        {
            //instancia/genera un objeto aleatorio entre la posicion 0 y obj.Length(sin contar este ultimo)
            //transform.position= la posicion donde se va a instanciar, la posicion del componente transform
            //Quaternion.identity = la rotacion del objeto, concretamente, sin rotacion.
            Instantiate(obj[Random.Range(0, obj.Length)], transform.position, Quaternion.identity);
            //Invoca el metodo generar de forma aleatoria entre tiempoMIn y tiempoMax
            Invoke("Generar", Random.Range(tiempoMin, tiempoMax));
        }
    }


     //UNIR LA REDUCCION DE TIEMPO EN UNA SOLA FUNCION
    //Reduce el tiempo de genercion de items al aumentar la puntuacion
    
    void reducirTiempoGeneracion() {
        for (; Puntuacion.puntuacion >= limiteReduccionGeneracion; tiempoMax -= tiempoReducido)
        {
            for (; Puntuacion.puntuacion >= limiteReduccionGeneracion; tiempoMin -= tiempoReducido)
            {
                limiteReduccionGeneracion += 10;
            }
        }
    }

    //Reduce el tiempo de genercion de items al aumentar la puntuacion modo por tiempo
    void reducirTiempoGeneracionTiempo()
    {
        for (; PuntuacionTiempo.puntuacionTiempo >= limiteReduccionGeneracion; tiempoMax -= tiempoReducido)
        {
            for (; PuntuacionTiempo.puntuacionTiempo >= limiteReduccionGeneracion; tiempoMin -= tiempoReducido)
            {
                limiteReduccionGeneracion += 5;
            }
        }
        
        
    }
}

