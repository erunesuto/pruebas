using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonCargarEscena : MonoBehaviour
{

    public string nombreEscenaParaCargar = "GameScene";

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
        //cada vez que se pulse un boton la puntuacioon actual se iguala a 0
        //evita que se guarde/vea la puntuacion en el marcador con la actualizacion de aumento de velocidad por puntuacion
        Puntuacion.puntuacion = 0;
        PuntuacionTiempo.puntuacionTiempo = 0;
        PuntuacionGravedad.puntuacionGravedad = 0;

        //detiene el audio de la camara y luego reproduce el del boton jugar
        Camera.main.GetComponent<AudioSource>().Stop();
        GetComponent<AudioSource>().Play();
        Invoke("CargarNivelJuego", GetComponent<AudioSource>().clip.length);
    }

    void CargarNivelJuego()
    {
        SceneManager.LoadScene(nombreEscenaParaCargar);
    }
}
