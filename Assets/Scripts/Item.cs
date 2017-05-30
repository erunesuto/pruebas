using UnityEngine;

public class Item : MonoBehaviour {

    public int puntosGanados = 5;
    public AudioClip itemSoundClip;
    public float itemSoundVolume = 3f;

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
            //GetComponent<AudioSource>().Play();
            NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", puntosGanados);
            
            
            //empieza a reproducir el itemSoundClip(inspector) en la posicion de la camara con el volumen itemSoundVolume
            AudioSource.PlayClipAtPoint(itemSoundClip, Camera.main.transform.position, itemSoundVolume);

        }
        Destroy(gameObject);
    }
}
