using UnityEngine;
using UnityEngine.SceneManagement;

//NO USADO

public class BotonJugar : MonoBehaviour
{
    //SE HA MODIFICADO PARA HACER PRUEBAS

    //public AudioClip itemSoundClip;
    //public float itemSoundVolume = 1f;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnMouseDown()
    {
        //si falla cambiar el collider2D por uno 3D
        //fallo nombre
        //detiene el audio de la camara y luego reproduce el del boton jugar
        //Camera.main.GetComponent<AudioSource>().Stop();
        //AudioCenter.loadSound(Application.dataPath + "/Sounds/PulsarSound");


        GetComponent<AudioSource>().Play();
        //AudioSource.PlayClipAtPoint(itemSoundClip, Camera.main.transform.position, itemSoundVolume);

        //Carga el nivel del juego una vez acabado el audio 
        //Invoke("CargarNivelJuego", GetComponent<AudioSource>().clip.length);
        
        //antiguo
        //Application.LoadLevel("game scene");
    }

    void CargarNivelJuego()
    {
        SceneManager.LoadScene("game scene");
    }
}
