using UnityEngine;

public class GeneradorTiempo : MonoBehaviour
{

    //En el array obj guardamos diferentes objetos(prefabs de triangulo,cuadrado,etc... para luego instanciarlos/generarlos
    public GameObject[] obj;
    public float tiempoMin = 2f;
    public float tiempoMax = 4f;
    private bool fin = false;

    // Use this for initialization
    void Start()
    {
        //esta observando la notificacion "PersonajeEmpiezaACorrer",cuando es true entonces activa la notificacion
        NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeEmpiezaACorrer");
        NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");

    }

    void PersonajeHaMuerto()
    {
        fin = true;
    }

    // Update is called once per frame
    void Update()
    {

    


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
}
