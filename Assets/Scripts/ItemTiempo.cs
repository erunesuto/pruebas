using UnityEngine;


//modificacion del script Item.cs para adaptarlo al modo de juego por tiempo
public class ItemTiempo : MonoBehaviour
{

    public int puntosGanadosTiempo = 1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        //Si el tag del collider es jugador se notifica y se incrementan los puntos si no se destruye el objeto sn sumar nada
        if (collider.tag == "Player")
        {
            NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntosTiempo", puntosGanadosTiempo);
        }
        Destroy(gameObject);
    }
}
